using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ClassDeclarationTests
    {
        [Test]
        public void DeclaresSimpleClass()
        {
            var compiler = new TypeScript.TypeScriptCompiler();
            var result = compiler.Compile("class Person{}");
            result.Should().Be(
@"var Person = (function () {
    function Person() { }
    return Person;
})();");
        }
    }
}
