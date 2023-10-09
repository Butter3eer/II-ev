import { Userinterface } from "./Userinterface";

export class User implements Userinterface {
    nev: string = "";
    eletkor: number = 0;
    haziallat : any = "Cirmos";

    constructor(nev: string, eletkor: number, haziallat: any) {
        this.nev = nev;
        this.eletkor = eletkor;
        this.haziallat = haziallat;
    }

    szuletesnap() : void {
        this.eletkor++;
    }
}