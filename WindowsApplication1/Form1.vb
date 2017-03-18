Public Class Form1
    Dim firstnum As Decimal
    Dim Secondnum As Decimal
    Dim operation As Integer
    Dim operator_selector As Boolean = False
    Dim SquareNumber As Double
    Dim ModdedNumber As Double
    Dim SquareValue As Double
    Dim Initial_Value As Double
    Dim SquareResult As Double
    Dim ValueTotal As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        TextBox1.Text = "0"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        firstnum = TextBox1.Text
        TextBox1.Text = "0"
        operator_selector = True
        operation = 1 ' = +
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        firstnum = TextBox1.Text
        TextBox1.Text = "0"
        operator_selector = True
        operation = 2 ' = -
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        firstnum = TextBox1.Text
        TextBox1.Text = "0"
        operator_selector = True
        operation = 3 ' = *
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        firstnum = TextBox1.Text
        TextBox1.Text = "0"
        operator_selector = True
        operation = 4 ' = /
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If operator_selector = True Then
            Secondnum = TextBox1.Text
            If operation = 1 Then
                TextBox1.Text = firstnum + Secondnum
            ElseIf operation = 2 Then
                TextBox1.Text = firstnum - Secondnum
            ElseIf operation = 3 Then
                TextBox1.Text = firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    TextBox1.Text = "Error!"
                Else
                    TextBox1.Text = firstnum / Secondnum
                End If
            End If
            operator_selector = False
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click


    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        ModdedNumber = TextBox1.Text * TextBox1.Text
        TextBox1.Text = ModdedNumber

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "1"
        Else
            TextBox2.Text = "1"
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "2"
        Else
            TextBox2.Text = "2"
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "3"
        Else
            TextBox2.Text = "3"
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "4"
        Else
            TextBox2.Text = "4"
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "5"
        Else
            TextBox2.Text = "5"
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "6"
        Else
            TextBox2.Text = "6"
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "7"
        Else
            TextBox2.Text = "7"
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "8"
        Else
            TextBox2.Text = "8"
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "9"
        Else
            TextBox2.Text = "9"
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If TextBox2.Text <> "0" Then
            TextBox2.Text += "0"
        Else
            TextBox2.Text = "0"
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TextBox2.Text = ""
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
