import { Injectable } from "@angular/core";
import { KoffieBattle } from "./koffie-battle.model";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class KoffieBattleService {
  formData: KoffieBattle;
  readonly rootURL = "https://localhost:44366/";
  list: KoffieBattle;

  constructor(private http: HttpClient) {}

  postKoffieBattle(formData: KoffieBattle) {
    return this.http.post(this.rootURL + "post", formData);
  }
}
