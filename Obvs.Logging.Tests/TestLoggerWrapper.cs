using Obvs.Logging.NLog;
using Obvs.Logging.Log4Net;
using Xunit;

namespace Obvs.Logging.Tests
{
    public class TestLoggerWrapper
    {
        [Fact]
        public void ShouldUsesCorrectNameForNLog()
        {
            MyClass myClass = new MyClass(new NLogLoggerFactory());
            myClass.LogSomething();
        }
        
        [Fact]
        public void ShouldUsesCorrectNameForLog4Net()
        {
            MyClass myClass = new MyClass(new Log4NetLogFactory());
            myClass.LogSomething();
        }
    }
}
