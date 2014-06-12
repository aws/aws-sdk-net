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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.DynamoDBv2.DataModel
{
    internal class PropertyStorage
    {
        // local property name
        public string PropertyName { get; private set; }
        // DynamoDB attribute name
        public string AttributeName { get; set; }

        // MemberInfo of the property
        public MemberInfo Member { get; private set; }
        // Type of the property
        public Type MemberType { get; private set; }
        // Converter type, if one is present
        public Type ConverterType { get; set; }
        // Converter, if one is present
        public IPropertyConverter Converter { get; private set; }

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
        public void Validate()
        {
            if (IsVersion)
                Utils.ValidateVersionType(MemberType);    // no conversion is possible, so type must be a nullable primitive

            if (IsHashKey && IsRangeKey)
                throw new InvalidOperationException("Property " + PropertyName + " cannot be both hash and range key");

            if (IsKey || IsGSIKey)
                if (Converter == null && !Utils.IsPrimitive(MemberType))
                    throw new InvalidOperationException("Key " + PropertyName + " must be of primitive type");

            foreach (var index in Indexes)
                IndexNames.AddRange(index.IndexNames);

            if (ConverterType != null)
            {
                if (!Utils.CanInstantiate(ConverterType) || !Utils.ImplementsInterface(ConverterType, typeof(IPropertyConverter)))
                    throw new InvalidOperationException("Converter for " + PropertyName + " must be instantiable with no parameters and must implement IPropertyConverter");

                this.Converter = Utils.Instantiate(ConverterType) as IPropertyConverter;
            }
        }

        public PropertyStorage(MemberInfo member)
        {
            IndexNames = new List<string>();
            Indexes = new List<Index>();
            Member = member;
            MemberType = Utils.GetType(member);
            PropertyName = member.Name;
        }
    }

    internal class ItemStorage
    {
        public Document Document { get; set; }
        public ItemStorageConfig Config { get; set; }
        public Primitive CurrentVersion { get; set; }

        public ItemStorage(ItemStorageConfig storageConfig)
        {
            Document = new Document();
            Config = storageConfig;
        }
    }

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

    internal class ItemStorageConfig
    {
        // normalized PropertyStorage objects
        public List<PropertyStorage> Properties { get; private set; }

        // table
        public string TableName { get; set; }
        public bool LowerCamelCaseProperties { get; set; }

        // keys
        public List<string> HashKeyPropertyNames { get; private set; }
        public List<string> RangeKeyPropertyNames { get; private set; }

        // properties to get
        public List<string> AttributesToGet { get; private set; }

        // version
        public string VersionPropertyName { get; private set; }
        public bool HasVersion { get { return !string.IsNullOrEmpty(VersionPropertyName); } }

        // target type
        public ITypeInfo TargetTypeInfo { get; private set; }

        // target type members
        public Dictionary<string, MemberInfo> TargetTypeMembers { get; private set; }

        // attribute-to-index mapping
        public Dictionary<string, List<string>> AttributeToIndexesNameMapping { get; set; }

        // indexName to LSI range key properties mapping
        public Dictionary<string, List<string>> IndexNameToLSIRangePropertiesMapping { get; set; }

        // indexName to GSIConfig mapping
        public Dictionary<string, GSIConfig> IndexNameToGSIMapping { get; set; }

        // storage mappings
        private Dictionary<string, PropertyStorage> PropertyToPropertyStorageMapping { get; set; }

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
                return GetPropertyStorage(VersionPropertyName);
            }
        }
        public IEnumerable<PropertyStorage> AllPropertyStorage
        {
            get { return PropertyToPropertyStorageMapping.Values; }
        }
        private void AddPropertyStorage(PropertyStorage value)
        {
            string propertyName = value.PropertyName;
            string attributeName = value.AttributeName;

            PropertyToPropertyStorageMapping[propertyName] = value;
            if (!AttributesToGet.Contains(attributeName))
                AttributesToGet.Add(attributeName);
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
            if (value.IsHashKey)
                HashKeyPropertyNames.Add(propertyName);
            if (value.IsRangeKey)
                RangeKeyPropertyNames.Add(propertyName);
            if (value.IsVersion)
            {
                if (!string.IsNullOrEmpty(VersionPropertyName))
                    throw new InvalidOperationException("Multiple version properties defined: " + VersionPropertyName + " and " + propertyName);
                VersionPropertyName = propertyName;
            }
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
            var properties = Properties.Where(match).ToList();

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


        public static bool IsValidMemberInfo(MemberInfo member)
        {
            // filter out non-fields and non-properties
            if (!(member is FieldInfo || member is PropertyInfo))
                return false;

            // filter out properties that aren't both read and write
            if (!Utils.IsReadWrite(member))
                return false;

            return true;
        }

        private static Dictionary<string, MemberInfo> GetMembersDictionary(ITypeInfo typeInfo)
        {
            Dictionary<string, MemberInfo> dictionary = new Dictionary<string, MemberInfo>(StringComparer.Ordinal);

            var members = typeInfo
                .GetMembers()
                .Where(IsValidMemberInfo)
                .ToList();
            foreach (var member in members)
            {
                AWSSDKUtils.AddToDictionary(dictionary, member.Name, member);
            }

            return dictionary;
        }

        public void Denormalize()
        {
            // analyze all PropertyStorage configs and denormalize data into other properties
            // all data must exist in PropertyStorage objects prior to denormalization

            foreach (var property in Properties)
            {
                // only add non-ignored properties
                if (property.IsIgnored) continue;

                property.Validate();
                AddPropertyStorage(property);

                string propertyName = property.PropertyName;

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

            if (this.HashKeyPropertyNames.Count == 0)
                throw new InvalidOperationException("No hash key configured for type " + TargetTypeInfo.FullName);
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
        public ItemStorageConfig(ITypeInfo targetTypeInfo)
        {
            TargetTypeInfo = targetTypeInfo;
            Properties = new List<PropertyStorage>();
            PropertyToPropertyStorageMapping = new Dictionary<string, PropertyStorage>(StringComparer.Ordinal);
            AttributeToIndexesNameMapping = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            IndexNameToLSIRangePropertiesMapping = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            IndexNameToGSIMapping = new Dictionary<string, GSIConfig>(StringComparer.Ordinal);
            AttributesToGet = new List<string>();
            HashKeyPropertyNames = new List<string>();
            RangeKeyPropertyNames = new List<string>();
            TargetTypeMembers = GetMembersDictionary(targetTypeInfo);
        }
    }


    internal class ItemStorageConfigCache
    {
        // Cache of ItemStorageConfig objects per table and the
        // base, table-less ItemStorageConfig
        private class ConfigTableCache
        {
            public Dictionary<string, ItemStorageConfig> Cache { get; private set; }
            private ItemStorageConfig BaseTypeConfig;

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

        public ItemStorageConfigCache(DynamoDBContext context)
        {
            Cache = new Dictionary<Type, ConfigTableCache>();
            Context = context;
        }

        public ItemStorageConfig GetConfig<T>(DynamoDBFlatConfig flatConfig)
        {
            Type type = typeof(T);
            return GetConfig(type, flatConfig);
        }
        public ItemStorageConfig GetConfig(Type type, DynamoDBFlatConfig flatConfig)
        {
            lock (Cache)
            {
                ConfigTableCache tableCache;
                if (!Cache.TryGetValue(type, out tableCache))
                {
                    var baseStorageConfig = CreateStorageConfig(type, null);
                    tableCache = new ConfigTableCache(baseStorageConfig);
                    Cache[type] = tableCache;
                }

                string actualTableName = DynamoDBContext.GetTableName(tableCache.BaseTableName, flatConfig);

                ItemStorageConfig config;
                if (!tableCache.Cache.TryGetValue(actualTableName, out config))
                {
                    config = CreateStorageConfig(type, actualTableName);
                    tableCache.Cache[actualTableName] = config;
                }
                return config;
            }
        }

        private static string GetAccurateCase(ItemStorageConfig config, string value)
        {
            return (config.LowerCamelCaseProperties ? Utils.ToLowerCamelCase(value) : value);
        }
        internal ItemStorageConfig CreateStorageConfig(Type baseType, string actualTableName)
        {
            if (baseType == null) throw new ArgumentNullException("baseType");
            ITypeInfo typeInfo = TypeFactory.GetTypeInfo(baseType);
            ItemStorageConfig config = new ItemStorageConfig(typeInfo);

            PopulateConfigFromType(config, typeInfo);
            PopulateConfigFromMappings(config, AWSConfigs.DynamoDBConfig.Context.TypeMappings);

            // populate config from table definition only if actual table name is known
            if (!string.IsNullOrEmpty(actualTableName))
            {
                Table table = Context.GetTable(actualTableName);
                PopulateConfigFromTable(config, table);

                config.Denormalize();
            }

            return config;
        }

        private static void PopulateConfigFromType(ItemStorageConfig config, ITypeInfo typeInfo)
        {
            DynamoDBTableAttribute tableAttribute = Utils.GetTableAttribute(typeInfo);
            if (tableAttribute == null)
            {
                config.TableName = typeInfo.Name;
            }
            else
            {
                if (string.IsNullOrEmpty(tableAttribute.TableName)) throw new InvalidOperationException("DynamoDBTableAttribute.Table is empty or null");
                config.TableName = tableAttribute.TableName;
                config.LowerCamelCaseProperties = tableAttribute.LowerCamelCaseProperties;
            }

            string tableAlias;
            if (AWSConfigs.DynamoDBConfig.Context.TableAliases.TryGetValue(config.TableName, out tableAlias))
                config.TableName = tableAlias;

            foreach (var member in typeInfo.GetMembers())
            {
                if (!ItemStorageConfig.IsValidMemberInfo(member))
                    continue;

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

                    DynamoDBPropertyAttribute propertyAttribute = attribute as DynamoDBPropertyAttribute;
                    if (propertyAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(propertyAttribute.AttributeName))
                            propertyStorage.AttributeName = GetAccurateCase(config, propertyAttribute.AttributeName);

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
                }

                config.Properties.Add(propertyStorage);
            }
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
            var baseType = config.TargetTypeInfo.BaseType;
            TypeMapping typeMapping;
            if (typeMappings.TryGetValue(baseType, out typeMapping))
            {
                config.TableName = typeMapping.TargetTable;

                foreach (var kvp in typeMapping.PropertyConfigs)
                {
                    PropertyConfig propertyConfig = kvp.Value;
                    string propertyName = propertyConfig.Name;

                    PropertyStorage propertyStorage;
                    if (!config.FindPropertyByPropertyName(propertyName, out propertyStorage))
                        throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                            "No matching property {0} on type {1}", propertyName, baseType.FullName));

                    if (!string.IsNullOrEmpty( propertyConfig.Attribute))
                        propertyStorage.AttributeName = propertyConfig.Attribute;
                    if (propertyConfig.Converter != null)
                        propertyStorage.ConverterType = propertyConfig.Converter;
                    propertyStorage.IsIgnored = propertyConfig.Ignore;
                    propertyStorage.IsVersion = propertyConfig.Version;
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

            bool exists = config.FindSinglePropertyByAttributeName(attributeName, out property);
            if (!exists)
            {
                // property storage doesn't exist yet, create and populate
                MemberInfo member;

                // for optional properties/attributes, a null MemberInfo is OK
                Validate(config.TargetTypeMembers.TryGetValue(attributeName, out member) || optional,
                    "Unable to locate property for key attribute {0}", attributeName);

                if (member != null)
                {
                    property = new PropertyStorage(member);
                    property.AttributeName = attributeName;
                    config.Properties.Add(property);
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
    }
}
