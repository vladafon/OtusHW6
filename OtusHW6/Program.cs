using OtusHW6.Command.Commands;

var command3 = new Command3();
var command2 = new Command2(command3);
var command1 = new Command1(command2);

await command1.ExecuteAsync();

Console.ReadKey();

