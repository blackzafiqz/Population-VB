Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For index As Integer = 1 To 30
            boxDays.Items.Add(index)
            boxOrganisms.Items.Add(index)
        Next

    End Sub
End Class
