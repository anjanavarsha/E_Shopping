<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Edit_Product.aspx.cs" Inherits="E_Shopping.Edit_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 116%;
            height: 774px;
        }
        .auto-style3 {
            width: 540px;
            height: 583px;
        }
    .auto-style4 {
        width: 128%;
        height: 373px;
    }
        .auto-style14 {
            width: 540px;
            height: 135px;
        }
        .auto-style15 {
            height: 135px;
        }
        .auto-style16 {
            width: 540px;
            height: 27px;
        }
        .auto-style17 {
            height: 27px;
        }
        .auto-style18 {
            height: 583px;
        }
        .auto-style20 {
            width: 168px;
        }
        .auto-style21 {
            width: 297px;
        }
        .auto-style22 {
            width: 168px;
            height: 26px;
        }
        .auto-style23 {
            width: 297px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style14">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="243px" Width="807px">
                    <Columns>
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Product_Id") %>' OnCommand="LinkButton1_Command">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Product_Name" HeaderText="Product Name" />
                        <asp:ImageField DataImageUrlField="Product_Image" HeaderText="Product Image">
                        </asp:ImageField>
                        <asp:BoundField DataField="Product_Price" HeaderText="Product Price" />
                        <asp:BoundField DataField="Product_Description" HeaderText="Product Description" />
                        <asp:BoundField DataField="Product_Stock" HeaderText="Product Stock" />
                        <asp:BoundField DataField="Product_Status" HeaderText="Product Status" />
                        <asp:TemplateField HeaderText="Block">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("Product_Id") %>' OnCommand="LinkButton3_Command">Block</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="delete">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Product_Id") %>' OnCommand="LinkButton2_Command">Delete</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style16">
                </td>
            <td class="auto-style17">
                </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Panel ID="Panel1" runat="server" Height="229px" Visible="False">
                    <table class="auto-style4">
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label8" runat="server" Font-Size="XX-Large" Text="Edit Product Details"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">
                                <asp:Label ID="Label1" runat="server" Text="Product name"></asp:Label>
                            </td>
                            <td class="auto-style21">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter product name"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">
                                <asp:Label ID="Label2" runat="server" Text="Product Image"></asp:Label>
                            </td>
                            <td class="auto-style21">
                                <asp:Image ID="Image1" runat="server" Height="93px" Width="100px" />
                                <asp:FileUpload ID="FileUpload1" runat="server" Width="154px" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="select image" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">
                                <asp:Label ID="Label3" runat="server" Text="Product price"></asp:Label>
                            </td>
                            <td class="auto-style21">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="enter price"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style22">
                                <asp:Label ID="Label4" runat="server" Text="Product description"></asp:Label>
                            </td>
                            <td class="auto-style23">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="enter the produt description"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">
                                <asp:Label ID="Label5" runat="server" Text="Product stock"></asp:Label>
                            </td>
                            <td class="auto-style21">
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox4" ErrorMessage="enter stock details"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">
                                <asp:Label ID="Label6" runat="server" Text="Product status"></asp:Label>
                            </td>
                            <td class="auto-style21">
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Available</asp:ListItem>
                                    <asp:ListItem>Un available</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="select status"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">&nbsp;</td>
                            <td class="auto-style21">
                                <asp:Button ID="Update" runat="server" OnClick="Button1_Click" Text="Update" />
                                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20">&nbsp;</td>
                            <td class="auto-style21">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style20">&nbsp;</td>
                            <td class="auto-style21">&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td class="auto-style18">
                </td>
        </tr>
        </table>
</asp:Content>
