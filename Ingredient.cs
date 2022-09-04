public class Ingredient
{
    public string? Name { get; set; }
    public uint Quantity { get; set; } = 0;
    public string? Units { get; set; }

    public Ingredient() { }

    public bool IsValid()
    {
        bool isValid = false;

        if ((false == string.IsNullOrWhiteSpace(Name)) &&
            (0 < Quantity))
        {
            isValid = true;
        }

        return isValid;
    }

    public string GetDescription()
    {
        string description;
        
        if (true == string.IsNullOrWhiteSpace(Units))
        {
            description = Quantity.ToString() + "x " + Name;
        }
        else 
        {
            description = Quantity.ToString() + " " + Units + " of " + Name;
        }

        return description;
    }

    public void Copy(Ingredient other)
    {
        this.Name     = other.Name;
        this.Quantity = other.Quantity;
        this.Units    = other.Units;
    }

    public Ingredient Clone()
    {
        Ingredient clone = new();

        clone.Copy(this);

        return clone;
    }
}