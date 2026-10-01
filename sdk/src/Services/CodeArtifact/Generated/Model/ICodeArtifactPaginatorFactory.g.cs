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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Paginators for the CodeArtifact service
    /// </summary>
    public interface ICodeArtifactPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAllowedRepositoriesForGroup operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAllowedRepositoriesForGroupPaginator ListAllowedRepositoriesForGroup(ListAllowedRepositoriesForGroupRequest request);

        /// <summary>
        /// Paginator for ListAssociatedPackages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssociatedPackagesPaginator ListAssociatedPackages(ListAssociatedPackagesRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListPackageGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPackageGroupsPaginator ListPackageGroups(ListPackageGroupsRequest request);

        /// <summary>
        /// Paginator for ListPackageVersionAssets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPackageVersionAssetsPaginator ListPackageVersionAssets(ListPackageVersionAssetsRequest request);

        /// <summary>
        /// Paginator for ListPackageVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPackageVersionsPaginator ListPackageVersions(ListPackageVersionsRequest request);

        /// <summary>
        /// Paginator for ListPackages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPackagesPaginator ListPackages(ListPackagesRequest request);

        /// <summary>
        /// Paginator for ListRepositories operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListRepositoriesInDomain operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRepositoriesInDomainPaginator ListRepositoriesInDomain(ListRepositoriesInDomainRequest request);

        /// <summary>
        /// Paginator for ListSubPackageGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSubPackageGroupsPaginator ListSubPackageGroups(ListSubPackageGroupsRequest request);
    }
}
