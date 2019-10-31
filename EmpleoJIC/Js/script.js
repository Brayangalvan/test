var icono = document.getElementById("icon");
var menu = document.getElementById("menuresponsive");

icono.addEventListener("click", esconder);

function esconder() {
    var clase = menu.className;

    if (clase == "invisible") {
        menu.classList.remove("invisible");
        menu.classList.add("visible");
        icono.classList.add("activo");
    }
    else {
        menu.classList.remove("visible");
        menu.classList.add("invisible");
        icono.classList.remove("activo");
    }
}

function iniciosesion(entra) {
    var inicio = document.getElementById("containerLogin");
    inicio.style.display = 'block';
    if (entra == "entrar") {
        inicio.style.display = 'block';
    } else if (entra == "cerrar") {
        inicio.style.display = 'none';
    }
}

function activar(num) {
    for (var i = 1; i <= $(".item").size() ; i++) {
        var paginaOferta = document.getElementsByClassName(i);
        var paginacion = document.getElementById(i);
        if (i == num) {
            paginaOferta[0].style.display = 'block';
            paginacion.classList.add("active");
        } else {
            paginacion.classList.remove("active");
            paginaOferta[0].style.display = 'none';
        }
    }
}

function anterior() {
    var activo = document.getElementsByClassName("active");
    var valor = parseInt(activo[0].getAttribute('id'));
    if (valor > 1) {
        valor = valor - 1;
        activar(valor);
    } 
}
function proxima() {
    var numPaginacion = $(".item").size();
    var activo = document.getElementsByClassName("active");
    var valor = parseInt(activo[0].getAttribute('id'));
    if (valor < numPaginacion)
         {
        valor = valor + 1;
        activar(valor);
    } else if (valor == numPaginacion) {
        activar(valor);
    }
}