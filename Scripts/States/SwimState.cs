using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public abstract class SwimState
{
    protected ISwimBehavior _swimBehavior;
    public SwimState(ISwimBehavior swimBehavior)
    {
        _swimBehavior = swimBehavior;
    }
    public virtual void Update(Transform duckTransform)
    {
        _swimBehavior?.Swim(duckTransform);
    }
    public abstract SwimState SwitchState();
}



public class SwimmingState : SwimState
{
    public SwimmingState(ISwimBehavior swimBehavior) : base(swimBehavior) { }

    public override SwimState SwitchState() => new NotSwimmingState(_swimBehavior);
}

public class NotSwimmingState : SwimState
{
    public NotSwimmingState(ISwimBehavior swimBehavior) : base(swimBehavior) { }
    public override SwimState SwitchState() => new SwimmingState(_swimBehavior);
    public override void Update(Transform duckTransform)
    {
    }
}
