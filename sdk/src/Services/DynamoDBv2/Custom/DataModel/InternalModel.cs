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
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Util.Internal;
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

        public void AddDerivedType(string typeDiscriminator, Type type)
        {
            DerivedTypesDictionary[type] = typeDiscriminator;
            DerivedTypeKeysDictionary[typeDiscriminator] = type;
        }

        // derived type information used for polymorphic serialization
        public Dictionary<Type, string> DerivedTypesDictionary { get; private set; }

        // derived type information used for polymorphic deserialization
        public Dictionary<string, Type> DerivedTypeKeysDictionary { get; private set; }

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
            DerivedTypesDictionary = new Dictionary<Type, string>();
            DerivedTypeKeysDictionary = new Dictionary<string,Type>();
        }
        internal SimplePropertyStorage([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type memberType, Dictionary<Type, string> derivedTypesDictionary)
        {
            MemberType = memberType;
            DerivedTypesDictionary = derivedTypesDictionary;
        }
        internal SimplePropertyStorage([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type memberType, Dictionary<string, Type> derivedTypeKeysDictionary)
        {
            MemberType = memberType;
            DerivedTypeKeysDictionary = derivedTypeKeysDictionary;
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

        // whether to store DateTime as epoch seconds integer
        public bool StoreAsEpoch { get; set; }

        // whether to store Type Discriminator for polymorphic serialization
        public bool PolymorphicProperty { get; set; }

        // corresponding IndexNames, if applicable
        public List<string> IndexNames { get; set; }

        public void AddIndex(DynamoDBGlobalSecondaryIndexHashKeyAttribute gsiHashKey)
        {
            AddIndex(new GSI(true, gsiHashKey.AttributeName, gsiHashKey.IndexNames));
        }
        public void AddIndex(DynamoDBGlobalSecondaryIndexRangeKeyAttribute gsiRangeKey)
        {
            AddIndex(new GSI(false, gsiRangeKey.AttributeName, gsiRangeKey.IndexNames));
        }
        public void AddIndex(DynamoDBLocalSecondaryIndexRangeKeyAttribute lsiRangeKey)
        {
            AddIndex(new LSI(lsiRangeKey.AttributeName, lsiRangeKey.IndexNames));
        }
        public void AddGsiIndex(bool isHashKey, string attributeName, params string[] indexNames)
        {
            AddIndex(new GSI(isHashKey, attributeName, indexNames));
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

            public GSI(bool isHashKey, string attributeName, params string[] indexNames)
                : base(attributeName, indexNames)
            {
                IsHashKey = isHashKey;
            }
        }

        /// <summary>
        /// Validates configurations and sets required fields
        /// </summary>
        public void Validate(DynamoDBContext context)
        {
            if (IsVersion)
                Utils.ValidateVersionType(MemberType);    // no conversion is possible, so type must be a nullable primitive

            if (IsHashKey && IsRangeKey)
                throw new InvalidOperationException("Property " + PropertyName + " cannot be both hash and range key");

            if (ConverterType != null)
            {
                if (PolymorphicProperty)
                    throw new InvalidOperationException("Converter for " + PropertyName + " must not be set at the same time as derived types.");

                if (StoreAsEpoch)
                    throw new InvalidOperationException("Converter for " + PropertyName + " must not be set at the same time as StoreAsEpoch is set to true");

                if (!Utils.CanInstantiateConverter(ConverterType) || !Utils.ImplementsInterface(ConverterType, typeof(IPropertyConverter)))
                    throw new InvalidOperationException("Converter for " + PropertyName + " must be instantiable with no parameters and must implement IPropertyConverter");

                this.Converter = Utils.InstantiateConverter(ConverterType, context) as IPropertyConverter;
            }

            IPropertyConverter converter;
            if (context.ConverterCache.TryGetValue(MemberType, out converter) && converter != null)
            {
                this.Converter = converter;
            }

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
        }

        // index name
        public string IndexName { get; set; }

        // keys
        public string HashKeyPropertyName { get; set; }
        public string RangeKeyPropertyName { get; set; }
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

        // storage mappings
        private Dictionary<string, PropertyStorage> PropertyToPropertyStorageMapping { get; set; }

        internal void AddPropertyStorage(string propertyName, PropertyStorage propertyStorage)
        {
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

        private static Dictionary<string, MemberInfo> GetMembersDictionary([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type)
        {
            Dictionary<string, MemberInfo> dictionary = new Dictionary<string, MemberInfo>(StringComparer.Ordinal);

            var members = Utils.GetMembersFromType(type);
            
            foreach (var member in members)
            {
                InternalSDKUtils.AddToDictionary(dictionary, member.Name, member);
            }

            return dictionary;
        }



        // constructor
        internal StorageConfig([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType)
        {
            if (!Utils.CanInstantiate(targetType))
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
                    errorMessage = $"Type {targetType.FullName} is unsupported, it cannot be instantiated";
                }

                throw new InvalidOperationException(errorMessage);
            }

            TargetType = targetType;
            Properties = new List<PropertyStorage>();
            PropertyToPropertyStorageMapping = new Dictionary<string, PropertyStorage>(StringComparer.Ordinal);
            TargetTypeMembers = GetMembersDictionary(targetType);

            if (TargetTypeMembers.Count == 0)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Type {0} is unsupported, it has no supported members", targetType.FullName));
        }
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

        // keys
        public List<string> HashKeyPropertyNames { get; private set; }
        public List<string> RangeKeyPropertyNames { get; private set; }

        // properties to get
        public List<string> AttributesToGet { get; private set; }

        // version
        public string VersionPropertyName { get; private set; }
        public bool HasVersion { get { return !string.IsNullOrEmpty(VersionPropertyName); } }

        // attribute-to-index mapping
        public Dictionary<string, List<string>> AttributeToIndexesNameMapping { get; set; }

        // indexName to LSI range key properties mapping
        public Dictionary<string, List<string>> IndexNameToLSIRangePropertiesMapping { get; set; }

        // indexName to GSIConfig mapping
        public Dictionary<string, GSIConfig> IndexNameToGSIMapping { get; set; }


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

        public string GetCorrectHashKeyProperty(DynamoDBFlatConfig currentConfig, string hashKeyProperty)
        {
            if (currentConfig.IsIndexOperation)
            {
                string indexName = currentConfig.IndexName;
                GSIConfig gsiConfig = this.GetGSIConfig(indexName);
                // Use GSI hash key if GSI is found AND GSI hash-key is set
                if (gsiConfig != null && !string.IsNullOrEmpty(gsiConfig.HashKeyPropertyName))
                    hashKeyProperty = gsiConfig.HashKeyPropertyName;
            }
            return hashKeyProperty;
        }
        public string GetRangeKeyByIndex(string indexName)
        {
            string rangeKeyPropertyName = null;

            // test LSI first
            List<string> rangeProperties;
            if (IndexNameToLSIRangePropertiesMapping.TryGetValue(indexName, out rangeProperties) &&
                rangeProperties != null &&
                rangeProperties.Count == 1)
            {
                rangeKeyPropertyName = rangeProperties[0];
            }

            GSIConfig gsiConfig = GetGSIConfig(indexName);
            if (gsiConfig != null)
            {
                rangeKeyPropertyName = gsiConfig.RangeKeyPropertyName;
            }

            if (string.IsNullOrEmpty(rangeKeyPropertyName))
                throw new InvalidOperationException("Unable to determine range key from index name");

            return rangeKeyPropertyName;
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
                // only add non-ignored properties
                if (property.IsIgnored) continue;

                property.Validate(context);
                AddPropertyStorage(property, this.BaseTypeStorageConfig);

                string propertyName = property.PropertyName;

                AddKeyPropertyNames(property, propertyName);

                foreach (var index in property.Indexes)
                {
                    var gsi = index as PropertyStorage.GSI;
                    if (gsi != null)
                        AddGSIConfigs(gsi.IndexNames, propertyName, gsi.IsHashKey);

                    var lsi = index as PropertyStorage.LSI;
                    if (lsi != null)
                        AddLSIConfigs(lsi.IndexNames, propertyName);
                }
            }

            foreach (var polymorphicTypesProperty in this.PolymorphicTypesStorageConfig)
            {
                foreach (var polymorphicProperty in polymorphicTypesProperty.Value.Properties)
                {
                    // only add non-ignored properties
                    if (polymorphicProperty.IsIgnored) continue;

                    polymorphicProperty.Validate(context);

                    string propertyName = polymorphicProperty.PropertyName;

                    AddPropertyStorage(polymorphicProperty, polymorphicTypesProperty.Value);

                    foreach (var index in polymorphicProperty.Indexes)
                    {
                        var gsi = index as PropertyStorage.GSI;
                        if (gsi != null)
                            AddGSIConfigs(gsi.IndexNames, propertyName, gsi.IsHashKey);

                        var lsi = index as PropertyStorage.LSI;
                        if (lsi != null)
                            AddLSIConfigs(lsi.IndexNames, propertyName);
                    }
                }
            }

            if (PolymorphicTypesStorageConfig.Any())
            {
                AttributesToGet.Add(derivedTypeAttributeName);
            }

            //if (this.HashKeyPropertyNames.Count == 0)
            //    throw new InvalidOperationException("No hash key configured for type " + TargetTypeInfo.FullName);

            if (this.BaseTypeStorageConfig.Properties.Count == 0)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Type {0} is unsupported, it has no supported members", this.BaseTypeStorageConfig.TargetType.FullName));
        }


        public void AddPolymorphicPropertyStorageConfiguration(string typeDiscriminator, Type derivedType, StorageConfig polymorphicStorageConfig)
        {
            this.PolymorphicTypesStorageConfig.Add(typeDiscriminator, polymorphicStorageConfig);
            this.PolymorphicConfig.Add(derivedType, typeDiscriminator);
        }

        private void AddPropertyStorage(PropertyStorage value, StorageConfig config)
        {
            string propertyName = value.PropertyName;
            string attributeName = value.AttributeName;

            config.AddPropertyStorage(propertyName, value);

            if (!AttributesToGet.Contains(attributeName))
                AttributesToGet.Add(attributeName);
            if (value.StoreAsEpoch)
                AttributesToStoreAsEpoch.Add(attributeName);

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

        private void AddGSIConfigs(List<string> gsiIndexNames, string propertyName, bool isHashKey)
        {
            foreach (var index in gsiIndexNames)
            {
                GSIConfig gsiConfig = this.GetGSIConfig(index);
                if (gsiConfig == null)
                {
                    gsiConfig = new GSIConfig(index);
                    this.IndexNameToGSIMapping[index] = gsiConfig;
                }
                if (isHashKey)
                    gsiConfig.HashKeyPropertyName = propertyName;
                else
                    gsiConfig.RangeKeyPropertyName = propertyName;
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
            AttributesToGet = new List<string>();
            HashKeyPropertyNames = new List<string>();
            RangeKeyPropertyNames = new List<string>();
            AttributesToStoreAsEpoch = new HashSet<string>();
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
                    // If this type is only used for conversion, do not attempt to populate the config from the table
                    if (conversionOnly)
                        return tableCache.BaseTypeConfig;

                    actualTableName = DynamoDBContext.GetTableName(tableCache.BaseTableName, flatConfig);

                    if (tableCache.Cache.TryGetValue(actualTableName, out config))
                    {
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
                        tableCache = new ConfigTableCache(baseStorageConfig);
                        Cache[type] = tableCache;
                    }
                }

                // If this type is only used for conversion, do not attempt to populate the config from the table
                if (conversionOnly)
                    return tableCache.BaseTypeConfig;

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

            if (flatConfig.DisableFetchingTableMetadata)
            {
                if (string.IsNullOrEmpty(actualTableName))
                {
                    actualTableName = DynamoDBContext.GetTableName(config.TableName, flatConfig);
                }
                var emptyConfig = new TableConfig(actualTableName, conversion: null, consumer: Table.DynamoDBConsumer.DataModel,
                    storeAsEpoch: null, isEmptyStringValueEnabled: false, metadataCachingMode: flatConfig.MetadataCachingMode);
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
            }

            string tableAlias;
            if (AWSConfigsDynamoDB.Context.TableAliases.TryGetValue(config.TableName, out tableAlias))
                config.TableName = tableAlias;

            var members = Utils.GetMembersFromType(type);

            foreach (var member in members)
            {
                var propertyStorage = MemberInfoToPropertyStorage(config, member);

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

                    var polymorphicTypeMembers = Utils.GetMembersFromType(attribute.DerivedType);

                    foreach (var member in polymorphicTypeMembers)
                    {
                        var propertyStorage = MemberInfoToPropertyStorage(config, member);
                        polymorphicStorageConfig.Properties.Add(propertyStorage);
                    }

                    config.AddPolymorphicPropertyStorageConfiguration(attribute.TypeDiscriminator, attribute.DerivedType, polymorphicStorageConfig);

                }
            }
        }

        private static PropertyStorage MemberInfoToPropertyStorage(ItemStorageConfig config, MemberInfo member)
        {
            // prepare basic info
            PropertyStorage propertyStorage = new PropertyStorage(member);
            propertyStorage.AttributeName = GetAccurateCase(config, member.Name);

            // run through all DDB attributes
            List<DynamoDBAttribute> allAttributes = Utils.GetAttributes(member);
            foreach (var attribute in allAttributes)
            {
                // filter out ignored properties
                if (attribute is DynamoDBIgnoreAttribute)
                    propertyStorage.IsIgnored = true;

                if (attribute is DynamoDBVersionAttribute)
                    propertyStorage.IsVersion = true;

                DynamoDBRenamableAttribute renamableAttribute = attribute as DynamoDBRenamableAttribute;
                if (renamableAttribute != null && !string.IsNullOrEmpty(renamableAttribute.AttributeName))
                {
                    propertyStorage.AttributeName = GetAccurateCase(config, renamableAttribute.AttributeName);
                }

                DynamoDBPropertyAttribute propertyAttribute = attribute as DynamoDBPropertyAttribute;
                if (propertyAttribute != null)
                {
                    propertyStorage.StoreAsEpoch = propertyAttribute.StoreAsEpoch;
                       
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

            return propertyStorage;
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

                foreach (var element in gsi.KeySchema)
                {
                    string attributeName = element.AttributeName;
                    bool isHashKey = element.KeyType == KeyType.HASH;

                    property = GetProperty(config, attributeName, true);
                    if (property != null)
                    {
                        property.AddGsiIndex(isHashKey, attributeName, indexName);
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
