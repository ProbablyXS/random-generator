Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Diagnostics
Public Class RandomNumber
    <DebuggerNonUserCode()>
    Public Sub New()
    End Sub

    Public Shared Sub Rand()
        Dim random As Random = New Random()
        Dim Count As Integer = 1
        Form1.TextBox1.Text = ""
        Dim randnum As String = ""
        Dim flag As Boolean = Form1.CheckBox1.Checked
        If flag Then
            randnum += "abcdefghijklmnopqrstuvwxyz"
        End If
        flag = Form1.CheckBox2.Checked
        If flag Then
            randnum += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        End If
        flag = Form1.CheckBox3.Checked
        If flag Then
            randnum += "0123456789"
        End If
        flag = Form1.CheckBox4.Checked
        If flag Then
            randnum += "&é(-è_çà)=^$ù*,;:!¨£%µ?./§\`|[{#~"
        End If
        flag = (Operators.CompareString(Form1.TextBox2.Text, "0", False) <= 0)
        ' The following expression was wrapped in a checked-statement
        If flag Then
            Form1.TextBox1.Text = "??????????"
            Interaction.MsgBox("Entrez un nombre supérieur à 0", MsgBoxStyle.Information, "Information")
        Else
            flag = (Conversions.ToDouble(Form1.TextBox2.Text) >= 21.0)
            If flag Then
                Interaction.MsgBox("Entrez un nombre inférieur à " + Form1.TextBox2.Text + vbCrLf & "(Doit être entre 0 et 20)", MsgBoxStyle.Information, "Information")
            Else
                While CDec(Count) <= Conversions.ToDouble(Form1.TextBox2.Text)
                    Dim test As String = Conversions.ToString(random.[Next](0, randnum.Length))
                    Form1.TextBox1.Text = Form1.TextBox1.Text + Conversions.ToString(randnum(Conversions.ToInteger(test)))
                    Count += 1
                End While
            End If
        End If
    End Sub
End Class