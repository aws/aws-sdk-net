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
    public partial interface IBatchGet
    {
        /// <summary>
        /// Executes a server call to batch-get the items requested.
        /// </summary>
        void Execute();
    }

    public abstract partial class BatchGet
    {
        /// <inheritdoc/>
        public abstract void Execute();
    }

    public partial class BatchGet<T> : BatchGet, IBatchGet<T>
    {
        /// <inheritdoc/>
        public override void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(BatchGet), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }
    }

   public partial interface IMultiTableBatchGet
    {
        /// <summary>
        /// Executes a multi-table batch request against all configured batches.
        /// Results are stored in the respective BatchGet objects.
        /// </summary>
        void Execute();
    }

    public partial class MultiTableBatchGet : IMultiTableBatchGet
    {
        /// <inheritdoc/>/>
        public void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableBatchGet), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }
    }
}
