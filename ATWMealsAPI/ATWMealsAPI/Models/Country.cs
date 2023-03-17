namespace ATWMealsAPI.Models
{
  public class Country
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual List<Meal>? Meals { get; set; }
  }
}
