$(document).ready(function () {

    $("#SQModelId").change(function () {
        var sqModel = $("#SQModelId").val();

        $("#SQCustomerId").empty();
        $("#SQCustomerId").append("<option value='0'>--Firma Seçin--</option>");

        $.post("/secondquality/getAjaxResult", { sqModel: sqModel }, "json")
            .done(function (data) {
                for (let index = 0; index < data.length; index++) {
                    $("#SQCustomerId").append("<option value='" + data[index].id + "'>" + data[index].customerName + "</option>");
                    
                }
            })
            .fail(function (xhr, status, error) {
                alert("error");
            });
    });
});