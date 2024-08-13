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

/*
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Paginators for the SecretsManager service
    ///</summary>
    public class SecretsManagerPaginatorFactory : ISecretsManagerPaginatorFactory
    {
        private readonly IAmazonSecretsManager client;

        internal SecretsManagerPaginatorFactory(IAmazonSecretsManager client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for BatchGetSecretValue operation
        ///</summary>
        public IBatchGetSecretValuePaginator BatchGetSecretValue(BatchGetSecretValueRequest request) 
        {
            return new BatchGetSecretValuePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecrets operation
        ///</summary>
        public IListSecretsPaginator ListSecrets(ListSecretsRequest request) 
        {
            return new ListSecretsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSecretVersionIds operation
        ///</summary>
        public IListSecretVersionIdsPaginator ListSecretVersionIds(ListSecretVersionIdsRequest request) 
        {
            return new ListSecretVersionIdsPaginator(this.client, request);
        }
    }
}