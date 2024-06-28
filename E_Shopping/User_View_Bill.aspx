<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="User_View_Bill.aspx.cs" Inherits="E_Shopping.User_View_Bill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 18px;
        }
        .auto-style3 {
            height: 20px;
        }
        .auto-style6 {
            height: 48px;
        }
        .auto-style7 {
            height: 8px;
        }
        .auto-style8 {
            height: 14px;
        }
        .auto-style9 {
            height: 116px;
        }
        .auto-style10 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label4" runat="server" Text="Bill NO :" Font-Bold="True" Font-Size="X-Large" ForeColor="White"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"></asp:Label>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label9" runat="server" Font-Size="X-Large" Text="Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            </td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="White" BorderStyle="Solid" BorderWidth="4px" CellSpacing="10" Width="882px">
                    <Columns>
                        <asp:BoundField DataField="Product_Name" HeaderText="Product name" />
                        <asp:ImageField DataImageUrlField="Product_Image" HeaderText="Image">
                        </asp:ImageField>
                        <asp:BoundField HeaderText="Price" DataField="Product_Price" />
                        <asp:BoundField HeaderText="Status" DataField="Product_Status" />
                        <asp:BoundField DataField="Cart_Quantity" HeaderText="Quantity" />
                        <asp:BoundField DataField="Order_Status" HeaderText="Order status" />
                        <asp:BoundField DataField="Total_Price" HeaderText="Grand Total" />
                    </Columns>
                    <FooterStyle BorderColor="#FF6600" Font-Bold="True" Font-Italic="True" Font-Overline="True" Font-Size="Medium" />
                    <PagerSettings Position="Top" />
                    <PagerStyle BorderColor="#CC6699" BorderStyle="Dashed" />
                    <RowStyle BorderColor="White" BorderStyle="Double" />
                </asp:GridView>
            </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label1" runat="server" Text="Account Number" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large"></asp:TextBox>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Grand Total" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label7" runat="server" Font-Size="X-Large"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button2" runat="server" Text="Pay" OnClick="Button2_Click" Font-Size="X-Large" Width="154px" />
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label8" runat="server" Font-Size="X-Large" Text="Account Balance"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Font-Size="X-Large"></asp:Label>
            </td>
            <td class="auto-style10">
                </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
