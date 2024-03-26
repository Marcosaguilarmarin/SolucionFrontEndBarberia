// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


const toggleNavul = document.querySelector(".toggleList");
const NavMenu = document.querySelector(".navul")

toggleNavul.addEventListener("click", () => {

    NavMenu.classList.toggle("navul-visible")

})


/*
document.addEventListener("DOMContentLoaded", function () {
    var toggleListButton = document.getElementById("toggleListButton");
    var navList = document.querySelector(".navul");

    toggleListButton.addEventListener("click", function () {
        if (navList.classList.contains("navul-hidden")) {
            navList.classList.remove("navul-hidden");
        } else {
            navList.classList.add("navul-hidden");
        }
    });
});*/