<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.materia1 = New System.Windows.Forms.TextBox()
        Me.materia2 = New System.Windows.Forms.TextBox()
        Me.materia3 = New System.Windows.Forms.TextBox()
        Me.materia4 = New System.Windows.Forms.TextBox()
        Me.materia5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.calculo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sociedad y Cultura IV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matemáticas IV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Laboratorio de medios y tecnología IV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingles IV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Orientación vocacional II"
        '
        'materia1
        '
        Me.materia1.Location = New System.Drawing.Point(351, 9)
        Me.materia1.Name = "materia1"
        Me.materia1.Size = New System.Drawing.Size(100, 20)
        Me.materia1.TabIndex = 5
        '
        'materia2
        '
        Me.materia2.Location = New System.Drawing.Point(351, 38)
        Me.materia2.Name = "materia2"
        Me.materia2.Size = New System.Drawing.Size(100, 20)
        Me.materia2.TabIndex = 6
        '
        'materia3
        '
        Me.materia3.Location = New System.Drawing.Point(351, 69)
        Me.materia3.Name = "materia3"
        Me.materia3.Size = New System.Drawing.Size(100, 20)
        Me.materia3.TabIndex = 7
        '
        'materia4
        '
        Me.materia4.Location = New System.Drawing.Point(351, 101)
        Me.materia4.Name = "materia4"
        Me.materia4.Size = New System.Drawing.Size(100, 20)
        Me.materia4.TabIndex = 8
        '
        'materia5
        '
        Me.materia5.Location = New System.Drawing.Point(351, 137)
        Me.materia5.Name = "materia5"
        Me.materia5.Size = New System.Drawing.Size(100, 20)
        Me.materia5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Promedio:"
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(614, 26)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(21, 24)
        Me.resultado.TabIndex = 11
        Me.resultado.Text = "0"
        '
        'calculo
        '
        Me.calculo.Location = New System.Drawing.Point(557, 79)
        Me.calculo.Name = "calculo"
        Me.calculo.Size = New System.Drawing.Size(75, 35)
        Me.calculo.TabIndex = 12
        Me.calculo.Text = "Calcular promedio"
        Me.calculo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.calculo)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.materia5)
        Me.Controls.Add(Me.materia4)
        Me.Controls.Add(Me.materia3)
        Me.Controls.Add(Me.materia2)
        Me.Controls.Add(Me.materia1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents materia1 As TextBox
    Friend WithEvents materia2 As TextBox
    Friend WithEvents materia3 As TextBox
    Friend WithEvents materia4 As TextBox
    Friend WithEvents materia5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents resultado As Label
    Friend WithEvents calculo As Button
End Class
