/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

using Amazon.Util.Internal;
using ThirdParty.RuntimeBackports;

namespace Amazon.Runtime
{
    /// <summary>
    /// Base class for constant class that holds the value that will be sent to AWS for the static constants.
    /// </summary>
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)]
    [ConstantClassComparer(ConstantClassComparerKind.OrdinalIgnoreCase)]
    public class ConstantClass
    {
        static readonly object staticFieldsLock = new object();
        static Dictionary<Type, Dictionary<string, ConstantClass>> staticFields =
            new Dictionary<Type, Dictionary<string, ConstantClass>>();

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
            return this.Intern().Value;
        }

        public string ToString(IFormatProvider provider)
        {
            return this.Intern().Value;
        }

        public static implicit operator string(ConstantClass value)
        {
            if (value == null)
                return null;
            return value.Intern().Value;
        }

        /// <summary>
        /// Attempt to find correct-cased constant value using whatever cased value the user
        /// has provided. This is primarily useful for mapping any-cased values from a CLI
        /// tool to the specific casing required by the service, avoiding the need for the
        /// user to (a) remember the specific case and (b) actually type it correctly.
        /// </summary>
        /// <returns>The properly cased service constant matching the value</returns>
        internal ConstantClass Intern()
        {
            if (!staticFields.ContainsKey(this.GetType()))
                LoadFields(this.GetType());

            var map = staticFields[this.GetType()];
            ConstantClass foundValue;
            return map.TryGetValue(this.Value, out foundValue) ? foundValue : this;
        }

        protected static T FindValue<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.PublicConstructors)] T>(string value) where T : ConstantClass
        {
            if (value == null)
                return null;

            if (!staticFields.ContainsKey(typeof(T)))
                LoadFields(typeof (T));

            var fields = staticFields[typeof(T)];
            ConstantClass foundValue;
            if (!fields.TryGetValue(value, out foundValue))
            {
                var type = typeof(T);
                var constructor = type.GetConstructor(new Type[] { typeof(string) });
                return constructor.Invoke(new object[] { value }) as T;
            }

            return foundValue as T;
        }

        private static void LoadFields([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] Type type)
        {
            if (staticFields.ContainsKey(type))
                return;

            lock (staticFieldsLock)
            {
                if (staticFields.ContainsKey(type)) return;

                var comparer = StringComparer.OrdinalIgnoreCase;
                var comparerAttr = type.GetCustomAttribute<ConstantClassComparerAttribute>();
                if (comparerAttr != null)
                {
                    comparer = GetStringComparerFromKind(comparerAttr.ComparerKind);
                }

                var map = new Dictionary<string, ConstantClass>(comparer);

                foreach (var fieldInfo in type.GetFields())
                {
                    if (fieldInfo.IsStatic && fieldInfo.FieldType == type)
                    {
                        var cc = fieldInfo.GetValue(null) as ConstantClass;
                        map[cc.Value] = cc;
                    }
                }

                // create copy of dictionary with new value
                var newDictionary = new Dictionary<Type, Dictionary<string, ConstantClass>>(staticFields);
                newDictionary[type] = map;

                // swap in the new dictionary
                staticFields = newDictionary;
            }
        }

        private static StringComparer GetStringComparerFromKind(ConstantClassComparerKind comparerKind)
        {
            switch (comparerKind)
            {
                case ConstantClassComparerKind.Ordinal:
                    return StringComparer.Ordinal;
                case ConstantClassComparerKind.OrdinalIgnoreCase:
                    return StringComparer.OrdinalIgnoreCase;
                default:
                    return StringComparer.OrdinalIgnoreCase;
            }
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                // If obj is null, return false.
                return false;
            }

            // If both are the same instance, return true.
            if (System.Object.ReferenceEquals(this, obj))
            {
                return true;
            }

            var objConstantClass = obj as ConstantClass;
            if (this.Equals(objConstantClass))
            {
                return true;
            }

            var objString = obj as string;
            if (objString != null)
            {
                return Equals(objString);
            }

            // obj is of an incompatible type, return false.
            return false;
        }

        public virtual bool Equals(ConstantClass obj)
        {
            if ((object)obj == null)
            {
                // If obj is null, return false.
                return false;
            }
            return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
        }

        protected virtual bool Equals(string value)
        {
            return StringComparer.OrdinalIgnoreCase.Equals(this.Value, value);
        }

        public static bool operator ==(ConstantClass a, ConstantClass b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                // If both are null, or both are the same instance, return true.
                return true;
            }

            if ((object)a == null)
            {
                // If either is null, return false.
                return false;
            }
            else
            {
                return a.Equals(b);
            }
        }

        public static bool operator !=(ConstantClass a, ConstantClass b)
        {
            return !(a == b);
        }

        public static bool operator ==(ConstantClass a, string b)
        {
            if ((object)a == null && b == null)
            {
                return true;
            }

            if ((object)a == null)
            {
                // If either is null, return false.
                return false;
            }
            else
            {
                return a.Equals(b);
            }
        }

        public static bool operator ==(string a, ConstantClass b)
        {
            return (b == a);
        }        

        public static bool operator !=(ConstantClass a, string b)
        {
            return !(a == b);
        }

        public static bool operator !=(string a, ConstantClass b)
        {
            return !(a == b);
        }
    }

    /// <summary>
    /// Indicates the type of <see cref="ConstantClassComparerKind"/> to use when indexing constants
    /// in a <see cref="ConstantClass"/>-derived type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ConstantClassComparerAttribute : Attribute
    {
        public ConstantClassComparerKind ComparerKind { get; }

        public ConstantClassComparerAttribute(ConstantClassComparerKind comparerKind)
        {
            ComparerKind = comparerKind;
        }
    }

    /// <summary>
    /// Specifies the kind of string comparison to use when indexing constant values
    /// in a <see cref="ConstantClass"/>-derived type.
    /// </summary>
    public enum ConstantClassComparerKind
    {
        Ordinal,
        OrdinalIgnoreCase,
    }
}
