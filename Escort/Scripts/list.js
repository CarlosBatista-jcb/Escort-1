$(document).ready(function () {

    $("#age-range").nstSlider({
        "left_grip_selector": ".leftGrip",
        "right_grip_selector": ".rightGrip",
        "value_bar_selector": ".bar",
        "value_changed_callback": function (cause, leftValue, rightValue) {
            $(this).parent().find('.leftLabel').text(leftValue);
            $(this).parent().find('.rightLabel').text(rightValue);
        }
    });
    $("#height-range").nstSlider({
        "left_grip_selector": ".leftGrip",
        "right_grip_selector": ".rightGrip",
        "value_bar_selector": ".bar",
        "value_changed_callback": function (cause, leftValue, rightValue) {
            $(this).parent().find('.leftLabel').text(leftValue);
            $(this).parent().find('.rightLabel').text(rightValue);
        }
    });
    $("#price-range").nstSlider({
        "rounding": {
            "500": "600",
            "600": "700",
            "700": "800",
            "800": "900",
            "900": "1000",
            "1000": "1100",
            "1100": "1200",
            "1200": "1300",
            "1300": "1400",
            "1400": "1500",
            "1500": "1600",
            "1600": "1700",
            "1700": "1800",
            "1800": "1900",
            "1900": "2000",
            "2000": "2100",
            "2100": "2200",
            "2200": "2300",
            "2300": "2400",
            "2400": "2500",
            "2500": "2600",
            "2600": "2700",
            "2700": "2800",
            "2800": "2900",
            "2900": "3000"
        },
        "left_grip_selector": ".leftGrip",
        "right_grip_selector": ".rightGrip",
        "value_bar_selector": ".bar",
        "value_changed_callback": function (cause, leftValue, rightValue) {
            $(this).parent().find('.leftLabel').text(leftValue);
            $(this).parent().find('.rightLabel').text(rightValue);
        }
    });






});


function OpenFilter() {
  
    $("#filter").slideToggle();
    $("#age-range").nstSlider("refresh");
    $("#height-range").nstSlider("refresh");
    $("#price-range").nstSlider("refresh");
}


