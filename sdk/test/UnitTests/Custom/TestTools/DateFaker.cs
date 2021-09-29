using System;
using System.Reflection;
using Amazon;
	 
namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    public static class DateFaker
    {
        public static void Run(DateTime fakeDate, Action action)
        {
            SetUtcNowSource(() => fakeDate);
	 
            try
            {
                action();
            }
            finally
            {
                SetUtcNowSource(() => DateTime.UtcNow);
            }
        }
	 
        private static void SetUtcNowSource(Func<DateTime> source)
        {
            var field = typeof(AWSConfigs).GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);
            field.SetValue(null, source);
        }
    }
}