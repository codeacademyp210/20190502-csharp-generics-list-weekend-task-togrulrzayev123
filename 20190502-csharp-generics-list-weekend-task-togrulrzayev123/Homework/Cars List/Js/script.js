"use strict";


let carArray = [];

function CarObject(_id, _manufacturer, _model, _release) {
    this.id = _id;
    this.manufacturer = _manufacturer;
    this.model = _model;
    this.release = _release;
}

let idCounter = (function () {
    var counter = 0;
    return function () {
        return counter += 1;
    }
})();

function validateForm() {
    let manufacturerValue = document.forms["myForm"]["manfuc"].value;
    let modelValue = document.forms["myForm"]["model"].value;
    let releaseValue = document.forms["myForm"]["release"].value;
    const numberPattern = /^(([0-9]{4})*$)/;

    if (manufacturerValue == "" || modelValue == "" || releaseValue == "") {
        alert("All must be filled out");
        return false;
    } 
    if (!isNaN(manufacturerValue)) {
        alert("You are writing only text for Manufacturing");
        return false;
    }
    if (!releaseValue.match(numberPattern)) {
        alert("You are writing only numbers and 4 digits  for Release")
        return false;
    }
    else {
        let newCarList = new CarObject(idCounter(), manufacturerValue, modelValue, releaseValue);
        carArray.push(newCarList);
        console.log(carArray);
        let carList = "";
        for (let i = 0; i < carArray.length; i++) {
            carList = carArray[i].id + ". " + carArray[i].manufacturer + "-" + carArray[i].model + "- " + carArray[i].release
        }

        let ulElement = document.getElementById('lists');
        let liElement = document.createElement('li');
        liElement.classList.add('list-group-item', 'd-flex', 'justify-content-between');
        liElement.appendChild(document.createTextNode(carList));


        let newIcon = document.createElement("i");
        newIcon.classList.add('fas', 'fa-trash-alt');
        liElement.appendChild(newIcon);

        ulElement.appendChild(liElement);

        newIcon.addEventListener("click", function () {
            ulElement.removeChild(liElement);
            carArray.splice(CarObject - 1, 1);
        });


        liElement.addEventListener("click", function () {
            document.forms["myForm"]["manfuc"].value = manufacturerValue;
            document.forms["myForm"]["model"].value = modelValue;
            document.forms["myForm"]["release"].value = releaseValue;
        });


        if (typeof (Storage) !== "undefined") {
            let myJson = JSON.stringify(carArray)
            localStorage.setItem(ulElement, myJson);

           localStorage.getItem(ulElement);
        }
        else {
            document.getElementById("lists").innerHTML = "Sorry, your browser does not support Web Storage...";

        }

        document.forms["myForm"]["manfuc"].value = "";
        document.forms["myForm"]["model"].value = "";
        document.forms["myForm"]["release"].value = "";
    }

    return false;
}

