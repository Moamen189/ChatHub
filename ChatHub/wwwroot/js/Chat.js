document.addEventListener("DOMContentLoaded", function () {
    var messageInp = document.getElementById("messageInp");
    var userName = prompt("Please Enter Your Name : ");
    var proxeyConnection = new signalR.HubConnectionBuider().withUrl("https://localhost:44334/chat").build(); //Create Proxy
    //document.getElementById("sendBtn").addEventListener("click", function () {

    //});

});