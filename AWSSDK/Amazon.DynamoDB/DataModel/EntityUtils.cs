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
using System.IO;
using System.Reflection;
using System.Text;
using Amazon.CloudFront.Model;

namespace Amazon.DynamoDB.DataModel
{
    internal static class EntityUtils
    {
        #region Type methods

        public static bool IsPrimitive(Type type)
        {
            return (
                type.IsAssignableFrom(typeof(Boolean)) ||
                type.IsAssignableFrom(typeof(Byte)) ||
                type.IsAssignableFrom(typeof(Char)) ||
                type.IsAssignableFrom(typeof(DateTime)) ||
                type.IsAssignableFrom(typeof(Decimal)) ||
                type.IsAssignableFrom(typeof(Double)) ||
                type.IsAssignableFrom(typeof(int)) ||
                type.IsAssignableFrom(typeof(long)) ||
                type.IsAssignableFrom(typeof(SByte)) ||
                type.IsAssignableFrom(typeof(short)) ||
                type.IsAssignableFrom(typeof(Single)) ||
                type.IsAssignableFrom(typeof(String)) ||
                type.IsAssignableFrom(typeof(uint)) ||
                type.IsAssignableFrom(typeof(ulong)) ||
                type.IsAssignableFrom(typeof(ushort)) ||
                type.IsAssignableFrom(typeof(Guid)) ||
                type.IsAssignableFrom(typeof(byte[])) ||
                type.IsAssignableFrom(typeof(MemoryStream)));
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

            // Check if there is a metadata class
            var checkedType = CheckMetaDataType(targetType);
            object[] attributes = checkedType.GetCustomAttributes(typeof(DynamoDBAttribute), true);

            return GetSingleDDBAttribute(attributes);
        }
        public static DynamoDBAttribute GetAttribute(MemberInfo targetMemberInfo)
        {
            if (targetMemberInfo == null) throw new ArgumentNullException("targetMemberInfo");

            var checkedMemberInfo = CheckMetaDataType(targetMemberInfo);
            object[] attributes = checkedMemberInfo.GetCustomAttributes(typeof(DynamoDBAttribute), true);

            return GetSingleDDBAttribute(attributes);
        }

        public static DynamoDBAttribute GetSingleDDBAttribute(object[] attributes)
        {
            if (attributes.Length == 0)
                return null;
            if (attributes.Length == 1)
                return (attributes[0] as DynamoDBAttribute);
            throw new InvalidOperationException("Cannot have multiple DynamoDBAttributes on a single member");
        }

        #endregion

        #region Non-DynamoDB utilities

        private static Type CheckMetaDataType(Type targetType)
        {
            if (targetType == null)
                throw new ArgumentNullException("targetType");

            object[] attributes = targetType.GetCustomAttributes(true);
            var resultType = targetType;
            foreach (var attribute in attributes)
            {
                if (attribute.GetType().FullName == "System.ComponentModel.DataAnnotations.MetadataTypeAttribute") // string comparison since we're using 3.5 Client Profile
                {
                    resultType = attribute.GetType().GetProperty("MetadataClassType").GetValue(attribute, null) as Type;
                    break;
                }
            }
            return resultType;
        }

        private static MemberInfo CheckMetaDataType(MemberInfo targetMemberInfo)
        {
            if (targetMemberInfo == null)
                throw new ArgumentNullException("targetMemberInfo");

            var metaDataType = CheckMetaDataType(targetMemberInfo.DeclaringType);
            if (metaDataType == null)
                return targetMemberInfo;

            var matchedMembers = metaDataType.GetMember(targetMemberInfo.Name);
            var memberCount = matchedMembers.Length;
            switch (memberCount)
            {
                case 0:
                    return targetMemberInfo;
                case 1:
                    return matchedMembers[0];
                default:
                    throw new InvalidOperationException(
                        string.Format("More than one public member found with the same name of:  {0}",
                                      targetMemberInfo.Name));
            }
        }

        public static string ToLowerCamelCase(string value)
        {
            if (string.IsNullOrEmpty(value) || char.IsLower(value[0])) return value;
            StringBuilder sb = new StringBuilder(value);
            sb[0] = char.ToLower(sb[0]);
            return sb.ToString();
        }
        public static object Instantiate(Type objectType)
        {
            if (objectType == null)
                throw new ArgumentNullException();
            if (!CanInstantiate(objectType))
                throw new InvalidOperationException("Cannot instantiate type " + objectType.FullName);
            var constructorInfo = objectType.GetConstructor(Type.EmptyTypes);
            if (constructorInfo == null) throw new InvalidOperationException("Type must have a parameterless constructor");
            object instance = constructorInfo.Invoke(null);
            return instance;
        }
        public static bool CanInstantiate(Type objectType)
        {
            return
                //objectType.IsPublic &&
                objectType.IsClass &&
                !objectType.IsInterface &&
                !objectType.IsAbstract &&
                !objectType.IsGenericTypeDefinition &&
                !objectType.ContainsGenericParameters &&
                objectType.GetConstructor(Type.EmptyTypes) != null; // parameterless constructor present?
        }
        public static Type GetType(MemberInfo member)
        {
            return (member is PropertyInfo ? (member as PropertyInfo).PropertyType : (member as FieldInfo).FieldType);
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
                throw new ArgumentOutOfRangeException("Member must be FieldInfo or PropertyInfo");
            }
        }
        public static bool ImplementsInterface(Type targetType, Type interfaceType)
        {
            if (!interfaceType.IsInterface)
                throw new ArgumentOutOfRangeException("interfaceType", "Type is not an interface");

            foreach (var inter in targetType.GetInterfaces())
            {
                if (inter == interfaceType)
                    return true;
                if (interfaceType.IsGenericTypeDefinition && inter.IsGenericType)
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
