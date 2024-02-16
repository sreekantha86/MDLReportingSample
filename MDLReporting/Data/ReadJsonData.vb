Imports System.IO
Imports Newtonsoft.Json

Public Class ReadJsonData
    Public Function ReadReportModel(ByVal path As String) As ReportModel
        Dim reportData As New ReportModel
        If File.Exists(path) Then
            Dim jsonData As String = File.ReadAllText(path)
            reportData = JsonConvert.DeserializeObject(Of ReportModel)(jsonData)
        End If
        Return reportData
    End Function
End Class
