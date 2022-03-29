public class FoodItem
{
    public string foodItemName  { get; set; }
    public double foodItemPrice  { get; set; }   
    public int Quantity { get; set; }
    public string foodItemWeight { get; set; }

    public void IncreaseQuaniity()
    {
        if(Quantity<20)
            Quantity++;
    }

    public void DescreaseQuaniity()
    {
        if(Quantity>0)
            Quantity--;
    }



}