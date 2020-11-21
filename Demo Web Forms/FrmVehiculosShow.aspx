<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmVehiculosShow.aspx.cs" Inherits="Demo_Web_Forms.FrmVehiculosShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<%--<asp:GridView ID="gvTablaUno" runat="server" >
</asp:GridView>--%>
 <div Class="container">
        <hr />
  <div style="overflow: scroll" >
            <asp:GridView ID="gvTablaUno" runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" EnableTheming="True" AllowPaging="True"  PageSize="5" OnRowCommand="gvTablaUno_RowCommand" OnSelectedIndexChanged="gvTablaUno_SelectedIndexChanged">
                     <Columns>
                         <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton runat="server" Text="Select" CommandName="Select" CommandArgument='<%# Eval("car_id") %>' />
                            </ItemTemplate>
                         </asp:TemplateField>
                     </Columns>
            </asp:GridView>
        </div>
  </div>
</asp:Content>
