using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    internal class LSP
    {
    }

    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("call");
        }

        //public abstract void TakePhoto();
    }

    public class Nokia3310 : BasePhone
    {
        //public override void TakePhoto()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class Iphone : BasePhone, ITakePhoto
    {
        //public override void TakePhoto()
        //{
        //    Console.WriteLine("Take Photo");
        //}
        public void TakePhoto()
        {
            Console.WriteLine("Iphone => Take Photo");
        }
    }

    public class Xphone : BasePhone, ITakePhoto
    {
        //public override void TakePhoto()
        //{
        //    Console.WriteLine("Take Photo");
        //}
        public void TakePhoto()
        {
            Console.WriteLine("XPhone => Take Photo");
        }
    }
}
