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

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Telemetry.Tracing;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface ITable
    {
        #region PutItem

        /// <summary>
        /// Puts a document into DynamoDB, using optional configs.
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        Document PutItem(Document doc, PutItemOperationConfig config = null);

        /// <summary>
        /// Puts a document into DynamoDB, using optional configs.
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if put is successful or false if the condition in the config was not met.</returns>
        bool TryPutItem(Document doc, PutItemOperationConfig config = null);

        #endregion

        #region GetItem

        /// <summary>
        /// Gets a document from DynamoDB by hash primary key, using specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Document from DynamoDB.</returns>
        Document GetItem(Primitive hashKey, GetItemOperationConfig config = null);

        /// <summary>
        /// Gets a document from DynamoDB by hash-and-range primary key,
        /// using specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Document from DynamoDB.</returns>
        Document GetItem(Primitive hashKey, Primitive rangeKey, GetItemOperationConfig config = null);

        /// <summary>
        /// Gets a document from DynamoDB by key, using specified configs.
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Document from DynamoDB.</returns>
        Document GetItem(IDictionary<string, DynamoDBEntry> key, GetItemOperationConfig config = null);

        #endregion

        #region UpdateItem

        /// <summary>
        /// Update a document in DynamoDB, using specified config.
        /// </summary>
        /// <param name="doc">Document to update.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        Document UpdateItem(Document doc, UpdateItemOperationConfig config = null);

        /// <summary>
        /// Update a document in DynamoDB, using specified config.
        /// </summary>
        /// <param name="doc">Document to update.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if updated or false if the condition in the config was not met.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        bool TryUpdateItem(Document doc, UpdateItemOperationConfig config = null);

        /// <summary>
        /// Update a document in DynamoDB, with a key to identify the
        /// document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        Document UpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config = null);

        /// <summary>
        /// Update a document in DynamoDB, with a key to identify the
        /// document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if updated or false if the condition in the config was not met.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        bool TryUpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config = null);

        /// <summary>
        /// Update a document in DynamoDB, with a hash primary key to identify
        /// the document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        Document UpdateItem(Document doc, Primitive hashKey, UpdateItemOperationConfig config = null);

        /// <summary>
        /// Update a document in DynamoDB, with a hash primary key to identify
        /// the document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if updated or false if the condition in the config was not met.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        bool TryUpdateItem(Document doc, Primitive hashKey, UpdateItemOperationConfig config = null);

        /// <summary>
        /// Update a document in DynamoDB, with a hash-and-range primary key to identify
        /// the document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        Document UpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config = null);

        /// <summary>
        /// Update a document in DynamoDB, with a hash-and-range primary key to identify
        /// the document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if updated or false if the condition in the config was not met.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        bool TryUpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config = null);

        #endregion

        #region DeleteItem

        /// <summary>
        /// Delete a document in DynamoDB, using specified configs.
        /// </summary>
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">If the condition set on the config fails.</exception>
        /// <param name="document">Document to delete.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        Document DeleteItem(Document document, DeleteItemOperationConfig config = null);

        /// <summary>
        /// Delete a document in DynamoDB, using specified configs.
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if deleted or false if the condition in the config was not met.</returns>
        bool TryDeleteItem(Document document, DeleteItemOperationConfig config = null);

        /// <summary>
        /// Delete a document in DynamoDB, identified by hash-key,
        /// using the specified configs.
        /// </summary>
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">If the condition set on the config fails.</exception>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        Document DeleteItem(Primitive hashKey, DeleteItemOperationConfig config = null);

        /// <summary>
        /// Delete a document in DynamoDB, identified by a hash primary key,
        /// using specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if deleted or false if the condition in the config was not met.</returns>
        bool TryDeleteItem(Primitive hashKey, DeleteItemOperationConfig config = null);

        /// <summary>
        /// Delete a document in DynamoDB, identified by hash-and-range primary key,
        /// using the specified configs.
        /// </summary>
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">If the condition set on the config fails.</exception>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        Document DeleteItem(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config = null);

        /// <summary>
        /// Delete a document in DynamoDB, identified by hash-and-range primary key,
        /// using the specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if deleted or false if the condition in the config was not met.</returns>
        bool TryDeleteItem(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config = null);

        /// <summary>
        /// Delete a document in DynamoDB, identified by a key, using specified configs.
        /// </summary>
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">If the condition set on the config fails.</exception>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        Document DeleteItem(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config = null);

        /// <summary>
        /// Delete a document in DynamoDB, identified by a key, using specified configs.
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>True if deleted or false if the condition in the config was not met.</returns>
        bool TryDeleteItem(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config = null);

        #endregion
    }

    public partial class Table : ITable
    {
        #region PutItem

        /// <inheritdoc/>
        public Document PutItem(Document doc, PutItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(PutItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return PutItemHelper(doc, config);
            }
        }

        /// <inheritdoc/>
        public bool TryPutItem(Document doc, PutItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryPutItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    PutItemHelper(doc, config);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        #endregion


        #region GetItem

        /// <inheritdoc/>
        public Document GetItem(Primitive hashKey, GetItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return GetItem(hashKey, null, config);
            }
        }

        /// <inheritdoc/>
        public Document GetItem(Primitive hashKey, Primitive rangeKey, GetItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return GetItemHelper(MakeKey(hashKey, rangeKey), config);
            }
        }

        /// <inheritdoc/>
        public Document GetItem(IDictionary<string, DynamoDBEntry> key, GetItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return GetItemHelper(MakeKey(key), config);
            }

        }

        #endregion


        #region UpdateItem

        /// <inheritdoc/>
        public Document UpdateItem(Document doc, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return UpdateHelper(doc, MakeKey(doc), config, null);
            }
        }

        /// <inheritdoc/>
        public bool TryUpdateItem(Document doc, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryUpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    UpdateHelper(doc, MakeKey(doc), config, null);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        /// <inheritdoc/>
        public Document UpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return UpdateHelper(doc, MakeKey(key), config, null);
            }
        }

        /// <inheritdoc/>
        public bool TryUpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryUpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    UpdateHelper(doc, MakeKey(key), config, null);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        /// <inheritdoc/>
        public Document UpdateItem(Document doc, Primitive hashKey, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return UpdateHelper(doc, MakeKey(hashKey, null), config, null);
            }
        }

        /// <inheritdoc/>
        public bool TryUpdateItem(Document doc, Primitive hashKey, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryUpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    UpdateHelper(doc, MakeKey(hashKey, null), config, null);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        /// <inheritdoc/>
        public Document UpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return UpdateHelper(doc, MakeKey(hashKey, rangeKey), config, null);
            }
        }

        /// <inheritdoc/>
        public bool TryUpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryUpdateItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    UpdateHelper(doc, MakeKey(hashKey, rangeKey), config, null);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        #endregion


        #region DeleteItem

        /// <inheritdoc/>
        public Document DeleteItem(Document document, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return DeleteHelper(MakeKey(document), config);
            }
        }

        /// <inheritdoc/>
        public bool TryDeleteItem(Document document, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryDeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    DeleteItem(document, config);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        /// <inheritdoc/>
        public Document DeleteItem(Primitive hashKey, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return DeleteHelper(MakeKey(hashKey, null), config);
            }
        }

        /// <inheritdoc/>
        public bool TryDeleteItem(Primitive hashKey, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryDeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    DeleteItem(hashKey, config);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        /// <inheritdoc/>
        public Document DeleteItem(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return DeleteHelper(MakeKey(hashKey, rangeKey), config);
            }
        }

        /// <inheritdoc/>
        public bool TryDeleteItem(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryDeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    DeleteItem(hashKey, rangeKey, config);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        /// <inheritdoc/>
        public Document DeleteItem(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return DeleteHelper(MakeKey(key), config);
            }
        }

        /// <inheritdoc/>
        public bool TryDeleteItem(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config = null)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryDeleteItem));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                try
                {
                    DeleteHelper(MakeKey(key), config);
                    return true;
                }
                catch (ConditionalCheckFailedException)
                {
                    return false;
                }
            }
        }

        #endregion

    }
}
