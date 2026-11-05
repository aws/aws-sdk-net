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

using System.Threading.Tasks;
using System.Threading;
using Amazon.Runtime.Telemetry.Tracing;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial interface IBatchWrite
    {
        /// <summary>
        /// Executes a server call to batch-write/delete the items requested.
        ///
        /// If more than 25 put/delete operations are specified, calls of up to 25
        /// put/delete items will be made until all items are processed.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// 
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public abstract partial class BatchWrite : IBatchWrite
    {
        /// <inheritdoc/>
        public abstract Task ExecuteAsync(CancellationToken cancellationToken);
    }

    public partial class  BatchWrite<T> : BatchWrite, IBatchWrite<T>
    {
        /// <inheritdoc/>
        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(BatchWrite), nameof(ExecuteAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }

    public partial interface IMultiTableBatchWrite
    {
        /// <summary>
        /// Executes a multi-table batch request against all configured batches.
        ///
        /// If more than 25 put/delete operations are specified, calls of up to 25
        /// put/delete items will be made until all items are processed.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// 
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class MultiTableBatchWrite : IMultiTableBatchWrite
    {
        /// <inheritdoc/>
        public async Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableBatchWrite), nameof(ExecuteAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
