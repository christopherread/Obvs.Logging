using Serilog.Core;

namespace Obvs.Logging.Serilog
{
    public class SerilogLoggerFactory : ILoggerFactory
    {
        public ILogger Create(string name)
        {
            return new SerilogLoggerWrapper(global::Serilog.Log.ForContext("SourceContext", name));
        }

        public ILogger Create<T>()
        {
            return new SerilogLoggerWrapper(global::Serilog.Log.ForContext<T>());
        }
    }
}