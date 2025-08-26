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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Paginators for the EC2 service
    ///</summary>
    public interface IEC2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAddressesAttribute operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAddressesAttributePaginator DescribeAddressesAttribute(DescribeAddressesAttributeRequest request);

        /// <summary>
        /// Paginator for DescribeAddressTransfers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAddressTransfersPaginator DescribeAddressTransfers(DescribeAddressTransfersRequest request);

        /// <summary>
        /// Paginator for DescribeAwsNetworkPerformanceMetricSubscriptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAwsNetworkPerformanceMetricSubscriptionsPaginator DescribeAwsNetworkPerformanceMetricSubscriptions(DescribeAwsNetworkPerformanceMetricSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeByoipCidrs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeByoipCidrsPaginator DescribeByoipCidrs(DescribeByoipCidrsRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityBlockExtensionHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityBlockExtensionHistoryPaginator DescribeCapacityBlockExtensionHistory(DescribeCapacityBlockExtensionHistoryRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityBlockExtensionOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityBlockExtensionOfferingsPaginator DescribeCapacityBlockExtensionOfferings(DescribeCapacityBlockExtensionOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityBlockOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityBlockOfferingsPaginator DescribeCapacityBlockOfferings(DescribeCapacityBlockOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityBlocks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityBlocksPaginator DescribeCapacityBlocks(DescribeCapacityBlocksRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityBlockStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityBlockStatusPaginator DescribeCapacityBlockStatus(DescribeCapacityBlockStatusRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityReservationBillingRequests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityReservationBillingRequestsPaginator DescribeCapacityReservationBillingRequests(DescribeCapacityReservationBillingRequestsRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityReservationFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityReservationFleetsPaginator DescribeCapacityReservationFleets(DescribeCapacityReservationFleetsRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityReservations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCapacityReservationsPaginator DescribeCapacityReservations(DescribeCapacityReservationsRequest request);

        /// <summary>
        /// Paginator for DescribeCarrierGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCarrierGatewaysPaginator DescribeCarrierGateways(DescribeCarrierGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeClassicLinkInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClassicLinkInstancesPaginator DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnAuthorizationRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClientVpnAuthorizationRulesPaginator DescribeClientVpnAuthorizationRules(DescribeClientVpnAuthorizationRulesRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClientVpnConnectionsPaginator DescribeClientVpnConnections(DescribeClientVpnConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClientVpnEndpointsPaginator DescribeClientVpnEndpoints(DescribeClientVpnEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnRoutes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClientVpnRoutesPaginator DescribeClientVpnRoutes(DescribeClientVpnRoutesRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnTargetNetworks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeClientVpnTargetNetworksPaginator DescribeClientVpnTargetNetworks(DescribeClientVpnTargetNetworksRequest request);

        /// <summary>
        /// Paginator for DescribeCoipPools operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeCoipPoolsPaginator DescribeCoipPools(DescribeCoipPoolsRequest request);

        /// <summary>
        /// Paginator for DescribeDhcpOptions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeDhcpOptionsPaginator DescribeDhcpOptions(DescribeDhcpOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeEgressOnlyInternetGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeEgressOnlyInternetGatewaysPaginator DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeExportImageTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeExportImageTasksPaginator DescribeExportImageTasks(DescribeExportImageTasksRequest request);

        /// <summary>
        /// Paginator for DescribeFastLaunchImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFastLaunchImagesPaginator DescribeFastLaunchImages(DescribeFastLaunchImagesRequest request);

        /// <summary>
        /// Paginator for DescribeFastSnapshotRestores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFastSnapshotRestoresPaginator DescribeFastSnapshotRestores(DescribeFastSnapshotRestoresRequest request);

        /// <summary>
        /// Paginator for DescribeFleets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFleetsPaginator DescribeFleets(DescribeFleetsRequest request);

        /// <summary>
        /// Paginator for DescribeFlowLogs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFlowLogsPaginator DescribeFlowLogs(DescribeFlowLogsRequest request);

        /// <summary>
        /// Paginator for DescribeFpgaImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeFpgaImagesPaginator DescribeFpgaImages(DescribeFpgaImagesRequest request);

        /// <summary>
        /// Paginator for DescribeHostReservationOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeHostReservationOfferingsPaginator DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeHostReservations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeHostReservationsPaginator DescribeHostReservations(DescribeHostReservationsRequest request);

        /// <summary>
        /// Paginator for DescribeHosts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeHostsPaginator DescribeHosts(DescribeHostsRequest request);

        /// <summary>
        /// Paginator for DescribeIamInstanceProfileAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeIamInstanceProfileAssociationsPaginator DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeImageReferences operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImageReferencesPaginator DescribeImageReferences(DescribeImageReferencesRequest request);

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Paginator for DescribeImageUsageReportEntries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImageUsageReportEntriesPaginator DescribeImageUsageReportEntries(DescribeImageUsageReportEntriesRequest request);

        /// <summary>
        /// Paginator for DescribeImageUsageReports operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImageUsageReportsPaginator DescribeImageUsageReports(DescribeImageUsageReportsRequest request);

        /// <summary>
        /// Paginator for DescribeImportImageTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImportImageTasksPaginator DescribeImportImageTasks(DescribeImportImageTasksRequest request);

        /// <summary>
        /// Paginator for DescribeImportSnapshotTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeImportSnapshotTasksPaginator DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceConnectEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceConnectEndpointsPaginator DescribeInstanceConnectEndpoints(DescribeInstanceConnectEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceCreditSpecifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceCreditSpecificationsPaginator DescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceEventWindows operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceEventWindowsPaginator DescribeInstanceEventWindows(DescribeInstanceEventWindowsRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceImageMetadata operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceImageMetadataPaginator DescribeInstanceImageMetadata(DescribeInstanceImageMetadataRequest request);

        /// <summary>
        /// Paginator for DescribeInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstancesPaginator DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceStatusPaginator DescribeInstanceStatus(DescribeInstanceStatusRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceTopology operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceTopologyPaginator DescribeInstanceTopology(DescribeInstanceTopologyRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceTypeOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceTypeOfferingsPaginator DescribeInstanceTypeOfferings(DescribeInstanceTypeOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInstanceTypesPaginator DescribeInstanceTypes(DescribeInstanceTypesRequest request);

        /// <summary>
        /// Paginator for DescribeInternetGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeInternetGatewaysPaginator DescribeInternetGateways(DescribeInternetGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeIpamPools operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeIpamPoolsPaginator DescribeIpamPools(DescribeIpamPoolsRequest request);

        /// <summary>
        /// Paginator for DescribeIpamResourceDiscoveries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeIpamResourceDiscoveriesPaginator DescribeIpamResourceDiscoveries(DescribeIpamResourceDiscoveriesRequest request);

        /// <summary>
        /// Paginator for DescribeIpamResourceDiscoveryAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeIpamResourceDiscoveryAssociationsPaginator DescribeIpamResourceDiscoveryAssociations(DescribeIpamResourceDiscoveryAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeIpams operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeIpamsPaginator DescribeIpams(DescribeIpamsRequest request);

        /// <summary>
        /// Paginator for DescribeIpamScopes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeIpamScopesPaginator DescribeIpamScopes(DescribeIpamScopesRequest request);

        /// <summary>
        /// Paginator for DescribeIpv6Pools operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeIpv6PoolsPaginator DescribeIpv6Pools(DescribeIpv6PoolsRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLaunchTemplatesPaginator DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchTemplateVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLaunchTemplateVersionsPaginator DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTables operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLocalGatewayRouteTablesPaginator DescribeLocalGatewayRouteTables(DescribeLocalGatewayRouteTablesRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsPaginator DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations(DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTableVpcAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLocalGatewayRouteTableVpcAssociationsPaginator DescribeLocalGatewayRouteTableVpcAssociations(DescribeLocalGatewayRouteTableVpcAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLocalGatewaysPaginator DescribeLocalGateways(DescribeLocalGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayVirtualInterfaceGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLocalGatewayVirtualInterfaceGroupsPaginator DescribeLocalGatewayVirtualInterfaceGroups(DescribeLocalGatewayVirtualInterfaceGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayVirtualInterfaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeLocalGatewayVirtualInterfacesPaginator DescribeLocalGatewayVirtualInterfaces(DescribeLocalGatewayVirtualInterfacesRequest request);

        /// <summary>
        /// Paginator for DescribeMacHosts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMacHostsPaginator DescribeMacHosts(DescribeMacHostsRequest request);

        /// <summary>
        /// Paginator for DescribeMacModificationTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMacModificationTasksPaginator DescribeMacModificationTasks(DescribeMacModificationTasksRequest request);

        /// <summary>
        /// Paginator for DescribeManagedPrefixLists operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeManagedPrefixListsPaginator DescribeManagedPrefixLists(DescribeManagedPrefixListsRequest request);

        /// <summary>
        /// Paginator for DescribeMovingAddresses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeMovingAddressesPaginator DescribeMovingAddresses(DescribeMovingAddressesRequest request);

        /// <summary>
        /// Paginator for DescribeNatGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNatGatewaysPaginator DescribeNatGateways(DescribeNatGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkAcls operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNetworkAclsPaginator DescribeNetworkAcls(DescribeNetworkAclsRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAccessScopeAnalyses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNetworkInsightsAccessScopeAnalysesPaginator DescribeNetworkInsightsAccessScopeAnalyses(DescribeNetworkInsightsAccessScopeAnalysesRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAccessScopes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNetworkInsightsAccessScopesPaginator DescribeNetworkInsightsAccessScopes(DescribeNetworkInsightsAccessScopesRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAnalyses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNetworkInsightsAnalysesPaginator DescribeNetworkInsightsAnalyses(DescribeNetworkInsightsAnalysesRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsPaths operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNetworkInsightsPathsPaginator DescribeNetworkInsightsPaths(DescribeNetworkInsightsPathsRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInterfacePermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNetworkInterfacePermissionsPaginator DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInterfaces operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNetworkInterfacesPaginator DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request);

        /// <summary>
        /// Paginator for DescribePrefixLists operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePrefixListsPaginator DescribePrefixLists(DescribePrefixListsRequest request);

        /// <summary>
        /// Paginator for DescribePrincipalIdFormat operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePrincipalIdFormatPaginator DescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request);

        /// <summary>
        /// Paginator for DescribePublicIpv4Pools operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePublicIpv4PoolsPaginator DescribePublicIpv4Pools(DescribePublicIpv4PoolsRequest request);

        /// <summary>
        /// Paginator for DescribeReplaceRootVolumeTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReplaceRootVolumeTasksPaginator DescribeReplaceRootVolumeTasks(DescribeReplaceRootVolumeTasksRequest request);

        /// <summary>
        /// Paginator for DescribeReservedInstancesModifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReservedInstancesModificationsPaginator DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedInstancesOfferings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeReservedInstancesOfferingsPaginator DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeRouteServerEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRouteServerEndpointsPaginator DescribeRouteServerEndpoints(DescribeRouteServerEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeRouteServerPeers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRouteServerPeersPaginator DescribeRouteServerPeers(DescribeRouteServerPeersRequest request);

        /// <summary>
        /// Paginator for DescribeRouteServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRouteServersPaginator DescribeRouteServers(DescribeRouteServersRequest request);

        /// <summary>
        /// Paginator for DescribeRouteTables operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRouteTablesPaginator DescribeRouteTables(DescribeRouteTablesRequest request);

        /// <summary>
        /// Paginator for DescribeScheduledInstanceAvailability operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeScheduledInstanceAvailabilityPaginator DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request);

        /// <summary>
        /// Paginator for DescribeScheduledInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeScheduledInstancesPaginator DescribeScheduledInstances(DescribeScheduledInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeSecurityGroupRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSecurityGroupRulesPaginator DescribeSecurityGroupRules(DescribeSecurityGroupRulesRequest request);

        /// <summary>
        /// Paginator for DescribeSecurityGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSecurityGroupsPaginator DescribeSecurityGroups(DescribeSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeSecurityGroupVpcAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSecurityGroupVpcAssociationsPaginator DescribeSecurityGroupVpcAssociations(DescribeSecurityGroupVpcAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshotTierStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSnapshotTierStatusPaginator DescribeSnapshotTierStatus(DescribeSnapshotTierStatusRequest request);

        /// <summary>
        /// Paginator for DescribeSpotFleetRequests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSpotFleetRequestsPaginator DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request);

        /// <summary>
        /// Paginator for DescribeSpotInstanceRequests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSpotInstanceRequestsPaginator DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request);

        /// <summary>
        /// Paginator for DescribeSpotPriceHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSpotPriceHistoryPaginator DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request);

        /// <summary>
        /// Paginator for DescribeStaleSecurityGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeStaleSecurityGroupsPaginator DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeStoreImageTasks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeStoreImageTasksPaginator DescribeStoreImageTasks(DescribeStoreImageTasksRequest request);

        /// <summary>
        /// Paginator for DescribeSubnets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSubnetsPaginator DescribeSubnets(DescribeSubnetsRequest request);

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Paginator for DescribeTrafficMirrorFilters operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTrafficMirrorFiltersPaginator DescribeTrafficMirrorFilters(DescribeTrafficMirrorFiltersRequest request);

        /// <summary>
        /// Paginator for DescribeTrafficMirrorSessions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTrafficMirrorSessionsPaginator DescribeTrafficMirrorSessions(DescribeTrafficMirrorSessionsRequest request);

        /// <summary>
        /// Paginator for DescribeTrafficMirrorTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTrafficMirrorTargetsPaginator DescribeTrafficMirrorTargets(DescribeTrafficMirrorTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayAttachments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayAttachmentsPaginator DescribeTransitGatewayAttachments(DescribeTransitGatewayAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayConnectPeers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayConnectPeersPaginator DescribeTransitGatewayConnectPeers(DescribeTransitGatewayConnectPeersRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayConnects operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayConnectsPaginator DescribeTransitGatewayConnects(DescribeTransitGatewayConnectsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayMulticastDomains operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayMulticastDomainsPaginator DescribeTransitGatewayMulticastDomains(DescribeTransitGatewayMulticastDomainsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayPeeringAttachments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayPeeringAttachmentsPaginator DescribeTransitGatewayPeeringAttachments(DescribeTransitGatewayPeeringAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayPolicyTables operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayPolicyTablesPaginator DescribeTransitGatewayPolicyTables(DescribeTransitGatewayPolicyTablesRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayRouteTableAnnouncements operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayRouteTableAnnouncementsPaginator DescribeTransitGatewayRouteTableAnnouncements(DescribeTransitGatewayRouteTableAnnouncementsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayRouteTables operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayRouteTablesPaginator DescribeTransitGatewayRouteTables(DescribeTransitGatewayRouteTablesRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGateways operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewaysPaginator DescribeTransitGateways(DescribeTransitGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayVpcAttachments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTransitGatewayVpcAttachmentsPaginator DescribeTransitGatewayVpcAttachments(DescribeTransitGatewayVpcAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeTrunkInterfaceAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeTrunkInterfaceAssociationsPaginator DescribeTrunkInterfaceAssociations(DescribeTrunkInterfaceAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVerifiedAccessEndpointsPaginator DescribeVerifiedAccessEndpoints(DescribeVerifiedAccessEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVerifiedAccessGroupsPaginator DescribeVerifiedAccessGroups(DescribeVerifiedAccessGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessInstanceLoggingConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVerifiedAccessInstanceLoggingConfigurationsPaginator DescribeVerifiedAccessInstanceLoggingConfigurations(DescribeVerifiedAccessInstanceLoggingConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessInstances operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVerifiedAccessInstancesPaginator DescribeVerifiedAccessInstances(DescribeVerifiedAccessInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessTrustProviders operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVerifiedAccessTrustProvidersPaginator DescribeVerifiedAccessTrustProviders(DescribeVerifiedAccessTrustProvidersRequest request);

        /// <summary>
        /// Paginator for DescribeVolumes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVolumesPaginator DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Paginator for DescribeVolumesModifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVolumesModificationsPaginator DescribeVolumesModifications(DescribeVolumesModificationsRequest request);

        /// <summary>
        /// Paginator for DescribeVolumeStatus operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVolumeStatusPaginator DescribeVolumeStatus(DescribeVolumeStatusRequest request);

        /// <summary>
        /// Paginator for DescribeVpcClassicLinkDnsSupport operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcClassicLinkDnsSupportPaginator DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointConnectionNotifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcEndpointConnectionNotificationsPaginator DescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcEndpointConnectionsPaginator DescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpoints operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcEndpointsPaginator DescribeVpcEndpoints(DescribeVpcEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointServiceConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcEndpointServiceConfigurationsPaginator DescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointServicePermissions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcEndpointServicePermissionsPaginator DescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcPeeringConnections operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcPeeringConnectionsPaginator DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVpcsPaginator DescribeVpcs(DescribeVpcsRequest request);

        /// <summary>
        /// Paginator for GetAssociatedIpv6PoolCidrs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetAssociatedIpv6PoolCidrsPaginator GetAssociatedIpv6PoolCidrs(GetAssociatedIpv6PoolCidrsRequest request);

        /// <summary>
        /// Paginator for GetAwsNetworkPerformanceData operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetAwsNetworkPerformanceDataPaginator GetAwsNetworkPerformanceData(GetAwsNetworkPerformanceDataRequest request);

        /// <summary>
        /// Paginator for GetGroupsForCapacityReservation operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetGroupsForCapacityReservationPaginator GetGroupsForCapacityReservation(GetGroupsForCapacityReservationRequest request);

        /// <summary>
        /// Paginator for GetInstanceTypesFromInstanceRequirements operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetInstanceTypesFromInstanceRequirementsPaginator GetInstanceTypesFromInstanceRequirements(GetInstanceTypesFromInstanceRequirementsRequest request);

        /// <summary>
        /// Paginator for GetIpamAddressHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIpamAddressHistoryPaginator GetIpamAddressHistory(GetIpamAddressHistoryRequest request);

        /// <summary>
        /// Paginator for GetIpamDiscoveredAccounts operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIpamDiscoveredAccountsPaginator GetIpamDiscoveredAccounts(GetIpamDiscoveredAccountsRequest request);

        /// <summary>
        /// Paginator for GetIpamDiscoveredResourceCidrs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIpamDiscoveredResourceCidrsPaginator GetIpamDiscoveredResourceCidrs(GetIpamDiscoveredResourceCidrsRequest request);

        /// <summary>
        /// Paginator for GetIpamPoolAllocations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIpamPoolAllocationsPaginator GetIpamPoolAllocations(GetIpamPoolAllocationsRequest request);

        /// <summary>
        /// Paginator for GetIpamPoolCidrs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIpamPoolCidrsPaginator GetIpamPoolCidrs(GetIpamPoolCidrsRequest request);

        /// <summary>
        /// Paginator for GetIpamResourceCidrs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetIpamResourceCidrsPaginator GetIpamResourceCidrs(GetIpamResourceCidrsRequest request);

        /// <summary>
        /// Paginator for GetManagedPrefixListAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetManagedPrefixListAssociationsPaginator GetManagedPrefixListAssociations(GetManagedPrefixListAssociationsRequest request);

        /// <summary>
        /// Paginator for GetManagedPrefixListEntries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetManagedPrefixListEntriesPaginator GetManagedPrefixListEntries(GetManagedPrefixListEntriesRequest request);

        /// <summary>
        /// Paginator for GetNetworkInsightsAccessScopeAnalysisFindings operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetNetworkInsightsAccessScopeAnalysisFindingsPaginator GetNetworkInsightsAccessScopeAnalysisFindings(GetNetworkInsightsAccessScopeAnalysisFindingsRequest request);

        /// <summary>
        /// Paginator for GetSecurityGroupsForVpc operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSecurityGroupsForVpcPaginator GetSecurityGroupsForVpc(GetSecurityGroupsForVpcRequest request);

        /// <summary>
        /// Paginator for GetSpotPlacementScores operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetSpotPlacementScoresPaginator GetSpotPlacementScores(GetSpotPlacementScoresRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayAttachmentPropagations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTransitGatewayAttachmentPropagationsPaginator GetTransitGatewayAttachmentPropagations(GetTransitGatewayAttachmentPropagationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayMulticastDomainAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTransitGatewayMulticastDomainAssociationsPaginator GetTransitGatewayMulticastDomainAssociations(GetTransitGatewayMulticastDomainAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayPolicyTableAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTransitGatewayPolicyTableAssociationsPaginator GetTransitGatewayPolicyTableAssociations(GetTransitGatewayPolicyTableAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayPrefixListReferences operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTransitGatewayPrefixListReferencesPaginator GetTransitGatewayPrefixListReferences(GetTransitGatewayPrefixListReferencesRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayRouteTableAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTransitGatewayRouteTableAssociationsPaginator GetTransitGatewayRouteTableAssociations(GetTransitGatewayRouteTableAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayRouteTablePropagations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetTransitGatewayRouteTablePropagationsPaginator GetTransitGatewayRouteTablePropagations(GetTransitGatewayRouteTablePropagationsRequest request);

        /// <summary>
        /// Paginator for GetVpnConnectionDeviceTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetVpnConnectionDeviceTypesPaginator GetVpnConnectionDeviceTypes(GetVpnConnectionDeviceTypesRequest request);

        /// <summary>
        /// Paginator for ListImagesInRecycleBin operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListImagesInRecycleBinPaginator ListImagesInRecycleBin(ListImagesInRecycleBinRequest request);

        /// <summary>
        /// Paginator for ListSnapshotsInRecycleBin operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSnapshotsInRecycleBinPaginator ListSnapshotsInRecycleBin(ListSnapshotsInRecycleBinRequest request);

        /// <summary>
        /// Paginator for SearchLocalGatewayRoutes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchLocalGatewayRoutesPaginator SearchLocalGatewayRoutes(SearchLocalGatewayRoutesRequest request);

        /// <summary>
        /// Paginator for SearchTransitGatewayMulticastGroups operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        ISearchTransitGatewayMulticastGroupsPaginator SearchTransitGatewayMulticastGroups(SearchTransitGatewayMulticastGroupsRequest request);
    }
}