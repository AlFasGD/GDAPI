using System;

namespace GDAPI.Objects.GeometryDash.General
{
    /// <summary>Represents the color of a guideline.</summary>
    public struct GuidelineColor : IComparable<GuidelineColor>
    {
        /// <summary>Represents the value of the transparent color in the guideline. It is a hidden game feature, where invisible guidelines may be created.</summary>
        public const float TransparentValue = 0.7f;
        /// <summary>Represents the value of the orange color in the guideline.</summary>
        public const float OrangeValue = 0.8f;
        /// <summary>Represents the value of the yellow color in the guideline.</summary>
        public const float YellowValue = 0.9f;
        /// <summary>Represents the value of the green color in the guideline.</summary>
        public const float GreenValue = 1f;

        /// <summary>An instance of the transparent guideline color.</summary>
        public static readonly GuidelineColor Transparent = new GuidelineColor(TransparentValue);
        /// <summary>An instance of the orange guideline color.</summary>
        public static readonly GuidelineColor Orange = new GuidelineColor(OrangeValue);
        /// <summary>An instance of the yellow guideline color.</summary>
        public static readonly GuidelineColor Yellow = new GuidelineColor(YellowValue);
        /// <summary>An instance of the green guideline color.</summary>
        public static readonly GuidelineColor Green = new GuidelineColor(GreenValue);

        private float col;

        /// <summary>Determines whether the guideline color is transparent.</summary>
        public bool IsTransparent => col == TransparentValue;
        /// <summary>Determines whether the guideline color is orange.</summary>
        public bool IsOrange => col == OrangeValue;
        /// <summary>Determines whether the guideline color is yellow.</summary>
        public bool IsYellow => col == YellowValue;
        /// <summary>Determines whether the guideline color is green.</summary>
        public bool IsGreen => col == GreenValue;

        /// <summary>Initializes a new instance of the <seealso cref="GuidelineColor"/> struct.</summary>
        /// <param name="color">The color value to use.</param>
        public GuidelineColor(float color) => col = color;
        /// <summary>Initializes a new instance of the <seealso cref="GuidelineColor"/> struct.</summary>
        /// <param name="color">The color value to use.</param>
        public GuidelineColor(double color) => col = (float)color;
        /// <summary>Initializes a new instance of the <seealso cref="GuidelineColor"/> struct.</summary>
        /// <param name="color">The color value to use.</param>
        public GuidelineColor(decimal color) => col = (float)color;

        /// <summary>Compares this <seealso cref="GuidelineColor"/> to another based on their color value.</summary>
        /// <param name="other">The other <seealso cref="GuidelineColor"/> to compare this to.</param>
        public int CompareTo(GuidelineColor other) => col.CompareTo(other.col);

        public static implicit operator GuidelineColor(float color) => new GuidelineColor(color);
        public static implicit operator GuidelineColor(double color) => new GuidelineColor(color);
        public static implicit operator GuidelineColor(decimal color) => new GuidelineColor(color);

        public static explicit operator float(GuidelineColor color) => color.col;
        public static explicit operator double(GuidelineColor color) => color.col;
        public static explicit operator decimal(GuidelineColor color) => (decimal)color.col;

        public static bool operator ==(GuidelineColor left, GuidelineColor right) => left.col == right.col;
        public static bool operator !=(GuidelineColor left, GuidelineColor right) => left.col != right.col;

        /// <summary>Parses the <seealso cref="GuidelineColor"/> from a string representation of a <seealso cref="float"/>.</summary>
        /// <param name="s">The string to parse.</param>
        public static GuidelineColor Parse(string s) => float.Parse(s);

        /// <summary>Returns the string representation of this <seealso cref="GuidelineColor"/>'s raw color value.</summary>
        public override string ToString() => col.ToString();
        /// <summary>Determines whether this <seealso cref="GuidelineColor"/> equals another object.</summary>
        /// <param name="obj">The other object to determine equality with.</param>
        public override bool Equals(object obj) => col.Equals(((GuidelineColor)obj).col);
        /// <summary>Gets the hash code of this <seealso cref="GuidelineColor"/> based on the raw color value.</summary>
        public override int GetHashCode() => col.GetHashCode();
    }
}
