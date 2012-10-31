using Noesis.Javascript;
using TypeScript.Properties;

namespace TypeScript
{
    public class TypeScriptCompiler
    {
        public string Compile(string jsCode)
        {
            var jsCompiler = Resources.compiler_js;
            var typeScript = Resources.typescript_js;
            string tsCode;
            string error;
            using (var context = new JavascriptContext())
            {
                context.SetParameter("jsCode", jsCode);
                context.Run(typeScript);
                context.Run(jsCompiler);
                tsCode = (string)context.GetParameter("tsCode");
                error = (string)context.GetParameter("error");
            }
            if (!string.IsNullOrWhiteSpace(error))
            {
                throw new TypeScriptCompilerException(error);
            }
            return tsCode.Trim();
        }
    }
}
