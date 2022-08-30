import React from "react";

function Patients(props) {

  return (
    <div>
        <ul>
            {props.data.map((patient) => (
                <li>{patient.firstName} {patient.lastName}</li>
      ))}
      </ul>
    </div>
  );
}

export default Patients;