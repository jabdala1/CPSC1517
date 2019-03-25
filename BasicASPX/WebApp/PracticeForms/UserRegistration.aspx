<%@ Page Title="User Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="WebApp.PracticeForms.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>User Registration</h1>
    <table class="nav-justified">
        <tr>
            <td style="width: 286px; height: 21px;">
                <asp:Label ID="Instructions" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="width: 277px; height: 21px;"></td>
            <td style="height: 21px"></td>
        </tr>
        <tr>
            <td style="width: 286px; height: 21px;">
                <asp:Label ID="MessageLabel" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="width: 277px; height: 21px;">&nbsp;</td>
            <td style="height: 21px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:Label ID="Label11" runat="server" Text="First Name"></asp:Label>
            </td>
            <td style="width: 277px">
                <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:Label ID="Label12" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td style="width: 277px">
                <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:Label ID="Label3" runat="server" Text="User Name"></asp:Label>
            </td>
            <td style="width: 277px">
                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:Label ID="Label4" runat="server" Text="Email Address"></asp:Label>
            </td>
            <td style="width: 277px">
                <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:Label ID="Label5" runat="server" Text="Confirm Email"></asp:Label>
            </td>
            <td style="width: 277px">
                <asp:TextBox ID="ConfirmEmail" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="width: 277px">
                <input id="Password1" type="password" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px; height: 22px;">
                <asp:Label ID="Label7" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td style="width: 277px; height: 22px;">
                <input id="Password2" type="password" style="height: 23px" /></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 286px; height: 22px;">
                &nbsp;</td>
            <td style="width: 277px; height: 22px;">
                &nbsp;</td>
            <td style="height: 22px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:CheckBox ID="Terms" runat="server" />
                <asp:Label ID="Label13" runat="server" Text="I agree to the terms of the site"></asp:Label>
            </td>
            <td style="width: 277px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                &nbsp;</td>
            <td style="width: 277px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 286px">
                <asp:Button ID="SubmitForm" runat="server" Text="Submit Registration" OnClick="SubmitForm_Click" />
            </td>
            <td style="width: 277px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
