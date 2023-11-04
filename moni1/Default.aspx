<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="moni1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body style="background-image: url('80408-107252-image_banner.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-position: center center; background-size: cover;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>揪辦活動</strong></div>
        <table align="center" class="auto-style2">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="phoneLB" runat="server" Text="請輸入電話： "></asp:Label>
                    <asp:TextBox ID="phoneTB" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="loginBT" runat="server" Text="登入" OnClick="loginBT_Click" />
                    <asp:LinkButton ID="entryLBT" runat="server" Visible="False" OnClick="entryLBT_Click" PostBackUrl="~/parter.aspx">進入網頁</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="loginStateLB" runat="server" Text="登入狀態"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [member_name], [member_phone] FROM [Table] WHERE ([member_phone] = @member_phone)">
            <SelectParameters>
                <asp:ControlParameter ControlID="phoneTB" Name="member_phone" PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="phoneDetailsView" runat="server" AutoGenerateRows="False" DataKeyNames="member_phone" DataSourceID="SqlDataSource1" EmptyDataText="手機號錯誤" Height="50px" Visible="False" Width="125px">
            <Fields>
                <asp:BoundField DataField="member_name" HeaderText="member_name" SortExpression="member_name" />
                <asp:BoundField DataField="member_phone" HeaderText="member_phone" ReadOnly="True" SortExpression="member_phone" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
