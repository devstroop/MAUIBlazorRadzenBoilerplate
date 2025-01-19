using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace IOTKit.Layout
{
    public partial class AppLayout
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public DialogService DialogService { get; set; } = default!;

        [Inject]
        public TooltipService TooltipService { get; set; } = default!;

        [Inject]
        public ContextMenuService ContextMenuService { get; set; } = default!;

        [Inject]
        public NotificationService NotificationService { get; set; } = default!;

        bool sidebarExpanded = true;

        void SidebarToggleClick()
        {
            sidebarExpanded = !sidebarExpanded;
        }
    }
}