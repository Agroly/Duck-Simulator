using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.IO.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace Ducks
{
    public abstract class Duck : MonoBehaviour
    {
        [SerializeField] private float quackInterval = 3f;
        protected IQuackBehavior quackBehavior = new DefaultQuack();
        protected ISwimBehavior swimBehavior = null;
        protected IFlyBehavior flyBehavior = null;
        protected StateMachine stateMachine;

        private void Start()
        {
            InitializeBehavior();
            InitializeStates();
            StartCoroutine(QuackRoutine());
        }
        protected abstract void InitializeBehavior();

        protected virtual void InitializeStates()
        {
            stateMachine = new StateMachine();
            stateMachine.Initialize(new FlyingState(flyBehavior), new SwimmingState(swimBehavior));
        }


        private void Quack()
        {
            quackBehavior?.Quack(gameObject.name);
        }
        private void Update()
        {
            stateMachine.currentFlyState.Update(transform);
            stateMachine.currentSwimState.Update(transform);
        }

        private IEnumerator QuackRoutine()
        {
            while (true)
            {
                Quack();
                yield return new WaitForSeconds(quackInterval);
                stateMachine.SwitchSwimState();
                stateMachine.SwitchFlyState();
            }
        }
    }
}
