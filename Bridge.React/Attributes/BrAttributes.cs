using Bridge.Html5;

namespace Bridge.React
{
    [ObjectLiteral]
    public sealed class BrAttributes : ReactDomElementAttributes<HTMLBRElement>
    {
        public string Clear { private get; set; }
    }
}
