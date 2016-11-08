




function GeneratePw(userId) {
    if(userId != ""){
        $.ajax({
            method: "POST",
            url: "/Account/ReGeneratePassword",
            data: { userId: userId }
        }).success(function (msg) {
            if(msg != "Error"){
                alert(msg);
            } else {
                alert("Error while generating new password");
            }
        });



    }
}




