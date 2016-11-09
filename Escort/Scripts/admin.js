$(document).ready(function () {
    
    $('#search').keyup(function (e) {
        if (e.keyCode == 13) {
            var key = $.trim($("#search").val());
            //window.location.replace(window.location.host + window.location.pathname + "?q=" + key);
            window.location.href = window.location.pathname + "?q=" + key;
        }
    });

    if ($("#error-text").text() !== "") {
        $("#alertError").modal();
    }
});




function GeneratePw(userId, username) {
    if (userId !== "") {
        $(".control-btn").prop("disabled", true);
        $.ajax({
            method: "POST",
            url: "/Account/ReGeneratePassword",
            data: { userId: userId }
        }).success(function (msg) {
            if(msg !== "Error"){
                $("#name").text(username);
                $("#pw").text(msg);
                $("#alertPw").modal({
                    backdrop: "static"
                });
            } else {
                alert("Error while generating new password");
            }
            $(".control-btn").prop("disabled", false);
        });



    }
}




