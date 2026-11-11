namespace LangtonsAnt.Core;

public sealed class Ant
{
    private readonly World _world;

    public Ant(World world, Position position, Direction direction)
    {
        _world = world;
        Position = position;
        Direction = direction;
    }

    public Position Position { get; private set; }
    public Direction Direction { get; private set; }

    public AntStep Step()
    {
        
        var position = Position;
        var color = _world.GetColor(position);
        var newColor = color == CellColor.White
            ? CellColor.Black
            : CellColor.White;
        Position to;
        if (color == CellColor.White)
        {
            Direction = Direction.East;
            to = new Position(position.X + 1, position.Y);
        }
        else
        {
            Direction = Direction.West;
            to = new Position(position.X - 1, position.Y);
        }
        Position = to;
        var toColor = _world.GetColor(to);
        return new AntStep(position, to, Direction, newColor, toColor);
    }

    public IEnumerable<AntStep> GetSteps(int count)
    {
        throw new NotImplementedException($"{nameof(Ant)}.{nameof(GetSteps)}");
    }
}
