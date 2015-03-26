using Amazon;
using Amazon.Runtime;
using System;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    /// <summary>
    /// Simple way to switch between two states with a using block.
    /// </summary>
    public class DisposableSwitch : IDisposable
    {
        private bool CallbacksSet { get; set; }
        private Action EndAction { get; set; }

        public DisposableSwitch(Action onEnd)
            : this(null, onEnd) { }
        public DisposableSwitch(Action onStart, Action onEnd)
        {
            SetCallbacks(onStart, onEnd);
        }

        protected DisposableSwitch()
        { }
        protected void SetCallbacks(Action onStart, Action onEnd)
        {
            if (CallbacksSet)
                throw new InvalidOperationException();

            if (onStart != null)
                onStart();
            EndAction = onEnd;

            CallbacksSet = true;
        }

        public void Dispose()
        {
            if (EndAction != null)
                EndAction();
        }
    }

    /// <summary>
    /// Disables SDK logging while this object is not disposed
    /// </summary>
    public class DisableLogging : DisposableSwitch
    {
        public DisableLogging()
            : base()
        {
            SetCallbacks(Disable, Enable);
        }

        private ResponseLoggingOption oldLogResponses;
        private bool oldLogMetrics;
        private LoggingOptions oldLogTo;
        private void Disable()
        {
            oldLogResponses = AWSConfigs.LoggingConfig.LogResponses;
            AWSConfigs.LoggingConfig.LogResponses = ResponseLoggingOption.Never;

            oldLogMetrics = AWSConfigs.LoggingConfig.LogMetrics;
            AWSConfigs.LoggingConfig.LogMetrics = false;

            oldLogTo = AWSConfigs.LoggingConfig.LogTo;
            AWSConfigs.LoggingConfig.LogTo = LoggingOptions.None;
        }
        private void Enable()
        {
            AWSConfigs.LoggingConfig.LogResponses = oldLogResponses;
            AWSConfigs.LoggingConfig.LogMetrics = oldLogMetrics;
            AWSConfigs.LoggingConfig.LogTo = oldLogTo;
        }
    }
}
