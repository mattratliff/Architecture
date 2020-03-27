import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { AddUserModel } from "../models/user/add.user.model";
import { UpdateUserModel } from "../models/user/update.user.model";
import { UserModel } from "../models/user/user.model";

@Injectable({ providedIn: "root" })
export class AppUserService {
    constructor(private readonly http: HttpClient) { }

    add(model: AddUserModel) {
        return this.http.post<number>("Users", model);
    }

    delete(id: number) {
        return this.http.delete(`Users/${id}`);
    }

    get(id: number) {
        return this.http.get<UserModel>(`Users/${id}`);
    }

    list() {
        return this.http.get<UserModel[]>("Users");
    }

    update(model: UpdateUserModel) {
        return this.http.put(`Users/${model.id}`, model);
    }
}
