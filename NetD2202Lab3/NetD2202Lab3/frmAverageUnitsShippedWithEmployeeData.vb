'Author: Yu Ting Lin
'Last Modified: 6/27/2020
'Description: This windows form takes up to 7 numeric units shipped quantities each value representing a day,
'against three employees while using two dimensional arrays and validating input. 

Option Strict On
Public Class AUSWithEmployeeDataform

#Region "Variable Declarations"
    Private Const MIN_UNITS As Integer = 0 'minimum accepted value is 0
    Private Const MAX_UNITS As Integer = 5000 'maximum accepted value is 5000

    Dim day As Integer = 0 'set day as integer
    Dim employee As Integer = 0 'set employee as integer 

    Dim employeeWeeklyTotalUnitsShipped As Double 'set an employees total units as double
    Dim overallTotalUnitsShipped As Double 'set over all total as double 

    Dim weeklyAverageUnitsShipped As Double 'set an weekly average per employee as a double
    Dim overallAverageUnitsShipped As Double 'set overall total average as double 

    Dim unitsArray(2, 6) As Double

    Dim textboxArray() As TextBox
    Dim outputLabelArray() As Label

#End Region

#Region "Functions and Subroutines"

    Sub ClearControls(controlArray As Control())
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty
        Next
    End Sub
    Sub SetTextboxesEnabled(textboxArray As TextBox(), enabledStatus As Boolean)
        For Each textboxToSet As TextBox In textboxArray
            textboxToSet.Enabled = enabledStatus
        Next
    End Sub


    Sub SetDefaults()
        ClearControls(textboxArray)
        ClearControls(outputLabelArray)
        lblOverallAverage.Text = String.Empty

        SetTextboxesEnabled(textboxArray, True)

        day = 0
        employee = 0
        lblDay.Text = "Day " & (day + 1)

        employeeWeeklyTotalUnitsShipped = 0
        overallTotalUnitsShipped = 0
        lblOverallAverage.Text = String.Empty
        txtUnitsInput.Focus()
    End Sub


#End Region

#Region "Event Handlers"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    Private Sub frmAverageUnitsShippedWithEmployeeData_load(sender As Object, e As EventArgs) Handles MyBase.Load
        textboxArray = {txtEmployee1Input, txtEmployee2Input, txtEmployee3Input}
        outputLabelArray = {lblEmployee1AverageOutput, lblEmployee2AverageOutput, lblEmployee3AverageOutput}
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Const DaysinWeek As Integer = 7
        Const NumberOfEmployees As Integer = 3


        If Double.TryParse(txtUnitsInput.Text, unitsArray(employee, day)) Then

            If unitsArray(employee, day) <= MAX_UNITS And unitsArray(employee, day) >= MIN_UNITS Then
                weeklyAverageUnitsShipped += unitsArray(employee, day)

                textboxArray(employee).Text &= unitsArray(employee, day) & vbCrLf

                day += 1
                lblDay.Text = "Day " & (day + 1)

                txtUnitsInput.Clear()

                If day = DaysinWeek Then

                    employeeWeeklyTotalUnitsShipped = 0

                    For dayCounter As Integer = 0 To DaysinWeek - 1
                        employeeWeeklyTotalUnitsShipped += unitsArray(employee, dayCounter)
                    Next

                    weeklyAverageUnitsShipped = employeeWeeklyTotalUnitsShipped / DaysinWeek
                    outputLabelArray(employee).Text = "Average: " & Math.Round(weeklyAverageUnitsShipped, 2)


                    employee += 1

                    day = 0
                    lblDay.Text = "Day " & (day + 1)



                    If employee = NumberOfEmployees Then

                        For Each day In unitsArray
                            overallTotalUnitsShipped += day
                        Next

                        overallAverageUnitsShipped = overallTotalUnitsShipped / unitsArray.Length
                        lblOverallAverage.Text = "Average: " & Math.Round(overallAverageUnitsShipped, 2)

                        txtUnitsInput.Enabled = False
                        btnEnter.Enabled = False
                        btnReset.Focus()

                        lblDay.Text = "Done"

                    End If

                End If
            Else
                MessageBox.Show("Please ensure that your input number is between 0 and 5000 inclusive.")
                txtUnitsInput.SelectAll()
            txtUnitsInput.Focus()
        End If
        Else
            MessageBox.Show("Units must be entered as a number.")
            txtUnitsInput.SelectAll()
            txtUnitsInput.Focus()
        End If




    End Sub


#End Region


End Class
