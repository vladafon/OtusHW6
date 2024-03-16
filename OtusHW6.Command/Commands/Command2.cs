namespace OtusHW6.Command.Commands
{
    public class Command2 : ChainCommand
    {
        public Command2(ICommand next) : base(next) { }
        public Command2() : base() { }

        protected override Task ExecuteBeforeNextCommandAsync()
        {
            Console.WriteLine("Команда 2");
            return Task.CompletedTask;
        }

        protected override Task ExecuteAfterNextCommandAsync() => Task.CompletedTask;
    }
}
