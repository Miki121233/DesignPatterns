namespace DesignPatterns.Prototype
{
    internal abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Border Border { get; set; }

        public abstract void Render();
        public abstract Shape ShallowClone();
        public abstract Shape DeepClone();
    }
}
