<%@ Page Title="" Language="C#" MasterPageFile="~/MenuMasterPage.Master" AutoEventWireup="true" CodeBehind="ConsultaLibrosGeneral.aspx.cs" Inherits="ASP_FrontEnd.ConsultaLibrosGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />  
    <div>   
        <h2> Vista de Libros</h2>
        <asp:GridView ID="gvLibros" runat="server" CellPadding="4" Height="252px" Width="695px" AllowPaging="True" ForeColor="#333333" GridLines="None">
           
         
            <AlternatingRowStyle BackColor="White" />
           
         
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True"/>
            <HeaderStyle BackColor="#990000" Font-Bold="true" ForeColor="White"/>
            <PagerStyle ForeColor="#333333" HorizontalAlign="Center" BackColor="#FFCC66"/>
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333"/>
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="true" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC"/>
            <SortedAscendingHeaderStyle BackColor="#4D0000"/>
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle  BackColor="#820000"/>
        </asp:GridView>
    </div>

</asp:Content>
