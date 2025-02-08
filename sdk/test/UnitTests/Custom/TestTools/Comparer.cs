using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;
using System.Text.Json;
using System.Collections;
using System.IO;
using Amazon.Runtime.Documents;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator;
using System.Collections.ObjectModel;
using Amazon;
using AWSSDK.UnitTests;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    public class Comparer
    {
        //static long ConvertToLong(int input)
        //{
        //    return (long)input;
        //}
        
        //static MemoryStream ConvertToMemoryStream(string input)
        //{
        //    var output = new MemoryStream(Convert.FromBase64String(input));
        //    return output;
        //}

        public static HashSet<string> propertiesToIgnore = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Amazon.DynamoDBv2.Model.AttributeValue.IsBOOLSet",
            "Amazon.DynamoDBv2.Model.AttributeValue.IsLSet",
            "Amazon.DynamoDBv2.Model.AttributeValue.IsMSet",
        };

        public static void CompareObjects<T>(T x, T y)
        {
            Compare(x, y, typeof(T));
        }

        private static void Compare(object x, object y, Type type)
        {
            if (x == null && y == null)
                return;

            if (!AWSConfigs.InitializeCollections && x != null && type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICollection<>)))
            {
                var expectedCollection = (ICollection)x;
                var actualCollection = (ICollection)y;
                if (expectedCollection.Count == 0 && actualCollection == null)
                    return;
            }

            if (x == null ^ y == null)
                Assert.Fail("Either x or y is null. x={0} y={1}", x, y);


            if (type.IsPrimitive)
                Assert.IsTrue(x.Equals(y), "x is not equal to y. x={0} y={1}",x,y);

            if (type == typeof(string))
            {
                Assert.IsTrue(x.Equals(y), "x is not equal to y. x={0} y={1}", x, y);
                return;
            }

            if (type == typeof(DateTime))
            {
                var xDate = (DateTime)x;
                var yDate = (DateTime)y;
                xDate = xDate.Kind != DateTimeKind.Utc ? throw new Exception("xDate DateTime Kind is not UTC") : xDate;
                yDate = yDate.Kind != DateTimeKind.Utc ? throw new Exception("yDate DateTime Kind is not UTC") : yDate;

                Assert.IsTrue(xDate.Equals(yDate), "x is not equal to y. x={0} y={1}", xDate, yDate);
                return;
            }

            if (type == typeof(MemoryStream))
            {
                var xStream = x as MemoryStream;
                var yStream = y as MemoryStream;
                Compare(FromMemoryStream(xStream), FromMemoryStream(yStream), typeof(string));
                return;
            }

            if (type.GetInterface("System.Collections.IList") != null)
            {
                var listType = type.GenericTypeArguments[0];
                var listX = x as IList;
                var listY = y as IList;

                if (listX.Count != listY.Count)
                    Assert.Fail("Lists do not contain same number of elements. x count={0}  y count={1}",
                        listX.Count, listY.Count);

                for (int i = 0; i < listX.Count; i++)
                {
                    Compare(listX[i], listY[i], listType);            
                }
                return;
            }

            if (type.GetInterface("System.Collections.IDictionary") != null)
            {
                var valueType = type.GenericTypeArguments[1];
                var mapX = x as IDictionary;
                var mapY = y as IDictionary;

                if (mapX.Count != mapY.Count)
                    Assert.Fail("Dictionaries do not contain same number of elements. x count={0}  y count={1}",
                        mapX.Count, mapY.Count);

                foreach (var keyX in mapX.Keys)
                {
                    Compare(mapX[keyX], mapY[keyX], valueType);
                        
                }
                return;
            }

            foreach (var propInfo in type.GetProperties())
            {
                var fullName = propInfo.DeclaringType.FullName + "." + propInfo.Name;
                if (propertiesToIgnore.Contains(fullName))
                    continue;

                var propType = propInfo.PropertyType;
                var a = propInfo.GetValue(x);
                var b = propInfo.GetValue(y);
                Compare(a, b, propType);
            }
            return;
        }

        static string FromMemoryStream(MemoryStream value)
        {
            return Convert.ToBase64String(value.ToArray());
        }
    }
}
