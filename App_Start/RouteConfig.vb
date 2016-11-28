Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="RegistrationRoute",
            url:="{controller}/{message}/{action}",
            defaults:=New With {.controller = "Registration", .action = "Index"}
        )

        routes.MapRoute(
            name:="RefillRoute",
            url:="{controller}/{message}/{action}",
            defaults:=New With {.controller = "Refill", .action = "Index"}
        )

        routes.MapRoute(
            name:="QoutaRoute",
            url:="{controller}/{message}/{action}",
            defaults:=New With {.controller = "Qouta", .action = "Index"}
        )

        routes.MapRoute(
            name:="TransferRoute",
            url:="{controller}/{message}/{action}",
            defaults:=New With {.controller = "Transfer", .action = "Index"}
        )

        routes.MapRoute(
            name:="SendSMSRoute",
            url:="{controller}/{message}/{action}",
            defaults:=New With {.controller = "SendSMS", .action = "Index"}
        )

    End Sub
End Module