import { useState } from "react";
import { io } from "socket.io-client";

export default function useSocket() {
  const socket = io("localhost:3000");
  const [pulso, setPulse] = useState(0);
  const [presion, setPresion] = useState(0);
  const [oxigeno, setOxigeno] = useState(0);

  socket.on("pulso", (pulso: number) => {
    setPulse(pulso);
  });

  socket.on("presion", (presion: number) => {
    setPresion(presion);
  });

  socket.on("oxigeno", (oxigeno: number) => {
    setOxigeno(oxigeno);
  });

  return {
    pulso,
    presion,
    oxigeno,
  };
}
