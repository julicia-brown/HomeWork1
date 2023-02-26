Public Class frmNumbers
    Private Sub lblInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstructions.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Visible = True

        Dim V As String = "Un"
        lblFrench.Text = V
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Visible = True

        Dim V As String = "Deux"
        lblFrench.Text = V
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Visible = True

        Dim V As String = "Trois"
        lblFrench.Text = V
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Visible = True

        Dim V As String = "Quatre"
        lblFrench.Text = V
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Visible = True

        Dim V As String = "Cinq"
        lblFrench.Text = V
    End Sub
End Class
