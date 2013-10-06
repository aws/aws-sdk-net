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
using Amazon.DynamoDB.DocumentModel;
using Amazon.DynamoDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;

namespace Amazon.DynamoDB.DataModel
{
    internal class PropertyStorage
    {
        public string PropertyName { get; set; }
        public string AttributeName { get; set; }

        public MemberInfo Member { get; set; }
        public Type MemberType { get; set; }
        public IPropertyConverter Converter { get; set; }

        public bool IsHashKey { get; set; }
        public bool IsRangeKey { get; set; }
        public bool IsVersion { get; set; }
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

    internal class ItemStorageConfig
    {
        // table
        public string TableName { get; set; }
        public bool LowerCamelCaseProperties { get; set; }

        // keys
        public string HashKeyPropertyName { get; set; }
        public string RangeKeyPropertyName { get; set; }
        public bool HasRangeKey { get { return !string.IsNullOrEmpty(RangeKeyPropertyName); } }

        // version
        public string VersionPropertyName { get; set; }
        public bool HasVersion { get { return !string.IsNullOrEmpty(VersionPropertyName); } }

        // storage mappings
        private Dictionary<string, PropertyStorage> PropertyToPropertyStorageMapping { get; set; }

        public PropertyStorage GetPropertyStorage(string propertyName)
        {
            PropertyStorage storage;
            if (PropertyToPropertyStorageMapping.TryGetValue(propertyName, out storage))
                return storage;
            throw new InvalidOperationException("Unable to find storage information for property [" + propertyName + "]");
        }
        public PropertyStorage HashPropertyStorage
        {
            get
            {
                return GetPropertyStorage(HashKeyPropertyName);
            }
        }
        public PropertyStorage RangePropertyStorage
        {
            get
            {
                if (!HasRangeKey) throw new InvalidOperationException("No range key defined for this type");
                return GetPropertyStorage(RangeKeyPropertyName);
            }
        }
        public PropertyStorage VersionPropertyStorage
        {
            get
            {
                if (!HasVersion) throw new InvalidOperationException("No version field defined for this type");
                return GetPropertyStorage(VersionPropertyName);
            }
        }
        public void AddPropertyStorage(PropertyStorage value)
        {
            PropertyToPropertyStorageMapping[value.PropertyName] = value;
        }
        public IEnumerable<PropertyStorage> AllPropertyStorage
        {
            get { return PropertyToPropertyStorageMapping.Values; }
        }

        // properties to get
        public List<string> AttributesToGet { get; private set; }

        // constructor
        public ItemStorageConfig()
        {
            PropertyToPropertyStorageMapping = new Dictionary<string, PropertyStorage>(StringComparer.Ordinal);
            AttributesToGet = new List<string>();
        }
    }


    internal static class ItemStorageConfigCache
    {
        private static Dictionary<Type, ItemStorageConfig> Cache;

        static ItemStorageConfigCache()
        {
            Cache = new Dictionary<Type, ItemStorageConfig>();
        }

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
            return (config.LowerCamelCaseProperties ? EntityUtils.ToLowerCamelCase(value) : value);
        }
        internal static ItemStorageConfig CreateStorageConfig(Type type)
        {
            if (type == null) throw new ArgumentNullException("type");

            ItemStorageConfig config = new ItemStorageConfig();

            DynamoDBTableAttribute tableAttribute = EntityUtils.GetTableAttribute(type);
            if (tableAttribute == null || string.IsNullOrEmpty(tableAttribute.TableName)) throw new InvalidOperationException("No DynamoDBTableAttribute on type");

            if (string.IsNullOrEmpty(tableAttribute.TableName)) throw new InvalidOperationException("DynamoDBTableAttribute.Table is empty or null");
            config.TableName = tableAttribute.TableName;
            config.LowerCamelCaseProperties = tableAttribute.LowerCamelCaseProperties;

            foreach (var member in type.GetMembers())
            {
                // filter out non-fields and non-properties
                if (!(member is FieldInfo || member is PropertyInfo)) continue;

                // filter out properties that aren't both read and write
                if (!EntityUtils.IsReadWrite(member)) continue;

                DynamoDBAttribute attribute = EntityUtils.GetAttribute(member);

                // filter out ignored properties
                if (attribute is DynamoDBIgnoreAttribute) continue;

                Type memberType = EntityUtils.GetType(member);
                string attributeName = GetAccurateCase(config, member.Name);
                string propertyName = member.Name;

                PropertyStorage propertyStorage = new PropertyStorage
                {
                    Member = member,
                    MemberType = memberType,
                };

                if (attribute is DynamoDBVersionAttribute)
                {
                    EntityUtils.ValidateVersionType(memberType);    // no conversion is possible, so type must be a nullable primitive

                    if (!string.IsNullOrEmpty(config.VersionPropertyName))
                        throw new InvalidOperationException("Multiple version attributes defined");

                    config.VersionPropertyName = propertyName;
                    propertyStorage.IsVersion = true;
                }

                DynamoDBPropertyAttribute propertyAttribute = attribute as DynamoDBPropertyAttribute;
                if (propertyAttribute != null)
                {
                    if (!string.IsNullOrEmpty(propertyAttribute.AttributeName))
                        attributeName = GetAccurateCase(config, propertyAttribute.AttributeName);

                    if (propertyAttribute is DynamoDBHashKeyAttribute)
                    {
                        if (propertyAttribute.Converter == null && !EntityUtils.IsPrimitive(memberType))
                            throw new InvalidOperationException("Hash key " + propertyName + " must be of primitive type");
                        if (!string.IsNullOrEmpty(config.HashKeyPropertyName))
                            throw new InvalidOperationException("Multiple hash keys defined");

                        config.HashKeyPropertyName = propertyName;
                        propertyStorage.IsHashKey = true;
                    }
                    if (propertyAttribute is DynamoDBRangeKeyAttribute)
                    {
                        if (propertyAttribute.Converter == null && !EntityUtils.IsPrimitive(memberType))
                            throw new InvalidOperationException("Range key " + propertyName + " must be of primitive type");
                        if (!string.IsNullOrEmpty(config.RangeKeyPropertyName))
                            throw new InvalidOperationException("Multiple range keys defined");

                        config.RangeKeyPropertyName = propertyName;
                        propertyStorage.IsRangeKey = true;
                    }


                    if (propertyAttribute.Converter != null)
                    {
                        if (!EntityUtils.CanInstantiate(propertyAttribute.Converter) || !EntityUtils.ImplementsInterface(propertyAttribute.Converter, typeof(IPropertyConverter)))
                            throw new InvalidOperationException("Converter for " + propertyName + " must be instantiable with no parameters and must implement IPropertyConverter");

                        propertyStorage.Converter = EntityUtils.Instantiate(propertyAttribute.Converter) as IPropertyConverter;
                    }
                }

                propertyStorage.PropertyName = propertyName;
                propertyStorage.AttributeName = attributeName;
                
                config.AttributesToGet.Add(attributeName);
                config.AddPropertyStorage(propertyStorage);
            }

            if (string.IsNullOrEmpty(config.HashKeyPropertyName))
                throw new InvalidOperationException("No hash key configured on type");

            return config;
        }
    }

}
