namespace Ducks
{
    public class JetpackDuck : Duck
    {
        protected override void InitializeBehavior()
        {
            swimBehavior = new JetpackSwim();
            flyBehavior = new JetpackFly();
        }
    }
}
