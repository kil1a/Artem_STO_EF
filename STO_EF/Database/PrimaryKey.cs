namespace STO_EF.DataBase;
public class PrimaryKey
{
    private static int _lastKey = 0;
    public int Key { get; }

    public PrimaryKey()
    {
        Key = _lastKey;
        _lastKey++;
    }
}