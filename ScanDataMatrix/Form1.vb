Imports System.Runtime.InteropServices

Public Class Form1

    Property shtrih_kod_temp As String = ""
    Property shtrih_kod As String = ""
    Property nums As List(Of Integer)

    'Property buffer_text As String = ""

    Private Sub Work()
        Dim DM As New MyDataMatrix

        DataMatrixHelpers.SplitStrList(DM, nums, 29)
        'DataMatrixHelpers.SplitStrString(DM, buffer_text, " ")

        GTIN_TextBox.Text = DM.GTIN
        SN_TextBox.Text = DM.SN
        SGTIN_TextBox.Text = DM.SGTIN
        TextBox1.Text = DM.SERIAL
        TextBox2.Text = DM.S_DATE
        TextBox3.Text = DM.TN_VED
        TextBox5.Text = DM.crypto_key
        TextBox4.Text = DM.crypto_shifr

        Scanned_TextBox.Text = ""
        Scanned_TextBox_Select()

        TimerScan.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New System.Globalization.CultureInfo("en-US"))
        Scanned_TextBox_Select()

        nums = New List(Of Integer)


        '' ШИФРОВАНИЕ ЛОГИНА И ПАРОЛЯ В КАССЕ
        'Dim login = "login"
        'Dim login_int() As Integer
        'Dim login_shifr = ""

        'login_int = set_str(login)
        'login_shifr = set_str_s(login_int)

        'MessageBox.Show(login_shifr)


    End Sub


    '' ШИФРОВАНИЕ ЛОГИНА И ПАРОЛЯ В КАССЕ
    'Private Function set_str(ByVal str_s As String) As Integer()
    '    Dim int_s() As Integer = {Asc(" ") * 2}
    '    If str_s.Length > 0 Then
    '        Dim i As Integer
    '        Dim sm As Integer = Asc(str_s.Substring(0, 1))
    '        ReDim int_s(str_s.Length - 1)
    '        For i = 0 To str_s.Length - 1
    '            int_s(i) = Asc(str_s.Substring(i, 1)) + sm + i
    '        Next
    '    End If : Return int_s
    'End Function

    'Private Function set_str_s(masi As Integer()) As String
    '    Dim ss As String = ""
    '    If masi.Length > 0 Then
    '        For i As Integer = 0 To masi.Length - 1
    '            ss &= masi(i) & "-"
    '        Next
    '        ss = ss.Substring(0, ss.Length - 1)
    '    End If
    '    Return ss
    'End Function




    Private Sub Scanned_TextBox_Select() Handles SN_TextBox.Click, MyBase.Click, GTIN_TextBox.Click
        Scanned_TextBox.Select()
    End Sub

    Private Sub TimerScan_Tick(sender As Object, e As EventArgs) Handles TimerScan.Tick
        shtrih_kod_temp = Scanned_TextBox.Text
        If String.Compare(shtrih_kod, shtrih_kod_temp) = 0 Then
            TimerScan.Enabled = False

            Work()
        Else
            shtrih_kod = shtrih_kod_temp
        End If
    End Sub

    Private Sub Scanned_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Scanned_TextBox.KeyPress

        shtrih_kod_temp = Scanned_TextBox.Text
        TimerScan.Enabled = True

        nums.Add(Asc(e.KeyChar))

        'If (Asc(e.KeyChar) = 29) Then
        '    buffer_text += " "
        'Else
        '    buffer_text += e.KeyChar
        'End If

    End Sub
End Class
