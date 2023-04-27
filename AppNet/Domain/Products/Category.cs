
using Flunt.Validations;

namespace AppNet.Domain.Products;

public class Category : Entity{   
    
    public string Name { get; set; }
    public bool Active { get; set; }

    // Através do construtor, podemos  analisar se a informação é válida ou não.
    public Category(string name) 
    {
        var contract = new Contract<Category>()
            .IsNotNull(name, "Name");
        AddNotification(contract);

        Name = name;
        Active = true;
    }
    
}
