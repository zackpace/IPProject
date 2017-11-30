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
        
        $.ajax({
            url: "/Home/AccountDetails?id=" + id
           
           
        }).done(function (html) {
        
            $("#AccountDetails").html(html)

        });

       
      

    });
 
   
});