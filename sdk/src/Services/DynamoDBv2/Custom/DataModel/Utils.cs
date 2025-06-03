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
using System.Linq;
using System.Reflection;
using System.Text;
using System.Diagnostics.CodeAnalysis;

using Amazon.Util.Internal;
using System.Globalization;
using System.Collections;
using Amazon.DynamoDBv2.DocumentModel;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
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

        internal static readonly Type[] PrimitiveTypesCollectionsAndArray = new Type[]
        {
            // Byte[] is explicitly not in this list because there is a separate converter for that type.
            typeof(Boolean[]),
            typeof(Char[]),
            typeof(DateTime[]),
            typeof(Decimal[]),
            typeof(Double[]),
            typeof(int[]),
            typeof(long[]),
            typeof(SByte[]),
            typeof(short[]),
            typeof(Single[]),
            typeof(String[]),
            typeof(uint[]),
            typeof(ulong[]),
            typeof(ushort[]),
            typeof(Guid[]),
            typeof(MemoryStream[]),
            typeof(Primitive[]),

            typeof(List<Boolean>),
            typeof(List<Byte>),
            typeof(List<Byte[]>),
            typeof(List<Char>),
            typeof(List<DateTime>),
            typeof(List<Decimal>),
            typeof(List<Double>),
            typeof(List<int>),
            typeof(List<long>),
            typeof(List<SByte>),
            typeof(List<short>),
            typeof(List<Single>),
            typeof(List<String>),
            typeof(List<uint>),
            typeof(List<ulong>),
            typeof(List<ushort>),
            typeof(List<Guid>),
            typeof(List<MemoryStream>),
            typeof(List<Primitive>),

            typeof(HashSet<Boolean>),
            typeof(HashSet<Byte>),
            typeof(HashSet<Byte[]>),
            typeof(HashSet<Char>),
            typeof(HashSet<DateTime>),
            typeof(HashSet<Decimal>),
            typeof(HashSet<Double>),
            typeof(HashSet<int>),
            typeof(HashSet<long>),
            typeof(HashSet<SByte>),
            typeof(HashSet<short>),
            typeof(HashSet<Single>),
            typeof(HashSet<String>),
            typeof(HashSet<uint>),
            typeof(HashSet<ulong>),
            typeof(HashSet<ushort>),
            typeof(HashSet<Guid>),
            typeof(HashSet<MemoryStream>),
            typeof(HashSet<Primitive>)
        };

        internal static readonly IEnumerable<Type> PrimitiveTypes = new HashSet<Type>(primitiveTypesArray);

        internal static bool IsPrimitive(Type type)
        {
            return PrimitiveTypes.Any(ti => type.IsAssignableFrom(ti));
        }
        internal static bool IsPrimitive<T>()
        {
            return IsPrimitive(typeof(T));
        }
        internal static void ValidatePrimitiveType(Type type)
        {
            if (!Utils.IsPrimitive(type))
                throw new InvalidCastException(string.Format(CultureInfo.InvariantCulture,
                    "{0} is not a supported Primitive type", type.FullName));
        }
        internal static void ValidatePrimitiveType<T>()
        {
            ValidatePrimitiveType(typeof(T));
        }

        internal static void ValidateNumericType(Type memberType)
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

        [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)]
        internal static Type GetPrimitiveElementType(Type collectionType)
        {
            var elementType = Utils.GetElementType(collectionType);

            if (elementType != null)
            {
                Utils.ValidatePrimitiveType(elementType);
                return elementType;
            }

            throw new InvalidOperationException("Unable to determine element type");
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2073",
            Justification = "The user's type has been annotated with DynamicallyAccessedMemberTypes.All with the public API into the library. At this point the type will not be trimmed.")]
        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2063",
            Justification = "The user's type has been annotated with DynamicallyAccessedMemberTypes.All with the public API into the library. At this point the type will not be trimmed.")]
        [return: DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)]
        internal static Type GetElementType(Type collectionType)
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

        internal static bool ItemsToCollection([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, IEnumerable<object> items, out object result)
        {
            return targetType.IsArray ?
                ItemsToArray(targetType, items, out result):  //targetType is Array
                ItemsToIList(targetType, items, out result);  //targetType is IList or has Add method.
        }

        private static bool ItemsToIList([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, IEnumerable<object> items, out object result)
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

        private static bool ItemsToArray([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type targetType, IEnumerable<object> items, out object result)
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

        internal static DynamoDBTableAttribute GetTableAttribute(Type targetType)
        {
            if (targetType == null) throw new ArgumentNullException("targetType");

            object[] attributes = targetType.GetCustomAttributes(typeof(DynamoDBTableAttribute), true);
            DynamoDBTableAttribute tableAttribute = GetSingleDDBAttribute(attributes) as DynamoDBTableAttribute;

            if (tableAttribute == null)
                return null;

            return tableAttribute;
        }

        internal static DynamoDBPolymorphicTypeAttribute[] GetPolymorphicTypesAttribute(Type targetType)
        {
            if (targetType == null) throw new ArgumentNullException("targetType");

            object[] attributes = targetType.GetCustomAttributes(typeof(DynamoDBPolymorphicTypeAttribute), false);

            return attributes as DynamoDBPolymorphicTypeAttribute[];
        }

        internal static DynamoDBAttribute GetAttribute(Type targetType)
        {
            if (targetType == null) throw new ArgumentNullException("targetType");
            object[] attributes = targetType.GetCustomAttributes(typeof(DynamoDBAttribute), true);
            return GetSingleDDBAttribute(attributes);
        }
        internal static DynamoDBAttribute GetAttribute(MemberInfo targetMemberInfo)
        {
            object[] attributes = GetAttributeObjects(targetMemberInfo);
            return GetSingleDDBAttribute(attributes);
        }
        internal static List<DynamoDBAttribute> GetAttributes(MemberInfo targetMemberInfo)
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

        internal static string ToLowerCamelCase(string value)
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

        internal static bool IsCollectionType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type type)
        {
            if (type == typeof(string))
                return false;

            if (type.IsGenericType && typeof(IEnumerable).IsAssignableFrom(type))
                return true;

            return typeof(IEnumerable).IsAssignableFrom(type);
        }

        internal static object InstantiateConverter([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType, IDynamoDBContext context)
        {
            return InstantiateHelper(objectType, validConverterConstructorInputs, new object[] { context });
        }

        internal static object InstantiateArray([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType, int length)
        {
            return InstantiateHelper(objectType, validArrayConstructorInputs, new object[] { length });
        }

        internal static object Instantiate([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType)
        {
            return InstantiateHelper(objectType, validConstructorInputs, null);
        }

        private static object InstantiateHelper([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType, Type[][] validConstructorInputs, object[] optionalInput = null)
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

        private static IEnumerable<ConstructorInfo> GetConstructors([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type typeInfo, Type[][] validConstructorInputs)
        {
            foreach (var inputTypes in validConstructorInputs)
            {
                var constructor = typeInfo.GetConstructor(inputTypes);
                if (constructor != null)
                    yield return constructor;
            }
        }

        public static bool CanInstantiate([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType)
        {
            return CanInstantiateHelper(objectType, validConstructorInputs);
        }

        public static bool CanInstantiateArray([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType)
        {
            return objectType.IsArray && CanInstantiateHelper(objectType, validArrayConstructorInputs);
        }

        public static bool CanInstantiateConverter([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType)
        {
            return CanInstantiateHelper(objectType, validConverterConstructorInputs);
        }

        private static bool CanInstantiateHelper([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type objectType, Type[][] validConstructorInputs)
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

        
        internal static Type GetType(MemberInfo member)
        {
            var pi = member as PropertyInfo;
            var fi = member as FieldInfo;
            if (pi == null && fi == null)
                throw new ArgumentOutOfRangeException(nameof(member), "member must be of type PropertyInfo or FieldInfo");

            return (pi != null ? pi.PropertyType : fi.FieldType);
        }

        internal static bool IsReadWrite(MemberInfo member)
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

        internal static bool ImplementsInterface([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type targetType, Type interfaceType)
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
        
        /// <summary>
        /// Apply a set of filters to a determine whether a member should be returned.
        /// In terms of DynamoDb, we want to return members that are fields or properties
        /// and are both read and write members.
        /// </summary>
        private static bool IsValidMemberInfo(MemberInfo member)
        {
            // filter out non-fields and non-properties
            if (!(member is FieldInfo || member is PropertyInfo))
                return false;

            // filter out properties that aren't both read and write
            if (!IsReadWrite(member))
                return false;

            return true;
        }

        /// <summary>
        /// Retrieves a list of members that exist in a given type.
        /// The function goes over all the declared members of a given type
        /// and recurses into any base types and the declared members of those types.
        /// In case of members existing in both derived and base types,
        /// members from the derived types will be used while ignoring same-name members
        /// in base types to avoid returning duplicate members.
        /// </summary>
        internal static List<MemberInfo> GetMembersFromType([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type)

        {
            Dictionary<string, MemberInfo> members = new Dictionary<string, MemberInfo>();
        
            Type currentType = type;
            while (
                currentType != null && 
                currentType != typeof(object))
            {
                // Previous implementation used GetMembers to return the valid members for a type, but in certain class configurations
                // invalid members were returned. To account for that, we are going over each type separately.
                // Using 'DeclaredOnly' binding flag to return the members that were declared in the current type and not any inherited members
                // since the iteration is going over each base type separately.
                var currentMembers = currentType
                    .GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Where(IsValidMemberInfo)
                    .ToList();
        
                foreach (var member in currentMembers)
                {
                    if (!members.ContainsKey(member.Name))
                    {
                        members[member.Name] = member;
                    }
                }
        
                currentType = currentType.BaseType;
            }
        
            return members.Values.ToList();
        }

        #endregion
    }
}
