using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace ImageMagnifier
{
    public class MagnifierImage
    {
        private int multiple = 2;

        public int Multiple
        {
            get { return multiple; }
            //set { multiple = value; }
        }
        public MagnifierImage()
        { 
        
        }
        public MagnifierImage(int multiple)
        {
            this.multiple = multiple;
        }
        public Bitmap Magnifier(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("未发现文件存在.");
            }
            Bitmap map=(Bitmap)Bitmap.FromFile(filePath);
            return Magnifier(map, this.multiple);
        }
        public Bitmap Magnifier(string filePath,int multiple)
        {
            this.multiple = multiple;
            return Magnifier(filePath);
        }

        public Bitmap Magnifier(Bitmap srcbitmap, int multiple)
        {
            if (multiple <= 0) { multiple = 0; return srcbitmap; }
            Bitmap bitmap = new Bitmap(srcbitmap.Size.Width * multiple, srcbitmap.Size.Height * multiple);
            System.Drawing.Imaging.BitmapData srcbitmapdata = srcbitmap.LockBits(new Rectangle(new Point(0, 0), srcbitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            System.Drawing.Imaging.BitmapData bitmapdata = bitmap.LockBits(new Rectangle(new Point(0, 0), bitmap.Size), System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            unsafe
            {
                byte* srcbyte = (byte*)(srcbitmapdata.Scan0.ToPointer());
                byte* sourcebyte = (byte*)(bitmapdata.Scan0.ToPointer());
                for (int y = 0; y < bitmapdata.Height; y++)
                {
                    for (int x = 0; x < bitmapdata.Width; x++)
                    {
                        long index = (x / multiple) * 4 + (y / multiple) * srcbitmapdata.Stride;
                        sourcebyte[0] = srcbyte[index];
                        sourcebyte[1] = srcbyte[index + 1];
                        sourcebyte[2] = srcbyte[index + 2];
                        sourcebyte[3] = srcbyte[index + 3];
                        sourcebyte += 4;
                    }
                }
            }
            srcbitmap.UnlockBits(srcbitmapdata);
            bitmap.UnlockBits(bitmapdata);
            return bitmap;
        }


    }
}
