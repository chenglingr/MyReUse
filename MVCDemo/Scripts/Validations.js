function IsValid() {
    var pwd1 = $("#PassWord").val();
   
    var pwd2 = $("#inputPassword4").val();
    if (pwd1 == pwd2) { return true; }
    else { alert("两次密码不一致"); return false; }
}