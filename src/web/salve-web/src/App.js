import './App.css';
import React from 'react';
import axios from "axios";
import Clinics from './Components/Clinics';
import Patients from './Components/Patients';

function App() {
  const [clinicId, setClinicId] = React.useState(0);
  const [patients, setPatients] = React.useState([]);

  const handleChange = function(id){
    setClinicId(id);

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
      <Clinics onChange={(id) => handleChange(id)} />
      <Patients data={patients} />
    </div>
  );
}

export default App;
