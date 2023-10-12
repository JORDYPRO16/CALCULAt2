<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtPantalla = New System.Windows.Forms.TextBox()
        Me.BtnBorrar1 = New System.Windows.Forms.Button()
        Me.BtnborrarTD = New System.Windows.Forms.Button()
        Me.BtnElevado = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.BtnMultiplicacion = New System.Windows.Forms.Button()
        Me.BtnResta = New System.Windows.Forms.Button()
        Me.BtnSuma = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnPunto = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 93)
        Me.Panel1.TabIndex = 0
        '
        'TxtPantalla
        '
        Me.TxtPantalla.Location = New System.Drawing.Point(0, 90)
        Me.TxtPantalla.Multiline = True
        Me.TxtPantalla.Name = "TxtPantalla"
        Me.TxtPantalla.Size = New System.Drawing.Size(621, 122)
        Me.TxtPantalla.TabIndex = 1
        '
        'BtnBorrar1
        '
        Me.BtnBorrar1.BackColor = System.Drawing.Color.Orange
        Me.BtnBorrar1.Image = Global.Tarea2.My.Resources.Resources.borrar
        Me.BtnBorrar1.Location = New System.Drawing.Point(19, 280)
        Me.BtnBorrar1.Name = "BtnBorrar1"
        Me.BtnBorrar1.Size = New System.Drawing.Size(75, 68)
        Me.BtnBorrar1.TabIndex = 20
        Me.BtnBorrar1.UseVisualStyleBackColor = False
        '
        'BtnborrarTD
        '
        Me.BtnborrarTD.BackColor = System.Drawing.Color.Orange
        Me.BtnborrarTD.Image = Global.Tarea2.My.Resources.Resources._8664965_c_alphabet_icon
        Me.BtnborrarTD.Location = New System.Drawing.Point(100, 280)
        Me.BtnborrarTD.Name = "BtnborrarTD"
        Me.BtnborrarTD.Size = New System.Drawing.Size(75, 68)
        Me.BtnborrarTD.TabIndex = 19
        Me.BtnborrarTD.UseVisualStyleBackColor = False
        '
        'BtnElevado
        '
        Me.BtnElevado.BackColor = System.Drawing.Color.Orange
        Me.BtnElevado.Image = Global.Tarea2.My.Resources.Resources.Elevado
        Me.BtnElevado.Location = New System.Drawing.Point(181, 280)
        Me.BtnElevado.Name = "BtnElevado"
        Me.BtnElevado.Size = New System.Drawing.Size(75, 68)
        Me.BtnElevado.TabIndex = 18
        Me.BtnElevado.UseVisualStyleBackColor = False
        '
        'btnDivision
        '
        Me.btnDivision.BackColor = System.Drawing.Color.Orange
        Me.btnDivision.Image = Global.Tarea2.My.Resources.Resources.division
        Me.btnDivision.Location = New System.Drawing.Point(262, 280)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(75, 68)
        Me.btnDivision.TabIndex = 17
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'BtnMultiplicacion
        '
        Me.BtnMultiplicacion.BackColor = System.Drawing.Color.Orange
        Me.BtnMultiplicacion.Image = Global.Tarea2.My.Resources.Resources.Equis
        Me.BtnMultiplicacion.Location = New System.Drawing.Point(262, 354)
        Me.BtnMultiplicacion.Name = "BtnMultiplicacion"
        Me.BtnMultiplicacion.Size = New System.Drawing.Size(75, 68)
        Me.BtnMultiplicacion.TabIndex = 16
        Me.BtnMultiplicacion.UseVisualStyleBackColor = False
        '
        'BtnResta
        '
        Me.BtnResta.BackColor = System.Drawing.Color.Orange
        Me.BtnResta.Image = Global.Tarea2.My.Resources.Resources.Menos
        Me.BtnResta.Location = New System.Drawing.Point(262, 428)
        Me.BtnResta.Name = "BtnResta"
        Me.BtnResta.Size = New System.Drawing.Size(75, 68)
        Me.BtnResta.TabIndex = 15
        Me.BtnResta.UseVisualStyleBackColor = False
        '
        'BtnSuma
        '
        Me.BtnSuma.BackColor = System.Drawing.Color.Orange
        Me.BtnSuma.Image = Global.Tarea2.My.Resources.Resources.Mas
        Me.BtnSuma.Location = New System.Drawing.Point(262, 502)
        Me.BtnSuma.Name = "BtnSuma"
        Me.BtnSuma.Size = New System.Drawing.Size(75, 68)
        Me.BtnSuma.TabIndex = 14
        Me.BtnSuma.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Orange
        Me.BtnCalcular.Image = Global.Tarea2.My.Resources.Resources.igual
        Me.BtnCalcular.Location = New System.Drawing.Point(262, 576)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 55)
        Me.BtnCalcular.TabIndex = 13
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnPunto
        '
        Me.BtnPunto.Image = Global.Tarea2.My.Resources.Resources.Punto
        Me.BtnPunto.Location = New System.Drawing.Point(181, 576)
        Me.BtnPunto.Name = "BtnPunto"
        Me.BtnPunto.Size = New System.Drawing.Size(75, 55)
        Me.BtnPunto.TabIndex = 12
        Me.BtnPunto.UseVisualStyleBackColor = True
        '
        'Btn0
        '
        Me.Btn0.Image = Global.Tarea2.My.Resources.Resources._0
        Me.Btn0.Location = New System.Drawing.Point(19, 576)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(156, 55)
        Me.Btn0.TabIndex = 11
        Me.Btn0.UseVisualStyleBackColor = True
        '
        'Btn3
        '
        Me.Btn3.Image = Global.Tarea2.My.Resources.Resources._3
        Me.Btn3.Location = New System.Drawing.Point(181, 502)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 68)
        Me.Btn3.TabIndex = 10
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Image = Global.Tarea2.My.Resources.Resources._2
        Me.Btn2.Location = New System.Drawing.Point(100, 502)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 68)
        Me.Btn2.TabIndex = 9
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Image = Global.Tarea2.My.Resources.Resources._1
        Me.Btn1.Location = New System.Drawing.Point(19, 502)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 68)
        Me.Btn1.TabIndex = 8
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn6
        '
        Me.Btn6.Image = Global.Tarea2.My.Resources.Resources._6
        Me.Btn6.Location = New System.Drawing.Point(181, 428)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(75, 68)
        Me.Btn6.TabIndex = 7
        Me.Btn6.UseVisualStyleBackColor = True
        '
        'Btn5
        '
        Me.Btn5.Image = Global.Tarea2.My.Resources.Resources._5
        Me.Btn5.Location = New System.Drawing.Point(100, 428)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(75, 68)
        Me.Btn5.TabIndex = 6
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn4
        '
        Me.Btn4.Image = Global.Tarea2.My.Resources.Resources._4
        Me.Btn4.Location = New System.Drawing.Point(19, 428)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 68)
        Me.Btn4.TabIndex = 5
        Me.Btn4.UseVisualStyleBackColor = True
        '
        'Btn9
        '
        Me.Btn9.Image = Global.Tarea2.My.Resources.Resources._9
        Me.Btn9.Location = New System.Drawing.Point(181, 354)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(75, 68)
        Me.Btn9.TabIndex = 4
        Me.Btn9.UseVisualStyleBackColor = True
        '
        'Btn8
        '
        Me.Btn8.Image = Global.Tarea2.My.Resources.Resources._8
        Me.Btn8.Location = New System.Drawing.Point(100, 354)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(75, 68)
        Me.Btn8.TabIndex = 3
        Me.Btn8.UseVisualStyleBackColor = True
        '
        'Btn7
        '
        Me.Btn7.Image = Global.Tarea2.My.Resources.Resources._7
        Me.Btn7.Location = New System.Drawing.Point(19, 354)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(75, 68)
        Me.Btn7.TabIndex = 2
        Me.Btn7.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = Global.Tarea2.My.Resources.Resources.Icono_cerrar_FN
        Me.BtnCerrar.Location = New System.Drawing.Point(541, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 72)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Image = Global.Tarea2.My.Resources.Resources.Icono_Minimizar
        Me.BtnMinimizar.Location = New System.Drawing.Point(470, 12)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(75, 72)
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(621, 692)
        Me.Controls.Add(Me.BtnBorrar1)
        Me.Controls.Add(Me.BtnborrarTD)
        Me.Controls.Add(Me.BtnElevado)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.BtnMultiplicacion)
        Me.Controls.Add(Me.BtnResta)
        Me.Controls.Add(Me.BtnSuma)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnPunto)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.TxtPantalla)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TxtPantalla As TextBox
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnPunto As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnSuma As Button
    Friend WithEvents BtnResta As Button
    Friend WithEvents BtnMultiplicacion As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents BtnElevado As Button
    Friend WithEvents BtnborrarTD As Button
    Friend WithEvents BtnBorrar1 As Button
End Class
