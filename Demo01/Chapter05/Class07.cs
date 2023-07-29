using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Class07
    {
        //返回引用
        public static ref byte FindFirstEyePixel(Byte[] image)
        {
            for (int count = 0; count < image.Length; count++)
            {
                if (image[count] == (byte)ConsoleColor.Red)
                {
                    return ref image[count];
                } 
            }
            throw new InvalidOperationException("No pixals are red.");
        }
        static void Main(string[] args)
        {
            byte[] image=new byte[254];
            int index=new Random().Next(0,image.Length-1);
            image[index]=(byte)ConsoleColor.Red;
            Console.WriteLine($"image[{index}]={(ConsoleColor)image[index]}");

            ref byte redPixel = ref FindFirstEyePixel(image);
            redPixel=(byte)ConsoleColor.Black;
            Console.WriteLine($"image[{index}]={(ConsoleColor)image[redPixel]}");
            Console.ReadLine();
        }
    }
}
