/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// Base class for constant class that holds the value that will be sent to AWS for the static constants.
    /// </summary>
    public class ConstantClass
    {
        static Dictionary<Type, Dictionary<string, ConstantClass>> staticFields = new Dictionary<Type, Dictionary<string, ConstantClass>>();

        protected ConstantClass(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value that needs to be used when send the value to AWS
        /// </summary>
        public string Value
        {
            get;
            private set;
        }


        public override string ToString()
        {
            return this.Value;
        }

        public string ToString(IFormatProvider provider)
        {
            return this.Value;
        }

        public static implicit operator string(ConstantClass value)
        {
            if (value == null)
                return null;
            return value.Value;
        }

        protected static T FindValue<T>(string value) where T : ConstantClass
        {
            if (!staticFields.ContainsKey(typeof(T)))
            {
                lock (staticFields)
                {
                    if (!staticFields.ContainsKey(typeof(T)))
                    {
                        Dictionary<string, ConstantClass> map = new Dictionary<string, ConstantClass>();

                        var typeInfo = TypeFactory.GetTypeInfo(typeof(T));
                        foreach (var fieldInfo in typeInfo.GetFields())
                        {
                            if (fieldInfo.IsStatic && fieldInfo.FieldType == typeof(T))
                            {
                                var cc = fieldInfo.GetValue(null) as ConstantClass;
                                map[cc.Value] = cc;
                            }
                        }

                        staticFields[typeof(T)] = map;
                    }
                }
            }

            var fields = staticFields[typeof(T)];
            ConstantClass foundValue;
            if (!fields.TryGetValue(value, out foundValue))
            {
                var typeInfo = TypeFactory.GetTypeInfo(typeof(T));
                var constructor = typeInfo.GetConstructor(new ITypeInfo[] { TypeFactory.GetTypeInfo(typeof(string)) });
                return constructor.Invoke(new object[] { value }) as T;
            }

            return foundValue as T;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj is string)
            {
                return string.Equals(this.Value, (string)obj);
            }

            return string.Equals(this.Value, ((ConstantClass)obj).Value);
        }
    }
}
