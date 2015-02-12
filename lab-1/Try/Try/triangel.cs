using System;
using System.Linq;
using System.Collections.Generic;

public struct Point
{ 
    public double x, y;
  
    public Point(double a, double b) {
        x = a;
        y = b;
    }
}

public class Triangle 
{
    double[] sides;

    public Triangle(double a, double b, double c) 
        : this( new double[] {a, b, c} )
    {
        // Empty!
    }

    public Triangle(double[] s)
    {
        if (!controlArray(s)) 
        {
            throw new ArgumentException("FEL! Antalet element i arrayen måste vara 3!");
        }
        
        if (!controlValue(s)) 
        {
            throw new ArgumentException("FEL! Alla tal måste vara > 0!");
        }
        
        if (!controlTriangle(s))
        {
            throw new ArgumentException("FEL! Värdena representerar inte en giltig triangel!");
        }

        sides = new double[s.Length];
        
        for (int i = 0; i < s.Length; i++)
        {
            sides[i] = s[i];
        }
    }

    public Triangle(Point a, Point b, Point c)
        : this( new Point[] {a, b, c} )
    {
        // Empty!
    }

    public Triangle(Point[] s) 
    {
        if (!controlArray(s)) 
        {
            throw new ArgumentException("FEL! Antalet element i arrayen måste vara 3!");
        }
        
        double[] values = countDistance(s);
        
        if (!controlTriangle(values))
        {
            throw new ArgumentException("FEL! Värdena representerar inte en giltig triangel!");
        }

        sides = values;
    }

    private int uniqueSides()
    {
        return sides.Distinct<double>().Count();
    }

    private double[] countDistance(Point[] p)
    {
        double[] sides = new double[3];

        sides[0] = Math.Sqrt(Math.Pow((double)(p[1].x - p[2].x), 2.0) + Math.Pow((double)(p[1].y - p[2].y), 2.0));
        sides[1] = Math.Sqrt(Math.Pow((double)(p[0].x - p[2].x), 2.0) + Math.Pow((double)(p[0].y - p[2].y), 2.0));
        sides[2] = Math.Sqrt(Math.Pow((double)(p[1].x - p[0].x), 2.0) + Math.Pow((double)(p[1].y - p[0].y), 2.0));

        return sides;
    }

    private bool controlArray(Array arr) 
    {
        if (arr.Length != 3)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    private bool controlValue(double[] d) 
    {
        foreach (double value in d) 
        {
            if (value <= 0)
            {
                return false;
            }
        }
        return true;
    }

    private bool controlTriangle(double[] arr) 
    {
        if (arr[0] < (arr[1] + arr[2]) && arr[0] > Math.Abs(arr[1] - arr[2]))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public bool isScalene() {
        if (uniqueSides() == 3)
        {
            return true;
        }
        return false;
    }

    public bool isEquilateral() {
        if (uniqueSides() == 1)
        {
            return true;
        }
        return false;
    }

    public bool isIsosceles()
    {
        if (uniqueSides() == 2)
        {
            return true;
        }
        return false;
    }
}