$(document).ready(function () {

    if (!$(".mb-only").is(":visible")) {
        $(".mb-only").remove();
    }
    var w = $(window).width() * 0.5 - 20;
    //if(w > 300){
    //    $(".control-w").css("width", 300);
    //} else {
    //    $(".control-w").css("width", $(window).width() * 0.5 - 20);
    //}
   

    //$(".full-page").css("height", $(window).height());
    $(".header-content").css("top", $(window).height()*0.3);

    $(".height75").css("height", $(window).height() * 0.7);


	$("#block1").css("height", $(window).height() * 0.5);
    $("#block1").css("padding-top", $(window).height() * 0.2);


    $("#block2").css("height", $(window).height() * 0.5);
    $("#block2").css("padding-top", $(window).height() * 0.2);

    $("#block22").css("height", $(window).height() * 0.5);
    $("#block22").css("padding-top", $(window).height() * 0.2);

    $("#block5").css("height", $(window).height() * 0.5);
    $("#block5").css("padding-top", $(window).height() * 0.2);

    $("#block55").css("height", $(window).height() * 0.5);
    $("#block55").css("padding-top", $(window).height() * 0.2);

    $("#block3").css("height", $(window).height() * 0.25);
    $("#block3").css("padding-top", $(window).height() * 0.1);
    $("#block4").css("height", $(window).height() * 0.25);
    $("#block4").css("padding-top", $(window).height() * 0.1);
	
	$("#block1").css("height", $(window).height() * 0.5);
    $("#block1").css("padding-top", $(window).height() * 0.2);

	
	$(".navbar-nav li").click(function() {
    $(this).toggleClass("active");
    $(this).siblings().removeClass("active");
	});
	
    //$('#fullpage').fullpage();
	$("#page1").css("height", $(window).height());
	$("#page4").css("height", $(window).height());
	


   
$('video, object').maximage('maxcover');





$('#camera_wrap_1').camera({
				height: 'auto',
				pagination: false,
				thumbnails: false
			});

});


	