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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;

using Amazon.Util.Internal;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using ThirdParty.RuntimeBackports;
using Expression = System.Linq.Expressions.Expression;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class DynamoDBContext
    {
        #region Versioning

        internal static void SetNewVersion(ItemStorage storage)
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

        internal static DocumentModel.Expression CreateConditionExpressionForVersion(ItemStorage storage, DynamoDBEntry.AttributeConversionConfig conversionConfig)
        {
            if (!storage.Config.HasVersion) return new DocumentModel.Expression();

            bool shouldExist = storage.CurrentVersion?.ConvertToExpectedAttributeValue(conversionConfig).Exists ?? false;
            string variableName = Common.GetVariableName("version");
            string attributeReference = Common.GetAttributeReference(variableName);
            string versionAttributeName = storage.Config.VersionPropertyStorage.AttributeName;

            if (!shouldExist)
            {
                return new DocumentModel.Expression
                {
                    ExpressionStatement = $"attribute_not_exists({attributeReference})",
                    ExpressionAttributeNames = { [attributeReference] = versionAttributeName }
                };
            }

            string attributeValueReference = Common.GetAttributeValueReference(variableName);
            return new DocumentModel.Expression
            {
                ExpressionStatement = $"{attributeReference} = {attributeValueReference}",
                ExpressionAttributeNames = { [attributeReference] = versionAttributeName },
                ExpressionAttributeValues = { [attributeValueReference] = storage.CurrentVersion }
            };
        }

        #endregion

        #region Atomic counters

        internal static DocumentModel.Expression BuildCounterConditionExpression(ItemStorage storage)
        {
            var atomicCounters = GetCounterProperties(storage);
            DocumentModel.Expression counterConditionExpression = null;

            if (atomicCounters.Length != 0)
            {
                counterConditionExpression = CreateUpdateExpressionForCounterProperties(atomicCounters);
            }

            return counterConditionExpression;
        }

        private static PropertyStorage[] GetCounterProperties(ItemStorage storage)
        {
            var counterProperties = storage.Config.BaseTypeStorageConfig.Properties.
                Where(propertyStorage => propertyStorage.IsCounter).ToArray();

            return counterProperties;
        }

        private static DocumentModel.Expression CreateUpdateExpressionForCounterProperties(PropertyStorage[] counterPropertyStorages)
        {
            if (counterPropertyStorages.Length == 0) return null;

            DocumentModel.Expression updateExpression = new DocumentModel.Expression();
            var asserts = string.Empty;

            foreach (var propertyStorage in counterPropertyStorages)
            {
                string startValueName = $":{propertyStorage.AttributeName}Start";
                string deltaValueName = $":{propertyStorage.AttributeName}Delta";
                string counterAttributeName = Common.GetAttributeReference(propertyStorage.AttributeName);
                asserts += $"{counterAttributeName} = " +
                           $"if_not_exists({counterAttributeName},{startValueName}) + {deltaValueName} ,";
                updateExpression.ExpressionAttributeNames[counterAttributeName] = propertyStorage.AttributeName;
                updateExpression.ExpressionAttributeValues[deltaValueName] = propertyStorage.CounterDelta;

                //CounterDelta is being subtracted from CounterStartValue to compensate it being added back to the starting value
                updateExpression.ExpressionAttributeValues[startValueName] =
                    propertyStorage.CounterStartValue - propertyStorage.CounterDelta;
            }
            updateExpression.ExpressionStatement = $"SET {asserts.Substring(0, asserts.Length - 2)}";

            return updateExpression;
        }

        #endregion

        #region Table methods

        // Retrieves the target table for the specified type
        private Table GetTargetTableInternal<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(DynamoDBFlatConfig flatConfig)
        {
            Type type = typeof(T);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig(type, flatConfig);
            Table table = GetTargetTable(storageConfig, flatConfig, Table.DynamoDBConsumer.DocumentModel);
            return table;
        }

        // Retrieves a new instance of a table configured for the given storage and flat configs.
        internal Table GetTargetTable(ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig,
            Table.DynamoDBConsumer consumer = Table.DynamoDBConsumer.DataModel)
        {
            if (flatConfig == null)
                throw new ArgumentNullException("flatConfig");

            string tableName = GetTableName(storageConfig.TableName, flatConfig);
            var unconfiguredTable = GetUnconfiguredTable(tableName, flatConfig.DisableFetchingTableMetadata);
            ValidateConfigAgainstTable(storageConfig, unconfiguredTable);

            var tableConfig = new TableConfig(tableName, flatConfig.Conversion, consumer,
                storageConfig.AttributesToStoreAsEpoch, storageConfig.AttributesToStoreAsEpochLong, flatConfig.IsEmptyStringValueEnabled,
                flatConfig.MetadataCachingMode);
            var table = unconfiguredTable.Copy(tableConfig);
            return table;
        }

        // This is the call we want to avoid with disableFetchingTableMetadata = true, but as long as we still support false, we still need to call the discouraged sync-over-async 'Table.LoadTable(Client, emptyConfig)'
#pragma warning disable CS0618

        // Retrieves Config-less Table from cache or constructs it on cache-miss
        // This Table should not be used for data operations.
        // To use for data operations, Copy with a TableConfig first.
        internal Table GetUnconfiguredTable(string tableName, bool disableFetchingTableMetadata = false)
        {
            Table table;

            try
            {
                _readerWriterLockSlim.EnterReadLock();

                if (tablesMap.TryGetValue(tableName, out table))
                {
                    return table;
                }
            }
            finally
            {
                if (_readerWriterLockSlim.IsReadLockHeld)
                {
                    _readerWriterLockSlim.ExitReadLock();
                }
            }

            try
            {
                _readerWriterLockSlim.EnterWriteLock();

                // Check to see if another thread got the write lock before this thread and filled the cache.
                if (tablesMap.TryGetValue(tableName, out table))
                {
                    return table;
                }


                if (disableFetchingTableMetadata)
                {
                    return null;
                }

                var emptyConfig = new TableConfig(tableName, conversion: null, consumer: Table.DynamoDBConsumer.DataModel,
                    storeAsEpoch: null, storeAsEpochLong: null, isEmptyStringValueEnabled: false, metadataCachingMode: Config.MetadataCachingMode);
                table = Table.LoadTable(Client, emptyConfig) as Table;
                tablesMap[tableName] = table;

                return table;
            }
            finally
            {
                if (_readerWriterLockSlim.IsWriteLockHeld)
                {
                    _readerWriterLockSlim.ExitWriteLock();
                }
            }
        }

#pragma warning restore CS0618

        /// <summary>
        /// Stores a table in the cache if there is not an existing entry for the given key
        /// </summary>
        /// <param name="tableName">Name of the table used as the cache key</param>
        /// <param name="tableToStore">Table to store if not already present in the cache</param>
        /// <returns>Table that was either found in the cache or newly stored</returns>
        internal void StoreUnconfiguredTable(string tableName, Table tableToStore)
        {
            try
            {
                _readerWriterLockSlim.EnterReadLock();

                // Check to see if the cache was filled since this was invoked
                if (tablesMap.TryGetValue(tableName, out Table table))
                {
                    return;
                }
            }
            finally
            {
                if (_readerWriterLockSlim.IsReadLockHeld)
                {
                    _readerWriterLockSlim.ExitReadLock();
                }
            }

            try
            {
                _readerWriterLockSlim.EnterWriteLock();

                // Check to see if the cache was filled since this was invoked
                if (tablesMap.TryGetValue(tableName, out Table table))
                {
                    return;
                }

                tablesMap.Add(tableName, tableToStore);

                return;
            }
            finally
            {
                if (_readerWriterLockSlim.IsWriteLockHeld)
                {
                    _readerWriterLockSlim.ExitWriteLock();
                }
            }
        }

        internal static string GetTableName(string baseTableName, DynamoDBFlatConfig flatConfig)
        {
            if (flatConfig == null)
                throw new ArgumentNullException("flatConfig");

            string tableName = baseTableName;

            if (!string.IsNullOrEmpty(flatConfig.OverrideTableName))
                tableName = flatConfig.OverrideTableName;
            if (!string.IsNullOrEmpty(flatConfig.TableNamePrefix))
                tableName = flatConfig.TableNamePrefix + tableName;

            return tableName;
        }

        private static void ValidateConfigAgainstTable(ItemStorageConfig config, Table table)
        {
            CompareKeys(config, table, table.HashKeys, config.HashKeyPropertyNames, "hash");
            CompareKeys(config, table, table.RangeKeys, config.RangeKeyPropertyNames, "range");
        }
        private static void CompareKeys(ItemStorageConfig config, Table table, List<string> attributes, List<string> properties, string keyType)
        {
            if (attributes.Count != properties.Count)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Number of {0} keys on table {1} does not match number of hash keys on type {2}",
                    keyType, table.TableName, config.BaseTypeStorageConfig.TargetType.FullName));
            foreach (string hashProperty in properties)
            {
                PropertyStorage property = config.BaseTypeStorageConfig.GetPropertyStorage(hashProperty);
                if (!attributes.Contains(property.AttributeName))
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                        "Key property {0} on type {1} does not correspond to a {2} key on table {3}",
                        hashProperty, config.BaseTypeStorageConfig.TargetType.FullName, keyType, table.TableName));
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

            var dynamoDBBool = entry as DynamoDBBool;
            if (dynamoDBBool != null)
                return true;

            var dynamoDBNull = entry as DynamoDBNull;
            if (dynamoDBNull != null)
                return true;

            var dynamoDBList = entry as DynamoDBList;
            if (dynamoDBList != null)
                return (dynamoDBList.Entries != null);

            var document = entry as Document;
            if (document != null)
                return true;

            throw new InvalidOperationException("Unrecognized DynamoDBEntry object");
        }

        /// <summary>
        /// Deserializes a DynamoDB document to an object
        /// </summary>
        private T DocumentToObject<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ItemStorage storage, DynamoDBFlatConfig flatConfig)
        {
            Type type = typeof(T);
            return (T)DocumentToObject(type, storage, flatConfig);
        }

        private object DocumentToObject([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type objectType, ItemStorage storage, DynamoDBFlatConfig flatConfig)
        {
            if (storage == null) throw new ArgumentNullException("storage");

            if (storage.Document == null) return null;

            StorageConfig storageTypeConfig = null;

            // Check if polymorphic types should be used and if the derived type exists in the document
            if (storage.Config.StorePolymorphicTypes &&
                storage.Document.TryGetValue(flatConfig.DerivedTypeAttributeName, out var typeValue))
            {
                var derivedType = typeValue.AsString();
                storage.Config.PolymorphicTypesStorageConfig.TryGetValue(derivedType, out storageTypeConfig);
            }

            // If a valid derived type config was found, use it; otherwise, use the default object type
            var targetType = storageTypeConfig?.TargetType ?? objectType;

            object instance = Utils.InstantiateConverter(targetType, this);
            PopulateInstance(storage, instance, flatConfig, storageTypeConfig);

            return instance;
        }

        internal class ObjectWithItemStorage
        {
            public object OriginalObject { get; set; }

            public ItemStorage ItemStorage { get; set; }

            public void PopulateObject(DynamoDBContext context, DynamoDBFlatConfig flatConfig)
            {
                context.PopulateInstance(ItemStorage, OriginalObject, flatConfig);
            }
        }

        private void PopulateInstance(ItemStorage storage, object instance, DynamoDBFlatConfig flatConfig,
            StorageConfig storageConfig = null)
        {
            ItemStorageConfig config = storage.Config;
            Document document = storage.Document;

            storageConfig ??= config.BaseTypeStorageConfig;

            using (flatConfig.State.Track(document))
            {
                foreach (PropertyStorage propertyStorage in storageConfig.AllPropertyStorage)
                {
                    if(propertyStorage.IsFlattened) continue;
                    string attributeName = propertyStorage.AttributeName;
                    if (propertyStorage.ShouldFlattenChildProperties)
                    {
                        //create instance of the flatten property
                        var targetType = propertyStorage.MemberType;
                        object flattenedPropertyInstance = Utils.InstantiateConverter(targetType, this);

                        //populate the flatten properties
                        foreach (var flattenPropertyStorage in propertyStorage.FlattenProperties)
                        {
                            string flattenedAttributeName = flattenPropertyStorage.AttributeName;

                            PopulateProperty(storage, flatConfig, document, flattenedAttributeName, flattenPropertyStorage, flattenedPropertyInstance);
                        }
                        if (!TrySetValue(instance, propertyStorage.Member, flattenedPropertyInstance))
                        {
                            throw new InvalidOperationException("Unable to retrieve value from " + attributeName);
                        }
                    }
                    else
                    {
                        PopulateProperty(storage, flatConfig, document, attributeName, propertyStorage, instance);
                    }
                }
            }
        }

        private void PopulateProperty(ItemStorage storage, DynamoDBFlatConfig flatConfig, Document document,
            string attributeName, PropertyStorage propertyStorage, object instance)
        {
            DynamoDBEntry entry;
            if (!document.TryGetValue(attributeName, out entry)) return;

            if (ShouldSave(entry, true))
            {
                object value = FromDynamoDBEntry(propertyStorage, entry, flatConfig);

                if (!TrySetValue(instance, propertyStorage.Member, value))
                {
                    throw new InvalidOperationException("Unable to retrieve value from " + attributeName);
                }
            }

            if (propertyStorage.IsVersion)
                storage.CurrentVersion = entry as Primitive;
        }

        /// <summary>
        /// Serializes an object into a DynamoDB document
        /// </summary>
        private ItemStorage ObjectToItemStorage<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T toStore, bool keysOnly, DynamoDBFlatConfig flatConfig)
        {
            if (toStore == null) return null;

            Type objectType = typeof(T);
            return ObjectToItemStorage(toStore, objectType, keysOnly, flatConfig);
        }

        private ItemStorage ObjectToItemStorage(object toStore, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type objectType, bool keysOnly, DynamoDBFlatConfig flatConfig)
        {
            ItemStorageConfig config = StorageConfigCache.GetConfig(objectType, flatConfig);
            ItemStorage storage = ObjectToItemStorageHelper(toStore, config, flatConfig, keysOnly, flatConfig.IgnoreNullValues != null && flatConfig.IgnoreNullValues.Value);
            return storage;
        }
        internal ItemStorage ObjectToItemStorageHelper(object toStore, ItemStorageConfig config, DynamoDBFlatConfig flatConfig, bool keysOnly, bool ignoreNullValues)
        {
            ItemStorage storage = new ItemStorage(config);
            PopulateItemStorage(toStore, storage, flatConfig, keysOnly, ignoreNullValues);
            return storage;
        }

        private void PopulateItemStorage(object toStore, ItemStorage storage, DynamoDBFlatConfig flatConfig,
            bool keysOnly, bool ignoreNullValues)
        {
            ItemStorageConfig config = storage.Config;
            Document document = storage.Document;

            using (flatConfig.State.Track(toStore))
            {
                Type toStoreType = toStore.GetType();
                StorageConfig storageConfig;

                if (config.PolymorphicConfig.TryGetValue(toStoreType, out var derivedTypeKey))
                {
                    // If the object is a derived type, populate document using the derived type StorageConfig
                    // and store the derived type key in the document
                    document[flatConfig.DerivedTypeAttributeName] = new Primitive(derivedTypeKey);
                    storageConfig = config.PolymorphicTypesStorageConfig[derivedTypeKey];
                }
                else
                {
                    storageConfig = config.BaseTypeStorageConfig;
                }

                foreach (PropertyStorage propertyStorage in storageConfig.AllPropertyStorage)
                {
                    // if only keys are being serialized, skip non-key properties
                    // still include version, however, to populate the storage.CurrentVersion field
                    // and include counter, to populate the storage.CurrentCount field
                    if (keysOnly && !propertyStorage.IsHashKey && !propertyStorage.IsRangeKey &&
                        !propertyStorage.IsVersion && !propertyStorage.IsCounter) continue;

                    if (propertyStorage.IsFlattened) continue;

                    string propertyName = propertyStorage.PropertyName;
                    string attributeName = propertyStorage.AttributeName;

                    object value;
                    if (TryGetValue(toStore, propertyStorage.Member, out value))
                    {
                        DynamoDBEntry dbe = ToDynamoDBEntry(propertyStorage, value, flatConfig, propertyStorage.ShouldFlattenChildProperties);

                        if (ShouldSave(dbe, ignoreNullValues))
                        {

                            if (propertyStorage.ShouldFlattenChildProperties)
                            {
                                if (dbe == null) continue;

                                if (dbe is not Document innerDocument) continue;

                                foreach (var pair in innerDocument)
                                {
                                    document[pair.Key] = pair.Value;
                                }
                            }
                            else
                            {
                                Primitive dbePrimitive = dbe as Primitive;
                                if (propertyStorage.IsHashKey || propertyStorage.IsRangeKey ||
                                    propertyStorage.IsVersion || propertyStorage.IsLSIRangeKey)
                                {
                                    if (dbe != null && dbePrimitive == null)
                                        throw new InvalidOperationException("Property " + propertyName +
                                                                            " is a hash key, range key or version property and must be Primitive");
                                }

                                document[attributeName] = dbe;

                                if (propertyStorage.IsVersion)
                                    storage.CurrentVersion = dbePrimitive;
                            }
                        }
                    }
                    else
                        throw new InvalidOperationException(
                            "Unable to retrieve value from property " + propertyName);
                }
            }
        }

        // DynamoDBEntry <--> Object
        private object FromDynamoDBEntry(SimplePropertyStorage propertyStorage, DynamoDBEntry entry, DynamoDBFlatConfig flatConfig)
        {
            var converter = propertyStorage.Converter;
            if (converter != null)
                return converter.FromEntry(entry);

            var conversion = flatConfig.Conversion;
            var targetType = propertyStorage.MemberType;

            if (conversion.HasConverter(targetType))
            {
                var output = conversion.ConvertFromEntry(targetType, entry);
                if (!flatConfig.RetrieveDateTimeInUtc)
                {
                    if (targetType == typeof(DateTime))
                    {
                        //This is a valid use of .ToLocalTime because by default the dates are in UTC. If the user specifies to not retrieve in UTC we must convert to LocalTime.
                        return ((DateTime)output).ToLocalTime();
                    }
                    else if (targetType == typeof(DateTime?))
                    {
                        //This is a valid use of .ToLocalTime because by default the dates are in UTC. If the user specifies to not retrieve in UTC we must convert to LocalTime.
                        return ((DateTime?)output)?.ToLocalTime();
                    }
                }
                return output;
            }
            else
            {
                if (entry is DynamoDBNull)
                    return null;

                object output;
                Document document = entry as Document;
                if (document != null)
                {
                    if (TryFromMap(targetType, document, flatConfig, propertyStorage, out output))
                        return output;

                    var typeAttributeName = flatConfig.DerivedTypeAttributeName;//"$type"; 
                    var derivedType = document.ContainsKey(typeAttributeName) ? document[typeAttributeName].AsString() : null;

                    if (derivedType != null && propertyStorage.TryGetDerivedType(derivedType, out var value))
                    {
                        targetType = value;
                    }

                    return DeserializeFromDocument(document, targetType, flatConfig);
                }

                DynamoDBList list = entry as DynamoDBList;
                if (list != null &&
                    TryFromList(targetType, list, flatConfig, propertyStorage, out output))
                {
                    return output;
                }

                bool isAotRuntime = InternalSDKUtils.IsRunningNativeAot();
                string errorMessage;
                
                if (isAotRuntime)
                {
                    errorMessage = $"Unable to convert DynamoDB entry [{entry}] of type {entry.GetType().FullName} to property {propertyStorage.PropertyName} of type {targetType.FullName}. " +
                        "Since the application is running in Native AOT mode the type could possibly be trimmed. " +
                        "This can happen if the type being created is a nested type of a type being used for saving and loading DynamoDB items. " +
                        $"This can be worked around by adding the \"[DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof({targetType.FullName}))]\" attribute to the constructor of the parent type." + 
                        " If the parent type can not be modified the attribute can also be used on the method invoking the DynamoDB sdk or some other method that you are sure is not being trimmed.";
                }
                else
                {
                    errorMessage = string.Format(CultureInfo.InvariantCulture,
                        "Unable to convert DynamoDB entry [{0}] of type {1} to property {2} of type {3}",
                        entry, entry.GetType().FullName, propertyStorage.PropertyName, propertyStorage.MemberType.FullName);
                }

                throw new InvalidOperationException(errorMessage);
            }
        }
        private bool TryFromList([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType, DynamoDBList list, DynamoDBFlatConfig flatConfig,
            SimplePropertyStorage parentPropertyStorage, out object output)
        {
            return targetType.IsArray ?
                 TryFromListToArray(targetType, list, flatConfig, parentPropertyStorage, out output) : //targetType is Array
                 TryFromListToIList(targetType, list, flatConfig, parentPropertyStorage, out output) ; //targetType is IList or has Add method.
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2062",
            Justification = "The user's type has been annotated with InternalConstants.DataModelModeledType with the public API into the library. At this point the type will not be trimmed.")]

        private bool TryFromListToIList([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType, DynamoDBList list, DynamoDBFlatConfig flatConfig, SimplePropertyStorage parentPropertyStorage, out object output)
        {
            if ((!Utils.ImplementsInterface(targetType, typeof(ICollection<>)) &&
                !Utils.ImplementsInterface(targetType, typeof(IList))) ||
                !Utils.CanInstantiate(targetType))
            {
                output = null;
                return false;
            }

            var elementType = targetType.GetGenericArguments()[0];
            var collection = Utils.Instantiate(targetType);
            IList ilist = collection as IList;
            bool useIListInterface = ilist != null;
            var propertyStorage = new SimplePropertyStorage(elementType, parentPropertyStorage);

            MethodInfo collectionAdd = null;
            if (!useIListInterface)
            {
                collectionAdd = targetType.GetMethod("Add");
            }

            foreach (DynamoDBEntry entry in list.Entries)
            {
                var item = FromDynamoDBEntry(propertyStorage, entry, flatConfig);

                if (useIListInterface)
                    ilist.Add(item);
                else
                    collectionAdd.Invoke(collection, new object[] { item });
            }

            output = collection;
            return true;
        }

        private bool TryFromListToArray([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType, DynamoDBList list, DynamoDBFlatConfig flatConfig, SimplePropertyStorage parentPropertyStorage, out object output)
        {
            if (!Utils.CanInstantiateArray(targetType))
            {
                output = null;
                return false;
            }

            var elementType = Utils.GetElementType(targetType);
            var array = (Array)Utils.InstantiateArray(targetType, list.Entries.Count);
            var propertyStorage = new SimplePropertyStorage(elementType, parentPropertyStorage);

            for (int i = 0; i < list.Entries.Count; i++)
            {
                var entry = list.Entries[i];
                var item = FromDynamoDBEntry(propertyStorage, entry, flatConfig);
                array.SetValue(item, i);
            }

            output = array;
            return true;
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2067",
            Justification = "The user's type has been annotated with InternalConstants.DataModelModeledType with the public API into the library. At this point the type will not be trimmed.")]
        private bool TryFromMap([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType, Document map, DynamoDBFlatConfig flatConfig, SimplePropertyStorage parentPropertyStorage, out object output)
        {
            output = null;

            if (!Utils.CanInstantiate(targetType))
                return false;

            Type valueType;
            if (!IsSupportedDictionaryType(targetType, out valueType))
                return false;

            var dictionary = Utils.Instantiate(targetType);
            var idictionary = dictionary as IDictionary;
            var propertyStorage = new SimplePropertyStorage(valueType, parentPropertyStorage);

            foreach (var kvp in map)
            {
                var key = kvp.Key;
                var entry = kvp.Value;

                var item = FromDynamoDBEntry(propertyStorage, entry, flatConfig);
                idictionary.Add(key, item);
            }

            output = dictionary;
            return true;
        }

        internal DynamoDBEntry ToDynamoDBEntry(SimplePropertyStorage propertyStorage, object value, DynamoDBFlatConfig flatConfig)
        {
            return ToDynamoDBEntry(propertyStorage, value, flatConfig, canReturnScalarInsteadOfList: false);
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2072",
            Justification = "The user's type has been annotated with InternalConstants.DataModelModeledType with the public API into the library. At this point the type will not be trimmed.")]
        private DynamoDBEntry ToDynamoDBEntry(SimplePropertyStorage propertyStorage, object value,
            DynamoDBFlatConfig flatConfig, bool canReturnScalarInsteadOfList)
        {
            if (value == null)
                return null;

            var conversion = flatConfig.Conversion;
            var converter = propertyStorage.Converter;
            if (converter != null)
            {
                var entry = converter.ToEntry(value);
                if (entry != null)
                    entry = entry.ToConvertedEntry(conversion);
                return entry;
            }

            Type type;
            string typeDiscriminator = null;
            if (propertyStorage.TryGetDerivedTypeDiscriminator(value.GetType(), out var td))
            {
                typeDiscriminator = td;
                type = value.GetType();
            }
            else
            {
                type = propertyStorage.MemberType;
            }

            if (canReturnScalarInsteadOfList)
            {
                DynamoDBEntry entry = null;
                if (TryToScalar(value, type, flatConfig, ref entry))
                    return entry;
            }

            if (conversion.HasConverter(type))
                return conversion.ConvertToEntry(type, value);
            else
            {
                Document map;
                if (TryToMap(value, type, flatConfig, propertyStorage, out map))
                    return map;

                DynamoDBList list;
                if (TryToList(value, type, flatConfig, propertyStorage, out list))
                    return list;

                return SerializeToDocument(value, type, flatConfig, typeDiscriminator);
            }
        }

        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2067",
            Justification = "The user's type has been annotated with InternalConstants.DataModelModeledType with the public API into the library. At this point the type will not be trimmed.")]
        private bool TryToMap(object value, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type, DynamoDBFlatConfig flatConfig,
            SimplePropertyStorage parentPropertyStorage, out Document output)
        {
            output = null;

            Type keyType, valueType;
            if (!IsSupportedDictionaryType(type, out keyType, out valueType))
                return false;

            var idictionary = value as IDictionary;
            if (idictionary == null)
                return false;

            output = new Document();
            SimplePropertyStorage propertyStorage = new SimplePropertyStorage(valueType, parentPropertyStorage);

            foreach (object keyValue in idictionary.Keys)
            {
                object item = idictionary[keyValue];
                string key = keyValue as string;
                if (key == null)
                    continue;

                DynamoDBEntry entry;
                if (item == null)
                    entry = DynamoDBNull.Null;
                else
                    entry = ToDynamoDBEntry(propertyStorage, item, flatConfig, false);

                output[key] = entry;
            }
            return true;
        }

        private bool TryToList(object value, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type type, DynamoDBFlatConfig flatConfig,
            SimplePropertyStorage parentPropertyStoragey, out DynamoDBList output)
        {
            if (!Utils.ImplementsInterface(type, typeof(ICollection<>)))
            {
                output = null;
                return false;
            }

            IEnumerable enumerable = value as IEnumerable;

            // Strings are collections of chars, don't treat them as collections
            if (enumerable == null || value is string)
            {
                output = null;
                return false;
            }

            Type elementType = Utils.GetElementType(type);

            SimplePropertyStorage propertyStorage = new SimplePropertyStorage(elementType, parentPropertyStoragey);
            output = new DynamoDBList();
            foreach (var item in enumerable)
            {
                DynamoDBEntry entry;
                if (item == null)
                    entry = DynamoDBNull.Null;
                else
                {
                    entry = ToDynamoDBEntry(propertyStorage, item, flatConfig, false);
                }

                output.Add(entry);
            }
            return true;
        }

        private bool TryToScalar(object value, Type type, DynamoDBFlatConfig flatConfig, ref DynamoDBEntry entry)
        {
            var elementType = Utils.GetElementType(type);
            if (elementType != null)
            {
                IEnumerable enumerable = value as IEnumerable;

                // Strings are collections of chars, don't treat them as collections
                if (enumerable == null || value is string)
                {
                    // Only convert if value matches collection element type
                    if (value.GetType().IsAssignableFrom(elementType))
                    {
                        DynamoDBEntryConversion conversion = flatConfig.Conversion;
                        if (conversion.HasConverter(elementType))
                        {
                            if (conversion.TryConvertToEntry(elementType, value, out entry))
                                return true;
                        }
                        else
                        {
                            try
                            {
                                entry = SerializeToDocument(value, elementType, flatConfig, typeDiscriminator: null);
                                return true;
                            }
                            catch { }
                        }
                    }
                }
            }

            return false;
        }

        private static bool IsSupportedDictionaryType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type type, out Type valueType)
        {
            Type keyType;
            return IsSupportedDictionaryType(type, out keyType, out valueType);
        }

        private static bool IsSupportedDictionaryType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type type, out Type keyType, out Type valueType)
        {
            keyType = valueType = null;

            // Type must implement both IDictionary<TKey,TValue> and IDictionary
            if (!(Utils.ImplementsInterface(type, typeof(IDictionary<,>)) &&
                 Utils.ImplementsInterface(type, typeof(IDictionary))))
                return false;

            var genericArguments = type.GetGenericArguments();
            if (genericArguments.Length != 2)
                return false;
            keyType = genericArguments[0];
            valueType = genericArguments[1];
            if (keyType != typeof(string) || valueType == typeof(object))
                return false;

            return true;
        }

        /// <summary>
        /// Deserializes a given Document to instance of targetType
        /// Use only for property conversions, not for full item conversion
        /// </summary>
        private object DeserializeFromDocument(Document document, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type targetType, DynamoDBFlatConfig flatConfig)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig(targetType, flatConfig, conversionOnly: true);
            ItemStorage storage = new ItemStorage(storageConfig);
            storage.Document = document;
            object value = DocumentToObject(targetType, storage, flatConfig);
            return value;
        }

        /// <summary>
        /// Serializes a given value to Document
        /// Use only for property conversions, not for full item conversion
        /// </summary>
        private Document SerializeToDocument(object value, [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type type, DynamoDBFlatConfig flatConfig, string typeDiscriminator)
        {
            ItemStorageConfig config = StorageConfigCache.GetConfig(type, flatConfig, conversionOnly: true);
            var itemStorage = ObjectToItemStorageHelper(value, config, flatConfig, keysOnly: false, ignoreNullValues: flatConfig.IgnoreNullValues.Value);
            var doc = itemStorage.Document;
            if (typeDiscriminator != null)
            {
                var typeAttributeName = flatConfig.DerivedTypeAttributeName;
                doc[typeAttributeName] = new Primitive(typeDiscriminator);
            }
            return doc;
        }

        /// <summary>
        /// Get/Set object properties
        /// </summary>
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

        /// <summary>
        /// Query/Scan building
        /// </summary>
        private ScanFilter ComposeScanFilter(IEnumerable<ScanCondition> conditions, ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            ScanFilter filter = new ScanFilter();

            var conditionsToUse = new List<ScanCondition>();
            if (conditions != null)
            {
                conditionsToUse.AddRange(conditions);
            }
            if (flatConfig.QueryFilter != null)
            {
                conditionsToUse.AddRange(flatConfig.QueryFilter);
            }

            foreach (var condition in conditionsToUse)
            {
                PropertyStorage propertyStorage =
                    storageConfig.BaseTypeStorageConfig.GetPropertyStorage(condition.PropertyName);
                List<AttributeValue> attributeValues = new List<AttributeValue>();
                foreach (var value in condition.Values)
                {
                    var entry = ToDynamoDBEntry(propertyStorage, value, flatConfig, canReturnScalarInsteadOfList: true);
                    if (entry == null)
                        throw new InvalidOperationException(
                            string.Format(CultureInfo.InvariantCulture,
                                "Unable to convert value corresponding to property [{0}] to DynamoDB representation",
                                condition.PropertyName));

                    var attributeConversionConfig =
                        new DynamoDBEntry.AttributeConversionConfig(flatConfig.Conversion,
                            flatConfig.IsEmptyStringValueEnabled);
                    AttributeValue nativeValue = entry.ConvertToAttributeValue(attributeConversionConfig);
                    if (nativeValue != null)
                    {
                        attributeValues.Add(nativeValue);
                    }
                }

                filter.AddCondition(propertyStorage.AttributeName, condition.Operator, attributeValues);
            }

            return filter;
        }

        private QueryFilter ComposeQueryFilter(DynamoDBFlatConfig currentConfig, object hashKeyValue, IEnumerable<QueryCondition> conditions, ItemStorageConfig storageConfig, out List<string> indexNames)
        {
            ValidateHashKey(hashKeyValue, storageConfig);
            var hashKeyEntry = HashKeyValueToDynamoDBEntry(currentConfig, hashKeyValue, storageConfig);

            Document hashKey = new Document
            {
                [hashKeyEntry.Item1] = hashKeyEntry.Item2
            };

            return ComposeQueryFilterHelper(currentConfig, hashKey, conditions, storageConfig, out indexNames);
        }

        private (string, DynamoDBEntry) HashKeyValueToDynamoDBEntry(DynamoDBFlatConfig currentConfig, object hashKeyValue,
            ItemStorageConfig storageConfig)
        {
            // Set hash key property name
            // In case of index queries, if GSI, different key could be used
            string hashKeyProperty = storageConfig.HashKeyPropertyNames[0];
            hashKeyProperty = storageConfig.GetCorrectHashKeyProperty(currentConfig, hashKeyProperty);

            PropertyStorage propertyStorage = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(hashKeyProperty);
            string hashAttributeName = propertyStorage.AttributeName;

            DynamoDBEntry hashKeyEntry = ValueToDynamoDBEntry(propertyStorage, hashKeyValue, currentConfig);
            if (hashKeyEntry == null) throw new InvalidOperationException("Unable to convert hash key value for property " + hashKeyProperty);

            return (hashAttributeName, hashKeyEntry);
        }

        private static void ValidateHashKey(object hashKeyValue, ItemStorageConfig storageConfig)
        {
            if (hashKeyValue == null)
                throw new ArgumentNullException("hashKeyValue");

            if (storageConfig.HashKeyPropertyNames == null || storageConfig.HashKeyPropertyNames.Count == 0)
            {
                throw new InvalidOperationException($"Attempted to make a query without a defined hash key attribute. " +
                                                    $"If using {nameof(DynamoDBContextConfig.DisableFetchingTableMetadata)}, ensure that the table's hash key " +
                                                    $"is annotated with {nameof(DynamoDBHashKeyAttribute)}.");
            }
        }

        private static string NO_INDEX = DynamoDBFlatConfig.DefaultIndexName;

        private void ValidateQueryKeyConfiguration(ItemStorageConfig storageConfig, DynamoDBFlatConfig currentConfig)
        {
            if (storageConfig.HashKeyPropertyNames.Count != 1)
            {
                var tableName = GetTableName(storageConfig.TableName, currentConfig);
                throw new InvalidOperationException("Must have one hash key defined for the table " + tableName);
            }

            if (storageConfig.RangeKeyPropertyNames.Count != 1 && storageConfig.IndexNameToGSIMapping.Count == 0)
            {
                var tableName = GetTableName(storageConfig.TableName, currentConfig);
                throw new InvalidOperationException("Must have one range key or a GSI index defined for the table " + tableName);
            }
        }

        // This method composes the query filter and determines the possible indexes that the filter
        // may be used against. In the case where the condition property is also a RANGE key on the
        // table and not just on LSI/GSI, the potential index will be "" (absent).
        private QueryFilter ComposeQueryFilterHelper(
            DynamoDBFlatConfig currentConfig,
            Document hashKey,
            IEnumerable<QueryCondition> conditions,
            ItemStorageConfig storageConfig,
            out List<string> indexNames)
        {
            if (hashKey == null)
                throw new ArgumentNullException("hashKey");

            ValidateQueryKeyConfiguration(storageConfig, currentConfig);

            QueryFilter filter = new QueryFilter();

            // Configure hash-key equality condition
            string hashKeyProperty = storageConfig.HashKeyPropertyNames[0];
            hashKeyProperty = storageConfig.GetCorrectHashKeyProperty(currentConfig, hashKeyProperty);
            PropertyStorage propertyStorage = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(hashKeyProperty);
            string attributeName = propertyStorage.AttributeName;
            DynamoDBEntry hashValue = hashKey[attributeName];
            filter.AddCondition(attributeName, QueryOperator.Equal, hashValue);

            indexNames = new List<string>();
            if (conditions != null)
            {
                foreach (QueryCondition condition in conditions)
                {
                    if (string.IsNullOrEmpty(condition.PropertyName))
                    {
                        throw new InvalidOperationException($"Attempted to make a query with a range key condition without a defined range attribute. " +
                            $"If using {nameof(DynamoDBContextConfig.DisableFetchingTableMetadata)}, ensure that the table's range key(s) " +
                            $"are annotated with {nameof(DynamoDBRangeKeyAttribute)}, {nameof(DynamoDBLocalSecondaryIndexRangeKeyAttribute)}, " +
                            $"or {nameof(DynamoDBGlobalSecondaryIndexRangeKeyAttribute)}.");
                    }
                    object[] conditionValues = condition.Values;
                    PropertyStorage conditionProperty = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(condition.PropertyName);
                    if (conditionProperty.IsLSIRangeKey || conditionProperty.IsGSIKey)
                        indexNames.AddRange(conditionProperty.IndexNames);
                    if (conditionProperty.IsRangeKey)
                        indexNames.Add(NO_INDEX);
                    List<AttributeValue> attributeValues = ConvertConditionValues(conditionValues, conditionProperty, currentConfig);
                    filter.AddCondition(conditionProperty.AttributeName, condition.Operator, attributeValues);
                }
            }
            if (currentConfig.QueryFilter != null)
            {
                foreach (ScanCondition condition in currentConfig.QueryFilter)
                {
                    object[] conditionValues = condition.Values;
                    PropertyStorage conditionProperty = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(condition.PropertyName);
                    List<AttributeValue> attributeValues = ConvertConditionValues(conditionValues, conditionProperty, currentConfig, canReturnScalarInsteadOfList: true);
                    filter.AddCondition(conditionProperty.AttributeName, condition.Operator, attributeValues);
                }
            }
            return filter;
        }

        private List<AttributeValue> ConvertConditionValues(object[] conditionValues, PropertyStorage conditionProperty, DynamoDBFlatConfig flatConfig, bool canReturnScalarInsteadOfList = false)
        {
            List<AttributeValue> attributeValues = new List<AttributeValue>();
            foreach (var conditionValue in conditionValues)
            {
                DynamoDBEntry entry = ToDynamoDBEntry(conditionProperty, conditionValue, flatConfig, canReturnScalarInsteadOfList);
                var attributeConversionConfig = new DynamoDBEntry.AttributeConversionConfig(flatConfig.Conversion, flatConfig.IsEmptyStringValueEnabled);
                AttributeValue attributeValue = entry.ConvertToAttributeValue(attributeConversionConfig);
                attributeValues.Add(attributeValue);
            }
            return attributeValues;
        }

        private static string GetQueryIndexName(DynamoDBFlatConfig flatConfig, List<string> indexNames)
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
            else if (string.IsNullOrEmpty(inferredIndexName) && indexNames.Count > 0)
                throw new InvalidOperationException("Local Secondary Index range key conditions are used but no index could be inferred from model. Specified index name = " + specifiedIndexName);

            // index is both specified and inferred
            if (!string.IsNullOrEmpty(specifiedIndexName) && !string.IsNullOrEmpty(inferredIndexName))
            {
                // check that the indexes are equal
                if (string.Equals(inferredIndexName, specifiedIndexName, StringComparison.Ordinal))
                    return inferredIndexName;
                else
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                        "Specified index name {0} does not match with inferred index name {1}", specifiedIndexName, inferredIndexName));
            }

            if (!string.IsNullOrEmpty(inferredIndexName))
                return inferredIndexName;

            if (!string.IsNullOrEmpty(specifiedIndexName))
                return specifiedIndexName;

            return null;
        }

        private static List<QueryCondition> CreateQueryConditions(DynamoDBFlatConfig flatConfig, QueryOperator op, IEnumerable<object> values, ItemStorageConfig storageConfig)
        {
            string rangeKeyPropertyName;

            string indexName = flatConfig.IndexName;
            if (string.IsNullOrEmpty(indexName))
                rangeKeyPropertyName = storageConfig.RangeKeyPropertyNames.FirstOrDefault();
            else
                rangeKeyPropertyName = storageConfig.GetRangeKeyByIndex(indexName);

            List<QueryCondition> conditions = new List<QueryCondition>
            {
                new QueryCondition(rangeKeyPropertyName, op, values.ToArray())
            };
            return conditions;
        }

        // Key creation
        private DynamoDBEntry ValueToDynamoDBEntry(PropertyStorage propertyStorage, object value, DynamoDBFlatConfig flatConfig)
        {
            var entry = ToDynamoDBEntry(propertyStorage, value, flatConfig, false);
            return entry;
        }
        private static void ValidateKey(Key key, ItemStorageConfig storageConfig)
        {
            if (key == null) throw new ArgumentNullException("key");
            if (storageConfig == null) throw new ArgumentNullException("storageConfig");
            if (key.Count == 0) throw new InvalidOperationException("Key is empty");

            foreach (string hashKey in storageConfig.HashKeyPropertyNames)
            {
                string attributeName = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(hashKey).AttributeName;
                if (!key.ContainsKey(attributeName))
                    throw new InvalidOperationException("Key missing hash key " + hashKey);
            }
            foreach (string rangeKey in storageConfig.RangeKeyPropertyNames)
            {
                string attributeName = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(rangeKey).AttributeName;
                if (!key.ContainsKey(attributeName))
                    throw new InvalidOperationException("Key missing range key " + rangeKey);
            }
        }

        internal Key MakeKey(object hashKey, object rangeKey, ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            if (storageConfig.HashKeyPropertyNames.Count != 1)
            {
                var tableName = GetTableName(storageConfig.TableName, flatConfig);
                throw new InvalidOperationException("Must have one hash key defined for the table " + tableName);
            }

            Key key = new Key();

            string hashKeyPropertyName = storageConfig.HashKeyPropertyNames[0];
            PropertyStorage hashKeyProperty = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(hashKeyPropertyName);

            DynamoDBEntry hashKeyEntry = ValueToDynamoDBEntry(hashKeyProperty, hashKey, flatConfig);
            if (hashKeyEntry == null) throw new InvalidOperationException("Unable to convert hash key value for property " + hashKeyPropertyName);
            if (storageConfig.AttributesToStoreAsEpoch.Contains(hashKeyProperty.AttributeName))
                hashKeyEntry = Document.DateTimeToEpochSeconds(hashKeyEntry, hashKeyProperty.AttributeName);
            if (storageConfig.AttributesToStoreAsEpochLong.Contains(hashKeyProperty.AttributeName))
                hashKeyEntry = Document.DateTimeToEpochSecondsLong(hashKeyEntry, hashKeyProperty.AttributeName);
            var hashKeyEntryAttributeConversionConfig = new DynamoDBEntry.AttributeConversionConfig(flatConfig.Conversion, flatConfig.IsEmptyStringValueEnabled);
            key[hashKeyProperty.AttributeName] = hashKeyEntry.ConvertToAttributeValue(hashKeyEntryAttributeConversionConfig);

            if (storageConfig.RangeKeyPropertyNames.Count > 0)
            {
                if (storageConfig.RangeKeyPropertyNames.Count != 1)
                {
                    var tableName = GetTableName(storageConfig.TableName, flatConfig);
                    throw new InvalidOperationException("Must have one range key defined for the table " + tableName);
                }

                string rangeKeyPropertyName = storageConfig.RangeKeyPropertyNames[0];
                PropertyStorage rangeKeyProperty = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(rangeKeyPropertyName);

                DynamoDBEntry rangeKeyEntry = ValueToDynamoDBEntry(rangeKeyProperty, rangeKey, flatConfig);
                if (rangeKeyEntry == null) throw new InvalidOperationException("Unable to convert range key value for property " + rangeKeyPropertyName);
                if (storageConfig.AttributesToStoreAsEpoch.Contains(rangeKeyProperty.AttributeName))
                    rangeKeyEntry = Document.DateTimeToEpochSeconds(rangeKeyEntry, rangeKeyProperty.AttributeName);
                if (storageConfig.AttributesToStoreAsEpochLong.Contains(rangeKeyProperty.AttributeName))
                    rangeKeyEntry = Document.DateTimeToEpochSecondsLong(rangeKeyEntry, rangeKeyProperty.AttributeName);

                var rangeKeyEntryAttributeConversionConfig = new DynamoDBEntry.AttributeConversionConfig(flatConfig.Conversion, flatConfig.IsEmptyStringValueEnabled);
                key[rangeKeyProperty.AttributeName] = rangeKeyEntry.ConvertToAttributeValue(rangeKeyEntryAttributeConversionConfig);
            }

            ValidateKey(key, storageConfig);
            return key;
        }
        internal Key MakeKey<T>(T keyObject, ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            ItemStorage keyAsStorage = ObjectToItemStorageHelper(keyObject, storageConfig, flatConfig, keysOnly: true, ignoreNullValues: true);
            if (storageConfig.HasVersion) // if version field is defined, it would have been returned, so remove before making the key
                keyAsStorage.Document[storageConfig.VersionPropertyStorage.AttributeName] = null;
            Key key = new Key(keyAsStorage.Document.ToAttributeMap(flatConfig.Conversion, storageConfig.AttributesToStoreAsEpoch, storageConfig.AttributesToStoreAsEpochLong, flatConfig.IsEmptyStringValueEnabled));
            ValidateKey(key, storageConfig);
            return key;
        }

        // Searching
        internal class ContextSearch
        {
            public DynamoDBFlatConfig FlatConfig { get; set; }
            public Search Search { get; set; }

            public ContextSearch(Search search, DynamoDBFlatConfig flatConfig)
            {
                Search = search;
                FlatConfig = flatConfig;
            }
        }

        private IEnumerable<T> FromSearch<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ContextSearch cs)
        {
            if (cs == null) throw new ArgumentNullException("cs");

            // Configure search to not collect results
            cs.Search.CollectResults = false;

            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(cs.FlatConfig);
            while (!cs.Search.IsDone)
            {
                List<Document> set = cs.Search.GetNextSetHelper();
                foreach (var document in set)
                {
                    ItemStorage storage = new ItemStorage(storageConfig);
                    storage.Document = document;
                    T instance = DocumentToObject<T>(storage, cs.FlatConfig);
                    yield return instance;
                }
            }

            // Reset search to allow retrieving items more than once
            cs.Search.Reset();
        }

        #endregion

        #region Scan/Query

        private ContextSearch ConvertScan<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, this.Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            ScanFilter filter = ComposeScanFilter(conditions, storageConfig, flatConfig);

            Table table = GetTargetTable(storageConfig, flatConfig);
            var scanConfig = new ScanOperationConfig
            {
                AttributesToGet = storageConfig.AttributesToGet,
                Select = SelectValues.SpecificAttributes,
                Filter = filter,
                ConditionalOperator = flatConfig.ConditionalOperator,
                IndexName = flatConfig.IndexName,
                ConsistentRead = flatConfig.ConsistentRead.GetValueOrDefault(false)
            };

            // table.Scan() returns the ISearch interface but we explicitly cast it to a Search object since we rely on its internal behavior
            Search scan = table.Scan(scanConfig) as Search;
            return new ContextSearch(scan, flatConfig);
        }


        internal ContextSearch ConvertScan<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ContextExpression filterExpression, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, this.Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);

            DocumentModel.Expression expression = null;
            if (filterExpression is not { Filter: null })
            {
                if (flatConfig.QueryFilter != null && flatConfig.QueryFilter.Count != 0)
                {
                    throw new InvalidOperationException("QueryFilter is not supported with filter expression. Use either QueryFilter or filter expression, but not both.");
                }
                expression = ComposeExpression(filterExpression.Filter, storageConfig, flatConfig);
            }

            Table table = GetTargetTable(storageConfig, flatConfig);
            var scanConfig = new ScanOperationConfig
            {
                AttributesToGet = storageConfig.AttributesToGet,
                Select = SelectValues.SpecificAttributes,
                FilterExpression = expression,
                IndexName = flatConfig.IndexName,
                ConsistentRead = flatConfig.ConsistentRead.GetValueOrDefault(false)
            };

            // table.Scan() returns the ISearch interface but we explicitly cast it to a Search object since we rely on its internal behavior
            Search scan = table.Scan(scanConfig) as Search;
            return new ContextSearch(scan, flatConfig);
        }

        private ContextSearch ConvertFromScan<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Table table = GetTargetTable(storageConfig, flatConfig);

            // table.Scan() returns the ISearch interface but we explicitly cast it to a Search object since we rely on its internal behavior
            Search search = table.Scan(scanConfig) as Search;
            return new ContextSearch(search, flatConfig);
        }

        private ContextSearch ConvertFromQuery<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Table table = GetTargetTable(storageConfig, flatConfig);

            // table.Query() returns the ISearch interface but we explicitly cast it to a Search object since we rely on its internal behavior
            Search search = table.Query(queryConfig) as Search;
            return new ContextSearch(search, flatConfig);
        }

        private ContextSearch ConvertQueryByValue<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig)
        {
            if (operationConfig != null)
            {
                operationConfig.ValidateFilter();
            }

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
          
            ContextSearch query;
            if (operationConfig is { Expression: { Filter: not null } })
            {
                query = ConvertQueryByValueWithExpression<T>(hashKeyValue, op, values, operationConfig.Expression.Filter,
                    operationConfig, storageConfig);
            }
            else
            {
                List<QueryCondition> conditions = CreateQueryConditions(flatConfig, op, values, storageConfig);
                query = ConvertQueryByValue<T>(hashKeyValue, conditions, operationConfig, storageConfig);
            }
            return query;
        }

        private ContextSearch ConvertQueryByValueWithExpression<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values,
            Expression filterExpression, DynamoDBOperationConfig operationConfig, ItemStorageConfig storageConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);

            if (storageConfig == null)
                storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            if (operationConfig.QueryFilter != null && operationConfig.QueryFilter.Count != 0)
            {
                throw new InvalidOperationException("QueryFilter is not supported with filter expression. Use either QueryFilter or filter expression, but not both.");
            }
            return ConvertQueryHelper<T>(hashKeyValue, op, values, flatConfig, storageConfig, filterExpression);

        }

        internal ContextSearch
            ConvertQueryByValue<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(
                object hashKeyValue, IEnumerable<QueryCondition> conditions, DynamoDBOperationConfig operationConfig,
                ItemStorageConfig storageConfig = null)
        {
            if (operationConfig != null)
            {
                operationConfig.ValidateFilter();
            }

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);

            storageConfig ??= StorageConfigCache.GetConfig<T>(flatConfig);

            ContextSearch query;
            if (operationConfig is { Expression: { Filter: not null } })
            {
                if(conditions!=null && conditions.Any())
                {
                    throw new InvalidOperationException("Query conditions are not supported with filter expression. Use either Query conditions or filter expression, but not both.");
                }
                query = ConvertQueryByValueWithExpression<T>(hashKeyValue, QueryOperator.Equal, null,
                    operationConfig.Expression.Filter, operationConfig, storageConfig);
            }
            else
            {
                List<string> indexNames;
                QueryFilter filter = ComposeQueryFilter(flatConfig, hashKeyValue, conditions, storageConfig, out indexNames);
                query = ConvertQueryHelper<T>(flatConfig, storageConfig, filter, indexNames);
            }

            return query;
        }

        private ContextSearch ConvertQueryHelper<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(
                object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBFlatConfig flatConfig,
                ItemStorageConfig storageConfig,
                Expression filterExpression)
        {
            ValidateHashKey(hashKeyValue, storageConfig);
            ValidateQueryKeyConfiguration(storageConfig, flatConfig);

            var hashKeyEntry = HashKeyValueToDynamoDBEntry(flatConfig, hashKeyValue, storageConfig);
            var keyExpression = new DocumentModel.Expression
            {
                ExpressionStatement = "#hashKey = :hashKey",
                ExpressionAttributeValues = new Dictionary<string, DynamoDBEntry>
                {
                    { ":hashKey", hashKeyEntry.Item2 }
                },
                ExpressionAttributeNames = new Dictionary<string, string>
                {
                    { "#hashKey", hashKeyEntry.Item1 }
                }
            };

            string indexName = flatConfig.IndexName;

            var rangeKeyPropertyName = string.IsNullOrEmpty(indexName) ?
                storageConfig.RangeKeyPropertyNames.FirstOrDefault() : storageConfig.GetRangeKeyByIndex(indexName);

            if (!string.IsNullOrEmpty(rangeKeyPropertyName) && values != null)
            {
                keyExpression.ExpressionStatement += ContextExpressionsUtils.GetRangeKeyConditionExpression($"#rangeKey", op);
                keyExpression.ExpressionAttributeNames.Add("#rangeKey", rangeKeyPropertyName);
                var valuesList = values?.ToList();
                var rangeKeyProperty = storageConfig.BaseTypeStorageConfig.GetPropertyStorage(rangeKeyPropertyName);
                if (op == QueryOperator.Between && valuesList is { Count: 2 })
                {
                    keyExpression.ExpressionAttributeValues.Add(":rangeKey0", ToDynamoDBEntry(
                        rangeKeyProperty,
                        valuesList.ElementAt(0),
                        flatConfig,
                        true));
                    keyExpression.ExpressionAttributeValues.Add(":rangeKey1", ToDynamoDBEntry(
                        rangeKeyProperty,
                        valuesList.ElementAt(1),
                        flatConfig,
                        true));
                }
                else
                {
                    keyExpression.ExpressionAttributeValues.Add(":rangeKey0", ToDynamoDBEntry(
                        rangeKeyProperty,
                        valuesList.FirstOrDefault(),
                        flatConfig,
                        true
                    ));
                }
            }

            Table table = GetTargetTable(storageConfig, flatConfig);
            var queryConfig = new QueryOperationConfig
            {
                ConsistentRead = flatConfig.ConsistentRead.Value,
                BackwardSearch = flatConfig.BackwardQuery.Value,
                KeyExpression = keyExpression,
            };

            var expression = ComposeExpression(filterExpression, storageConfig, flatConfig);

            queryConfig.FilterExpression = expression;

            if (string.IsNullOrEmpty(indexName))
            {
                queryConfig.Select = SelectValues.SpecificAttributes;
                List<string> attributesToGet = storageConfig.AttributesToGet;
                queryConfig.AttributesToGet = attributesToGet;
            }
            else
            {
                queryConfig.IndexName = indexName;
                queryConfig.Select = SelectValues.AllProjectedAttributes;
            }
            Search query = table.Query(queryConfig) as Search;

            return new ContextSearch(query, flatConfig);
        }



        private ContextSearch ConvertQueryHelper<T>(DynamoDBFlatConfig currentConfig, ItemStorageConfig storageConfig, QueryFilter filter, List<string> indexNames)
        {
            Table table = GetTargetTable(storageConfig, currentConfig);
            string indexName = GetQueryIndexName(currentConfig, indexNames);
            var queryConfig = new QueryOperationConfig
            {
                Filter = filter,
                ConsistentRead = currentConfig.ConsistentRead.Value,
                BackwardSearch = currentConfig.BackwardQuery.Value,
                IndexName = indexName,
                ConditionalOperator = currentConfig.ConditionalOperator
            };
            if (string.IsNullOrEmpty(indexName))
            {
                queryConfig.Select = SelectValues.SpecificAttributes;
                List<string> attributesToGet = storageConfig.AttributesToGet;
                queryConfig.AttributesToGet = attributesToGet;
            }
            else
            {
                queryConfig.Select = SelectValues.AllProjectedAttributes;
            }

            // table.Query() returns the ISearch interface but we explicitly cast it to a Search object since we rely on its internal behavior
            Search query = table.Query(queryConfig) as Search;

            return new ContextSearch(query, currentConfig);
        }

        private AsyncSearch<T> FromSearchAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ContextSearch contextSearch)
        {
            return new AsyncSearch<T>(this, contextSearch);
        }

        #endregion

        #region Expression Building

        private DocumentModel.Expression ComposeExpression(Expression filterExpression, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            DocumentModel.Expression filter = new DocumentModel.Expression();
            if (filterExpression == null) return filter;


            var aliasList = new KeyAttributeAliasList();
            var expressionNode = BuildExpressionNode(filterExpression, storageConfig, flatConfig);

            filter.ExpressionStatement = expressionNode.BuildExpressionString(aliasList, "C");
            if (aliasList.NamesList != null && aliasList.NamesList.Count != 0)
            {
                var namesDictionary = new Dictionary<string, string>();
                for (int i = 0; i < aliasList.NamesList.Count; i++)
                {
                    namesDictionary[$"#C{i}"] = aliasList.NamesList[i];
                }

                filter.ExpressionAttributeNames = namesDictionary;
            }

            if (aliasList.ValuesList != null && aliasList.ValuesList.Count != 0)
            {
                var values = new Dictionary<string, DynamoDBEntry>();
                for (int i = 0; i < aliasList.ValuesList.Count; i++)
                {
                    values[$":C{i}"] = aliasList.ValuesList[i];
                }

                filter.ExpressionAttributeValues = values;
            }

            return filter;
        }

        private ExpressionNode BuildExpressionNode(Expression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode();

            switch (expr)
            {
                case LambdaExpression lambda:
                    // Recursively process the body of the lambda
                    return BuildExpressionNode(lambda.Body, storageConfig, flatConfig);
                case BinaryExpression binary when ContextExpressionsUtils.IsComparison(binary.NodeType):
                    node = HandleBinaryComparison(binary, storageConfig, flatConfig);
                    break;

                case BinaryExpression binary:
                    // Handle AND/OR expressions
                    var left = BuildExpressionNode(binary.Left, storageConfig, flatConfig);
                    var right = BuildExpressionNode(binary.Right, storageConfig, flatConfig);
                    node.Children.Enqueue(left);
                    node.Children.Enqueue(right);
                    var condition = binary.NodeType == ExpressionType.AndAlso ? "AND" : "OR";
                    node.FormatedExpression = $"(#c) {condition} (#c)";
                    break;

                case MethodCallExpression method:
                    node = HandleMethodCall(method, storageConfig, flatConfig);
                    break;

                case UnaryExpression { NodeType: ExpressionType.Not } unary:
                    var notUnary = BuildExpressionNode(unary.Operand, storageConfig, flatConfig);
                    node.Children.Enqueue(notUnary);
                    node.FormatedExpression = ExpressionFormatConstants.Not;
                    break;

                default:
                    throw new InvalidOperationException($"Unsupported expression type: {expr.NodeType}");
            }

            return node;
        }

        private ExpressionNode HandleBinaryComparison(BinaryExpression expr, ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            Expression member = null;
            object constant = null;

            if (ContextExpressionsUtils.IsMember(expr.Left))
            {
                member = expr.Left;
                constant = ContextExpressionsUtils.GetConstant(expr.Right);
            }
            else if (ContextExpressionsUtils.IsMember(expr.Right))
            {
                member = expr.Right;
                constant = ContextExpressionsUtils.GetConstant(expr.Left);
            }

            if (member == null)
                throw new NotSupportedException("Expected member access");

            var node = new ExpressionNode
            {
                FormatedExpression = expr.NodeType switch
                {
                    ExpressionType.Equal => ExpressionFormatConstants.Equal,
                    ExpressionType.NotEqual => ExpressionFormatConstants.NotEqual,
                    ExpressionType.LessThan => ExpressionFormatConstants.LessThan,
                    ExpressionType.LessThanOrEqual => ExpressionFormatConstants.LessThanOrEqual,
                    ExpressionType.GreaterThan => ExpressionFormatConstants.GreaterThan,
                    ExpressionType.GreaterThanOrEqual => ExpressionFormatConstants.GreaterThanOrEqual,
                    _ => throw new InvalidOperationException($"Unsupported mode: {expr.NodeType}")
                }
            };

            SetExpressionNodeAttributes(storageConfig, member, constant, node, flatConfig);

            return node;
        }

        private ExpressionNode HandleMethodCall(MethodCallExpression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            // Handle method calls like Equals, Between, In, AttributeExists, AttributeNotExists, AttributeType, BeginsWith, Contains
            return expr.Method.Name switch
            {
                "Equals" => HandleEqualsMethodCall(expr, storageConfig, flatConfig),
                "Contains" => HandleContainsMethodCall(expr, storageConfig, flatConfig),
                "StartsWith" => HandleStartsWithMethodCall(expr, storageConfig, flatConfig),
                "In" => HandleInMethodCall(expr, storageConfig, flatConfig),
                "Between" => HandleBetweenMethodCall(expr, storageConfig, flatConfig),
                "AttributeExists" => HandleExistsMethodCall(expr, storageConfig, flatConfig),
                "IsNull" or "AttributeNotExists" => HandleIsNullMethodCall(expr, storageConfig, flatConfig),
                "AttributeType" => HandleAttributeTypeMethodCall(expr, storageConfig, flatConfig),
                _ => throw new NotSupportedException($"Unsupported method call: {expr.Method.Name}")
            };
        }

        private ExpressionNode HandleAttributeTypeMethodCall(MethodCallExpression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode
            {
                FormatedExpression = ExpressionFormatConstants.AttributeType
            };

            if (expr.Arguments.Count == 2 && expr.Object == null)
            {
                var memberObj = ContextExpressionsUtils.GetMember(expr.Arguments[0]);
                var typeExpr = ContextExpressionsUtils.GetConstant(expr.Arguments[1]);
                if (memberObj!=null && typeExpr!=null)
                {
                    SetExpressionNodeAttributes(storageConfig, memberObj, typeExpr, node, flatConfig);
                }
                else
                {
                    throw new NotSupportedException("Expected MemberExpression and ConstantExpression as arguments for AttributeType method call.");
                }
            }
            else
            {
                throw new NotSupportedException("Expected MemberExpression and ConstantExpression as arguments for AttributeType method call.");
            }
            return node;
        }

        private ExpressionNode HandleIsNullMethodCall(MethodCallExpression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode
            {
                FormatedExpression = ExpressionFormatConstants.AttributeNotExists
            };

            if (expr.Arguments.Count == 1 && expr.Object == null)
            {
                var collectionExpr = expr.Arguments[0] as MemberExpression;
                if (collectionExpr != null)
                {
                    SetExpressionNameNode(storageConfig, collectionExpr, node, flatConfig);
                }
                else
                {
                    throw new NotSupportedException("Expected MemberExpression as argument for AttributeNotExists method call.");
                }
            }
            else
            {
                throw new NotSupportedException("Expected MemberExpression as argument for AttributeNotExists method call.");
            }

            return node;
        }

        private ExpressionNode HandleExistsMethodCall(MethodCallExpression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode
            {
                FormatedExpression = ExpressionFormatConstants.AttributeExists
            };

            if (expr.Arguments.Count == 1 && expr.Object == null)
            {
                var collectionExpr = expr.Arguments[0] as MemberExpression;
                if (collectionExpr != null)
                {
                    SetExpressionNameNode(storageConfig, collectionExpr, node, flatConfig);
                }
                else
                {
                    throw new NotSupportedException("Expected MemberExpression as argument for AttributeExists method call.");
                }
            }

            return node;
        }

        private ExpressionNode HandleInMethodCall(MethodCallExpression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode
            {
                FormatedExpression = ExpressionFormatConstants.In
            };

            if (expr.Object is MemberExpression memberObj && expr.Arguments[0] is NewArrayExpression arrayExpr)
            {
                var propertyStorage = SetExpressionNameNode(storageConfig, memberObj, node, flatConfig);

                foreach (var arg in arrayExpr.Expressions)
                {
                    if (arg is not ConstantExpression constExpr) continue;

                    node.FormatedExpression += "#c, ";

                    SetExpressionValueNode(constExpr, node, propertyStorage, flatConfig);
                }
            }
            else
            {
                throw new NotSupportedException("Expected MemberExpression with NewArrayExpression as argument for In method call.");
            }

            if (node.FormatedExpression.EndsWith(", "))
            {
                node.FormatedExpression = node.FormatedExpression.Substring(0, node.FormatedExpression.Length - 2);
            }
            node.FormatedExpression += ")";
            return node;
        }

        private ExpressionNode HandleBetweenMethodCall(MethodCallExpression expr,
            ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode
            {
                FormatedExpression = ExpressionFormatConstants.Between
            };


            if (expr.Arguments.Count == 3 && expr.Object == null)
            {
                var collectionExpr = expr.Arguments[0] as MemberExpression;
                var constExprLeft = expr.Arguments[1] as ConstantExpression;
                var constExprRight = expr.Arguments[2] as ConstantExpression;

                if (collectionExpr != null && constExprLeft != null && constExprRight != null)
                {
                    var propertyStorage = SetExpressionNameNode(storageConfig, collectionExpr, node, flatConfig);

                    SetExpressionValueNode(ContextExpressionsUtils.GetConstant(constExprLeft), node, propertyStorage, flatConfig);
                    SetExpressionValueNode(ContextExpressionsUtils.GetConstant(constExprRight), node, propertyStorage, flatConfig);
                }
            }
            else
            {
                throw new NotSupportedException("Expected MemberExpression with NewArrayExpression as argument for In method call.");
            }

            return node;
        }

        private ExpressionNode HandleStartsWithMethodCall(MethodCallExpression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode
            {
                FormatedExpression = ExpressionFormatConstants.BeginsWith
            };
            if (expr.Object is MemberExpression memberObj && expr.Arguments[0] is ConstantExpression argConst)
            {
                var constantValue=ContextExpressionsUtils.GetConstant(argConst);
                SetExpressionNodeAttributes(storageConfig, memberObj, constantValue, node, flatConfig);
            }
            else
            {
                throw new NotSupportedException("Expected MemberExpression with ConstantExpression as argument for StartsWith method call.");
            }

            return node;
        }

        private ExpressionNode HandleContainsMethodCall(MethodCallExpression expr,
            ItemStorageConfig storageConfig, DynamoDBFlatConfig flatConfig)
        {
            var node = new ExpressionNode
            {
                FormatedExpression = ExpressionFormatConstants.Contains
            };
            if (expr.Object is MemberExpression memberObj && expr.Arguments[0] is ConstantExpression argConst)
            {
                SetExpressionNodeAttributes(storageConfig, memberObj, ContextExpressionsUtils.GetConstant(argConst), node, flatConfig);
            }
            else if (expr.Arguments.Count == 2 && expr.Object == null)
            {
                var collectionExpr = expr.Arguments[0] as MemberExpression;
                var constExpr = expr.Arguments[1] as ConstantExpression;

                if (collectionExpr != null && constExpr != null)
                {
                    SetExpressionNodeAttributes(storageConfig, collectionExpr, ContextExpressionsUtils.GetConstant(constExpr), node, flatConfig);
                }
                else
                {
                    throw new NotSupportedException(
                        "Expected MemberExpression with ConstantExpression as argument for Contains method call.");
                }
            }
            else
            {
                throw new NotSupportedException(
                    "Expected MemberExpression with ConstantExpression as argument for Contains method call.");
            }

            return node;
        }

        private ExpressionNode HandleEqualsMethodCall(MethodCallExpression expr, ItemStorageConfig storageConfig,
            DynamoDBFlatConfig flatConfig)
        {
            const string formatedExpression = ExpressionFormatConstants.Equal;
            var node = new ExpressionNode
            {
                FormatedExpression = formatedExpression
            };

            if (expr.Object is MemberExpression member &&
                expr.Arguments[0] is ConstantExpression constant &&
                constant.Value == null)
            {
                SetExpressionNodeAttributes(storageConfig, member, constant, node, flatConfig);
                return node;
            }
            else if (expr.Arguments.Count == 2 && expr.Object == null)
            {
                Expression memberObj = null;
                object argConst = null;

                if (ContextExpressionsUtils.IsMember(expr.Arguments[0]))
                {
                    memberObj = expr.Arguments[0];
                    argConst = ContextExpressionsUtils.GetConstant(expr.Arguments[1]);
                }
                else if (ContextExpressionsUtils.IsMember(expr.Arguments[1]))
                {
                    memberObj = expr.Arguments[1];
                    argConst = ContextExpressionsUtils.GetConstant(expr.Arguments[0]);
                }

                if (memberObj != null && argConst != null)
                {
                    SetExpressionNodeAttributes(storageConfig, memberObj, argConst, node, flatConfig);
                    return node;
                }
            }

            throw new NotSupportedException("Expected MemberExpression with ConstantExpression as argument for Equals method call.");
        }

        private void SetExpressionNodeAttributes(ItemStorageConfig storageConfig, Expression memberObj,
            object argConst, ExpressionNode node, DynamoDBFlatConfig flatConfig)
        {
            var propertyStorage = SetExpressionNameNode(storageConfig, memberObj, node, flatConfig);
            SetExpressionValueNode(argConst, node, propertyStorage, flatConfig);
        }

        private void SetExpressionValueNode(object argConst, ExpressionNode node, PropertyStorage propertyStorage, DynamoDBFlatConfig flatConfig)
        {
            DynamoDBEntry entry = ToDynamoDBEntry(propertyStorage, argConst, flatConfig, canReturnScalarInsteadOfList: true);
            var valuesNode = new ExpressionNode()
            {
                FormatedExpression = ExpressionFormatConstants.Value
            };
            valuesNode.Values.Enqueue(entry);
            node.Children.Enqueue(valuesNode);
        }

        private PropertyStorage ResolveNestedPropertyStorage(StorageConfig rootConfig, DynamoDBFlatConfig flatConfig,
            List<PathNode> path, Queue<string> namesNodeNames)
        {
            StorageConfig currentConfig = rootConfig;
            PropertyStorage propertyStorage = null;
            for (int i = 0; i < path.Count; i++)
            {
                var pathNode = path[i];

                // If the path node is a map, just add the name to the queue
                if (pathNode.IsMap)
                {
                    namesNodeNames.Enqueue(pathNode.Path);
                    continue;
                }

                propertyStorage = currentConfig.GetPropertyStorage(pathNode.Path);
                if (propertyStorage == null)
                    throw new InvalidOperationException($"Property '{pathNode.Path}' not found in storage config.");
                // If the property is ignored, throw an exception
                if (propertyStorage.IsIgnored)
                {
                    throw new InvalidOperationException($"Property '{pathNode.Path}' is marked as ignored and cannot be used in a filter expression.");
                }

                namesNodeNames.Enqueue(propertyStorage.AttributeName);
                // If not the last segment, descend into the nested StorageConfig
                if (i >= path.Count - 1) continue;

                // Only descend if the property is a complex type (not primitive/string)
                var propertyType = propertyStorage.MemberType;
                if (Utils.IsPrimitive(propertyType))
                    throw new InvalidOperationException($"Property '{pathNode.Path}' is not a complex type.");

                // Determine the element type if the property is a collection
                var nextPathNode = path[i + 1];

                Type elementType = null;
                var depth = pathNode.IndexDepth;
                if (nextPathNode is { IsMap: true })
                {
                    depth += nextPathNode.IndexDepth;
                }

                var node = new PropertyNode()
                {
                    PropertyType = propertyType
                };
                var currentDepth = 0;

                while (currentDepth <= depth && node.PropertyType != null && Utils.ImplementsInterface(node.PropertyType, typeof(ICollection<>))
                       && node.PropertyType != typeof(string))
                {
                    elementType = Utils.GetElementType(node.PropertyType) ?? GetDictionaryValueType(node.PropertyType);
                    node.PropertyType = elementType;
                    currentDepth++;
                }
                elementType ??= propertyType;

                ItemStorageConfig config = StorageConfigCache.GetConfig(elementType, flatConfig);
                currentConfig = config.BaseTypeStorageConfig;
            }

            return propertyStorage;
        }


        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2073",
            Justification = "The user's type has been annotated with DynamicallyAccessedMemberTypes.All with the public API into the library. At this point the type will not be trimmed.")]
        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2063",
            Justification = "The user's type has been annotated with DynamicallyAccessedMemberTypes.All with the public API into the library. At this point the type will not be trimmed.")]
        [return: DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)]
        private static Type GetDictionaryValueType([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type type)
        {
            if (!(Utils.ImplementsInterface(type, typeof(IDictionary<,>)) &&
                  Utils.ImplementsInterface(type, typeof(IDictionary)))) { }
            else
            {
                var genericArguments = type.GetGenericArguments();
                if (genericArguments != null && genericArguments.Length == 2)
                    return genericArguments[1];
            }
            return null;
        }
        private PropertyStorage SetExpressionNameNode(ItemStorageConfig storageConfig, Expression memberObj,
            ExpressionNode node, DynamoDBFlatConfig flatConfig)
        {
            var path = ContextExpressionsUtils.ExtractPathNodes(memberObj);
            if (path.Count == 0)
            {
                throw new InvalidOperationException("Expected a valid property path in the expression.");
            }
            var namesNode = new ExpressionNode()
            {
                FormatedExpression = string.Join(".", path.Select(pn => pn.FormattedPath))
            };

            var propertyStorage = ResolveNestedPropertyStorage(storageConfig.BaseTypeStorageConfig, flatConfig, path, namesNode.Names);
            node.Children.Enqueue(namesNode);

            return propertyStorage;
        }


        #endregion
    }
}
