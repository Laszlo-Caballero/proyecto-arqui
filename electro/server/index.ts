import express from "express";
import { createServer } from "http";
import { initializeSocket } from "./socket/socketHandle";
import cors from "cors";

const app = express();
const server = createServer(app);
initializeSocket(server);

const port = 3000;

app.use(
  cors({
    origin: "http://localhost:5173",
    credentials: true,
  })
);

server.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
