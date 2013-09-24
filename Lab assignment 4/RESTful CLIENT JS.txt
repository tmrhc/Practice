var echo = function(dataPass) {
    $.ajax({
        type: "POST",
        url: "/echo/json/",
        data: dataPass,
        cache: false,
        success: function(json) {
            alert("Result=" + json.Id);
        }
    });
};
$('.add').live('click', function() {
    $.get("http://vhost1135.site1.compute.ihost.com/aspnet_client/calculator%20wcf%20service/calc.svc/addition/60/30", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.subtract').live('click', function() {
    $.get("http://vhost1135.site1.compute.ihost.com/aspnet_client/calculator%20wcf%20service/calc.svc/subtraction/60/30", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.mul').live('click', function() {
    $.get("http://vhost1135.site1.compute.ihost.com/aspnet_client/calculator%20wcf%20service/calc.svc/multiplication/60/30", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.div').live('click', function() {
    $.get("http://vhost1135.site1.compute.ihost.com/aspnet_client/calculator%20wcf%20service/calc.svc/division/60/30", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
