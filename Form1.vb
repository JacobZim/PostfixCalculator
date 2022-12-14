Public Class Form1





    Private Function EvaluatePostfix(exp As String)
        Dim Size As Integer = exp.Length
        Dim i As Integer, u As Integer, w As Integer, t As Integer
        Dim stk As Stack = New Stack()
        Dim temp As String, x As String, y As String

        If (Size = 0) Then
            postfixOutputBox.Text = ""
            Return ""
        End If

        For i = 0 To Size - 1
            temp = exp(i)
            If ("123456789".Contains(temp)) Then
                stk.Push(temp)
            ElseIf ("+-/*".Contains(temp)) Then
                x = stk.Pop
                y = stk.Pop
                Integer.TryParse(x, u)
                Integer.TryParse(y, w)

                If (temp = "+") Then
                    t = w + u
                ElseIf (temp = "-") Then
                    t = w - u
                ElseIf (temp = "*") Then
                    t = w * u
                ElseIf (temp = "/") Then
                    t = w / u
                End If
                stk.Push(CStr(t))
            End If
        Next
        temp = stk.Pop
        Return temp
    End Function

    Private Sub PostfixToInfix(exp As String)
        Dim Size As Integer = exp.Length
        Dim i As Integer
        Dim stk As Stack = New Stack()
        Dim temp As String, x As String, y As String

        If (Size = 0) Then
            postfixOutputBox.Text = ""
            Return
        End If

        For i = 0 To Size - 1
            temp = exp(i)
            If ("123456789".Contains(temp)) Then
                stk.Push(temp)
            ElseIf ("+-*/".Contains(temp)) Then
                x = stk.Pop
                y = stk.Pop

                temp = "(" & y & temp & x & ")"
                stk.Push(temp)
            End If
        Next
        infixEquivalentBox.Text = stk.Pop
    End Sub

    Private Function prec(str As Char)
        If (str = "^") Then
            Return 3
        ElseIf ((str = "/") <> (str = "*")) Then
            Return 2
        ElseIf ((str = "+") <> (str = "-")) Then
            Return 1
        Else
            Return -1
        End If
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        postfixOutputBox.Text = EvaluatePostfix(postfixInputBox.Text)
        PostfixToInfix(postfixInputBox.Text)
    End Sub

    Private Function InfixToPostfix(exp As String)
        Dim Size As Integer = exp.Length
        Dim i As Integer
        Dim stk As Stack = New Stack()
        Dim temp As String, x As String, output As String = ""

        If (Size = 0) Then
            postfixOutputBox.Text = ""
            Return ""
        End If

        For i = 0 To Size - 1
            temp = exp(i)
            If ("123456789".Contains(temp)) Then
                output = output & temp
            ElseIf ("(".Contains(temp)) Then
                stk.Push(temp)
            ElseIf (")".Contains(temp)) Then
                While ((stk.Count > 0) And stk.Peek <> "(")
                    x = stk.Pop
                    output = output & x
                End While
                If ((stk.Count > 0) And stk.Peek <> "(") Then
                    Return ""
                Else
                    stk.Pop()
                End If
            Else
                While (stk.Count > 0 AndAlso prec(temp) <= prec(stk.Peek))
                    output = output & stk.Pop
                End While
                stk.Push(temp)
            End If
        Next
        While (stk.Count > 0)
            output = output & stk.Pop
        End While
        postfixEquivalentBox.Text = output
        Return output
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        infixOutputBox.Text = EvaluatePostfix(InfixToPostfix(infixInputBox.Text))
    End Sub
End Class
