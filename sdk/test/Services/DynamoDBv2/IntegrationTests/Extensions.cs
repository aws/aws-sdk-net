using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Utils;

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

        /// <summary>
        /// Re-runs an eventually consistent read (for example a GSI query) until it returns the expected number of items.
        /// </summary>
        public static async Task<List<T>> WaitForItemsAsync<T>(Func<Task<List<T>>> load, int count)
        {
            List<T> items = null;
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                items = await load();
                return items.Count == count;
            }, sleepSeconds: 1, maxWaitSeconds: 30);
            return items;
        }
    }
}
