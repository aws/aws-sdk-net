using System;
using System.Reflection;
using Amazon;
	 
namespace AWSSDK_DotNet.UnitTests.TestTools
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

    public class AWSConfigsDateFaker : IDisposable
    {
        private readonly FieldInfo _awsConfigsUtcNowSourceField;
        public AWSConfigsDateFaker(Func<DateTime> currentDateTimeFunc)
        {
            _awsConfigsUtcNowSourceField = 
                typeof(AWSConfigs)
                    .GetField("utcNowSource", BindingFlags.Static | BindingFlags.NonPublic);

            _awsConfigsUtcNowSourceField.SetValue(null, currentDateTimeFunc);
        }

        public void Dispose()
        {
            _awsConfigsUtcNowSourceField.SetValue(null, new Func<DateTime>(() => DateTime.UtcNow));
        }
    }
}