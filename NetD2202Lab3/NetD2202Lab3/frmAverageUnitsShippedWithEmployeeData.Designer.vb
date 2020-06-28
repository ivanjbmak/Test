<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AUSWithEmployeeDataform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.txtEmployee1Input = New System.Windows.Forms.TextBox()
        Me.txtEmployee2Input = New System.Windows.Forms.TextBox()
        Me.txtEmployee3Input = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployee1AverageOutput = New System.Windows.Forms.Label()
        Me.lblEmployee2AverageOutput = New System.Windows.Forms.Label()
        Me.lblEmployee3AverageOutput = New System.Windows.Forms.Label()
        Me.lblOverallAverage = New System.Windows.Forms.Label()
        Me.ttpAverageUnitsShippedandEmployeeData = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(34, 26)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(26, 13)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(34, 49)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units:"
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.Location = New System.Drawing.Point(74, 46)
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(45, 20)
        Me.txtUnitsInput.TabIndex = 2
        Me.ttpAverageUnitsShippedandEmployeeData.SetToolTip(Me.txtUnitsInput, "Enter the Units shipped per day")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(56, 81)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(73, 21)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1 "
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(192, 81)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(73, 23)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(319, 81)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(73, 23)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtEmployee1Input
        '
        Me.txtEmployee1Input.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmployee1Input.Location = New System.Drawing.Point(37, 100)
        Me.txtEmployee1Input.Multiline = True
        Me.txtEmployee1Input.Name = "txtEmployee1Input"
        Me.txtEmployee1Input.ReadOnly = True
        Me.txtEmployee1Input.Size = New System.Drawing.Size(115, 143)
        Me.txtEmployee1Input.TabIndex = 6
        Me.ttpAverageUnitsShippedandEmployeeData.SetToolTip(Me.txtEmployee1Input, "List of Employee Units shipped for the week")
        '
        'txtEmployee2Input
        '
        Me.txtEmployee2Input.Location = New System.Drawing.Point(167, 100)
        Me.txtEmployee2Input.Multiline = True
        Me.txtEmployee2Input.Name = "txtEmployee2Input"
        Me.txtEmployee2Input.ReadOnly = True
        Me.txtEmployee2Input.Size = New System.Drawing.Size(115, 143)
        Me.txtEmployee2Input.TabIndex = 7
        '
        'txtEmployee3Input
        '
        Me.txtEmployee3Input.Location = New System.Drawing.Point(300, 100)
        Me.txtEmployee3Input.Multiline = True
        Me.txtEmployee3Input.Name = "txtEmployee3Input"
        Me.txtEmployee3Input.ReadOnly = True
        Me.txtEmployee3Input.Size = New System.Drawing.Size(115, 143)
        Me.txtEmployee3Input.TabIndex = 8
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(34, 326)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(115, 23)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttpAverageUnitsShippedandEmployeeData.SetToolTip(Me.btnEnter, "Press to calculate all averages of employees")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(167, 326)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttpAverageUnitsShippedandEmployeeData.SetToolTip(Me.btnReset, "Press reset to clear all data ")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(300, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ttpAverageUnitsShippedandEmployeeData.SetToolTip(Me.btnExit, "Press to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployee1AverageOutput
        '
        Me.lblEmployee1AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1AverageOutput.Location = New System.Drawing.Point(34, 257)
        Me.lblEmployee1AverageOutput.Name = "lblEmployee1AverageOutput"
        Me.lblEmployee1AverageOutput.Size = New System.Drawing.Size(118, 23)
        Me.lblEmployee1AverageOutput.TabIndex = 9
        Me.lblEmployee1AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2AverageOutput
        '
        Me.lblEmployee2AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2AverageOutput.Location = New System.Drawing.Point(167, 257)
        Me.lblEmployee2AverageOutput.Name = "lblEmployee2AverageOutput"
        Me.lblEmployee2AverageOutput.Size = New System.Drawing.Size(118, 23)
        Me.lblEmployee2AverageOutput.TabIndex = 10
        Me.lblEmployee2AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3AverageOutput
        '
        Me.lblEmployee3AverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3AverageOutput.Location = New System.Drawing.Point(297, 257)
        Me.lblEmployee3AverageOutput.Name = "lblEmployee3AverageOutput"
        Me.lblEmployee3AverageOutput.Size = New System.Drawing.Size(118, 23)
        Me.lblEmployee3AverageOutput.TabIndex = 11
        Me.lblEmployee3AverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverallAverage
        '
        Me.lblOverallAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallAverage.Location = New System.Drawing.Point(34, 290)
        Me.lblOverallAverage.Name = "lblOverallAverage"
        Me.lblOverallAverage.Size = New System.Drawing.Size(381, 23)
        Me.lblOverallAverage.TabIndex = 12
        Me.lblOverallAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AUSWithEmployeeDataform
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.Controls.Add(Me.lblOverallAverage)
        Me.Controls.Add(Me.lblEmployee3AverageOutput)
        Me.Controls.Add(Me.lblEmployee2AverageOutput)
        Me.Controls.Add(Me.lblEmployee1AverageOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtEmployee3Input)
        Me.Controls.Add(Me.txtEmployee2Input)
        Me.Controls.Add(Me.txtEmployee1Input)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AUSWithEmployeeDataform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped With Employee Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnitsInput As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtEmployee1Input As TextBox
    Friend WithEvents txtEmployee2Input As TextBox
    Friend WithEvents txtEmployee3Input As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployee1AverageOutput As Label
    Friend WithEvents lblEmployee2AverageOutput As Label
    Friend WithEvents lblEmployee3AverageOutput As Label
    Friend WithEvents lblOverallAverage As Label
    Friend WithEvents ttpAverageUnitsShippedandEmployeeData As ToolTip
End Class
