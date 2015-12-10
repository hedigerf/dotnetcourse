<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BMI.aspx.cs" Inherits="BMI" %>
<%@ Register TagPrefix="my" TagName="DateInputField" Src="DateInputField.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>BMI Calculator</h1>
        <p>Gewicht in kg:</p>
        <asp:TextBox ID="myWeight" runat="server" />
        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="myWeight" ErrorMessage="Sie müssen ein Gewicht eintragen" >
        </asp:RequiredFieldValidator>
        <asp:RangeValidator id="RangeValidator1" runat="server" ControlToValidate="myWeight" MinimumValue="40" MaximumValue="200" Type="Double" ErrorMessage="Das Gewicht muss zwischen 40 und 200 liegen" >
        </asp:RangeValidator>
        <p>Grösse in m:</p>
        <asp:TextBox ID="myHeight" runat="server" />
        <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="myHeight" ErrorMessage="Sie müssen eine Grösse eintragen" >
        </asp:RequiredFieldValidator>
        <asp:RangeValidator id="RangeValidator2" runat="server" ControlToValidate="myHeight" MinimumValue="1.00" MaximumValue="3.00" Type="Double" ErrorMessage="Die Grösse muss zwischen 1.0. und 3.00 liegen" >
        </asp:RangeValidator>
        <p>Datum</p>
        <br /><my:DateInputField ID="dateField" Text="01.01.1900" Runat="server" />
        <br /><br />
        <asp:Button ID="reset" Text="reset" OnClick="Reset" runat="server" />
        <asp:Button ID="calculate" Text="calculate" OnClick="CalculateBMI" runat="server" />
        <asp:Button ID="go" Text="go" OnClick="transferPage" runat="server" />
        <br /><br />
        <asp:Label ID="myBMI" runat="server" />
        <asp:TextBox ID="myBMItxtB" runat="server" /> 
    </div>
    </form>
</body>
</html>
