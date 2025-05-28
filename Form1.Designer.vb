<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TxtRectX = New TextBox()
        TxtRectY = New TextBox()
        Label2 = New Label()
        BtnSave = New Button()
        Label3 = New Label()
        TxtAX = New TextBox()
        Label4 = New Label()
        TxtAY = New TextBox()
        Label5 = New Label()
        TxtBY = New TextBox()
        TxtBX = New TextBox()
        Label6 = New Label()
        TxtCY = New TextBox()
        TxtCX = New TextBox()
        Label7 = New Label()
        TxtDY = New TextBox()
        TxtDX = New TextBox()
        Label8 = New Label()
        TxtEY = New TextBox()
        TxtEX = New TextBox()
        Label9 = New Label()
        TxtFY = New TextBox()
        TxtFX = New TextBox()
        Label10 = New Label()
        TxtGY = New TextBox()
        TxtGX = New TextBox()
        Label11 = New Label()
        TxtHY = New TextBox()
        TxtHX = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label14 = New Label()
        TxtInput = New TextBox()
        TxtOutput = New TextBox()
        Label15 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(324, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rectangle width"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Sketch
        PictureBox1.Location = New Point(108, 84)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(522, 437)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TxtRectX
        ' 
        TxtRectX.Location = New Point(324, 50)
        TxtRectX.Name = "TxtRectX"
        TxtRectX.Size = New Size(92, 23)
        TxtRectX.TabIndex = 2
        ' 
        ' TxtRectY
        ' 
        TxtRectY.Location = New Point(10, 312)
        TxtRectY.Name = "TxtRectY"
        TxtRectY.Size = New Size(92, 23)
        TxtRectY.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 288)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 3
        Label2.Text = "Rectangle heigth"
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(722, 355)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(237, 47)
        BtnSave.TabIndex = 5
        BtnSave.Text = "Save Coordinates"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(701, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(15, 15)
        Label3.TabIndex = 6
        Label3.Text = "A"
        ' 
        ' TxtAX
        ' 
        TxtAX.Location = New Point(722, 109)
        TxtAX.Name = "TxtAX"
        TxtAX.Size = New Size(118, 23)
        TxtAX.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(775, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(14, 15)
        Label4.TabIndex = 8
        Label4.Text = "X"
        ' 
        ' TxtAY
        ' 
        TxtAY.Location = New Point(846, 109)
        TxtAY.Name = "TxtAY"
        TxtAY.Size = New Size(113, 23)
        TxtAY.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(895, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(14, 15)
        Label5.TabIndex = 10
        Label5.Text = "Y"
        ' 
        ' TxtBY
        ' 
        TxtBY.Location = New Point(846, 138)
        TxtBY.Name = "TxtBY"
        TxtBY.Size = New Size(113, 23)
        TxtBY.TabIndex = 13
        ' 
        ' TxtBX
        ' 
        TxtBX.Location = New Point(722, 138)
        TxtBX.Name = "TxtBX"
        TxtBX.Size = New Size(118, 23)
        TxtBX.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(701, 141)
        Label6.Name = "Label6"
        Label6.Size = New Size(14, 15)
        Label6.TabIndex = 11
        Label6.Text = "B"
        ' 
        ' TxtCY
        ' 
        TxtCY.Location = New Point(846, 167)
        TxtCY.Name = "TxtCY"
        TxtCY.Size = New Size(113, 23)
        TxtCY.TabIndex = 16
        ' 
        ' TxtCX
        ' 
        TxtCX.Location = New Point(722, 167)
        TxtCX.Name = "TxtCX"
        TxtCX.Size = New Size(118, 23)
        TxtCX.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(701, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(15, 15)
        Label7.TabIndex = 14
        Label7.Text = "C"
        ' 
        ' TxtDY
        ' 
        TxtDY.Location = New Point(846, 196)
        TxtDY.Name = "TxtDY"
        TxtDY.Size = New Size(113, 23)
        TxtDY.TabIndex = 19
        ' 
        ' TxtDX
        ' 
        TxtDX.Location = New Point(722, 196)
        TxtDX.Name = "TxtDX"
        TxtDX.Size = New Size(118, 23)
        TxtDX.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(701, 199)
        Label8.Name = "Label8"
        Label8.Size = New Size(15, 15)
        Label8.TabIndex = 17
        Label8.Text = "D"
        ' 
        ' TxtEY
        ' 
        TxtEY.Location = New Point(846, 225)
        TxtEY.Name = "TxtEY"
        TxtEY.Size = New Size(113, 23)
        TxtEY.TabIndex = 22
        ' 
        ' TxtEX
        ' 
        TxtEX.Location = New Point(722, 225)
        TxtEX.Name = "TxtEX"
        TxtEX.Size = New Size(118, 23)
        TxtEX.TabIndex = 21
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(701, 228)
        Label9.Name = "Label9"
        Label9.Size = New Size(13, 15)
        Label9.TabIndex = 20
        Label9.Text = "E"
        ' 
        ' TxtFY
        ' 
        TxtFY.Location = New Point(846, 254)
        TxtFY.Name = "TxtFY"
        TxtFY.Size = New Size(113, 23)
        TxtFY.TabIndex = 25
        ' 
        ' TxtFX
        ' 
        TxtFX.Location = New Point(722, 254)
        TxtFX.Name = "TxtFX"
        TxtFX.Size = New Size(118, 23)
        TxtFX.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(701, 257)
        Label10.Name = "Label10"
        Label10.Size = New Size(13, 15)
        Label10.TabIndex = 23
        Label10.Text = "F"
        ' 
        ' TxtGY
        ' 
        TxtGY.Location = New Point(846, 283)
        TxtGY.Name = "TxtGY"
        TxtGY.Size = New Size(113, 23)
        TxtGY.TabIndex = 28
        ' 
        ' TxtGX
        ' 
        TxtGX.Location = New Point(722, 283)
        TxtGX.Name = "TxtGX"
        TxtGX.Size = New Size(118, 23)
        TxtGX.TabIndex = 27
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(701, 286)
        Label11.Name = "Label11"
        Label11.Size = New Size(15, 15)
        Label11.TabIndex = 26
        Label11.Text = "G"
        ' 
        ' TxtHY
        ' 
        TxtHY.Location = New Point(846, 312)
        TxtHY.Name = "TxtHY"
        TxtHY.Size = New Size(113, 23)
        TxtHY.TabIndex = 31
        ' 
        ' TxtHX
        ' 
        TxtHX.Location = New Point(722, 312)
        TxtHX.Name = "TxtHX"
        TxtHX.Size = New Size(118, 23)
        TxtHX.TabIndex = 30
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(701, 315)
        Label12.Name = "Label12"
        Label12.Size = New Size(16, 15)
        Label12.TabIndex = 29
        Label12.Text = "H"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(775, 58)
        Label13.Name = "Label13"
        Label13.Size = New Size(124, 15)
        Label13.TabIndex = 32
        Label13.Text = "Measured coordinates"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(46, 577)
        Label14.Name = "Label14"
        Label14.Size = New Size(59, 15)
        Label14.TabIndex = 33
        Label14.Text = "Input File:"
        ' 
        ' TxtInput
        ' 
        TxtInput.Location = New Point(108, 574)
        TxtInput.Name = "TxtInput"
        TxtInput.Size = New Size(661, 23)
        TxtInput.TabIndex = 34
        ' 
        ' TxtOutput
        ' 
        TxtOutput.Location = New Point(108, 613)
        TxtOutput.Name = "TxtOutput"
        TxtOutput.Size = New Size(661, 23)
        TxtOutput.TabIndex = 36
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(36, 616)
        Label15.Name = "Label15"
        Label15.Size = New Size(69, 15)
        Label15.TabIndex = 35
        Label15.Text = "Output File:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(775, 570)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 29)
        Button1.TabIndex = 37
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(775, 609)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 29)
        Button2.TabIndex = 38
        Button2.Text = "Select"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(254, 678)
        Button3.Name = "Button3"
        Button3.Size = New Size(295, 47)
        Button3.TabIndex = 39
        Button3.Text = "Process NC File"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1005, 765)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TxtOutput)
        Controls.Add(Label15)
        Controls.Add(TxtInput)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(TxtHY)
        Controls.Add(TxtHX)
        Controls.Add(Label12)
        Controls.Add(TxtGY)
        Controls.Add(TxtGX)
        Controls.Add(Label11)
        Controls.Add(TxtFY)
        Controls.Add(TxtFX)
        Controls.Add(Label10)
        Controls.Add(TxtEY)
        Controls.Add(TxtEX)
        Controls.Add(Label9)
        Controls.Add(TxtDY)
        Controls.Add(TxtDX)
        Controls.Add(Label8)
        Controls.Add(TxtCY)
        Controls.Add(TxtCX)
        Controls.Add(Label7)
        Controls.Add(TxtBY)
        Controls.Add(TxtBX)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TxtAY)
        Controls.Add(Label4)
        Controls.Add(TxtAX)
        Controls.Add(Label3)
        Controls.Add(BtnSave)
        Controls.Add(TxtRectY)
        Controls.Add(Label2)
        Controls.Add(TxtRectX)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Maslow Post Processor"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtRectX As TextBox
    Friend WithEvents TxtRectY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAX As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAY As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBY As TextBox
    Friend WithEvents TxtBX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCY As TextBox
    Friend WithEvents TxtCX As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDY As TextBox
    Friend WithEvents TxtDX As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEY As TextBox
    Friend WithEvents TxtEX As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtFY As TextBox
    Friend WithEvents TxtFX As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtGY As TextBox
    Friend WithEvents TxtGX As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtHY As TextBox
    Friend WithEvents TxtHX As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents TxtOutput As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
