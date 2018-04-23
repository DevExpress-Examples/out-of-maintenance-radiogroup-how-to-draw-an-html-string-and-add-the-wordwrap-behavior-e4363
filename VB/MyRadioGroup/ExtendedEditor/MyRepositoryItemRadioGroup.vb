Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing

Namespace EditorDescendant
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyRepositoryItemRadioGroup
		Inherits RepositoryItemRadioGroup
		#Region "Service"

		Shared Sub New()
			Register()
		End Sub

		Public Sub New()
			MinItemHeight = 20
			AllowHtmlString = True
		End Sub
		Friend Const EditorName As String = "MyRadioGroup"

		Public Shared Sub Register()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyRadioGroup), GetType(MyRepositoryItemRadioGroup), GetType(MyRadioGroupViewInfo), New RadioGroupPainter(), True, EditImageIndexes.RadioGroup, GetType(DevExpress.Accessibility.BaseEditAccessible)))
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String

			Get
				Return EditorName
			End Get

		End Property

		#End Region



		Private privateMinItemHeight As Integer
		Public Property MinItemHeight() As Integer
			Get
				Return privateMinItemHeight
			End Get
			Set(ByVal value As Integer)
				privateMinItemHeight = value
			End Set
		End Property


		Private privateAllowHtmlString As Boolean
		Public Property AllowHtmlString() As Boolean
			Get
				Return privateAllowHtmlString
			End Get
			Set(ByVal value As Boolean)
				privateAllowHtmlString = value
			End Set
		End Property


	End Class
End Namespace
