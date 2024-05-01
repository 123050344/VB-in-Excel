
Imports System.IO
Imports OfficeOpenXml

Public Class Form1

    Dim id As Integer

    Public Sub New()
        InitializeComponent()
        id = 0
        lstvData.FullRowSelect = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim x As MyItem

        id = id + 1
        Dim description As String = txtDescription.Text
        Dim price As Decimal = Math.Round((New Random()).NextDouble() * 1000, 2)
        x = New MyItem(id, description, price)
        lstItems.Items.Add(x.ToString())

        Dim row As New ListViewItem({x.Id.ToString(), x.Description, x.Price.ToString()})
        lstvData.Items.Add(row)

        UpdateLabel()
        UpdateTotal()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each item As ListViewItem In lstvData.SelectedItems
            lstvData.Items.Remove(item)
        Next
        UpdateLabel()
        UpdateTotal()
    End Sub

    Sub UpdateLabel()
        lblCount.Text = lstvData.Items.Count.ToString()
    End Sub

    Sub UpdateTotal()
        Dim total As Decimal = 0
        For Each item As ListViewItem In lstvData.Items
            total += Decimal.Parse(item.SubItems(2).Text)
        Next
        LblTotal.Text = total.ToString()
    End Sub

    Private Sub ExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click

        If lstvData.Items.Count = 0 Then
            MessageBox.Show("There is no data to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim filePath As String = Path.Combine(desktopPath, "archive.xlsx")

        Try

            Using package As New ExcelPackage(New FileInfo(filePath))
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Datas")
                worksheet.Cells("A1").Value = "ID"
                worksheet.Cells("B1").Value = "Descriptión"
                worksheet.Cells("C1").Value = "Price"

                Dim row As Integer = 2
                For Each item As ListViewItem In lstvData.Items
                    worksheet.Cells("A" & row).Value = item.SubItems(0).Text
                    worksheet.Cells("B" & row).Value = item.SubItems(1).Text
                    worksheet.Cells("C" & row).Value = item.SubItems(2).Text
                    row += 1
                Next


                package.Save()
            End Using

            MessageBox.Show("Data exported to Excel successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error when exporting data to Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

