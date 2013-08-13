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
using System.Linq;
using System.IO;
using System.Reflection;

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class DynamoDBContext
    {
        #region Versioning

        private static void SetNewVersion(ItemStorage storage)
        {
            if (!storage.Config.HasVersion) return;

            DynamoDBEntry versionEntry;
            Primitive version;
            string versionAttributeName = storage.Config.VersionPropertyStorage.AttributeName;

            if (storage.Document.TryGetValue(versionAttributeName, out versionEntry))
                version = versionEntry as Primitive;
            else
                version = null;

            if (version != null && version.Value != null)
            {
                if (version.Type != DynamoDBEntryType.Numeric) throw new InvalidOperationException("Version property must be numeric");
                PropertyStorage propertyStorage = storage.Config.VersionPropertyStorage;
                IncrementVersion(propertyStorage.MemberType, ref version);
            }
            else
            {
                version = new Primitive("0", true);
            }
            storage.Document[versionAttributeName] = version;
        }
        private static void IncrementVersion(Type memberType, ref Primitive version)
        {
            if (memberType.IsAssignableFrom(typeof(Byte))) version = version.AsByte() + 1;
            else if (memberType.IsAssignableFrom(typeof(SByte))) version = version.AsSByte() + 1;
            else if (memberType.IsAssignableFrom(typeof(int))) version = version.AsInt() + 1;
            else if (memberType.IsAssignableFrom(typeof(uint))) version = version.AsUInt() + 1;
            else if (memberType.IsAssignableFrom(typeof(long))) version = version.AsLong() + 1;
            else if (memberType.IsAssignableFrom(typeof(ulong))) version = version.AsULong() + 1;
            else if (memberType.IsAssignableFrom(typeof(short))) version = version.AsShort() + 1;
            else if (memberType.IsAssignableFrom(typeof(ushort))) version = version.AsUShort() + 1;
        }
        private static Document CreateExpectedDocumentForVersion(ItemStorage storage)
        {
            Document document = new Document();
            if (storage.Config.HasVersion)
            {
                string versionAttributeName = storage.Config.VersionPropertyStorage.AttributeName;
                if (storage.CurrentVersion == null)
                {
                    document[versionAttributeName] = null;
                }
                else
                {
                    document[versionAttributeName] = storage.CurrentVersion;
                }
            }
            return document;
        }

        #endregion

        #region Table methods

        internal Table GetTargetTable(ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            if (flatConfig == null)
                throw new ArgumentNullException("flatConfig");

            string tableName = GetTableName(storageConfig, flatConfig);
            Table table = GetTable(tableName);

            ValidateConfigAgainstTable(storageConfig, table);
            return table;
        }

        private Table GetTable(string tableName)
        {
            Table table;
            lock (tablesMapLock)
            {
                if (!tablesMap.TryGetValue(tableName, out table))
                {
                    table = Table.LoadTable(client, tableName, Table.DynamoDBConsumer.DataModel);
                    tablesMap[tableName] = table;
                }
            }
            return table;
        }

        private static string GetTableName(ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            if (flatConfig == null)
                throw new ArgumentNullException("flatConfig");

            string tableName = storageConfig.TableName;

            if (!string.IsNullOrEmpty(flatConfig.OverrideTableName))
                tableName = flatConfig.OverrideTableName;
            if (!string.IsNullOrEmpty(flatConfig.TableNamePrefix))
                tableName = flatConfig.TableNamePrefix + tableName;

            return tableName;
        }

        private void ValidateConfigAgainstTable(ItemStorageConfig config, Table table)
        {
            CompareKeys(config, table, table.HashKeys, config.HashKeyPropertyNames, "hash");
            CompareKeys(config, table, table.RangeKeys, config.RangeKeyPropertyNames, "range");
        }

        private static void CompareKeys(ItemStorageConfig config, Table table, List<string> attributes, List<string> properties, string keyType)
        {
            if (attributes.Count != properties.Count)
                throw new InvalidOperationException(string.Format(
                    "Number of {0} keys on table {1} does not match number of hash keys on type {2}",
                    keyType, table.TableName, config.TargetType.FullName));
            foreach (string hashProperty in properties)
            {
                PropertyStorage property = config.GetPropertyStorage(hashProperty);
                if (!attributes.Contains(property.AttributeName))
                    throw new InvalidOperationException(string.Format(
                        "Key property {0} on type {1} does not correspond to a {2} key on table {3}",
                        hashProperty, config.TargetType.FullName, keyType, table.TableName));
            }
        }

        #endregion

        #region Marshalling/unmarshalling

        // Check if DynamoDBEntry is supported
        private static bool ShouldSave(DynamoDBEntry entry, bool ignoreNullValues)
        {
            if (entry == null)
            {
                if (ignoreNullValues)
                    return false;
                else
                    return true;
            }

            var primitive = entry as Primitive;
            if (primitive != null)
                return (primitive.Value != null);

            var primitiveList = entry as PrimitiveList;
            if (primitiveList != null)
                return (primitiveList.Entries != null && primitiveList.Entries.Count > 0);

            throw new InvalidOperationException("Unrecognized DynamoDBEntry object");
        }

        // Deserializing DynamoDB document into an object
        private static T DocumentToObject<T>(ItemStorage storage)
        {
            Type type = typeof(T);
            return (T)DocumentToObject(type, storage);
        }
        private static object DocumentToObject(Type objectType, ItemStorage storage)
        {
            if (storage == null) throw new ArgumentNullException();

            if (storage.Document == null) return null;

            object instance = Utils.Instantiate(objectType);
            PopulateInstance(storage, instance);
            return instance;
        }
        private static void PopulateInstance(ItemStorage storage, object instance)
        {
            ItemStorageConfig config = storage.Config;
            Document document = storage.Document;

            foreach (PropertyStorage propertyStorage in config.AllPropertyStorage)
            {
                string propertyName = propertyStorage.PropertyName;
                string attributeName = propertyStorage.AttributeName;

                DynamoDBEntry entry;
                if (document.TryGetValue(attributeName, out entry))
                {
                    if (ShouldSave(entry, true))
                    {
                        object value = FromDynamoDBEntry(propertyStorage, entry); // TODO: send entire propertyStorage into method, and store the collectionAdd MethodInfo in it

                        if (!TrySetValue(instance, propertyStorage.Member, value))
                        {
                            throw new InvalidOperationException("Unable to retrieve value from " + attributeName);
                        }
                    }

                    if (propertyStorage.IsVersion)
                        storage.CurrentVersion = entry as Primitive;
                }
            }
        }

        // Serializing an object into a DynamoDB document
        private static ItemStorage ObjectToItemStorage<T>(T toStore, bool keysOnly, bool ignoreNullValues)
        {
            if (toStore == null) return null;

            Type objectType = typeof(T);
            ItemStorageConfig config = ItemStorageConfigCache.GetConfig(objectType);
            if (config == null) return null;

            ItemStorage storage = ObjectToItemStorage<T>(toStore, keysOnly, ignoreNullValues, config);
            return storage;
        }
        internal static ItemStorage ObjectToItemStorage<T>(T toStore, bool keysOnly, bool ignoreNullValues, ItemStorageConfig config)
        {
            ItemStorage storage = new ItemStorage(config);
            PopulateItemStorage(toStore, keysOnly, ignoreNullValues, storage);
            return storage;
        }
        private static void PopulateItemStorage(object toStore, bool keysOnly, bool ignoreNullValues, ItemStorage storage)
        {
            ItemStorageConfig config = storage.Config;
            Document document = storage.Document;

            foreach (PropertyStorage propertyStorage in config.AllPropertyStorage)
            {
                // if only keys are being serialized, skip non-key properties
                // still include version, however, to populate the storage.CurrentVersion field
                if (keysOnly && !propertyStorage.IsHashKey && !propertyStorage.IsRangeKey && !propertyStorage.IsVersion) continue;

                string propertyName = propertyStorage.PropertyName;
                string attributeName = propertyStorage.AttributeName;

                object value;
                if (TryGetValue(toStore, propertyStorage.Member, out value))
                {
                    DynamoDBEntry dbe = ToDynamoDBEntry(propertyStorage, value);

                    if (ShouldSave(dbe, ignoreNullValues))
                    {
                        if (propertyStorage.IsHashKey || propertyStorage.IsRangeKey || propertyStorage.IsVersion || propertyStorage.IsLSIRangeKey)
                        {
                            if (dbe is PrimitiveList)
                                throw new InvalidOperationException("Property " + propertyName + " is a hash key, range key or version property and cannot be PrimitiveList");
                        }
                        document[attributeName] = dbe;

                        if (propertyStorage.IsVersion)
                            storage.CurrentVersion = dbe as Primitive;
                    }
                }
                else
                    throw new InvalidOperationException("Unable to retrieve value from property " + propertyName);
            }
        }

        // DynamoDBEntry <--> Object
        private static object FromDynamoDBEntry(PropertyStorage propertyStorage, DynamoDBEntry value)
        {
            var converter = propertyStorage.Converter;
            if (converter != null)
                return converter.FromEntry(value);

            object output;
            var targetType = propertyStorage.MemberType;

            Primitive primitive = value as Primitive;
            if (primitive != null && TryFromPrimitive(targetType, primitive, out output))
                return output;

            PrimitiveList primitiveList = value as PrimitiveList;
            if (primitiveList != null && TryFromPrimitiveList(targetType, primitiveList, out output))
                return output;

            throw new InvalidOperationException(
                string.Format("Unable to convert attribute \"{0}\" to property \"{1}\" of type \"{2}\"",
                propertyStorage.AttributeName, propertyStorage.PropertyName, propertyStorage.MemberType.FullName));
        }
        private static DynamoDBEntry ToDynamoDBEntry(PropertyStorage propertyStorage, object value)
        {
            return ToDynamoDBEntry(propertyStorage, value, false);
        }
        private static DynamoDBEntry ToDynamoDBEntry(PropertyStorage propertyStorage, object value, bool canReturnPrimitiveInsteadOfList)
        {
            if (value == null)
                return null;

            var converter = propertyStorage.Converter;
            if (converter != null)
                return converter.ToEntry(value);

            var type = propertyStorage.MemberType;
            Primitive primitive;
            if (TryToPrimitive(type, value, out primitive))
                return primitive;

            DynamoDBEntry primitiveList;
            if (TryToPrimitiveList(type, value, canReturnPrimitiveInsteadOfList, out primitiveList))
                return primitiveList;

            throw new InvalidOperationException(string.Format("Unable to convert field \"{0}\" of type \"{1}\", type is not primitive or primitive collection and does not define a converter",
                propertyStorage.PropertyName, value.GetType().FullName));

        }

        // PrimitiveList <--> List
        private static bool TryFromPrimitiveList(Type targetType, PrimitiveList value, out object output)
        {
            Type elementType;
            if ((!Utils.ImplementsInterface(targetType, typeof(ICollection<>)) &&
                !Utils.ImplementsInterface(targetType, typeof(IList))) ||
                !Utils.CanInstantiate(targetType) ||
                !Utils.IsPrimitive(elementType = targetType.GetGenericArguments()[0]))
            {
                output = null;
                return false;
            }
            
            var collection = Utils.Instantiate(targetType);
            IList ilist = collection as IList;
            bool useIListInterface = ilist != null;

            MethodInfo collectionAdd = null;
            if (!useIListInterface)
            {
                collectionAdd = targetType.GetMethod("Add");
            }
            
            foreach (Primitive primitive in value.Entries)
            {
                object primitiveValue;
                if (TryFromPrimitive(elementType, primitive, out primitiveValue))
                {
                    if (useIListInterface)
                        ilist.Add(primitiveValue);
                    else
                        collectionAdd.Invoke(collection, new object[] { primitiveValue });
                }
                else
                {
                    output = null;
                    return false;
                }
            }

            output = collection;
            return true;
        }
        private static bool TryToPrimitiveList(Type type, object value, bool canReturnPrimitive, out DynamoDBEntry output)
        {
            Type elementType;
            if (!Utils.ImplementsInterface(type, typeof(ICollection<>)) ||
                !Utils.IsPrimitive(elementType = type.GetGenericArguments()[0]))
            {
                output = null;
                return false;
            }

            ICollection collection = value as ICollection;

            Primitive primitive;
            if (collection == null)
            {
                if (canReturnPrimitive &&
                    value.GetType().IsAssignableFrom(elementType) &&
                    TryToPrimitive(elementType, value, out primitive))
                {
                    output = primitive;
                    return true;
                }

                output = null;
                return false;
            }

            PrimitiveList primitiveList = new PrimitiveList();
            DynamoDBEntryType? listType = null;
            foreach (var item in collection)
            {
                if (TryToPrimitive(elementType, item, out primitive))
                {
                    if (listType.HasValue && listType.Value != primitive.Type)
                        throw new InvalidOperationException("List cannot contain a mix of different types");
                    listType = primitive.Type;

                    primitiveList.Entries.Add(primitive);
                }
                else
                {
                    output = null;
                    return false;
                }
            }
            primitiveList.Type = listType.GetValueOrDefault(DynamoDBEntryType.String);

            output = primitiveList;
            return true;
        }

        // Primitive <--> Value type
        private static bool TryFromPrimitive(Type targetType, Primitive value, out object output)
        {
            if (value.Value == null)
            {
                output = null;
                return true;
            }

            if (targetType.IsAssignableFrom(typeof(Boolean))) output = value.AsBoolean();
            else if (targetType.IsAssignableFrom(typeof(Byte))) output = value.AsByte();
            else if (targetType.IsAssignableFrom(typeof(Char))) output = value.AsChar();
            else if (targetType.IsAssignableFrom(typeof(DateTime))) output = value.AsDateTime();
            else if (targetType.IsAssignableFrom(typeof(Decimal))) output = value.AsDecimal();
            else if (targetType.IsAssignableFrom(typeof(Double))) output = value.AsDouble();
            else if (targetType.IsAssignableFrom(typeof(int))) output = value.AsInt();
            else if (targetType.IsAssignableFrom(typeof(long))) output = value.AsLong();
            else if (targetType.IsAssignableFrom(typeof(SByte))) output = value.AsSByte();
            else if (targetType.IsAssignableFrom(typeof(short))) output = value.AsShort();
            else if (targetType.IsAssignableFrom(typeof(Single))) output = value.AsSingle();
            else if (targetType.IsAssignableFrom(typeof(String))) output = value.AsString();
            else if (targetType.IsAssignableFrom(typeof(uint))) output = value.AsUInt();
            else if (targetType.IsAssignableFrom(typeof(ulong))) output = value.AsULong();
            else if (targetType.IsAssignableFrom(typeof(ushort))) output = value.AsUShort();
            else if (targetType.IsAssignableFrom(typeof(Guid))) output = value.AsGuid();
            else if (targetType.IsAssignableFrom(typeof(byte[]))) output = value.AsByteArray();
            else if (targetType.IsAssignableFrom(typeof(MemoryStream))) output = value.AsMemoryStream();
            else
            {
                output = null;
                return false;
            }
            return true;
        }
        private static bool TryToPrimitive(Type type, object value, out Primitive output)
        {
            if (type.IsAssignableFrom(typeof(Boolean))) output = (Boolean)value;
            else if (type.IsAssignableFrom(typeof(Byte))) output = (Byte)value;
            else if (type.IsAssignableFrom(typeof(Char))) output = (Char)value;
            else if (type.IsAssignableFrom(typeof(DateTime))) output = (DateTime)value;
            else if (type.IsAssignableFrom(typeof(Decimal))) output = (Decimal)value;
            else if (type.IsAssignableFrom(typeof(Double))) output = (Double)value;
            else if (type.IsAssignableFrom(typeof(int))) output = (int)value;
            else if (type.IsAssignableFrom(typeof(long))) output = (long)value;
            else if (type.IsAssignableFrom(typeof(SByte))) output = (SByte)value;
            else if (type.IsAssignableFrom(typeof(short))) output = (short)value;
            else if (type.IsAssignableFrom(typeof(Single))) output = (Single)value;
            else if (type.IsAssignableFrom(typeof(String))) output = (String)value;
            else if (type.IsAssignableFrom(typeof(uint))) output = (uint)value;
            else if (type.IsAssignableFrom(typeof(ulong))) output = (ulong)value;
            else if (type.IsAssignableFrom(typeof(ushort))) output = (ushort)value;
            else if (type.IsAssignableFrom(typeof(Guid))) output = (Guid)value;
            else if (type.IsAssignableFrom(typeof(byte[]))) output = (byte[])value;
            else if (type.IsAssignableFrom(typeof(MemoryStream))) output = (MemoryStream)value;
            else
            {
                output = null;
                return false;
            }
            return true;
        }

        // Get/Set object properties
        private static bool TrySetValue(object instance, MemberInfo member, object value)
        {
            FieldInfo fieldInfo = member as FieldInfo;
            PropertyInfo propertyInfo = member as PropertyInfo;

            if (fieldInfo != null)
            {
                fieldInfo.SetValue(instance, value);
                return true;
            }
            else if (propertyInfo != null)
            {
                propertyInfo.SetValue(instance, value, null);
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool TryGetValue(object instance, MemberInfo member, out object value)
        {
            FieldInfo fieldInfo = member as FieldInfo;
            PropertyInfo propertyInfo = member as PropertyInfo;

            if (fieldInfo != null)
            {
                value = fieldInfo.GetValue(instance);
                return true;
            }
            else if (propertyInfo != null)
            {
                value = propertyInfo.GetValue(instance, null);
                return true;
            }
            else
            {
                value = null;
                return false;
            }
        }

        // Query/Scan building
        private static ScanFilter ComposeScanFilter(IEnumerable<ScanCondition> conditions, ItemStorageConfig storageConfig)
        {
            ScanFilter filter = new ScanFilter();
            foreach (var condition in conditions)
            {
                PropertyStorage propertyStorage = storageConfig.GetPropertyStorage(condition.PropertyName);
                List<AttributeValue> attributeValues = new List<AttributeValue>();
                foreach (var value in condition.Values)
                {
                    var entry = ToDynamoDBEntry(propertyStorage, value, true);
                    if (entry == null)
                        throw new InvalidOperationException(
                            string.Format("Unable to convert value corresponding to property [{0}] to DynamoDB representation", condition.PropertyName));

                    AttributeValue nativeValue = entry.ConvertToAttributeValue();
                    if (nativeValue != null)
                    {
                        attributeValues.Add(nativeValue);
                    }
                }
                filter.AddCondition(propertyStorage.AttributeName, condition.Operator, attributeValues);
            }
            return filter;
        }

        private static QueryFilter ComposeQueryFilter(object hashKeyValue, IEnumerable<QueryCondition> conditions, ItemStorageConfig storageConfig, out List<string> indexNames)
        {
            if (hashKeyValue == null)
                throw new ArgumentNullException("hashKeyValue");

            string hashKeyProperty = storageConfig.HashKeyPropertyNames[0];
            DynamoDBEntry hashKeyEntry = ValueToDynamoDBEntry(hashKeyProperty, hashKeyValue, storageConfig);
            if (hashKeyEntry == null) throw new InvalidOperationException("Unable to convert hash key value for property " + hashKeyProperty);
            string hashAttributeName = storageConfig.GetPropertyStorage(hashKeyProperty).AttributeName;
            Document hashKey = new Document();
            hashKey[hashAttributeName] = hashKeyEntry;

            return ComposeQueryFilterHelper(hashKey, conditions, storageConfig, out indexNames);
        }
        private static QueryFilter ComposeQueryFilterHelper(Document hashKey, IEnumerable<QueryCondition> conditions, ItemStorageConfig storageConfig, out List<string> indexNames)
        {
            if (hashKey == null)
                throw new ArgumentNullException("hashKey");

            if (storageConfig.HashKeyPropertyNames.Count != 1)
                throw new InvalidOperationException("Must have one hash key defined for the table " + storageConfig.TableName);
            if (storageConfig.RangeKeyPropertyNames.Count != 1)
                throw new InvalidOperationException("Must have one range key defined for the table " + storageConfig.TableName);

            QueryFilter filter = new QueryFilter();
            foreach (string hashKeyProperty in storageConfig.HashKeyPropertyNames)
            {
                PropertyStorage propertyStorage = storageConfig.GetPropertyStorage(hashKeyProperty);
                string attributeName = propertyStorage.AttributeName;
                DynamoDBEntry hashValue = hashKey[attributeName];
                filter.AddCondition(attributeName, QueryOperator.Equal, hashValue);
            }

            indexNames = new List<string>();
            if (conditions != null)
            {
                foreach (QueryCondition condition in conditions)
                {
                    object[] conditionValues = condition.Values;
                    PropertyStorage propertyStorage = storageConfig.GetPropertyStorage(condition.PropertyName);
                    if (propertyStorage.IsLSIRangeKey)
                        indexNames.AddRange(propertyStorage.Indexes);
                    List<AttributeValue> attributeValues = new List<AttributeValue>();
                    foreach (var conditionValue in conditionValues)
                    {
                        DynamoDBEntry entry = ToDynamoDBEntry(propertyStorage, conditionValue);
                        AttributeValue attributeValue = entry.ConvertToAttributeValue();
                        attributeValues.Add(attributeValue);
                    }
                    filter.AddCondition(propertyStorage.AttributeName, condition.Operator, attributeValues);
                }
            }
            return filter;
        }

        private static string GetQueryIndexName(ItemStorageConfig storageConfig, QueryFilter filter, DynamoDBFlatConfig flatConfig, List<string> indexNames)
        {
            string specifiedIndexName = flatConfig.IndexName;

            // remove possible duplicate indexes
            indexNames = indexNames.Distinct(StringComparer.Ordinal).ToList();

            string inferredIndexName = null;
            if (string.IsNullOrEmpty(specifiedIndexName) && indexNames.Count == 1)
            {
                inferredIndexName = indexNames[0];
            }
            else if (indexNames.Contains(specifiedIndexName, StringComparer.Ordinal))
            {
                inferredIndexName = specifiedIndexName;
            }

            if (string.IsNullOrEmpty(inferredIndexName) && indexNames.Count > 0)
                throw new InvalidOperationException("Local Secondary Index range key conditions are used but no index could be inferred from model. Specified index name = " + specifiedIndexName);

            // index is both specified and inferred
            if (!string.IsNullOrEmpty(specifiedIndexName) && !string.IsNullOrEmpty(inferredIndexName))
            {
                // check that the indexes are equal
                if (string.Equals(inferredIndexName, specifiedIndexName, StringComparison.Ordinal))
                    return inferredIndexName;
                else
                    throw new InvalidOperationException(string.Format(
                        "Specified index name {0} does not match with inferred index name {1}", specifiedIndexName, inferredIndexName));
            }

            if (!string.IsNullOrEmpty(inferredIndexName))
                return inferredIndexName;

            if (!string.IsNullOrEmpty(specifiedIndexName))
                return specifiedIndexName;

            return null;
        }
        private List<QueryCondition> CreateQueryConditions(DynamoDBOperationConfig config, QueryOperator op, IEnumerable<object> values, ItemStorageConfig storageConfig)
        {
            string rangeKeyPropertyName;

            var flatConfig = new DynamoDBFlatConfig(config, this.config);
            string indexName = flatConfig.IndexName;
            if (string.IsNullOrEmpty(indexName))
                rangeKeyPropertyName = storageConfig.RangeKeyPropertyNames.FirstOrDefault();
            else
            {
                List<string> rangeProperties;
                if (!storageConfig.IndexNameToRangePropertiesMapping.TryGetValue(indexName, out rangeProperties))
                    rangeProperties = null;

                if (rangeProperties == null || rangeProperties.Count != 1)
                    throw new InvalidOperationException("Unable to determine range key from index name");
                rangeKeyPropertyName = rangeProperties[0];
            }
            List<QueryCondition> conditions = new List<QueryCondition>
            {
                new QueryCondition(rangeKeyPropertyName, op, values.ToArray())
            };
            return conditions;
        }


        // Key creation
        private static DynamoDBEntry ValueToDynamoDBEntry(string propertyName, object value, ItemStorageConfig storageConfig)
        {
            PropertyStorage propertyStorage = storageConfig.GetPropertyStorage(propertyName);
            var entry = ToDynamoDBEntry(propertyStorage, value);
            return entry;
        }
        private static void ValidateKey(Key key, ItemStorageConfig storageConfig)
        {
            if (key == null) throw new ArgumentNullException("key");
            if (storageConfig == null) throw new ArgumentNullException("storageConfig");
            if (key.Count == 0) throw new InvalidOperationException("Key is empty");

            foreach (string hashKey in storageConfig.HashKeyPropertyNames)
            {
                string attributeName = storageConfig.GetPropertyStorage(hashKey).AttributeName;
                if (!key.ContainsKey(attributeName))
                    throw new InvalidOperationException("Key missing hash key " + hashKey);
            }
            foreach (string rangeKey in storageConfig.RangeKeyPropertyNames)
            {
                string attributeName = storageConfig.GetPropertyStorage(rangeKey).AttributeName;
                if (!key.ContainsKey(attributeName))
                    throw new InvalidOperationException("Key missing range key " + rangeKey);
            }
        }

        internal static Key MakeKey(object hashKey, object rangeKey, ItemStorageConfig storageConfig)
        {
            if (storageConfig.HashKeyPropertyNames.Count != 1)
                throw new InvalidOperationException("Must have one hash key defined for the table " + storageConfig.TableName);
            string hashKeyPropertyName = storageConfig.HashKeyPropertyNames[0];
            Key key = new Key();

            DynamoDBEntry hashKeyEntry = ValueToDynamoDBEntry(hashKeyPropertyName, hashKey, storageConfig);
            if (hashKeyEntry == null) throw new InvalidOperationException("Unable to convert hash key value for property " + hashKeyPropertyName);
            PropertyStorage hashKeyProperty = storageConfig.GetPropertyStorage(hashKeyPropertyName);
            key[hashKeyProperty.AttributeName] = hashKeyEntry.ConvertToAttributeValue();

            if (storageConfig.RangeKeyPropertyNames.Count > 0)
            {
                if (storageConfig.RangeKeyPropertyNames.Count != 1)
                    throw new InvalidOperationException("Must have one range key defined for the table");

                string rangeKeyPropertyName = storageConfig.RangeKeyPropertyNames[0];
                DynamoDBEntry rangeKeyEntry = ValueToDynamoDBEntry(rangeKeyPropertyName, rangeKey, storageConfig);
                if (rangeKeyEntry == null) throw new InvalidOperationException("Unable to convert range key value for property " + rangeKeyPropertyName);
                PropertyStorage rangeKeyProperty = storageConfig.GetPropertyStorage(rangeKeyPropertyName);
                key[rangeKeyProperty.AttributeName] = rangeKeyEntry.ConvertToAttributeValue();
            }

            ValidateKey(key, storageConfig);
            return key;
        }

        internal static Key MakeKey<T>(T keyObject, ItemStorageConfig storageConfig)
        {
            ItemStorage keyAsStorage = ObjectToItemStorage<T>(keyObject, true, true, storageConfig);
            if (storageConfig.HasVersion) // if version field is defined, it would have been returned, so remove before making the key
                keyAsStorage.Document[storageConfig.VersionPropertyStorage.AttributeName] = null;
            Key key = new Key(keyAsStorage.Document.ToAttributeMap());
            ValidateKey(key, storageConfig);
            return key;
        }

        // Searching
        private IEnumerable<T> FromSearch<T>(Search search)
        {
            if (search == null) throw new ArgumentNullException("search");

            // Configure search to not collect results
            search.CollectResults = false;

            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            while (!search.IsDone)
            {
                List<Document> set = search.GetNextSet();
                foreach (var document in set)
                {
                    ItemStorage storage = new ItemStorage(storageConfig);
                    storage.Document = document;
                    T instance = DocumentToObject<T>(storage);
                    yield return instance;
                }
            }
        }

        #endregion
    }
}
