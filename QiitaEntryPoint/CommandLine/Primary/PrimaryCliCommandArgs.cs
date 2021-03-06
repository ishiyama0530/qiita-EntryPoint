using EntryPoint;

namespace QiitaEntryPoint.CommandLine.Primary
{
    public class PrimaryCliCommandArgs : BaseCliArguments
    {
        public PrimaryCliCommandArgs() : base("Primary Command") { }

        [Required]
        [OptionParameter(ShortName: 'm',
                         LongName: "message")]
        [Help("Output message")]
        public string Message { get; set; }

        [Option(ShortName: 'd',
                LongName: "day")]
        [Help("add execute day")]
        public bool AddDay { get; set; }
    }
}