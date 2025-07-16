using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleWorld.DrawableObjects.Base
{
    public interface IDrawableRadial : IDrawable
    {
        PointF Position { get; set; }
        PointF PlanetCenter { get; set; }
    }
}
