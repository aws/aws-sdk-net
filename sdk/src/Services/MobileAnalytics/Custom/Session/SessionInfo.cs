using System;
namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Object that represnets session's information such as start time stamp, stop time stamp , unique session ID and duration.
    /// </summary>
    public class SessionInfo
    {
        public DateTime StartTimestamp { get; set; }
        public DateTime? StopTimestamp { get; set; }
        public string SessionId { get; set; }
        public long Duration { get; set; }
    }
}