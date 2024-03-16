namespace OtusHW6.Command.Commands
{
    public class Command3 : ChainCommand
    {
        public Command3(ICommand next) : base(next) { }
        public Command3() : base() { }

        protected override Task ExecuteBeforeNextCommandAsync()
        {
            Console.WriteLine("Команда 3");
            return Task.CompletedTask;
        }

        protected override Task ExecuteAfterNextCommandAsync() => Task.CompletedTask;
    }
}
