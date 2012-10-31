using FluentAssertions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TypeScriptPlayExampleScriptTests
    {
        [Test]
        public void PlayScriptCompiles()
        {
            var compiler = new TypeScript.TypeScriptCompiler();
            var result = compiler.Compile(@"class Greeter {
	greeting: string;
	constructor (message: string) {
		this.greeting = message;
	}
	greet() {
		return ""Hello, "" + this.greeting;
	}
}   

var greeter = new Greeter(""world"");

var button = document.createElement('button')
button.innerText =""Say Hello""
button.onclick = function() {
	alert(greeter.greet())
}

document.body.appendChild(button)");

            result.Should().Be(
@"var Greeter = (function () {
    function Greeter(message) {
        this.greeting = message;
    }
    Greeter.prototype.greet = function () {
        return ""Hello, "" + this.greeting;
    };
    return Greeter;
})();
var greeter = new Greeter(""world"");
var button = document.createElement('button');
button.innerText = ""Say Hello"";
button.onclick = function () {
    alert(greeter.greet());
};
document.body.appendChild(button);");
        }
    }
}
