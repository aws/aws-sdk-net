using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public static class Extensions
    {
        public static Dictionary<string, AttributeValue> MakeKey(this Table table, Document doc)
        {
            var method = table
                .GetType()
                .GetMethod("MakeKey",
                    BindingFlags.Instance | BindingFlags.NonPublic,
                    binder: null,
                    types: new[] { typeof(IDictionary<string, DynamoDBEntry>) },
                    modifiers: null);
            var key = method.Invoke(table, new[] { doc }) as Dictionary<string, AttributeValue>;
            return key;
        }
        public static Dictionary<string, AttributeValue> MakeKey<T>(this DynamoDBContext context, T item)
        {
            var doc = context.ToDocument(item);
            var table = context.GetTargetTable<T>();
            var key = table.MakeKey(doc);
            return key;
        }
        public static DynamoDBEntryConversion GetConversion(this DynamoDBContext context)
        {
            var property = context
                .GetType()
                .GetProperty("Config", BindingFlags.NonPublic | BindingFlags.Instance);
            var config = property.GetValue(context, null) as DynamoDBContextConfig;
            return config.Conversion;
        }
        public static IEnumerable<string> GetStoreAsEpoch(this Table table)
        {
            // internal IEnumerable<string> StoreAsEpoch { get; private set; }

            var property = table
                .GetType()
                .GetProperty("StoreAsEpoch", BindingFlags.Instance | BindingFlags.NonPublic);
            var storeAsEpoch = property.GetValue(table, null) as IEnumerable<string>;
            return storeAsEpoch;
        }
        public static TimeSpan GetAbsolute(this TimeSpan ts)
        {
            return (ts.Ticks < 0 ? -ts : ts);
        }
    }
}
