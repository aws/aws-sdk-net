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
#pragma warning disable 1574

using System;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Util;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Telemetry.Tracing;

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface ITable
    {
        #region PutItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.PutItem"/>
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> PutItemAsync(Document doc, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.PutItem"/>
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> PutItemAsync(Document doc, PutItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        #endregion

        #region GetItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> GetItemAsync(Primitive hashKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> GetItemAsync(Primitive hashKey, GetItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> GetItemAsync(Primitive hashKey, Primitive rangeKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> GetItemAsync(Primitive hashKey, Primitive rangeKey, GetItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// </summary>
        /// <param name="key">Ley of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> GetItemAsync(IDictionary<string, DynamoDBEntry> key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// </summary>
        /// <param name="key">Ley of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> GetItemAsync(IDictionary<string, DynamoDBEntry> key, GetItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        #endregion

        #region UpdateItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, IDictionary<string, DynamoDBEntry> key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, Primitive rangeKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));


        #endregion

        #region DeleteItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(Document document, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(Document document, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(Primitive hashKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(Primitive hashKey, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(Primitive hashKey, Primitive rangeKey, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(IDictionary<string, DynamoDBEntry> key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<Document> DeleteItemAsync(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
    }

    public partial class Table : ITable
    {
        #region PutItemAsync

        /// <inheritdoc/>
        public async Task<Document> PutItemAsync(Document doc, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(PutItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await PutItemHelperAsync(doc, null, cancellationToken).ConfigureAwait(false);
            }
        }


        /// <inheritdoc/>
        public async Task<Document> PutItemAsync(Document doc, PutItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(PutItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await PutItemHelperAsync(doc, config, cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region GetItemAsync

        /// <inheritdoc/>
        public async Task<Document> GetItemAsync(Primitive hashKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetItemHelperAsync(MakeKey(hashKey, null), null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> GetItemAsync(Primitive hashKey, GetItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetItemHelperAsync(MakeKey(hashKey, null), config, cancellationToken).ConfigureAwait(false);
            }
        }


        /// <inheritdoc/>
        public async Task<Document> GetItemAsync(Primitive hashKey, Primitive rangeKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetItemHelperAsync(MakeKey(hashKey, rangeKey), null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> GetItemAsync(Primitive hashKey, Primitive rangeKey, GetItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetItemHelperAsync(MakeKey(hashKey, rangeKey), config, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> GetItemAsync(IDictionary<string, DynamoDBEntry> key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetItemHelperAsync(MakeKey(key), null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> GetItemAsync(IDictionary<string, DynamoDBEntry> key, GetItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(GetItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetItemHelperAsync(MakeKey(key), config, cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region UpdateItemAsync

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, null, null, null, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, null, null, config, null,cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, IDictionary<string, DynamoDBEntry> key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, MakeKey(key), null, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, MakeKey(key), config, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, hashKey, null, null, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, hashKey, null, config, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, Primitive rangeKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, hashKey, rangeKey, null, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> UpdateItemAsync(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(UpdateItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await UpdateHelperAsync(doc, hashKey, rangeKey, config, null, cancellationToken).ConfigureAwait(false);
            }
        }


        #endregion

        #region DeleteItemAsync

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(Document document, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(document), null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(Document document, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(document), config, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(Primitive hashKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(hashKey, null), null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(Primitive hashKey, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(hashKey, null), config, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(Primitive hashKey, Primitive rangeKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(hashKey, rangeKey), null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(hashKey, rangeKey), config, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(IDictionary<string, DynamoDBEntry> key, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(key), null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Document> DeleteItemAsync(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config, CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(DeleteItemAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await DeleteHelperAsync(MakeKey(key), config, cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

    }
}
