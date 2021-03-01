using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        private Vector3 center;
        private float radius;
        public Sphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public override float Volume => (4/3) * (MathF.PI * (radius*3));

        public override Vector3 Center => new Vector3(center.X, center.Y, center.Z);

        public override float Area => 4 * (MathF.PI * (radius * 2));
        public override string ToString()
        {
            return $"Sphere @({center.X}, {center.Y}, {center.Z}): r = {radius}";
        }
    }
}
