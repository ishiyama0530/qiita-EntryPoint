using EntryPoint;
using QiitaEntryPoint.CommandLine.Primary;
using QiitaEntryPoint.CommandLine.Secondary;

namespace QiitaEntryPoint.CommandLine
{
    public class CliCommands : BaseCliCommands
    {
        [DefaultCommand]
        [Command("primary")]
        [Help("The Main command")]
        public void Primary(string[] args)
        {
            var options = Cli.Parse<PrimaryCliCommandArgs>(args);
            var command = new PrimaryCliCommand();
            command.Handle(options);
        }

        [Command("secondary")]
        [Help("The Secondary command")]
        public void Secondary(string[] args)
        {
            var command = new SecondaryCliCommand();
            command.Handle();
        }
    }
}