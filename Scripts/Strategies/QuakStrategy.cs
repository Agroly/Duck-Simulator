using UnityEngine;

public interface IQuackBehavior
{
    void Quack(string duckName);
}
public class DefaultQuack : IQuackBehavior
{
    public void Quack(string duckName)
    {
        Debug.Log($"{duckName} �������.");
        QuackCounter.Instance.IncrementQuackCount();
    }
}

public class SqueakQuack : IQuackBehavior
{
    public void Quack(string duckName)
    {
        Debug.Log($"{duckName} �����.");
    }
}
