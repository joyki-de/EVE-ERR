'
' Created by SharpDevelop.
' User: Joyki
' Date: 10.01.2014
' Time: 12:10
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.label3 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.inputVeldspar = New System.Windows.Forms.TextBox()
		Me.inputScordite = New System.Windows.Forms.TextBox()
		Me.inputPyroxeres = New System.Windows.Forms.TextBox()
		Me.inputKernite = New System.Windows.Forms.TextBox()
		Me.oMiningMinuteVeldspar = New System.Windows.Forms.TextBox()
		Me.oMiningMinuteScordite = New System.Windows.Forms.TextBox()
		Me.oMiningMinutePyroxeres = New System.Windows.Forms.TextBox()
		Me.oMiningMinuteKernite = New System.Windows.Forms.TextBox()
		Me.oMiningLadungVeldspar = New System.Windows.Forms.TextBox()
		Me.oMiningLadungScordite = New System.Windows.Forms.TextBox()
		Me.oMiningLadungPyroxeres = New System.Windows.Forms.TextBox()
		Me.oMiningLadungKernite = New System.Windows.Forms.TextBox()
		Me.oErtragMinuteVeldspar = New System.Windows.Forms.TextBox()
		Me.oErtragMinuteScordite = New System.Windows.Forms.TextBox()
		Me.oErtragMinutePyroxeres = New System.Windows.Forms.TextBox()
		Me.oErtragMinutekernite = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.inputMinerLeistung = New System.Windows.Forms.TextBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.inputFrachtraumm3 = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label13 = New System.Windows.Forms.Label()
		Me.oErtragLadungVeldspar = New System.Windows.Forms.TextBox()
		Me.oErtragLadungScordite = New System.Windows.Forms.TextBox()
		Me.oErtragLadungPyroxeres = New System.Windows.Forms.TextBox()
		Me.oErtragLadungKernite = New System.Windows.Forms.TextBox()
		Me.label14 = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(82, 9)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(86, 22)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Aktueller Preis:"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(286, 9)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 24)
		Me.label5.TabIndex = 7
		Me.label5.Text = "Ertrag / m³"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(315, 294)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(138, 27)
		Me.button1.TabIndex = 14
		Me.button1.Text = "Berrechnen"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(48, 17)
		Me.label1.TabIndex = 15
		Me.label1.Text = "Erz"
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(396, 9)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(100, 24)
		Me.label8.TabIndex = 16
		Me.label8.Text = "Ertrag / Minute"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(174, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 17
		Me.label2.Text = "Mining / Minute"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(12, 41)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(68, 15)
		Me.label4.TabIndex = 18
		Me.label4.Text = "Veldspar"
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(12, 67)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(68, 15)
		Me.label6.TabIndex = 19
		Me.label6.Text = "Scordite"
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(12, 93)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(68, 15)
		Me.label7.TabIndex = 20
		Me.label7.Text = "Pyroxeres"
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(12, 119)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(68, 15)
		Me.label9.TabIndex = 21
		Me.label9.Text = "Kernite"
		'
		'inputVeldspar
		'
		Me.inputVeldspar.Location = New System.Drawing.Point(82, 38)
		Me.inputVeldspar.Name = "inputVeldspar"
		Me.inputVeldspar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.inputVeldspar.Size = New System.Drawing.Size(68, 20)
		Me.inputVeldspar.TabIndex = 22
		'
		'inputScordite
		'
		Me.inputScordite.Location = New System.Drawing.Point(82, 64)
		Me.inputScordite.Name = "inputScordite"
		Me.inputScordite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.inputScordite.Size = New System.Drawing.Size(68, 20)
		Me.inputScordite.TabIndex = 23
		'
		'inputPyroxeres
		'
		Me.inputPyroxeres.Location = New System.Drawing.Point(82, 90)
		Me.inputPyroxeres.Name = "inputPyroxeres"
		Me.inputPyroxeres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.inputPyroxeres.Size = New System.Drawing.Size(68, 20)
		Me.inputPyroxeres.TabIndex = 24
		'
		'inputKernite
		'
		Me.inputKernite.Location = New System.Drawing.Point(82, 116)
		Me.inputKernite.Name = "inputKernite"
		Me.inputKernite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.inputKernite.Size = New System.Drawing.Size(68, 20)
		Me.inputKernite.TabIndex = 25
		'
		'oMiningMinuteVeldspar
		'
		Me.oMiningMinuteVeldspar.Location = New System.Drawing.Point(174, 38)
		Me.oMiningMinuteVeldspar.Name = "oMiningMinuteVeldspar"
		Me.oMiningMinuteVeldspar.ReadOnly = true
		Me.oMiningMinuteVeldspar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningMinuteVeldspar.Size = New System.Drawing.Size(100, 20)
		Me.oMiningMinuteVeldspar.TabIndex = 26
		'
		'oMiningMinuteScordite
		'
		Me.oMiningMinuteScordite.Location = New System.Drawing.Point(174, 64)
		Me.oMiningMinuteScordite.Name = "oMiningMinuteScordite"
		Me.oMiningMinuteScordite.ReadOnly = true
		Me.oMiningMinuteScordite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningMinuteScordite.Size = New System.Drawing.Size(100, 20)
		Me.oMiningMinuteScordite.TabIndex = 27
		'
		'oMiningMinutePyroxeres
		'
		Me.oMiningMinutePyroxeres.Location = New System.Drawing.Point(174, 88)
		Me.oMiningMinutePyroxeres.Name = "oMiningMinutePyroxeres"
		Me.oMiningMinutePyroxeres.ReadOnly = true
		Me.oMiningMinutePyroxeres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningMinutePyroxeres.Size = New System.Drawing.Size(100, 20)
		Me.oMiningMinutePyroxeres.TabIndex = 28
		'
		'oMiningMinuteKernite
		'
		Me.oMiningMinuteKernite.Location = New System.Drawing.Point(174, 116)
		Me.oMiningMinuteKernite.Name = "oMiningMinuteKernite"
		Me.oMiningMinuteKernite.ReadOnly = true
		Me.oMiningMinuteKernite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningMinuteKernite.Size = New System.Drawing.Size(100, 20)
		Me.oMiningMinuteKernite.TabIndex = 29
		'
		'oMiningLadungVeldspar
		'
		Me.oMiningLadungVeldspar.Location = New System.Drawing.Point(286, 38)
		Me.oMiningLadungVeldspar.Name = "oMiningLadungVeldspar"
		Me.oMiningLadungVeldspar.ReadOnly = true
		Me.oMiningLadungVeldspar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningLadungVeldspar.Size = New System.Drawing.Size(100, 20)
		Me.oMiningLadungVeldspar.TabIndex = 30
		'
		'oMiningLadungScordite
		'
		Me.oMiningLadungScordite.Location = New System.Drawing.Point(286, 64)
		Me.oMiningLadungScordite.Name = "oMiningLadungScordite"
		Me.oMiningLadungScordite.ReadOnly = true
		Me.oMiningLadungScordite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningLadungScordite.Size = New System.Drawing.Size(100, 20)
		Me.oMiningLadungScordite.TabIndex = 31
		'
		'oMiningLadungPyroxeres
		'
		Me.oMiningLadungPyroxeres.Location = New System.Drawing.Point(286, 90)
		Me.oMiningLadungPyroxeres.Name = "oMiningLadungPyroxeres"
		Me.oMiningLadungPyroxeres.ReadOnly = true
		Me.oMiningLadungPyroxeres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningLadungPyroxeres.Size = New System.Drawing.Size(100, 20)
		Me.oMiningLadungPyroxeres.TabIndex = 32
		'
		'oMiningLadungKernite
		'
		Me.oMiningLadungKernite.Location = New System.Drawing.Point(286, 116)
		Me.oMiningLadungKernite.Name = "oMiningLadungKernite"
		Me.oMiningLadungKernite.ReadOnly = true
		Me.oMiningLadungKernite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oMiningLadungKernite.Size = New System.Drawing.Size(100, 20)
		Me.oMiningLadungKernite.TabIndex = 33
		'
		'oErtragMinuteVeldspar
		'
		Me.oErtragMinuteVeldspar.Location = New System.Drawing.Point(396, 38)
		Me.oErtragMinuteVeldspar.Name = "oErtragMinuteVeldspar"
		Me.oErtragMinuteVeldspar.ReadOnly = true
		Me.oErtragMinuteVeldspar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragMinuteVeldspar.Size = New System.Drawing.Size(100, 20)
		Me.oErtragMinuteVeldspar.TabIndex = 34
		'
		'oErtragMinuteScordite
		'
		Me.oErtragMinuteScordite.Location = New System.Drawing.Point(396, 64)
		Me.oErtragMinuteScordite.Name = "oErtragMinuteScordite"
		Me.oErtragMinuteScordite.ReadOnly = true
		Me.oErtragMinuteScordite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragMinuteScordite.Size = New System.Drawing.Size(100, 20)
		Me.oErtragMinuteScordite.TabIndex = 35
		'
		'oErtragMinutePyroxeres
		'
		Me.oErtragMinutePyroxeres.Location = New System.Drawing.Point(396, 90)
		Me.oErtragMinutePyroxeres.Name = "oErtragMinutePyroxeres"
		Me.oErtragMinutePyroxeres.ReadOnly = true
		Me.oErtragMinutePyroxeres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragMinutePyroxeres.Size = New System.Drawing.Size(100, 20)
		Me.oErtragMinutePyroxeres.TabIndex = 36
		'
		'oErtragMinutekernite
		'
		Me.oErtragMinutekernite.Location = New System.Drawing.Point(396, 116)
		Me.oErtragMinutekernite.Name = "oErtragMinutekernite"
		Me.oErtragMinutekernite.ReadOnly = true
		Me.oErtragMinutekernite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragMinutekernite.Size = New System.Drawing.Size(100, 20)
		Me.oErtragMinutekernite.TabIndex = 37
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(12, 205)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(79, 23)
		Me.label10.TabIndex = 38
		Me.label10.Text = "Miner Leisung"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'inputMinerLeistung
		'
		Me.inputMinerLeistung.Location = New System.Drawing.Point(97, 205)
		Me.inputMinerLeistung.Name = "inputMinerLeistung"
		Me.inputMinerLeistung.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.inputMinerLeistung.Size = New System.Drawing.Size(68, 20)
		Me.inputMinerLeistung.TabIndex = 39
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(12, 232)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(79, 23)
		Me.label11.TabIndex = 40
		Me.label11.Text = "Frachtraum"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'inputFrachtraumm3
		'
		Me.inputFrachtraumm3.Location = New System.Drawing.Point(97, 235)
		Me.inputFrachtraumm3.Name = "inputFrachtraumm3"
		Me.inputFrachtraumm3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.inputFrachtraumm3.Size = New System.Drawing.Size(68, 20)
		Me.inputFrachtraumm3.TabIndex = 41
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(171, 205)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(45, 23)
		Me.label12.TabIndex = 42
		Me.label12.Text = "/60 sec"
		Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(171, 233)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(33, 23)
		Me.label13.TabIndex = 43
		Me.label13.Text = "m³"
		Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'oErtragLadungVeldspar
		'
		Me.oErtragLadungVeldspar.Location = New System.Drawing.Point(502, 38)
		Me.oErtragLadungVeldspar.Name = "oErtragLadungVeldspar"
		Me.oErtragLadungVeldspar.ReadOnly = true
		Me.oErtragLadungVeldspar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragLadungVeldspar.Size = New System.Drawing.Size(100, 20)
		Me.oErtragLadungVeldspar.TabIndex = 44
		'
		'oErtragLadungScordite
		'
		Me.oErtragLadungScordite.Location = New System.Drawing.Point(502, 64)
		Me.oErtragLadungScordite.Name = "oErtragLadungScordite"
		Me.oErtragLadungScordite.ReadOnly = true
		Me.oErtragLadungScordite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragLadungScordite.Size = New System.Drawing.Size(100, 20)
		Me.oErtragLadungScordite.TabIndex = 45
		'
		'oErtragLadungPyroxeres
		'
		Me.oErtragLadungPyroxeres.Location = New System.Drawing.Point(502, 90)
		Me.oErtragLadungPyroxeres.Name = "oErtragLadungPyroxeres"
		Me.oErtragLadungPyroxeres.ReadOnly = true
		Me.oErtragLadungPyroxeres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragLadungPyroxeres.Size = New System.Drawing.Size(100, 20)
		Me.oErtragLadungPyroxeres.TabIndex = 46
		'
		'oErtragLadungKernite
		'
		Me.oErtragLadungKernite.Location = New System.Drawing.Point(502, 116)
		Me.oErtragLadungKernite.Name = "oErtragLadungKernite"
		Me.oErtragLadungKernite.ReadOnly = true
		Me.oErtragLadungKernite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.oErtragLadungKernite.Size = New System.Drawing.Size(100, 20)
		Me.oErtragLadungKernite.TabIndex = 47
		'
		'label14
		'
		Me.label14.Location = New System.Drawing.Point(502, 9)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(100, 24)
		Me.label14.TabIndex = 48
		Me.label14.Text = "Ertrag / Ladung"
		Me.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(27, 294)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(138, 27)
		Me.button2.TabIndex = 49
		Me.button2.Text = "Online Preise abfragen"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(614, 355)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.label14)
		Me.Controls.Add(Me.oErtragLadungKernite)
		Me.Controls.Add(Me.oErtragLadungPyroxeres)
		Me.Controls.Add(Me.oErtragLadungScordite)
		Me.Controls.Add(Me.oErtragLadungVeldspar)
		Me.Controls.Add(Me.label13)
		Me.Controls.Add(Me.label12)
		Me.Controls.Add(Me.inputFrachtraumm3)
		Me.Controls.Add(Me.label11)
		Me.Controls.Add(Me.inputMinerLeistung)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.oErtragMinutekernite)
		Me.Controls.Add(Me.oErtragMinutePyroxeres)
		Me.Controls.Add(Me.oErtragMinuteScordite)
		Me.Controls.Add(Me.oErtragMinuteVeldspar)
		Me.Controls.Add(Me.oMiningLadungKernite)
		Me.Controls.Add(Me.oMiningLadungPyroxeres)
		Me.Controls.Add(Me.oMiningLadungScordite)
		Me.Controls.Add(Me.oMiningLadungVeldspar)
		Me.Controls.Add(Me.oMiningMinuteKernite)
		Me.Controls.Add(Me.oMiningMinutePyroxeres)
		Me.Controls.Add(Me.oMiningMinuteScordite)
		Me.Controls.Add(Me.oMiningMinuteVeldspar)
		Me.Controls.Add(Me.inputKernite)
		Me.Controls.Add(Me.inputPyroxeres)
		Me.Controls.Add(Me.inputScordite)
		Me.Controls.Add(Me.inputVeldspar)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.Text = "EVE Online Erz Effizienz Rechner"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button2 As System.Windows.Forms.Button
	Private label14 As System.Windows.Forms.Label
	Private oErtragLadungKernite As System.Windows.Forms.TextBox
	Private oErtragLadungPyroxeres As System.Windows.Forms.TextBox
	Private oErtragLadungScordite As System.Windows.Forms.TextBox
	Private oErtragLadungVeldspar As System.Windows.Forms.TextBox
	Private label13 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private inputFrachtraumm3 As System.Windows.Forms.TextBox
	Private label11 As System.Windows.Forms.Label
	Private inputMinerLeistung As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private oErtragMinutekernite As System.Windows.Forms.TextBox
	Private oErtragMinutePyroxeres As System.Windows.Forms.TextBox
	Private oErtragMinuteScordite As System.Windows.Forms.TextBox
	Private oErtragMinuteVeldspar As System.Windows.Forms.TextBox
	Private oMiningLadungKernite As System.Windows.Forms.TextBox
	Private oMiningLadungPyroxeres As System.Windows.Forms.TextBox
	Private oMiningLadungScordite As System.Windows.Forms.TextBox
	Private oMiningLadungVeldspar As System.Windows.Forms.TextBox
	Private oMiningMinuteKernite As System.Windows.Forms.TextBox
	Private oMiningMinutePyroxeres As System.Windows.Forms.TextBox
	Private oMiningMinuteScordite As System.Windows.Forms.TextBox
	Private oMiningMinuteVeldspar As System.Windows.Forms.TextBox
	Private inputKernite As System.Windows.Forms.TextBox
	Private inputPyroxeres As System.Windows.Forms.TextBox
	Private inputScordite As System.Windows.Forms.TextBox
	Private inputVeldspar As System.Windows.Forms.TextBox
	Private label9 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private label5 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
