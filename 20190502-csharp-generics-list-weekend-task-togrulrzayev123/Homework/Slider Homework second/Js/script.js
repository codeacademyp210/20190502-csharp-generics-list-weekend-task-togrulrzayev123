"use strict";
let slider = document.querySelector(".slider");
let sliderImage = document.querySelectorAll(".slider img");

let prevButton = document.querySelector(".prev");
let nextButton = document.querySelector(".next");

let counter = 1;
let size = sliderImage[0].clientWidth;


slider.style.transform = 'translateX(' + (-size-15 * counter) + 'px)';

nextButton.addEventListener('click', function () {
    if (counter >= sliderImage.length - 1)
        return;
    slider.style.transition = "transform 0.4s ease-in-out";
    counter++;
    slider.style.transform = 'translateX(' + (-size * counter) + 'px)';

})

prevButton.addEventListener('click', function () {
    if (counter <= 0)
        return;
    slider.style.transition = "transform 0.4s ease-in-out";
    counter--;
    slider.style.transform = 'translateX(' + (-size * counter) + 'px)';

})

slider.addEventListener("transitionend", function () {
    if (sliderImage[counter].id === 'last') {
        slider.style.transition = "none";
        counter = sliderImage.length - 2;
        slider.style.transform = 'translateX(' + (-size * counter) + 'px)';
    }

    if (sliderImage[counter].id === 'first') {
        slider.style.transition = "none"
        counter = sliderImage.length - counter;
        slider.style.transform = 'translateX(' + (-size * counter) + 'px)';
    }
})























// let prev = document.querySelector(".prev");
// let next = document.querySelector(".next");
// let sliderContent = document.querySelector(".slider .content");



// next.addEventListener("click", nextSlide);
// prev.addEventListener("click", prevSlide);

// function nextSlide() {
//     let currentItem = document.querySelector(".active-item-right");
//     currentItem.classList.remove("active-item-right");
//     if (currentItem.nextElementSibling != null) {
//         currentItem.nextElementSibling.classList.add("active-item-right");
//     } else {
//         currentItem.parentNode.firstElementChild.classList.add("active-item-right");
//     }
// }

// function prevSlide() {
//     let currentItem = document.querySelector(".active-item-right");
//     currentItem.classList.remove("active-item-right");
//     if (currentItem.previousElementSibling != null) {
//         currentItem.previousElementSibling.classList.add("active-item-right");
//     } else {
//         currentItem.parentNode.lastElementChild.classList.add("active-item-right");
//     }
// }