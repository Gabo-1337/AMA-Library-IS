Public Class HistoryForm
    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AMAInvDBDataSet.History' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.AMAInvDBDataSet.History)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        UpdateInv.Show()
        Me.Close()
    End Sub
End Class