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

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Basic property storage information
    /// </summary>
    internal class SimplePropertyStorage
    {
        // local property name
        public string PropertyName { get; protected set; }
        // DynamoDB attribute name
        public string AttributeName { get; set; }

        // MemberInfo of the property
        public MemberInfo Member { get; protected set; }
        // Type of the property

        [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)]
        public Type MemberType { get; protected set; }
        // Converter type, if one is present

        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)]
        public Type ConverterType { get; set; }
        // Converter, if one is present
        public IPropertyConverter Converter { get; protected set; }

        public void AddDerivedType(string typeDiscriminator, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type)
        {
            _derivedTypesDictionary[type] = typeDiscriminator;
            _derivedTypeKeysDictionary[typeDiscriminator] = type;
        }

        // derived type information used for polymorphic serialization
        private Dictionary<Type, string> _derivedTypesDictionary;

        // derived type information used for polymorphic deserialization
        private Dictionary<string, Type> _derivedTypeKeysDictionary;

        public bool TryGetDerivedTypeDiscriminator([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type, out string typeDiscriminator)
        {
            if (_derivedTypesDictionary.TryGetValue(type, out typeDiscriminator))
            {
                return true;
            }

            return false;
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// The types the deserializer can produce for this member in addition to <c>MemberType</c>, that is the
        /// derived types registered for polymorphic deserialization.
        /// </summary>
        internal IEnumerable<Type> PolymorphicDerivedTypes
        {
            get { return _derivedTypeKeysDictionary.Values; }
        }
#endif

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2067",
            Justification = "The user's type has been annotated with InternalConstants.DataModelModeledType with the public API into the library. At this point the type will not be trimmed.")]
        public bool TryGetDerivedType(string typeDiscriminator, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] out Type deriviedType)
        {
            if (_derivedTypeKeysDictionary.TryGetValue(typeDiscriminator, out deriviedType))
            {
                return true;
            }

            return false;
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2072",
            Justification = "The user's type has been annotated with DynamicallyAccessedMemberTypes.All with the public API into the library. At this point the type will not be trimmed.")]
        internal SimplePropertyStorage(MemberInfo member)
            : this(Utils.GetType(member))
        {
            Member = member;
            PropertyName = member.Name;
        }

        internal SimplePropertyStorage([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type memberType)
        {
            MemberType = memberType;
            _derivedTypesDictionary = new Dictionary<Type, string>();
            _derivedTypeKeysDictionary = new Dictionary<string,Type>();
        }

        internal SimplePropertyStorage([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type memberType, SimplePropertyStorage parentProeprtyStorage)
        {
            MemberType = memberType;
            _derivedTypesDictionary = parentProeprtyStorage._derivedTypesDictionary;
            _derivedTypeKeysDictionary = parentProeprtyStorage._derivedTypeKeysDictionary;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "{0} {1}", MemberType.FullName, PropertyName);
        }
    }

    /// <summary>
    /// DynamoDB property storage information
    /// </summary>
    internal class PropertyStorage : SimplePropertyStorage
    {
        // flags
        public bool IsHashKey { get; set; }
        public bool IsRangeKey { get; set; }
        public bool IsKey { get { return IsHashKey || IsRangeKey; } }
        public bool IsVersion { get; set; }
        public bool IsLSIRangeKey { get; set; }
        public bool IsGSIHashKey { get; set; }
        public bool IsGSIRangeKey { get; set; }
        public bool IsGSIKey { get { return IsGSIHashKey || IsGSIRangeKey; } }
        public bool IsIgnored { get; set; }

        /// <summary>
        /// Whether this member's value is supplied through a parameterized (binding) constructor rather
        /// than being set after construction. When <c>true</c>, the value is passed as a constructor argument
        /// during deserialization and is not written via a property/field setter. Only used on the .NET 8+ target.
        /// </summary>
        public bool IsConstructorArgument { get; set; }

        /// <summary>
        /// Whether to store DateTime as epoch seconds integer.
        /// </summary>
        public bool StoreAsEpoch { get; set; }

        /// <summary>
        /// Whether to store DateTime as epoch seconds integer (with support for dates AFTER 2038).
        /// </summary>
        public bool StoreAsEpochLong { get; set; }

        /// <summary>
        /// Whether to store Type Discriminator for polymorphic serialization.
        /// </summary>
        public bool PolymorphicProperty { get; set; }

        /// <summary>
        /// Whether to store child properties at the same level as the parent property.
        /// </summary>
        public bool ShouldFlattenChildProperties { get; set; }

        /// <summary>
        /// Whether to store property at parent level.
        /// </summary>
        public bool IsFlattened { get; set; }

        /// <summary>
        /// Whether to store the property as a timestamp that is automatically generated.
        /// </summary>
        public bool IsAutoGeneratedTimestamp { get; set; }

        /// <summary>
        /// Behavior for handling updates to this property during a save operation.
        /// </summary>
        public UpdateBehavior UpdateBehaviorMode { get; set; }

        // corresponding IndexNames, if applicable
        public List<string> IndexNames { get; set; }

        public List<PropertyStorage> FlattenProperties { get; set; }

        public bool IsCounter { get; set; }

        public long CounterDelta { get; set; }

        public long CounterStartValue { get; set; }

        /// <summary>
        /// Whether this property is a search vector associated with one or more vector indexes.
        /// </summary>
        public bool IsSearchVector { get; set; }

        /// <summary>
        /// Names of the vector indexes this search vector belongs to.
        /// </summary>
        public List<string> SearchVectorIndexNames { get; set; }

        public void AddIndex(DynamoDBGlobalSecondaryIndexHashKeyAttribute gsiHashKey)
        {
            AddIndex(new GSI(true, gsiHashKey.AttributeName, gsiHashKey.Order, gsiHashKey.IndexNames));
        }
        public void AddIndex(DynamoDBGlobalSecondaryIndexRangeKeyAttribute gsiRangeKey)
        {
            AddIndex(new GSI(false, gsiRangeKey.AttributeName, gsiRangeKey.Order, gsiRangeKey.IndexNames));
        }
        public void AddIndex(DynamoDBLocalSecondaryIndexRangeKeyAttribute lsiRangeKey)
        {
            AddIndex(new LSI(lsiRangeKey.AttributeName, lsiRangeKey.IndexNames));
        }
        public void AddGsiIndex(bool isHashKey, string attributeName,int order, params string[] indexNames)
        {
            AddIndex(new GSI(isHashKey, attributeName, order, indexNames));
        }
        public void AddLsiIndex(string attributeName, params string[] indexNames)
        {
            AddIndex(new LSI(attributeName, indexNames));
        }
        public void AddIndex(Index index)
        {
            Indexes.Add(index);
        }

        public List<Index> Indexes { get; private set; }

        public abstract class Index
        {
            public List<string> IndexNames { get; private set; }
            public string AttributeName { get; private set; }

            public Index(string attributeName, params string[] indexNames)
            {
                IndexNames = new List<string>(indexNames);
                AttributeName = attributeName;
            }
        }
        public class LSI : Index
        {
            public LSI(string attributeName, params string[] indexNames)
                : base(attributeName, indexNames) { }
        }
        public class GSI : Index
        {
            public bool IsHashKey { get; private set; }

            public int Order { get; private set; }

            public GSI(bool isHashKey, string attributeName, int order, params string[] indexNames)
                : base(attributeName, indexNames)
            {
                IsHashKey = isHashKey;
                Order = order;
            }
        }

        /// <summary>
        /// Validates configurations and sets required fields
        /// </summary>
        public void Validate(DynamoDBContext context)
        {
            if (IsVersion)
                Utils.ValidateNumericType(MemberType);    // no conversion is possible, so type must be a nullable primitive

            if (IsCounter)
                Utils.ValidateNumericType(MemberType);    // no conversion is possible, so type must be a nullable primitive

            if (IsSearchVector)
            {
                Utils.ValidateSearchVectorType(MemberType);

                if (context?.Config?.Conversion == DynamoDBEntryConversion.V1)
                    throw new InvalidOperationException(
                        "Property " + PropertyName + " is a search vector, which is not supported with DynamoDBEntryConversion.V1. Use DynamoDBEntryConversion.V2 instead.");
            }

            if (IsHashKey && IsRangeKey)
                throw new InvalidOperationException("Property " + PropertyName + " cannot be both hash and range key");

            if (UpdateBehaviorMode == UpdateBehavior.IfNotExists && (IsKey || IsVersion || IsCounter))
            {
                string propertyType = IsKey ? "key" : IsVersion ? "version" : IsCounter ? "counter" : "unknown";
                throw new InvalidOperationException($"Property {PropertyName} cannot be a {propertyType} and have UpdateBehavior set to IfNotExists at the same time.");
            }

            if (ConverterType != null)
            {
                if (PolymorphicProperty)
                    throw new InvalidOperationException("Converter for " + PropertyName + " must not be set at the same time as derived types.");

                if (ShouldFlattenChildProperties)
                    throw new InvalidOperationException("Converter for " + PropertyName + " must not be set at the same time as flatten types.");

                if (StoreAsEpoch || StoreAsEpochLong)
                    throw new InvalidOperationException("Converter for " + PropertyName + " must not be set at the same time as StoreAsEpoch or StoreAsEpochLong is set to true");

                if (IsAutoGeneratedTimestamp)
                    throw new InvalidOperationException("Converter for " + PropertyName + " must not be set at the same time as AutoGeneratedTimestamp is set to true.");

                if (!Utils.CanInstantiateConverter(ConverterType) || !Utils.ImplementsInterface(ConverterType, typeof(IPropertyConverter)))
                    throw new InvalidOperationException("Converter for " + PropertyName + " must be instantiable with no parameters and must implement IPropertyConverter");

                this.Converter = Utils.InstantiateConverter(ConverterType, context) as IPropertyConverter;
            }
            else
            {
                if (context.ConverterCache.TryGetValue(MemberType, out IPropertyConverter converter) && converter != null)
                {
                    if (!PolymorphicProperty && !ShouldFlattenChildProperties && !StoreAsEpoch && !StoreAsEpochLong && !IsAutoGeneratedTimestamp)
                        this.Converter = converter;
                }
            }

            if (StoreAsEpoch && StoreAsEpochLong)
                throw new InvalidOperationException(PropertyName + " must not set both StoreAsEpoch and StoreAsEpochLong as true at the same time.");
            
            if (IsAutoGeneratedTimestamp)
                Utils.ValidateTimestampType(MemberType);

            foreach (var index in Indexes)
                IndexNames.AddRange(index.IndexNames);
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "The user's type has been annotated with DynamicallyAccessedMemberTypes.All with the public API into the library. At this point the type will not be trimmed.")]
        internal PropertyStorage(MemberInfo member)
            : base(member)
        {
            IndexNames = new List<string>();
            Indexes = new List<Index>();
            FlattenProperties = new List<PropertyStorage>();
            SearchVectorIndexNames = new List<string>();
            UpdateBehaviorMode = UpdateBehavior.Always;
        }

    }

    /// <summary>
    /// Storage information for a single item
    /// </summary>
    internal class ItemStorage
    {
        public Document Document { get; set; }
        public ItemStorageConfig Config { get; set; }
        public Primitive CurrentVersion { get; set; }
        public HashSet<object> ConvertedObjects { get; private set; }

        public ItemStorage(ItemStorageConfig storageConfig)
        {
            Document = new Document();
            Config = storageConfig;
            ConvertedObjects = new HashSet<object>();
        }
    }

    /// <summary>
    /// GSI info
    /// </summary>
    internal class GSIConfig
    {
        public GSIConfig(string indexName)
        {
            IndexName = indexName;
            HashKeyPropertyNames = new Dictionary<string, int>();
            RangeKeyPropertyNames = new Dictionary<string, int>();
        }

        // index name
        public string IndexName { get; set; }

        // keys
        public Dictionary<string,int> HashKeyPropertyNames { get; set; }
        public Dictionary<string, int> RangeKeyPropertyNames { get; set; }
    }

    /// <summary>
    /// Storage information for a specific class
    /// </summary>
    internal class StorageConfig
    {
        // normalized PropertyStorage objects
        public List<PropertyStorage> Properties { get; private set; }

        // target type
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
        public Type TargetType { get; private set; }

        // target type members
        public Dictionary<string, MemberInfo> TargetTypeMembers { get; private set; }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Pairs a constructor parameter with the <see cref="PropertyStorage"/> that supplies its value.
        /// </summary>
        internal readonly struct ConstructorArgument
        {
            public ConstructorArgument(ParameterInfo parameter, PropertyStorage storage)
            {
                Parameter = parameter;
                Storage = storage;
            }

            public ParameterInfo Parameter { get; }
            public PropertyStorage Storage { get; }
        }

        /// <summary>
        /// The constructor used to populate instances of <see cref="TargetType"/> by binding stored attribute
        /// values to its parameters, or <c>null</c> when the type is populated via the parameterless path.
        /// </summary>
        internal ConstructorInfo BindingConstructor { get; private set; }

        /// <summary>
        /// The binding-constructor parameters aligned with the <see cref="PropertyStorage"/> that supplies each value.
        /// Populated by <see cref="ResolveConstructorArguments"/>.
        /// </summary>
        internal ConstructorArgument[] ConstructorArguments { get; private set; }

        /// <summary>
        /// The names of the binding constructor's parameters, used to surface get-only members during discovery.
        /// </summary>
        internal string[] ConstructorParameterNames { get; private set; }
#endif

        // storage mappings
        private Dictionary<string, PropertyStorage> PropertyToPropertyStorageMapping { get; set; }

        internal void AddPropertyStorage(string propertyName, PropertyStorage propertyStorage)
        {
            // Check for existing property with the same attribute name
            foreach (var existing in PropertyToPropertyStorageMapping.Values)
            {
                if (string.Equals(existing.AttributeName, propertyStorage.AttributeName))
                {
                    throw new InvalidOperationException(
                        $"A property with attribute name '{propertyStorage.AttributeName}' already exists (property: '{existing.PropertyName}'). " +
                        $"Cannot add property '{propertyName}' with the same attribute name.");
                }
            }
            PropertyToPropertyStorageMapping[propertyName] = propertyStorage;
        }

        public PropertyStorage GetPropertyStorage(string propertyName)
        {
            PropertyStorage storage;
            if (TryGetPropertyStorage(propertyName, out storage))
                return storage;
            throw new InvalidOperationException("Unable to find storage information for property [" + propertyName + "]");
        }
        public bool TryGetPropertyStorage(string propertyName, out PropertyStorage storage)
        {
            return (PropertyToPropertyStorageMapping.TryGetValue(propertyName, out storage));
        }
        
        public IEnumerable<PropertyStorage> AllPropertyStorage
        {
            get { return PropertyToPropertyStorageMapping.Values; }
        }
        public bool FindPropertyByPropertyName(string propertyName, out PropertyStorage propertyStorage)
        {
            return FindSingleProperty(
                p => string.Equals(p.PropertyName, propertyName, StringComparison.Ordinal),
                "Multiple properties configured for property " + propertyName,
                out propertyStorage);
        }
        public bool FindSinglePropertyByAttributeName(string attributeName, out PropertyStorage propertyStorage)
        {
            return FindSingleProperty(
                p => string.Equals(p.AttributeName, attributeName, StringComparison.Ordinal),
                "Multiple properties configured for attribute " + attributeName,
                out propertyStorage);
        }
        private bool FindSingleProperty(Func<PropertyStorage, bool> match, string errorMessage, out PropertyStorage propertyStorage)
        {
            var properties = Properties
                .Where(ps => !ps.IsIgnored)
                .Where(match)
                .ToList();

            if (properties.Count == 0)
            {
                propertyStorage = null;
                return false;
            }
            if (properties.Count == 1)
            {
                propertyStorage = properties[0];
                return true;
            }

            throw new InvalidOperationException(errorMessage);
        }

        private static Dictionary<string, MemberInfo> GetMembersDictionary([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type, ICollection<string> constructorParameterNames)
        {
            Dictionary<string, MemberInfo> dictionary = new Dictionary<string, MemberInfo>(StringComparer.Ordinal);

            var members = Utils.GetMembersFromType(type, constructorParameterNames);

            foreach (var member in members)
            {
                InternalSDKUtils.AddToDictionary(dictionary, member.Name, member);
            }

            return dictionary;
        }



        // constructor
        internal StorageConfig([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType)
        {
            ICollection<string> constructorParameterNames = null;
            bool requiresParameterlessConstructor = true;

#if NET8_0_OR_GREATER
            // Immutable types (e.g. record / record struct) are populated by binding stored values to a
            // parameterized constructor rather than instantiating with a parameterless constructor.
            if (Utils.TryGetBindingConstructor(targetType, out var bindingConstructor))
            {
                BindingConstructor = bindingConstructor;
                ConstructorParameterNames = bindingConstructor.GetParameters().Select(p => p.Name).ToArray();
                constructorParameterNames = ConstructorParameterNames;
                requiresParameterlessConstructor = false;
            }
            else if (targetType.IsValueType && !targetType.ContainsGenericParameters && !targetType.IsByRefLike)
            {
                // Value types (e.g. a non-positional record struct) that have no binding constructor are
                // populated via zero-initialization (default(T)) followed by member assignment, so they do
                // not require a parameterless constructor (CanInstantiate only accepts reference types).
                // Open generic and byref-like value types cannot be boxed, so they must not take this path;
                // leaving them to CanInstantiate keeps the normal unsupported-type error authoritative
                // instead of failing later inside Array.CreateInstance.
                requiresParameterlessConstructor = false;
            }
#endif

            if (requiresParameterlessConstructor && !Utils.CanInstantiate(targetType))
            {
                string errorMessage;
                if (InternalSDKUtils.IsRunningNativeAot())
                {
                    errorMessage = $"Type {targetType.FullName} is unsupported, it cannot be instantiated. Since the application is running in Native AOT mode the type could possibly be trimmed. " +
                        "This can happen if the type being created is a nested type of a type being used for saving and loading DynamoDB items. " +
                        $"This can be worked around by adding the \"[DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof({targetType.FullName}))]\" attribute to the constructor of the parent type." +
                        "If the parent type can not be modified the attribute can also be used on the method invoking the DynamoDB sdk or some other method that you are sure is not being trimmed.";
                }
                else
                {
                    errorMessage = $"Type {targetType.FullName} is unsupported, it cannot be instantiated.";
                }

#if !NET8_0_OR_GREATER
                // Populating a type through a parameterized constructor (records, other immutable types, and
                // value types) is only available on the .NET 8 or later build of the SDK. Point users at that
                // requirement instead of leaving them with a bare "cannot be instantiated" message.
                errorMessage += " Retargeting to .NET 8 (or later) can enable records and other types with a usable public parameterized constructor (selected with [DynamoDBConstructor] when necessary); otherwise, expose a public parameterless constructor and settable members.";
#endif

                throw new InvalidOperationException(errorMessage);
            }

            TargetType = targetType;
            Properties = new List<PropertyStorage>();
            PropertyToPropertyStorageMapping = new Dictionary<string, PropertyStorage>(StringComparer.Ordinal);
            TargetTypeMembers = GetMembersDictionary(targetType, constructorParameterNames);

            if (TargetTypeMembers.Count == 0)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Type {0} is unsupported, it has no supported members", targetType.FullName));
        }

#if NET8_0_OR_GREATER
        /// <summary>
        /// Aligns the binding constructor's parameters with the <see cref="PropertyStorage"/> that supplies
        /// each value (matched by property name, case-insensitive) and flags those members as constructor
        /// arguments, then validates that every modeled member can actually be populated when an item is loaded.
        /// Must be called after <see cref="Properties"/> has been populated and after type mappings and table
        /// configuration have been applied.
        /// </summary>
        internal void ResolveConstructorArguments()
        {
            if (BindingConstructor != null)
            {
                var parameters = BindingConstructor.GetParameters();
                var arguments = new ConstructorArgument[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                    var parameter = parameters[i];
                    PropertyStorage match = FindConstructorArgumentMember(parameter);

                    // Reject members whose value the SDK reconciles onto the instance after a save/update, since that
                    // write-back is impossible for an immutable constructor-populated member. This includes members
                    // nested inside a flattened constructor argument, whose server-managed descendants would otherwise
                    // be silently left stale (the flattened parent is skipped by PopulateInstance).
                    ValidateConstructorBindableMember(match, viaFlatten: false);

                    ValidateConstructorArgumentType(parameter, match);

                    match.IsConstructorArgument = true;
                    arguments[i] = new ConstructorArgument(parameter, match);
                }

                ConstructorArguments = arguments;

                // Every remaining member is set through a setter when an item is loaded, so a read-only member that
                // was not bound to a constructor parameter could be saved but never loaded.
                ValidateAllMembersAreLoadable();
            }

            if (TargetType.IsValueType)
            {
                // A value type is boxed before the SDK reconciles server-produced values onto the instance, so the
                // write-back updates a copy and the caller's value silently keeps the stale value.
                foreach (var property in Properties)
                {
                    if (property.IsIgnored) continue;
                    ValidateValueTypeMember(property, viaFlatten: false);
                }
            }
        }

        /// <summary>
        /// Finds the single modeled member that supplies <paramref name="parameter"/>. Members are matched to
        /// constructor parameters by name, case-insensitively; when more than one member matches, an exact
        /// (case-sensitive) match wins, and anything else is rejected as ambiguous rather than guessed.
        /// </summary>
        private PropertyStorage FindConstructorArgumentMember(ParameterInfo parameter)
        {
            var candidates = Properties
                .Where(ps => !ps.IsIgnored && string.Equals(ps.PropertyName, parameter.Name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (candidates.Count == 0)
            {
                throw new InvalidOperationException(
                    $"Constructor parameter '{parameter.Name}' of type {TargetType.FullName} does not map to a modeled member. " +
                    "Every binding constructor parameter must correspond to a readable property or field (matched by name, case-insensitive) " +
                    "that is not marked with [DynamoDBIgnore].");
            }

            if (candidates.Count == 1)
                return candidates[0];

            var exactMatches = candidates
                .Where(ps => string.Equals(ps.PropertyName, parameter.Name, StringComparison.Ordinal))
                .ToList();

            if (exactMatches.Count == 1)
                return exactMatches[0];

            throw new InvalidOperationException(
                $"Constructor parameter '{parameter.Name}' of type {TargetType.FullName} matches more than one modeled member " +
                $"({string.Join(", ", candidates.Select(ps => "'" + ps.PropertyName + "'"))}). Constructor parameters are matched to members " +
                "by name, case-insensitively, so this mapping is ambiguous. Rename the parameter to exactly match the member that supplies it, " +
                "or mark the members that should not be persisted with [DynamoDBIgnore].");
        }

        /// <summary>
        /// Throws when a modeled member cannot be populated while loading an item because it is neither supplied
        /// through the binding constructor nor writable. Such a member is still written when the item is saved, so
        /// allowing it would produce stored items that fail to load.
        /// </summary>
        private void ValidateAllMembersAreLoadable()        {
            foreach (var property in Properties)
            {
                if (property.IsIgnored || property.IsConstructorArgument) continue;
                if (Utils.IsReadWrite(property.Member)) continue;

                throw new InvalidOperationException(
                    $"Property '{property.PropertyName}' of type {TargetType.FullName} is read-only and is not supplied through the constructor " +
                    "used for DynamoDB deserialization, so it would be written when the item is saved but could never be populated when it is loaded. " +
                    "Mark it with [DynamoDBIgnore], make it settable, or select a constructor that includes it with [DynamoDBConstructor].");
            }
        }

        /// <summary>
        /// Throws when a constructor parameter's type cannot accept the value produced for the member that supplies
        /// it. A stored attribute is deserialized as its member's type and then handed to
        /// <see cref="ConstructorInfo.Invoke(object[])"/>, so an incompatible pair (for example an <c>int</c>
        /// parameter fed by a <c>long</c> member) saves successfully and then fails on every load.
        /// </summary>
        private void ValidateConstructorArgumentType(ParameterInfo parameter, PropertyStorage member)
        {
            // A converter decides the run-time type of the deserialized value, so the member's declared type says
            // nothing useful about what the constructor will receive. Converter is the effective converter: it
            // covers an attribute or type-mapping converter and a default converter registered on the context,
            // which is why this runs after Denormalize has called PropertyStorage.Validate.
            if (member.Converter != null || member.ConverterType != null)
                return;

            // The loader can produce the member's declared type, any derived type declared on the member itself,
            // and any declared on the member's type with [DynamoDBPolymorphicType].
            var runtimeTypes = member.PolymorphicDerivedTypes
                .Concat(Utils.GetPolymorphicDerivedTypes(member.MemberType));

            if (Utils.IsAssignableToConstructorParameter(member.MemberType, parameter.ParameterType, runtimeTypes))
                return;

            throw new InvalidOperationException(
                $"Constructor parameter '{parameter.Name}' of type {TargetType.FullName} is declared as " +
                $"{parameter.ParameterType.FullName}, but the member '{member.PropertyName}' that supplies it is " +
                $"{member.MemberType.FullName}. A stored attribute is deserialized as its member's type and then passed to the " +
                "constructor, so this combination would save successfully but fail to load with an argument-type error. " +
                "Declare the parameter and the member with the same type, or use a type the member's type converts to implicitly. " +
                "A parameter type derived from the member's type is only supported when a [DynamoDBPolymorphicType] mapping " +
                "lets the loader create that derived type.");
        }

        /// <summary>
        /// Returns a description of why <paramref name="member"/> holds a value that the SDK reconciles onto the
        /// instance after a save or update, or <c>null</c> when it holds no such value. The SDK writes a
        /// server-produced value back onto the instance for these members once the request completes.
        /// </summary>
        private static string GetServerManagedMemberKind(PropertyStorage member)
        {
            if (member.IsVersion) return "a version property";
            if (member.IsCounter) return "an atomic counter property";
            if (member.IsAutoGeneratedTimestamp) return "an auto-generated timestamp property";
            if (member.UpdateBehaviorMode == UpdateBehavior.IfNotExists) return "a property that uses UpdateBehavior.IfNotExists";
            return null;
        }

        /// <summary>
        /// Throws if <paramref name="member"/> (or, when it is flattened, any of its descendants) holds a value that
        /// the SDK reconciles onto the instance after a save/update — a version, atomic counter, auto-generated
        /// timestamp, or <see cref="UpdateBehavior.IfNotExists"/> member — because that write-back cannot be applied
        /// to an immutable member supplied through the constructor.
        /// </summary>
        private void ValidateConstructorBindableMember(PropertyStorage member, bool viaFlatten)
        {
            var kind = GetServerManagedMemberKind(member);
            if (kind != null)
            {
                string location = viaFlatten
                    ? $"reached through a flattened constructor parameter of type {TargetType.FullName}"
                    : $"of type {TargetType.FullName}";

                throw new InvalidOperationException(
                    $"Property '{member.PropertyName}' ({location}) is {kind} and cannot be supplied through a constructor parameter. " +
                    "These properties are updated by the SDK after a save or update, which requires writing the new value back onto the instance; " +
                    "that is not possible for an immutable (constructor-populated) member. Make it a settable property on a type with a parameterless constructor instead.");
            }

            if (member.ShouldFlattenChildProperties && member.FlattenProperties != null)
            {
                foreach (var child in member.FlattenProperties)
                {
                    ValidateConstructorBindableMember(child, viaFlatten: true);
                }
            }
        }

        /// <summary>
        /// Throws if <paramref name="member"/> (or, when it is flattened, any of its descendants) holds a value that
        /// the SDK reconciles onto the instance after a save/update and the declaring type is a value type. The SDK
        /// boxes the instance before assigning those values through reflection, so the assignment updates the box
        /// rather than the caller's value: optimistic locking would silently break and atomic counter and
        /// UpdateBehavior.IfNotExists members would silently read a stale value after a save.
        /// </summary>
        private void ValidateValueTypeMember(PropertyStorage member, bool viaFlatten)
        {
            var kind = GetServerManagedMemberKind(member);
            if (kind != null)
            {
                string location = viaFlatten
                    ? $"reached through a flattened member of value type {TargetType.FullName}"
                    : $"of value type {TargetType.FullName}";

                throw new InvalidOperationException(
                    $"Property '{member.PropertyName}' ({location}) is {kind} and cannot be declared on a value type (struct or record struct). " +
                    "The SDK writes the new value back onto the instance after a save or update, but a value type is boxed before that assignment, " +
                    "so the caller's value would silently keep the stale value. Declare the type as a class instead.");
            }

            if (member.ShouldFlattenChildProperties && member.FlattenProperties != null)
            {
                foreach (var child in member.FlattenProperties)
                {
                    ValidateValueTypeMember(child, viaFlatten: true);
                }
            }
        }
#endif
    }

    /// <summary>
    /// Storage information for a specific class that is associated with a table
    /// </summary>
    internal class ItemStorageConfig 
    {
        // table
        public string TableName { get; set; }

        public StorageConfig BaseTypeStorageConfig { get; private set; }

        public Dictionary<string, StorageConfig> PolymorphicTypesStorageConfig { get; private set; }

        public Dictionary<Type,string> PolymorphicConfig { get; private set; }

        public bool LowerCamelCaseProperties { get; set; }
        public HashSet<string> AttributesToStoreAsEpoch { get; set; }
        public HashSet<string> AttributesToStoreAsEpochLong { get; set; }

        // keys
        public List<string> HashKeyPropertyNames { get; private set; }
        public List<string> RangeKeyPropertyNames { get; private set; }

        // properties to get
        public List<string> AttributesToGet { get; private set; }

        public Expression ProjectionExpression { get; private set; }

        // version
        public string VersionPropertyName { get; private set; }
        public bool HasVersion { get { return !string.IsNullOrEmpty(VersionPropertyName); } }

        public bool HasAutogeneratedProperties { get; internal set; }

        // attribute-to-index mapping
        public Dictionary<string, List<string>> AttributeToIndexesNameMapping { get; set; }

        // indexName to LSI range key properties mapping
        public Dictionary<string, List<string>> IndexNameToLSIRangePropertiesMapping { get; set; }

        // indexName to GSIConfig mapping
        public Dictionary<string, GSIConfig> IndexNameToGSIMapping { get; set; }

        // search vector indexName to property name mapping (declared via DynamoDBSearchVectorAttribute)
        public Dictionary<string, string> IndexNameToSearchVectorPropertiesMapping { get; set; }

        // entity conversion
        public DynamoDBEntryConversion Conversion { get; set; }


        public bool StorePolymorphicTypes => this.PolymorphicTypesStorageConfig.Any();

        //public void RemovePropertyStorage(string propertyName)
        //{
        //    PropertyStorage storage;
        //    if (!TryGetPropertyStorage(propertyName, out storage))
        //        return;

        //    string attributeName = storage.AttributeName;

        //    // Remove all references
        //    if (storage.IsHashKey)
        //        HashKeyPropertyNames.Remove(propertyName);
        //    if (storage.IsRangeKey)
        //        RangeKeyPropertyNames.Remove(propertyName);
        //    if (storage.IsVersion)
        //        VersionPropertyName = null;
        //    if (storage.IsGSIHashKey)
        //        IndexNameToGSIMapping

        //    AttributesToGet.Remove(attributeName);

        //    PropertyToPropertyStorageMapping.Remove(propertyName);
        //}

        public GSIConfig GetGSIConfig(string indexName)
        {
            GSIConfig gsiConfig;
            if (!this.IndexNameToGSIMapping.TryGetValue(indexName, out gsiConfig))
                gsiConfig = null;
            return gsiConfig;
        }

        public List<string> GetCorrectHashKeyProperty(DynamoDBFlatConfig currentConfig, List<string> hashKeyProperties)
        {
            if (currentConfig.IsIndexOperation)
            {
                string indexName = currentConfig.IndexName;
                GSIConfig gsiConfig = this.GetGSIConfig(indexName);
                // Use GSI hash key if GSI is found AND GSI hash-keys are set
                if (gsiConfig != null && gsiConfig.HashKeyPropertyNames != null && gsiConfig.HashKeyPropertyNames.Count != 0)
                    hashKeyProperties = gsiConfig.HashKeyPropertyNames.OrderBy(kv => kv.Value).Select(kv => kv.Key).ToList(); ;
            }
            return hashKeyProperties;
        }
            
        public List<string> GetRangeKeyByIndex(string indexName)
        {
            List<string> rangeKeyPropertyNames = null;

            // test LSI first
            List<string> rangeProperties;
            if (IndexNameToLSIRangePropertiesMapping.TryGetValue(indexName, out rangeProperties) &&
                rangeProperties != null && rangeProperties.Count == 1)
            {
                rangeKeyPropertyNames = rangeProperties;
            }

            GSIConfig gsiConfig = GetGSIConfig(indexName);
            if (gsiConfig != null)
            {
                rangeKeyPropertyNames = gsiConfig.RangeKeyPropertyNames.OrderBy(kv => kv.Value)
                    .Select(kv=> kv.Key).ToList();
            }

            return rangeKeyPropertyNames;
        }
        public PropertyStorage VersionPropertyStorage
        {
            get
            {
                if (!HasVersion) throw new InvalidOperationException("No version field defined for this type");
                return this.BaseTypeStorageConfig.GetPropertyStorage(VersionPropertyName);
            }
        }

        public void Denormalize(DynamoDBContext context, string derivedTypeAttributeName)
        {
            // analyze all PropertyStorage configs and denormalize data into other properties
            // all data must exist in PropertyStorage objects prior to denormalization

            foreach (var property in this.BaseTypeStorageConfig.Properties)
            {
                ProcessProperty(property, this.BaseTypeStorageConfig, true);
            }

            foreach (var polymorphicTypesProperty in this.PolymorphicTypesStorageConfig)
            {
                foreach (var polymorphicProperty in polymorphicTypesProperty.Value.Properties)
                {
                    ProcessProperty(polymorphicProperty, polymorphicTypesProperty.Value, false);
                }
            }

            if (StorePolymorphicTypes)
            {
                AttributesToGet.Add(derivedTypeAttributeName);
                AddAttributeNameToProjectionExpression(derivedTypeAttributeName);
            }

            if (this.BaseTypeStorageConfig.Properties.Count == 0)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Type {0} is unsupported, it has no supported members", this.BaseTypeStorageConfig.TargetType.FullName));
            return;

            void ProcessProperty(PropertyStorage property, StorageConfig storageConfig, bool setKeyProperties)
            {
                // only add non-ignored properties
                if (property.IsIgnored)
                    return;

                property.Validate(context);

                SetPropertyConfig(property, storageConfig, setKeyProperties);

                if (!property.ShouldFlattenChildProperties) return;

                // flatten properties
                foreach (var flattenProperty in property.FlattenProperties)
                {
                    ProcessProperty(flattenProperty, storageConfig, setKeyProperties);
                }
            }

            void SetPropertyConfig(PropertyStorage property, StorageConfig storageConfig, bool setKeyProperties)
            {
                AddPropertyStorage(property, storageConfig);

                string propertyName = property.PropertyName;

                if (setKeyProperties)
                {
                    AddKeyPropertyNames(property, propertyName);
                }

                foreach (var index in property.Indexes)
                {
                    var gsi = index as PropertyStorage.GSI;
                    if (gsi != null)
                        AddGSIConfigs(gsi.IndexNames, propertyName, gsi.IsHashKey, gsi.Order);

                    var lsi = index as PropertyStorage.LSI;
                    if (lsi != null)
                        AddLSIConfigs(lsi.IndexNames, propertyName);
                }

                if (property.IsSearchVector)
                    AddSearchVectorConfigs(property.SearchVectorIndexNames, propertyName);
            }
        }

        public void AddPolymorphicPropertyStorageConfiguration(string typeDiscriminator, Type derivedType, StorageConfig polymorphicStorageConfig)
        {
            this.PolymorphicTypesStorageConfig.Add(typeDiscriminator, polymorphicStorageConfig);
            this.PolymorphicConfig.Add(derivedType, typeDiscriminator);
        }

        private void AddAttributeNameToProjectionExpression(string derivedTypeAttributeName)
        {
            var expressionAttributeCount = ProjectionExpression.ExpressionAttributeNames.Count;
            var expressionAttributeName = "#P" + expressionAttributeCount.ToString(CultureInfo.InvariantCulture);

            var currentExpressionStatement = ProjectionExpression.ExpressionStatement;
            if (string.IsNullOrEmpty(currentExpressionStatement))
            {
                ProjectionExpression.ExpressionStatement = expressionAttributeName;
            }
            else
            {
                ProjectionExpression.ExpressionStatement = expressionAttributeCount > 0
                    ? string.Concat(currentExpressionStatement, ", ", expressionAttributeName)
                    : string.Concat(currentExpressionStatement, expressionAttributeName);
            }

            ProjectionExpression.ExpressionAttributeNames.Add(expressionAttributeName, derivedTypeAttributeName);
        }

        private void AddPropertyStorage(PropertyStorage value, StorageConfig config)
        {
            string propertyName = value.PropertyName;
            string attributeName = value.AttributeName;

            config.AddPropertyStorage(propertyName, value);

            if (!AttributesToGet.Contains(attributeName))
                AttributesToGet.Add(attributeName);

            if (!ProjectionExpression.ExpressionAttributeNames.ContainsValue(attributeName))
                AddAttributeNameToProjectionExpression(attributeName);

            if (value.StoreAsEpoch)
                AttributesToStoreAsEpoch.Add(attributeName);
            if (value.StoreAsEpochLong)
                AttributesToStoreAsEpochLong.Add(attributeName);

            if (value.IsLSIRangeKey || value.IsGSIKey)
            {
                List<string> indexes;
                if (!AttributeToIndexesNameMapping.TryGetValue(attributeName, out indexes))
                {
                    indexes = new List<string>();
                    AttributeToIndexesNameMapping[attributeName] = indexes;
                }

                foreach (var index in value.IndexNames)
                {
                    if (!indexes.Contains(index))
                        indexes.Add(index);
                }
            }
        }

        private void AddKeyPropertyNames(PropertyStorage value, string propertyName)
        {
            if (value.IsHashKey)
                HashKeyPropertyNames.Add(propertyName);
            if (value.IsRangeKey)
                RangeKeyPropertyNames.Add(propertyName);
            if (!value.IsVersion) return;

            if (!string.IsNullOrEmpty(VersionPropertyName))
                throw new InvalidOperationException("Multiple version properties defined: " + VersionPropertyName + " and " + propertyName);
            VersionPropertyName = propertyName;
        }

        private void AddLSIConfigs(List<string> lsiIndexNames, string propertyName)
        {
            foreach (var index in lsiIndexNames)
            {
                List<string> properties;
                if (!this.IndexNameToLSIRangePropertiesMapping.TryGetValue(index, out properties))
                {
                    properties = new List<string>();
                    this.IndexNameToLSIRangePropertiesMapping[index] = properties;
                }
                if (!properties.Contains(propertyName, StringComparer.Ordinal))
                    properties.Add(propertyName);
            }
        }

        private void AddSearchVectorConfigs(List<string> searchVectorIndexNames, string propertyName)
        {
            if (searchVectorIndexNames == null)
                return;

            foreach (var index in searchVectorIndexNames)
            {
                if (string.IsNullOrEmpty(index))
                    continue;

                if (this.IndexNameToSearchVectorPropertiesMapping.TryGetValue(index, out var existingPropertyName) &&
                    !string.Equals(existingPropertyName, propertyName, StringComparison.Ordinal))
                {
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                        "Search vector index {0} is declared on multiple properties: {1} and {2}.", index, existingPropertyName, propertyName));
                }

                this.IndexNameToSearchVectorPropertiesMapping[index] = propertyName;
            }
        }

        private void AddGSIConfigs(List<string> gsiIndexNames, string propertyName, bool isHashKey, int order)
        {
            foreach (var index in gsiIndexNames)
            {
                GSIConfig gsiConfig = this.GetGSIConfig(index);
                if (gsiConfig == null)
                {
                    gsiConfig = new GSIConfig(index);
                    this.IndexNameToGSIMapping[index] = gsiConfig;
                }

                var targetDict = isHashKey ? gsiConfig.HashKeyPropertyNames : gsiConfig.RangeKeyPropertyNames;

                string keyToRemove = null;
                foreach (var kv in targetDict)
                {
                    if (kv.Value != order) continue;
                    keyToRemove = kv.Key;
                    break;
                }
                if (keyToRemove != null)
                {
                    targetDict.Remove(keyToRemove);
                }

                targetDict[propertyName] = order;
            }
        }

        // constructor
        internal ItemStorageConfig([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType)
        {
            BaseTypeStorageConfig = new StorageConfig(targetType);
            PolymorphicTypesStorageConfig = new Dictionary<string, StorageConfig>();
            PolymorphicConfig= new Dictionary<Type, string>();
            AttributeToIndexesNameMapping = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            IndexNameToLSIRangePropertiesMapping = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            IndexNameToGSIMapping = new Dictionary<string, GSIConfig>(StringComparer.Ordinal);
            IndexNameToSearchVectorPropertiesMapping = new Dictionary<string, string>(StringComparer.Ordinal);
            AttributesToGet = new List<string>();
            ProjectionExpression = new Expression();
            HashKeyPropertyNames = new List<string>();
            RangeKeyPropertyNames = new List<string>();
            AttributesToStoreAsEpoch = new HashSet<string>();
            AttributesToStoreAsEpochLong = new HashSet<string>();
        }
    }


    /// <summary>
    /// Cache of ItemStorageConfig objects
    /// </summary>
    internal class ItemStorageConfigCache : IDisposable
    {
        // Cache of ItemStorageConfig objects per table and the
        // base, table-less ItemStorageConfig
        private class ConfigTableCache
        {
            public Dictionary<string, ItemStorageConfig> Cache { get; private set; }
            public ItemStorageConfig BaseTypeConfig { get; private set; }

            public ConfigTableCache(ItemStorageConfig baseTypeConfig)
            {
                BaseTypeConfig = baseTypeConfig;
                BaseTableName = BaseTypeConfig.TableName;
                Cache = new Dictionary<string, ItemStorageConfig>(StringComparer.Ordinal);
            }
            public string BaseTableName { get; private set; }
        }

        private Dictionary<Type, ConfigTableCache> Cache;
        private DynamoDBContext Context;
        private bool disposedValue;
        private readonly ReaderWriterLockSlim _readerWriterLockSlim = new ReaderWriterLockSlim();

        public ItemStorageConfigCache(DynamoDBContext context)
        {
            Cache = new Dictionary<Type, ConfigTableCache>();
            Context = context;
        }

        public ItemStorageConfig GetConfig<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(DynamoDBFlatConfig flatConfig, bool conversionOnly = false)
        {
            Type type = typeof(T);
            return GetConfig(type, flatConfig, conversionOnly);
        }

        public ItemStorageConfig GetConfig([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type, DynamoDBFlatConfig flatConfig, bool conversionOnly = false)
        {
            ConfigTableCache tableCache = null;
            ItemStorageConfig config;
            
            string actualTableName = null;

            try
            {
                _readerWriterLockSlim.EnterReadLock();

                Cache.TryGetValue(type, out tableCache);
                if(tableCache != null)
                {
                    // If this type is only used for conversion, do not attempt to populate the config from the table.
                    // Only propagate the nested type's conversion when it declares its own schema (via DynamoDBTable);
                    // a table-less nested type has a null Conversion and must not override the enclosing item's conversion.
                    if (conversionOnly)
                    {
                        if (flatConfig != null && tableCache.BaseTypeConfig.Conversion != null)
                            flatConfig.ItemConversion = tableCache.BaseTypeConfig.Conversion;
                        return tableCache.BaseTypeConfig;
                    }

                    actualTableName = DynamoDBContext.GetTableName(tableCache.BaseTableName, flatConfig);

                    if (tableCache.Cache.TryGetValue(actualTableName, out config))
                    {
                        if (flatConfig == null)
                            throw new ArgumentNullException("flatConfig");

                        flatConfig.ItemConversion = config.Conversion;
                        return config;
                    }
                }
            }
            finally
            {
                if(_readerWriterLockSlim.IsReadLockHeld)
                {
                    _readerWriterLockSlim.ExitReadLock();
                }
            }

            try
            {
                _readerWriterLockSlim.EnterWriteLock();

                if (tableCache == null)
                {
                    // Check to see if another thread go the write lock before this thread and filled the cache.
                    Cache.TryGetValue(type, out tableCache);

                    if (tableCache == null)
                    {
                        var baseStorageConfig = CreateStorageConfig(type, actualTableName: null, flatConfig);
                        flatConfig.ItemConversion = baseStorageConfig.Conversion;

                        tableCache = new ConfigTableCache(baseStorageConfig);
                        Cache[type] = tableCache;
                    }
                }

                // If this type is only used for conversion, do not attempt to populate the config from the table.
                // Only propagate the nested type's conversion when it declares its own schema (via DynamoDBTable);
                // a table-less nested type has a null Conversion and must not override the enclosing item's conversion.
                if (conversionOnly)
                {
                    if (flatConfig != null && tableCache.BaseTypeConfig.Conversion != null)
                        flatConfig.ItemConversion = tableCache.BaseTypeConfig.Conversion;
                    return tableCache.BaseTypeConfig;
                }

                if (actualTableName == null)
                {
                    actualTableName = DynamoDBContext.GetTableName(tableCache.BaseTableName, flatConfig);
                }

                // Check to see if another thread go the write lock before this thread and filled the cache.
                if (tableCache.Cache.TryGetValue(actualTableName, out config))
                {
                    return config;
                }

                config = CreateStorageConfig(type, actualTableName, flatConfig);
                flatConfig.ItemConversion = config.Conversion;
                tableCache.Cache[actualTableName] = config;

                return config;
            }
            finally
            {
                if(_readerWriterLockSlim.IsWriteLockHeld)
                {
                    _readerWriterLockSlim.ExitWriteLock();
                }
            }
        }

        private static string GetAccurateCase(ItemStorageConfig config, string value)
        {
            return (config.LowerCamelCaseProperties ? Utils.ToLowerCamelCase(value) : value);
        }

        private ItemStorageConfig CreateStorageConfig([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type baseType, string actualTableName, DynamoDBFlatConfig flatConfig)
        {
            if (baseType == null) 
                throw new ArgumentNullException("baseType");

            ItemStorageConfig config = new ItemStorageConfig(baseType);

            PopulateConfigFromType(config, baseType);
            PopulateConfigFromMappings(config, AWSConfigsDynamoDB.Context.TypeMappings);

            // try to populate config from table definition only if actual table name is known
            if (!string.IsNullOrEmpty(actualTableName))
            {
                Table table;
                try
                {
                    table = Context.GetUnconfiguredTable(actualTableName, flatConfig.DisableFetchingTableMetadata);
                }
                catch
                {
                    table = null;
                }

                if (table != null)
                {
                    PopulateConfigFromTable(config, table);
                }
            }

            config.Denormalize(Context, flatConfig.DerivedTypeAttributeName);

#if NET8_0_OR_GREATER
            // Resolve binding-constructor arguments after Denormalize, which is where PropertyStorage.Validate
            // assigns the effective converter. Running earlier would miss a default converter registered on the
            // context (DynamoDBContext.ConverterCache is only consulted there). Mapping-level flags such as
            // version, counter and ignore are already final by this point as well.
            config.BaseTypeStorageConfig.ResolveConstructorArguments();
            foreach (var polymorphicStorageConfig in config.PolymorphicTypesStorageConfig.Values)
            {
                polymorphicStorageConfig.ResolveConstructorArguments();
            }
#endif

            if (flatConfig.DisableFetchingTableMetadata)
            {
                if (string.IsNullOrEmpty(actualTableName))
                {
                    actualTableName = DynamoDBContext.GetTableName(config.TableName, flatConfig);
                }
                var emptyConfig = new TableConfig(actualTableName, conversion: null, consumer: Table.DynamoDBConsumer.DataModel,
                    storeAsEpoch: null, storeAsEpochLong: null, isEmptyStringValueEnabled: false, metadataCachingMode: flatConfig.MetadataCachingMode);
                var table = Table.CreateTableFromItemStorageConfig(Context.Client, emptyConfig, config, flatConfig);

                // The table info must be cached under the actual table name exactly how it exists in the DynamoDB service.
                // This is done to mimic the caching behavior when DisableFetchingTableMetadata is set to false.
                Context.StoreUnconfiguredTable(actualTableName, table);
            }
            return config;
        }

        private static void PopulateConfigFromType(ItemStorageConfig config, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)]  Type type)
        {
            DynamoDBTableAttribute tableAttribute = Utils.GetTableAttribute(type);
            if (tableAttribute == null)
            {
                config.TableName = type.Name;
            }
            else
            {
                if (string.IsNullOrEmpty(tableAttribute.TableName)) throw new InvalidOperationException("DynamoDBTableAttribute.Table is empty or null");
                config.TableName = tableAttribute.TableName;
                config.LowerCamelCaseProperties = tableAttribute.LowerCamelCaseProperties;

                config.Conversion = tableAttribute.Conversion switch
                {
                    ConversionSchema.V1 => DynamoDBEntryConversion.V1,
                    ConversionSchema.V2 => DynamoDBEntryConversion.V2,
                    _ => config.Conversion
                };
            }

            string tableAlias;
            if (AWSConfigsDynamoDB.Context.TableAliases.TryGetValue(config.TableName, out tableAlias))
                config.TableName = tableAlias;

            ICollection<string> baseConstructorParameterNames = null;
#if NET8_0_OR_GREATER
            baseConstructorParameterNames = config.BaseTypeStorageConfig.ConstructorParameterNames;
#endif
            var members = Utils.GetMembersFromType(type, baseConstructorParameterNames);

            foreach (var member in members)
            {
                var propertyStorage = MemberInfoToPropertyStorage(config, member);

                if (!propertyStorage.IsIgnored)
                {
                    ValidateAttributeName(config, propertyStorage.AttributeName);
                }

                config.BaseTypeStorageConfig.Properties.Add(propertyStorage);
            }

            DynamoDBPolymorphicTypeAttribute[] polymorphicTypeAttribute = Utils.GetPolymorphicTypesAttribute(type);

            if (polymorphicTypeAttribute is not { Length: > 0 }) return;
            {
                foreach (var attribute in polymorphicTypeAttribute)
                {
                    if (attribute.DerivedType == null)
                    {
                        throw new InvalidOperationException("Invalid polymorphic type: DerivedType is null.");
                    }

                    if (!attribute.DerivedType.IsSubclassOf(type))
                    {
                        throw new InvalidOperationException($"Invalid polymorphic type: '{attribute.DerivedType.FullName}' must be a subclass of '{type.FullName}'.");
                    }

                    var polymorphicStorageConfig = new StorageConfig(attribute.DerivedType);

                    ICollection<string> polymorphicConstructorParameterNames = null;
#if NET8_0_OR_GREATER
                    polymorphicConstructorParameterNames = polymorphicStorageConfig.ConstructorParameterNames;
#endif
                    var polymorphicTypeMembers = Utils.GetMembersFromType(attribute.DerivedType, polymorphicConstructorParameterNames);

                    foreach (var member in polymorphicTypeMembers)
                    {
                        var propertyStorage = MemberInfoToPropertyStorage(config, member);
                        polymorphicStorageConfig.Properties.Add(propertyStorage);
                    }

                    config.AddPolymorphicPropertyStorageConfiguration(attribute.TypeDiscriminator, attribute.DerivedType, polymorphicStorageConfig);

                }
            }
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2072",
            Justification = "The user's type has been annotated with DynamicallyAccessedMemberTypes.All with the public API into the library. At this point the type will not be trimmed.")]
        private static PropertyStorage MemberInfoToPropertyStorage(ItemStorageConfig config, MemberInfo member)
        {
            // prepare basic info
            PropertyStorage propertyStorage = new PropertyStorage(member);
            propertyStorage.AttributeName = GetAccurateCase(config, member.Name);

            // run through all DDB attributes
            List<DynamoDBAttribute> allAttributes = Utils.GetAttributes(member);

            if(allAttributes.Count>1 &&
                allAttributes.Any(a => a is DynamoDBFlattenAttribute))
            {
                throw new InvalidOperationException("DynamoDBFlatten cannot be combined with other annotations.");
            }

            foreach (var attribute in allAttributes)
            {
                // filter out ignored properties
                if (attribute is DynamoDBIgnoreAttribute)
                {
                    propertyStorage.IsIgnored = true;
                    continue;
                }

                // flatten properties
                if (attribute is DynamoDBFlattenAttribute)
                {
                    propertyStorage.ShouldFlattenChildProperties = true;

                    var type = Utils.GetType(member);

                    if (Utils.IsCollectionType(type) || Utils.IsPrimitive(type))
                    {
                        throw new InvalidOperationException("Cannot flatten primitive types or collections. Only complex objects are supported.");
                    }

#if NET8_0_OR_GREATER
                    // A flattened value is reconstructed with a parameterless constructor during loading
                    // (see CreateFlattenedMember). A type that is populated through a binding constructor
                    // (e.g. a record or other immutable type) cannot be created that way, so it would serialize
                    // but fail to load. Reject the combination at configuration time to fail fast and symmetrically.
                    if (Utils.TryGetBindingConstructor(type, out _))
                    {
                        throw new InvalidOperationException(
                            $"Property '{propertyStorage.PropertyName}' is marked [DynamoDBFlatten] but its type {type.FullName} is an immutable type populated through a constructor. " +
                            "Flattening is not supported for constructor-populated (e.g. record) types because a flattened value is reconstructed with a parameterless constructor when loading. " +
                            "Use a type with a parameterless constructor and settable members, or store it as a nested (non-flattened) property.");
                    }
#endif

                    // A flattened value is materialized by CreateFlattenedMember when the item is loaded. Reject a
                    // type it cannot materialize here, at configuration time, so that saving and loading fail the
                    // same way with a message that names the property. Without this the failure surfaces only while
                    // loading, as a bare "Cannot instantiate type" that does not say which member caused it.
                    bool canMaterializeFlattenedType = Utils.CanInstantiateConverter(type);
#if NET8_0_OR_GREATER
                    // Value types are materialized by zero-initialization instead (see CreateFlattenedMember).
                    canMaterializeFlattenedType = canMaterializeFlattenedType || type.IsValueType;
#endif
                    if (!canMaterializeFlattenedType)
                    {
                        throw new InvalidOperationException(
                            $"Property '{propertyStorage.PropertyName}' is marked [DynamoDBFlatten] but its type {type.FullName} cannot be instantiated. " +
                            "A flattened value is reconstructed when the item is loaded, which requires a public parameterless constructor " +
                            "(or one accepting a DynamoDBContext) and settable members. Give the type such a constructor, or store it as a " +
                            "nested (non-flattened) property.");
                    }

                    var members = Utils.GetMembersFromType(type);

                    foreach (var memberInfo in members)
                    {
                        var flattenPropertyStorage = MemberInfoToPropertyStorage(config, memberInfo);

                        flattenPropertyStorage.IsFlattened = true;

                        propertyStorage.FlattenProperties.Add(flattenPropertyStorage);
                    }
                }

                if (attribute is DynamoDBVersionAttribute)
                    propertyStorage.IsVersion = true;

                DynamoDBAtomicCounterAttribute counterAttribute = attribute as DynamoDBAtomicCounterAttribute;
                if (counterAttribute != null)
                {
                    propertyStorage.IsCounter = true;
                    propertyStorage.CounterDelta = counterAttribute.Delta;
                    propertyStorage.CounterStartValue = counterAttribute.StartValue;
                }

                DynamoDBSearchVectorAttribute searchVectorAttribute = attribute as DynamoDBSearchVectorAttribute;
                if (searchVectorAttribute != null)
                {
                    propertyStorage.IsSearchVector = true;
                    if (!string.IsNullOrEmpty(searchVectorAttribute.IndexName))
                        propertyStorage.SearchVectorIndexNames.Add(searchVectorAttribute.IndexName);
                }

                DynamoDBRenamableAttribute renamableAttribute = attribute as DynamoDBRenamableAttribute;
                if (renamableAttribute != null && !string.IsNullOrEmpty(renamableAttribute.AttributeName))
                {
                    propertyStorage.AttributeName = GetAccurateCase(config, renamableAttribute.AttributeName);
                }

                DynamoDBPropertyAttribute propertyAttribute = attribute as DynamoDBPropertyAttribute;
                if (propertyAttribute != null)
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    propertyStorage.StoreAsEpoch = propertyAttribute.StoreAsEpoch;
#pragma warning restore CS0618 // Type or member is obsolete
                    propertyStorage.StoreAsEpochLong = propertyAttribute.StoreAsEpochLong;

                    if (propertyAttribute.Converter != null)
                        propertyStorage.ConverterType = propertyAttribute.Converter;
                        
                    if (propertyAttribute is DynamoDBHashKeyAttribute)
                    {
                        var gsiHashAttribute = propertyAttribute as DynamoDBGlobalSecondaryIndexHashKeyAttribute;
                        if (gsiHashAttribute != null)
                        {
                            propertyStorage.IsGSIHashKey = true;
                            propertyStorage.AddIndex(gsiHashAttribute);
                        }
                        else
                            propertyStorage.IsHashKey = true;
                    }
                    if (propertyAttribute is DynamoDBRangeKeyAttribute)
                    {
                        var gsiRangeAttribute = propertyAttribute as DynamoDBGlobalSecondaryIndexRangeKeyAttribute;
                        if (gsiRangeAttribute != null)
                        {
                            propertyStorage.IsGSIRangeKey = true;
                            propertyStorage.AddIndex(gsiRangeAttribute);
                        }
                        else
                            propertyStorage.IsRangeKey = true;
                    }

                    if (propertyAttribute is DynamoDBAutoGeneratedTimestampAttribute)
                    {
                        propertyStorage.IsAutoGeneratedTimestamp = true;
                        config.HasAutogeneratedProperties = true;
                    }

                    if (propertyAttribute is DynamoDbUpdateBehaviorAttribute updateBehaviorAttribute)
                    {
                        propertyStorage.UpdateBehaviorMode = updateBehaviorAttribute.Behavior;
                    }

                    DynamoDBLocalSecondaryIndexRangeKeyAttribute lsiRangeKeyAttribute = propertyAttribute as DynamoDBLocalSecondaryIndexRangeKeyAttribute;
                    if (lsiRangeKeyAttribute != null)
                    {
                        propertyStorage.IsLSIRangeKey = true;
                        propertyStorage.AddIndex(lsiRangeKeyAttribute);
                    }
                }

                DynamoDBPolymorphicTypeAttribute polymorphicAttribute = attribute as DynamoDBPolymorphicTypeAttribute;
                if (polymorphicAttribute != null)
                {
                    propertyStorage.PolymorphicProperty = true;
                    propertyStorage.AddDerivedType(polymorphicAttribute.TypeDiscriminator, polymorphicAttribute.DerivedType);
                }
            }

            return  propertyStorage;
        }

        private static void PopulateConfigFromTable(ItemStorageConfig config, Table table)
        {
            PropertyStorage property;

            // keys
            foreach(var key in table.Keys)
            {
                var attributeName = key.Key;
                var keyDescription = key.Value;

                property = GetProperty(config, attributeName, false);

                // validate against table
                if (property.IsKey)
                    ValidateProperty(property.IsHashKey == keyDescription.IsHash,
                        property.PropertyName, "Property key definition must match table key definition");

                // populate property
                if (keyDescription.IsHash)
                    property.IsHashKey = true;
                else
                    property.IsRangeKey = true;
            }

            foreach (var kvp in table.GlobalSecondaryIndexes)
            {
                string indexName = kvp.Key;
                var gsi = kvp.Value;
                var hashKeyOrder = 0;
                var rangeKeyOrder = 0;
                var keyOrder = 0;
                foreach (var element in gsi.KeySchema)
                {
                    string attributeName = element.AttributeName;
                    bool isHashKey = element.KeyType == KeyType.HASH;
                    property = GetProperty(config, attributeName, true);
                    if (property != null)
                    {
                        keyOrder = isHashKey ? hashKeyOrder : rangeKeyOrder;
                        
                        // Check for existing properties with same GSI configuration and remove index
                        foreach (var existingProperty in config.BaseTypeStorageConfig.Properties)
                        {
                            var gsiToModify = existingProperty.Indexes.OfType<PropertyStorage.GSI>()
                                .FirstOrDefault(gsiIndex => gsiIndex.IndexNames.Contains(indexName) &&
                                                            gsiIndex.Order == keyOrder &&
                                                            gsiIndex.IsHashKey == isHashKey);
                            if (gsiToModify != null)
                            {
                                gsiToModify.IndexNames.Remove(indexName);
                                if (gsiToModify.IndexNames.Count == 0)
                                {
                                    existingProperty.Indexes.Remove(gsiToModify);
                                }
                            }
                        }
                        
                        property.AddGsiIndex(isHashKey, attributeName, keyOrder, indexName);

                        if (isHashKey)
                        {
                            hashKeyOrder++;
                        }
                        else
                        {
                            rangeKeyOrder++;
                        }

                    }
                }
            }

            foreach (var kvp in table.LocalSecondaryIndexes)
            {
                string indexName = kvp.Key;
                var lsi = kvp.Value;

                foreach (var element in lsi.KeySchema)
                {
                    string attributeName = element.AttributeName;
                    bool isHashKey = element.KeyType == KeyType.HASH;

                    // only add for range keys
                    if (!isHashKey)
                    {
                        property = GetProperty(config, attributeName, true);
                        if (property != null)
                        {
                            property.AddLsiIndex(attributeName, indexName);
                        }
                    }
                }
            }

        }


        private static void PopulateConfigFromMappings(ItemStorageConfig config, Dictionary<Type, TypeMapping> typeMappings)
        {
            var baseType = config.BaseTypeStorageConfig.TargetType;
            TypeMapping typeMapping;
            if (typeMappings.TryGetValue(baseType, out typeMapping))
            {
                config.TableName = typeMapping.TargetTable;

                if (AWSConfigsDynamoDB.Context.TableAliases.TryGetValue(config.TableName, out var tableAlias))
                    config.TableName = tableAlias;

                foreach (var kvp in typeMapping.PropertyConfigs)
                {
                    PropertyConfig propertyConfig = kvp.Value;
                    string propertyName = propertyConfig.Name;

                    PropertyStorage propertyStorage;
                    if (!config.BaseTypeStorageConfig.FindPropertyByPropertyName(propertyName, out propertyStorage))
                        throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                            "No matching property {0} on type {1}", propertyName, baseType.FullName));

                    if (!string.IsNullOrEmpty(propertyConfig.Attribute))
                        propertyStorage.AttributeName = propertyConfig.Attribute;
                    if (propertyConfig.Converter != null)
                        propertyStorage.ConverterType = propertyConfig.Converter;
                    propertyStorage.IsIgnored = propertyConfig.Ignore;
                    propertyStorage.IsVersion = propertyConfig.Version;
                    propertyStorage.StoreAsEpoch = propertyConfig.StoreAsEpoch;
                    propertyStorage.StoreAsEpochLong = propertyConfig.StoreAsEpochLong;
                }
            }
        }

        // Finds an existing PropertyStorage for a property by its attributeName,
        // or creates a new PropertyStorage and adds it to the config.
        // If a property is non-optional and is not present on the type, throws an exception.
        // If a property is optional and not present on the type, returns null.
        private static PropertyStorage GetProperty(ItemStorageConfig config, string attributeName, bool optional)
        {
            PropertyStorage property = null;

            bool exists = config.BaseTypeStorageConfig.FindSinglePropertyByAttributeName(attributeName, out property);
            if (!exists)
            {
                // property storage doesn't exist yet, create and populate
                MemberInfo member;

                // for optional properties/attributes, a null MemberInfo is OK
                Validate(config.BaseTypeStorageConfig.TargetTypeMembers.TryGetValue(attributeName, out member) || optional,
                    "Unable to locate property for key attribute {0}", attributeName);

                if (member != null)
                {
                    property = new PropertyStorage(member);
                    property.AttributeName = attributeName;
                    config.BaseTypeStorageConfig.Properties.Add(property);
                }
            }

            return property;
        }
        
        private static List<PropertyStorage> GetIndexProperties(ItemStorageConfig config, string indexName)
        {
            return config.BaseTypeStorageConfig.Properties
                .Where(p => p.Indexes != null && p.Indexes.Any(gsi => gsi.IndexNames.Contains(indexName)))
                .ToList();
        }

        private static void Validate(bool value, string messageFormat, params object[] args)
        {
            if (!value)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(CultureInfo.InvariantCulture, messageFormat, args);
                throw new InvalidOperationException(sb.ToString());
            }
        }
        private static void ValidateProperty(bool value, string propertyName, string messageFormat, params object[] args)
        {
            if (!value)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(CultureInfo.InvariantCulture, "Error with property [{0}]: ", propertyName);
                sb.AppendFormat(CultureInfo.InvariantCulture, messageFormat, args);
                throw new InvalidOperationException(sb.ToString());
            }
        }

        private static void ValidateAttributeName(ItemStorageConfig config, string attributeName)
        {
            foreach (var property in config.BaseTypeStorageConfig.Properties)
            {
                if (string.Equals(property.AttributeName, attributeName) && !property.IsIgnored)
                {
                    throw new InvalidOperationException(
                        $"Attempt to add an attribute that is already defined.[Attribute name: {attributeName}]");
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _readerWriterLockSlim.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
