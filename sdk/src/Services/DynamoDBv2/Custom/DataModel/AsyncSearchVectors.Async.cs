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
    /// <summary>
    /// Interface for asynchronously retrieving search vector items from a search result.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial interface IAsyncSearchVectors<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>
    {
        /// <summary>
        /// Executes the vector search request and returns the matching items for the configured query.
        /// This call is not paginated; each invocation issues a new search and returns up to the configured TopK matches.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A list of search vector items.</returns>
        Task<List<SearchVectorsItem<T>>> GetAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class AsyncSearchVectors<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T> : IAsyncSearchVectors<T>
    {
        /// <inheritdoc/>
        public virtual async Task<List<SearchVectorsItem<T>>> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(AsyncSearchVectors<T>), nameof(GetAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                var documents = await _documentSearchVectors.GetHelperAsync(cancellationToken).ConfigureAwait(false);

                List<SearchVectorsItem<T>> items = _sourceContext.DocumentSearchVectorsItem<T>(documents, this._config).ToList();
                return items;
            }
        }

    }
}
