import React, { useState, useEffect } from "react";
import { Line } from "react-chartjs-2";
import {
  Chart as ChartJS,
  LineElement,
  CategoryScale,
  LinearScale,
  ChartData,
  ChartOptions,
} from "chart.js";
import "chart.js/auto";
import "./components.css";

ChartJS.register(LineElement, CategoryScale, LinearScale);

const Oxchart: React.FC = () => {
  const [data, setData] = useState<ChartData<"line">>({
    labels: Array.from({ length: 100 }, (_, i) => i.toString()),
    datasets: [
      {
        label: "Smooth Wave",
        data: Array.from({ length: 100 }, () => 0),
        borderColor: "green",
        borderWidth: 2,
        fill: false,
      },
    ],
  });

  useEffect(() => {
    let x = 0;
    const generateSmoothPoint = (): number => {
      x += 0.1;
      return Math.sin(x) * 0.5 + Math.sin(x * 0.5) * 0.3;
    };

    // Intervalo para actualizar los datos del gráfico
    const interval = setInterval(() => {
      setData((prevData) => {
        const newData = [...(prevData.datasets[0].data as number[])];
        newData.push(generateSmoothPoint());
        newData.shift();

        return {
          ...prevData,
          datasets: [{ ...prevData.datasets[0], data: newData }],
        };
      });
    }, 100);

    return () => clearInterval(interval);
  }, []);

  const options: ChartOptions<"line"> = {
    responsive: true,
    animation: { duration: 0 },
    scales: {
      x: { display: false },
      y: {
        min: -1,
        max: 1,
        grid: { color: "rgba(0, 255, 0, 0.3)" },
        ticks: { display: false },
      },
    },
    plugins: {
      legend: { display: false },
    },
  };

  return (
    <div className="h-1/3">
      <Line data={data} options={options} className="lineOx" />
    </div>
  );
};

export default Oxchart;
