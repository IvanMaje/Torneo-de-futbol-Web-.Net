const ham = document.getElementById('ham');
const menu = document.getElementById('enlaces_menu');
const nav = document.getElementById('nav');
const logo = document.getElementById('logo');
const lineas_ham = document.querySelectorAll('.ham span');

ham.addEventListener('click', () => {
    menu.classList.toggle('activado');
    nav.classList.toggle('nav_colorido');
    logo.classList.toggle('logo_fondo_colorido');
    lineas_ham.forEach(barra => barra.classList.toggle('cambio'));
})