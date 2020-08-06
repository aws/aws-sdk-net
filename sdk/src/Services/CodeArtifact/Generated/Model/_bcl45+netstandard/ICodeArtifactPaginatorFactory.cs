#if !NETSTANDARD13
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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Paginators for the CodeArtifact service
    ///</summary>
    public interface ICodeArtifactPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListPackages operation
        ///</summary>
        IListPackagesPaginator ListPackages(ListPackagesRequest request);

        /// <summary>
        /// Paginator for ListPackageVersionAssets operation
        ///</summary>
        IListPackageVersionAssetsPaginator ListPackageVersionAssets(ListPackageVersionAssetsRequest request);

        /// <summary>
        /// Paginator for ListPackageVersions operation
        ///</summary>
        IListPackageVersionsPaginator ListPackageVersions(ListPackageVersionsRequest request);

        /// <summary>
        /// Paginator for ListRepositories operation
        ///</summary>
        IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListRepositoriesInDomain operation
        ///</summary>
        IListRepositoriesInDomainPaginator ListRepositoriesInDomain(ListRepositoriesInDomainRequest request);
    }
}
#endif