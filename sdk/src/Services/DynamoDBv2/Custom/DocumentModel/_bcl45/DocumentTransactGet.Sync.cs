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
    /// <summary>
    /// Class for retrieving multiple Documents from a single DynamoDB table in a transaction.
    /// </summary>
    public partial class DocumentTransactGet
    {
        #region Public methods

        /// <summary>
        /// Executes a server call to get the documents requested in a transaction.
        /// Populates Results with the retrieved items.
        /// </summary>
        public void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(DocumentTransactGet), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }

        #endregion
    }

    /// <summary>
    /// Class for retrieving multiple Documents from multiple DynamoDB tables in a transaction.
    /// </summary>
    public partial class MultiTableDocumentTransactGet
    {
        #region Public methods

        /// <summary>
        /// Executes a multi-table transaction request against all configured DocumentTransactGet objects.
        /// Results are stored in the respective DocumentTransactGet objects.
        /// </summary>
        public void Execute()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(MultiTableDocumentTransactGet), nameof(Execute));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                ExecuteHelper();
            }
        }

        #endregion
    }
}
