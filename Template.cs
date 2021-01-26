using System;
using System.Collections.Generic;
using System.Text;

namespace Hw288
{
    abstract class CarMaking
    {
        public void Make()
        {
            getBox();
            addWheels();
            addMotor();
            addBody();
        }
       
        public abstract void getBox();
        public abstract void addWheels();
        public abstract void addMotor();
        public abstract void addBody();
    }

    class HeavyCar3 : CarMaking
    {
        

        public override void getBox()
        {
            Console.WriteLine("Встовляем коробку передач.");
        }

        public override void addWheels()
        {
            Console.WriteLine("Закручиваем колесо.");
        }

        public override void addMotor()
        {
            Console.WriteLine("Вставляем мотор.");
        }

        public override void addBody()
        {
            Console.WriteLine("Стваи корбус поверз всего.");
        }
        
    }
    
    }
    class Template
    {

    }
}
