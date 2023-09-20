import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap/dist/js/bootstrap.bundle';

function registration() {
    //alert("Ide kerül a regisztráció"); 
    let neved = document.getElementById("inputNeved").value;
    document.getElementById("hibaUzenet").style.color = "red";
    if (neved == "") {
        document.getElementById("hibaUzenet").innerText = 
        "Név megadása kötelező!";
    } else if (neved.length < 5) {
        document.getElementById("hibaUzenet").innerText = 
        "Nem lehet 5 karakternél rövidebb a név!";
    } else {
        document.getElementById("hibaUzenet").style.color = "green";
        document.getElementById("hibaUzenet").innerText =
            `Gratulálok a regisztrációhoz ${neved}!`;
    }
}

function init() {
    //document.getElementById("hibaUzenet").innerHTML = "<b>Félkövér</b>";
    //document.getElementById("hibaUzenet").innerText = "<b>Félkövér</b>";
    document.getElementById("gombFeldolgoz").addEventListener("click", registration);
}

document.addEventListener("DOMContentLoaded", init);