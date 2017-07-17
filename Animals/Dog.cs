namespace Animals
{
    public class Dog: Animal
    {
        public string FavoriteToy { get;}
        public Dog(string name, string toy): base(name)
        {   
            this.FavoriteToy = toy;
        }
    }
}