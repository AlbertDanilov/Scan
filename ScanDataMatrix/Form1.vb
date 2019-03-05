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
    End Sub

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
