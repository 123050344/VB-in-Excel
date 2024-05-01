<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lstvData = New ListView()
        btnsave = New Button()
        txtDescription = New TextBox()
        lblCount = New Label()
        lstItems = New ListView()
        LblTotal = New Label()
        btnRemove = New Button()
        btnExportToExcel = New Button()
        SuspendLayout()
        ' 
        ' lstvData
        ' 
        lstvData.Location = New Point(419, 158)
        lstvData.Name = "lstvData"
        lstvData.Size = New Size(369, 206)
        lstvData.TabIndex = 0
        lstvData.UseCompatibleStateImageBehavior = False
        lstvData.View = View.List
        ' 
        ' btnsave
        ' 
        btnsave.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnsave.Location = New Point(419, 12)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(167, 47)
        btnsave.TabIndex = 1
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(36, 39)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(333, 60)
        txtDescription.TabIndex = 2
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Location = New Point(433, 394)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(0, 15)
        lblCount.TabIndex = 3
        ' 
        ' lstItems
        ' 
        lstItems.Location = New Point(21, 158)
        lstItems.Name = "lstItems"
        lstItems.Size = New Size(369, 206)
        lstItems.TabIndex = 4
        lstItems.UseCompatibleStateImageBehavior = False
        lstItems.View = View.List
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Location = New Point(93, 379)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(0, 15)
        LblTotal.TabIndex = 5
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnRemove.Location = New Point(419, 82)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(167, 47)
        btnRemove.TabIndex = 6
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnExportToExcel.Location = New Point(612, 52)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(167, 47)
        btnExportToExcel.TabIndex = 7
        btnExportToExcel.Text = "Export"
        btnExportToExcel.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExportToExcel)
        Controls.Add(btnRemove)
        Controls.Add(LblTotal)
        Controls.Add(lstItems)
        Controls.Add(lblCount)
        Controls.Add(txtDescription)
        Controls.Add(btnsave)
        Controls.Add(lstvData)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstvData As ListView
    Friend WithEvents btnsave As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lstItems As ListView
    Friend WithEvents LblTotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnExportToExcel As Button
End Class
