Imports System.Globalization
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.Unicode

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtRectX.Text = My.Settings.RectX
        TxtRectY.Text = My.Settings.RectY

        TxtAX.Text = My.Settings.AX
        TxtAY.Text = My.Settings.AY
        TxtBX.Text = My.Settings.BX
        TxtBY.Text = My.Settings.BY
        TxtCX.Text = My.Settings.CX
        TxtCY.Text = My.Settings.CY
        TxtDX.Text = My.Settings.DX
        TxtDY.Text = My.Settings.DY
        TxtEX.Text = My.Settings.EX
        TxtEY.Text = My.Settings.EY
        TxtFX.Text = My.Settings.FX
        TxtFY.Text = My.Settings.FY
        TxtGX.Text = My.Settings.GX
        TxtGY.Text = My.Settings.GY
        TxtHX.Text = My.Settings.HX
        TxtHY.Text = My.Settings.HY
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        My.Settings.RectX = TxtRectX.Text
        My.Settings.RectY = TxtRectY.Text

        My.Settings.AX = TxtAX.Text
        My.Settings.AY = TxtAY.Text
        My.Settings.BX = TxtBX.Text
        My.Settings.BY = TxtBY.Text
        My.Settings.CX = TxtCX.Text
        My.Settings.CY = TxtCY.Text
        My.Settings.DX = TxtDX.Text
        My.Settings.DY = TxtDY.Text
        My.Settings.EX = TxtEX.Text
        My.Settings.EY = TxtEY.Text
        My.Settings.FX = TxtFX.Text
        My.Settings.FY = TxtFY.Text
        My.Settings.GX = TxtGX.Text
        My.Settings.GY = TxtGY.Text
        My.Settings.HX = TxtHX.Text
        My.Settings.HY = TxtHY.Text

        MsgBox("Parameters saved successfully", 0, "Success")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.FileName = "select a nc file"
        OpenFileDialog1.Filter = "NC files (*.nc)|*.nc"
        OpenFileDialog1.ShowDialog()
        TxtInput.Text = OpenFileDialog1.FileName

        TxtOutput.Text = OpenFileDialog1.FileName.Remove(OpenFileDialog1.FileName.Length - 3) + "_pp.nc"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.FileName = TxtOutput.Text.Substring(TxtOutput.Text.LastIndexOf("\") + 1)
        SaveFileDialog1.Filter = "NC files (*.nc)|*.nc"
        SaveFileDialog1.ShowDialog()
        TxtOutput.Text = SaveFileDialog1.FileName
    End Sub

    Dim OffsetAX, OffsetAY, OffsetBX, OffsetBY, OffsetCX, OffsetCY, OffsetDX, OffsetDY, OffsetEX, OffsetEY, OffsetFX, OffsetFY, OffsetGX, OffsetGY, OffsetHX, OffsetHY As Double
    Dim W2, H2 As Double

    Dim OldX As Double
    Dim OldY As Double

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        W2 = Val(TxtRectX.Text) / 2
        H2 = Val(TxtRectY.Text) / 2

        OffsetAX = Val(TxtAX.Text) - W2
        OffsetAY = Val(TxtAY.Text)
        OffsetBX = Val(TxtBX.Text) - W2
        OffsetBY = Val(TxtBY.Text) - H2
        OffsetCX = Val(TxtCX.Text)
        OffsetCY = Val(TxtCY.Text) - H2
        OffsetDX = Val(TxtDX.Text) + W2
        OffsetDY = Val(TxtDY.Text) - H2
        OffsetEX = Val(TxtEX.Text) + W2
        OffsetEY = Val(TxtEY.Text)
        OffsetFX = Val(TxtFX.Text) + W2
        OffsetFY = Val(TxtFY.Text) + H2
        OffsetGX = Val(TxtGX.Text)
        OffsetGY = Val(TxtGY.Text) + H2
        OffsetHX = Val(TxtHX.Text) - W2
        OffsetHY = Val(TxtHY.Text) + H2


        Dim inputfile As StreamReader
        Dim outputfile As StreamWriter
        Dim content, line As String
        Dim retval As Boolean

        'remove comment and write to output
        inputfile = My.Computer.FileSystem.OpenTextFileReader(TxtInput.Text)
        outputfile = My.Computer.FileSystem.OpenTextFileWriter(TxtOutput.Text, False)
        content = inputfile.ReadToEnd
        retval = RemoveComment(content)
        If retval = True Then
            outputfile.Write(content)
        End If
        inputfile.Close()
        outputfile.Close()
        If retval = False Then
            MsgBox("Problem with input file. Comment not correct")
            Exit Sub
        End If

        'Adjust X en Y
        content = ""
        OldX = 0
        OldY = 0
        inputfile = My.Computer.FileSystem.OpenTextFileReader(TxtOutput.Text)
        While inputfile.EndOfStream = False
            line = inputfile.ReadLine()
            retval = AdjustXY(line)
            If retval = False Then
                Exit While
            End If
            content = content + line + vbCrLf
        End While
        inputfile.Close()
        If retval = False Then
            MsgBox("Problem with input file. Multiple X or Y on same line")
            Exit Sub
        End If

        'Write content to output
        outputfile = My.Computer.FileSystem.OpenTextFileWriter(TxtOutput.Text, False, New UTF8Encoding(encoderShouldEmitUTF8Identifier:=False))
        outputfile.Write(content)
        outputfile.Close()
        MsgBox("processing succeeded!")



        'While inputfile.EndOfStream = False
        'inputfile.BaseStream.Position = 0   'read text again
        'outputfile.WriteLine(line)
        'End While
    End Sub

    Private Function RemoveComment(ByRef s As String) As Boolean
        Dim i, j As Integer
        While s.Contains("("c)
            i = s.IndexOf("("c)
            j = s.IndexOf(")"c)
            If j = -1 Or j < i Then
                Return False
            End If
            s = s.Remove(i, j - i + 1)
        End While

        Return True
    End Function

    Private Function AdjustXY(ByRef line As String) As Boolean

        Dim NewX, NewY As Double

        line = line.Replace("x"c, "X"c)
        line = line.Replace("y"c, "Y"c)
        If line.Length - line.Replace("X"c, "").Length > 1 Or line.Length - line.Replace("Y"c, "").Length > 1 Then
            Return False    'Multiple X or Y on same line
        End If

        If line.Contains("X"c) = False And line.Contains("Y"c) = False Then
            Return True
        End If

        If line.Contains("X"c) Then
            GetVal(line, OldX, "X"c)
        End If
        If line.Contains("Y"c) Then
            GetVal(line, OldY, "Y"c)
        End If

        NewX = OldX
        NewY = OldY
        Calc(NewX, NewY)

        If line.Contains("X"c) Then
            If line.Contains("Y"c) Then
                line = line.Remove(line.IndexOf("Y"c), 1)
            End If
            SetVal(line, NewX, NewY, "X"c)
        Else
            SetVal(line, NewX, NewY, "Y"c)
        End If

        Return True
    End Function

    Private Sub GetVal(ByRef line As String, ByRef value As Double, ByVal k As Char)
        Dim temp As String
        Dim i, l As Integer

        i = line.IndexOf(k) + 1
        temp = line.Substring(i)
        If temp.Contains(" "c) = False Then
            l = temp.Length
        Else
            l = temp.IndexOf(" "c)
        End If
        temp = temp.Remove(l)
        value = Val(temp)
        line = line.Remove(i, l)
    End Sub

    Private Sub SetVal(ByRef line As String, ByVal valueX As Double, ByVal valueY As Double, ByVal k As Char)
        Dim i As Integer

        i = line.IndexOf(k)
        line = line.Remove(i, 1)

        line = line.Insert(i, "X" + valueX.ToString("F4", CultureInfo.InvariantCulture) + " Y" + valueY.ToString("F4", CultureInfo.InvariantCulture))
    End Sub

    Private Sub Calc(ByRef X As Double, ByRef Y As Double)
        Dim newY, newX As Double
        If X >= 0 Then
            If Y >= 0 Then      'kwadrant I
                newX = X - (OffsetAX * X / W2 + OffsetCX * Y / H2 + (OffsetBX - OffsetCX - OffsetAX) * X * Y / (W2 * H2))
                newY = Y - (OffsetAY * X / W2 + OffsetCY * Y / H2 + (OffsetBY - OffsetCY - OffsetAY) * X * Y / (W2 * H2))
            Else                'kwadrant IV
                newX = X - (OffsetAX * X / W2 + OffsetGX * -Y / H2 + (OffsetHX - OffsetGX - OffsetAX) * X * -Y / (W2 * H2))
                newY = Y - (OffsetAY * X / W2 + OffsetGY * -Y / H2 + (OffsetHY - OffsetGY - OffsetAY) * X * -Y / (W2 * H2))
            End If
        Else
            If Y >= 0 Then      'kwadrant II
                newX = X - (OffsetEX * -X / W2 + OffsetCX * Y / H2 + (OffsetDX - OffsetCX - OffsetEX) * -X * Y / (W2 * H2))
                newY = Y - (OffsetEY * -X / W2 + OffsetCY * Y / H2 + (OffsetDY - OffsetCY - OffsetEY) * -X * Y / (W2 * H2))
            Else                'kwadrant III
                newX = X - (OffsetEX * -X / W2 + OffsetGX * -Y / H2 + (OffsetFX - OffsetGX - OffsetEX) * -X * -Y / (W2 * H2))
                newY = Y - (OffsetEY * -X / W2 + OffsetGY * -Y / H2 + (OffsetFY - OffsetGY - OffsetEY) * -X * -Y / (W2 * H2))
            End If
        End If
        X = newX
        Y = newY
    End Sub

End Class
