﻿namespace KudoEngine
{
    /// <summary>
    /// <see langword="Kudo"/>
    /// Contains <see langword="X"/> and <see langword="Y"/> values
    /// </summary>
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        /// <summary>
        /// Initialize a new Vector2 with values 0, 0
        /// </summary>
        public Vector2()
        {
            X = Zero().X;
            Y = Zero().Y;
        }

        /// <summary>
        /// Initialize a new Vector2 with the same values
        /// </summary>
        public Vector2(float xy)
        {
            X = xy;
            Y = xy;
        }

        /// <summary>
        /// Initialize a new Vector2 with values
        /// </summary>
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Returns <see langword="X"/> and <see langword="Y"/> as 0
        /// </summary>
        public static Vector2 Zero()
        {
            return new(0, 0);
        }

        /// <summary>
        /// Initialize a new Vector2 based on this Vector2
        /// </summary>
        public Vector2 Copy()
        {
            return new(X, Y);
        }

        /// <summary>
        /// Return a Vector2 value added to this Vector2
        /// </summary>
        public Vector2 Add(Vector2 vector)
        {
            return new(X + vector.X, Y + vector.Y);
        }

        /// <summary>
        /// Return a Vector2 value subtracted from this Vector2
        /// </summary>
        public Vector2 Subtract(Vector2 vector)
        {
            return new(X - vector.X, Y - vector.Y);
        }

        /// <summary>
        /// Return a Vector2 value multiplied by this Vector2
        /// </summary>
        public Vector2 Multiply(Vector2 vector)
        {
            return new(X * vector.X, Y * vector.Y);
        }

        /// <summary>
        /// Return this Vector2 divided by a Vector2 value
        /// </summary>
        public Vector2 Divide(Vector2 vector)
        {
            return new(X / vector.X, Y / vector.Y);
        }

        /// <summary>
        /// Return a Vector2 with absolute values based on this Vector2
        /// </summary>
        public Vector2 Abs()
        {
            return new((float)Math.Abs(X), (float)Math.Abs(Y));
        }

        /// <summary>
        /// Return this Vector2 raised to the specified power
        /// </summary>
        public Vector2 Pow(double power)
        {
            return new((float)Math.Pow(X, power), (float)Math.Pow(Y, power));
        }

        /// <summary>
        /// Calculate a position to move towards another <see langword="Vector2"/>
        /// </summary>
        public Vector2 MoveTowards(Vector2 vector, float step = 1f)
        {
            return new(X + Math.Sign(vector.X - X) * step, Y + Math.Sign(vector.Y - Y) * step);
        }

        /// <summary>
        /// Calculate a position to move in direction of a specified angle
        /// </summary>
        public Vector2 MoveInDirection(double angle, float step = 1f)
        {
            return Add(new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle)).Multiply(new(step)));
        }

        /// <summary>
        /// Calculate the angle of another <see langword="Vector2"/> relative to this object
        /// </summary>
        /// <returns>Radians</returns>
        public float GetRelativeAngle(Vector2 vector)
        {
            return (float)Math.Atan2(vector.Y - Y, vector.X - X);
        }

        /// <summary>
        /// Returns the distance between this Vector2 and another Vector2
        /// </summary>
        public float HowFarIs(Vector2 vector)
        {
            // Pythagorean theorem
            Vector2 tmp = Subtract(vector).Abs().Pow(2);
            return (float)Math.Sqrt(tmp.X + tmp.Y);
        }
    }
}
