import './App.css';
import { useState } from 'react';

function App() {
  const [data, setData] = useState([]);
  const getQuote = async () => {
    const response = await fetch("https://localhost:7265/Simple");
    const deserializedJSON = await response.json();
    setData(deserializedJSON);
  }
  const sendData = async (e) => {
    e.preventDefault();
    const request = {name: e.target.value};
    const response = await fetch("https://localhost:7265/Simple",
    {
      method: 'POST', 
      body: JSON.stringify(request)
    })
    const deserializedJSON = await response.json();
    setData(deserializedJSON);
  }

  return (
    <div className="App">
      <button onClick={getQuote}>Get Data from SimpleApi</button>
      {data.map((item) => {
        return (
        <div>{item.name}</div>)
      })}
      <form  onSubmit={sendData}>
        <input placeholder='Write Name...' type="text" name='name'/>
        <button>Submit</button>
      </form>
    </div>
  );
}

export default App;
