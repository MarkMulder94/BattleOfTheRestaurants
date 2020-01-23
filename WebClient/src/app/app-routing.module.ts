import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { JaarComponent } from "./koffie/JaarOverzicht/jaaroverzicht.component";
import { KoffieBattleComponent } from "./koffie/battle/koffie-battle/koffie-battle.component";

const routes: Routes = [
  { path: "current", component: KoffieBattleComponent },
  { path: "jaar", component: JaarComponent },
  { path: "jaar/:restaurant", component: JaarComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
