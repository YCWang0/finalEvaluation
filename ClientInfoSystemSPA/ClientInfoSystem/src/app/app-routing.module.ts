import { DetailComponent } from './detail/detail.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {path:'Interactions/InteractionsByClientId/:id',component:DetailComponent},
  {path:'Interactions/GetInteractionsByEmpId/:id',component:DetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
