$(document).ready(function () {

    $("#SQModelId").change(function () {
        var sqModel = $("#SQModelId").val();

        $("#SQCustomerId").empty();
        $("#SQCustomerId").append("<option value='0'>--Firma Seçin--</option>");
        $("#sell-qty").empty();

        $.post("/secondquality/getCompanyName", { sqModel: sqModel }, "json")
            .done(function (data) {
                for (let index = 0; index < data.length; index++) {
                    $("#SQCustomerId").append("<option value='" + data[index].id + "'>" + data[index].customerName + "</option>");

                }
            })
            .fail(function (xhr, status, error) {
                alert("error");
            });
    });

    $("#SQCustomerId").change(function () {
        $("#sell-qty").empty();
        var sQCustomer = $("#SQCustomerId").val();
        var sqModel = $("#SQModelId").val();


        $.post("/secondquality/getStockQTY", { sQCustomer: sQCustomer, sqModel: sqModel }, "json")
            .done(function (data) {

                console.log(parseInt(data.sqqty));
                $("#sell-qty").append("<strong>" + parseInt(data.sqqty) + "</strong>");


            })
            .fail(function (xhr, status, error) {
                alert("error");
            });
    });

    $("#add-shopping-list").click(function () {
        $.post("/secondquality/getShoppingListAdd", { name: "hello" }, "json")
            .done(function (data) {

                console.log(parseInt(data.sqqty));
                $("#sell-qty").append("<strong>" + parseInt(data.sqqty) + "</strong>");


            })
            .fail(function (xhr, status, error) {
                alert("error");
            });
    });

});

