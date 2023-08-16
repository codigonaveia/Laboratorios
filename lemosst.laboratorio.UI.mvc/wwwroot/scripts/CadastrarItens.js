$(document).ready(function () {
    $("#submitButton").click(function () {
        var model = {
            ProdutoId = $('#ProdutoId').val(),
            SubItensId =  $('#DescricaoItens').val(),
            PrecoUnitario = $('#PrecoUnitario').val(),
            Quantidade = $('#Quantidade').val()
        };


        createPerson(model);
    });

});
function createPerson(model) {
    $.ajax({
        url: "/Produtos/CadastrarProduto", //'@Url.Action("CadastrarProduto","Produtos")',
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(model),
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.error(error);
        }
    });
}