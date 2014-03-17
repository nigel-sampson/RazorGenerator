using System.Collections.Generic;
using System.IO;
using System.Web.Razor.Parser;

namespace RazorGenerator.Core
{
    public class GenerateMvcDefaultClassNames : RazorCodeTransformerBase
    {
        public override void Initialize(RazorHost razorHost, IDictionary<string, string> directives)
        {
            razorHost.DefaultNamespace = "Asp";
            razorHost.DefaultClassName = ParserHelpers.SanitizeClassName(razorHost.ProjectRelativePath);
        }
    }
}
