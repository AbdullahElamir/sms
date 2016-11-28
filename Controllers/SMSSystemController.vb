Imports System.Web.Mvc
Imports log4net

Namespace Controllers
    Public Class SMSSystemController
        Inherits Controller

        Public logger As ILog = LogManager.GetLogger("SMSSystem")

        ' GET: Default
        Function Index(Optional ByVal message As String = "") As String
            Try
                If (message.Length <> 0) Then
                    If (message.StartsWith("1")) Then
                        Dim con = DependencyResolver.Current.GetService(Of RegistrationController)
                        Return con.Index(message)
                    ElseIf (message.StartsWith("2")) Then
                        Dim con = DependencyResolver.Current.GetService(Of RefillController)
                        Return con.Index(message)
                    ElseIf (message.StartsWith("3")) Then
                        Dim con = DependencyResolver.Current.GetService(Of QoutaController)
                        Return con.Index(message)
                    ElseIf (message.StartsWith("4")) Then
                        Dim con = DependencyResolver.Current.GetService(Of TransferController)
                        Return con.Index(message)
                    ElseIf (message.StartsWith("5")) Then
                        Dim con = DependencyResolver.Current.GetService(Of SendSMSController)
                        Return con.Index(message)
                    End If
                End If
                Throw New Exception()
            Catch ex As Exception
                logger.Error("#Error | " & "Your message is invalid, please try again.")
                Return "خطأ في الإدخال، الرجاء المحاولة مرة أخرى!"
            End Try
        End Function
    End Class
End Namespace