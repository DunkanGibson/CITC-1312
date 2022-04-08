<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HomePage.aspx.vb" Inherits="MSDN.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 0; background: gray;">
    <form id="form1" runat="server" style="margin: 0;">
        <div style="background: blue; height: 70px; display: flex; justify-content: center; ">
            <p style=" color: white; font-size: 30px">
            My .Net First Website
            </p>
        </div>
        
        <div style="display: flex; justify-content: center; ">
            <span style="color: rgb(0, 0, 0); font-family: &quot;Segoe UI&quot;, SegoeUI, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">
            <br />
            Welcome to my first website made with .NET
            <br />
            <br />
            Please enter your Name:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Display Name" />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor = "Black"></asp:Label> 
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" Width="350px" BorderWidth="1px" NextPrevFormat="FullMonth">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt" ForeColor="#333333" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" Font-Bold="True" BorderWidth="4px" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
                &nbsp;<br />
            <br />
            <br />
            </span>
        </div>
    </form>
</body>
</html>
