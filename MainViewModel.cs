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

        public MainViewModel()
        {
            ImageWidth = 259;
            ImageHeight = 194;
            RepeatX = 1.0;
            RectangleHeight = ImageHeight;
            RectangleWidth = imageWidth;

            OkCommand = new RelayCommand(OnOk);
        }

        private void OnOk()
        {
            RectangleHeight = RepeatX * ImageHeight;
            RaisePropertyChanged("RepeatX");
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
        public RelayCommand OkCommand { get; set; }
    }
}
