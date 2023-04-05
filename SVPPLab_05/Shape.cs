﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace SVPPLab_05
{
    public class Shape
    {
        public Shape()
        {
        }

        public Shape(int width, int height, int thickness, Color? background, Color? foreground)
        {
            Width = width;
            Height = height;
            Thickness = thickness;
            Background = background;
            Foreground = foreground;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public int Thickness { get; set; } = 0;
        public Color? Background { get; set; }
        public Color? Foreground { get; set; }

        public void draw(Canvas canvas, Point point)
        {
            Polygon polygon = new Polygon();
            polygon.Points.Add(point);
            polygon.Points.Add(new Point(point.X + Width, point.Y));
            polygon.Points.Add(new Point(point.X, point.Y + Height));
            polygon.Fill = new SolidColorBrush((Color)Background);
            polygon.Stroke = new SolidColorBrush((Color)Foreground);
            polygon.StrokeThickness = Thickness;
            canvas.Children.Add(polygon);
        }
        public void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы (xml)|*.xml|Все файлы|*.*";
            if (saveFileDialog.ShowDialog() == false) return;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shape));
            using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create))
            {
                xmlSerializer.Serialize(file, this);
            }
        }
        public static Shape Load()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы (xml)|*.xml|Все файлы|*.*";
            if (openFileDialog.ShowDialog() == false) return null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Shape));
            using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                return (Shape)xmlSerializer.Deserialize(file);
            }
        }
        public override string ToString()
        {
            return $"Thickness = {Thickness} Background = {Background} Foreground = {Foreground}\n" +
                $"Width = {Width} Height = {Height}";
        }


    }
}
