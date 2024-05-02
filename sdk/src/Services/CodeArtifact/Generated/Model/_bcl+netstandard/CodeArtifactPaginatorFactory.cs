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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Paginators for the CodeArtifact service
    ///</summary>
    public class CodeArtifactPaginatorFactory : ICodeArtifactPaginatorFactory
    {
        private readonly IAmazonCodeArtifact client;

        internal CodeArtifactPaginatorFactory(IAmazonCodeArtifact client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAllowedRepositoriesForGroup operation
        ///</summary>
        public IListAllowedRepositoriesForGroupPaginator ListAllowedRepositoriesForGroup(ListAllowedRepositoriesForGroupRequest request) 
        {
            return new ListAllowedRepositoriesForGroupPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedPackages operation
        ///</summary>
        public IListAssociatedPackagesPaginator ListAssociatedPackages(ListAssociatedPackagesRequest request) 
        {
            return new ListAssociatedPackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackageGroups operation
        ///</summary>
        public IListPackageGroupsPaginator ListPackageGroups(ListPackageGroupsRequest request) 
        {
            return new ListPackageGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackages operation
        ///</summary>
        public IListPackagesPaginator ListPackages(ListPackagesRequest request) 
        {
            return new ListPackagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackageVersionAssets operation
        ///</summary>
        public IListPackageVersionAssetsPaginator ListPackageVersionAssets(ListPackageVersionAssetsRequest request) 
        {
            return new ListPackageVersionAssetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPackageVersions operation
        ///</summary>
        public IListPackageVersionsPaginator ListPackageVersions(ListPackageVersionsRequest request) 
        {
            return new ListPackageVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositories operation
        ///</summary>
        public IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request) 
        {
            return new ListRepositoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositoriesInDomain operation
        ///</summary>
        public IListRepositoriesInDomainPaginator ListRepositoriesInDomain(ListRepositoriesInDomainRequest request) 
        {
            return new ListRepositoriesInDomainPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSubPackageGroups operation
        ///</summary>
        public IListSubPackageGroupsPaginator ListSubPackageGroups(ListSubPackageGroupsRequest request) 
        {
            return new ListSubPackageGroupsPaginator(this.client, request);
        }
    }
}