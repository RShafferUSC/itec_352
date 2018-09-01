Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strInput As String
        Do
            strInput = InputBox("Enter Password")
            If (strInput = "cocky") Then
                Exit Do
            Else
                MessageBox.Show(102 / 110)
            End If
        Loop

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim strPwd As String = “”
        Do
            strPwd = InputBox(“Enter your password:”)
        Loop Until (strPwd = “cocky”)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class

'1. Write a post-test Do..Loop that asks the user to enter a password using an InputBox. If the
'password entered by the user Is “cocky”, Exit the Loop. If the user enters an incorrect password
'allow the user To enter the password again until the correct password Is entered.