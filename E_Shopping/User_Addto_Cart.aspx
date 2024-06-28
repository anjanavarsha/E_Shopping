<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="User_Addto_Cart.aspx.cs" Inherits="E_Shopping.User_Addto_Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 607px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 607px;
            height: 18px;
        }
        .auto-style5 {
            height: 18px;
        }
        .auto-style6 {
            width: 607px;
            height: 130px;
        }
        .auto-style7 {
            height: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style6">
                <asp:GridView ID="GridView1" runat="server" Width="913px" BorderStyle="Solid" ForeColor="#3399FF" GridLines="Vertical" Height="360px" AutoGenerateColumns="False" PageSize="5" >
                    <Columns>
                        <asp:ImageField DataImageUrlField="Product_Image" HeaderText="Product Image" >
                        </asp:ImageField>
                        <asp:BoundField DataField="Product_Name" HeaderText="Product_Name" />
                        <asp:BoundField DataField="Product_Description" HeaderText="Product Details" />
                        <asp:BoundField DataField="Cart_Quantity" HeaderText="Cart_Quantity" />
                        <asp:BoundField DataField="Total_Price" HeaderText="Cart Total" />
                        <asp:BoundField DataField="Status" HeaderText="Cart Status" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <%--<asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Cart_ID") %>' OnCommand="LinkButton1_Command2">Edit</asp:LinkButton>--%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>
                             
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Cart_ID" HeaderText="Cart_Id" />
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label4" runat="server" Text="Total Price"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
