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

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface ISearchVectors
    {
        /// <summary>
        /// Searches the vector index and returns the top K matching documents along with their scores.
        /// </summary>
        /// <returns>List of documents with their corresponding scores.</returns>
        List<DocumentSearchVectorsItem> Get();

    }

    public partial class SearchVectors : ISearchVectors
    {
        /// <inheritdoc/>
        public List<DocumentSearchVectorsItem> Get()
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(SearchVectors), nameof(Get));
            using (DynamoDBTelemetry.CreateSpan(TracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return GetHelper();
            }
        }
    }
}
