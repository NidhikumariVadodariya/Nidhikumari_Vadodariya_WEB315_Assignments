// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\Assignment03\NidhiVadodariyaChat\Client\Pages\Index.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    private bool SendMessage;

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

        Task SendMessage(string user, string message, bool Clients)
        {
        return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        await hubConnection.StartAsync();
    }

    async Task Send() =>
        await hubConnection.SendAsync("SendMessage", userInput, messageInput);

    async Task SendToMyself() =>
    await hubConnection.SendAsync("SendMessageToCaller", userInput, messageInput);

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