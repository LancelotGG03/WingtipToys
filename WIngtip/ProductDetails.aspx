<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WIngtip.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server"
        ItemType="WIngtip.Models.Product" SelectMethod ="GetProduct" RenderOuterTable="false">
            <ItemTemplate>
                <div>
                    <h1><%#:Item.ProductName %></h1>
                </div>
                <br />
                <table>
                    <tr>
                        <td>
                            <img src="/Catalog/Foticos/<%#:Item.ImagePath %>"
                            style="border:solid; height:300px" alt="<%#:Item.ProductName %>"/>
                        </td>
                        <td>&nbsp;</td>
                        <td style="vertical-align: top; text-align:left;">
                            <b>Descripción:</b><br /><%#:Item.Description %>
                            <br />
                            <span><b>Precio:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                            <br />
                            <span><b>Código de producto:</b>&nbsp;<%#:Item.ProductID%>
                            </span>
                            <br />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
</asp:Content>
