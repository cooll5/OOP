package com.company;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        double x; // input
        double y; // result
        double A = 0; // сталий вираз
        double B = 0; // змінний вираз
        System.out.println("Task 1:");
        System.out.print("x = ");
        x = in.nextDouble();
        A = 1 + x;
        if (x <= 4)
            B = Math.Exp(Math.Log(2 + 2 * 2) + 2 * x);
        else
        if (x > 7)
            B = 1 - 7 * x + 2 * x * x - Math.Pow(2 * x, 3);
        else
            B = 1 / Math.Tan((1 + x) / 9 + 8 * x);

        y = A + B;

            System.out.println("y = " + String.format("%.3f", y));

        System.out.println("Task 2:");

        double a; // input
        double b; // input
        double c; // input
        double F = 0; // result

        System.out.print("a = ");
        a = in.nextDouble();
        System.out.print("b = ");
        b = in.nextDouble();
        System.out.print("c = ");
        c = in.nextDouble();
        System.out.print("x = ");
        x = in.nextDouble();

        if (c < 0 && x != 0)
            F = (-a) * x - c;

        else
        if (c > 0 && x == 0)
            F = (x - a) / ( - c );

        else
            F = (b * x)/ (c - a);

        System.out.println("Task 2: F = " + String.format("%.3f", F));

        System.out.println("Task 3:");

        int i = 1, N;
        double S;

        System.out.print("N = ");
        N = in.nextInt();

        S = 0;
        i = 1;
        while (i <= N)
        {
            S += ((1 + i / N)/ (i * i));
            i++;
        }
        System.out.println("1) S = " + String.format("%.3f", S));

        S = 0;
        i = 1;
        do
        {
            S += ((1 + i / N) / (i * i));
            i++;
        }
        while (i <= N);
        System.out.println("2) S = " + String.format("%.3f", S));

        S = 0;
        for (i = 1; i <= N; i++)
        {
            S += ((1 + i / N) / (i * i));
        }
        System.out.println("3) S = " + String.format("%.3f", S));

        S = 0;
        for (i = N; i >= 1; i--)
        {
            S += ((1 + i / N) / (i * i));
        }
        System.out.println("4) S = " + String.format("%.3f", S));

        System.out.println("Task 4:");

        double xp;
        double xk;
        double dx;

        System.out.print("xp = ");
        xp = in.nextDouble();
        System.out.print("xk = ");
        xk = in.nextDouble();
        System.out.print("dx = ");
        dx = in.nextDouble();
        System.out.print("a = ");
        a = in.nextDouble();
        System.out.print("b = ");
        b = in.nextDouble();
        System.out.print("c = ");
        c = in.nextDouble();

        System.out.println("---------------------------");
        System.out.println("|     x     |     F     |");

        x = xp;
        while (x <= xk)
        {
            if (c < 0 && x != 0)
                F = (-a) * x - c;
            else
            if (c > 0 && x == 0)
                F = (x - a) / (-c);
            else
                F = (b * x) / (c - a);

            System.out.println("|  "+ String.format("%.3f", x)"    |     " + String.format("%.3f", F)     |");
            System.out.println("4) S = " + String.format("%.3f", S));
            " + String.format("%.3f", S)
            x += dx;
        }
        System.out.println("---------------------------");
    }
}
