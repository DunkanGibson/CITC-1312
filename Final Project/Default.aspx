<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Final_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron jumbotron-fluid">
        <div class="container">
            <h1 class="display-4">
                Majors and thier Respective Chairs
            </h1>
          
            <p class="lead">Please see below to find the chair of your our Majors offered.</p>
        </div>

    </div>

    <div style="display: flex; justify-content: center; color: black;">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="AccessDataSource1" EmptyDataText="There are no data records to display." Height="205px" Width="993px" DataKeyNames="major_ID">
            <Columns>
                <asp:BoundField DataField="major_Name" HeaderText="Name of Major" SortExpression="major_Name" />
                <asp:BoundField DataField="major_Chair" HeaderText="Name of Chair" SortExpression="major_Chair" />
                <asp:BoundField DataField="major_Phone" HeaderText="Phone Number" SortExpression="major_Phone" />
                <asp:BoundField DataField="major_ID" HeaderText="Major ID" ReadOnly="True" SortExpression="major_ID" />
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="D:\Code\CITC-1312\Final Project\bin\StudentDataBase.accdb" SelectCommand="SELECT [major_Name], [major_Chair], [major_Phone], [major_ID] FROM [Department]"></asp:AccessDataSource>

       </div>


    <div style="display: flex; justify-content: center; margin-top:50px; ">
        <h1>
            Students please see above to find the chair of your major
        </h1>
    </div>

    <div style="display: flex; justify-content: center; color: black;">
           <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="AccessDataSource2" EmptyDataText="There are no data records to display." Width="992px">
            <Columns>
                <asp:BoundField DataField="student_FirstName" HeaderText="First Name" SortExpression="student_FirstName" />
                <asp:BoundField DataField="student_LastName" HeaderText="Last Name" SortExpression="student_LastName" />
                <asp:BoundField DataField="major_ID" HeaderText="Major ID" SortExpression="major_ID" />
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource2" runat="server" DataFile="D:\Code\CITC-1312\Final Project\bin\StudentDataBase.accdb" SelectCommand="SELECT [student_FirstName], [student_LastName], [major_ID] FROM [Student]">
        </asp:AccessDataSource>

    </div>



</asp:Content>
