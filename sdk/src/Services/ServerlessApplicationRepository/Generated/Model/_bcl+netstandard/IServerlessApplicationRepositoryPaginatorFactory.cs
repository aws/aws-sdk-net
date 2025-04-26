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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Paginators for the ServerlessApplicationRepository service
    ///</summary>
    public interface IServerlessApplicationRepositoryPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListApplicationDependencies operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationDependenciesPaginator ListApplicationDependencies(ListApplicationDependenciesRequest request);

        /// <summary>
        /// Paginator for ListApplications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationsPaginator ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Paginator for ListApplicationVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextToken" }
        )]
        IListApplicationVersionsPaginator ListApplicationVersions(ListApplicationVersionsRequest request);
    }
}