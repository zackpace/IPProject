$(document).ready(function () {


  

    $(".Person").click(function () {
        
        var id = $(this).children(".id").text();
     
        window.location = "/Home/People/"+id;
    });
    $(".Branch").click(function () {

        var id = $(this).children(".id").text();

        window.location = "/Home/Branch/" + id;
    });
    $(".account").click(function () {
        var id = $(this).children(".id").text();
        var test = 2;
        $.ajax({
            type: "GET",
            url: "/Home/GetSomePartialView/",
            data: someArguments,
            success: function (jsReturnArgs) {

                if (jsReturnArgs.Status === 300) { //300 is an arbitrary value I just made up right now
                    showPopup("You do not have access to that.");
                }

                $("#someDiv").html(jsReturnArgs.ViewString); //the HTML I returned from the controller
            },
            error: function (errorData) { onError(errorData); }
        });

        $(".AccountDetails").append("<p>" + test + "</p>");
      

    });
 
   
});