using EntryPoint;
using QiitaEntryPoint.CommandLine;

namespace QiitaEntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Cli.Execute<CliCommands>(args);
        }
    }
}
