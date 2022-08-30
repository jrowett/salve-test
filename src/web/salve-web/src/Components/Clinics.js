import React from "react";
import axios from "axios";
import Dropdown from 'react-bootstrap/Dropdown';

function Clinics(props) {

  return (
    <div>
    <Dropdown onSelect={(e) => props.onClinicSelected(e)}>
      <Dropdown.Toggle id="dropdown-clinic">
        Select Clinic
      </Dropdown.Toggle>

      <Dropdown.Menu>
      {props.data.map((clinic) => (
        <Dropdown.Item eventKey={clinic.id} key={clinic.id} value={clinic.id}>{clinic.name}</Dropdown.Item>
      ))}
      </Dropdown.Menu>
    </Dropdown>
    </div>
  );
}

export default Clinics;