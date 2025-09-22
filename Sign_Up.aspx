<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sign_Up.aspx.cs" Inherits="Sign_Up" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>SignUp</title>
    <link href="Styles/Login.css" rel="stylesheet" />
</head>
<body style="background-image: url('http://localhost:22390/OnlineCarsWeb/Images/download.jpg')">
    <div>
        <div align = "center" style="background-color: #00FF99; border-radius:10px; opacity:90%; padding-top:1px; height:100px; 
            box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);">
			<h1 style="font-family: 'Arial Black'; font-size: xx-large; font-weight: 400; font-variant: small-caps; color: #0000FF;">
            Online Used Cars Sale and Purchase System</h1>
		</div>
        <div style="width:100%; height:20px;" align="center">
                <asp:Label ID="LBL_MESSAGE" runat="server" 
                    style="text-align:center; font-size:14pt; font-weight:bold;" 
                    ForeColor="Lime"></asp:Label>
            </div>
		<div >
			<div class="form" align="center" style="opacity:75%">
				<form id="Form1" runat="server">
                <table>
                <tr>
                    <td>
                        <asp:TextBox ID="TXT_USER_NAME" runat="server" TextMode="SingleLine" 
                            placeholder="User Name" Width="350px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="TXT_USER_NAME" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" >*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TXT_LOGIN_NAME" runat="server" TextMode="SingleLine" placeholder="Login Name" Width="350px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TXT_LOGIN_NAME" Display="Dynamic" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr> 
                <tr>
                    <td>
                        <asp:DropDownList ID="TXT_USER_TYPE" runat="server" placeholder="User Type" Width="350px" >
                            <asp:ListItem>Seller</asp:ListItem>
                            <asp:ListItem>Buyer</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="TXT_USER_TYPE" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" >*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TXT_PASSWORD" runat="server" TextMode="Password" placeholder="Password" Width="350px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="TXT_PASSWORD" Display="Dynamic" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TXT_CONFIRM_PASSWORD" runat="server" TextMode="Password" placeholder="Confirm Password" Width="350px" ></asp:TextBox>
                        </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                ControlToValidate="TXT_CONFIRM_PASSWORD" Display="Dynamic" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BTN_REGISTER" runat="server" Text="REGISTER" 
                        style="background-color: #00FF99; border-radius:5px; color: #000000; font-weight: bold;" 
                        onclick="BTN_REGISTER_Click" Width="350px"/>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <p class="message"><a href="Login.aspx" style="color: #0000FF; font-weight: bold;" Width="270px">Already have login</a></p>        
                    </td>
                </tr>
                </table>
                
				</form>
	  		</div>
		</div>
    </div>
</body>
</html>
