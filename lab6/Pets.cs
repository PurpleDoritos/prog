
//using System.Media;

namespace Pets
{
    // declaration for Dog class
    public class Dog
    {

        // Two properties, Name and Breed
        public string Name { get; set; }
        public string Breed { get; set; }


        // This is the constructor
        public Dog(string name, string breed)
        {
            this.Breed = breed;
            this.Name = name;
        }
        private void HappyBark()
        {
           /*  string wavFilePath = "happy-puppy.wav";
            SoundPlayer player = new SoundPlayer(wavFilePath);
            player.PlaySync(); */
        }
        public void Fetch()
        {
            HappyBark();

        }
        // String representation is returned by this method
        public override String ToString()
        {
            return $"{this.Name} the dog";
        }


    }
}