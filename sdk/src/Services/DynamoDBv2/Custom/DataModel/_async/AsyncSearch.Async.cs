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

using Amazon.Runtime.Telemetry.Tracing;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial interface IAsyncSearch<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>
    {
        /// <summary>
        /// Initiates the asynchronous execution to get the next set of results from DynamoDB.
        /// 
        /// If there are more items in the Scan/Query, PaginationToken will be
        /// set and can be consumed in a new Scan/Query operation to resume
        /// retrieving items from this point.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>
        /// A Task that can be used to poll or wait for results, or both.
        /// Results will include the next set of result items from DynamoDB.
        /// </returns>
        Task<List<T>> GetNextSetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution to get all the remaining results from DynamoDB.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>
        /// A Task that can be used to poll or wait for results, or both.
        /// Results will include the remaining result items from DynamoDB.
        /// </returns>
        Task<List<T>> GetRemainingAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class AsyncSearch<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : IAsyncSearch<T>

    {
        /// <inheritdoc/>
        public virtual async Task<List<T>> GetNextSetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(AsyncSearch<T>), nameof(GetNextSetAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                var documents = await _documentSearch.GetNextSetHelperAsync(cancellationToken).ConfigureAwait(false);
                List<T> items = _sourceContext.FromDocumentsHelper<T>(documents, this._config).ToList();
                return items;
            }
        }

        /// <inheritdoc/>
        public virtual async Task<List<T>> GetRemainingAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(AsyncSearch<T>), nameof(GetRemainingAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                var documents = await _documentSearch.GetRemainingHelperAsync(cancellationToken).ConfigureAwait(false);
                List<T> items = _sourceContext.FromDocumentsHelper<T>(documents, this._config).ToList();
                return items;
            }
        }
    }
}
