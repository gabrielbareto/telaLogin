var api = 'https://localhost:44347/api/Usuarios'
var xhttp = new XMLHttpRequest()



function validar(){ 
    var nome = document.getElementById('txtnome').value;
    var senha = document.getElementById('txtsenha').value;
    
    if(nome == 'aluno' && senha == 'unit'){
        window.alert("Usuário e senha corretos!")
    } else {
        window.alert("Usuário ou senha incorretos!")
    }
}