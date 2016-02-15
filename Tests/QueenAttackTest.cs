using System;
using Xunit;

namespace QueenAttack
{
  public class QueenAttackTest
  {
    [Fact]
    public void Queen_ForHorizontal_true()
    {
      Queen queen = new Queen(2, 2);
      Assert.Equal(true, queen.CanAttack(2, 4));
    }
    [Fact]
    public void Queen_ForHorizontal_false()
    {
      Queen queen = new Queen(3, 2);
      Assert.Equal(false, queen.CanAttack(2, 4));
    }
    [Fact]
    public void Queen_ForVertical_true()
    {
      Queen queen = new Queen(2, 4);
      Assert.Equal(true, queen.CanAttack(3, 4));
    }
    [Fact]
    public void Queen_ForVertical_false()
    {
      Queen queen = new Queen(3, 2);
      Assert.Equal(false, queen.CanAttack(2, 4));
    }
    [Fact]
    public void Queen_ForDiagonal_true()
    {
      Queen queen = new Queen(5, 5);
      Assert.Equal(true, queen.CanAttack(6, 6));
    }
    [Fact]
    public void Queen_ForDiagonal_false()
    {
      Queen queen = new Queen(5, 5);
      Assert.Equal(false, queen.CanAttack(3, 8));
    }

  }
}
