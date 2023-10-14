namespace ObjectCalisthenics.Rule2.Example1.Models;

public interface ISomething
{
    void Do();
}

public class Something : ISomething { public void Do() { } }

public class SomethingElse : ISomething { public void Do() { } }
