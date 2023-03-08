Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function News() As ActionResult
        ViewData("Message") = "News:"

        Return View()
    End Function

    Function Shop() As ActionResult
        ViewData("Message") = "Shop:"

        Return View()
    End Function
End Class
