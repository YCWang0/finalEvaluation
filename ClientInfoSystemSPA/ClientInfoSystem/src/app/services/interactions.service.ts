import { ApiService } from './api.service';
import { Injectable } from '@angular/core';
import { Interaction } from '../models/interaction';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InteractionsService {

  constructor(private apiService:ApiService) { 
  }
  getInteractByEmpId(id:number):Observable<Interaction[]>{
    return this.apiService.getAll(`${'Interactions/InteractionsByEmpId/'}${id}`);
  }
  getInteractByCliId(id:number): Observable<Interaction>{
    return this.apiService.getOne(`${'Interactions/InteractionsByClientId/'}${id}`);
  }

}
