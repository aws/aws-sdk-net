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
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial interface ITransactGet
    {
        /// <summary>
        /// Executes a server call to get the items requested in a transaction.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public abstract partial class TransactGet : ITransactGet
    {
        /// <inheritdoc/>
        public abstract Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class  TransactGet<T> : TransactGet, ITransactGet<T>
    {
        /// <inheritdoc/>
        public override async Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(TransactGet), nameof(ExecuteAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }

    public partial interface IMultiTableTransactGet
    {
        /// <summary>
        /// Executes a multi-table transaction request against all configured TransactGet objects.
        /// Results are stored in the respective TransactGet objects.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        ///
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
    }

    public partial class MultiTableTransactGet : IMultiTableTransactGet
    {
        /// <inheritdoc/>
        public async Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableTransactGet), nameof(ExecuteAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
