Imports System.Threading

Public Class Form1

    Property shtrih_kod_temp As String = ""
    Property shtrih_kod As String = ""
    Property nums As List(Of Integer)
    Property workthread As Thread

    'Property buffer_text As String = ""

    Private Sub Work()
        Dim DM As New MyDataMatrix

        For Each num In nums
            nums_tb.Invoke(Sub()
                               nums_tb.Text &= num.ToString & " "
                           End Sub)
            sg_tb.Invoke(Sub()
                             sg_tb.Text &= ChrW(num)
                         End Sub)
        Next

        DataMatrixHelpers.SplitStrList(DM, nums, 29)
        'DataMatrixHelpers.SplitStrString(DM, buffer_text, " ")

        If DM.SGTIN_v Then
            GTIN_TextBox.Invoke(Sub()
                                    GTIN_TextBox.Text = DM.GTIN
                                End Sub)
            SN_TextBox.Invoke(Sub()
                                  SN_TextBox.Text = DM.SN
                              End Sub)
            SGTIN_TextBox.Invoke(Sub()
                                     SGTIN_TextBox.Text = DM.SGTIN
                                 End Sub)


            TextBox1.Invoke(Sub()
                                TextBox1.Text = DM.SERIAL
                            End Sub)
            TextBox2.Invoke(Sub()
                                TextBox2.Text = DM.S_DATE
                            End Sub)
            TextBox3.Invoke(Sub()
                                TextBox3.Text = DM.TN_VED
                            End Sub)
            TextBox5.Invoke(Sub()
                                TextBox5.Text = DM.crypto_key
                            End Sub)
            TextBox4.Invoke(Sub()
                                TextBox4.Text = DM.crypto_shifr
                            End Sub)
        Else
            Escape()
        End If

        'Scanned_TextBox.Text = ""
        'Scanned_TextBox_Select()

        TimerScan.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(New System.Globalization.CultureInfo("en-US"))
        'Scanned_TextBox_Select()

        nums = New List(Of Integer)

        'backthread = New Thread(New ParameterizedThreadStart(AddressOf Form1_KeyPress))
        'backthread.Start()

        'backthread = New Thread(AddressOf Form1_KeyPress)
        'backthread.Start()

        '' ШИФРОВАНИЕ ЛОГИНА И ПАРОЛЯ В КАССЕ
        ''Dim login = "112233"
        ''Dim login_int() As Integer
        ''Dim login_shifr = ""
        ''login_int = set_str(login)
        ''login_shifr = set_str_s(login_int)
        ''MessageBox.Show(login_shifr)


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




    'Private Sub Scanned_TextBox_Select() Handles SN_TextBox.Click, MyBase.Click, GTIN_TextBox.Click
    '    Scanned_TextBox.Select()
    'End Sub

    Private Sub TimerScan_Tick(sender As Object, e As EventArgs) Handles TimerScan.Tick
        'shtrih_kod_temp = Scanned_TextBox.Text
        If String.Compare(shtrih_kod, shtrih_kod_temp) = 0 Then
            TimerScan.Enabled = False

            workthread = New Thread(AddressOf Work)
            workthread.Start()

        Else
            shtrih_kod = shtrih_kod_temp
        End If
    End Sub

    'Private Sub Scanned_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Scanned_TextBox.KeyPress

    '    shtrih_kod_temp = Scanned_TextBox.Text
    '    TimerScan.Enabled = True

    '    nums.Add(Asc(e.KeyChar))

    '    'If (Asc(e.KeyChar) = 29) Then
    '    '    buffer_text += " "
    '    'Else
    '    '    buffer_text += e.KeyChar
    '    'End If

    'End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 27 Then
            Escape()
        Else
            shtrih_kod_temp += e.KeyChar
            TimerScan.Enabled = True

            nums.Add(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub Esc_Button_Click(sender As Object, e As EventArgs) Handles Esc_Button.Click
        Escape()
    End Sub

    Private Sub Escape()
        GTIN_TextBox.Invoke(Sub()
                                GTIN_TextBox.Text = "-"
                            End Sub)
        SN_TextBox.Invoke(Sub()
                              SN_TextBox.Text = "-"
                          End Sub)
        SGTIN_TextBox.Invoke(Sub()
                                 SGTIN_TextBox.Text = "-"
                             End Sub)
        TextBox1.Invoke(Sub()
                            TextBox1.Text = "-"
                        End Sub)
        TextBox2.Invoke(Sub()
                            TextBox2.Text = "-"
                        End Sub)
        TextBox3.Invoke(Sub()
                            TextBox3.Text = "-"
                        End Sub)
        TextBox5.Invoke(Sub()
                            TextBox5.Text = "-"
                        End Sub)
        TextBox4.Invoke(Sub()
                            TextBox4.Text = "-"
                        End Sub)
        nums.Clear()
    End Sub

End Class
