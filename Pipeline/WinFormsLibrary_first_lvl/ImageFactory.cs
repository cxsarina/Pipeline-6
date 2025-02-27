﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ImageFactory
    {
        private string imgFolder = "D:\\Навчання_2_курс\\6-lab KPZ\\Pipeline\\img\\img for animation";

        private string[] imageFileNames = {
        "zognuta_truba_1.png", "zognuta_truba_2.png", "zognuta_truba_3.png", "zognuta_truba_4.png",
        "troina_truba_1.png", "troina_truba_2.png", "troina_truba_3.png", "troina_truba_4.png",
        "prama_truba_1.png", "prama_truba_2.png",
        "chetwerna_truba.png",
        "start-finish_truba.png"
    };

        public Image GetImage(int index)
        {
            if (index >= 0 && index < imageFileNames.Length)
            {
                string imagePath = Path.Combine(imgFolder, imageFileNames[index]);
                return Image.FromFile(imagePath);
            }
            else
            {
                Console.WriteLine($"Invalid index for image: {index}");
                return null;
            }
        }
    }
}
