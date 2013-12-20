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
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Reflection;
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
        public string PropertyName { get; set; }
        // DynamoDB attribute name
        public string AttributeName { get; set; }

        // MemberInfo of the property
        public MemberInfo Member { get; private set; }
        // Type of the property
        public Type MemberType { get; private set; }
        // Converter, if one is present
        public IPropertyConverter Converter { get; set; }

        // flags
        public bool IsHashKey { get; set; }
        public bool IsRangeKey { get; set; }
        public bool IsVersion { get; set; }
        public bool IsLSIRangeKey { get; set; }
        public bool IsGSIHashKey { get; set; }
        public bool IsGSIRangeKey { get; set; }
        public bool IsGSIKey { get { return IsGSIHashKey || IsGSIRangeKey; } }

        // corresponding IndexName, if applicable
        public List<string> Indexes { get; set; }

        public PropertyStorage(MemberInfo member, Type memberType)
        {
            Indexes = new List<string>();
            Member = member;
            MemberType = memberType;
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

        //public List<string> GetAttributesToGet(ItemStorageConfig storageConfig, Table table, List<string> attributesToGet)
        //{
        //    var gsi = table.GlobalSecondaryIndexes[this.IndexName];
        //    var projection = gsi.Projection;
        //    if (projection.ProjectionType == ProjectionType.INCLUDE)
        //    {
        //        attributesToGet = new List<string>();

        //        // add keys
        //        var gsiHashProperty = storageConfig.GetPropertyStorage(this.HashKeyPropertyName);
        //        attributesToGet.Add(gsiHashProperty.AttributeName);
        //        var gsiRangeProperty = storageConfig.GetPropertyStorage(this.RangeKeyPropertyName);
        //        attributesToGet.Add(gsiRangeProperty.AttributeName);

        //        // add non-keys
        //        attributesToGet.AddRange(projection.NonKeyAttributes);
        //    }
        //    return attributesToGet;
        //}
    }

    internal class ItemStorageConfig
    {
        // table
        public string TableName { get; set; }
        public bool LowerCamelCaseProperties { get; set; }

        // keys
        public List<string> HashKeyPropertyNames { get; set; }
        public List<string> RangeKeyPropertyNames { get; set; }

        // properties to get
        public List<string> AttributesToGet { get; set; }

        // version
        public string VersionPropertyName { get; set; }
        public bool HasVersion { get { return !string.IsNullOrEmpty(VersionPropertyName); } }

        // target type
        public Type TargetType { get; set; }

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
            if (PropertyToPropertyStorageMapping.TryGetValue(propertyName, out storage))
                return storage;
            throw new InvalidOperationException("Unable to find storage information for property [" + propertyName + "]");
        }
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
        public void AddPropertyStorage(PropertyStorage value)
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
                foreach (var index in value.Indexes)
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
                    throw new InvalidOperationException("Multiple version attributes defined");
                VersionPropertyName = propertyName;
            }
        }

        // constructor
        public ItemStorageConfig(Type targetType)
        {
            TargetType = targetType;
            PropertyToPropertyStorageMapping = new Dictionary<string, PropertyStorage>(StringComparer.Ordinal);
            AttributeToIndexesNameMapping = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            IndexNameToLSIRangePropertiesMapping = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            IndexNameToGSIMapping = new Dictionary<string, GSIConfig>(StringComparer.Ordinal);
            AttributesToGet = new List<string>();
            HashKeyPropertyNames = new List<string>();
            RangeKeyPropertyNames = new List<string>();
        }
    }


    internal static class ItemStorageConfigCache
    {
        private static Dictionary<Type, ItemStorageConfig> Cache = new Dictionary<Type, ItemStorageConfig>();

        public static ItemStorageConfig GetConfig<T>()
        {
            Type type = typeof(T);
            return GetConfig(type);
        }
        public static ItemStorageConfig GetConfig(Type type)
        {
            lock (Cache)
            {
                ItemStorageConfig config;
                if (!Cache.TryGetValue(type, out config))
                {
                    config = CreateStorageConfig(type);
                    Cache[type] = config;
                }
                return config;
            }
        }

        private static string GetAccurateCase(ItemStorageConfig config, string value)
        {
            return (config.LowerCamelCaseProperties ? Utils.ToLowerCamelCase(value) : value);
        }
        private static void AddGSIConfigs(ItemStorageConfig config, string[] gsiIndexNames, string propertyName, bool isHashKey)
        {
            foreach (var index in gsiIndexNames)
            {
                GSIConfig gsiConfig = config.GetGSIConfig(index);
                if (gsiConfig == null)
                {
                    gsiConfig = new GSIConfig(index);
                    config.IndexNameToGSIMapping[index] = gsiConfig;
                }
                if (isHashKey)
                    gsiConfig.HashKeyPropertyName = propertyName;
                else
                    gsiConfig.RangeKeyPropertyName = propertyName;
            }
        }
        internal static ItemStorageConfig CreateStorageConfig(Type type)
        {
            if (type == null) throw new ArgumentNullException("type");
            var typeWrapper = TypeFactory.GetTypeInfo(type);
            ItemStorageConfig config = new ItemStorageConfig(type);

            DynamoDBTableAttribute tableAttribute = Utils.GetTableAttribute(type);
            if (tableAttribute == null || string.IsNullOrEmpty(tableAttribute.TableName)) throw new InvalidOperationException("No DynamoDBTableAttribute on type");

            if (string.IsNullOrEmpty(tableAttribute.TableName)) throw new InvalidOperationException("DynamoDBTableAttribute.Table is empty or null");
            config.TableName = tableAttribute.TableName;
            config.LowerCamelCaseProperties = tableAttribute.LowerCamelCaseProperties;

            foreach (var member in typeWrapper.GetMembers())
            {
                // filter out non-fields and non-properties
                if (!(member is FieldInfo || member is PropertyInfo)) continue;

                // filter out properties that aren't both read and write
                if (!Utils.IsReadWrite(member)) continue;

                // prepare basic info
                Type memberType = Utils.GetType(member);
                string attributeName = GetAccurateCase(config, member.Name);
                string propertyName = member.Name;
                PropertyStorage propertyStorage = new PropertyStorage(member, memberType);

                // run through all DDB attributes
                bool ignorePresent = false;
                var allAttributes = Utils.GetAttributes(member);
                foreach (var attribute in allAttributes)
                {
                    // filter out ignored properties
                    if (attribute is DynamoDBIgnoreAttribute)
                        ignorePresent |= true;

                    // if ignore attribute is present, ignore other attributes
                    if (ignorePresent) continue;

                    if (attribute is DynamoDBVersionAttribute)
                    {
                        Utils.ValidateVersionType(memberType);    // no conversion is possible, so type must be a nullable primitive

                        propertyStorage.IsVersion = true;
                    }

                    DynamoDBPropertyAttribute propertyAttribute = attribute as DynamoDBPropertyAttribute;
                    if (propertyAttribute != null)
                    {
                        if (!string.IsNullOrEmpty(propertyAttribute.AttributeName))
                            attributeName = GetAccurateCase(config, propertyAttribute.AttributeName);

                        if (propertyAttribute is DynamoDBHashKeyAttribute)
                        {
                            if (propertyAttribute.Converter == null && !Utils.IsPrimitive(memberType))
                                throw new InvalidOperationException("Hash key " + propertyName + " must be of primitive type");

                            if (propertyAttribute is DynamoDBGlobalSecondaryIndexHashKeyAttribute)
                            {
                                propertyStorage.IsGSIHashKey = true;
                                var gsiHashAttribute = propertyAttribute as DynamoDBGlobalSecondaryIndexHashKeyAttribute;
                                if (gsiHashAttribute.IndexNames == null || gsiHashAttribute.IndexNames.Length == 0)
                                    throw new InvalidOperationException("Global Secondary Index must not be null or empty");
                                propertyStorage.Indexes.AddRange(gsiHashAttribute.IndexNames);
                                AddGSIConfigs(config, gsiHashAttribute.IndexNames, propertyName, true);
                            }
                            else
                                propertyStorage.IsHashKey = true;
                        }
                        if (propertyAttribute is DynamoDBRangeKeyAttribute)
                        {
                            if (propertyAttribute.Converter == null && !Utils.IsPrimitive(memberType))
                                throw new InvalidOperationException("Range key " + propertyName + " must be of primitive type");

                            if (propertyAttribute is DynamoDBGlobalSecondaryIndexRangeKeyAttribute)
                            {
                                propertyStorage.IsGSIRangeKey = true;
                                var gsiRangeAttribute = propertyAttribute as DynamoDBGlobalSecondaryIndexRangeKeyAttribute;
                                if (gsiRangeAttribute.IndexNames == null || gsiRangeAttribute.IndexNames.Length == 0)
                                    throw new InvalidOperationException("Global Secondary Index must not be null or empty");
                                propertyStorage.Indexes.AddRange(gsiRangeAttribute.IndexNames);
                                AddGSIConfigs(config, gsiRangeAttribute.IndexNames, propertyName, false);
                            }
                            else
                                propertyStorage.IsRangeKey = true;
                        }
                        if (propertyAttribute is DynamoDBLocalSecondaryIndexRangeKeyAttribute)
                        {
                            DynamoDBLocalSecondaryIndexRangeKeyAttribute lsiRangeKeyAttribute = propertyAttribute as DynamoDBLocalSecondaryIndexRangeKeyAttribute;
                            if (lsiRangeKeyAttribute.IndexNames == null || lsiRangeKeyAttribute.IndexNames.Length == 0)
                                throw new InvalidOperationException("Local Secondary Index must not be null or empty");
                            propertyStorage.Indexes.AddRange(lsiRangeKeyAttribute.IndexNames);
                            propertyStorage.IsLSIRangeKey = true;

                            foreach (var index in lsiRangeKeyAttribute.IndexNames)
                            {
                                List<string> properties;
                                if (!config.IndexNameToLSIRangePropertiesMapping.TryGetValue(index, out properties))
                                {
                                    properties = new List<string>();
                                    config.IndexNameToLSIRangePropertiesMapping[index] = properties;
                                }
                                properties.Add(propertyName);
                            }
                        }

                        if (propertyAttribute.Converter != null)
                        {
                            if (!Utils.CanInstantiate(propertyAttribute.Converter) || !Utils.ImplementsInterface(propertyAttribute.Converter, typeof(IPropertyConverter)))
                                throw new InvalidOperationException("Converter for " + propertyName + " must be instantiable with no parameters and must implement IPropertyConverter");

                            propertyStorage.Converter = Utils.Instantiate(propertyAttribute.Converter) as IPropertyConverter;
                        }
                    }
                }

                propertyStorage.PropertyName = propertyName;
                propertyStorage.AttributeName = attributeName;

                // only add property storage if no ignore attribute was present
                if (!ignorePresent)
                    config.AddPropertyStorage(propertyStorage);
            }

            if (config.HashKeyPropertyNames.Count == 0)
                throw new InvalidOperationException("No hash key configured for type " + type.FullName);

            return config;
        }
    }

}
