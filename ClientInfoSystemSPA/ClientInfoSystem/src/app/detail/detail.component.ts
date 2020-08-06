import { InteractionsService } from './../services/interactions.service';
import { Interaction } from './../models/interaction';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from './../services/employee.service';
import { Employee } from './../models/employee';
import { ClientService } from './../services/client.service';
import { Client } from './../models/client';

@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent implements OnInit {
 interaction:Interaction;
  id:number;
  constructor(private interactionsService: InteractionsService  ,private route: ActivatedRoute,) { }

  ngOnInit() {
    this.route.paramMap.subscribe(
      params=>{
        this.id=+params.get('id');
        this.getAllIns();
      }
    );
  }
  private getAllIns(){
    this.interactionsService.getInteractByCliId(this.id)
    .subscribe(i=>{
      this.interaction=i;
      console.log(this.interaction)
    });
  }

  }
  
