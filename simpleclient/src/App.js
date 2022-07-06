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
    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");
    const body = JSON.stringify({
      Name:e.target["name"].value
    })
    console.log(body)
    const requestOptions = {
      method: 'POST',
      mode: 'cors',
      headers: myHeaders,
      body: body,
      redirect: 'follow'
    };
    const response = await fetch("https://localhost:7265/Simple", requestOptions)
    const deserializedJSON = await response.json();
    console.log(deserializedJSON)
    setData(deserializedJSON);
  }

  return (
    <div className="App">
      <button onClick={getQuote}>Get Data from SimpleApi</button>
      {data.map((item) => {
        return (
          <div>{item.name}</div>)
      })}
      <form onSubmit={sendData}>
        <input placeholder='Write Name...' type="text" name='name' />
        <button>Submit</button>
      </form>
    </div>
  );
}

export default App;
