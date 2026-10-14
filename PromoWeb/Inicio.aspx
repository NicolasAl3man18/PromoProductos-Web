<%@ Page Title="" Language="C#" MasterPageFile="~/MeMaster.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="PromoWeb.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row">
    
    <div class="col-2"></div>    
    <div class="col">
        <hr />
        
        <div class="mb-3">
            <label for="TxtVaucher" class="form-label">Ingrese Voucher</label>
            
            <asp:TextBox ID="TxtVaucher" CssClass="form-control input-vaucher-grande" runat="server" placeholder="Ingrese Por Favor Su Voucher"></asp:TextBox>
        </div>
        
        <div>
            <asp:Button ID="btnVaucher" CssClass="btn btn-primary" runat="server" OnClick="btnVaucher_Click" Text="Verificar" />
            <asp:Label ID="lbMensaje" runat="server" fontColor="red"></asp:Label>
        </div>
    </div>
    <div class="col-2"></div>
</div>





</asp:Content>


