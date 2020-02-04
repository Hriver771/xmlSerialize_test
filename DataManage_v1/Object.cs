using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataManage_v1
{
    public class Object
    {
        [XmlElement("ShapeType")]
        public int ShapeType { get; set; }

        [XmlElement("Type")]
        public int Type { get; set; }

        [XmlElement("Transform")]
        public _Transform Transform { get; set; }

        [XmlElement("Position")]
        public _Position Position { get; set; }

        [XmlElement("Points")]
        public List<_Point> Points { get; set; }

        [XmlElement("Label")]
        public _Label Label { get; set; }

        public Object()
        {
            this.ShapeType = 0; this.Type = 1;
            this.Transform = new _Transform();
            this.Position = new _Position();
            this.Points = new List<_Point>();
            _Point temp = new _Point(256, 694);
            this.Points.Add(temp);
            _Point temp2 = new _Point(359, 734);
            this.Points.Add(temp);
            this.Label = new _Label();
                      
        }

        public class _Transform
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public int ShowRoof { get; set; }
            public int ExtendedPoint { get; set; }
            public int Side { get; set; }
            public int Direction { get; set; }

            public _Transform()
            {
                this.Height = 103; this.Width = 40; this.ShowRoof = 0; this.ExtendedPoint = 0; this.Side = -1;
            }
        }
        public class _Position
        {
            public double Bottom { get; set; }
            public double Right { get; set; }
            public double Top { get; set; }
            public double Left { get; set; }

            public _Position ()
            {
                this.Bottom = 359; this.Right = 734; this.Right = 734; this.Left = 694;
            }
        }
        public class _Points
        {
            public _Point point1 { get; set; }
            public _Point Point2 { get; set; }
        }
        public class _Point
        {
            public double y { get; set; }
            public double x { get; set; }

            public _Point() { }

            public _Point(int y, int x)
            {
                this.y = y;
                this.x = x;
            }
        }
        public class _Label
        {
            public string Text { get; set; }
        }
    }
}