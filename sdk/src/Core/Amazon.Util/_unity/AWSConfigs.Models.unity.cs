using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Util
{
    #region Basic sections

    /// <summary>
    /// Proxy configuration is not implemented in Unity SDK.
    /// </summary>
    public partial class ProxyConfig
    {
        internal void Configure(ProxySection section)
        {

        }
    }

    /// <summary>
    /// Settings for logging in the SDK.
    /// </summary>
    public partial class LoggingConfig
    {
        internal void Configure(LoggingSection section)
        {
            if (section != null)
            {
                LogTo = section.LogTo;
                LogResponses = section.LogResponses;
                LogMetrics = section.LogMetrics.GetValueOrDefault(false);
                LogMetricsFormat = section.LogMetricsFormat;
                LogResponsesSizeLimit = section.LogResponsesSizeLimit.HasValue ? section.LogResponsesSizeLimit.Value : 1024;
                if (section.LogMetricsCustomFormatter != null
                    && typeof(IMetricsFormatter).IsAssignableFrom(section.LogMetricsCustomFormatter))
                {
                    LogMetricsCustomFormatter = Activator.CreateInstance(section.LogMetricsCustomFormatter) as IMetricsFormatter;
                }
            }
        }
    }

    #endregion
}
