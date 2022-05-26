// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const TipoPrestamoSelect = document.querySelector("#TipoPrestamo"); 
const TasaInteresInput = document.querySelector("#TasaInteres");


if (TipoPrestamoSelect.value === 1) {
    TasaInteresInput.textContent = "20%";

    return;
}