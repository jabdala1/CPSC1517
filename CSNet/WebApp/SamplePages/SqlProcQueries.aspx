<%@ Page Title="Sql Proc" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SqlProcQueries.aspx.cs" Inherits="WebApp.SamplePages.SqlProcQueries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1>Sql Procedure queries</h1>
        <table align="center" style="width: 80%">
            <tr>
                <td align="center">
                    <asp:Label ID="Label1" runat="server" Text="Select a Product category"></asp:Label>
&nbsp;
                    <asp:DropDownList ID="CategoryList" runat="server"></asp:DropDownList>
               </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click"   />
&nbsp;
                    <asp:Button ID="Clear" runat="server" Text="Clear"
                        CausesValidation="false" OnClick="Clear_Click" />
                </td>

            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center">
                    <asp:GridView ID="CategoryProductList" runat="server" AllowPaging="True" PageSize="5" PagerSettings-Mode="NumericFirstLast" PagerSettings-FirstPageText="Start" PagerSettings-LastPageText="End" GridLines="Horizontal" AlternatingRowStyle-BackColor="#CCCCCC"
                        OnPageIndexChanging="CategoryProductList_PageIndexChanging" AutoGenerateColumns="False">
<AlternatingRowStyle BackColor="#CCCCCC"></AlternatingRowStyle>

                        <Columns>
                            <asp:TemplateField HeaderText="Name"></asp:TemplateField>
                            <asp:TemplateField HeaderText="Price">
                                <HeaderStyle Font-Bold="True" />
                                <ItemStyle HorizontalAlign="Right" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="QoH">
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" text='<%# Eval("Product Name")%>'></asp:Label>
                                </ItemTemplate>
                                <ControlStyle Font-Bold="True" />
                                <HeaderStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>

<PagerSettings FirstPageText="Start" LastPageText="End" Mode="NumericFirstLast"></PagerSettings>
                    </asp:GridView>
                </td>

            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr pagersettings-pagebuttoncount="5">
                <td align="center">
                    <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
                </td>

            </tr>
        </table>


</asp:Content>
