#pragma checksum "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a20455d391d9e6cf2433dc4eccdecece936644d"
// <auto-generated/>
#pragma warning disable 1591
namespace data01.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using data01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\_Imports.razor"
using data01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Tasks</h1>\r\n");
#nullable restore
#line 8 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
 if (!addingRecord) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "display: flex; justify-content: space-between");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "radio");
            __builder.AddAttribute(9, "name", "radioBtn");
            __builder.AddAttribute(10, "checked", 
#nullable restore
#line 11 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                           currentRadio.Equals("all")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "value", "all");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                           onChangeRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(13, " All tasks\r\n            ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "radio");
            __builder.AddAttribute(16, "name", "radioBtn");
            __builder.AddAttribute(17, "checked", 
#nullable restore
#line 13 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                           currentRadio.Equals("byStatus")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "value", "byStatus");
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                           onChangeRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, " Filter by status\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "mt-2");
            __builder.AddAttribute(23, "style", "display:" + " " + (
#nullable restore
#line 15 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                currentRadio.Equals("byStatus") ? "" : "none"

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.AddMarkupContent(25, "<h5>Select a status </h5>\r\n                ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 17 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                currentStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                          onChangeStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 18 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                     foreach (var sts in statusList)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                        ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 20 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                        sts

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, 
#nullable restore
#line 20 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                               sts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 21 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                      () => addingRecord = true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "New");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    <hr>\r\n");
#nullable restore
#line 30 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
     if (myTasks.Count > 0 && !addingRecord)
    {
        int tot = 0;

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "        ");
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "class", "table table-dark");
            __builder.AddAttribute(52, "border", "1");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.AddMarkupContent(54, "<tr>\r\n                <td>Actions</td>\r\n                <td>ID</td>\r\n                <td>Task</td>\r\n                <td>On charge</td>\r\n                <td>Deadline</td>\r\n                <td>Status</td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
             foreach (var task in myTasks)
            {
                tot++;

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                ");
            __builder.OpenElement(56, "tr");
            __builder.AddAttribute(57, "style", "font-size: 9;");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "btn btn-danger");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                               () => deleteTask(task)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 49 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                          task.task_id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 50 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                          task.taskname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 51 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                          task.responsible

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 52 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                          task.deadline

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.OpenElement(80, "td");
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "select");
            __builder.AddAttribute(83, "class", "form-control");
            __builder.AddAttribute(84, "value", 
#nullable restore
#line 54 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                             task.status

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                                     (e) => updateTaskStatus(e, task)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 55 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                             foreach (var sts in statusList)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                                ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", 
#nullable restore
#line 57 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                sts

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, 
#nullable restore
#line 57 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                       sts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 58 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 62 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 64 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
        if (currentRadio == "byStatus") {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, " ");
            __builder.OpenElement(99, "p");
            __builder.AddContent(100, "Total of ");
            __builder.AddContent(101, 
#nullable restore
#line 64 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                       currentStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(102, " Tasks: ");
            __builder.AddContent(103, 
#nullable restore
#line 64 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                             tot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(104, " ");
#nullable restore
#line 64 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                                     }
        else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, " ");
            __builder.OpenElement(106, "p");
            __builder.AddContent(107, "Total of Tasks: ");
            __builder.AddContent(108, 
#nullable restore
#line 65 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                   tot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(109, " ");
#nullable restore
#line 65 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                           }
    }
    else
    {
        if (currentRadio == "byStatus") {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, " ");
            __builder.OpenElement(111, "h3");
            __builder.AddContent(112, "No ");
            __builder.AddContent(113, 
#nullable restore
#line 69 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                  currentStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(114, " Tasks");
            __builder.CloseElement();
            __builder.AddContent(115, " ");
#nullable restore
#line 69 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                           }
        else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, " ");
            __builder.AddMarkupContent(117, "<h3>No Tasks</h3> ");
#nullable restore
#line 70 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                 }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
     
} else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "    ");
            __builder.OpenElement(119, "table");
            __builder.AddAttribute(120, "class", "table table-dark");
            __builder.AddAttribute(121, "border", "1");
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.AddMarkupContent(123, @"<tr class=""form-group"">
            <td>Taskname</td>
            <td>Supervisor</td>
            <td>Email supervisor</td>
            <td>Responsible</td>
            <td>Email responsible</td>
            <td>Deadline</td>
            <td>Estimate hours</td>
            <td>Status</td>
        </tr>
        ");
            __builder.OpenElement(124, "tr");
            __builder.AddAttribute(125, "style", "font-size: 9;");
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "td");
            __builder.OpenElement(128, "input");
            __builder.AddAttribute(129, "class", "form-control");
            __builder.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 85 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                   newTask.taskname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.taskname = __value, newTask.taskname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n            ");
            __builder.OpenElement(133, "td");
            __builder.OpenElement(134, "input");
            __builder.AddAttribute(135, "class", "form-control");
            __builder.AddAttribute(136, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                   newTask.supervisor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.supervisor = __value, newTask.supervisor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n            ");
            __builder.OpenElement(139, "td");
            __builder.OpenElement(140, "input");
            __builder.AddAttribute(141, "class", "form-control");
            __builder.AddAttribute(142, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                   newTask.email_supervisor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.email_supervisor = __value, newTask.email_supervisor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n            ");
            __builder.OpenElement(145, "td");
            __builder.OpenElement(146, "input");
            __builder.AddAttribute(147, "class", "form-control");
            __builder.AddAttribute(148, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                   newTask.responsible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.responsible = __value, newTask.responsible));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n            ");
            __builder.OpenElement(151, "td");
            __builder.OpenElement(152, "input");
            __builder.AddAttribute(153, "class", "form-control");
            __builder.AddAttribute(154, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                   newTask.email_responsible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(155, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.email_responsible = __value, newTask.email_responsible));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n            ");
            __builder.OpenElement(157, "td");
            __builder.OpenElement(158, "input");
            __builder.AddAttribute(159, "class", "form-control");
            __builder.AddAttribute(160, "type", "datetime-local");
            __builder.AddAttribute(161, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 90 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                         newTask.deadline

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(162, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.deadline = __value, newTask.deadline, format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n            ");
            __builder.OpenElement(164, "td");
            __builder.OpenElement(165, "input");
            __builder.AddAttribute(166, "class", "form-control");
            __builder.AddAttribute(167, "type", "number");
            __builder.AddAttribute(168, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                 newTask.estimate_hours

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(169, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.estimate_hours = __value, newTask.estimate_hours, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n            ");
            __builder.OpenElement(171, "td");
            __builder.AddMarkupContent(172, "\r\n                ");
            __builder.OpenElement(173, "select");
            __builder.AddAttribute(174, "class", "form-control");
            __builder.AddAttribute(175, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                     newTask.status

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(176, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTask.status = __value, newTask.status));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(177, "\r\n");
#nullable restore
#line 94 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                     foreach (var sts in statusList)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(178, "                        ");
            __builder.OpenElement(179, "option");
            __builder.AddAttribute(180, "value", 
#nullable restore
#line 96 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                        sts

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(181, 
#nullable restore
#line 96 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                               sts

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n");
#nullable restore
#line 97 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(183, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(185, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n    ");
            __builder.OpenElement(188, "div");
            __builder.AddAttribute(189, "class", "d-flex justify-content-end");
            __builder.AddMarkupContent(190, "\r\n        ");
            __builder.OpenElement(191, "button");
            __builder.AddAttribute(192, "type", "button");
            __builder.AddAttribute(193, "class", "btn btn-primary");
            __builder.AddAttribute(194, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                () => addingRecord = false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(195, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n        ");
            __builder.OpenElement(197, "button");
            __builder.AddAttribute(198, "type", "button");
            __builder.AddAttribute(199, "class", "btn btn-success ml-2");
            __builder.AddAttribute(200, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
                                                                     addTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(201, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n");
#nullable restore
#line 106 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\Users\campo\Desktop\MII\EMI205 PRODUCCION DE SOFTWARE\M3 - NET\data01\Pages\Counter.razor"
       
    private MyPostgresDB DB = new MyPostgresDB();
    private List<DBTask> myTasks = new List<DBTask>();
    private List<String> statusList = new List<String>();
    private String currentStatus;
    private String currentRadio = "all";
    private Boolean addingRecord = false;
    private DBTask newTask = new DBTask();
    protected override void OnInitialized()
    {
        GetTaskStatuses();
        GetTasks();
    }
    private void GetTaskStatuses()
    {
        statusList.Clear();
        string sql = "SELECT unnest(enum_range(NULL::Task_Status));";
        NpgsqlDataReader data = DB.executeSQL(sql);
        while (data.Read())
        {
            for (int i = 0; i < data.FieldCount; i++)
            {
                statusList.Add(data.GetString(i));
            }
        }
        currentStatus = statusList[0];
        data.Close();
    }
    private void GetTasks()
    {
        myTasks.Clear();
        string sql = "SELECT task_id, taskname, responsible, deadline, status FROM task";
        if (currentRadio == "byStatus") sql += $" WHERE status='{currentStatus}'";
        sql += ";";
        NpgsqlDataReader data = DB.executeSQL(sql);
        DBTask task;
        while (data.Read())
        {
            task = new DBTask();
            task.set_from_reader(data);
            myTasks.Add(task);
        }
        data.Close();
    }
    private void onChangeRadio(ChangeEventArgs args)
    {
        currentRadio = args.Value.ToString();
        Console.WriteLine(currentRadio == "all" ? "Show all Tasks" : $"Show tasks from the type {currentStatus}");
        GetTasks();
    }

    private void onChangeStatus(ChangeEventArgs args)
    {
        currentStatus = args.Value.ToString();
        Console.WriteLine($"Other records, from the type {currentStatus} should be displayed");
        GetTasks();
    }
    private void addTask()
    {
        Console.WriteLine("New button was pressed");
        // Cambios el datestyle para que PostgreSQL acepte la query
        string sql = "SET datestyle TO dmy;";
        sql+= "INSERT INTO task (taskname, supervisor, email_supervisor, responsible, email_responsible, created_on, deadline, estimate_hours, status) VALUES ";
        sql += $"('{newTask.taskname}', '{newTask.supervisor}', '{newTask.email_supervisor}', '{newTask.responsible}', '{newTask.email_responsible}', '{DateTime.Now}', '{newTask.deadline}', {newTask.estimate_hours}, '{newTask.status}');";
        NpgsqlDataReader data = DB.executeSQL(sql);
        data.Close();
        newTask = new DBTask();
        // Volvemos a mostrar la tabla con los datos
        addingRecord = false;
        GetTasks();
    }
    private void deleteTask(DBTask task)
    {
        Console.WriteLine($"The task {task.task_id} should be removed");
        string sql = $"DELETE FROM task WHERE task_id = {task.task_id}";
        NpgsqlDataReader data = DB.executeSQL(sql);
        data.Close();
        GetTasks();
    }
    private void updateTaskStatus(ChangeEventArgs e, DBTask task)
    {
        Console.WriteLine($"The task {task.task_id} should change to {e.Value.ToString()}");
        string sql = $"UPDATE task SET status ='{e.Value.ToString()}' WHERE task_id = {task.task_id}";
        NpgsqlDataReader data = DB.executeSQL(sql);
        data.Close();
        GetTasks();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
