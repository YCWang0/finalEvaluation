import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule}from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DetailComponent } from './detail/detail.component';
import { HttpClient } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {
  NgbCarouselModule,
  NgbCollapseModule,
  NgbDropdownModule,
  NgbModalModule,
  NgbPaginationModule,
  NgbTabsetModule,
  NgbAlertModule
} from "@ng-bootstrap/ng-bootstrap";
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule,
    NgbCarouselModule,
    NgbCollapseModule,
    NgbDropdownModule,
    NgbModalModule,
    NgbPaginationModule,
    NgbTabsetModule,
    NgbAlertModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
