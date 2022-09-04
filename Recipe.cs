public class Recipe
{
    public uint UID { get; set; } = 0;

    public string Title { get; set; } = "";

    public List<Ingredient> Ingredients { get; set; } = new(); 

    public string? Instructions { get; set; }

    public bool IsValid()
    {
        bool isValid = false;

        if ((false == string.IsNullOrWhiteSpace(Title)) &&
            (0 < Ingredients.Count()))
        {
            isValid = true;
        }

        return isValid;
    }

    public void Copy(Recipe other)
    {
        this.UID   = other.UID;
        this.Title = other.Title;
        this.Ingredients.Clear();

        foreach (var ingredient in other.Ingredients)
        {
            this.Ingredients.Add(ingredient.Clone());
        }
    }
}