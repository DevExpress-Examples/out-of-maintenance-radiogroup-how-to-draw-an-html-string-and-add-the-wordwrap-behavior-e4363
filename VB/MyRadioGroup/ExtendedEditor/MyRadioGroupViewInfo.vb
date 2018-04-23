Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports System.Windows.Forms

Namespace EditorDescendant
	Public Class MyRadioGroupViewInfo
		Inherits RadioGroupViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub



		Protected Overrides Function CreateItemInfo(ByVal item As DevExpress.XtraEditors.Controls.RadioGroupItem) As RadioGroupItemViewInfo
			Dim info As CheckObjectInfoArgs = (CType(MyBase.CreateItemInfo(item), CheckObjectInfoArgs))
			info.AllowHtmlString = (CType(OwnerEdit.Properties, MyRepositoryItemRadioGroup)).AllowHtmlString

			Return CType(info, RadioGroupItemViewInfo)
		End Function


		Protected Overrides ReadOnly Property MinItemHeight() As Integer
			Get
				Dim heght As Integer = (CType(OwnerEdit.Properties, MyRepositoryItemRadioGroup)).MinItemHeight
				Return heght
			End Get
		End Property
	End Class
End Namespace
