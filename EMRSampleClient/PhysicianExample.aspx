<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhysicianExample.aspx.cs" Inherits="EMRSampleClient.PhysicianExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Physician Example</h1>
    <form id="form1" runat="server">
        <div style="position:absolute;top:80px;width:430px;border:solid;border-width:1px;padding:5px;">
            <!-- Search -->
            <div>
                <asp:Label ID="Label12" runat="server" Text="Search by ID" Width="100px"></asp:Label>
                <asp:TextBox ID="txtSearch" runat="server" Width="250px"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            </div>
        </div>
        <div style="border-style: solid; border-color: inherit; position:absolute; top:170px; width:400px; border-width:1px; padding:5px; left: 10px; height: 515px;">
            <div style="position: relative; top: 10px; left: 5px;">
                <!-- Id -->
                <div>
                    <asp:Label ID="Label13" runat="server" Text="ID" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtID" runat="server" Width="200px" Enabled="false" ForeColor="#999999"></asp:TextBox>
                </div>
            </div>

             <div style="position: relative; top: 15px; left: 5px;">
                 <h3>Name</h3>
                <!-- Name -->
                <div>
                    <asp:Label ID="Label6" runat="server" Text="First" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtFirst" runat="server" Width="200px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label7" runat="server" Text="Last" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtLast" runat="server" Width="200px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label8" runat="server" Text="Middle" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtMiddle" runat="server" Width="200px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label9" runat="server" Text="Suffix" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtSuffix" runat="server" Width="50px"></asp:TextBox>
                </div>
            </div>
            <div style="position: relative; top: 15px; left: 5px;">
                 <h3>Address</h3>
                <!-- Address -->
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Street" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtStreet1" runat="server" Width="250px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Street" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtStreet2" runat="server" Width="250px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label3" runat="server" Text="City" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtCity" runat="server" Width="250px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label4" runat="server" Text="State" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtState" runat="server" Width="75px"></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label5" runat="server" Text="Zip" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtZip" runat="server" Width="75px"></asp:TextBox>
                </div>
            </div>

            <div style="position: relative; top: 40px; left: 5px;">
                <!-- Number -->
                <div>
                    <asp:Label ID="Label10" runat="server" Text="Phone #" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtNumber" runat="server" Width="200px"></asp:TextBox>
                </div>
            </div>
            <div style="position: relative; top: 60px; left: 5px;">
                <!-- Speciality -->
                <div>
                    <asp:Label ID="Label11" runat="server" Text="Speciality" Width="75px"></asp:Label>
                    <asp:TextBox ID="txtSpeciality" runat="server" Width="250px"></asp:TextBox>
                </div>
            </div>
            <div style="position: relative; top: 90px; left: 1px;">
                <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </div>
        </div>

    </form>

    
</body>
</html>
