using System;

namespace QiitaEntryPoint.CommandLine.Primary
{
    public class PrimaryCliCommand
    {
        public void Handle(PrimaryCliCommandArgs args)
        {
            if (args.AddDay)
            {
                Console.WriteLine($"Hello. {args.Message} by {DateTime.Today.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine(args.Message);
            }
        }
    }
}