#pragma checksum "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd7349484b33f5d4e7f509ada578940ad6c09460"
// <auto-generated/>
#pragma warning disable 1591
namespace NidhikumariVadodariyaGroceryApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using NidhikumariVadodariyaGroceryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\_Imports.razor"
using NidhikumariVadodariyaGroceryApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GroceryStore")]
    public partial class GroceryStore : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
 if (groceryIsle.Count != 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Isle List</h1>");
#nullable restore
#line 6 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "ul");
#nullable restore
#line 11 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
     if (groceryIsle.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                                                  AddProducts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Add Products");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "<br><br>");
#nullable restore
#line 14 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
     foreach (var GroceryIsle in groceryIsle)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-default");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                                                      () =>tmpItems=GetItems(GroceryIsle.isleNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, 
#nullable restore
#line 17 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                                                                                                       GroceryIsle.isleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<br><br>\r\n    ");
            __builder.OpenElement(13, "h3");
            __builder.AddContent(14, 
#nullable restore
#line 22 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
         currentIsle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n\r\n    <br><br>");
#nullable restore
#line 27 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
     if (groceryIsle.Count != 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table");
            __builder.AddMarkupContent(18, "<tr><th width=\"150\">Food Item</th>\r\n                <th width=\"150\">Price</th>\r\n                <th width=\"150\">Weight</th>\r\n                <th width=\"150\">Quantity</th></tr>");
#nullable restore
#line 37 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
             foreach (var GroceryItem in tmpItems)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 40 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                         GroceryItem.foodItemName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 41 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                         GroceryItem.foodItemPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 42 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                         GroceryItem.foodItemWeight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-default");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                                                                  () => GroceryItem.DescreaseQuaniity()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "-");
            __builder.CloseElement();
            __builder.AddContent(34, "  ");
            __builder.AddContent(35, 
#nullable restore
#line 43 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                                                                                                                      GroceryItem.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-default");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                              () => GroceryItem.IncreaseQuaniity()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "+");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
       


    private List<GroceryIsle> groceryIsle = new List<GroceryIsle>();
    private List<FoodItem> tmpItems = new List<FoodItem>();
    private string currentIsle = "";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                             
    private void AddProducts()
    {
        Console.Write("worked");
        GroceryIsle isl1 = new GroceryIsle();
        isl1.isleName = "Vegetables";
        isl1.isleNumber = 1;
        isl1.FoodItemsList.Add(new FoodItem
        {
            Quantity = 1,
            foodItemName = "Tomato",
            foodItemWeight = "1/2 lb",
            foodItemPrice =
        1.45
        });
        isl1.FoodItemsList.Add(new FoodItem
        {
            Quantity = 1,
            foodItemName = "Onion",
            foodItemWeight = "1/2 lb",
            foodItemPrice =
        1.78
        });
        isl1.FoodItemsList.Add(new FoodItem
        {
            Quantity = 1,
            foodItemName = "Carrot",
            foodItemWeight = "1/2 lb",
            foodItemPrice =
        2.00
        });

        GroceryIsle isl2 = new GroceryIsle();
        isl2.isleName = "Produce";
        isl2.isleNumber = 2;
        isl2.FoodItemsList.Add(new FoodItem
        {
            Quantity = 15,
            foodItemName = "Apples",
            foodItemWeight = "1.5",
            foodItemPrice =
        2.99
        });
        isl2.FoodItemsList.Add(new FoodItem
        {
            Quantity = 20,
            foodItemName = "Oranges",
            foodItemWeight = "1.5",
            foodItemPrice =
        5.99
        });
        isl2.FoodItemsList.Add(new FoodItem
        {
            Quantity = 10,
            foodItemName = "Lemons",
            foodItemWeight = "1.5",
            foodItemPrice =
        1.99
        });


        GroceryIsle isl3 = new GroceryIsle();
        isl3.isleName = "Dairy";
        isl3.isleNumber = 3;
        isl3.FoodItemsList.Add(new FoodItem
        {
            Quantity = 10,
            foodItemName = "Milk",
            foodItemWeight = "1.5",
            foodItemPrice = 5.99
        });
        isl3.FoodItemsList.Add(new FoodItem
        {
            Quantity = 20,
            foodItemName = "Yogurt",
            foodItemWeight = "1.5",
            foodItemPrice =
        2.79
        });
        isl3.FoodItemsList.Add(new FoodItem
        {
            Quantity = 5,
            foodItemName = "Butter",
            foodItemWeight = "1.5",
            foodItemPrice =
        5.00
        });

        groceryIsle.Add(isl1);
        groceryIsle.Add(isl2);
        groceryIsle.Add(isl3);
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                          
    private List<FoodItem> GetItems(int isleNumber)
    {
        foreach (var GroceryIsle in groceryIsle)
        {
            if (GroceryIsle.isleNumber == isleNumber)
            {
                currentIsle = GroceryIsle.isleName;
                return GroceryIsle.FoodItemsList;
            }
        }
        return new List<FoodItem>();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
