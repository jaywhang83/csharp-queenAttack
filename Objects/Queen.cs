using System;

namespace QueenAttack
{
  public class Queen
  {
    private double XCordinate;
    private double YCordinate;

    public Queen(double x, double y)
    {
      XCordinate = x;
      YCordinate = y;
    }

    public double GetX()
    {
      return XCordinate;
    }
    public double GetY()
    {
      return YCordinate;
    }
    public void SetX(double x)
    {
      XCordinate = x;
    }
    public void SetY(double y)
    {
      YCordinate = y;
    }
    public bool CanAttack(double x, double y)
    {
      if(x == GetX())
      {
        return true;
      }
      else if(y == GetY())
      {
        return true;
      }
      else if((y - GetY())/(x-GetX()) == 1 || (y - GetY())/(x-GetX()) == -1 )
      {
        return true;
      }
      else
      {
          return false;
      }
    }
  }
}
