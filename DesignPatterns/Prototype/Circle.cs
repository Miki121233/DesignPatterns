namespace DesignPatterns.Prototype
{
    internal class Circle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render circle");
        }

        public override Shape ShallowClone()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override Shape DeepClone()
        {
            var cloneBase = (Circle)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Color = Border.Color,
                Size = Border.Size
            };
            return cloneBase;
        }
    }
}
