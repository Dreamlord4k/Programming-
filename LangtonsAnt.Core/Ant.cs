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
        var turn = color == CellColor.White ? 1 : 3;
        Direction = (Direction)(((int)Direction + turn) % 4);
        var to = Direction switch
        {
            Direction.North => new Position(position.X, position.Y - 1),
            Direction.East  => new Position(position.X + 1, position.Y),
            Direction.South => new Position(position.X, position.Y + 1),
            Direction.West  => new Position(position.X - 1, position.Y),
            _ => throw new InvalidOperationException()
        };

        var toColor = _world.GetColor(to);
        return new AntStep(position, to, Direction, newColor, toColor);
    }

    public IEnumerable<AntStep> GetSteps(int count)
    {
        throw new NotImplementedException($"{nameof(Ant)}.{nameof(GetSteps)}");
    }
}
