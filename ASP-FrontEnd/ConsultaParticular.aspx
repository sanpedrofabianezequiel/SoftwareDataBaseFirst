<%@ Page Title="" Language="C#" MasterPageFile="~/MenuMasterPage.Master" AutoEventWireup="true" CodeBehind="ConsultaParticular.aspx.cs" Inherits="ASP_FrontEnd.ConsultaParticular" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <br />  
    <div>   
        <h2> Vista de Libros Particular</h2>
        <asp:GridView ID="gvLibrosParticular" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="252px" Width="695px" AllowPaging="True" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="gvLibrosParticular_SelectedIndexChanged">
           
         
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
           
         
            <FooterStyle BackColor="#CCCC99" ForeColor="Black"/>
            <HeaderStyle BackColor="#333333" Font-Bold="true" ForeColor="White"/>
            <PagerStyle ForeColor="Black" HorizontalAlign="Right" BackColor="White"/>
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="true" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7"/>
            <SortedAscendingHeaderStyle BackColor="#4B4B4B"/>
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle  BackColor="#242121"/>
        </asp:GridView>
    </div>

    <div >

        <asp:ListBox ID ="lbAutores" runat="server" CssClass="w-100"></asp:ListBox>
    </div>    




</asp:Content>
