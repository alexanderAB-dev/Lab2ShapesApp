using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        private Vector2 center;
        private Vector2 size;
       
        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.size = size;
        }
        public Rectangle(Vector2 center, float width)
        {
            this.center = center;
            this.size = new Vector2(width,width);
            
        }

       

        public override Vector3 Center => new Vector3(center, 0);
        public override float Circumference => (size.X + size.Y)*2;
        public override float Area => size.X * size.Y;
        public bool IsSquare => size.X == size.Y;

        public override string ToString()
        {
            return $"Rectangle @({center.X}, {center.Y}): w = {size.X}, h = {size.Y}, isSquare = {IsSquare}";
        }
    }
}

