let i = 5;
console.log(i);


let egesz : number = 5;
console.log(egesz);

let v1 : boolean;
v1 = true;
console.log(v1);

let v2 : string = "kezdőérték";
console.log(v2);

let t1 : number[] = [];
t1.push(1, 2, 3);
console.log(t1);

let v3 : any[] = [1, 2, "kezd"];
console.log(v3);

let v : any = true;
v = "string";
console.log(v);

let ns : number | string;
ns = 15;
ns = "string";
console.log(ns);

const nevek : string[] = [];
nevek.push("Alma");

const nevsor : readonly string[] = ["Tamás"];
console.table(nevsor);

// class User {
//   name: string;
//   age: number;
//   haziallat: string;

//   constructor(name: string, age: number, haziallat: string) {
//     this.name = name;
//     this.age = age;
//     this.haziallat = haziallat;
//   }
// }

// const user1 = new User("Alma", 15, "Béka");
// const user2 = new User("Béka", 214, "Alma");

// console.table(user2);

import { User } from "./User";

// let obj : User = {
//   nev: "Béla",
//   eletkor: 22,
//   haziallat: null
// }

// obj.haziallat = 'Buksi';

let obj : User = new User("Béla", 15, "Alma");
let obj2 = new User("Kasd", 15, "ASdasd");

console.table(obj);
console.table(obj2);

obj.szuletesnap();
console.table(obj);

document.addEventListener("DOMContentLoaded", init);

function init() {
  document.getElementById("szamForm")?.addEventListener("submit", szamKuldes);
  document.getElementById("szamlalo")?.addEventListener('input', szamChange);
}

function szamKuldes(e : SubmitEvent) {
  let szam = parseInt((document.getElementById("szamlalo") as HTMLInputElement).value);
  if (szam < 0) {
    document.getElementById('negyzet')!.textContent = "Nem lehet negatív!";
  }
  else {
    szamChange();
  }
  e.preventDefault();
}

function szamChange() {
  let szam = parseInt((document.getElementById("szamlalo") as HTMLInputElement).value)
  let negyzet = szam * szam;
  document.getElementById('negyzet')!.textContent = negyzet.toString();
}