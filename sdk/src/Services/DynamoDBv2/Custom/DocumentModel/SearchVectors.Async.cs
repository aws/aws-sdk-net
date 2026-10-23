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

using Amazon.Runtime.Telemetry.Tracing;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface ISearchVectors
    {
        /// <summary>
        /// Asynchronously retrieves the most similar vectors from the source table based on the provided vector and similarity metric.
        /// </summary>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation. 
        /// The task result contains a list of the top K most similar vectors.</returns>
        Task<List<DocumentSearchVectorsItem>> GetAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class SearchVectors : ISearchVectors
    {
        /// <inheritdoc/>
        public async Task<List<DocumentSearchVectorsItem>> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(SearchVectors), nameof(GetAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
