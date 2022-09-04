public class RecipesContainer
{
    public List<Recipe> recipes = new();

    public Recipe? SelectedRecipe { get; set; }
    private string? savedString;

    public string Property
    {
        get => savedString ?? string.Empty;
        set
        {
            savedString = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}