namespace LangtonsAnt.Core;

public sealed class World
{
    Dictionary<Position, CellColor> _colors = new();
    public CellColor GetColor(Position position)
    {
        if (_colors.TryGetValue(position, out var color))
            return color;

        return CellColor.White;
    }

    public void SetColor(Position position, CellColor color)
    {
        _colors[position] = color;
    }
}
