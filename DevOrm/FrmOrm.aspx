<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmOrm.aspx.cs" Inherits="DevOrm.FrmOrm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Dapper를 사용한 데이터 입력과 출력</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>데이터 입력</h2>
        <br />이름: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />설명: <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <br />주소: <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />전화: <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <br /><asp:Button ID="btnSave" runat="server" Text="저장" 
            OnClick="btnSave_Click" />
        <h2>데이터 출력</h2>
        <asp:GridView ID="lstWarehouses" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
