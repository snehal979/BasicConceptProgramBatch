using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptProgram
{
    internal class Alphabet
    {
        public void CheckVowelOrConsonat()
        {
            //Uc9 Alphabet check is vowel or Consonat(a,e,i,o,u)
            Console.WriteLine("Enter the alphabet");
            char alphabet = Convert.ToChar(Console.ReadLine());
            if(alphabet == 'A'||alphabet == 'E' || alphabet =='I'|| alphabet == 'O'||alphabet=='U'||alphabet == 'a'||alphabet == 'e' || alphabet =='i'|| alphabet == 'o'||alphabet=='u')
                Console.WriteLine("The alphabet is vowel"+alphabet);
            else
                Console.WriteLine("The aplhabet is Consonat"+alphabet);
        }
    }
}
