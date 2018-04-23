' Developer Express Code Central Example:
' How to iterate through all ASPxFormLayout items
' 
' This example demonstrates how to iterate through all ASPxFormLayout items using
' the LayoutGroupBase.ForEach method
' (http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxFormLayoutLayoutGroupBasetopic).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4574

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxFormLayout
Imports System.Diagnostics

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
    Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each item In layout.Items
            If TypeOf item Is LayoutGroupBase Then
                TryCast(item, LayoutGroupBase).ForEach(AddressOf GetNestedControls)
            End If
        Next item
    End Sub
    Private Sub GetNestedControls(ByVal item As LayoutItemBase)
            If TypeOf item Is LayoutItem Then
                SetValue(TryCast(item, LayoutItem))
            End If

    End Sub
    Private Shared Sub SetValue(ByVal c As LayoutItem)
        For Each control As Control In c.Controls
            Dim editor As ASPxEdit = TryCast(control, ASPxEdit)
            If editor IsNot Nothing Then
                editor.Value = Date.Now.ToString()
            End If
        Next control
    End Sub
End Class