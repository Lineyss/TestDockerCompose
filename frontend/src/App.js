import axios from "axios";
import React, { useState, useEffect } from "react";

const Url = "https://localhost:801/WeatherForecast";

const Weather = (props) => {
  return (
    <ul>
      <li>date: {props.date}</li>
      <li>temperatureC: {props.temperatureC}</li>
      <li>temperatureF: {props.temperatureF}</li>
      <li>summary: {props.summary}</li>
    </ul>
  );
};

function App() {
  const [weatherData, setWeatherData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    axios.get(Url)
      .then((res) => {
        setWeatherData(res.data);
        setLoading(false);
      })
      .catch((err) => {
        setError(err.message);
        setLoading(false);
      });
  }, []);

  return (
    <div className="App">
      <header className="App-header">
        {loading && <p>Loading...</p>}
        {error && <p>Error: {error}</p>}
        {weatherData.map((weather, index) => (
          <Weather {...weather} />
        ))}
      </header>
    </div>
  );
}

export default App;
