// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let slideIndex = 0;
showSlides();

function showSlides() {
  let i;
  let slides = document.getElementsByClassName("mySlides");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}
  slides[slideIndex-1].style.display = "block";
  setTimeout(showSlides, 2000); // Change image every 2 seconds
}


//validação de cpf
function validar_conta(form)
{
  var camposenha = document.getElementById('txtsenha');
  var valorsenha = txtsenha.value;

  var caixasenha = document.querySelector('.msg-senha');

  if(valorsenha.length < 6)
  {
     caixasenha.innerHTML = "Sua senha precisa ter ao menos 6 caractéres";
     caixasenha.style.display = 'block';
     camposenha.focus();

     return false;
  }
  else
  {
    return true;
  }
}