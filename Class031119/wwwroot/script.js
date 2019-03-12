(function () {
    "use strict";
    window.onload = function () {
        //Add event listener here!	
        var button = document.querySelector("#btn");
        button.addEventListener("click", function (e) {
            var name = document.querySelector("#name").value;
            var price = document.querySelector("#price").value;
            fetch("/ShoppingList/Add?name=" + name + "&price=" + price).then(function (response) {
                response.text().then(function (message) { console.log(message); });
            });
        });
    };
}());