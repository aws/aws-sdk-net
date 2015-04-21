using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    /// <summary>
    /// This class instantiates an object of the passed in type. It will also set values for all the properties 
    /// and create and fill lists and maps.
    /// 
    /// The class should always return back the same object for the same object definition. This make debugging 
    /// more predictable.
    /// </summary>
    public class InstantiateClassGenerator
    {
        public static T Execute<T>()
            where T : new()
        {
            var type = typeof(T);
            var result = Execute(type);
            var rootObject = (T)result;
            return rootObject;
        }

        public static object Execute(Type type)
        {
            var rootObject = Activator.CreateInstance(type);
            TypeCircularReference<Type> tcr = new TypeCircularReference<Type>();
            InstantiateProperties(tcr, rootObject);
            return rootObject;
        }

        private static void InstantiateProperties(TypeCircularReference<Type> tcr, object owningObject)
        {
            foreach (var info in owningObject.GetType().GetProperties())
            {
                if (info.SetMethod == null)
                    continue;

                var type = info.PropertyType;
                var propertyValue = InstantiateType(tcr, type);
                info.SetMethod.Invoke(owningObject, new object[] { propertyValue });
            }
        }

        private static object InstantiateType(TypeCircularReference<Type> tcr, Type type)
        {
            bool pushed = false;
            if (!type.FullName.StartsWith("System"))
            {
                pushed = tcr.Push(type);
                if (!pushed)
                    return null;
            }

            try
            {
                if (type == typeof(string))
                {
                    return "Test_Value";
                }
                else if (type == typeof(bool))
                {
                    return true;
                }
                else if (type == typeof(int))
                {
                    return int.MaxValue;
                }
                else if (type == typeof(long))
                {
                    return long.MaxValue;
                }
                else if (type == typeof(double))
                {
                    return double.MaxValue;
                }
                else if (type == typeof(DateTime))
                {
                    return Constants.DEFAULT_DATE;
                }
                else if (type == typeof(MemoryStream))
                {
                    return new MemoryStream(Constants.DEFAULT_BLOB);
                }
                //else if (type == typeof(Amazon.S3.S3Region))
                //{
                //    return Amazon.S3.S3Region.USW2; // S3 bucket region
                //}
                else if (type.BaseType.FullName == "Amazon.Runtime.ConstantClass")
                {
                    var value = type.GetFields()[0].GetValue(null);
                    return value;
                }
                else if (type == typeof(Stream))
                {
                    return new MemoryStream(Constants.DEFAULT_BLOB);
                }
                else if (type.BaseType.FullName == "System.MulticastDelegate")
                {
                    return null; // Event Handlers
                }
                //else if (type.IsAssignableFrom(typeof(TimeSpan?)))
                //{
                //    return TimeSpan.FromHours(1); // S3 request timeout
                //}
                //else if (type == typeof(Amazon.S3.Model.ByteRange))
                //{
                //    return null; // s3 byte range
                //}
                //else if (type == typeof(Amazon.S3.Model.HeadersCollection))
                //{
                //    return null;
                //}
                //else if (type == typeof(Amazon.S3.Model.MetadataCollection))
                //{
                //    return null;
                //}
                else
                {
                    var value = Activator.CreateInstance(type);
                    if (type.GetInterface("System.Collections.IList") != null)
                    {
                        var list = value as System.Collections.IList;
                        var listType = type.GenericTypeArguments[0];
                        if (!tcr.Contains(listType))
                        {
                            // Add some variability to the length to the array 
                            for (int i = 0; i < (1 + listType.FullName.Length % 5); i++)
                            {
                                list.Add(InstantiateType(tcr, listType));
                            }
                        }
                    }
                    else if (type.GetInterface("System.Collections.IDictionary") != null)
                    {
                        var map = value as System.Collections.IDictionary;
                        var valueType = type.GenericTypeArguments[1];
                        if (!tcr.Contains(valueType))
                        {
                            // Add some variability to the length to the array 
                            for (int i = 0; i < (1 + valueType.FullName.Length % 5); i++)
                            {
                                map.Add("key" + i, InstantiateType(tcr, valueType));
                            }
                        }
                    }
                    else
                    {
                        InstantiateProperties(tcr, value);
                    }

                    return value;
                }
            }
            finally
            {
                if (pushed)
                    tcr.Pop();
            }
        }

        public static void ValidateObjectFullyInstantiated(object owningObject)
        {
            Assert.IsNotNull(owningObject, "Root object null");

            var owningType = owningObject.GetType();
            foreach (var info in owningType.GetProperties())
            {
                if (info.SetMethod == null || info.Name == "ContentLength")
                    continue;

                var type = info.PropertyType;
                var propertyValue = info.GetMethod.Invoke(owningObject, new object[] { });

                if (owningObject.GetType() == typeof(Amazon.Glacier.Model.GetJobOutputResponse) ||
                    owningObject.GetType() == typeof(Amazon.Lambda.Model.InvokeAsyncResponse) ||
                    owningObject.GetType() == typeof(Amazon.Lambda.Model.InvokeResponse)) 
                {
                    if (info.Name == "Status" ||
                        info.Name == "StatusCode")
                    {
						// Special case for GetJobOutputResponse.Status property which is unmarshalled from 
						// HttpResponse's Status code.
                        Assert.AreEqual(200, propertyValue);
                        continue;
                    }
                }

                ValidatePropertyValueInstantiated(type, propertyValue, info.Name);
            }
        }

        private static void ValidatePropertyValueInstantiated(Type type, object propertyValue, string propertyName)
        {
            if (type == typeof(string))
            {
                Assert.IsTrue(propertyValue is string, "Invalid value for " + propertyName);
                Assert.IsTrue(((string)propertyValue).Length > 0, "Invalid value for " + propertyName);
            }
            else if (type == typeof(bool))
            {
                Assert.IsTrue(propertyValue is bool, "Invalid value for " + propertyName);
                Assert.IsTrue(((bool)propertyValue), "Invalid value for " + propertyName);
            }
            else if (type == typeof(int))
            {
                Assert.IsTrue(propertyValue is int, "Invalid value for " + propertyName);
                Assert.AreEqual(((int)propertyValue), int.MaxValue, "Invalid value for " + propertyName);
            }
            else if (type == typeof(long))
            {
                Assert.IsTrue(propertyValue is long, "Invalid value for " + propertyName);
                Assert.AreEqual(((long)propertyValue), long.MaxValue, "Invalid value for " + propertyName);
            }
            else if (type == typeof(double))
            {
                Assert.IsTrue(propertyValue is double, "Invalid value for " + propertyName);
                Assert.AreEqual(((double)propertyValue), double.MaxValue, "Invalid value for " + propertyName);
            }
            else if (type == typeof(DateTime))
            {
                Assert.IsTrue(propertyValue is DateTime, "Invalid value for " + propertyName);
                Assert.AreEqual(((DateTime)propertyValue).ToUniversalTime(), Constants.DEFAULT_DATE.ToUniversalTime(), "Invalid value for " + propertyName);
            }                
            else if (type == typeof(MemoryStream))
            {
                Assert.IsTrue(propertyValue is MemoryStream, "Invalid value for " + propertyName);
                Assert.IsTrue(((MemoryStream)propertyValue).Length > 0, "Invalid value for " + propertyName);
            }
            else if (type == typeof(Stream))
            {
                Assert.IsTrue(propertyValue is Stream, "Invalid value for " + propertyName);
                Assert.IsTrue(((Stream)propertyValue).Length > 0, "Invalid value for " + propertyName);
            }
            else if (type.BaseType.FullName == "Amazon.Runtime.ConstantClass")
            {
                Assert.IsTrue(propertyValue is Amazon.Runtime.ConstantClass, "Invalid value for " + propertyName);
            }
            else
            {                   
                if (type.GetInterface("System.Collections.IList") != null)
                {
                    var list = propertyValue as System.Collections.IList;

                    var listType = type.GenericTypeArguments[0];
                    foreach(var item in list)
                    {
                        ValidatePropertyValueInstantiated(listType, item, propertyValue + "_Dictionary");
                    }
                }
                else if (type.GetInterface("System.Collections.IDictionary") != null)
                {
                    var map = propertyValue as System.Collections.IDictionary;

                    var valueType = type.GenericTypeArguments[1];
                    foreach(var key in map.Keys)
                    {
                        ValidatePropertyValueInstantiated(valueType, map[key], propertyValue + "_Dictionary");
                    }
                }
                else
                {                    
                    ValidateObjectFullyInstantiated(propertyValue);
                }
            }
        }
    }
}
