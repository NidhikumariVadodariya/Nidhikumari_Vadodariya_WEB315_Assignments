#pragma checksum "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbac994ae8c379d4af6282d12c405b6d05153758"
// <auto-generated/>
#pragma warning disable 1591
namespace NidhiVadodariyaChat.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using NidhiVadodariyaChat.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\_Imports.razor"
using NidhiVadodariyaChat.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddAttribute(2, "b-k18cwhlr3c");
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "class", "name");
            __builder.AddAttribute(5, "b-k18cwhlr3c");
            __builder.AddMarkupContent(6, "\r\n        Name:\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
                      userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(10, "b-k18cwhlr3c");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "messagesList");
            __builder.AddAttribute(14, "b-k18cwhlr3c");
#nullable restore
#line 13 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
     foreach (var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "b-k18cwhlr3c");
            __builder.AddContent(17, 
#nullable restore
#line 15 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n    ");
            __builder.OpenElement(19, "label");
            __builder.AddAttribute(20, "class", "msg");
            __builder.AddAttribute(21, "b-k18cwhlr3c");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "size", "60");
            __builder.AddAttribute(24, "placeholder", "Type a mesage..");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(27, "b-k18cwhlr3c");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
                          Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "sendme");
            __builder.AddAttribute(32, "disabled", 
#nullable restore
#line 63 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
                                                           !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "b-k18cwhlr3c");
            __builder.AddContent(34, "Send Me");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
                          SendMessageToOthers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "sendothers");
            __builder.AddAttribute(39, "disabled", 
#nullable restore
#line 64 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
                                                                              !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "b-k18cwhlr3c");
            __builder.AddContent(41, "Send To Others");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();
            
       hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
       {
           var encodedMsg = $"{user}: {message}";
           messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync(); 
    }

    async Task SendMessageToOthers() =>
        await hubConnection.SendAsync("Send", userInput, messageInput);

    async Task Send() =>
    await hubConnection.SendAsync("SendMessageToOthers", userInput, messageInput);

    

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
