﻿/*
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
using System.Linq;
using System.Reflection;
using System.Text;

using Amazon.Util.Internal;
using System.Globalization;
using System.Collections;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
#if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(Amazon.DynamoDBv2.Custom.Internal.InternalConstants.RequiresUnreferencedCodeMessage)]
#endif
    internal static class Utils
    {
        private static readonly Type[] EmptyTypes = new Type[0];

        #region Type methods

        private static readonly Type[] primitiveTypesArray = new Type[]
        {
            typeof(Boolean),
            typeof(Byte),
            typeof(Char),
            typeof(DateTime),
            typeof(Decimal),
            typeof(Double),
            typeof(int),
            typeof(long),
            typeof(SByte),
            typeof(short),
            typeof(Single),
            typeof(String),
            typeof(uint),
            typeof(ulong),
            typeof(ushort),
            typeof(Guid),
            typeof(byte[]),
            typeof(MemoryStream),
            typeof(Primitive)
        };

        public static readonly IEnumerable<Type> PrimitiveTypes = new HashSet<Type>(primitiveTypesArray);

        public static bool IsPrimitive(Type type)
        {
            return PrimitiveTypes.Any(ti => type.IsAssignableFrom(ti));
        }
        public static bool IsPrimitive<T>()
        {
            return IsPrimitive(typeof(T));
        }
        public static void ValidatePrimitiveType(Type type)
        {
            if (!Utils.IsPrimitive(type))
                throw new InvalidCastException(string.Format(CultureInfo.InvariantCulture,
                    "{0} is not a supported Primitive type", type.FullName));
        }
        public static void ValidatePrimitiveType<T>()
        {
            ValidatePrimitiveType(typeof(T));
        }

        public static void ValidateVersionType(Type memberType)
        {
            if (memberType.IsGenericType && memberType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                (memberType.IsAssignableFrom(typeof(Byte)) ||
                memberType.IsAssignableFrom(typeof(SByte)) ||
                memberType.IsAssignableFrom(typeof(int)) ||
                memberType.IsAssignableFrom(typeof(uint)) ||
                memberType.IsAssignableFrom(typeof(long)) ||
                memberType.IsAssignableFrom(typeof(ulong)) ||
                memberType.IsAssignableFrom(typeof(short)) ||
                memberType.IsAssignableFrom(typeof(ushort))))
            {
                return;
            }
            throw new InvalidOperationException("Version property must be of primitive, numeric, integer, nullable type (e.g. int?, long?, byte?)");
        }

        public static Type GetPrimitiveElementType(Type collectionType)
        {
            var elementType = Utils.GetElementType(collectionType);

            if (elementType != null)
            {
                Utils.ValidatePrimitiveType(elementType);
                return elementType;
            }

            throw new InvalidOperationException("Unable to determine element type");
        }
        public static Type GetElementType(Type collectionType)
        {
            var elementType = collectionType.GetElementType();

            if (elementType == null)
            {
                var genericArguments = collectionType.GetGenericArguments();
                if (genericArguments != null && genericArguments.Length == 1)
                    elementType = genericArguments[0];
            }

            // elementType may be null at this point, meaning that the collectionType isn't a collectionType
            return elementType;
        }

        public static bool ItemsToCollection(Type targetType, IEnumerable<object> items, out object result)
        {
            return targetType.IsArray ?
                ItemsToArray(targetType, items, out result):  //targetType is Array
                ItemsToIList(targetType, items, out result);  //targetType is IList or has Add method.
        }

        private static bool ItemsToIList(Type targetType, IEnumerable<object> items, out object result)
        {
            result = Utils.Instantiate(targetType);

            var ilist = result as IList;
            if (ilist != null)
            {
                foreach (var item in items)
                    ilist.Add(item);
                return true;
            }

            var addMethod = targetType.GetMethod("Add");
            if (addMethod != null)
            {
                foreach (var item in items)
                    addMethod.Invoke(result, new object[] { item });
                return true;
            }

            result = null;
            return false;
        }

        private static bool ItemsToArray(Type targetType, IEnumerable<object> items, out object result)
        {
            var itemlist = items.ToList();
            var array = (Array)InstantiateArray(targetType, itemlist.Count);

            for (int i = 0; i < itemlist.Count; i++)
            {
                var item = itemlist[i];
                array.SetValue(item, i);
            }
            result = array;
            return true;
        }

        #endregion

        #region Attribute methods

        public static DynamoDBTableAttribute GetTableAttribute(Type targetType)
        {
            DynamoDBTableAttribute tableAttribute = GetAttribute(targetType) as DynamoDBTableAttribute;
            if (tableAttribute == null)
                return null;
            return tableAttribute;
        }

        public static DynamoDBAttribute GetAttribute(Type targetType)
        {
            if (targetType == null) throw new ArgumentNullException("targetType");
            object[] attributes = targetType.GetCustomAttributes(typeof(DynamoDBAttribute), true);
            return GetSingleDDBAttribute(attributes);
        }
        public static DynamoDBAttribute GetAttribute(MemberInfo targetMemberInfo)
        {
            object[] attributes = GetAttributeObjects(targetMemberInfo);
            return GetSingleDDBAttribute(attributes);
        }
        public static List<DynamoDBAttribute> GetAttributes(MemberInfo targetMemberInfo)
        {
            object[] attObjects = GetAttributeObjects(targetMemberInfo) ?? new object[0];
            var attributes = new List<DynamoDBAttribute>();
            foreach (var attObj in attObjects)
            {
                var attribute = attObj as DynamoDBAttribute;
                if (attribute != null)
                    attributes.Add(attribute);
            }
            return attributes;
        }

        private static DynamoDBAttribute GetSingleDDBAttribute(object[] attributes)
        {
            if (attributes.Length == 0)
                return null;
            if (attributes.Length == 1)
                return (attributes[0] as DynamoDBAttribute);
            throw new InvalidOperationException("Cannot have multiple DynamoDBAttributes on a single member");
        }

        private static object[] GetAttributeObjects(MemberInfo targetMemberInfo)
        {
            if (targetMemberInfo == null) throw new ArgumentNullException("targetMemberInfo");
#if NETSTANDARD
            object[] attributes = CustomAttributeExtensions.GetCustomAttributes(targetMemberInfo, typeof(DynamoDBAttribute), true).ToArray<object>();
#else
            object[] attributes = Attribute.GetCustomAttributes(targetMemberInfo, typeof(DynamoDBAttribute), true).ToArray<object>();
#endif
            return attributes;
        }

        #endregion

        #region Non-DynamoDB utilities

        public static string ToLowerCamelCase(string value)
        {
            if (string.IsNullOrEmpty(value) || char.IsLower(value[0])) return value;
            StringBuilder sb = new StringBuilder(value);
            sb[0] = char.ToLowerInvariant(sb[0]);
            return sb.ToString();
        }

        private static Type[][] validConstructorInputs = new Type[][]
        {
            EmptyTypes,
        };
        private static Type[][] validArrayConstructorInputs = new Type[][]
        {
            //supports one dimension Array only
            new Type[] { typeof(int) } 
        };
        private static Type[][] validConverterConstructorInputs = new Type[][]
        {
            EmptyTypes,
            new Type[] { typeof(DynamoDBContext) }
        };

        public static object InstantiateConverter(Type objectType, IDynamoDBContext context)
        {
            return InstantiateHelper(objectType, validConverterConstructorInputs, new object[] { context });
        }
        public static object InstantiateArray(Type objectType,int length)
        {
            return InstantiateHelper(objectType, validArrayConstructorInputs, new object[] { length });
        }
        public static object Instantiate(Type objectType)
        {
            return InstantiateHelper(objectType, validConstructorInputs, null);
        }
        private static object InstantiateHelper(Type objectType, Type[][] validConstructorInputs, object[] optionalInput = null)
        {
            if (objectType == null)
                throw new ArgumentNullException("objectType");
            if (!CanInstantiateHelper(objectType, validConstructorInputs))
                throw new InvalidOperationException("Cannot instantiate type " + objectType.FullName);

            var constructors = GetConstructors(objectType, validConstructorInputs).ToList();

            if (constructors != null && constructors.Count > 0)
            {
                foreach (var constructor in constructors)
                {
                    var inputs = constructor.GetParameters();
                    object[] constructorParameters = inputs.Length == 0 ?
                        null : optionalInput;
                    object instance = constructor.Invoke(constructorParameters);
                    return instance;
                }
            }

            throw new InvalidOperationException("Unable to find valid constructor for type " + objectType.FullName);
        }
        private static IEnumerable<ConstructorInfo> GetConstructors(Type typeInfo, Type[][] validConstructorInputs)
        {
            foreach(var inputTypes in validConstructorInputs)
            {
                var constructor = typeInfo.GetConstructor(inputTypes);
                if (constructor != null)
                    yield return constructor;
            }
        }

        public static bool CanInstantiate(Type objectType)
        {
            return CanInstantiateHelper(objectType, validConstructorInputs);
        }
        public static bool CanInstantiateArray(Type objectType)
        {
            return objectType.IsArray && CanInstantiateHelper(objectType, validArrayConstructorInputs);
        }
        public static bool CanInstantiateConverter(Type objectType)
        {
            return CanInstantiateHelper(objectType, validConverterConstructorInputs);
        }
        private static bool CanInstantiateHelper(Type objectType, Type[][] validConstructorInputs)
        {
            var objectTypeWrapper = objectType;

            bool candidate =
                //objectType.IsPublic &&
                objectTypeWrapper.IsClass &&
                !objectTypeWrapper.IsInterface &&
                !objectTypeWrapper.IsAbstract &&
                !objectTypeWrapper.IsGenericTypeDefinition &&
                !objectTypeWrapper.ContainsGenericParameters;

            if (!candidate)
                return false;

            // check valid constructor inputs
            var constructors = GetConstructors(objectTypeWrapper, validConstructorInputs).ToList();
            if (constructors.Count == 0)
                return false;

            return true;
        }
        public static Type GetType(MemberInfo member)
        {
            var pi = member as PropertyInfo;
            var fi = member as FieldInfo;
            if (pi == null && fi == null)
                throw new ArgumentOutOfRangeException("member", "member must be of type PropertyInfo or FieldInfo");

            return (pi != null ? pi.PropertyType : fi.FieldType);
        }
        public static bool IsReadWrite(MemberInfo member)
        {
            PropertyInfo property = member as PropertyInfo;
            FieldInfo field = member as FieldInfo;

            if (property != null)
            {
                return (property.CanRead && property.CanWrite);
            }
            else if (field != null)
            {
                return (field.IsPublic && !field.IsLiteral && !field.IsInitOnly);
            }
            else
            {
                throw new ArgumentOutOfRangeException("member", "Member must be FieldInfo or PropertyInfo");
            }
        }
        public static bool ImplementsInterface(Type targetType, Type interfaceType)
        {
            if (!interfaceType.IsInterface)
                throw new ArgumentOutOfRangeException("interfaceType", "Type is not an interface");

            foreach (var inter in targetType.GetInterfaces())
            {
                if (InternalSDKUtils.AreTypesEqual(inter, interfaceType))
                    return true;
                if (inter.IsGenericTypeDefinition && inter.IsGenericType)
                {
                    var generic = inter.GetGenericTypeDefinition();
                    if (generic == interfaceType)
                        return true;
                }
            }
            return false;
        }

#endregion

    }
}
