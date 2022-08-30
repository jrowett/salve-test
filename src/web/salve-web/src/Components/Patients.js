import React from "react";
import BootstrapTable from 'react-bootstrap-table-next';
import paginationFactory from 'react-bootstrap-table2-paginator';
import moment from 'moment';

function Patients(props) {
    const columns = [
         {
        dataField: 'firstName',
        text: 'First Name',
        sort: true
      }, {
        dataField: 'lastName',
        text: 'Last Name',
        sort: true
      }, {
        dataField: 'dateOfBirth',
        text: 'Date Of Birth ',
        sort: true,
        formatter: function (cell, row, rowIndex, formatExtraData) { return moment(cell).format('DD/MM/YYYY') }
      }
    ];

    

  return (
    props.data.length > 0 
    ?    <BootstrapTable keyField='id' data={ props.data } columns={ columns } pagination={ paginationFactory() } />
    : <div>No patient records to display</div>    
  );
}

export default Patients;