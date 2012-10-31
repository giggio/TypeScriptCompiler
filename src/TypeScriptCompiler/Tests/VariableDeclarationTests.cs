using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class VariableDeclarationTests
    {
        [Test]
        public void DeclaresNumber()
        {
            var compiler = new TypeScript.TypeScriptCompiler();
            var result = compiler.Compile("var a = 1;");
            result.Should().Be("var a = 1;");
        }
    }
}
