using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class InsAttributes : ReactDomElementAttributes<HTMLModElement>
    {
        public string Cite { private get; set; }
        public string DateTime { private get; set; }
    }
}
