namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// Amazon mobile analytics background runner.
    /// Background runner periodically sends events to server.
    /// </summary>
    public class MobileAnalyticsUtil
    {
        public static string AppDataPath
        {
            get 
            {
#if BCL45
                return "";
#elif BCL35
                return "";
#elif PCL
                return "";
#endif
            }
        }
    }

}