#pragma checksum "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94fa6edabba124a01e3a22c8f96e7cc52099cc65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskList_ListTasks), @"mvc.1.0.view", @"/Views/TaskList/ListTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TaskList/ListTasks.cshtml", typeof(AspNetCore.Views_TaskList_ListTasks))]
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
#line 1 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\_ViewImports.cshtml"
using TaskListCapstone6;

#line default
#line hidden
#line 2 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\_ViewImports.cshtml"
using TaskListCapstone6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fa6edabba124a01e3a22c8f96e7cc52099cc65", @"/Views/TaskList/ListTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd504959524e00aa2e8f92b2d5a3cd9aedbae02", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskList_ListTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"
  
    ViewData["Title"] = "ListTasks";

#line default
#line hidden
            BeginContext(47, 25, true);
            WriteLiteral("\r\n<h1>List Tasks</h1>\r\n\r\n");
            EndContext();
            BeginContext(102, 136, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>     \r\n        <th>Description</th>\r\n        <th>Due Date</th>\r\n        <th>Completed</th>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(279, 14, true);
            WriteLiteral("<tr>\r\n    <td>");
            EndContext();
            BeginContext(294, 16, false);
#line 19 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"
   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(310, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(326, 12, false);
#line 20 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"
   Write(item.DueDate);

#line default
#line hidden
            EndContext();
            BeginContext(338, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(354, 14, false);
#line 21 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"
   Write(item.Completed);

#line default
#line hidden
            EndContext();
            BeginContext(368, 17, true);
            WriteLiteral("</td>\r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 385, "\"", 428, 2);
            WriteAttributeValue("", 392, "/TaskList/DeleteTask?Id=", 392, 24, true);
#line 22 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"
WriteAttributeValue("", 416, item.TaskId, 416, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(429, 66, true);
            WriteLiteral("><input type=\"submit\" value=\"Delete Task\" /> </a></td>\r\n    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 495, "\"", 538, 2);
            WriteAttributeValue("", 502, "/TaskList/UpdateTask?Id=", 502, 24, true);
#line 23 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"
WriteAttributeValue("", 526, item.TaskId, 526, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(539, 65, true);
            WriteLiteral("><input type=\"submit\" value=\"Mark Complete\" /> </a></td>\r\n</tr>\r\n");
            EndContext();
#line 25 "C:\Users\josep\source\repos\TaskListCapstone6\TaskListCapstone6\Views\TaskList\ListTasks.cshtml"


    }

#line default
#line hidden
            BeginContext(615, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
