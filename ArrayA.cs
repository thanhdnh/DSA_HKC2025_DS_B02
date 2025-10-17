public class ArrayA
{
    private object[] elmements;

    public ArrayA(int length)
    {
        elmements = new object[length];
    }

    public object[] Items {
            get => elmements;
            set => elmements = value; 
    }

  public void Add(object x)
    {

    }
    public bool Contains(object x)
    {

        return true;
    }
    public int IndexOf(object x)
    {

        return 0;
    }
    public void Reverse()
    {
        
    }
}