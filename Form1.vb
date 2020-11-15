Option Explicit On
Option Strict Off

Public Class frmCalc


    Dim sign As String
    Dim val1 As Double
    Dim val2 As Double


    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        txtBox.Text = txtBox.Text & cmd0.Text 'get 0
    End Sub

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        txtBox.Text = txtBox.Text & cmd1.Text 'get 1
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        txtBox.Text = txtBox.Text & cmd2.Text 'get 2
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txtBox.Text = txtBox.Text & cmd3.Text 'get 3
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        txtBox.Text = txtBox.Text & cmd4.Text 'get 4
    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        txtBox.Text = txtBox.Text & cmd5.Text 'get 5
    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        txtBox.Text = txtBox.Text & cmd6.Text
    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        txtBox.Text = txtBox.Text & cmd7.Text
    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        txtBox.Text = txtBox.Text & cmd8.Text
    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        txtBox.Text = txtBox.Text & cmd9.Text
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtBox.Text = ""
        val1 = 0
        val2 = 0
        sign = ""
    End Sub

    Private Sub cmdCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcos.Click
        Dim v As Double
        On Error GoTo aa
        v = CDbl(txtBox.Text)
        txtBox.Text = Math.Cos(v)
aa:     Exit Sub
    End Sub

    Private Sub cmdDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddivide.Click
        sign = "/"
        On Error GoTo aa
        val1 = CDbl(txtBox.Text)
        txtBox.Text = ""
aa:     Exit Sub
    End Sub

    Private Sub cmdEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdequal.Click
        On Error GoTo aa
        val2 = CDbl(txtBox.Text)
        If (sign = "+") Then
            txtBox.Text = val1 + val2
        ElseIf (sign = "-") Then
            txtBox.Text = val1 - val2
        ElseIf (sign = "*") Then
            txtBox.Text = val1 * val2
        Else : txtBox.Text = val1 / val2
        End If
aa:     Exit Sub
    End Sub

    Private Sub cmdMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmultiply.Click
        sign = "*"
        On Error GoTo aa
        val1 = CDbl(txtBox.Text)
        txtBox.Text = ""
aa:     Exit Sub
    End Sub

    Private Sub cmdPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        sign = "+"
        On Error GoTo aa
        val1 = CDbl(txtBox.Text)
        txtBox.Text = ""
aa:     Exit Sub
    End Sub

    Private Sub cmdSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubtract.Click
        sign = "-"
        On Error GoTo aa
        val1 = CDbl(txtBox.Text)
        txtBox.Text = ""
aa:     Exit Sub
    End Sub

    Private Sub cmdSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsqrt.Click
        Dim v As Double
        On Error GoTo aa
        v = CDbl(txtBox.Text)
        txtBox.Text = Math.Sqrt(v)
aa:     Exit Sub
    End Sub

    Private Sub cmdSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsin.Click
        Dim v As Double
        On Error GoTo aa
        v = CDbl(txtBox.Text)
        txtBox.Text = Math.Sin(v)
aa:     Exit Sub
    End Sub

    Private Sub cmdTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtan.Click
        Dim v As Double
        On Error GoTo aa
        v = CDbl(txtBox.Text)
        txtBox.Text = Math.Tan(v)
aa:     Exit Sub
    End Sub

    Private Sub cmdSquare_Click(sender As Object, e As EventArgs) Handles cmdsquare.Click
        Dim v As Double
        On Error GoTo aa
        v = CDbl(txtBox.Text)
        txtBox.Text = v ^ 2
aa:     Exit Sub
    End Sub

    Private Sub txtBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBox.KeyPress
        If Asc(e.KeyChar) >= Asc("0") And Asc(e.KeyChar) <= Asc("9") Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub
End Class