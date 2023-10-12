Public Class Calculadora

    Dim numero1 As Double
    Dim numero2 As Double
    Dim operacion As String
    Dim resultado As Double
    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Btn8.Click
        TxtPantalla.Text &= 8
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        TxtPantalla.Text &= 0
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TxtPantalla.Text &= 7
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TxtPantalla.Text &= 9
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TxtPantalla.Text &= 4
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TxtPantalla.Text &= 5
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TxtPantalla.Text &= 6
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtPantalla.Text &= 1
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TxtPantalla.Text &= 2
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TxtPantalla.Text &= 3
    End Sub

    Private Sub RealizarOperacion(operador As String)
        'Realiza la operacion solicitada por medio  del operador
        Select Case operador
            Case "+"
                resultado = (numero1 + numero2).ToString()
            Case "-"
                resultado = (numero1 - numero2).ToString()
            Case "x"
                resultado = (numero1 * numero2).ToString()
            Case "%"
                If numero2 <> 0 Then
                    MessageBox.Show("El resultado de la division es: " & resultado)
                Else
                    MessageBox.Show("No Puede dividir entre 0, porfavor digite otro numero")
                End If
                resultado = (numero1 / numero2).ToString()
            Case "^"
                resultado = (numero1 ^ numero2).ToString()
            Case "."

        End Select
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim cadena = TxtPantalla.Text.Trim()
        Dim ElementosEncadena() As String = cadena.Split(operacion)


        If (ElementosEncadena.Length > 1 And ElementosEncadena(1) <> "") Then

            Dim ValorDM As String = ElementosEncadena(1).Trim()
            numero2 = ValorDM
            RealizarOperacion(operacion)
            MsgBox("El resultado de la operacion:  " + TxtPantalla.Text + " es de:  " + CStr(resultado))

        Else
            'Manejamos el error
            CalcuAvisos1.ShowDialog()
        End If


    End Sub
    Private Sub BtnSuma_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        numero1 = TxtPantalla.Text
        TxtPantalla.Text &= " + "
        operacion = "+"
    End Sub

    Private Sub BtnResta_Click(sender As Object, e As EventArgs) Handles BtnResta.Click
        numero1 = TxtPantalla.Text
        TxtPantalla.Text &= " - "
        operacion = "-"
    End Sub

    Private Sub BtnMultiplicacion_Click(sender As Object, e As EventArgs) Handles BtnMultiplicacion.Click
        numero1 = TxtPantalla.Text
        TxtPantalla.Text &= " x "
        operacion = "x"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        numero1 = TxtPantalla.Text
        TxtPantalla.Text &= " % "
        operacion = "%"

    End Sub

    Private Sub BtnElevado_Click(sender As Object, e As EventArgs) Handles BtnElevado.Click
        numero1 = TxtPantalla.Text
        TxtPantalla.Text &= " ^ "
        operacion = "^"
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnborrarTD_Click(sender As Object, e As EventArgs) Handles BtnborrarTD.Click
        TxtPantalla.Text = "      "
    End Sub

    Private Sub BtnBorrar1_Click(sender As Object, e As EventArgs) Handles BtnBorrar1.Click
        If TxtPantalla.Text.Length > 0 Then
            TxtPantalla.Text = TxtPantalla.Text.Substring(0, TxtPantalla.Text.Length - 1)

        End If
    End Sub

    Private Sub BtnPunto_Click(sender As Object, e As EventArgs) Handles BtnPunto.Click
        numero1 = TxtPantalla.Text
        TxtPantalla.Text &= " . "
        operacion = "."
    End Sub
End Class
