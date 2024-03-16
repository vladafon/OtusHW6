namespace OtusHW6.Command
{
    public class FinishCommand : ICommand
    {
        public Task ExecuteAsync() => Task.CompletedTask;
    }
}
