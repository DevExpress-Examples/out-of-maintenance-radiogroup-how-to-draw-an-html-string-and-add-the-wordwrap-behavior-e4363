Imports Microsoft.VisualBasic
Imports System
Namespace GridProject
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myRadioGroup1 = New EditorDescendant.MyRadioGroup()
			CType(Me.myRadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myRadioGroup1
			' 
			Me.myRadioGroup1.Location = New System.Drawing.Point(12, 12)
			Me.myRadioGroup1.Name = "myRadioGroup1"
			Me.myRadioGroup1.Properties.AllowHtmlString = True
			Me.myRadioGroup1.Properties.Appearance.Options.UseTextOptions = True
			Me.myRadioGroup1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.myRadioGroup1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			Me.myRadioGroup1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.myRadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "<size=14>Some text <br> <size=12>Some text<br><br> <size=10>Some text<br>"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "<size=14>Some text <br> <size=12>Some text<br><br> <size=10>Some text<br>"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "<size=14>Some text <br> <size=12>Some text<br><br> <size=10>Some text<br>")})
			Me.myRadioGroup1.Properties.MinItemHeight = 100
			Me.myRadioGroup1.Size = New System.Drawing.Size(577, 560)
			Me.myRadioGroup1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(601, 584)
			Me.Controls.Add(Me.myRadioGroup1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myRadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myRadioGroup1 As EditorDescendant.MyRadioGroup


	End Class
End Namespace

