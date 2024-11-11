import ECGChart from "./components/ECG";
import Oxchart from "./components/OX";
import PRSChart from "./components/PRS";
import useSocket from "./hooks/sockethook";

function App() {
  const { pulso, oxigeno, presion } = useSocket();

  return (
    <main className="h-screen w-full flex flex-1 bg-black text-green-600">
      <section className="w-3/4 h-full">
        <ECGChart />
        <PRSChart />
        <Oxchart />
      </section>{" "}
      <section className="w-1/4 flex flex-col h-full justify-center">
        <div className="h-1/3 flex flex-col p-4 gap-y-8 border-2 border-blue-200 justify-center">
          <h2 className="text-6xl font-bold">ECG</h2>
          <p className="text-5xl font-bold">{pulso.toString()}</p>
        </div>
        <div className="h-1/3 flex flex-col p-4 gap-y-8 border-2 border-blue-200 justify-center">
          <h2 className="text-6xl font-bold">Presion Alterial</h2>
          <p className="text-5xl font-bold">{presion.toString()}</p>
        </div>{" "}
        <div className="h-1/3 flex flex-col p-4 gap-y-8 border-2 border-blue-200 justify-center">
          <h2 className="text-6xl font-bold">Oxigeno</h2>
          <p className="text-5xl font-bold">{oxigeno.toString()}%</p>
        </div>
      </section>
    </main>
  );
}

export default App;
