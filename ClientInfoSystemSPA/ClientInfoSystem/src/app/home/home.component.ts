import { EmployeeService } from './../services/employee.service';
import { Employee } from './../models/employee';
import { ClientService } from './../services/client.service';
import { Client } from './../models/client';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  client:Client[];
  employee: Employee[];
  constructor(private clientService:ClientService,private employeeService:EmployeeService) { }

  ngOnInit(){
    this.clientService.getAllClients()
      .subscribe(c=>{
        this.client=c;
        console.log('clientsssssssss');
      console.log(this.client);
      });

      this.employeeService.getAllEmployee()
      .subscribe(e=>{
        this.employee=e;
        console.log('employeeeeeeeee');
        console.log(this.employee);
      });


  }
}
