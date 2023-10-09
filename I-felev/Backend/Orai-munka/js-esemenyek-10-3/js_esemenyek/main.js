document.addEventListener("DOMContentLoaded", init);

function init() {
  window.addEventListener('resize', meret);
  document.getElementById('post-form').addEventListener("submit", formSubmit);
  document.getElementById('jelszo').addEventListener('change', passwordChange);
  document.getElementById('tartalom').addEventListener('input', contentChange);
  document.getElementById('jelszo').addEventListener('click', katt);
}

function katt(e) {
  console.log(e.currentTarget);
  console.log(e.currentTarget.value);
  console.log(e.currentTarget.id);
}

function meret() {
  console.log(window.outerWidth + 'x' + outerHeight);
}

function formSubmit(e) {
  let felNev = document.getElementById('felNev').value;
  if (felNev.length > 50) {
    e.preventDefault();
  }
}

function passwordChange() {
  console.log("A jelszó változott.");
}

function contentChange(e) {
  let tarHossz = e.currentTarget.value;
  document.getElementById('karakterek').innerText = tarHossz.length + `-/-50`;
  if (tarHossz.length > 50) {
    document.getElementById('karakterek').style.color = "red";
    document.getElementById('karakterek').style.fontWeight = 'bold';
  } else {
    document.getElementById('karakterek').style.color = null;
    document.getElementById('karakterek').style.fontWeight = null;
  }
}