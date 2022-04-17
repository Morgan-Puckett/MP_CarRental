'Morgan Puckett 
'RCET0265
'Spring 2022
'Car Rental
'https://github.com/Morgan-Puckett/MP_CarRental.git

Option Explicit On
Option Strict On
Option Compare Binary

Public Class MP_CarRental
    Dim errorMsg As String
    Dim MorK As Boolean
    Dim miles As Integer
    Dim discountA As String = ""
    Dim discountB As String = ""
    Dim cost As Integer
    Dim customerT, milesT, chargesT As Integer

    Private Sub MP_CarRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Car Rental Information"
        DisplayDistanceTextBox.Enabled = False
        MileageChargeTextBox.Enabled = False
        DayChargeTextBox.Enabled = False
        DiscountDisplayTextBox.Enabled = False
        OweTextBox.Enabled = False
        MilesRadiobutton.Enabled = True
    End Sub

    'Checks to see if Name is Entered and is not just numbers
    Function NameCheck(er As Boolean)

        Select Case NameTextBox.Text
            Case ""
                er = True
                errorMsg += vbCrLf + "Name Is not valid"
                NameTextBox.Focus()

            Case Else
                Try
                    NameTextBox.Text = CInt(NameTextBox.Text)
                    er = True
                    errorMsg += vbCrLf + "Name cannot include numbers"
                    NameTextBox.Focus()

                Catch ex As Exception
                    er = False

                End Try
                er = False
        End Select
        'This makes sure its filled out, but how do we verify it is a name?

        Return er
    End Function

    'Checks to see if address is entered 
    Function AddyCheck(er As Boolean)

        Select Case AddressTextBox.Text
            Case ""
                er = True
                errorMsg += vbCrLf + "Address Is not valid"
                AddressTextBox.Focus()
            Case Else
                er = False
        End Select
        Return er
    End Function

    'Checks to see if city is entered and is not just numbers 
    Function CityCheck(er As Boolean)

        Select Case CityTextBox.Text
            Case ""
                er = True
                errorMsg += vbCrLf + "City Is not valid"
                CityTextBox.Focus()
            Case Else
                Try
                    CityTextBox.Text = CInt(CityTextBox.Text)
                    er = True
                    errorMsg += vbCrLf + "City cannot include numbers"
                    CityTextBox.Focus()

                Catch ex As Exception
                    er = False

                End Try
                er = False
        End Select
        Return er
    End Function

    'Checks if state is entered 
    Function StateCheck(er As Boolean)

        Select Case StateTextBox.Text
            Case ""
                er = True
                errorMsg += vbCrLf + "State Is not valid"
                StateTextBox.Focus()
            Case Else
                Try
                    StateTextBox.Text = CInt(StateTextBox.Text)
                    er = True
                    errorMsg += vbCrLf + "State cannot include numbers"
                    StateTextBox.Focus()

                Catch ex As Exception
                    er = False

                End Try
                er = False
        End Select
        Return er
    End Function

    'Checks if zip is entered/numbers 
    Function ZipCheck(er As Boolean)
        Try
            ZipCodeTextBox.Text = CInt(ZipCodeTextBox.Text)
            er = False
            'check to see if it can convert blank to int, if not 
            'must creat validation of blank or not 
        Catch ex As Exception
            ZipCodeTextBox.Focus()
            er = True
            errorMsg += vbCrLf + "Zipcode must be a number"
        End Try
        Return er
    End Function

    'Checks if entered/numbers
    Function OdoCheck(er As Boolean)
        Try
            BegOdoReadTextBox.Text = CInt(BegOdoReadTextBox.Text)
            EndOdoReadTextBox.Text = CInt(EndOdoReadTextBox.Text)
            miles = EndOdoReadTextBox.Text - BegOdoReadTextBox.Text
            er = False
            If BegOdoReadTextBox.Text > EndOdoReadTextBox.Text Then
                errorMsg += "Ending Odometer must be greater than start mileage"
                BegOdoReadTextBox.Focus()
                er = True
            End If

        Catch ex As Exception
            er = True
            errorMsg += vbCrLf + "Odometers must read as a number"
            BegOdoReadTextBox.Focus()
        End Try
        Return er
    End Function

    'Checks if entered/numbers 
    Function DaysCheck(er As Boolean)
        Try
            NumOfDaysTextBox.Text = CInt(NumOfDaysTextBox.Text)
            er = False
            If NumOfDaysTextBox.Text <= 0 Or NumOfDaysTextBox.Text > 45 Then
                errorMsg += "Days must be between 1 - 45"
                er = True
                NumOfDaysTextBox.Focus()
            End If

        Catch ex As Exception
            er = True
            errorMsg += vbCrLf + "Days must be a valid number"
            NumOfDaysTextBox.Focus()
        End Try
        Return er
    End Function

    'Checks if entered/numbers 
    Function MilesTotal()

        Dim m1 As Integer = 0
        Dim m2 As Integer = 0
        Dim milesCost As Integer = 0

        If miles > 200 Then
            m1 = miles - 200
            If m1 > 500 Then
                m2 = m1 - 300
                milesCost += m2 * 0.1
            End If
            If m1 > 300 Then
                m1 = 300
            End If
            milesCost += m1 * 0.12

        Else
            milesCost = 0
        End If
        If MorK = 0 Then
            milesCost = milesCost * 0.62
            miles = 0.62 * miles
        End If
        Return milesCost
    End Function

    'Checks if discount boxes are checked
    Function DiscountCheck()
        Dim erA, erB, erC As Integer
        If discountA = "AAA" Then
            erA = cost * 0.05
        End If
        If discountB = "Senior" Then
            erB += cost * 0.03
        End If
        erC = erA + erB
        Return erC
    End Function

    'Checks total cost(once all boxes are verified, submits to summary
    Function CalculateCost()
        Dim er As Integer
        cost = 0
        cost += NumOfDaysTextBox.Text * 15
        cost += MilesTotal()
        cost = cost - DiscountCheck()
        er = MsgBox($"All information is as follows: " + vbCrLf +
                   $"Name: {NameTextBox.Text}" + vbCrLf +
                   $"Address: {AddressTextBox.Text}" + vbCrLf +
                   $"City: {CityTextBox.Text}" + vbCrLf +
                   $"State: {StateTextBox.Text}" + vbCrLf +
                   $"ZipCode: {ZipCodeTextBox.Text}" + vbCrLf +
                   $"{miles} miles over {NumOfDaysTextBox.Text} day(s) using the {discountA + " " + discountB} discount applied" + vbCrLf +
                   $"With a total charge of ${cost}" + vbCrLf + vbCrLf +
                   "If all this information looks correct, Press yes to submit this customer information", MsgBoxStyle.Question.YesNo, "Submit Form")
        If er = 6 Then
            Summary()
        End If
        Return cost
    End Function

    'Clears all boxes, not summary
    Sub ClearAll()
        DisplayDistanceTextBox.Text = ""
        MileageChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        DiscountDisplayTextBox.Text = ""
        OweTextBox.Text = ""
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BegOdoReadTextBox.Text = ""
        EndOdoReadTextBox.Text = ""
        NumOfDaysTextBox.Text = ""
        MilesRadiobutton.Checked = True
        AAACheckBox.Checked = False
        SeniorCheckBox.Checked = False
    End Sub

    'Places info into the disabled text boxes
    Sub DisplayMoney()
        DisplayDistanceTextBox.Text = miles
        MileageChargeTextBox.Text = MilesTotal()
        DayChargeTextBox.Text = (NumOfDaysTextBox.Text * 15)
        DiscountDisplayTextBox.Text = DiscountCheck()
        OweTextBox.Text = cost
    End Sub

    'Adds info to summary
    Sub Summary()
        customerT += 1 + customerT
        milesT += miles + milesT
        chargesT += cost + chargesT
    End Sub

    'Validates info and displays
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim er As Boolean
        If DaysCheck(er) Or OdoCheck(er) Or ZipCheck(er) Or StateCheck(er) Or CityCheck(er) Or AddyCheck(er) Or NameCheck(er) = True Then
            MsgBox(errorMsg)
            'This gets focus correct, nut how can I make the order correct(without overcomplicating it)
        Else
            CalculateCost()
            DisplayMoney()
        End If

        errorMsg = ""
    End Sub

    'mi or km
    Private Sub MilesRadiobutton_CheckedChanged(sender As Object, e As EventArgs) Handles MilesRadiobutton.CheckedChanged
        MorK = 1
    End Sub
    Private Sub KilometersRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles KilometersRadioButton.CheckedChanged
        MorK = 0
    End Sub

    'Checks for discounts
    Private Sub AAACheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AAACheckBox.CheckedChanged
        discountA = "AAA"
    End Sub
    Private Sub SeniorCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SeniorCheckBox.CheckedChanged
        discountB = "Senior"
    End Sub

    'Double checks if user would like to exit program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim er As Integer = 0
        er = MsgBox("Are you sure you would like to exit?", MsgBoxStyle.Question.YesNo)

        If er = 6 Then
            Me.Close()
        End If

    End Sub

    'Uses clear all function
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearAll()
    End Sub

    'Uses summary function
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim er As Integer
        er = MsgBox($"Total Customers: {customerT}" + vbCrLf +
               $"Total Miles Driven: {milesT} mi" + vbCrLf +
               $"Total Charges: ${chargesT}" + vbCrLf +
               "Would you like to clear this history?", MsgBoxStyle.Question.YesNo, "Clear form")
        If er = 6 Then
            ClearAll()
            customerT = 0
            milesT = 0
            chargesT = 0
        End If
    End Sub
End Class
