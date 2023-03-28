using System;

namespace CollezioniEGenerici.Esempi
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal
    {
        public void Speak() => Console.WriteLine("Woof!");
    }

    public class Cat : IAnimal
    {
        public void Speak() => Console.WriteLine("Meow!");
    }

  
    public class ControVarianza 
    {
        public delegate void AnimalHandler(IAnimal animal);
        public void HandleDog(IAnimal animal) => Console.WriteLine("Handling a dog!");
        public void HandleCat(IAnimal animal) => Console.WriteLine("Handling a cat!");

        public void Esegui() 
        {
            AnimalHandler handler = HandleDog;
            handler += HandleCat;

            handler(new Dog()); // stampa "Handling a dog!"
            handler(new Cat()); // stampa "Handling a cat!"
        }

    }

}
