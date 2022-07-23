const barra = document.getElementById('nav');

window.addEventListener('scroll', function () {

    console.log(window.scrollY);
    if (window.scrollY != 0) {
        barra.style.backgroundColor = "rgb(223, 166, 61)";
    } else {
        barra.style.backgroundColor = "rgba(241, 240, 240, 0.192)";
    }
})
