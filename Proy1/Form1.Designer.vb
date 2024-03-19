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
        Me.TextB1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextB2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextB3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.botcalculo = New System.Windows.Forms.Button()
        Me.Labresult1 = New System.Windows.Forms.Label()
        Me.Labper = New System.Windows.Forms.Label()
        Me.Labfecha = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextB1
        '
        Me.TextB1.Location = New System.Drawing.Point(77, 115)
        Me.TextB1.Name = "TextB1"
        Me.TextB1.Size = New System.Drawing.Size(100, 20)
        Me.TextB1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese el Total de la Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese el porcentaje de Propina"
        '
        'TextB2
        '
        Me.TextB2.Location = New System.Drawing.Point(77, 183)
        Me.TextB2.Name = "TextB2"
        Me.TextB2.Size = New System.Drawing.Size(100, 20)
        Me.TextB2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ingrese el total de personas"
        '
        'TextB3
        '
        Me.TextB3.Location = New System.Drawing.Point(77, 251)
        Me.TextB3.Name = "TextB3"
        Me.TextB3.Size = New System.Drawing.Size(100, 20)
        Me.TextB3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Calculo de Cuenta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(254, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total por persona :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(254, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fecha y hora del calculo"
        '
        'botcalculo
        '
        Me.botcalculo.Location = New System.Drawing.Point(86, 304)
        Me.botcalculo.Name = "botcalculo"
        Me.botcalculo.Size = New System.Drawing.Size(91, 31)
        Me.botcalculo.TabIndex = 11
        Me.botcalculo.Text = "Calcular"
        Me.botcalculo.UseVisualStyleBackColor = True
        '
        'Labresult1
        '
        Me.Labresult1.AutoSize = True
        Me.Labresult1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labresult1.Location = New System.Drawing.Point(295, 115)
        Me.Labresult1.Name = "Labresult1"
        Me.Labresult1.Size = New System.Drawing.Size(0, 17)
        Me.Labresult1.TabIndex = 12
        '
        'Labper
        '
        Me.Labper.AutoSize = True
        Me.Labper.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labper.Location = New System.Drawing.Point(389, 186)
        Me.Labper.Name = "Labper"
        Me.Labper.Size = New System.Drawing.Size(0, 17)
        Me.Labper.TabIndex = 13
        '
        'Labfecha
        '
        Me.Labfecha.AutoSize = True
        Me.Labfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labfecha.Location = New System.Drawing.Point(257, 287)
        Me.Labfecha.Name = "Labfecha"
        Me.Labfecha.Size = New System.Drawing.Size(0, 17)
        Me.Labfecha.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 362)
        Me.Controls.Add(Me.Labfecha)
        Me.Controls.Add(Me.Labper)
        Me.Controls.Add(Me.Labresult1)
        Me.Controls.Add(Me.botcalculo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextB3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextB2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextB1)
        Me.Name = "Form1"
        Me.Text = "Calculo de Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextB1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextB2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextB3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents botcalculo As Button
    Friend WithEvents Labresult1 As Label
    Friend WithEvents Labper As Label
    Friend WithEvents Labfecha As Label
End Class
