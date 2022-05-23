//övning 3.2 Arv och 3.3 Polymorfism.
//Svar på fråga: 3.2    13. Bird.
//Svar på Fråga 3.2.   14. Animal.
abstract class Animal
{
    private string name;
    private int weight;
    private int age;

    public Animal(string name, int weight, int age)
    {
        this.name = name;
        this.weight = weight;
        this.age = age;
    }

    public abstract string Stats();
    public abstract string DoSound()
    {
        return Console.WriteLine("Sound of Animal: ");
    }



    class Horse : Animal
    {
        public string MakeSound()
        {
            string sound = DoSound();
            return sound;
            Console.WriteLine($"{sound} Neigh");
        }
        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;
       }


    }
    class Dog : Animal
    {
        string feature = "Bark";

        public string MakeSound()
        {
            string sound = DoSound();
            return sound;
            Console.WriteLine($"{sound} Bark");
        }

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }



    }
    class Hedgehog : Animal
    {
        string feature = "Spikes";

        public string MakeSound()
        {
            string sound = DoSound();
            return sound;
            Console.WriteLine($"{sound} Chirp");
        }

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }



    }
    class Worm : Animal
    {
        string feature = "Tiny";


        public string MakeSound()
        {
            string sound = DoSound();
            return sound;
            Console.WriteLine($"{sound} Bam");
        }

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }
    }

    class Bird : Animal
    {
        string feature = "Wings";

        public string MakeSound()
        {
            string sound = DoSound();
            return sound;
            Console.WriteLine($"{sound} Tweet");
        }

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }
    }

    class Wolf : Animal
    {
        string feature = "Fighter";


        public string MakeSound()
        {
            string sound = DoSound();
            return sound;
            Console.WriteLine($"{sound} Howl");
        }

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }
    }

    class Pelican : Bird
    {
        string feature = "thin";

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }
    }

    class Flamingo : Bird
    {
        string feature = "long";

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }
    }

    class Swan : Bird
    {
        string feature = "white";

        public override string Stats(string name, int weight, int age)
        {
            return name + weight + age;

        }
    }

}

class Wolf
{



    interface Person
    {
        void talk();
    }

    class Wolfman : Wolf
    {
        public void talk()
        {
            Console.WriteLine("Hej");
        }
    }

    
    // En lista Animals

   
    


    List<Animal> animals = new List<Animal>();
    aninmals.Add("Lion");
    animals.Add("Tiger");
    animals.Add("Cheetah");

        foreach(Animal anim in animals)
        Console.Writeline(anim);




       










