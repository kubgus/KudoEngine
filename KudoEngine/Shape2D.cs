﻿namespace KudoEngine
{
    /// <summary>
    /// <see langword="Kudo"/>
    /// A single-color rectangle
    /// </summary>
    public class Shape2D : RenderedObject2D
    {
        public Color Color { get; set; }

        /// <summary>
        /// Initialize a new Shape2D
        /// </summary>
        /// <param name="tag">A cosmetic tag for debugging</param>
        public Shape2D(Vector2 position, Vector2 scale, Color color, float rotation = 0f, string tag = "Shape2D", int layer = 0)
        {
            Position = position;
            Scale = scale;
            Color = color;
            Rotation = rotation;
            Tag = tag;
            Layer = Math.Clamp(layer, -999, 1000);

            IsAlive = true;

            Kudo.AddRender2D(this);
        }
    }
}
