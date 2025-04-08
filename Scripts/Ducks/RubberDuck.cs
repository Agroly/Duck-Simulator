namespace Ducks
{
    public class RubberDuck : Duck
    {
        protected override void InitializeBehavior()
        {
            quackBehavior = new SqueakQuack();
            swimBehavior = new RotateSwim();
        }
    }
}
