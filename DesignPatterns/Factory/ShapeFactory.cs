namespace DesignPatterns.Factory
{
    internal class ShapeFactory
    {
        public Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Square:
                    return new Square();
                default:
                    throw new Exception($"No case for {type}");
            }
        }
    }
}
