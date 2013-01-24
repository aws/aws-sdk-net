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
using System.IO;
using System.Reflection;

using Amazon.DynamoDB.DocumentModel;
using Amazon.DynamoDB.Model;

namespace Amazon.DynamoDB.DataModel
{
    internal class DynamoDBFlatConfig : DynamoDBOperationConfig
    {
        private static DynamoDBOperationConfig _emptyOperationConfig = new DynamoDBOperationConfig
        {
            ConsistentRead = null, OverrideTableName = null, SkipVersionCheck = null, TableNamePrefix = null
        };
        private static DynamoDBContextConfig _emptyContextConfig = new DynamoDBContextConfig
        {
            ConsistentRead = null, SkipVersionCheck = null, TableNamePrefix = null
        };

        public DynamoDBFlatConfig(DynamoDBOperationConfig operationConfig, DynamoDBContextConfig contextConfig)
        {
            if (operationConfig == null)
                operationConfig = _emptyOperationConfig;
            if (contextConfig == null)
                contextConfig = _emptyContextConfig;

            bool consistentRead = operationConfig.ConsistentRead ?? contextConfig.ConsistentRead ?? false;
            bool skipVersionCheck = operationConfig.SkipVersionCheck ?? contextConfig.SkipVersionCheck ?? false;
            bool ignoreNullValues = operationConfig.IgnoreNullValues ?? contextConfig.IgnoreNullValues ?? false;
            string overrideTableName =
                !string.IsNullOrEmpty(operationConfig.OverrideTableName) ? operationConfig.OverrideTableName : string.Empty;
            string tableNamePrefix =
                !string.IsNullOrEmpty(operationConfig.TableNamePrefix) ? operationConfig.TableNamePrefix :
                !string.IsNullOrEmpty(contextConfig.TableNamePrefix) ? contextConfig.TableNamePrefix : string.Empty;
            bool backwardQuery = operationConfig.BackwardQuery ?? false;

            ConsistentRead = consistentRead;
            SkipVersionCheck = skipVersionCheck;
            IgnoreNullValues = ignoreNullValues;
            OverrideTableName = overrideTableName;
            TableNamePrefix = tableNamePrefix;
            BackwardQuery = backwardQuery;
        }
    }

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
            string hashKeyTableAttribute = table.HashKeyName;
            string hashKeyConfigAttribute = config.HashPropertyStorage.AttributeName;
            if (!string.Equals(hashKeyTableAttribute, hashKeyConfigAttribute, StringComparison.Ordinal))
                throw new InvalidOperationException("Hash key on table and on type do not match");

            if (string.IsNullOrEmpty(table.RangeKeyName) != string.IsNullOrEmpty(config.RangeKeyPropertyName))
                throw new InvalidOperationException("Range key presence on table and type does not match");

            if (config.HasRangeKey)
            {
                string rangeKeyTableAttribute = table.RangeKeyName;
                string rangeKeyConfigAttribute = config.RangePropertyStorage.AttributeName;
                if (!string.Equals(rangeKeyTableAttribute, rangeKeyConfigAttribute, StringComparison.Ordinal))
                    throw new InvalidOperationException("Range key on table and on type do not match");
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

            object instance = EntityUtils.Instantiate(objectType);
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
                        if (propertyStorage.IsHashKey || propertyStorage.IsRangeKey || propertyStorage.IsVersion)
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
            if ((!EntityUtils.ImplementsInterface(targetType, typeof(ICollection<>)) &&
                !EntityUtils.ImplementsInterface(targetType, typeof(IList))) ||
                !EntityUtils.CanInstantiate(targetType) ||
                !EntityUtils.IsPrimitive(elementType = targetType.GetGenericArguments()[0]))
            {
                output = null;
                return false;
            }
            
            var collection = EntityUtils.Instantiate(targetType);
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
            if (!EntityUtils.ImplementsInterface(type, typeof(ICollection<>)) ||
                !EntityUtils.IsPrimitive(elementType = type.GetGenericArguments()[0]))
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

        // Query/Scan filter creation
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
        private static RangeFilter ComposeRangeFilter(QueryOperator op, IEnumerable<object> values, ItemStorageConfig storageConfig)
        {
            RangeFilter filter;
            if (values != null)
            {
                PropertyStorage propertyStorage = storageConfig.RangePropertyStorage;

                List<AttributeValue> attributeValues = new List<AttributeValue>();
                foreach (var value in values)
                {
                    var entry = ToDynamoDBEntry(propertyStorage, value);

                    AttributeValue nativeValue = entry.ConvertToAttributeValue();
                    if (nativeValue != null)
                    {
                        attributeValues.Add(nativeValue);
                    }
                }

                filter = new RangeFilter(op, attributeValues);
            }
            else
            {
                filter = new RangeFilter();
            }
            return filter;
        }

        // Key creation
        private static DynamoDBEntry ValueToDynamoDBEntry(string propertyName, object value, ItemStorageConfig storageConfig)
        {
            PropertyStorage propertyStorage = storageConfig.GetPropertyStorage(propertyName);

            var entry = ToDynamoDBEntry(propertyStorage, value);

            return entry;
        }
        internal static Key MakeKey(object hashKeyValue, object rangeKeyValue, ItemStorageConfig storageConfig)
        {
            if (hashKeyValue == null) throw new ArgumentNullException("hashKeyValue");
            if (storageConfig.HasRangeKey && rangeKeyValue == null) throw new ArgumentNullException("rangeKeyValue");

            Key key = new Key();

            DynamoDBEntry hashKeyEntry = ValueToDynamoDBEntry(storageConfig.HashKeyPropertyName, hashKeyValue, storageConfig);
            if (hashKeyEntry == null) throw new InvalidOperationException("Unable to convert hash key value for property " + storageConfig.HashKeyPropertyName);
            key.HashKeyElement = hashKeyEntry.ConvertToAttributeValue();

            if (storageConfig.HasRangeKey)
            {
                DynamoDBEntry rangeKeyEntry = ValueToDynamoDBEntry(storageConfig.RangeKeyPropertyName, rangeKeyValue, storageConfig);
                if (rangeKeyEntry == null) throw new InvalidOperationException("Unable to convert range key value for property " + storageConfig.RangeKeyPropertyName);
                key.RangeKeyElement = rangeKeyEntry.ConvertToAttributeValue();
            }

            return key;
        }

        // Searching
        private IEnumerable<T> FromSearch<T>(Search search)
        {
            if (search == null) throw new ArgumentNullException("search");

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
