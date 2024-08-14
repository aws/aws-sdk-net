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

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial interface IDocumentBatchGet
    {
        /// <summary>
        /// Executes a server call to batch-get the documents requested.
        /// Populates Results with the retrieved items.
        /// </summary>
        void Execute();
    }

    public partial class DocumentBatchGet : IDocumentBatchGet
    {
        /// <inheritdoc/>
        public void Execute()
        {
            ExecuteHelper();
        }
    }

    public partial interface IMultiTableDocumentBatchGet
    {
        /// <summary>
        /// Executes a multi-table batch request against all configured batches.
        /// Results are stored in the respective DocumentBatchGet objects.
        /// </summary>
        void Execute();
    }

    public partial class MultiTableDocumentBatchGet
    {
        /// <inheritdoc/>
        public void Execute()
        {
            ExecuteHelper();
        }
    }
}
