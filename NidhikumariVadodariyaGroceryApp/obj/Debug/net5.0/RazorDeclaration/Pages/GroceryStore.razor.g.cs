// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
       
    private List<GroceryIsle> groceryIsle = new List<GroceryIsle>();
    private List<FoodItem> tmpItems = new List<FoodItem>();
    private string currentIsle = "";
    private string productName="";
    private string productPrice="";
    private string productQuantity="";
    private string productWeight="";
    private string productIsle="-1";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                             
    private void AddProducts()
    {
        Console.Write("worked");
        GroceryIsle isl1 = new GroceryIsle();
        isl1.isleName = "Vegetables";
        isl1.isleNumber = 1;
        isl1.FoodItemsList.Add(new FoodItem {
            Quantity = 1,
            foodItemName = "Tomato",
            foodItemWeight = "1/2 lb",
            foodItemPrice = 1.45 });
    
        isl1.FoodItemsList.Add(new FoodItem {
            Quantity = 1,
            foodItemName = "Onion",
            foodItemWeight = "1/2 lb",
            foodItemPrice = 1.78 });

        isl1.FoodItemsList.Add(new FoodItem {
            Quantity = 1,
            foodItemName = "Carrot",
            foodItemWeight = "1/2 lb",
            foodItemPrice = 2.00 });

        GroceryIsle isl2 = new GroceryIsle();
        isl2.isleName = "Produce";
        isl2.isleNumber = 2;
        isl2.FoodItemsList.Add(new FoodItem {
            Quantity = 15,
            foodItemName = "Apples",
            foodItemWeight = "1.5",
            foodItemPrice = 2.99 });

        isl2.FoodItemsList.Add(new FoodItem {
            Quantity = 20,
            foodItemName = "Oranges",
            foodItemWeight = "1.5",
            foodItemPrice = 5.99 });

        isl2.FoodItemsList.Add(new FoodItem {
            Quantity = 10,
            foodItemName = "Lemons",
            foodItemWeight = "1.5",
            foodItemPrice = 1.99 });

        GroceryIsle isl3 = new GroceryIsle();
        isl3.isleName = "Dairy";
        isl3.isleNumber = 3;
        isl3.FoodItemsList.Add(new FoodItem {
            Quantity = 10,
            foodItemName = "Milk",
            foodItemWeight = "1.5",
            foodItemPrice = 5.99 });

        isl3.FoodItemsList.Add(new FoodItem {
            Quantity = 20,
            foodItemName = "Yogurt",
            foodItemWeight = "1.5",
            foodItemPrice = 2.79 });

        isl3.FoodItemsList.Add(new FoodItem {
            Quantity = 5,
            foodItemName = "Butter",
            foodItemWeight = "1.5",
            foodItemPrice = 5.00 });

        groceryIsle.Add(isl1);
        groceryIsle.Add(isl2);
        groceryIsle.Add(isl3);
    }
    private void AddNewProduct()
    {
        if(productIsle!="-1")
        {
            FoodItem newItem = new FoodItem();
            //Validation
            if(productName!="" && productPrice!="" && productQuantity!="" && productWeight!="" && Convert.ToInt32(productQuantity) > 0 && Convert.ToInt32(productQuantity) <= 20)
            {
                newItem.foodItemName = productName;
                newItem.foodItemPrice = Convert.ToDouble(productPrice);
                newItem.foodItemWeight = productWeight;
                newItem.Quantity = Convert.ToInt32(productQuantity);
                
                foreach(var item in groceryIsle)
                {
                    if(item.isleNumber==Convert.ToInt32(productIsle))
                    {
                        item.FoodItemsList.Add(newItem);
                    }
                }
                
                //reset variables
                productName = "";
                productPrice = "";
                productQuantity = "";
                productWeight = "";
                productIsle = "-1";
            }
        }
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "C:\Users\nidhi\OneDrive\Documents\GitHub\Nidhikumari_Vadodariya_WEB315_Assignments\NidhikumariVadodariyaGroceryApp\Pages\GroceryStore.razor"
                          
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
