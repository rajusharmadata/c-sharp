public abstract class Example{

 public abstract double CircleArea();

}

public class Circle:Example{
    private int  Radius;

   public Circle(int r){
        Radius = r;
    }
    public override double CircleArea(){
        return 3.14 * Radius * Radius;
    }
}