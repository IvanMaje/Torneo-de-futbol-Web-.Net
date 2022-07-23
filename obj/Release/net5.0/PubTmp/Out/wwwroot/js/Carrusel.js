const carrusel = document.getElementById("carrusel");
let carruselImagenes = document.querySelectorAll(".carrusel_imagen");
let ultimaImagen = carruselImagenes[carruselImagenes.length - 1];

const botonIzquierdo = document.getElementById("boton_izquierdo");
const botonDerecho = document.getElementById("boton_derecho");

carrusel.insertAdjacentElement('afterbegin', ultimaImagen);


botonIzquierdo.addEventListener('click', function () {
    ultimaImagen = document.querySelectorAll(".carrusel_imagen")[carruselImagenes.length - 1];
    carrusel.style.transition = "all 0.5s";
    carrusel.style.marginLeft = "0";
    setTimeout(function () {
        carrusel.style.transition = "none";
        carrusel.insertAdjacentElement('afterbegin', ultimaImagen);
        carrusel.style.marginLeft = "-100%";
    }, 500);
});


botonDerecho.addEventListener('click', function () {
    let primerImagen = document.querySelectorAll(".carrusel_imagen")[0];
    carrusel.style.transition = "all 0.5s";
    carrusel.style.marginLeft = "-200%";
    setTimeout(function () {
        carrusel.style.transition = "none";
        carrusel.insertAdjacentElement('beforeend', primerImagen);
        carrusel.style.marginLeft = "-100%";
    }, 500);
});