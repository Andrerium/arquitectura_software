function validar(formulario) {
    if(formulario.nombre.value.trim()=="" && formulario.nombre.value.trim().length<3){
        document.getElementById("errorNombre").innerText = "Campo obligatorio ome";
      formulario.nombre.focus();
      return false;
    }
    var re = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i
    if (!re.test(formulario.email.value)){
      document.getElementById("emailInvalido").innerText = "email no valido";
      formulario.nombre.focus();
      return false;
    }
    if(formulario.contrasena.value.trim().length < 5){
      document.getElementById("errorContrasena").innerText = "contrasena no valida";
      formulario.nombre.focus();
      return false ;
    }
    if(formulario.confirmacion.value != formulario.contrasena.value ){
      document.getElementById("errorConfirmacion").innerText = "las contraseñas deben ser iguales";
      formulario.nombre.focus();
      return false;
    }
    if(formulario.genero.value == ""){
      document.getElementById("errorGenero").innerText = "Debe elegir un genero";
      formulario.nombre.focus();
      return false;
    }
    if(formulario.pais.value == ""){
      document.getElementById("errorPais").innerText = "El pais es obligatorio";
      formulario.nombre.focus();
      return false;
    }
    if(!formulario.terminos.checked){
      document.getElementById("aceptaTerminos").innerText = "Debe aceptar terminos y condiciones";
      formulario.nombre.focus();
      return false;

    }
    

    alert("Datos enviados");
  
    return true;
  }

