using System;

namespace Amazon.Runtime
{
    /// <summary>
    /// Abstract logger class, base for any custom/specific loggers.
    /// </summary>
    public abstract class BaseLogger
    {
        public Type DeclaringType { get; private set; }

        public bool IsEnabled { get; set; }

        public BaseLogger(Type declaringType)
        {
            DeclaringType = declaringType;
            IsEnabled = true;
        }

        #region Logging methods

        /// <summary>
        /// Flushes the logger contents.
        /// </summary>
        public abstract void Flush();

        /// <summary>
        /// Simple wrapper around the log4net IsErrorEnabled property.
        /// </summary>
        public virtual bool IsErrorEnabled { get { return true; } }

        /// <summary>
        /// Simple wrapper around the log4net IsDebugEnabled property.
        /// </summary>
        public virtual bool IsDebugEnabled { get { return true; } }

        /// <summary>
        /// Simple wrapper around the log4net IsInfoEnabled property.
        /// </summary>
        public virtual bool IsInfoEnabled { get { return true; } }

        /// <summary>
        /// Simple wrapper around the log4net Error method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public abstract void Error(Exception exception, string messageFormat, params object[] args);

        /// <summary>
        /// Simple wrapper around the log4net Debug method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public abstract void Debug(Exception exception, string messageFormat, params object[] args);

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public abstract void DebugFormat(string message, params object[] arguments);

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public abstract void InfoFormat(string message, params object[] arguments);

        #endregion
    }
}