using UnityEngine;

public interface ISwimBehavior
{
    void Swim(Transform duckTransform);
}
public class DefaultSwim : ISwimBehavior
{
    public void Swim(Transform t)
    {
        t.position += Vector3.up * Time.deltaTime;
    }
}
public class JetpackSwim : ISwimBehavior
{
    public void Swim(Transform t)
    {
        t.position += Vector3.up * Time.deltaTime * 2;
    }
}


public class RotateSwim : ISwimBehavior
{
    private Vector3 center = Vector3.zero;
    private float radius = 2f;             
    private float speed = 1f;             
    private float angle = 0f;             

    public void Swim(Transform t)
    {
        angle += speed * Time.deltaTime;
        float x = center.x + Mathf.Cos(angle) * radius;
        float y = center.y + Mathf.Sin(angle) * radius;
        t.position = new Vector3(x, y, t.position.z);
    }
}


