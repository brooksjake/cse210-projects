public class Fraction
{
    // attributes
    private int _top;
    private int _bottom;

    // constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // getters
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public String GetFractionString()
    {
        return (_top + "/" + _bottom);
    }
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

    // setters
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

}