using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;

namespace TiledImage
{
    public class MainViewModel : ViewModelBase
    {
        private double imageWidth;
        private double imageHeight;
        private double repeatX;
        private double rectangleHeight;
        private double rectangleWidth;
        //private double viewportHeight;

        public MainViewModel()
        {
            ImageWidth = 259;
            ImageHeight = 194;
            RepeatX = 1.0;
            RectangleHeight = ImageHeight;
            RectangleWidth = imageWidth;
            //ViewportHeight = 1.0;

            OkCommand = new RelayCommand(OnOk);
        }

        private void OnOk()
        {
            // calc the ratio
            double ratio = ImageWidth / ImageHeight;

            RectangleHeight = RepeatX * ImageHeight;
            RectangleWidth = ImageWidth / ratio;
            RaisePropertyChanged("RepeatX");
            //ViewportHeight = 1 / RepeateX;
        }

        public double ImageWidth
        {
            get => imageWidth;
            set
            {
                Set(ref imageWidth, value);
            }
        }
        public double ImageHeight
        {
            get => imageHeight;
            set
            {
                Set(ref imageHeight, value);
            }
        }
        public double RepeatX
        {
            get => repeatX;
            set
            {
                Set(ref repeatX, value);
            }
        }
        public double RectangleHeight
        {
            get => rectangleHeight;
            set
            {
                Set(ref rectangleHeight, value);
            }
        }
        public double RectangleWidth
        {
            get => rectangleWidth;
            set
            {
                Set(ref rectangleWidth, value);
            }
        }
        //public double ViewportHeight 
        //{ 
        //    get => viewportHeight;
        //    set
        //    {
        //        Set(ref viewportHeight, value);
        //    }
        //}
        public RelayCommand OkCommand { get; set; }
    }
}
