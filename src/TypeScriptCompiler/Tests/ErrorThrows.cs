using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ErrorThrows
    {
        [Test]
        public void Throws()
        {
            var compiler = new TypeScript.TypeScriptCompiler();
            try
            {
                compiler.Compile("var a = ;");
                Assert.Fail("Compilation did not fail.");
            }
            catch (TypeScript.TypeScriptCompilerException exception)
            {
                exception.Message.Should().Be("Compilation error: Check format of expression term\nCode block: 1\nStart position: 8\nLength: 1");
            }
        }
    }
}