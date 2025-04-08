using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public FlyState currentFlyState;
    public SwimState currentSwimState;

    public void Initialize(FlyState startFlyState, SwimState startSwimState)
    {
        currentFlyState = startFlyState;
        currentSwimState = startSwimState;
    }
    public void SwitchSwimState()
    {
        currentSwimState = currentSwimState.SwitchState();
    }
    public void SwitchFlyState()
    {
        currentFlyState = currentFlyState.SwitchState();
    }
}
