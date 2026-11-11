using LangtonsAnt.Core;
using NUnit.Framework;

namespace LangtonsAnt.Tests;

public class WorldTests
{
    [Test]
    public void GetColor_ReturnsWhite_ForAnUntouchedCell()
    {
        // Arrange
        var world = new World();
        var position = new Position(0, 0);

        // Act
        CellColor color = world.GetColor(position);

        // Assert
        Assert.That(color, Is.EqualTo(CellColor.White));
    }

    [Test]
    public void GetColor_ReturnsColorSetForCell()
    {
        var world = new World();
        var position = new Position(2, 2); 
        world.SetColor(position, CellColor.Black);
        Assert.That(world.GetColor(position), Is.EqualTo(CellColor.Black));
    }
    
    [Test]
    public void GetColor_ReturnsDirectionAndPose()
    {
        var world = new World();
        var position = new Position(1, 2); 
        CellColor color = world.GetColor(position);
        Assert.That(world.GetColor(position), Is.EqualTo(CellColor.Black));
    }
}
