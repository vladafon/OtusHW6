namespace OtusHW6.Command
{
    public abstract class ChainCommand : ICommand
    {
        ICommand _next;
        public ChainCommand(ICommand next) => _next = next;
        public ChainCommand() => _next = new FinishCommand();

        public async Task ExecuteAsync()
        {
            await ExecuteBeforeNextCommandAsync();
            await _next.ExecuteAsync();
            await ExecuteAfterNextCommandAsync();
        }

        protected abstract Task ExecuteBeforeNextCommandAsync();
        protected abstract Task ExecuteAfterNextCommandAsync();
    }
}
