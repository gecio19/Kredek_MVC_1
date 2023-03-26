namespace PracaDomowa_1.Models
{
    public class Movie
    {
        public Movie(int id , string name, string des, double rating, string img)
        {
            Id = id;
            Name = name;
            Description = des;
            Rating = rating;
            Image = img;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Rating { get; set; }

        public string Image { get; set; }


    }
}
