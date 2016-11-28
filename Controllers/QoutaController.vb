Imports System.Web.Mvc
Imports log4net

Namespace Controllers
    Public Class QoutaController
        Inherits Controller

        Dim logger As ILog = LogManager.GetLogger("SMSSystem")

        ' GET: Qouta
        Function Index(ByVal message As String) As String
            ' الفواصل سوف تكون عن طريق اشارة الماينس -












            ' استخدم احد هذه الفنكشن للطباعة في ملف اللوق الموجود في ملفات المشروع
            logger.Debug("#Debug | " & "Your message")
            logger.Info("#INFO | " & "Your message")
            logger.Warn("#Warn | " & "Your message")
            logger.Error("#Error | " & "Your message")
            logger.Fatal("#Fatal | " & "Your message")


            ' الرسائل سوف تكون تعرض عن طريق جملة  Return
            Return "عرض الرصيد والنقاط الخاصة بك"
        End Function

    End Class
End Namespace