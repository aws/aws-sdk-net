﻿/*
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
    /// <summary>
    /// Represents a non-generic object for writing/deleting/version-checking multiple items
    /// in a single DynamoDB table in a transaction.
    /// </summary>
    public abstract partial class TransactWrite
    {
        #region Public methods

        /// <summary>
        /// Executes a server call to write/delete/version-check the items requested in a transaction.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(TransactWrite), nameof(ExecuteAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion
    }

    /// <summary>
    /// Class for writing/deleting/version-checking multiple items in multiple DynamoDB tables,
    /// using multiple strongly-typed TransactWrite objects.
    /// </summary>
    public partial class MultiTableTransactWrite
    {
        #region Public methods

        /// <summary>
        /// Executes a multi-table transaction request against all configured TransactWrite objects.
        /// </summary>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        ///
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableTransactWrite), nameof(ExecuteAsync));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                await ExecuteHelperAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion
    }
}
