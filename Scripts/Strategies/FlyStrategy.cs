using UnityEngine;

public interface IFlyBehavior
{
    void Fly(Transform duckTransform);
}
public class DefaultFly : IFlyBehavior
{
    public void Fly(Transform duckTransform)
    {
        duckTransform.rotation *= Quaternion.AngleAxis(5 * Time.deltaTime, Vector3.forward);
    }
}
public class InverseFly : IFlyBehavior
{
    public void Fly(Transform duckTransform)
    {
        duckTransform.rotation *= Quaternion.AngleAxis(5 * Time.deltaTime, Vector3.back);
    }
}
public class JetpackFly : IFlyBehavior
{
    public void Fly(Transform duckTransform)
    {
        duckTransform.rotation *= Quaternion.AngleAxis(100 * Time.deltaTime, Vector3.back);
    }
}

