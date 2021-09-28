public class ArrayFraction
{
    public Fraction[] arry_fraction { get; private set; }
    
    public Fraction this[int numb]{
        get{
            return arry_fraction[numb];
        }
        private set{}
    }

    public void add(Fraction drob){
        Array.Resize<Fraction>(ref drob, drob.Lengths+1);
        drob[drob.Lengths]=drob;
    }

    public Fraction sum(){
        
    }
}