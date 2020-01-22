import { Injectable } from "@angular/core";
import { KoffieBattle } from "./koffie-battle.model";

@Injectable({
  providedIn: "root"
})
export class KoffieBattleService {
  formData: KoffieBattle;
  constructor() {}
}
