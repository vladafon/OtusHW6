namespace OtusHW6.Command.Commands
{
    public class Command1 : ChainCommand
    {
        public Command1(ICommand next) : base(next) { }
        public Command1() : base() { }

        protected override Task ExecuteBeforeNextCommandAsync() => Task.CompletedTask;

        protected override Task ExecuteAfterNextCommandAsync()
        {
            Console.WriteLine("Команда 1");
            return Task.CompletedTask;
        }
    }
}
