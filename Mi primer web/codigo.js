console.log("Hola mundo!")
function saludar(){
        var user = document.getElementById("txtUser").value;
        var password = document.getElementById("txtPassword").value;
        console.log("Hola " + user);
        alert("Conserva tu clave en secreto... Nosotros la guardamos: " + password);
    }