<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COMP229_F2016_Assignment2_Part3.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <!-- Name: Rutvik Patel, Dhruv Patel -->
<!-- Student ID: 300877075, 300856248 -->
<!-- Date: October 5, 2016 -->
<!-- Default.aspx file -->
        <div class="row">
            <!--Grid Layout -->
            <div class="col-md-6">

                <!--Jumbotron to take in the Games  -->
                  <button type="button" class="btn btn-primary">Game 1</button>
                <div class="jumbotron">
                     <asp:GridView ID="teamGridView" runat="server" AutoGenerateColumns="false"
                         CssClass="table-table-bordered table-striped table-hover">
                           <Columns>
                        <asp:BoundField DataField="Rankings" HeaderText="Rankings" Visible="true" />
                        <asp:BoundField DataField="Teams" HeaderText="Teams" Visible="true" />
                        <asp:BoundField DataField="points" HeaderText="points" Visible="true" />
                        <asp:BoundField DataField="Result" HeaderText="Result" Visible="true" />
                        
                    </Columns>
                     </asp:GridView>
                  
                </div>
                <!--Button for the games -->
              
            </div>
            <div class="col-md-6">
                <button type="button" class="btn btn-primary">Game 2</button>
                <div class="jumbotron">

                </div>
                
            </div>
            <div class="col-md-6">
                 <button type="button" class="btn btn-primary">Game 3</button>
                <div class="jumbotron">

                </div>
               
            </div>
            <div class="col-md-6">
                <button type="button" class="btn btn-primary">Game 4</button>
                <div class="jumbotron">

                </div>
                
            </div>
        </div>
    </div>
</asp:Content>
