<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Reporte1.aspx.cs" Inherits="ClinicaWEB.Reportes.Reporte1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">

        <h2 class="text-center mb-4">Consulta Atencion</h2>
        <p class="text-end">
            <asp:HyperLink ID="HyperLink" runat="server" NavigateUrl="~/Home.aspx" CssClass="btn btn-outline-secondary">
          Retornar al Registro</asp:HyperLink>
        </p>

        <div class="row">
            <div class="form-floating mb-3">
                <asp:DropDownList ID="cboMedico" runat="server" CssClass="form-control">
                </asp:DropDownList>
                <label for="cboMedico">Medico:</label>
            </div>
            <div class="form-floating mb-3">
                <asp:DropDownList ID="cboPaciente" runat="server" CssClass="form-control">
                </asp:DropDownList>
                <label for="cboPaciente">Paciente:</label>
            </div>


            <div class="form-floating mb-3">
                <asp:DropDownList ID="cboSucursal" runat="server" CssClass="form-control">
                </asp:DropDownList>
                <label for="cboSucursal">Sucursal:</label>
            </div>
        </div>


        <div class="text-end mb-3 mt-3">
            <asp:LinkButton ID="btnNuevo" runat="server" CssClass="btn btn-success" OnClick="btnBuscarAtencion_Click" Text="Buscar Atencion" />
            <asp:Button ID="btnRecargarPagina" CssClass="btn btn-warning" runat="server" Text="Recargar Página" OnClick="btnLimpiarFiltros_Click" />

        </div>
        <asp:GridView ID="gvAtencion" runat="server" AutoGenerateColumns="False"
            CssClass="table table-bordered table-hover table-responsive" GridLines="None" AllowPaging="True" EnableViewState="true"
            OnPageIndexChanging="gvAtencion_PageIndexChanging">




            <Columns>
                <asp:BoundField DataField="cod_ate" HeaderText="Código" />

                <asp:TemplateField HeaderText="Medico">
                    <ItemTemplate>
                        <%# ObtenerNombreMedico(Eval("cod_med")) %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Paciente">
                    <ItemTemplate>
                        <%# ObtenerNombrePaciente(Eval("cod_pac")) %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Sucursal">
                    <ItemTemplate>
                        <%# ObtenerNombreSucursal(Eval("cod_suc")) %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:BoundField DataField="num_sala" HeaderText="Sala" />

            </Columns>
            <PagerStyle CssClass="pagination justify-content-center align-items-center" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />


            <HeaderStyle CssClass="table-dark" />
            <RowStyle CssClass="table-light" />
            <SelectedRowStyle CssClass="table-success" />
        </asp:GridView>
    </div>

</asp:Content>
