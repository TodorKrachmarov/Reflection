using System;

public class Program
{
    public static void Main()
    {
        //Spy spy = new Spy();
        //string result = spy.StealFieldInfo("Hacker", "username", "password");
        //Console.WriteLine(result);

        //Spy spy = new Spy();
        //string result = spy.AnalyzeAcessModifiers("Hacker");
        //Console.WriteLine(result);

        //Spy spy = new Spy();
        //string result = spy.RevealPrivateMethods("Hacker");
        //Console.WriteLine(result);

        Spy spy = new Spy();
        string result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
    }
}
