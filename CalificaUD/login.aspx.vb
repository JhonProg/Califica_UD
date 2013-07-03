Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session.Timeout = 10
        Session.Abandon()
    End Sub

    Public Sub cantar()
        Response.Write("cantar")
    End Sub



End Class