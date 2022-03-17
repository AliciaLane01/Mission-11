// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BookStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using BookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\alici\source\repos\BookStore\BookStore\Pages\Admin\Orders.razor"
       
    public IPurchaseRepository repo => Service;

    public IEnumerable<Purchase> AllOrders { get; set; }
    public IEnumerable<Purchase> ShippedOrders { get; set; }
    public IEnumerable<Purchase> UnfulfilledOrders { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Purchases.ToListAsync();
        ShippedOrders = AllOrders.Where(x => x.OrderShipped);
        UnfulfilledOrders = AllOrders.Where(x => !x.OrderShipped);
    }

    public void ShipOrder(int id) => UpdateOrder(id, true);
    public void ResetOrder(int id) => UpdateOrder(id, false);

    private void UpdateOrder(int id, bool shipped)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseId == id);
        p.OrderShipped = shipped;
        repo.SavePurchase(p);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
