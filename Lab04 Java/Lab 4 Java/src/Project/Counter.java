package Project;
import java.util.Scanner;

public class Counter
{
    private int sense;
	
	
	public String getName() { return name; }
	public int getNo() { return no; }

    private int sense;
    public int GetSense() { return sense; }

    public bool SetSense(int value)
    {
        if (value >= 0 && value < 100000) { sense = value; return true; }
        else System.out.println("Try to write your value again!");

        { sense = 0; return false; }

    }

    public void Read()
    {
        int s;

        do
        {
            System.out.println("Sense: ");
            s = scan.nextDouble();

        } while (!Init(s));
    }

    public void Display()
    {
        if (sense == 0)
            System.out.println("" + String.format("%.3f", sense); - you have no value");
        else
            System.out.println("" + String.format("%.3f", sense); that is your current value");
    }
}
