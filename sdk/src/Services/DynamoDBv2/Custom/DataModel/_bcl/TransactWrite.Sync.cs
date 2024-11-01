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

namespace Amazon.DynamoDBv2.DataModel
{
    public partial interface ITransactWrite
    {
        /// <summary>
        /// Executes a server call to write/delete/version-check the items requested in a transaction.
        /// </summary>
        void Execute();
    }

    public abstract partial class TransactWrite : ITransactWrite
    {
        /// <inheritdoc/>
        public abstract void Execute();
    }

    public partial class TransactWrite<T> : TransactWrite, ITransactWrite<T>
    {
        /// <inheritdoc/>
        public override void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(TransactWrite), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }
    }

    public partial interface IMultiTableTransactWrite
    {
        /// <summary>
        /// Executes a multi-table transaction request against all configured TransactWrite objects.
        /// </summary>
        void Execute();
    }

    public partial class MultiTableTransactWrite : IMultiTableTransactWrite
    {
        /// <inheritdoc/>
        public void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableTransactWrite), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }
    }
}
