import { Component } from "@angular/core";
import { AppUserService } from "src/app/services/user.service";
import { UserModel } from "src/app/models/user/user.model";

@Component({ selector: "app-list", templateUrl: "./list.component.html" })
export class AppListComponent {
    users = new Array<UserModel>();

    constructor(private readonly appUserService: AppUserService) {
        this.appUserService.list().subscribe((users) => this.users = users);
    }
}
