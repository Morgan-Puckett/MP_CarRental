<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MP_CarRental
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
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.BegOdoReadLabel = New System.Windows.Forms.Label()
        Me.EndOdoReadLabel = New System.Windows.Forms.Label()
        Me.NumOfDaysLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BegOdoReadTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdoReadTextBox = New System.Windows.Forms.TextBox()
        Me.NumOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MilesOrKiloGroupBox = New System.Windows.Forms.GroupBox()
        Me.KilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.MilesRadiobutton = New System.Windows.Forms.RadioButton()
        Me.DiscountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.AAACheckBox = New System.Windows.Forms.CheckBox()
        Me.DistanceLabeel = New System.Windows.Forms.Label()
        Me.MileageChargeLabel = New System.Windows.Forms.Label()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.DicountAmountLabel = New System.Windows.Forms.Label()
        Me.OweLabel = New System.Windows.Forms.Label()
        Me.DisplayDistanceTextBox = New System.Windows.Forms.TextBox()
        Me.MileageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountDisplayTextBox = New System.Windows.Forms.TextBox()
        Me.OweTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MilesOrKiloGroupBox.SuspendLayout()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(114, 326)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(94, 27)
        Me.CalculateButton.TabIndex = 10
        Me.CalculateButton.Text = "Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Submits Information to Database")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(10, 11)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(94, 15)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Customer Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(202, 9)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(110, 23)
        Me.NameTextBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter your name")
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(10, 38)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(49, 15)
        Me.AddressLabel.TabIndex = 3
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(10, 63)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(28, 15)
        Me.CityLabel.TabIndex = 4
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(10, 88)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(33, 15)
        Me.StateLabel.TabIndex = 5
        Me.StateLabel.Text = "State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(10, 112)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(55, 15)
        Me.ZipCodeLabel.TabIndex = 6
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'BegOdoReadLabel
        '
        Me.BegOdoReadLabel.AutoSize = True
        Me.BegOdoReadLabel.Location = New System.Drawing.Point(10, 140)
        Me.BegOdoReadLabel.Name = "BegOdoReadLabel"
        Me.BegOdoReadLabel.Size = New System.Drawing.Size(157, 15)
        Me.BegOdoReadLabel.TabIndex = 7
        Me.BegOdoReadLabel.Text = "Beginner Odometer Reading"
        '
        'EndOdoReadLabel
        '
        Me.EndOdoReadLabel.AutoSize = True
        Me.EndOdoReadLabel.Location = New System.Drawing.Point(10, 166)
        Me.EndOdoReadLabel.Name = "EndOdoReadLabel"
        Me.EndOdoReadLabel.Size = New System.Drawing.Size(147, 15)
        Me.EndOdoReadLabel.TabIndex = 8
        Me.EndOdoReadLabel.Text = "Ending Odometer Reading"
        '
        'NumOfDaysLabel
        '
        Me.NumOfDaysLabel.AutoSize = True
        Me.NumOfDaysLabel.Location = New System.Drawing.Point(10, 194)
        Me.NumOfDaysLabel.Name = "NumOfDaysLabel"
        Me.NumOfDaysLabel.Size = New System.Drawing.Size(98, 15)
        Me.NumOfDaysLabel.TabIndex = 9
        Me.NumOfDaysLabel.Text = "Number Of Days "
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(202, 36)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(110, 23)
        Me.AddressTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AddressTextBox, "Enter current residence")
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(202, 61)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(110, 23)
        Me.CityTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Enter current City")
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(202, 86)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(110, 23)
        Me.StateTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.StateTextBox, "Enter current State")
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(202, 110)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(110, 23)
        Me.ZipCodeTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ZipCodeTextBox, "Enter current Zip Code")
        '
        'BegOdoReadTextBox
        '
        Me.BegOdoReadTextBox.Location = New System.Drawing.Point(202, 137)
        Me.BegOdoReadTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BegOdoReadTextBox.Name = "BegOdoReadTextBox"
        Me.BegOdoReadTextBox.Size = New System.Drawing.Size(110, 23)
        Me.BegOdoReadTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BegOdoReadTextBox, "Enter Number of Miles Prior to Rental ")
        '
        'EndOdoReadTextBox
        '
        Me.EndOdoReadTextBox.Location = New System.Drawing.Point(202, 164)
        Me.EndOdoReadTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EndOdoReadTextBox.Name = "EndOdoReadTextBox"
        Me.EndOdoReadTextBox.Size = New System.Drawing.Size(110, 23)
        Me.EndOdoReadTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.EndOdoReadTextBox, "Enter Number of Miles after Rental")
        '
        'NumOfDaysTextBox
        '
        Me.NumOfDaysTextBox.Location = New System.Drawing.Point(202, 192)
        Me.NumOfDaysTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumOfDaysTextBox.Name = "NumOfDaysTextBox"
        Me.NumOfDaysTextBox.Size = New System.Drawing.Size(110, 23)
        Me.NumOfDaysTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.NumOfDaysTextBox, "Enter Number of Days Rented")
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(317, 326)
        Me.SummaryButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(97, 27)
        Me.SummaryButton.TabIndex = 12
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Shows current database information, allows the user to clear database")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(214, 326)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(98, 27)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears all current information, does not clear database")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(419, 326)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(88, 27)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Closes Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MilesOrKiloGroupBox
        '
        Me.MilesOrKiloGroupBox.Controls.Add(Me.KilometersRadioButton)
        Me.MilesOrKiloGroupBox.Controls.Add(Me.MilesRadiobutton)
        Me.MilesOrKiloGroupBox.Location = New System.Drawing.Point(46, 239)
        Me.MilesOrKiloGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MilesOrKiloGroupBox.Name = "MilesOrKiloGroupBox"
        Me.MilesOrKiloGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MilesOrKiloGroupBox.Size = New System.Drawing.Size(264, 74)
        Me.MilesOrKiloGroupBox.TabIndex = 8
        Me.MilesOrKiloGroupBox.TabStop = False
        Me.MilesOrKiloGroupBox.Text = "Is Odometer in Miles or Kilometers?"
        Me.ToolTip1.SetToolTip(Me.MilesOrKiloGroupBox, "Specify if mi or km")
        '
        'KilometersRadioButton
        '
        Me.KilometersRadioButton.AutoSize = True
        Me.KilometersRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KilometersRadioButton.Location = New System.Drawing.Point(12, 50)
        Me.KilometersRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KilometersRadioButton.Name = "KilometersRadioButton"
        Me.KilometersRadioButton.Size = New System.Drawing.Size(81, 19)
        Me.KilometersRadioButton.TabIndex = 1
        Me.KilometersRadioButton.TabStop = True
        Me.KilometersRadioButton.Text = "Kilometers"
        Me.KilometersRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadiobutton
        '
        Me.MilesRadiobutton.AutoSize = True
        Me.MilesRadiobutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MilesRadiobutton.Location = New System.Drawing.Point(12, 23)
        Me.MilesRadiobutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MilesRadiobutton.Name = "MilesRadiobutton"
        Me.MilesRadiobutton.Size = New System.Drawing.Size(53, 19)
        Me.MilesRadiobutton.TabIndex = 0
        Me.MilesRadiobutton.TabStop = True
        Me.MilesRadiobutton.Text = "Miles"
        Me.MilesRadiobutton.UseVisualStyleBackColor = True
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAACheckBox)
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(375, 243)
        Me.DiscountsGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(289, 69)
        Me.DiscountsGroupBox.TabIndex = 9
        Me.DiscountsGroupBox.TabStop = False
        Me.DiscountsGroupBox.Text = "Discounts"
        Me.ToolTip1.SetToolTip(Me.DiscountsGroupBox, "Apply discounts. No one checks if youre an AAA member so just take the discount")
        '
        'SeniorCheckBox
        '
        Me.SeniorCheckBox.AutoSize = True
        Me.SeniorCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SeniorCheckBox.Location = New System.Drawing.Point(39, 45)
        Me.SeniorCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SeniorCheckBox.Name = "SeniorCheckBox"
        Me.SeniorCheckBox.Size = New System.Drawing.Size(148, 19)
        Me.SeniorCheckBox.TabIndex = 1
        Me.SeniorCheckBox.Text = "Senior Citizen Discount"
        Me.SeniorCheckBox.UseVisualStyleBackColor = True
        '
        'AAACheckBox
        '
        Me.AAACheckBox.AutoSize = True
        Me.AAACheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AAACheckBox.Location = New System.Drawing.Point(39, 20)
        Me.AAACheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AAACheckBox.Name = "AAACheckBox"
        Me.AAACheckBox.Size = New System.Drawing.Size(148, 19)
        Me.AAACheckBox.TabIndex = 0
        Me.AAACheckBox.Text = "AAA Member Discount"
        Me.AAACheckBox.UseVisualStyleBackColor = True
        '
        'DistanceLabeel
        '
        Me.DistanceLabeel.AutoSize = True
        Me.DistanceLabeel.Location = New System.Drawing.Point(399, 40)
        Me.DistanceLabeel.Name = "DistanceLabeel"
        Me.DistanceLabeel.Size = New System.Drawing.Size(136, 15)
        Me.DistanceLabeel.TabIndex = 22
        Me.DistanceLabeel.Text = "Distance Driven In Miles:"
        '
        'MileageChargeLabel
        '
        Me.MileageChargeLabel.AutoSize = True
        Me.MileageChargeLabel.Location = New System.Drawing.Point(446, 65)
        Me.MileageChargeLabel.Name = "MileageChargeLabel"
        Me.MileageChargeLabel.Size = New System.Drawing.Size(93, 15)
        Me.MileageChargeLabel.TabIndex = 23
        Me.MileageChargeLabel.Text = "Mileage Charge:"
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Location = New System.Drawing.Point(471, 90)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(71, 15)
        Me.DayChargeLabel.TabIndex = 24
        Me.DayChargeLabel.Text = "Day Charge:"
        '
        'DicountAmountLabel
        '
        Me.DicountAmountLabel.AutoSize = True
        Me.DicountAmountLabel.Location = New System.Drawing.Point(438, 115)
        Me.DicountAmountLabel.Name = "DicountAmountLabel"
        Me.DicountAmountLabel.Size = New System.Drawing.Size(104, 15)
        Me.DicountAmountLabel.TabIndex = 25
        Me.DicountAmountLabel.Text = "Discount Amount:"
        '
        'OweLabel
        '
        Me.OweLabel.AutoSize = True
        Me.OweLabel.Location = New System.Drawing.Point(485, 140)
        Me.OweLabel.Name = "OweLabel"
        Me.OweLabel.Size = New System.Drawing.Size(57, 15)
        Me.OweLabel.TabIndex = 26
        Me.OweLabel.Text = "You Owe:"
        '
        'DisplayDistanceTextBox
        '
        Me.DisplayDistanceTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.DisplayDistanceTextBox.Location = New System.Drawing.Point(551, 38)
        Me.DisplayDistanceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DisplayDistanceTextBox.Name = "DisplayDistanceTextBox"
        Me.DisplayDistanceTextBox.Size = New System.Drawing.Size(101, 23)
        Me.DisplayDistanceTextBox.TabIndex = 27
        '
        'MileageChargeTextBox
        '
        Me.MileageChargeTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.MileageChargeTextBox.Location = New System.Drawing.Point(551, 63)
        Me.MileageChargeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MileageChargeTextBox.Name = "MileageChargeTextBox"
        Me.MileageChargeTextBox.Size = New System.Drawing.Size(101, 23)
        Me.MileageChargeTextBox.TabIndex = 28
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.DayChargeTextBox.Location = New System.Drawing.Point(551, 88)
        Me.DayChargeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(101, 23)
        Me.DayChargeTextBox.TabIndex = 29
        '
        'DiscountDisplayTextBox
        '
        Me.DiscountDisplayTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.DiscountDisplayTextBox.Location = New System.Drawing.Point(551, 112)
        Me.DiscountDisplayTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DiscountDisplayTextBox.Name = "DiscountDisplayTextBox"
        Me.DiscountDisplayTextBox.Size = New System.Drawing.Size(101, 23)
        Me.DiscountDisplayTextBox.TabIndex = 30
        '
        'OweTextBox
        '
        Me.OweTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.OweTextBox.Location = New System.Drawing.Point(551, 137)
        Me.OweTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OweTextBox.Name = "OweTextBox"
        Me.OweTextBox.Size = New System.Drawing.Size(101, 23)
        Me.OweTextBox.TabIndex = 31
        '
        'MP_CarRental
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(700, 379)
        Me.Controls.Add(Me.OweTextBox)
        Me.Controls.Add(Me.DiscountDisplayTextBox)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.MileageChargeTextBox)
        Me.Controls.Add(Me.DisplayDistanceTextBox)
        Me.Controls.Add(Me.OweLabel)
        Me.Controls.Add(Me.DicountAmountLabel)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MileageChargeLabel)
        Me.Controls.Add(Me.DistanceLabeel)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Controls.Add(Me.MilesOrKiloGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.NumOfDaysTextBox)
        Me.Controls.Add(Me.EndOdoReadTextBox)
        Me.Controls.Add(Me.BegOdoReadTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NumOfDaysLabel)
        Me.Controls.Add(Me.EndOdoReadLabel)
        Me.Controls.Add(Me.BegOdoReadLabel)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MP_CarRental"
        Me.Text = "Form1"
        Me.MilesOrKiloGroupBox.ResumeLayout(False)
        Me.MilesOrKiloGroupBox.PerformLayout()
        Me.DiscountsGroupBox.ResumeLayout(False)
        Me.DiscountsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculateButton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents BegOdoReadLabel As Label
    Friend WithEvents EndOdoReadLabel As Label
    Friend WithEvents NumOfDaysLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents BegOdoReadTextBox As TextBox
    Friend WithEvents EndOdoReadTextBox As TextBox
    Friend WithEvents NumOfDaysTextBox As TextBox
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MilesOrKiloGroupBox As GroupBox
    Friend WithEvents MilesRadiobutton As RadioButton
    Friend WithEvents KilometersRadioButton As RadioButton
    Friend WithEvents DiscountsGroupBox As GroupBox
    Friend WithEvents SeniorCheckBox As CheckBox
    Friend WithEvents AAACheckBox As CheckBox
    Friend WithEvents DistanceLabeel As Label
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents DicountAmountLabel As Label
    Friend WithEvents OweLabel As Label
    Friend WithEvents DisplayDistanceTextBox As TextBox
    Friend WithEvents MileageChargeTextBox As TextBox
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents DiscountDisplayTextBox As TextBox
    Friend WithEvents OweTextBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
