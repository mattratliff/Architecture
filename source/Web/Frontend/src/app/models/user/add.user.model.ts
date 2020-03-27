import { SignInModel } from "../auth/signIn.model";
import { UserModel } from "./user.model";

export class AddUserModel extends UserModel {
    signIn!: SignInModel;
}
