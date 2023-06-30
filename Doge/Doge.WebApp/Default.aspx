<%@ Page Title="Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Doge.WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>Order List</h2>
        <div>
            <asp:ListView ID="ordersList" runat="server"
                ItemType="Doge.Model.Order">
                <LayoutTemplate>
                    <table cellpadding="2" width="640px" border="1" id="tbl1" runat="server">
                        <tr runat="server" style="background-color: #98FB98">
                            <th runat="server">Order ID</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder" />
                    </table>
                    <asp:DataPager ID="orderPager" runat="server">
                        <Fields>
                            <asp:NumericPagerField />
                        </Fields>
                    </asp:DataPager>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
