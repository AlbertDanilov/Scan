Public Class DataMatrix

    Property SN As String = "" 'Серийный номер *\ до 20 символов
    Property GTIN As String = "" 'Международный код маркировки *\ 14 символов
    Property SGTIN As String = "" 'SGTIN = GTIN + SN
    Property SGTIN_v As Boolean = False
    Property SERIAL As String = "" 'Серия
    Property S_DATE As String = "" 'Срок годности *\ до 6 символов
    Property TN_VED As String = "" 'Код ТН ВЭД
    Property SSCC As String 'Код SSCC, третичной (заводской, транспортной) упаковки *\ 18 символов
    Property optTorg As String 'Уникальный идентификатор третичной (заводской, транспортной) упаковки
    Property crypto_key As String
    Property crypto_shifr As String

End Class

Public Class MyDataMatrix
    Inherits DataMatrix
    Public Function GetAILenght(ByVal aiCode As String) As Integer
        Select Case aiCode
            Case "00"
                Return 18
            Case "01"
                Return 14
            Case "10"
                Return 20
            Case "17"
                Return 6
            Case "21"
                Return 13
            Case "91"
                Return 4
            Case "92"
                Return 90
            Case "240"
                Return 4
            Case "999"
                Return 18
            Case Else
                Return 0
        End Select
    End Function
    Public Sub SetDM(ByVal aiCode As String, ByRef val As String)
        Select Case aiCode
            Case "00"
                Me.SSCC = val
            Case "01"
                Me.GTIN = val
            Case "10"
                Me.SERIAL = val
            Case "17"
                Me.S_DATE = val
            Case "21"
                Me.SN = val
            Case "91"
                Me.crypto_key = val
            Case "92"
                Me.crypto_shifr = val
            Case "240"
                Me.TN_VED = val
            Case "999"
                Me.optTorg = val
        End Select
    End Sub
    Public Sub SGTIN_check()
        If (String.Compare(Me.GTIN, "") = 1) And (String.Compare(Me.SN, "") = 1) Then
            SGTIN_v = True
            SGTIN = Me.GTIN & Me.SN
        End If
    End Sub

End Class
