using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;
using ThirdParty.Json.LitJson;
using System.Collections;
using System.IO;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AWSSDK_DotNet35.UnitTests.TestTools
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

        public static void CompareObjectToJson<T>(T obj, string json)
        {
            T y = JsonToObject<T>(json);
            CompareObjects<T>(obj, y);
        }

        public static void CompareObjects<T>(T x, T y)
        {
            Compare(x, y, typeof(T));
        }

        private static void Compare(object x, object y, Type type)
        {
            if (x == null && y == null)
                return;

            if ((x == null && y != null) || (x != null && y == null))
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
                xDate = xDate.Kind != DateTimeKind.Utc ? xDate.ToUniversalTime() : xDate;
                yDate = yDate.Kind != DateTimeKind.Utc ? yDate.ToUniversalTime() : yDate;

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

        public static T JsonToObject<T>(string json)
        {
            JsonReader reader = new JsonReader(json);
            var result = Unmarshall(reader, typeof(T));
            return result == null ?  default(T) : (T)result;
        }

        private static object Unmarshall(JsonReader reader, Type instanceType,object instance=null)
        {
            while (reader.Read())
            {
                var token = reader.Token;
                var value = reader.Value;

                if (token == JsonToken.ObjectStart)
                {
                    instance = Activator.CreateInstance(instanceType);
                }

                else if (token == JsonToken.PropertyName)
                {
                    var propInfo = instanceType.GetProperty((string)value,BindingFlags.IgnoreCase|BindingFlags.Public|BindingFlags.Instance);
                    
                    object childObj = null;
                    if (propInfo.PropertyType.GetInterface("System.Collections.IDictionary") != null)
                    {
                        childObj = ParseMap(reader, propInfo.PropertyType);
                    }
                    else if (propInfo.PropertyType == typeof(MemoryStream))
                    {
                        reader.Read();
                        childObj = ParseMemoryStream(reader, propInfo.PropertyType);
                    }
                    else if (
                        propInfo.DeclaringType.FullName == "Amazon.WAF.Model.ByteMatchTuple" &&
                        propInfo.Name == "TargetString")
                    {
                        reader.Read();
                        if (reader.Token == JsonToken.String)
                            childObj = Encoding.UTF8.GetString(Convert.FromBase64String((string)reader.Value));
                        else
                            throw new InvalidOperationException("Expecting a string");
                    }
                    else if (propInfo.PropertyType.BaseType.FullName == "Amazon.Runtime.ConstantClass")
                    {
                        reader.Read();
                        childObj = ParseConstant(reader, propInfo.PropertyType);
                    }
                    else if (propInfo.PropertyType == typeof(float))
                    {
                        childObj = Unmarshall(reader, propInfo.PropertyType);
                        childObj = (float)(double)childObj;
                    }
                    else
                    {
                        childObj = Unmarshall(reader, propInfo.PropertyType);
                        if (propInfo.PropertyType == typeof(DateTime))
                            childObj = ConvertToDateTime(childObj);
                    }
                    propInfo.SetValue(instance, childObj);
                }

                else if (token == JsonToken.ArrayStart)
                {
                    if (instanceType.GetInterface("System.Collections.IList") != null)
                    {                        
                        return ParseArray(reader, instanceType);
                    }                   
                }

                else if (IsPrimitiveToken(token))
                {
                    return value;
                }

                else if (token == JsonToken.ObjectEnd ||
                    token == JsonToken.Null)
                {
                    return instance;
                }
            }
            return instance;
        }

        private static object ParseConstant(JsonReader reader, Type constantType)
        {
            //reader.Read();
            if (reader.Token == JsonToken.Null)
                return null;
            else if (reader.Token == JsonToken.String)
                return Activator.CreateInstance(constantType, reader.Value);

            throw new InvalidOperationException(string.Format("Could not convert Json Token {0} to type {1}",
                reader.Token, constantType));
        }

        private static object ParseMemoryStream(JsonReader reader, Type type)
        {
            //reader.Read();
            if (reader.Token == JsonToken.Null)            
                return null;            
            else if(reader.Token == JsonToken.String)
                return new MemoryStream(Convert.FromBase64String((string)reader.Value));

            throw new InvalidOperationException(string.Format("Could not convert Json Token {0} to MemoryStream",
                reader.Token));
        }

        private static object ParseMap(JsonReader reader, Type mapType)
        {            
            var keyType = mapType.GetGenericArguments()[0];
            var valueType = mapType.GetGenericArguments()[1];
            var map = Activator.CreateInstance(mapType) as IDictionary;

            while (reader.Read())
            {
                var token = reader.Token;
                var tokenValue = reader.Value;
                object key = null, value = null;

                if (token == JsonToken.ObjectStart)
                {
                    continue;
                }
                else if (token == JsonToken.PropertyName)
                {
                    key = tokenValue;

                    reader.Read();
                    token = reader.Token;
                    tokenValue = reader.Value;
                    if (token == JsonToken.ObjectStart)
                    {
                        value = Activator.CreateInstance(valueType);
                        Unmarshall(reader, valueType, value);
                    }
                    else if (token == JsonToken.ArrayStart)
                    {
                        value = ParseArray(reader, valueType);
                    }
                    else if (IsPrimitiveToken(token))
                    {
                        if (valueType == typeof(MemoryStream))
                            value = ParseMemoryStream(reader, valueType);
                        else if (valueType.BaseType.FullName == "Amazon.Runtime.ConstantClass")
                            value = ParseConstant(reader, valueType);
                        else
                            value = tokenValue;
                    }
                    else if (token == JsonToken.Null)
                    {
                        value = null;
                    }
                    map.Add(key, value);
                }                
                else if (token == JsonToken.ObjectEnd ||
                    token == JsonToken.Null)
                {
                    return map;
                }
            }
            return map;
        }

        private static object ParseArray(JsonReader reader, Type listType)
        {            
            var itemType = listType.GetGenericArguments()[0];
            var list = Activator.CreateInstance(listType) as IList;
            while(reader.Read())
            {
                var token = reader.Token;
                var value = reader.Value;

                if (token == JsonToken.ObjectStart)
                {
                    object itemInstance = null;
                    if (itemType.GetInterface("System.Collections.IDictionary") != null)
                    {
                        itemInstance = ParseMap(reader, itemType);
                    }
                    else
                    {
                        itemInstance = Activator.CreateInstance(itemType);
                        Unmarshall(reader, itemType, itemInstance);
                    }
                    list.Add(itemInstance);
                }
                else if (IsPrimitiveToken(token))
                {
                    if (itemType == typeof(MemoryStream))                    
                        list.Add(ParseMemoryStream(reader, itemType));                    
                    else if (itemType.BaseType.FullName == "Amazon.Runtime.ConstantClass")                    
                        list.Add(ParseConstant(reader, itemType));                    
                    else
                        list.Add(value);                    
                }
                else if (token == JsonToken.ArrayEnd)
                {
                    return list;
                }
            }
            return list;
        }

        private static bool IsPrimitiveToken(JsonToken token)
        {
            return  token == JsonToken.Boolean ||
                    token == JsonToken.Double ||
                    token == JsonToken.Int ||
                    token == JsonToken.Long ||
                    token == JsonToken.String ||
                    token == JsonToken.Null;
        }

        private static object ConvertToDateTime(object value)
        {            
            if (value.GetType() == typeof(int))
                return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds((int)value);

            if (value.GetType() == typeof(double))
                return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds((double)value);

            if (value.GetType() == typeof(long))
                return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)
                .AddMilliseconds((long)value);

            throw new InvalidOperationException(string.Format("Could not convert {0} of type {1} to DateTime",
                value, value.GetType()));
        } 
    }
}
