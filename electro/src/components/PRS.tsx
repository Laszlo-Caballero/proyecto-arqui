import React, { useEffect, useState } from "react";
import { Line } from "react-chartjs-2";
import "./components.css";
import {
  Chart as ChartJS,
  LineElement,
  CategoryScale,
  LinearScale,
  ChartData,
  ChartOptions,
} from "chart.js";
import "chart.js/auto";

ChartJS.register(LineElement, CategoryScale, LinearScale);

const PRSChart: React.FC = () => {
  const [data, setData] = useState<ChartData<"line">>({
    labels: Array.from({ length: 100 }, (_, i) => i.toString()),
    datasets: [
      {
        label: "ECG Waveform",
        data: Array.from({ length: 100 }, () => 0),
        borderColor: "green",
        borderWidth: 2,
        fill: false,
      },
    ],
  });
  useEffect(() => {
    const generateECGPoint = (): number => {
      const randomValue = Math.sin(Math.random() * 2 * Math.PI);
      return randomValue > 0.7 ? 1 : randomValue < -0.7 ? -1 : randomValue;
    };

    const interval = setInterval(() => {
      setData((prevData) => {
        const newData = [...(prevData.datasets[0].data as number[])];
        newData.push(generateECGPoint());
        newData.shift();

        return {
          ...prevData,
          datasets: [{ ...prevData.datasets[0], data: newData }],
        };
      });
    }, 100);

    return () => clearInterval(interval);
  }, []);

  // Opciones de estilo para el gráfico
  const options: ChartOptions<"line"> = {
    responsive: true,

    animation: {
      duration: 0,
    },
    scales: {
      x: {
        display: false,
      },
      y: {
        min: -1.5,
        max: 1.5,
        grid: {
          color: "rgba(0, 255, 0, 0.3)",
        },
        ticks: {
          display: false,
        },
      },
    },
    plugins: {
      legend: {
        display: false,
      },
    },
  };

  return (
    <div className="h-1/3">
      <Line data={data} options={options} className="linePRS" />
    </div>
  );
};

export default PRSChart;
