document.addEventListener("DOMContentLoaded", function () {
    var messageInp = document.getElementById("messageInp");
    var userName = prompt("Please Enter Your Name : ");
    messageInp.focus();

    var proxyConnection = new signalR.HubConnectionBuider().withUrl("https://localhost:44334/chat").build(); //Create Proxy
  
    proxyConnection.start().then(function () {
        console.log("Connection Started Successflly");

        document.getElementById("sendBtn").addEventListener("click", function () {

            proxyConnection.invoke("Send", userName, messageInp.value);
            messageInp.value = "";
            messageInp.focus();

        });
    }).catch(error => {
        console.log(error);
    })

    proxyConnection.on("ReceiveMessage", function (user, message) {
        var liElement = document.createElement('li');
        liElement.innerHTML = `<strong>${user}: </strong> ${message}`;
        document.getElementById('conversation').appendChild(liElement);
    })
});