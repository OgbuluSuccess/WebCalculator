#pragma checksum "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\Calculate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9ca263089da982f1458b02da5919b9a9d0d61e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculate_Index), @"mvc.1.0.view", @"/Views/Calculate/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\_ViewImports.cshtml"
using WebCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ca263089da982f1458b02da5919b9a9d0d61e6", @"/Views/Calculate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea914b35850a00275709f524f4b0ae27c2788f89", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>

<script type=""text/javascript"">


    //function displaySeven() {
    //    document.getElementById(""answer_screen"").value = ""7""
    //}
    //function displayEight() {
    //    document.getElementById(""answer_screen"").value = ""8""
    //}
    /*var str = ""22"";*/
    
   

");
            WriteLiteral(@"        //$(""#seven"").click(function () {
        //    alert(""success"")
        //});

    $(function (){
        $(""#txt"").keypress(function (e) {
            if (String.fromCharCode(e.keyCode).match(/[^0-9+-/*]/g)) return false;
        });
        $(""#txt"").height(""40px"").width(""312px"");
        $(""#b0"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""0"");
            } else {
                $(""#txt"").val(x + ""0"")
            }
        });
        $(""#b1"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""1"");
            } else {
                $(""#txt"").val(x + ""1"")
            }
        });
        $(""#b2"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""2"");
            } else {
                $(""#txt"").val(x");
            WriteLiteral(@" + ""2"")
            }
        });
        $(""#b3"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""3"");
            } else {
                $(""#txt"").val(x + ""3"")
            }
        });
        $(""#b4"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""4"");
            } else {
                $(""#txt"").val(x + ""4"")
            }
        });
        $(""#b5"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""5"");
            } else {
                $(""#txt"").val(x + ""5"")
            }
        });
        $(""#b6"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""6"");
            } else {
                $(""#txt"").val(x + ""6"")
   ");
            WriteLiteral(@"         }
        });
        $(""#b7"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""7"");
            } else {
                $(""#txt"").val(x + ""7"")
            }
        });
        $(""#b8"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""8"");
            } else {
                $(""#txt"").val(x + ""8"")
            }
        });
        $(""#b9"").click(function () {
            var x = document.getElementById(""txt"").value;
            if (x == ""0"") {
                $(""#txt"").val(""9"");
            } else {
                $(""#txt"").val(x + ""9"")
            }
        });
        $(""#div"").click(function () {
            var x = document.getElementById(""txt"").value;
            var y = x.slice(-1)
            if (y == ""/"" || y == ""+"" || y == ""*"" || y == ""-"") { } else {
                $(""#txt"").val(x + """);
            WriteLiteral(@"/"")
            }
        });
        $(""#multy"").click(function () {
            var x = document.getElementById(""txt"").value;
            var x = document.getElementById(""txt"").value;
            var y = x.slice(-1)
            if (y == ""/"" || y == ""+"" || y == ""*"" || y == ""-"") { } else {
                $(""#txt"").val(x + ""*"")
            }
        });
        $(""#sub"").click(function () {
            var x = document.getElementById(""txt"").value;
            var x = document.getElementById(""txt"").value;
            var x = document.getElementById(""txt"").value;
            var y = x.slice(-1)
            if (y == ""/"" || y == ""+"" || y == ""*"" || y == ""-"") { } else {
                $(""#txt"").val(x + ""-"")
            }
        });
        $(""#add"").click(function () {
            var x = document.getElementById(""txt"").value;
            var x = document.getElementById(""txt"").value;
            var x = document.getElementById(""txt"").value;
            var x = document.getElementById(""txt"")");
            WriteLiteral(@".value;
            var y = x.slice(-1)
            if (y == ""/"" || y == ""+"" || y == ""*"" || y == ""-"") { } else {
                $(""#txt"").val(x + ""+"")
            }
        });
        $(""#dot"").click(function () {
            var x = document.getElementById(""txt"").value;
            var y = x.slice(-1)
            if (y == ""."") { } else {
                $(""#txt"").val(x + ""."")
            }
        });
        $(""#ce"").click(function () {
            var x = document.getElementById(""txt"").value;
            $(""#txt"").val(x.substring(0, x.length - 1))
        });
    });
</script>
<style>
    body {
        background-image: url(""Image/images.jpg"");
    }

    #d1 {
        border: 2px solid black;
        height: 350px;
        width: 340px;
        background-color: black;
        color: white;
    }
    #add, #multy, #sub, #div {
        background-color: lightseagreen;
        color: white;
    }
    #eq {
        background-color: purple;
        color: white;
    }");
            WriteLiteral("\r\n    #ce {\r\n        background-color: yellow;\r\n        color: black;\r\n    }\r\n    #re {\r\n        background-color: red;\r\n        color: white;\r\n    }\r\n\r\n\r\n</style>\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<center>\r\n    <div id=\"d1\">\r\n");
#nullable restore
#line 204 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\Calculate\Index.cshtml"
         using (@Html.BeginForm("Index", "Calculate"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table style=""height:50%;border:thick"">
                <tr>
                    <td colspan=""4"">
                        <center>
                            <h2>My Calculator</h2>
                        </center>
                    </td>
                </tr>
                <tr>
                    <td colspan=""4""><center>");
#nullable restore
#line 215 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\Calculate\Index.cshtml"
                                       Write(Html.TextBox("txt", (string)ViewBag.result));

#line default
#line hidden
#nullable disable
            WriteLiteral("</center></td>\r\n");
            WriteLiteral(@"                </tr>
                <tr>
                    <td><input type=""button""  id=""b7"" value=""7"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button""  id=""b8"" value=""8"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""b9"" value=""9"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""div"" value=""/"" style=""height:40px;width:75px"" /></td>
                </tr>
                <tr>
                    <td><input type=""button"" id=""b4"" value=""4"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""b5"" value=""5"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""b6"" value=""6"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""multy"" value=""*"" style=""height:40px;width:75px"" /></td>
                </tr>
                <tr>
                    <td><input type=""button"" id=""b1"" value=");
            WriteLiteral(@"""1"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""b2"" value=""2"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""b3"" value=""3"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""sub"" value=""-"" style=""height:40px;width:75px"" /></td>
                </tr>
                <tr>
                    <td><input type=""button"" id=""b0"" value=""0"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""dot"" value=""."" style=""height:40px;width:75px"" /></td>
                    <td><input type=""button"" id=""add"" value=""+"" style=""height:40px;width:75px"" /></td>
                    <td><input type=""submit"" id=""eq"" value=""="" style=""height:40px;width:75px"" /></td>
                </tr>
                <tr>
                    <td colspan=""2"">
                        <input type=""button"" id=""ce"" value=""CE"" style=""height:40px;width:155px"" />
                    </td>
 ");
            WriteLiteral(@"                   <td colspan=""2"">
                        <input type=""reset"" id=""re"" value=""Clear"" style=""height:40px;width:155px"" />
                    </td>
                </tr>
                <tr>
                    <td colspan=""4"">
                        <center>
                            <h2>Result : ");
#nullable restore
#line 253 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\Calculate\Index.cshtml"
                                    Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        </center>\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n");
#nullable restore
#line 258 "C:\Users\OGBULU SUCCESS\source\repos\WebCalculator\WebCalculator\Views\Calculate\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</center>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591