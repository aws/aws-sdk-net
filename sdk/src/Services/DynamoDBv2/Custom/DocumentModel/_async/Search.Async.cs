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
    public partial interface ISearch
    {
        /// <summary>
        /// Initiates the asynchronous execution of the GetNextSet operation.
        ///
        /// If there are more items in the Scan/Query, PaginationToken will be
        /// set and can be consumed in a new Scan/Query operation to resume
        /// retrieving items from this point.
        /// <seealso cref="Search.GetNextSet"/>
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<List<Document>> GetNextSetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetRemaining operation.
        /// <seealso cref="Search.GetRemaining"/>
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<List<Document>> GetRemainingAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class Search : ISearch
    {
        /// <inheritdoc/>
        public async Task<List<Document>> GetNextSetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Search), nameof(GetNextSetAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetNextSetHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<List<Document>> GetRemainingAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Search), nameof(GetRemainingAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return await GetRemainingHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
