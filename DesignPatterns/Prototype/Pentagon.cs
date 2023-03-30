namespace DesignPatterns.Prototype
{
    internal class Pentagon : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render pentagon");
        }

        public override Shape ShallowClone()
        {
            return (Pentagon)this.MemberwiseClone();
        }

        public override Shape DeepClone()
        {
            var cloneBase = (Pentagon)this.MemberwiseClone();
            cloneBase.Border = new Border()
            {
                Color = Border.Color,
                Size = Border.Size
            };
            return cloneBase;
        }
    }
}
