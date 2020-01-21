import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { ManagersComponent } from "./managers/managers.component";
import { ManagerListService } from "./shared/Manager/manager-list.service";
import { KoffieComponent } from "./koffie/koffie.component";

@NgModule({
  declarations: [AppComponent, ManagersComponent, KoffieComponent],
  imports: [BrowserModule, AppRoutingModule, FormsModule, NgbModule],
  providers: [ManagerListService],
  bootstrap: [AppComponent]
})
export class AppModule {}
