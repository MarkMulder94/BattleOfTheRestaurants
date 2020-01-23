import { Component, OnInit, Inject } from "@angular/core";
import { KoffieBattle } from "src/app/shared/Koffie/koffie-battle.model";
import { HttpClient } from "@angular/common/http";
import { KoffieBattleService } from "src/app/shared/Koffie/koffie-battle.service";
import { createWriteStream } from "fs";

@Component({
  selector: "app-koffie-battle",
  templateUrl: "./koffie-battle.component.html",
  styleUrls: ["./koffie-battle.component.css"]
})
export class KoffieBattleComponent implements OnInit {
  public KoffieVerkocht: KoffieBattle[];

  readonly rootURL = "https://localhost:44366/";

  constructor(private service: KoffieBattleService, private http: HttpClient) {}

  ngOnInit() {
    this.getKoffieBattle();
  }
  onSubmit() {
    this.getKoffieBattle();
    console.log(this.getKoffieBattle());
  }

  getKoffieBattle() {
    this.http.get<KoffieBattle[]>(this.rootURL + "koffie").subscribe(result => {
      this.KoffieVerkocht = result;
    });
  }
}
