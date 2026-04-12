using System;
using System.Collections.Generic;
using System.Reflection;
using Amazon.DynamoDBv2.DocumentModel;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public static class Extensions
    {
        public static IEnumerable<string> GetStoreAsEpoch(this Table table)
        {
            var property = table
                .GetType()
                .GetProperty("StoreAsEpoch", BindingFlags.Instance | BindingFlags.NonPublic);
            var storeAsEpoch = property.GetValue(table, null) as IEnumerable<string>;
            return storeAsEpoch;
        }

        public static IEnumerable<string> GetStoreAsEpochLong(this Table table)
        {
            var property = table
                .GetType()
                .GetProperty("StoreAsEpochLong", BindingFlags.Instance | BindingFlags.NonPublic);
            var storeAsEpochLong = property.GetValue(table, null) as IEnumerable<string>;
            return storeAsEpochLong;
        }
        public static TimeSpan GetAbsolute(this TimeSpan ts)
        {
            return (ts.Ticks < 0 ? -ts : ts);
        }
    }
}
