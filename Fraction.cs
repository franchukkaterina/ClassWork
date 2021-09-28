public class Fraction
{
    public int numerator  { get; set; }
    public int  denominator { get; set; }

    Fraction(){
      this.numerator = this.denominator = 0;  
    }
    public Fraction(Fraction other)
    {
        this.denominator = other.denominator;
        this.numerator = other.numerator;
    }

    public Fraction(int x, int y)
    {
        this.denominator = y;
        this.numerator = x;
            
    }

    public static Fraction operator+(Fraction first, Fraction second ){
        return new Fraction((first.numerator*second.denominator)+(second.numerator*first.denominator), first.denominator*second.denominator);
    }

    public static Fraction operator-(Fraction first, Fraction second ){
        return new Fraction((first.numerator*second.denominator)-(second.numerator*first.denominator), first.denominator*second.denominator);
    }

   public static bool operator ==(Fraction first, Fraction second)
    {
	    return first.numerator * second.denominator == second.numerator * first.denominator;
    }

    public static bool operator !=(Fraction first, Fraction second)
    {
	    return first.numerator * second.denominator == second.numerator * first.denominator;
    }

    public static bool operator >(Fraction first, Fraction second)
    {
	    return first.numerator * second.denominator > second.numerator * first.denominator;
    }
    public static bool operator <(Fraction first, Fraction second)
    {
	    return first.numerator * second.denominator < second.numerator * first.denominator;
    }

    public override string ToString()
    {
        return $"\t{this.numerator}/{this.denominator}";
    }
    
    public override bool Equals(object obj)
     {
        if(obj is Fraction)
            return ((obj as Fraction) == this);
        return false;
    }
    public override int GetHashCode()
    {
        return (this.numerator.GetHashCode() + this.denominator.GetHashCode()  );
    }
}