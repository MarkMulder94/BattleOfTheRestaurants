import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { ManagersComponent } from "./managers/managers.component";
import { ManagerListService } from "./shared/Manager/manager-list.service";
import { KoffieComponent } from "./koffie/koffie.component";
import { KoffieBattleService } from "./shared/Koffie/koffie-battle.service";
import { KoffieBattleComponent } from './koffie/battle/koffie-battle/koffie-battle.component';

@NgModule({
  declarations: [AppComponent, ManagersComponent, KoffieComponent, KoffieBattleComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    NgbModule,
    HttpClientModule
  ],
  providers: [ManagerListService, KoffieBattleService],
  bootstrap: [AppComponent]
})
export class AppModule {}
