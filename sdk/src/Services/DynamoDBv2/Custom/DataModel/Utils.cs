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
            throw new InvalidOperationException("Version or counter property must be of primitive, numeric, integer, nullable type (e.g. int?, long?, byte?)");
        }

        internal static void ValidateTimestampType(Type memberType)
        {
            if (memberType.IsGenericType && memberType.GetGenericTypeDefinition() == typeof(Nullable<>) &&
                (memberType.IsAssignableFrom(typeof(DateTime)) ||
                memberType.IsAssignableFrom(typeof(DateTimeOffset))))
            {
                return;
            }
            throw new InvalidOperationException(
                $"Timestamp properties must be of type Nullable<DateTime> (DateTime?) or Nullable<DateTimeOffset> (DateTimeOffset?). " +
                $"Invalid type: {memberType.FullName}. " +
                "Please ensure your property is declared as 'DateTime?' or 'DateTimeOffset?'."
            );
        }

        internal static void ValidateSearchVectorType(Type memberType)
        {
            if (memberType.IsGenericType &&
                memberType.GetGenericTypeDefinition() == typeof(List<>) &&
                memberType.GetGenericArguments()[0] == typeof(float))
            {
                return;
            }
            throw new InvalidOperationException(
                $"Search vector properties must be of type List<float>. " +
                $"Invalid type: {memberType.FullName}. " +
                "Please ensure your property is declared as 'List<float>'."
            );
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
                ItemsToArray(targetType, items, out result) :  //targetType is Array
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

#if NET8_0_OR_GREATER
        /// <summary>
        /// Attempts to select a parameterized constructor to use when populating an instance of
        /// <paramref name="type"/> by binding stored attribute values to constructor parameters.
        /// This supports immutable types such as C# record types (including record struct) and any
        /// type that is constructed through a parameterized constructor.
        /// </summary>
        /// <remarks>
        /// Selection rules:
        /// <list type="bullet">
        /// <item>If a constructor is marked with <see cref="DynamoDBConstructorAttribute"/>, it is used (and multiple such markers are an error).</item>
        /// <item>Otherwise, for reference types only, if a public parameterless constructor (or one accepting a <see cref="DynamoDBContext"/>) exists, no binding constructor is used and the type keeps the existing instantiation path. Value types (e.g. record struct) cannot use that path (see <see cref="CanInstantiate"/>), so a parameterless constructor does not suppress binding for them.</item>
        /// <item>Otherwise, if exactly one parameterized constructor remains, it is used. If more than one remains, the caller must disambiguate with <see cref="DynamoDBConstructorAttribute"/>.</item>
        /// </list>
        /// <para>
        /// The second rule is what keeps stored data compatible across target frameworks. A reference type with a
        /// public parameterless constructor is the only shape that older builds of the SDK can populate, and such a
        /// type never selects a binding constructor here unless the application opts in with
        /// <see cref="DynamoDBConstructorAttribute"/> (which does not exist below .NET 8). Every type that this
        /// method newly makes usable is a type that older builds rejected outright, so no existing item can change
        /// shape when an application is retargeted to .NET 8 or later.
        /// </para>
        /// <para>
        /// The compiler-generated record copy constructor needs no special handling: it is non-public (protected on
        /// a record class, private on a sealed record) and only public constructors are considered.
        /// </para>
        /// </remarks>
        /// <returns><c>true</c> when a binding constructor was selected; otherwise <c>false</c>.</returns>
        internal static bool TryGetBindingConstructor(
            [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type,
            out ConstructorInfo bindingConstructor)
        {
            bindingConstructor = null;

            // Types that cannot be instantiated by reflection (abstract, interface, or open generic) must not
            // select a binding constructor; otherwise they would bypass the existing CanInstantiate validation
            // and fail later with a raw reflection exception from ConstructorInfo.Invoke. A byref-like type
            // (ref struct) is excluded for the same reason: it cannot be boxed into the object that Invoke
            // returns. Returning false here lets the normal unsupported-type error path remain authoritative.
            if (type.IsAbstract || type.IsInterface || type.IsGenericTypeDefinition || type.ContainsGenericParameters || type.IsByRefLike)
                return false;

            // Only public instance constructors are considered. The compiler-generated record copy constructor is
            // non-public (protected on a record class, private on a sealed record), so it is already excluded here
            // and does not need special-casing — a legitimate public 'T(T source)' constructor must not be dropped.
            var constructors = type
                .GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .ToList();

            if (constructors.Count == 0)
                return false;

            // An explicit [DynamoDBConstructor] marker takes precedence and disambiguates multiple constructors.
            var marked = constructors.Where(c => c.GetCustomAttribute<DynamoDBConstructorAttribute>() != null).ToList();
            if (marked.Count > 1)
                throw new InvalidOperationException(
                    $"Type {type.FullName} has multiple constructors marked with [DynamoDBConstructor]. Only one constructor may be marked.");
            if (marked.Count == 1)
            {
                // A parameterless constructor marked with the attribute has nothing to bind; keep the existing path.
                if (marked[0].GetParameters().Length == 0)
                    return false;

                bindingConstructor = marked[0];
                return true;
            }

            // With no explicit marker, prefer the existing instantiation path when a parameterless constructor
            // (or one accepting a DynamoDBContext) is available. This preserves behavior for all existing types.
            // This only applies to reference types: value types are rejected by CanInstantiate (which requires a
            // class), so for a value type we must bind through a parameterized constructor even if it also declares
            // an explicit parameterless constructor.
            if (!type.IsValueType)
            {
                foreach (var constructor in constructors)
                {
                    var parameters = constructor.GetParameters();
                    if (parameters.Length == 0)
                        return false;
                    if (parameters.Length == 1 && parameters[0].ParameterType == typeof(DynamoDBContext))
                        return false;
                }
            }

            // Consider only constructors that can be bound: those with parameters, excluding the
            // parameterless and the DynamoDBContext-only constructors handled by the existing path.
            var bindable = constructors
                .Where(c =>
                {
                    var parameters = c.GetParameters();
                    if (parameters.Length == 0)
                        return false;
                    if (parameters.Length == 1 && parameters[0].ParameterType == typeof(DynamoDBContext))
                        return false;
                    return true;
                })
                .ToList();

            if (bindable.Count == 0)
                return false;

            if (bindable.Count == 1)
            {
                bindingConstructor = bindable[0];
                return true;
            }

            // More than one constructor could be bound. A value type whose persisted members are all writable does
            // not need a constructor at all: it is populated by zero-initialization followed by member assignment,
            // so the ambiguity is irrelevant and reporting it would reject a type that works everywhere it is used
            // (top level, nested and flattened). A value type that has constructor-only members, and any reference
            // type, still needs the caller to disambiguate.
            if (type.IsValueType && !ValueTypeRequiresBindingConstructor(type, bindable))
                return false;

            throw new InvalidOperationException(
                $"Type {type.FullName} has multiple bindable parameterized constructors. " +
                "Mark the constructor to use for DynamoDB deserialization with [DynamoDBConstructor].");
        }

        /// <summary>
        /// Whether a value type needs one of <paramref name="candidates"/> to populate at least one of the members
        /// it persists, that is whether it has a get-only property matching a parameter of any candidate. When it
        /// does not, zero-initialization followed by member assignment can populate the value completely.
        /// </summary>
        private static bool ValueTypeRequiresBindingConstructor(
            [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type,
            List<ConstructorInfo> candidates)
        {
            var parameterNames = candidates
                .SelectMany(c => c.GetParameters())
                .Select(p => p.Name)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();

            foreach (var member in GetMembersFromType(type, parameterNames))
            {
                if (!IsReadWrite(member))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// The widening conversions the reflection binder performs when a value is passed to a constructor
        /// parameter, keyed by the type of the value. This is the CLR's primitive widening table, which is
        /// narrower than C#'s implicit numeric conversions: notably nothing widens to <see cref="decimal"/>.
        /// </summary>
        private static readonly Dictionary<Type, Type[]> PrimitiveWideningConversions = new Dictionary<Type, Type[]>
        {
            [typeof(sbyte)]  = new[] { typeof(short), typeof(int), typeof(long), typeof(float), typeof(double) },
            [typeof(byte)]   = new[] { typeof(short), typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(char) },
            [typeof(short)]  = new[] { typeof(int), typeof(long), typeof(float), typeof(double) },
            [typeof(ushort)] = new[] { typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double), typeof(char) },
            [typeof(int)]    = new[] { typeof(long), typeof(float), typeof(double) },
            [typeof(uint)]   = new[] { typeof(long), typeof(ulong), typeof(float), typeof(double) },
            [typeof(long)]   = new[] { typeof(float), typeof(double) },
            [typeof(ulong)]  = new[] { typeof(float), typeof(double) },
            [typeof(char)]   = new[] { typeof(ushort), typeof(int), typeof(uint), typeof(long), typeof(ulong), typeof(float), typeof(double) },
            [typeof(float)]  = new[] { typeof(double) },
        };

        /// <summary>
        /// Determines whether a value of <paramref name="memberType"/> can be passed to a constructor parameter
        /// of <paramref name="parameterType"/>. A stored attribute is deserialized as its member's type and then
        /// handed to <see cref="ConstructorInfo.Invoke(object[])"/>, so a combination that the reflection binder
        /// rejects produces a model that saves successfully but fails on every load.
        /// </summary>
        /// <param name="memberType">The declared type of the member that supplies the parameter.</param>
        /// <param name="parameterType">The declared type of the constructor parameter.</param>
        /// <param name="polymorphicDerivedTypes">
        /// Types the deserializer can produce for the member besides <paramref name="memberType"/>, that is the
        /// derived types registered for polymorphic deserialization. A parameter type narrower than the member
        /// type is only reachable through one of these.
        /// </param>
        /// <remarks>
        /// Only combinations that can never succeed are reported, so the check accepts identity, nullability on
        /// either side, reference upcasts, boxing to object or an interface, enum and underlying-type pairs, and
        /// primitive widening as the reflection binder performs it.
        /// </remarks>
        internal static bool IsAssignableToConstructorParameter(
            Type memberType,
            Type parameterType,
            IEnumerable<Type> polymorphicDerivedTypes = null)
        {
            if (memberType == null || parameterType == null)
                return true;

            if (memberType == parameterType)
                return true;

            // A non-null Nullable<T> boxes as T, and the binder accepts a boxed T for a T? parameter, so the
            // nullability of either side does not affect whether the call succeeds.
            var member = Nullable.GetUnderlyingType(memberType) ?? memberType;
            var parameter = Nullable.GetUnderlyingType(parameterType) ?? parameterType;

            if (member == parameter)
                return true;

            // Reference conversions and boxing to object or an interface.
            if (parameter.IsAssignableFrom(member))
                return true;

            // The parameter is narrower than the member. The deserializer reconstructs the member's declared type,
            // so the only way the call can succeed is a polymorphic mapping that produces a compatible type.
            if (polymorphicDerivedTypes != null)
            {
                foreach (var derivedType in polymorphicDerivedTypes)
                {
                    if (parameter.IsAssignableFrom(derivedType))
                        return true;
                }
            }

            // An enum is passed as, and accepted for, its underlying primitive type.
            if (member.IsEnum)
                member = Enum.GetUnderlyingType(member);
            if (parameter.IsEnum)
                parameter = Enum.GetUnderlyingType(parameter);

            if (member == parameter)
                return true;

            return PrimitiveWideningConversions.TryGetValue(member, out var widensTo) &&
                Array.IndexOf(widensTo, parameter) >= 0;
        }

        /// <summary>
        /// The derived types declared with <see cref="DynamoDBPolymorphicTypeAttribute"/> on <paramref name="type"/>
        /// itself. The loader can produce any of these for a member declared as that type, in addition to any
        /// derived types declared on the member.
        /// </summary>
        internal static IEnumerable<Type> GetPolymorphicDerivedTypes(Type type)
        {
            if (type == null)
                yield break;

            foreach (var attribute in type.GetCustomAttributes<DynamoDBPolymorphicTypeAttribute>(inherit: false))
            {
                if (attribute.DerivedType != null)
                    yield return attribute.DerivedType;
            }
        }

        /// <summary>
        /// Whether a type populated through <paramref name="bindingConstructor"/> exposes members that only that
        /// constructor can populate, that is get-only properties matching one of its parameters. Such members are
        /// persisted by the type's own model but cannot be assigned by a caller that creates the value without
        /// invoking the constructor, so they would be written when an item is saved and never read back.
        /// </summary>
        /// <remarks>
        /// An <c>init</c> accessor counts as writable, so a positional <c>record struct</c> or
        /// <c>readonly record struct</c> has no constructor-only members.
        /// </remarks>
        internal static bool HasConstructorOnlyMembers(
            [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type,
            ConstructorInfo bindingConstructor)
        {
            var parameterNames = bindingConstructor.GetParameters().Select(p => p.Name).ToArray();

            foreach (var member in GetMembersFromType(type, parameterNames))
            {
                if (!IsReadWrite(member))
                    return true;
            }

            return false;
        }
#endif

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
        /// Determines whether <paramref name="member"/> is a readable, get-only property whose name matches
        /// one of the supplied constructor parameter names. Such members are otherwise excluded by
        /// <see cref="IsValidMemberInfo"/> (they are not writable), but are needed to support immutable types
        /// whose values are supplied through a parameterized constructor.
        /// </summary>
        private static bool IsConstructorBoundReadOnlyProperty(MemberInfo member, ICollection<string> constructorParameterNames)
        {
            if (constructorParameterNames == null || constructorParameterNames.Count == 0)
                return false;

            if (!(member is PropertyInfo property))
                return false;

            // Only get-only properties need this special handling; read/write (incl. init) members already pass IsValidMemberInfo.
            if (!property.CanRead || property.CanWrite)
                return false;

            foreach (var name in constructorParameterNames)
            {
                if (string.Equals(name, property.Name, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
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
            return GetMembersFromType(type, null);
        }

        /// <summary>
        /// Retrieves a list of members that exist in a given type. In addition to the read/write members
        /// returned by the parameterless overload, get-only properties whose name matches one of
        /// <paramref name="constructorParameterNames"/> (case-insensitive) are included so their values
        /// can be read for saving and bound to constructor parameters on load.
        /// </summary>
        internal static List<MemberInfo> GetMembersFromType(
            [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type,
            ICollection<string> constructorParameterNames)
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
                    .Where(m => IsValidMemberInfo(m) || IsConstructorBoundReadOnlyProperty(m, constructorParameterNames))
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