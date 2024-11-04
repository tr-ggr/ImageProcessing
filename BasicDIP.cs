using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    static class BasicDIP
    {
        private static void Scale(ref Bitmap source, ref Bitmap destination, int nwidth, int nheight)
        {
            int targetWidth = nwidth;
            int targetHeight = nheight;
            int  xSource, ySource;
            int width = source.Width;
            int height = source.Height;

            destination = new Bitmap(targetWidth, targetHeight);

            for (int x = 0; x < targetWidth; x++)
            {
                for (int y = 0; y < targetHeight; y++)
                {
                   xSource = x * width / targetWidth;
                   ySource = y * height / targetHeight;
                   destination.SetPixel(x, y, source.GetPixel(xSource, ySource));
                }
            }
        }
        public static void Subtract(ref Bitmap bg, ref Bitmap fg, ref Bitmap destination)
        {
            // definite color green
            Color green = Color.FromArgb(0, 255, 0);
            int green_pixel = green.G;
            int threshold = 50;

            Bitmap scaledForeground = new Bitmap(bg.Width, bg.Height);

            Scale(ref fg, ref scaledForeground, bg.Width, bg.Height);

            Bitmap result = new Bitmap(scaledForeground.Width, scaledForeground.Height);

            for (int x = 0; x < scaledForeground.Width; x++)
            {
                for (int y = 0; y < scaledForeground.Height; y++)
                {
                    Color fgPixel = scaledForeground.GetPixel(x, y);
                    Color bgPixel = bg.GetPixel(x, y);

                    //Console.WriteLine(fgPixel.R + " " + fgPixel.G + " " + fgPixel.B);

                    int green_fgpixel = fgPixel.G;

                    
                    int subtractValue = Math.Abs(green_pixel - green_fgpixel);

                    //Console.WriteLine(green_fgpixel + "-" + green_pixel + "=" + subtractValue);

                    if (subtractValue <= threshold)
                    {
                        result.SetPixel(x, y, bgPixel);
                    }
                    else
                    {
                        result.SetPixel(x, y, fgPixel);
                    }
                }
            }

            destination = result;
        }
        public static void Inversion(ref Bitmap source, ref Bitmap destination)
        {
            Color sample;
            Color inverted;

            Bitmap invertedImage = new Bitmap(source.Width, source.Height);

            // Convert to Inverted

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    sample = source.GetPixel(x, y);
                    inverted = Color.FromArgb(Math.Max(255 - sample.R, 0), Math.Max(255 - sample.G, 0), Math.Max(255 - sample.B, 0));
                    invertedImage.SetPixel(x, y, inverted);
                }
            }

            destination = invertedImage;

        }

        public static void Sepia(ref Bitmap source, ref Bitmap destination)
        {
            Color sample;
            Color sepiaColor;

            Bitmap sepiaImage = new Bitmap(source.Width, source.Height);

            // Convert to Inverted

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    sample = source.GetPixel(x, y);

                    int outputRed = (int)((sample.R * .393) + (sample.G * .769) + (sample.B * .189));
                    int outputGreen = (int)((sample.R * .349) + (sample.G * .686) + (sample.B * .168));
                    int outputBlue = (int)((sample.R * .272) + (sample.G * .534) + (sample.B * .131));

                    sepiaColor = Color.FromArgb(Math.Min(outputRed, 255), Math.Min(outputGreen, 255) , Math.Min(outputBlue, 255));
                    sepiaImage.SetPixel(x, y, sepiaColor);
                }
            }

            destination = sepiaImage;

        }

        public static void Copy(ref Bitmap source, ref Bitmap destination)
        {
            destination = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    destination.SetPixel(i, j, source.GetPixel(i, j));
                }
            }
        }

        public static void Histogram(ref Bitmap source, ref Bitmap destination)
        {
            Color sample;
            Color grey;
            Byte graydata;

            // Convert to grayscale

            for(int x = 0; x < source.Width; x++)
            {
                for(int y = 0; y < source.Height; y++)
                {
                    sample = source.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.B + sample.G) / 3);
                    grey = Color.FromArgb(graydata, graydata, graydata);
                    source.SetPixel(x, y, grey);
                }
            }

            int[] histogramData = new int[256];

            // Put data into array

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    sample = source.GetPixel(x, y);
                    histogramData[sample.R]++;
                }
            }

            // Convert array into picture
            Bitmap histogramPicture = new Bitmap(256, 800);

            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histogramData[x] / 5, histogramPicture.Height - 1); y++)
                {
                    histogramPicture.SetPixel(x, (histogramPicture.Height - 1) - y, Color.Black);
                }
            }

            destination = histogramPicture;

        }

        public static void Greyscale(ref Bitmap source, ref Bitmap destination)
        {
            Color sample;
            Color grey;
            Byte graydata;

            Bitmap greyscale = new Bitmap(source.Width, source.Height);

            // Convert to grayscale

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    sample = source.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.B + sample.G) / 3);
                    grey = Color.FromArgb(graydata, graydata, graydata);
                    greyscale.SetPixel(x, y, grey);
                }
            }

            destination = greyscale;

        }
    }
}
