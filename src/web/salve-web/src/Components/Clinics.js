import React from "react";
import axios from "axios";
import Dropdown from 'react-bootstrap/Dropdown';

function Clinics(props) {
  const [clinics, setClinics] = React.useState([]);

  React.useEffect(() => {
    axios
      .get("https://localhost:7289/clinics")
      .then((response) => setClinics(response.data));
  }, []);

  return (
    <div>
    <Dropdown onSelect={(e) => props.onChange(e)}>
      <Dropdown.Toggle id="dropdown-clinic">
        Select Clinic
      </Dropdown.Toggle>

      <Dropdown.Menu>
      {clinics.map((clinic) => (
        <Dropdown.Item eventKey={clinic.id} key={clinic.id} value={clinic.id}>{clinic.name}</Dropdown.Item>
      ))}
      </Dropdown.Menu>
    </Dropdown>
    </div>
  );
}

export default Clinics;