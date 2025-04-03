using Newtonsoft.Json;

namespace Shop{
    class Product{
        string Name {get; set;}
        int Price {get; set;}
        string Tags {get; set;}
    }


    class Program{
        public static void Main(string [] args){
            string json = "{\"Name\": \"Laptop\", \"Price\": 2000, \"Tags\": [\"Electronics\", \"Computers\"]}";
            
            Product products = JsonConvert.DeserializeObject<Product>(json);
        }
    }
}