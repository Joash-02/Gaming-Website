@Code
    ViewData("Title") = "Home Page"
End Code

<header>
    <br />
    <img src="~/Resources/Images/Logo.png" style="width:100px; height:100px;" />

    <style>
        * {
            box-sizing: border-box;
        }

        /* Create two equal columns that floats next to each other */
        .column {
            float: left;
            width: 50%;
            padding: 10px;
            height: 300px; /* Should be removed. Only for demonstration */
            color: cadetblue;
        }

        /* Clear floats after the columns */
        .row:after {
            content: "";
            display: table;
            clear: both;
        }

        body {
            background-color: rgba(34,34,34);
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: cover;
        }

        .button {
            background-color: rgba(255, 100, 57);
            border: none;
            color: white;
            padding: 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
        }

        .button5 {
            border-radius: 50px;
        }
    </style>

</header>
<br />

<body>
    <button class="button button5" ><img src="~/Resources/Images/Xbox.png" style="width:50px; height:50px;"/></button>
    <button class="button button5"><img src="~/Resources/Images/Playstation.png" style="width:50px; height:50px;"/></button>
    <button class="button button5"><img src="~/Resources/Images/Nintendo.png" style="width:50px; height:50px;"/></button>

    <br />
    <br />


    <div class="row">
        <div class=" text-center">
            <div class="column" style="background-color: rgba(255, 100, 57);">
                <h2>Column 1</h2>
                <p>Some text..</p>
            </div>
        </div>
        <div class="column" style="background-color: rgba(255, 100, 57);">
            <div class="text-center">
                <h2>Column 2</h2>
                <p>Some text..</p>
            </div>
        </div>
    </div>
</body>