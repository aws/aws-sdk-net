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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Paginators for the DirectoryService service
    ///</summary>
    public interface IDirectoryServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeClientAuthenticationSettings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClientAuthenticationSettingsPaginator DescribeClientAuthenticationSettings(DescribeClientAuthenticationSettingsRequest request);

        /// <summary>
        /// Paginator for DescribeDirectories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDirectoriesPaginator DescribeDirectories(DescribeDirectoriesRequest request);

        /// <summary>
        /// Paginator for DescribeDomainControllers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDomainControllersPaginator DescribeDomainControllers(DescribeDomainControllersRequest request);

        /// <summary>
        /// Paginator for DescribeLDAPSSettings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLDAPSSettingsPaginator DescribeLDAPSSettings(DescribeLDAPSSettingsRequest request);

        /// <summary>
        /// Paginator for DescribeRegions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegionsPaginator DescribeRegions(DescribeRegionsRequest request);

        /// <summary>
        /// Paginator for DescribeSharedDirectories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSharedDirectoriesPaginator DescribeSharedDirectories(DescribeSharedDirectoriesRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeTrusts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTrustsPaginator DescribeTrusts(DescribeTrustsRequest request);

        /// <summary>
        /// Paginator for DescribeUpdateDirectory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeUpdateDirectoryPaginator DescribeUpdateDirectory(DescribeUpdateDirectoryRequest request);

        /// <summary>
        /// Paginator for ListADAssessments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListADAssessmentsPaginator ListADAssessments(ListADAssessmentsRequest request);

        /// <summary>
        /// Paginator for ListCertificates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListCertificatesPaginator ListCertificates(ListCertificatesRequest request);

        /// <summary>
        /// Paginator for ListIpRoutes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListIpRoutesPaginator ListIpRoutes(ListIpRoutesRequest request);

        /// <summary>
        /// Paginator for ListLogSubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListLogSubscriptionsPaginator ListLogSubscriptions(ListLogSubscriptionsRequest request);

        /// <summary>
        /// Paginator for ListSchemaExtensions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListSchemaExtensionsPaginator ListSchemaExtensions(ListSchemaExtensionsRequest request);

        /// <summary>
        /// Paginator for ListTagsForResource operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "Limit",
            OutputToken = new[] { "NextToken" }
        )]
        IListTagsForResourcePaginator ListTagsForResource(ListTagsForResourceRequest request);
    }
}