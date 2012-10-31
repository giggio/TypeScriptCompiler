using FluentAssertions;
using NUnit.Framework;
using Noesis.Javascript;

namespace Tests
{
    [TestFixture]
    public class GetsSimpleStrings
    {
        [Test]
        public void ReturnHello()
        {
            using (var context = new JavascriptContext())
            {
                const string script = @"var str = 'hello';";

                context.Run(script);
                var result = context.GetParameter("str");

                result.Should().Be("hello");
            }
        }
        [Test]
        public void SimpleSumWithParam()
        {
            using (var context = new JavascriptContext())
            {
                context.SetParameter("a", 1);
                context.SetParameter("b", 2);
                const string script = @"var sum = a + b;";
                context.Run(script);
                var result = (int)context.GetParameter("sum");
                result.Should().Be(3);
            }
        }
    }
}
