import { Server } from "http";
import { Server as socket } from "socket.io";
import mqtt from "mqtt";

export function initializeSocket(server: Server) {
  const io = new socket(server, {
    cors: {
      origin: "http://localhost:5173",
    },
  });
  const client = mqtt.connect(
    "tls://1da777a57f014b96862f008f8b555fee.s1.eu.hivemq.cloud:8883",
    {
      username: "yo",
      password: "123",
    }
  );
  client.subscribe("pulso");
  client.subscribe("presion");
  client.subscribe("oxigeno");

  client.on("message", (topic, message) => {
    if (topic === "pulso") {
      io.emit("pulso", message.toString());
    }

    if (topic === "presion") {
      io.emit("presion", message.toString());
    }

    if (topic === "oxigeno") {
      io.emit("oxigeno", message.toString());
    }
  });
}
