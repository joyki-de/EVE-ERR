'
' Created by SharpDevelop.
' User: Joyki
' Date: 10.01.2014
' Time: 12:10
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		'
		' STARTE BERECHNUNG
		'
		'
		' erst mal die Textfelder als Zahl deklarieren
		' mit Fehlerabfrage
		
		try
		
		Dim varPreisVeldspar As Double = Convert.ToDouble(inputVeldspar.Text)
		Dim varPreisScordite As Double = Convert.ToDouble(inputScordite.Text)
		Dim varPreisPyroxeres As Double = Convert.ToDouble(inputPyroxeres.Text)
		Dim varPreisKernite As Double = Convert.ToDouble(inputKernite.Text)
		Dim varMinerLeistung As Double = Convert.ToDouble(inputMinerLeistung.Text)
		Dim varFrachtraum As Double = Convert.ToDouble(inputFrachtraumm3.Text)
		
		
		
		
		' definition der Faktoren Dichte
		'
		Dim faktorVeldspar As Double = 10
		Dim faktorScoridte As Double = 6.66
		Dim faktorPyroxeres As Double = 3.33
		Dim faktorKernite As Double = 0.83
		
		
		'
		' Ausgabe Mining / Minute
		'
		' 
		Dim oMiningMinVeldspar As Double = varMinerLeistung * faktorVeldspar
		oMiningMinuteVeldspar.Text = oMiningMinVeldspar.ToString("N0")
		
		Dim oMiningMinScordite As Double = varMinerLeistung * faktorScoridte
		oMiningMinuteScordite.Text = oMiningMinScordite.ToString("N0")
		
		Dim oMiningMinPyrox As Double = varMinerLeistung * faktorPyroxeres
		oMiningMinutePyroxeres.Text = oMiningMinPyrox.ToString("N0")
		
		Dim oMiningMinKernite As Double = varMinerLeistung * faktorKernite
		oMiningMinuteKernite.Text = oMiningMinKernite.ToString("N0")
		
		'
		' Ausgabe Ertrag / m3
		'
		'
		Dim Ertragm3Veldspar As Double = varPreisVeldspar * faktorVeldspar
		oMiningLadungVeldspar.Text = Ertragm3Veldspar.ToString("N0")
		
		Dim Ertragm3Scoridte As Double = varPreisScordite * faktorScoridte
		oMiningLadungScordite.Text = Ertragm3Scoridte.ToString("N0")
		
		Dim Ertagm3Pyrox As Double = varPreisPyroxeres * faktorPyroxeres
		oMiningLadungPyroxeres.Text = Ertagm3Pyrox.ToString("N0")
		
		Dim Ertagm3Kernite As Double = varPreisKernite * faktorKernite
		oMiningLadungKernite.Text = Ertagm3Kernite.ToString("N0")
		
		'
		' Ausgabe Ertrag / Minute
		'
		'
		oErtragMinuteVeldspar.Text = (varMinerLeistung * faktorVeldspar * varPreisVeldspar).ToString("N0")
		oErtragMinuteScordite.Text = (varMinerLeistung * faktorScoridte * varPreisScordite).ToString("N0")
		oErtragMinutePyroxeres.Text = (varMinerLeistung * faktorPyroxeres * varPreisPyroxeres).ToString("N0")
		oErtragMinutekernite.Text = (varMinerLeistung * faktorKernite * varPreisKernite).ToString("N0")
		
		'
		' Ausgabe Ertrag / Ladung
		'
		'
		oErtragLadungVeldspar.Text = (Ertragm3Veldspar * varFrachtraum).ToString("N0")
		oErtragLadungScordite.Text = (Ertragm3Scoridte * varFrachtraum).ToString("N0")
		oErtragLadungPyroxeres.Text = (Ertagm3Pyrox * varFrachtraum).ToString("N0")
		oErtragLadungKernite.Text = (Ertagm3Kernite * varFrachtraum).ToString("N0")
		
		'
		
		
		Catch ex As Exception
			MsgBox("Keine Werte eingetragen!    "+ex.Message)
		End Try
		
	End Sub
	

	

	
	
	
	Sub Button2Click(sender As Object, e As EventArgs)
MsgBox("noch in Arbeit")		
	End Sub
End Class
