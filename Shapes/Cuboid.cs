using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : Shape3D
    {
        public Vector3 center;
        public Vector3 size;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            this.size = new Vector3(width, width, width);
        }
        public override float Volume => size.X * size.Y * size.Z;

        public override Vector3 Center => new Vector3(center.X, center.Y, center.Z);

        public override float Area => 2 * ((size.X * size.Y) + (size.X * size.Z) + (size.Y * size.Z));

        public bool IsCube => size.X == size.Y && size.X == size.Z;

        public override string ToString()
        {
            return $"Cuboid @({center.X}, {center.Y}, {center.Z}): w = {size.X},  h = {size.Y}, l = {size.Z}, isCube = {IsCube}";
        }

    }
}
