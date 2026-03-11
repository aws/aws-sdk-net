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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Paginators for the DirectoryService service
    ///</summary>
    public class DirectoryServicePaginatorFactory : IDirectoryServicePaginatorFactory
    {
        private readonly IAmazonDirectoryService client;

        internal DirectoryServicePaginatorFactory(IAmazonDirectoryService client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeClientAuthenticationSettings operation
        ///</summary>
        public IDescribeClientAuthenticationSettingsPaginator DescribeClientAuthenticationSettings(DescribeClientAuthenticationSettingsRequest request) 
        {
            return new DescribeClientAuthenticationSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDirectories operation
        ///</summary>
        public IDescribeDirectoriesPaginator DescribeDirectories(DescribeDirectoriesRequest request) 
        {
            return new DescribeDirectoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDomainControllers operation
        ///</summary>
        public IDescribeDomainControllersPaginator DescribeDomainControllers(DescribeDomainControllersRequest request) 
        {
            return new DescribeDomainControllersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLDAPSSettings operation
        ///</summary>
        public IDescribeLDAPSSettingsPaginator DescribeLDAPSSettings(DescribeLDAPSSettingsRequest request) 
        {
            return new DescribeLDAPSSettingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRegions operation
        ///</summary>
        public IDescribeRegionsPaginator DescribeRegions(DescribeRegionsRequest request) 
        {
            return new DescribeRegionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSharedDirectories operation
        ///</summary>
        public IDescribeSharedDirectoriesPaginator DescribeSharedDirectories(DescribeSharedDirectoriesRequest request) 
        {
            return new DescribeSharedDirectoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        public IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request) 
        {
            return new DescribeSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrusts operation
        ///</summary>
        public IDescribeTrustsPaginator DescribeTrusts(DescribeTrustsRequest request) 
        {
            return new DescribeTrustsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeUpdateDirectory operation
        ///</summary>
        public IDescribeUpdateDirectoryPaginator DescribeUpdateDirectory(DescribeUpdateDirectoryRequest request) 
        {
            return new DescribeUpdateDirectoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListADAssessments operation
        ///</summary>
        public IListADAssessmentsPaginator ListADAssessments(ListADAssessmentsRequest request) 
        {
            return new ListADAssessmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCertificates operation
        ///</summary>
        public IListCertificatesPaginator ListCertificates(ListCertificatesRequest request) 
        {
            return new ListCertificatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIpRoutes operation
        ///</summary>
        public IListIpRoutesPaginator ListIpRoutes(ListIpRoutesRequest request) 
        {
            return new ListIpRoutesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLogSubscriptions operation
        ///</summary>
        public IListLogSubscriptionsPaginator ListLogSubscriptions(ListLogSubscriptionsRequest request) 
        {
            return new ListLogSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSchemaExtensions operation
        ///</summary>
        public IListSchemaExtensionsPaginator ListSchemaExtensions(ListSchemaExtensionsRequest request) 
        {
            return new ListSchemaExtensionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        public IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request) 
        {
            return new ListTagsForResourcePaginator(this.client, request);
        }
    }
}