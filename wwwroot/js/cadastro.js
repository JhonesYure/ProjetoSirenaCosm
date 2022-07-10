//validação de cpf
function validar(form)
{
  var camposenha= document.getElementById('txtsenha');
  var valorsenha = txtsenha.value;

  if(valorsenha.length < 6)//**SENHA */
    {
        caixasenha.innerHTML = "Sua senha precisa ter ao menos 6 caractéres";
        caixasenha.style.display = 'block'
        camposenha.focus();

        return false;
    }
    else
    {
        return true;
    }  
} 