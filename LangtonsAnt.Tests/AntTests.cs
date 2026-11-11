using LangtonsAnt.Core;
using NUnit.Framework;

using LangtonsAnt.Core;
using NUnit.Framework;

namespace LangtonsAnt.Tests;

public class AntTests
{
    [Test]
    public void Step_TurnsRightOnWhiteCell()
    {
        var world = new World();
        var ant = new Ant(world, new Position(0, 0), Direction.North);

        ant.Step();

        Assert.That(ant.Direction, Is.EqualTo(Direction.East));
    }
    [Test]
    public void Step_TurnsRightFromEastOnWhiteCell()
    {
        var world = new World();
        var ant = new Ant(world, new Position(0, 0), Direction.East);

        ant.Step();

        Assert.That(ant.Direction, Is.EqualTo(Direction.South));
    }
}