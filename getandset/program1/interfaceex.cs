
public interface Trangle{ // interrface class 
    public double trangleArea();
}

public class TrangleArea:Trangle{ // inheret the Trangle 
    private int length;
    private int breadth;

    public TrangleArea(int l, int b){ // constra use to set the value 
        length = l;
        breadth = b;
    }
    public  double trangleArea(){ 
        return (length * breadth)/2;
    }
}