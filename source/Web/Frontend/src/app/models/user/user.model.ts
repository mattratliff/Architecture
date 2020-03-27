import { FullNameModel } from "./fullname.model";

export class UserModel {
    id!: number;
    fullName = new FullNameModel();
    emailValue!: string;
}
