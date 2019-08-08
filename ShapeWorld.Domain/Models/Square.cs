namespace ShapeWorld.Domain.Models
{
    public class Square : Rectangle
    {
      private double sideLength;
      public override double Width
       {get
          {
            return sideLength;
          }
        set
          {
            sideLength=value;
          }
       }

      public override double Length
       {get
          {
            return sideLength;
          }
        set
          {
            sideLength=value;
          }
       }

      public override double Perimeter()
      {
        return 4*sideLength;
      }
     
    }
}