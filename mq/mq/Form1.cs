using HiveMQtt.Client;
using HiveMQtt.Client.Events;
using HiveMQtt.Client.Options;
using HiveMQtt.MQTT5.Types;
using mq.Clases;

namespace mq
{
    public partial class Form1 : Form
    {
        private HiveMQClient client;
        private String datos = "";
        private Animacion ecgAnimation;
        private Dibujar dataPainter;
        public Form1()
        {
            InitializeComponent();
            ecgAnimation = new Animacion();
            dataPainter = new Dibujar();

            ecgAnimation.OnInvalidate += (sender, e) => pbECG.Invalidate();
            ecgAnimation.Start();

            pbECG.Paint += new PaintEventHandler(pbECG_Paint);
            pbData.Paint += new PaintEventHandler(pbData_Paint);
        }

        private void recibir(object? sender, OnMessageReceivedEventArgs e)
        {
            string topic = e.PublishMessage.Topic;
            string message = e.PublishMessage.PayloadAsString;

            if (topic == "pulso")
                this.Invoke(new Action(() => lblCardiaco.Text = message));
            else if (topic == "presion")
                this.Invoke(new Action(() => lblPresion.Text = message));
            else if (topic == "oxigeno")
                this.Invoke(new Action(() => lblOxigeno.Text = message));
        }
        private async void btnConect_Click(object sender, EventArgs e)
        {
            var options = new HiveMQClientOptionsBuilder().
                          WithBroker("1da777a57f014b96862f008f8b555fee.s1.eu.hivemq.cloud").
                          WithUserName("yo").
                          WithPassword("123").
                          WithPort(8883).
                          WithUseTls(true).
                          Build();

            client = new HiveMQClient(options);

            // Setup an application message handlers BEFORE subscribing to a topic
            client.OnMessageReceived += recibir;

            // Connect to the MQTT broker
            var connectResult = await client.ConnectAsync().ConfigureAwait(false);

            // Configure the subscriptions we want and subscribe
            var builder = new SubscribeOptionsBuilder();
            builder.WithSubscription("pulso", QualityOfService.AtLeastOnceDelivery)
                   .WithSubscription("presion", QualityOfService.ExactlyOnceDelivery)
                   .WithSubscription("oxigeno", QualityOfService.AtLeastOnceDelivery);
            var subscribeOptions = builder.Build();
            var subscribeResult = await client.SubscribeAsync(subscribeOptions);
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            //var publishResult1 = await client.PublishAsync("topico1", "Hello 1");
            //var publishResult2 = await client.PublishAsync("topico2", "Hello 2");
            var publishResult1 = await client.PublishAsync("pulso", lblCardiaco.Text);
            var publishResult2 = await client.PublishAsync("presion", lblPresion.Text);
            var publishResult3 = await client.PublishAsync("oxigeno", lblOxigeno.Text);
        }

        private void pbECG_Paint(object sender, PaintEventArgs e)
        {
            ecgAnimation.Animar(e, pbECG);
        }


        private void pbData_Paint(object sender, PaintEventArgs e)
        {
            dataPainter.DrawData(e, pbData);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            ecgAnimation.Stop();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ecgAnimation.Start();
        }
    }
}