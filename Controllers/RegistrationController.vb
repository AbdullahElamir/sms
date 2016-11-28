Imports System.Web.Mvc
Imports log4net

Namespace Controllers
    Public Class RegistrationController
        Inherits Controller

        Public logger As ILog = LogManager.GetLogger("SMSSystem")

        ' GET: Registration
        Function Index(ByVal message As String) As String
            logger.Info("#INFO | " & "Start Registration Request ..")

            Dim tokens() As String = message.Split(New Char() {"-"})
            Try
                If (IsNothing(tokens) Or tokens.Length <> 3 Or CType(tokens(0), Integer) <> 1 Or (CType(tokens(1), Integer) <> 1 And CType(tokens(1), Integer) <> 2) Or Not (IsNumeric(tokens(2))) Or tokens(2).Length <> 10 Or Not (tokens(2).StartsWith("091"))) Then
                    Throw New Exception()
                End If
            Catch ex As Exception
                logger.Error("#Error | " & "Your message for registration is invalid, please try again.")
                logger.Info("#INFO | " & "End Registration Request.")
                Return "خطأ في مدخلات التسجيل، الرجاء المحاولة مرة أخرى!"
            End Try

            Dim simType As Integer = CType(tokens(1), Integer)
            Dim simNumber As Integer = CType(tokens(2), Integer)





            'logger.Debug("#Debug | " & "Your message")
            'logger.Info("#INFO | " & "Your message")
            'logger.Warn("#Warn | " & "Your message")
            'logger.Error("#Error | " & "Your message")
            'logger.Fatal("#Fatal | " & "Your message")


            logger.Info("#INFO | " & "Successfully Registered.")
            logger.Info("#INFO | " & "End Registration Request.")
            Return "تم التسجيل بنجاح"
        End Function

    End Class
End Namespace