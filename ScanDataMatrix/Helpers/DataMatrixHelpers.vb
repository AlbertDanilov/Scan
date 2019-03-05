Public Class DataMatrixHelpers
    'Public Shared Sub SplitStrString(ByRef DM As MyDataMatrix, ByVal STR_DM As String, GS As Char)
    '    If (STR_DM.Length > 2) Then
    '        Dim k240 As Boolean = False
    '        If Asc(STR_DM(0)) = Asc(GS) Then
    '            SplitStrString(DM, STR_DM.Substring(1, STR_DM.Length - 1), GS)
    '        Else
    '            Dim aiLength As Integer = DM.GetAILenght(STR_DM(0) & STR_DM(1))
    '            If aiLength = 0 Then
    '                aiLength = DM.GetAILenght(STR_DM(0) & STR_DM(1) & STR_DM(2))
    '                k240 = True
    '            End If
    '            If STR_DM.Length < aiLength Then aiLength = STR_DM.Length - 2
    '            If STR_DM.Length = aiLength Then aiLength = STR_DM.Length - 2
    '            Dim ver As String = Nothing
    '            Dim i As Integer
    '            If Not k240 Then
    '                For i = 2 To aiLength + 1
    '                    If Asc(STR_DM(i)) = Asc(GS) Then aiLength = i - 1 : Exit For
    '                    ver &= STR_DM(i)
    '                Next
    '            Else
    '                For i = 3 To aiLength + 2
    '                    If Asc(STR_DM(i)) = Asc(GS) Then aiLength = i - 1 : Exit For
    '                    ver &= STR_DM(i)
    '                Next
    '            End If
    '            If Not k240 Then
    '                DM.SetDM(STR_DM(0) & STR_DM(1), ver)
    '            Else
    '                DM.SetDM(STR_DM(0) & STR_DM(1) & STR_DM(2), ver)
    '            End If
    '            If (Not DM.SGTIN_v) Then DM.SGTIN_check()
    '            If Not k240 Then
    '                SplitStrString(DM, STR_DM.Substring((aiLength + 2), STR_DM.Length - (aiLength + 2)), GS)
    '            Else
    '                SplitStrString(DM, STR_DM.Substring((aiLength + 3), STR_DM.Length - (aiLength + 3)), GS)
    '            End If
    '        End If
    '    End If
    'End Sub

    Public Shared Sub SplitStrList(ByRef DM As MyDataMatrix, STR_DM As List(Of Integer), GS As Integer)
        If (STR_DM.Count > 2) Then
            Dim k240 As Boolean = False
            If STR_DM(0) = GS Then
                STR_DM.RemoveAt(0)
                SplitStrList(DM, STR_DM, GS)
            Else
                Dim aiLength As Integer = DM.GetAILenght(ChrW(STR_DM(0)) & ChrW(STR_DM(1)))
                If aiLength = 0 Then
                    aiLength = DM.GetAILenght(ChrW(STR_DM(0)) & ChrW(STR_DM(1)) & ChrW(STR_DM(2)))
                    k240 = True
                End If
                If STR_DM.Count < aiLength Then aiLength = STR_DM.Count - 2
                If STR_DM.Count = aiLength Then aiLength = STR_DM.Count - 2
                Dim ver As String = Nothing
                Dim i As Integer = 0
                If Not k240 Then
                    For i = 2 To aiLength + 1
                        If STR_DM(i) = GS Then aiLength = i - 1 : Exit For
                        ver &= ChrW(STR_DM(i))
                        Next
                        Else
                    For i = 3 To aiLength + 2
                        If STR_DM(i) = GS Then aiLength = i - 1 : Exit For
                        ver &= ChrW(STR_DM(i))
                        Next
                End If
                If Not k240 Then
                    DM.SetDM(ChrW(STR_DM(0)) & ChrW(STR_DM(1)), ver)
                Else
                    DM.SetDM(ChrW(STR_DM(0)) & ChrW(STR_DM(1)) & ChrW(STR_DM(2)), ver)
                End If
                If (Not DM.SGTIN_v) Then DM.SGTIN_check()
                If Not k240 Then
                    Dim k = aiLength + 2
                    While k > 0
                        STR_DM.RemoveAt(0)
                        k -= 1
                    End While
                    SplitStrList(DM, STR_DM, GS)
                Else
                    Dim k = aiLength + 3
                    While k > 0
                        STR_DM.RemoveAt(0)
                        k -= 1
                    End While
                    SplitStrList(DM, STR_DM, GS)
                End If
            End If
        End If
    End Sub
End Class
