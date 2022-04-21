<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Final_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="">
        <h1 class="display-4">
            Majors and thier Respective Chairs
        </h1>
        <p>Please see below to find the chair of your our Majors offered.</p>



    </div>

    <div style="display: flex; justify-content: center; color: black;">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="AccessDataSource1" EmptyDataText="There are no data records to display." Height="205px" Width="993px">
            <Columns>
                <asp:BoundField DataField="major_Name" HeaderText="Name of Major" SortExpression="major_Name" />
                <asp:BoundField DataField="major_Chair" HeaderText="Chair of Major" SortExpression="major_Chair" />
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="D:\Code\CITC-1312\Final Project\bin\StudentDataBase.accdb" SelectCommand="SELECT [major_Name], [major_Chair] FROM [Department]"></asp:AccessDataSource>

       </div>

</asp:Content>
