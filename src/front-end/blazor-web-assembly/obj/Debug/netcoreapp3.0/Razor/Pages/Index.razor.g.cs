#pragma checksum "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5801314bc896444eef5ca634b5b5338aa21f354f"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_web_assembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using blazor_web_assembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\_Imports.razor"
using blazor_web_assembly.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Todo (");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
           todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 5 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
 if (todos.Count() == 0){

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.AddMarkupContent(6, "<p>Add a todo list item below to get started</p>\r\n");
#nullable restore
#line 7 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
}
else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "striped");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<thead>\r\n          <tr>\r\n              <th>Item</th>\r\n              <th>Complete</th>\r\n          </tr>\r\n        </thead>\r\n\r\n        ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 18 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
             foreach (var todo in todos){

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
                         todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "p");
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "label");
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "checkbox");
            __builder.AddAttribute(28, "class", "filled-in");
            __builder.AddAttribute(29, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
                                                                                todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                <span></span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 30 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 33 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "input-field col s6");
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "id", "newTodo");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "class", "validate");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
                                                            newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.AddMarkupContent(50, "<label for=\"newTodo\">New To Do</label>\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "class", "waves-effect waves-light btn");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
                                                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(55, "Add");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\jeast\Documents\Development\#Github\playing-with-blazor\playing-with-blazor\src\front-end\blazor-web-assembly\Pages\Index.razor"
       
    private string newTodo;
    private IList<TodoItem> todos = new List<TodoItem>();

    private void AddTodo(){
        if (string.IsNullOrEmpty(this.newTodo) == false){
            todos.Add(new TodoItem{Title = newTodo});
            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
