import { Injectable } from "@angular/core";
import { KoffieBattle } from "./koffie-battle.model";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs/internal/Observable";
import { catchError, map, tap } from "rxjs/operators";

@Injectable({
  providedIn: "root"
})
export class KoffieBattleService {
  formData: KoffieBattle;
  public KoffieVerkocht: KoffieBattle[];

  readonly rootURL = "https://localhost:44366/";
  list: KoffieBattle;

  constructor(private http: HttpClient) {}

  postKoffieBattle(formData: KoffieBattle) {
    return this.http.post(this.rootURL + "post", formData);
  }
}
