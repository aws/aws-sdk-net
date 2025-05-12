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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Paginators for the SecretsManager service
    ///</summary>
    public interface ISecretsManagerPaginatorFactory
    {

        /// <summary>
        /// Paginator for BatchGetSecretValue operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IBatchGetSecretValuePaginator BatchGetSecretValue(BatchGetSecretValueRequest request);

        /// <summary>
        /// Paginator for ListSecrets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecretsPaginator ListSecrets(ListSecretsRequest request);

        /// <summary>
        /// Paginator for ListSecretVersionIds operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSecretVersionIdsPaginator ListSecretVersionIds(ListSecretVersionIdsRequest request);
    }
}