Imports Newtonsoft.Json
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim jsonFilePath = Path.Combine(Application.StartupPath, "JSON Files", "10094547.json")
            Dim reportData = New ReadJsonData().ReadReportModel(jsonFilePath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
