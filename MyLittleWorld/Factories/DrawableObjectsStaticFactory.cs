using System;
using System.Drawing;

namespace MyLittleWorld
{
    public static class DrawableObjectsStaticFactory
    {
        public static AbstractRadialObject CreateObject(Type objectType, PointF position, PointF planetCenter, int planetRadius)
        {
            if (objectType == typeof(House))
                return new House(position, planetCenter, planetRadius);
            if (objectType == typeof(Fir))
                return new Fir(position, planetCenter, planetRadius);
            if (objectType == typeof(Obelisk))
                return new Obelisk(position, planetCenter, planetRadius);
            if (objectType == typeof(Mountains))
                return new Mountains(position, planetCenter, planetRadius);

            throw new ArgumentException("Unknown object type");
        }
    }
}