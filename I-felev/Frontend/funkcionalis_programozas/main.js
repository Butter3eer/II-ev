import './style.css';

function init() {

}

const fv = init;
const fv2 = function() {
  fv();
}

document.addEventListener('DOMContentLoaded', function() {
  console.log("Anonim függvény, ami akkor hívódik meg, amikor az oldal betöltődött.")
});

const arrowFunction = (parameter1, parameter2, parameterN) => {
  console.log(`parameter1: ${parameter1}, parameter2: ${parameter2}, parameterN: ${parameterN}`);
};

document.addEventListener('DOMContentLoaded', () => {
  arrowFunction(1, 2, 3);
  obj.logThis1();
  obj.logThis2();
});


const obj = {
  logThis1: function() {
    console.log(this);
  },
  
  logThis2: () => {
    console.log(this);
  }
}

document.addEventListener('DOMContentLoaded', () => {
  const gomb = document.getElementById('gomb');
  gomb.addEventListener('click', () => {
    alert("Hello world!");
  });
});

const lista = []; //DRY - Dont Repeat Yourself

lista.push({
  vezetekNev: "Gipsz",
  keresztNev: "Jakab",
  eletkor: 21
});

lista.push({
  vezetekNev: "Teszt",
  keresztNev: "Elek",
  eletkor: 42
});

lista.push({
  vezetekNev: "Káb",
  keresztNev: "Elek",
  eletkor: 17
});

const idosebbMint20 = lista.filter(szemely => {
  return szemely.eletkor > 20
});

console.log(idosebbMint20);

function kivalogato(szemely)  {
  return szemely.eletkor > 20;
};

const idosebbMint20_2 = lista.filter(kivalogato);

console.log(idosebbMint20_2);

const idosebbMint20Gipsz = lista.filter(szemely => szemely.eletkor > 20 && szemely.vezetekNev == "Gipsz");

console.log(idosebbMint20Gipsz);

const nevek = lista.map(szemely => {
  return szemely.vezetekNev + " " + szemely.keresztNev;
});

console.log(nevek);

const idosebbMint20TeljesNev = lista
  .filter(szemely => szemely.eletkor > 20)
  .map(szemely => szemely.vezetekNev + " " + szemely.keresztNev);

console.log(idosebbMint20TeljesNev);