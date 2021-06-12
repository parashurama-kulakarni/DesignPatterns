using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.CommandPattern
{
    public class VideoEditor
    {
        private float contrast = 0.5f;
        private String text;

        public void setText(String text)
        {
            this.text = text;
        }

        public void removeText()
        {
            this.text = "";
        }

        public float getContrast()
        {
            return contrast;
        }

        public void setContrast(float contrast)
        {
            this.contrast = contrast;
        }

        public override string ToString()
        {
            return "VideoEditor{" +
                    "contrast=" + contrast +
                    ", text='" + text + '\'' +
                    '}';
        }
    }
}
