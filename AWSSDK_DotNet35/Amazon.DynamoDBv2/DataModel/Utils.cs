/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Util;
using System.Globalization;

namespace Amazon.DynamoDBv2.DataModel
{
    internal static class Utils
    {
        #region Type methods

        public static bool IsPrimitive(Type type)
        {
            var typeWrapper = TypeFactory.GetTypeInfo(type);
            return (
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Boolean))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Byte))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Char))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(DateTime))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Decimal))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Double))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(int))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(long))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(SByte))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(short))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Single))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(String))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(uint))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(ulong))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(ushort))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Guid))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(byte[]))) ||
                typeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(MemoryStream))));
        }

        public static void ValidateVersionType(Type memberType)
        {
            var memberTypeWrapper = TypeFactory.GetTypeInfo(memberType);
            if (memberTypeWrapper.IsGenericType && memberTypeWrapper.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                (memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(Byte))) ||
                memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(SByte))) ||
                memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(int))) ||
                memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(uint))) ||
                memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(long))) ||
                memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(ulong))) ||
                memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(short))) ||
                memberTypeWrapper.IsAssignableFrom(TypeFactory.GetTypeInfo(typeof(ushort)))))
            {
                return;
            }
            throw new InvalidOperationException("Version property must be of primitive, numeric, integer, nullable type (e.g. int?, long?, byte?)");
        }

        #endregion

        #region Attribute methods

        public static DynamoDBTableAttribute GetTableAttribute(Type type)
        {
            DynamoDBTableAttribute tableAttribute = GetAttribute(type) as DynamoDBTableAttribute;
            if (tableAttribute == null)
                return null;
            return tableAttribute;
        }

        public static DynamoDBAttribute GetAttribute(Type targetType)
        {
            if (targetType == null) throw new ArgumentNullException("targetType");
            object[] attributes = TypeFactory.GetTypeInfo(targetType).GetCustomAttributes(TypeFactory.GetTypeInfo(typeof(DynamoDBAttribute)), true);
            return GetSingleDDBAttribute(attributes);
        }
        public static DynamoDBAttribute GetAttribute(MemberInfo targetMemberInfo)
        {
            object[] attributes = GetAttributeObjects(targetMemberInfo);
            return GetSingleDDBAttribute(attributes);
        }
        public static DynamoDBAttribute[] GetAttributes(MemberInfo targetMemberInfo)
        {
            object[] attObjects = GetAttributeObjects(targetMemberInfo) ?? new object[0];
            var attributes = new List<DynamoDBAttribute>();
            foreach (var attObj in attObjects)
            {
                var attribute = attObj as DynamoDBAttribute;
                if (attribute != null)
                    attributes.Add(attribute);
            }
            return attributes.ToArray();
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
#if (WIN_RT || WINDOWS_PHONE)
            object[] attributes = targetMemberInfo.GetCustomAttributes(typeof(DynamoDBAttribute), true).ToArray();
#else
            object[] attributes = targetMemberInfo.GetCustomAttributes(typeof(DynamoDBAttribute), true);
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
        public static object Instantiate(Type objectType)
        {
            if (objectType == null)
                throw new ArgumentNullException("objectType");
            if (!CanInstantiate(objectType))
                throw new InvalidOperationException("Cannot instantiate type " + objectType.FullName);

            var objectTypeWrapper = TypeFactory.GetTypeInfo(objectType);
            var constructorInfo = objectTypeWrapper.GetConstructor(TypeFactory.EmptyTypes);
            if (constructorInfo == null) throw new InvalidOperationException("Type must have a parameterless constructor");
            object instance = constructorInfo.Invoke(null);
            return instance;
        }
        public static bool CanInstantiate(Type objectType)
        {
            var objectTypeWrapper = TypeFactory.GetTypeInfo(objectType);
            return
                //objectType.IsPublic &&
                objectTypeWrapper.IsClass &&
                !objectTypeWrapper.IsInterface &&
                !objectTypeWrapper.IsAbstract &&
                !objectTypeWrapper.IsGenericTypeDefinition &&
                !objectTypeWrapper.ContainsGenericParameters &&
                objectTypeWrapper.GetConstructor(TypeFactory.EmptyTypes) != null; // parameterless constructor present?
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
                return field.IsPublic;
            }
            else
            {
                throw new ArgumentOutOfRangeException("member", "Member must be FieldInfo or PropertyInfo");
            }
        }
        public static bool ImplementsInterface(Type targetType, Type interfaceType)
        {
            var targetTypeWrapper = TypeFactory.GetTypeInfo(targetType);
            var interfaceTypeWrapper = TypeFactory.GetTypeInfo(interfaceType);
            if (!interfaceTypeWrapper.IsInterface)
                throw new ArgumentOutOfRangeException("interfaceType", "Type is not an interface");

            foreach (var inter in targetTypeWrapper.GetInterfaces())
            {
                var interWrapper = TypeFactory.GetTypeInfo(inter);
                if (object.Equals(interWrapper, interfaceTypeWrapper))
                    return true;
                if (interfaceTypeWrapper.IsGenericTypeDefinition && interWrapper.IsGenericType)
                {
                    var generic = interWrapper.GetGenericTypeDefinition();
                    if (generic == interfaceType)
                        return true;
                }
            }
            return false;
        }

        #endregion

    }
}
