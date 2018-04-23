Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace EditorDescendant
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyRadioGroup
		Inherits RadioGroup

		#Region "Service"
		Shared Sub New()
			MyRepositoryItemRadioGroup.Register()
		End Sub

		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return MyRepositoryItemRadioGroup.EditorName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As MyRepositoryItemRadioGroup
			Get
				Return TryCast(MyBase.Properties, MyRepositoryItemRadioGroup)
			End Get
		End Property


	 #End Region
	End Class
End Namespace
