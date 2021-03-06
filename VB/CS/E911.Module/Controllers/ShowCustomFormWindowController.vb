﻿Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.SystemModule

Namespace E911.Module.Controllers
	''' <summary>
	''' This is a base WindowController that handles events of the ShowNavigationItemController class to display a custom form when a custom navigation item is clicked (http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppSystemModuleShowNavigationItemControllertopic).
	''' </summary>
	Public MustInherit Class ShowCustomFormWindowController
		Inherits WindowController
		Private navigationController As ShowNavigationItemController
		Public Sub New()
			TargetWindowType = WindowType.Main
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			navigationController = Frame.GetController(Of ShowNavigationItemController)()
			If navigationController IsNot Nothing Then
				AddHandler navigationController.CustomShowNavigationItem, AddressOf navigationController_CustomShowNavigationItem
			End If
		End Sub
		Protected Overrides Sub OnDeactivated()
			If navigationController IsNot Nothing Then
				RemoveHandler navigationController.CustomShowNavigationItem, AddressOf navigationController_CustomShowNavigationItem
			End If
			MyBase.OnDeactivated()
		End Sub
		Private Sub navigationController_CustomShowNavigationItem(ByVal sender As Object, ByVal e As CustomShowNavigationItemEventArgs)
			If e.ActionArguments.SelectedChoiceActionItem.Id = "CustomForm" Then
				ShowCustomForm(TryCast(e.ActionArguments.SelectedChoiceActionItem.Model, IModelNavigationItem))
				e.Handled = True
			End If
		End Sub
		Protected MustOverride Sub ShowCustomForm(ByVal model As IModelNavigationItem)
	End Class
End Namespace
