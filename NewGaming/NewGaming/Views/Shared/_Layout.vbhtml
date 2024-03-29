﻿<!DOCTYPE html>
<style>
    body {
       
    }
</style>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Gaming Portal</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>

<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Gaming Portal", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("News", "News", "Home")</li>
                    <li>@Html.ActionLink("Shop", "Shop", "Home")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <div style="text-align: center;">
                <a href="https://www.facebook.com/EBGamesNZ"><img src="~/Resources/Images/Facebook.png" style="width:40px; height:40px;"/> | </a>
                <a href="https://www.instagram.com/ebgamesnz/?hl=en"><img src="~/Resources/Images/Instagram.png" style="width:40px; height:40px;"/> | </a>
                <a href="https://twitter.com/EBGamesAus?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor"><img src="~/Resources/Images/Twitter.png" style="width:40px; height:40px;"/></a>
                <h5 style="font-family:Arial, Helvetica, sans-serif">Email: Info@gamingportal.com</h5>
                <h5 style="font-family:Arial, Helvetica, sans-serif">Phone: 09 643 2345</h5>
                <h5 style="font-family:Arial, Helvetica, sans-serif">&copy; @DateTime.Now.Year - Gaming Portal</h5>
            </div>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
