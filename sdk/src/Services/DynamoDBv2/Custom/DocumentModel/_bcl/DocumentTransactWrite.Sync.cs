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

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface IDocumentTransactWrite
    {
        /// <summary>
        /// Executes a server call to condition-check/put/update/delete the items specified in a transaction.
        /// </summary>
        void Execute();
    }

    public partial class DocumentTransactWrite : IDocumentTransactWrite
    {
        /// <inheritdoc/>
        public void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(DocumentTransactWrite), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }
    }

    public partial interface IMultiTableDocumentTransactWrite
    {
        /// <summary>
        /// Executes a multi-table transactional condition-check/put/update/delete against all configured DocumentTransactWrite objects.
        /// </summary>
        void Execute();
    }

    /// <summary>
    /// Class for condition checking, putting, updating and/or deleting
    /// multiple items in multiple DynamoDB tables in a transaction.
    /// </summary>
    public partial class MultiTableDocumentTransactWrite : IMultiTableDocumentTransactWrite
    {
        /// <inheritdoc/>
        public void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableDocumentTransactWrite), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }
    }
}
