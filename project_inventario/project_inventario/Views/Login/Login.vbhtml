﻿@ModelType project_inventario.Login
@Code
    ViewData("Title") = "Login"
End Code

<h2>Ingrese sus Datos</h2>

<div>
    @Using Html.BeginForm("Login", "Login", FormMethod.Post)
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.usuario)
            @Html.TextBoxFor(Function(model) model.usuario, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.usuario)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.contrasenia)
            @Html.PasswordFor(Function(model) model.contrasenia, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.contrasenia)
        </div>
        @<div class="form-group">
            @Html.LabelFor(Function(model) model.tipousuario)
            @Html.TextBoxFor(Function(model) model.tipousuario, New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(model) model.tipousuario)
        </div>
        @<input type="submit" value="Ingreso" class="btn btn-block btn-danger" />
    End Using

</div>

