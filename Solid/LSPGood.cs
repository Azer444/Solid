using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPGood
{
    public interface ItakePhoto
    {
        void TakePhoto();
    }
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapildi");
        }

        
    }

    public class IPhone : BasePhone, ItakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Fotograf Cekildi");
        }
    }

    public class Nokia3310 : BasePhone
    {
        
    }
}
