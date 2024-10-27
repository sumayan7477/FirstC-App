namespace MyNETWebApp.Models
{
    public class Author
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Nationality { get; set; } 

    }


}



// namespace MyNETWebApp.Models
// {
//     public class Author(string name, string email, string nationality)
//     {
//         public string? Name { get; set; } = name;
//         public string? Email { get; set; } = email;
//         public string? Nationality { get; set; } = nationality;

//         public string GetDetails (){
//              return $"Author: {Name}\nEmail: {Email}\nNationality: {Nationality}";
//         }
//     }


// }