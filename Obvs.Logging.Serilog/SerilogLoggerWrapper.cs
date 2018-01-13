using System;
using Serilog.Core;

namespace Obvs.Logging.Serilog
{
    public class SerilogLoggerWrapper : ILogger
    {
        private readonly global::Serilog.ILogger _logger;

        public SerilogLoggerWrapper(global::Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void Debug(string message, Exception exception = null)
        {
            if (exception == null)
            {
                _logger.Debug(message);
            }
            else
            {
                _logger.Debug(exception, message);
            }
        }

        public void Info(string message, Exception exception = null)
        {
            if (exception == null)
            {
                _logger.Information(message);
            }
            else
            {
                _logger.Information(exception, message);
            }
        }

        public void Warn(string message, Exception exception = null)
        {
            if (exception == null)
            {
                _logger.Warning(message);
            }
            else
            {
                _logger.Warning(exception, message);
            }
        }

        public void Error(string message, Exception exception = null)
        {
            if (exception == null)
            {
                _logger.Error(message);
            }
            else
            {
                _logger.Error(exception, message);
            }
        }

        public void Log(LogLevel level, string message, Exception exception = null)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    Debug(message, exception);
                    break;
                case LogLevel.Info:
                    Info(message, exception);
                    break;
                case LogLevel.Warn:
                    Warn(message, exception);
                    break;
                case LogLevel.Error:
                    Error(message, exception);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("level", level, null);
            }
        }
    }
}
