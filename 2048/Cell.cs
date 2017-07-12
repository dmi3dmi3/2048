using System;

public class Cell
{
    int iValue = 0;
    bool bIsFull = false;
	public Cell(bool full)
	{
        bIsFull = full;
        if (full)
        {
            iValue = RandValue;
        }
	}
    private int RandValue()
    {
        if (new Random().Next(10) == 0)
        {
            return 4;
        }
        else
        {
            return 2;
        }
    }
    public void Upgrate()
    {
        iValue *= 2;
    }
}
