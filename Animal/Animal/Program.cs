using Animal;

class Program
{
    static void Main(string[] args)
    {
        Base_Class myDog = new Class_Dog();
        Base_Class myCat = new Class_Cat();


        myDog.MakeSound();
        myCat.MakeSound();
    }
}