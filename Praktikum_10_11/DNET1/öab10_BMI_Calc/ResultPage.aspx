<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResultPage.aspx.cs" Inherits="ResultPage" %>
<%@ Register TagPrefix="myBMI" Namespace="BMICustomControl" Assembly="BMICustomControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           <h1>BMI ResultPage</h1>
            <p>BMI:</p>
            <asp:Label ID="BMI" runat="server" />
            <br />
            <myBMI:BMICC ID="BMIcc" Text="0" Runat="server" >
            </myBMI:BMICC>
            <br />  
            <p>Date:</p>
            <asp:Label ID="Date" runat="server" />
    </div>
    </form>
</body>
</html>
