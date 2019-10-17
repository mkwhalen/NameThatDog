using System;
using System.Collections.Generic;
using System.Text;

namespace NameThatDog.Shared
{
    public class DogName
    {
        public string GetDogName()
        {
            var dogNames = new List<string> { "Bentley", "Ryder", "Belle", "Tootsie", "Biscuit", "Jazzy"};
            var random = new Random();
            int index = random.Next(dogNames.Count);

            return dogNames[index];
        }
    }
}
