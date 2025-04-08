namespace Ducks
{
    public class AverageDuck : Duck
    {
        protected override void InitializeBehavior()
        {
            swimBehavior = new DefaultSwim();
            flyBehavior = new DefaultFly();
        }
    }
}
