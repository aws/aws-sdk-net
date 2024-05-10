using Amazon;
using System;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Reflection;

using System.Threading;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    public partial class General
    {
        // Reflection helpers
        public static TimeSpan IncorrectPositiveClockSkewOffset = TimeSpan.FromHours(26);
        public static TimeSpan IncorrectNegativeClockSkewOffset = TimeSpan.FromHours(-1);
        private static Func<DateTime> GetUtcNowSource()
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            return (Func<DateTime>)field.GetValue(null);
        }
        private static void SetUtcNowSource(Func<DateTime> source)
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, source);
        }
        public static void SetClockSkewCorrection(IClientConfig config, TimeSpan value)
        {
            var method = typeof(CorrectClockSkew).GetMethod("SetClockCorrectionForEndpoint", BindingFlags.Static | BindingFlags.NonPublic);
#pragma warning disable CS0618
            method.Invoke(null, new object[] { config.DetermineServiceURL(), value });
#pragma warning restore CS0618
        }
    }
}