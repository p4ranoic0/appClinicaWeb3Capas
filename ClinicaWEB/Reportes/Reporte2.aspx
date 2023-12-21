<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Reporte2.aspx.cs" Inherits="ClinicaWEB.Reportes.Reporte2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
        <h2 class="text-center mb-4">Consultar Paciente</h2>
        <div class="row">
            <div class="form-floating mb-3">
                <asp:TextBox type="text" ID="txtDni" class="form-control" placeholder="Ingrese número DNI o Codigo Paciente" runat="server" />
                <label for="txtDni">DNI o Codigo Paciente:</label>
            </div>
            <div class="text-end mb-3 mt-3">
                <asp:LinkButton ID="btnBuscar" class="btn btn-success" runat="server"
                    OnClick="btnBuscarPacientePorDni_Click">Buscar Paciente</asp:LinkButton>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                <!-- Card para mostrar datos del paciente -->
                <div class="card">
                    <div class="card-header">
                        Datos del Paciente
                    </div>
                    <div class="card-body" id="datosPaciente">

                        <p class="card-text">
                            <strong>Nombre:</strong>
                            <asp:Label ID="lblNombrePac" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>DNI:</strong>
                            <asp:Label ID="lblDni" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>Género:</strong>
                            <asp:Label ID="lblGenero" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>Fecha de Nacimiento:</strong>
                            <asp:Label ID="lblFechaNacimiento" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>Teléfono:</strong>
                            <asp:Label ID="lblTelefono" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>Dirección:</strong>
                            <asp:Label ID="lblDireccion" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>Email:</strong>
                            <asp:Label ID="lblEmail" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>Grupo Sanguíneo:</strong>
                            <asp:Label ID="lblGrupoSanguineo" runat="server" />
                        </p>
                        <p class="card-text">
                            <strong>Seguro:</strong>
                            <asp:Label ID="lblSeguro" runat="server" />
                        </p>

                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <!-- GridView para mostrar atenciones -->
                <asp:GridView ID="gvAtenciones" runat="server" AutoGenerateColumns="False"
                    CssClass="table table-bordered table-hover table-responsive" GridLines="None" AllowPaging="True" EnableViewState="true"
                    OnPageIndexChanging="gvAtenciones_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="cod_ate" HeaderText="Código" />
                        <asp:TemplateField HeaderText="Medico">
                            <ItemTemplate>
                                <%# ObtenerNombreMedico(Eval("cod_med")) %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="comen_ate" HeaderText="Comentario" />

                        <asp:TemplateField HeaderText="Sucursal">
                            <ItemTemplate>
                                <%# ObtenerNombreSucursal(Eval("cod_suc")) %>
                            </ItemTemplate>
                        </asp:TemplateField>


                    </Columns>
                    <PagerStyle CssClass="pagination justify-content-center align-items-center" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
                    <HeaderStyle CssClass="table-dark" />
                    <RowStyle CssClass="table-light" />
                    <SelectedRowStyle CssClass="table-success" />
                </asp:GridView>
                <asp:Label ID="lblSinAtenciones" runat="server" Visible="false" CssClass="text-danger">No hay atenciones para este paciente.</asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
