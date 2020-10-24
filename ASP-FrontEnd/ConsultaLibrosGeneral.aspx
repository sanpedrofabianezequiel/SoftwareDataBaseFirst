<%@ Page Title="" Language="C#" MasterPageFile="~/MenuMasterPage.Master" AutoEventWireup="true" CodeBehind="ConsultaLibrosGeneral.aspx.cs" Inherits="ASP_FrontEnd.ConsultaLibrosGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />  
    <div>   
        <h2> Vista de Libros</h2>
        <asp:GridView ID="gvLibros" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="252px" Width="695px" AllowPaging="true">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510"/>
            <HeaderStyle BackColor="ActiveBorder" Font-Bold="true" ForeColor="White"/>
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center"/>
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510"/>
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="true" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4"/>
            <SortedAscendingHeaderStyle BackColor="#B95C30"/>
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle  BackColor="#93451F"/>
        </asp:GridView>
    </div>

</asp:Content>
