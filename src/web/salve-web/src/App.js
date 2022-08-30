import './App.css';
import React from 'react';
import axios from "axios";
import Clinics from './Components/Clinics';
import Patients from './Components/Patients';

function App() {
  const [patients, setPatients] = React.useState([]);
  const [clinics, setClinics] = React.useState([]);

  React.useEffect(() => {
    axios
      .get("https://localhost:7289/clinics")
      .then((response) => setClinics(response.data));
  }, []);

  const handleChange = function(id){
      axios
        .get(`https://localhost:7289/clinics/${id}/patients`)
        .then((response) => setPatients(response.data))
        .catch();
  }
  return (
    
    <div className="App">
      <h1>
        Salve Technical Test
      </h1>
      <Clinics data={clinics} onClinicSelected={(id) => handleChange(id)} />
      <Patients data={patients} />
    </div>
  );
}

export default App;
