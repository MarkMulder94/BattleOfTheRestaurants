import { Component, OnInit } from "@angular/core";
import { KoffieBattleService } from "../shared/Koffie/koffie-battle.service";

import { NgForm } from "@angular/forms";
import { ThrowStmt } from "@angular/compiler";

@Component({
  selector: "app-koffie",
  templateUrl: "./koffie.component.html",
  styles: []
})
export class KoffieComponent implements OnInit {
  constructor(private service: KoffieBattleService) {}

  ngOnInit() {
    this.resetForm;
  }

  resetForm(form?: NgForm) {
    if (form != null) form.resetForm();
    this.service.formData = {
      KoffieBattleId: 0,
      NameManager: "",
      NameRestaurant: "Heerde",
      Groot: 0,
      Medium: 0,
      datum: ""
    };
  }

  onSubmit(form: NgForm) {
    this.service.postKoffieBattle(form.value).subscribe(
      res => {
        this.resetForm(form);
        console.log(res);
      },
      err => {
        console.log(err);
      }
    );
  }
}
