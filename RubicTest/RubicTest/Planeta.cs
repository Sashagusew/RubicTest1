using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicTest
{
    class Planeta

    {
        private void Main()
        {
            CreatetCat();
            CreatetCat();
            CreatetCat();
            CreatetPeople();
            CreatetPeople();
            CreatetPeople();
            CreatetPeople();
        }

        private void CreatetCat()
        {
           Cat cat1 = new Cat();
            cat1.name = "Wasya";
            cat1.age = 1;
            cat1.height = 13.5F;
            cat1.isBoy = true;
        }
        private void CreatetPeople()
        {
            People people1 = new People();
            people1.name = "SwyatoyMichail";
            people1.age = 98;
            people1.salory = 6.66F;
            people1.isBoy = true;
        }

    }
}
