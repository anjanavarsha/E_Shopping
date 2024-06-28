<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin_Product_View.aspx.cs" Inherits="E_Shopping.Admin_Product_View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<style type="text/css">--%>
 <%--   .auto-style1 {
        width: 68%;
        height: 225px;
            }
    .auto-style2 {
        height: 18px;
    }
    .auto-style3 {
        height: 71px;
    }
    .auto-style4 {
        height: 38px;
    }
    .auto-style5 {
        margin-left: 85;
    }
    .auto-style6 {
        height: 71px;
        width: 545px;
    }
    .auto-style7 {
        height: 18px;
        width: 545px;
    }
    .auto-style8 {
        width: 545px;
    }
    .auto-style9 {
        height: 38px;
        width: 545px;
    }
</style>--%>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style6">
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style5" Height="153px" Width="487px">
                <Columns>
                    <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="LinkButton1_Command">Select</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Block"></asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
        <td class="auto-style3"></td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Panel ID="Panel1" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style2"></td>
                        <td class="auto-style2"></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9"></td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
