
   window.cadastrar = function () {
        const email = document.getElementById("email").value;
        const senha = document.getElementById("senha").value;

        fetch("http://localhost:5000/usuarios", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                email: email,
                senha: senha
            })
        })
        .then(response => response.json())
        .then(data => {
            document.getElementById("mensagem").innerText = data.mensagem || "Cadastrado!";
        })
        .catch(error => {
            document.getElementById("mensagem").innerText = "Erro ao cadastrar";
        });
    }
