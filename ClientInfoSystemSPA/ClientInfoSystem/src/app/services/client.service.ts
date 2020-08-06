import { ApiService } from './api.service';
import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class ClientService {

  constructor(private apiService:ApiService) { }

  getAllClients(){
    return this.apiService.getAll("home/allClients");
  }


}
