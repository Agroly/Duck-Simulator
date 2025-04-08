using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class FlyState
{
    protected IFlyBehavior _flyBehavior;

    public FlyState(IFlyBehavior flyBehavior)
    {
        _flyBehavior = flyBehavior;
    }
    public virtual void Update(Transform duckTransform)
    {
        _flyBehavior?.Fly(duckTransform);
    }
    public abstract FlyState SwitchState();
}
public class NotFlyingState : FlyState
{
    public NotFlyingState(IFlyBehavior flyBehavior) : base(flyBehavior) { }
    public override void Update(Transform duckTransform)
    {
        // Ничего не делает
    }
    public override FlyState SwitchState() => new FlyingState(_flyBehavior);
}
public class FlyingState : FlyState
{
    public FlyingState(IFlyBehavior flyBehavior) : base(flyBehavior) { }

    public override FlyState SwitchState() => new JetPackFlyingState(_flyBehavior);
}

public class JetPackFlyingState : FlyState
{
    private IFlyBehavior _jetPackBehavior = new JetpackFly();
    public JetPackFlyingState(IFlyBehavior flyBehavior) : base(flyBehavior) { }

    public override void Update(Transform duckTransform)
    {
        _jetPackBehavior.Fly(duckTransform);
    }

    public override FlyState SwitchState() => new NotFlyingState(_flyBehavior);

}