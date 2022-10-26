$(document).ready(function () {

    $("#SQModelId").change(function () {
        var sqModel = $("#SQModelId").val();
        $.post("/secondquality/getAjaxResult", { sqModel: sqModel })
            .done(function (response) {
                alert(response);
                $("#SQCustomerId").empty();
                $("#SQCustomerId").append("<option value='0'>--Firma Seçin--</option>");

                // $.each(msg.d, function (i) {
                //     $("#dropdownlist").append("<option value='" + this.adres + "'>" + this.site + "</option>");
                // });

            })
            .fail(function (xhr, status, error) {
                alert("error");
            });
    });
});