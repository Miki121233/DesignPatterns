namespace DesignPatterns.Prototype
{
    internal class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }

        public override Shape ShallowClone()
        {
            return (Triangle)this.MemberwiseClone();
        }

        public override Shape DeepClone()
        {
            var cloneBase = (Triangle)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Color = Border.Color,
                Size = Border.Size
            };
            return cloneBase;
        }
    }
}
