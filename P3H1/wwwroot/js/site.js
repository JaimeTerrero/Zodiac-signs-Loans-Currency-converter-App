const TipoPrestamo = document.querySelector("#TipoPrestamo");
const TasaInteres = document.querySelector("#TasaInteres");

document.addEventListener('DOMContentLoaded', () => {
    TipoPrestamo.addEventListener('click', showPercentageInput);
});

function showPercentageInput(e) {
    e.preventDefault();

    if (TipoPrestamo.value == "1") {
        TasaInteres.value = '22%';
    } else if (TipoPrestamo.value == "2") {
        TasaInteres.value = '12%'
    } else if (TipoPrestamo.value == "3") {
        TasaInteres.value = '8%'
    }
}