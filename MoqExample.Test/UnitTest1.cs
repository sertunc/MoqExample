using System;
using Xunit;
using Moq;
using MoqExample.Core.Interface;
using MoqExample.Core.Model;

namespace MoqExample.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mock = new Mock<IFoo>();
            mock.Setup(foo => foo.DoSomething("ping")).Returns(true);

            // out arguments
            var outString = "ack";
            
            // TryParse will return true, and the out argument will return "ack", lazy evaluated
            mock.Setup(foo => foo.TryParse("ping", out outString)).Returns(true);

            // ref arguments
            var instance = new Bar();
            // Only matches if the ref argument to the invocation is the same instance
            mock.Setup(foo => foo.Submit(ref instance)).Returns(true);

            // access invocation arguments when returning a value
            mock.Setup(x => x.DoSomethingStringy(It.IsAny<string>()))
                    .Returns((string s) => s.ToLower());
            // Multiple parameters overloads available
        }
    }
}
