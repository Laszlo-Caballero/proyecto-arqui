namespace mq
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEnviar = new Boton();
            btnConect = new Boton();
            btnSalir = new Boton();
            btnIniciar = new Boton();
            btnParar = new Boton();
            pbData = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCardiaco = new Label();
            lblPresion = new Label();
            lblOxigeno = new Label();
            pbECG = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbECG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Black;
            btnEnviar.Borde = 2;
            btnEnviar.Color = Color.RoyalBlue;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.ForeColor = Color.RoyalBlue;
            btnEnviar.Location = new Point(666, 367);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Radio = 10;
            btnEnviar.Size = new Size(112, 40);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnConect
            // 
            btnConect.BackColor = Color.Black;
            btnConect.Borde = 2;
            btnConect.Color = Color.RoyalBlue;
            btnConect.FlatAppearance.BorderSize = 0;
            btnConect.FlatStyle = FlatStyle.Flat;
            btnConect.ForeColor = Color.RoyalBlue;
            btnConect.Location = new Point(550, 367);
            btnConect.Name = "btnConect";
            btnConect.Radio = 10;
            btnConect.Size = new Size(110, 40);
            btnConect.TabIndex = 5;
            btnConect.Text = "CONECTAR";
            btnConect.UseVisualStyleBackColor = false;
            btnConect.Click += btnConect_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.Borde = 2;
            btnSalir.Color = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(292, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Radio = 10;
            btnSalir.Size = new Size(110, 40);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Black;
            btnIniciar.Borde = 2;
            btnIniciar.Color = Color.LimeGreen;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.LimeGreen;
            btnIniciar.Location = new Point(28, 367);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Radio = 10;
            btnIniciar.Size = new Size(110, 40);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.BackColor = Color.Black;
            btnParar.Borde = 2;
            btnParar.Color = Color.DarkOrange;
            btnParar.FlatAppearance.BorderSize = 0;
            btnParar.FlatStyle = FlatStyle.Flat;
            btnParar.ForeColor = Color.DarkOrange;
            btnParar.Location = new Point(159, 367);
            btnParar.Name = "btnParar";
            btnParar.Radio = 10;
            btnParar.Size = new Size(110, 40);
            btnParar.TabIndex = 8;
            btnParar.Text = "PARAR";
            btnParar.UseVisualStyleBackColor = false;
            btnParar.Click += btnParar_Click;
            // 
            // pbData
            // 
            pbData.Location = new Point(583, 15);
            pbData.Name = "pbData";
            pbData.Size = new Size(195, 342);
            pbData.TabIndex = 10;
            pbData.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(598, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 17);
            label1.TabIndex = 11;
            label1.Text = "PULSO CARDIACO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(595, 136);
            label2.Name = "label2";
            label2.Size = new Size(131, 17);
            label2.TabIndex = 12;
            label2.Text = "PRESION ARTERIAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(595, 240);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 13;
            label3.Text = "OXIGENO";
            // 
            // lblCardiaco
            // 
            lblCardiaco.AutoSize = true;
            lblCardiaco.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblCardiaco.ForeColor = SystemColors.Control;
            lblCardiaco.Location = new Point(612, 56);
            lblCardiaco.Name = "lblCardiaco";
            lblCardiaco.Size = new Size(67, 54);
            lblCardiaco.TabIndex = 14;
            lblCardiaco.Text = "64";
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresion.ForeColor = SystemColors.ButtonFace;
            lblPresion.Location = new Point(612, 166);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(89, 54);
            lblPresion.TabIndex = 15;
            lblPresion.Text = "114";
            // 
            // lblOxigeno
            // 
            lblOxigeno.AutoSize = true;
            lblOxigeno.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblOxigeno.ForeColor = SystemColors.ButtonFace;
            lblOxigeno.Location = new Point(619, 260);
            lblOxigeno.Name = "lblOxigeno";
            lblOxigeno.Size = new Size(67, 54);
            lblOxigeno.TabIndex = 16;
            lblOxigeno.Text = "92";
            // 
            // pbECG
            // 
            pbECG.BackColor = SystemColors.MenuText;
            pbECG.Location = new Point(12, 15);
            pbECG.Name = "pbECG";
            pbECG.Size = new Size(547, 341);
            pbECG.TabIndex = 17;
            pbECG.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(685, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(692, 266);
            label4.Name = "label4";
            label4.Size = new Size(48, 46);
            label4.TabIndex = 19;
            label4.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(790, 419);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pbECG);
            Controls.Add(lblOxigeno);
            Controls.Add(lblPresion);
            Controls.Add(lblCardiaco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbData);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(btnSalir);
            Controls.Add(btnConect);
            Controls.Add(btnEnviar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbECG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Boton btnEnviar;
        private Boton btnConect;
        private Boton btnSalir;
        private Boton btnIniciar;
        private Boton btnParar;
        private PictureBox pbData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCardiaco;
        private Label lblPresion;
        private Label lblOxigeno;
        private PictureBox pbECG;
        private PictureBox pictureBox1;
        private Label label4;
    }
}