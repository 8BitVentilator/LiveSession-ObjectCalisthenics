namespace ObjectCalisthenics.Rule1.Example1.Models;

public record Field(Player Player);

public enum Player { X, O }

public class Board
{
    public int Width { get; }
    public int Height { get; }

    private readonly Field[,] _fields;

    public Board(int width, int height)
    {
        Width = width;
        Height = height;
        _fields = new Field[width, height];
    }

    public Field this[int x, int y]
    {
        get => _fields[x, y];
        set
        {
            if (_fields[x, y] != null)
                throw new Exception();

            _fields[x, y] = value;
        }
    }
}
