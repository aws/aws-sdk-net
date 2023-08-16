/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK.Benchmarks
{
    internal class TypeCircularReference<T>
    {
        Stack<T> stack = new Stack<T>();
        HashSet<T> hash = new HashSet<T>();

        public bool Push(T type)
        {
            if (hash.Contains(type))
                return false;

            stack.Push(type);
            hash.Add(type);


            return true;
        }

        public void Pop()
        {
            var type = stack.Pop();
            hash.Remove(type);
        }

        public bool Contains(T type)
        {
            return hash.Contains(type);
        }
    }

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
                var propertyValue = string.Equals(info.Name, "AccountId") ? "0123456789" : InstantiateType(tcr, type);
                info.SetMethod.Invoke(owningObject, new object[] { propertyValue });
            }
        }

        private static object InstantiateType(TypeCircularReference<Type> tcr, Type type)
        {
            bool pushed = false;
            if (!type.FullName.StartsWith("System."))
            {
                pushed = tcr.Push(type);
                if (!pushed)
                    return null;
            }

            try
            {
                if (type == typeof(string))
                {
                    return "%2FTest-Value/~.$\\&*value";
                }
                else if (type == typeof(bool) || type == typeof(bool?))
                {
                    return true;
                }
                else if (type == typeof(int) || type == typeof(int?))
                {
                    return int.MaxValue;
                }
                else if (type == typeof(long) || type == typeof(long?))
                {
                    return long.MaxValue;
                }
                else if (type == typeof(double) || type == typeof(double?))
                {
                    return double.MaxValue;
                }
                else if (type == typeof(DateTime) || type == typeof(DateTime?))
                {
                    return Constants.DefaultDate;
                }
                else if (type == typeof(MemoryStream))
                {
                    return new MemoryStream(Constants.DefaultBlob);
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
                    return new MemoryStream(Constants.DefaultBlob);
                }
                else if (type.BaseType.FullName == "System.MulticastDelegate")
                {
                    return null; // Event Handlers
                }
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
    }
}

