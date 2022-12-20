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

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Paginators for the EC2 service
    ///</summary>
    public class EC2PaginatorFactory : IEC2PaginatorFactory
    {
        private readonly IAmazonEC2 client;

        internal EC2PaginatorFactory(IAmazonEC2 client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeAddressesAttribute operation
        ///</summary>
        public IDescribeAddressesAttributePaginator DescribeAddressesAttribute(DescribeAddressesAttributeRequest request) 
        {
            return new DescribeAddressesAttributePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAddressTransfers operation
        ///</summary>
        public IDescribeAddressTransfersPaginator DescribeAddressTransfers(DescribeAddressTransfersRequest request) 
        {
            return new DescribeAddressTransfersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeAwsNetworkPerformanceMetricSubscriptions operation
        ///</summary>
        public IDescribeAwsNetworkPerformanceMetricSubscriptionsPaginator DescribeAwsNetworkPerformanceMetricSubscriptions(DescribeAwsNetworkPerformanceMetricSubscriptionsRequest request) 
        {
            return new DescribeAwsNetworkPerformanceMetricSubscriptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeByoipCidrs operation
        ///</summary>
        public IDescribeByoipCidrsPaginator DescribeByoipCidrs(DescribeByoipCidrsRequest request) 
        {
            return new DescribeByoipCidrsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCapacityReservationFleets operation
        ///</summary>
        public IDescribeCapacityReservationFleetsPaginator DescribeCapacityReservationFleets(DescribeCapacityReservationFleetsRequest request) 
        {
            return new DescribeCapacityReservationFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCapacityReservations operation
        ///</summary>
        public IDescribeCapacityReservationsPaginator DescribeCapacityReservations(DescribeCapacityReservationsRequest request) 
        {
            return new DescribeCapacityReservationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCarrierGateways operation
        ///</summary>
        public IDescribeCarrierGatewaysPaginator DescribeCarrierGateways(DescribeCarrierGatewaysRequest request) 
        {
            return new DescribeCarrierGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClassicLinkInstances operation
        ///</summary>
        public IDescribeClassicLinkInstancesPaginator DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request) 
        {
            return new DescribeClassicLinkInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClientVpnAuthorizationRules operation
        ///</summary>
        public IDescribeClientVpnAuthorizationRulesPaginator DescribeClientVpnAuthorizationRules(DescribeClientVpnAuthorizationRulesRequest request) 
        {
            return new DescribeClientVpnAuthorizationRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClientVpnConnections operation
        ///</summary>
        public IDescribeClientVpnConnectionsPaginator DescribeClientVpnConnections(DescribeClientVpnConnectionsRequest request) 
        {
            return new DescribeClientVpnConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClientVpnEndpoints operation
        ///</summary>
        public IDescribeClientVpnEndpointsPaginator DescribeClientVpnEndpoints(DescribeClientVpnEndpointsRequest request) 
        {
            return new DescribeClientVpnEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClientVpnRoutes operation
        ///</summary>
        public IDescribeClientVpnRoutesPaginator DescribeClientVpnRoutes(DescribeClientVpnRoutesRequest request) 
        {
            return new DescribeClientVpnRoutesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeClientVpnTargetNetworks operation
        ///</summary>
        public IDescribeClientVpnTargetNetworksPaginator DescribeClientVpnTargetNetworks(DescribeClientVpnTargetNetworksRequest request) 
        {
            return new DescribeClientVpnTargetNetworksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeCoipPools operation
        ///</summary>
        public IDescribeCoipPoolsPaginator DescribeCoipPools(DescribeCoipPoolsRequest request) 
        {
            return new DescribeCoipPoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeDhcpOptions operation
        ///</summary>
        public IDescribeDhcpOptionsPaginator DescribeDhcpOptions(DescribeDhcpOptionsRequest request) 
        {
            return new DescribeDhcpOptionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeEgressOnlyInternetGateways operation
        ///</summary>
        public IDescribeEgressOnlyInternetGatewaysPaginator DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request) 
        {
            return new DescribeEgressOnlyInternetGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeExportImageTasks operation
        ///</summary>
        public IDescribeExportImageTasksPaginator DescribeExportImageTasks(DescribeExportImageTasksRequest request) 
        {
            return new DescribeExportImageTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFastLaunchImages operation
        ///</summary>
        public IDescribeFastLaunchImagesPaginator DescribeFastLaunchImages(DescribeFastLaunchImagesRequest request) 
        {
            return new DescribeFastLaunchImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFastSnapshotRestores operation
        ///</summary>
        public IDescribeFastSnapshotRestoresPaginator DescribeFastSnapshotRestores(DescribeFastSnapshotRestoresRequest request) 
        {
            return new DescribeFastSnapshotRestoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFleets operation
        ///</summary>
        public IDescribeFleetsPaginator DescribeFleets(DescribeFleetsRequest request) 
        {
            return new DescribeFleetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFlowLogs operation
        ///</summary>
        public IDescribeFlowLogsPaginator DescribeFlowLogs(DescribeFlowLogsRequest request) 
        {
            return new DescribeFlowLogsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeFpgaImages operation
        ///</summary>
        public IDescribeFpgaImagesPaginator DescribeFpgaImages(DescribeFpgaImagesRequest request) 
        {
            return new DescribeFpgaImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeHostReservationOfferings operation
        ///</summary>
        public IDescribeHostReservationOfferingsPaginator DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request) 
        {
            return new DescribeHostReservationOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeHostReservations operation
        ///</summary>
        public IDescribeHostReservationsPaginator DescribeHostReservations(DescribeHostReservationsRequest request) 
        {
            return new DescribeHostReservationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeHosts operation
        ///</summary>
        public IDescribeHostsPaginator DescribeHosts(DescribeHostsRequest request) 
        {
            return new DescribeHostsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeIamInstanceProfileAssociations operation
        ///</summary>
        public IDescribeIamInstanceProfileAssociationsPaginator DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request) 
        {
            return new DescribeIamInstanceProfileAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        public IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request) 
        {
            return new DescribeImagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeImportImageTasks operation
        ///</summary>
        public IDescribeImportImageTasksPaginator DescribeImportImageTasks(DescribeImportImageTasksRequest request) 
        {
            return new DescribeImportImageTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeImportSnapshotTasks operation
        ///</summary>
        public IDescribeImportSnapshotTasksPaginator DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request) 
        {
            return new DescribeImportSnapshotTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceCreditSpecifications operation
        ///</summary>
        public IDescribeInstanceCreditSpecificationsPaginator DescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request) 
        {
            return new DescribeInstanceCreditSpecificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceEventWindows operation
        ///</summary>
        public IDescribeInstanceEventWindowsPaginator DescribeInstanceEventWindows(DescribeInstanceEventWindowsRequest request) 
        {
            return new DescribeInstanceEventWindowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstances operation
        ///</summary>
        public IDescribeInstancesPaginator DescribeInstances(DescribeInstancesRequest request) 
        {
            return new DescribeInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceStatus operation
        ///</summary>
        public IDescribeInstanceStatusPaginator DescribeInstanceStatus(DescribeInstanceStatusRequest request) 
        {
            return new DescribeInstanceStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceTypeOfferings operation
        ///</summary>
        public IDescribeInstanceTypeOfferingsPaginator DescribeInstanceTypeOfferings(DescribeInstanceTypeOfferingsRequest request) 
        {
            return new DescribeInstanceTypeOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInstanceTypes operation
        ///</summary>
        public IDescribeInstanceTypesPaginator DescribeInstanceTypes(DescribeInstanceTypesRequest request) 
        {
            return new DescribeInstanceTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeInternetGateways operation
        ///</summary>
        public IDescribeInternetGatewaysPaginator DescribeInternetGateways(DescribeInternetGatewaysRequest request) 
        {
            return new DescribeInternetGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeIpamPools operation
        ///</summary>
        public IDescribeIpamPoolsPaginator DescribeIpamPools(DescribeIpamPoolsRequest request) 
        {
            return new DescribeIpamPoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeIpams operation
        ///</summary>
        public IDescribeIpamsPaginator DescribeIpams(DescribeIpamsRequest request) 
        {
            return new DescribeIpamsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeIpamScopes operation
        ///</summary>
        public IDescribeIpamScopesPaginator DescribeIpamScopes(DescribeIpamScopesRequest request) 
        {
            return new DescribeIpamScopesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeIpv6Pools operation
        ///</summary>
        public IDescribeIpv6PoolsPaginator DescribeIpv6Pools(DescribeIpv6PoolsRequest request) 
        {
            return new DescribeIpv6PoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLaunchTemplates operation
        ///</summary>
        public IDescribeLaunchTemplatesPaginator DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request) 
        {
            return new DescribeLaunchTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLaunchTemplateVersions operation
        ///</summary>
        public IDescribeLaunchTemplateVersionsPaginator DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request) 
        {
            return new DescribeLaunchTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTables operation
        ///</summary>
        public IDescribeLocalGatewayRouteTablesPaginator DescribeLocalGatewayRouteTables(DescribeLocalGatewayRouteTablesRequest request) 
        {
            return new DescribeLocalGatewayRouteTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations operation
        ///</summary>
        public IDescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsPaginator DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations(DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequest request) 
        {
            return new DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTableVpcAssociations operation
        ///</summary>
        public IDescribeLocalGatewayRouteTableVpcAssociationsPaginator DescribeLocalGatewayRouteTableVpcAssociations(DescribeLocalGatewayRouteTableVpcAssociationsRequest request) 
        {
            return new DescribeLocalGatewayRouteTableVpcAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLocalGateways operation
        ///</summary>
        public IDescribeLocalGatewaysPaginator DescribeLocalGateways(DescribeLocalGatewaysRequest request) 
        {
            return new DescribeLocalGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLocalGatewayVirtualInterfaceGroups operation
        ///</summary>
        public IDescribeLocalGatewayVirtualInterfaceGroupsPaginator DescribeLocalGatewayVirtualInterfaceGroups(DescribeLocalGatewayVirtualInterfaceGroupsRequest request) 
        {
            return new DescribeLocalGatewayVirtualInterfaceGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeLocalGatewayVirtualInterfaces operation
        ///</summary>
        public IDescribeLocalGatewayVirtualInterfacesPaginator DescribeLocalGatewayVirtualInterfaces(DescribeLocalGatewayVirtualInterfacesRequest request) 
        {
            return new DescribeLocalGatewayVirtualInterfacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeManagedPrefixLists operation
        ///</summary>
        public IDescribeManagedPrefixListsPaginator DescribeManagedPrefixLists(DescribeManagedPrefixListsRequest request) 
        {
            return new DescribeManagedPrefixListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeMovingAddresses operation
        ///</summary>
        public IDescribeMovingAddressesPaginator DescribeMovingAddresses(DescribeMovingAddressesRequest request) 
        {
            return new DescribeMovingAddressesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNatGateways operation
        ///</summary>
        public IDescribeNatGatewaysPaginator DescribeNatGateways(DescribeNatGatewaysRequest request) 
        {
            return new DescribeNatGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNetworkAcls operation
        ///</summary>
        public IDescribeNetworkAclsPaginator DescribeNetworkAcls(DescribeNetworkAclsRequest request) 
        {
            return new DescribeNetworkAclsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAccessScopeAnalyses operation
        ///</summary>
        public IDescribeNetworkInsightsAccessScopeAnalysesPaginator DescribeNetworkInsightsAccessScopeAnalyses(DescribeNetworkInsightsAccessScopeAnalysesRequest request) 
        {
            return new DescribeNetworkInsightsAccessScopeAnalysesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAccessScopes operation
        ///</summary>
        public IDescribeNetworkInsightsAccessScopesPaginator DescribeNetworkInsightsAccessScopes(DescribeNetworkInsightsAccessScopesRequest request) 
        {
            return new DescribeNetworkInsightsAccessScopesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAnalyses operation
        ///</summary>
        public IDescribeNetworkInsightsAnalysesPaginator DescribeNetworkInsightsAnalyses(DescribeNetworkInsightsAnalysesRequest request) 
        {
            return new DescribeNetworkInsightsAnalysesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNetworkInsightsPaths operation
        ///</summary>
        public IDescribeNetworkInsightsPathsPaginator DescribeNetworkInsightsPaths(DescribeNetworkInsightsPathsRequest request) 
        {
            return new DescribeNetworkInsightsPathsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNetworkInterfacePermissions operation
        ///</summary>
        public IDescribeNetworkInterfacePermissionsPaginator DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request) 
        {
            return new DescribeNetworkInterfacePermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNetworkInterfaces operation
        ///</summary>
        public IDescribeNetworkInterfacesPaginator DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request) 
        {
            return new DescribeNetworkInterfacesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePrefixLists operation
        ///</summary>
        public IDescribePrefixListsPaginator DescribePrefixLists(DescribePrefixListsRequest request) 
        {
            return new DescribePrefixListsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePrincipalIdFormat operation
        ///</summary>
        public IDescribePrincipalIdFormatPaginator DescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request) 
        {
            return new DescribePrincipalIdFormatPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePublicIpv4Pools operation
        ///</summary>
        public IDescribePublicIpv4PoolsPaginator DescribePublicIpv4Pools(DescribePublicIpv4PoolsRequest request) 
        {
            return new DescribePublicIpv4PoolsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReplaceRootVolumeTasks operation
        ///</summary>
        public IDescribeReplaceRootVolumeTasksPaginator DescribeReplaceRootVolumeTasks(DescribeReplaceRootVolumeTasksRequest request) 
        {
            return new DescribeReplaceRootVolumeTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedInstancesModifications operation
        ///</summary>
        public IDescribeReservedInstancesModificationsPaginator DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request) 
        {
            return new DescribeReservedInstancesModificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeReservedInstancesOfferings operation
        ///</summary>
        public IDescribeReservedInstancesOfferingsPaginator DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request) 
        {
            return new DescribeReservedInstancesOfferingsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeRouteTables operation
        ///</summary>
        public IDescribeRouteTablesPaginator DescribeRouteTables(DescribeRouteTablesRequest request) 
        {
            return new DescribeRouteTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScheduledInstanceAvailability operation
        ///</summary>
        public IDescribeScheduledInstanceAvailabilityPaginator DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request) 
        {
            return new DescribeScheduledInstanceAvailabilityPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeScheduledInstances operation
        ///</summary>
        public IDescribeScheduledInstancesPaginator DescribeScheduledInstances(DescribeScheduledInstancesRequest request) 
        {
            return new DescribeScheduledInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSecurityGroupRules operation
        ///</summary>
        public IDescribeSecurityGroupRulesPaginator DescribeSecurityGroupRules(DescribeSecurityGroupRulesRequest request) 
        {
            return new DescribeSecurityGroupRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSecurityGroups operation
        ///</summary>
        public IDescribeSecurityGroupsPaginator DescribeSecurityGroups(DescribeSecurityGroupsRequest request) 
        {
            return new DescribeSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        public IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request) 
        {
            return new DescribeSnapshotsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSnapshotTierStatus operation
        ///</summary>
        public IDescribeSnapshotTierStatusPaginator DescribeSnapshotTierStatus(DescribeSnapshotTierStatusRequest request) 
        {
            return new DescribeSnapshotTierStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSpotFleetRequests operation
        ///</summary>
        public IDescribeSpotFleetRequestsPaginator DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request) 
        {
            return new DescribeSpotFleetRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSpotInstanceRequests operation
        ///</summary>
        public IDescribeSpotInstanceRequestsPaginator DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request) 
        {
            return new DescribeSpotInstanceRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSpotPriceHistory operation
        ///</summary>
        public IDescribeSpotPriceHistoryPaginator DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request) 
        {
            return new DescribeSpotPriceHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStaleSecurityGroups operation
        ///</summary>
        public IDescribeStaleSecurityGroupsPaginator DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request) 
        {
            return new DescribeStaleSecurityGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeStoreImageTasks operation
        ///</summary>
        public IDescribeStoreImageTasksPaginator DescribeStoreImageTasks(DescribeStoreImageTasksRequest request) 
        {
            return new DescribeStoreImageTasksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSubnets operation
        ///</summary>
        public IDescribeSubnetsPaginator DescribeSubnets(DescribeSubnetsRequest request) 
        {
            return new DescribeSubnetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        public IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request) 
        {
            return new DescribeTagsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrafficMirrorFilters operation
        ///</summary>
        public IDescribeTrafficMirrorFiltersPaginator DescribeTrafficMirrorFilters(DescribeTrafficMirrorFiltersRequest request) 
        {
            return new DescribeTrafficMirrorFiltersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrafficMirrorSessions operation
        ///</summary>
        public IDescribeTrafficMirrorSessionsPaginator DescribeTrafficMirrorSessions(DescribeTrafficMirrorSessionsRequest request) 
        {
            return new DescribeTrafficMirrorSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrafficMirrorTargets operation
        ///</summary>
        public IDescribeTrafficMirrorTargetsPaginator DescribeTrafficMirrorTargets(DescribeTrafficMirrorTargetsRequest request) 
        {
            return new DescribeTrafficMirrorTargetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayAttachments operation
        ///</summary>
        public IDescribeTransitGatewayAttachmentsPaginator DescribeTransitGatewayAttachments(DescribeTransitGatewayAttachmentsRequest request) 
        {
            return new DescribeTransitGatewayAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayConnectPeers operation
        ///</summary>
        public IDescribeTransitGatewayConnectPeersPaginator DescribeTransitGatewayConnectPeers(DescribeTransitGatewayConnectPeersRequest request) 
        {
            return new DescribeTransitGatewayConnectPeersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayConnects operation
        ///</summary>
        public IDescribeTransitGatewayConnectsPaginator DescribeTransitGatewayConnects(DescribeTransitGatewayConnectsRequest request) 
        {
            return new DescribeTransitGatewayConnectsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayMulticastDomains operation
        ///</summary>
        public IDescribeTransitGatewayMulticastDomainsPaginator DescribeTransitGatewayMulticastDomains(DescribeTransitGatewayMulticastDomainsRequest request) 
        {
            return new DescribeTransitGatewayMulticastDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayPeeringAttachments operation
        ///</summary>
        public IDescribeTransitGatewayPeeringAttachmentsPaginator DescribeTransitGatewayPeeringAttachments(DescribeTransitGatewayPeeringAttachmentsRequest request) 
        {
            return new DescribeTransitGatewayPeeringAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayPolicyTables operation
        ///</summary>
        public IDescribeTransitGatewayPolicyTablesPaginator DescribeTransitGatewayPolicyTables(DescribeTransitGatewayPolicyTablesRequest request) 
        {
            return new DescribeTransitGatewayPolicyTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayRouteTableAnnouncements operation
        ///</summary>
        public IDescribeTransitGatewayRouteTableAnnouncementsPaginator DescribeTransitGatewayRouteTableAnnouncements(DescribeTransitGatewayRouteTableAnnouncementsRequest request) 
        {
            return new DescribeTransitGatewayRouteTableAnnouncementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayRouteTables operation
        ///</summary>
        public IDescribeTransitGatewayRouteTablesPaginator DescribeTransitGatewayRouteTables(DescribeTransitGatewayRouteTablesRequest request) 
        {
            return new DescribeTransitGatewayRouteTablesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGateways operation
        ///</summary>
        public IDescribeTransitGatewaysPaginator DescribeTransitGateways(DescribeTransitGatewaysRequest request) 
        {
            return new DescribeTransitGatewaysPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTransitGatewayVpcAttachments operation
        ///</summary>
        public IDescribeTransitGatewayVpcAttachmentsPaginator DescribeTransitGatewayVpcAttachments(DescribeTransitGatewayVpcAttachmentsRequest request) 
        {
            return new DescribeTransitGatewayVpcAttachmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeTrunkInterfaceAssociations operation
        ///</summary>
        public IDescribeTrunkInterfaceAssociationsPaginator DescribeTrunkInterfaceAssociations(DescribeTrunkInterfaceAssociationsRequest request) 
        {
            return new DescribeTrunkInterfaceAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVerifiedAccessEndpoints operation
        ///</summary>
        public IDescribeVerifiedAccessEndpointsPaginator DescribeVerifiedAccessEndpoints(DescribeVerifiedAccessEndpointsRequest request) 
        {
            return new DescribeVerifiedAccessEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVerifiedAccessGroups operation
        ///</summary>
        public IDescribeVerifiedAccessGroupsPaginator DescribeVerifiedAccessGroups(DescribeVerifiedAccessGroupsRequest request) 
        {
            return new DescribeVerifiedAccessGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVerifiedAccessInstanceLoggingConfigurations operation
        ///</summary>
        public IDescribeVerifiedAccessInstanceLoggingConfigurationsPaginator DescribeVerifiedAccessInstanceLoggingConfigurations(DescribeVerifiedAccessInstanceLoggingConfigurationsRequest request) 
        {
            return new DescribeVerifiedAccessInstanceLoggingConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVerifiedAccessInstances operation
        ///</summary>
        public IDescribeVerifiedAccessInstancesPaginator DescribeVerifiedAccessInstances(DescribeVerifiedAccessInstancesRequest request) 
        {
            return new DescribeVerifiedAccessInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVerifiedAccessTrustProviders operation
        ///</summary>
        public IDescribeVerifiedAccessTrustProvidersPaginator DescribeVerifiedAccessTrustProviders(DescribeVerifiedAccessTrustProvidersRequest request) 
        {
            return new DescribeVerifiedAccessTrustProvidersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVolumes operation
        ///</summary>
        public IDescribeVolumesPaginator DescribeVolumes(DescribeVolumesRequest request) 
        {
            return new DescribeVolumesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVolumesModifications operation
        ///</summary>
        public IDescribeVolumesModificationsPaginator DescribeVolumesModifications(DescribeVolumesModificationsRequest request) 
        {
            return new DescribeVolumesModificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVolumeStatus operation
        ///</summary>
        public IDescribeVolumeStatusPaginator DescribeVolumeStatus(DescribeVolumeStatusRequest request) 
        {
            return new DescribeVolumeStatusPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcClassicLinkDnsSupport operation
        ///</summary>
        public IDescribeVpcClassicLinkDnsSupportPaginator DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request) 
        {
            return new DescribeVpcClassicLinkDnsSupportPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcEndpointConnectionNotifications operation
        ///</summary>
        public IDescribeVpcEndpointConnectionNotificationsPaginator DescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request) 
        {
            return new DescribeVpcEndpointConnectionNotificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcEndpointConnections operation
        ///</summary>
        public IDescribeVpcEndpointConnectionsPaginator DescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request) 
        {
            return new DescribeVpcEndpointConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcEndpoints operation
        ///</summary>
        public IDescribeVpcEndpointsPaginator DescribeVpcEndpoints(DescribeVpcEndpointsRequest request) 
        {
            return new DescribeVpcEndpointsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcEndpointServiceConfigurations operation
        ///</summary>
        public IDescribeVpcEndpointServiceConfigurationsPaginator DescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request) 
        {
            return new DescribeVpcEndpointServiceConfigurationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcEndpointServicePermissions operation
        ///</summary>
        public IDescribeVpcEndpointServicePermissionsPaginator DescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request) 
        {
            return new DescribeVpcEndpointServicePermissionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcPeeringConnections operation
        ///</summary>
        public IDescribeVpcPeeringConnectionsPaginator DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request) 
        {
            return new DescribeVpcPeeringConnectionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeVpcs operation
        ///</summary>
        public IDescribeVpcsPaginator DescribeVpcs(DescribeVpcsRequest request) 
        {
            return new DescribeVpcsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAssociatedIpv6PoolCidrs operation
        ///</summary>
        public IGetAssociatedIpv6PoolCidrsPaginator GetAssociatedIpv6PoolCidrs(GetAssociatedIpv6PoolCidrsRequest request) 
        {
            return new GetAssociatedIpv6PoolCidrsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetAwsNetworkPerformanceData operation
        ///</summary>
        public IGetAwsNetworkPerformanceDataPaginator GetAwsNetworkPerformanceData(GetAwsNetworkPerformanceDataRequest request) 
        {
            return new GetAwsNetworkPerformanceDataPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetGroupsForCapacityReservation operation
        ///</summary>
        public IGetGroupsForCapacityReservationPaginator GetGroupsForCapacityReservation(GetGroupsForCapacityReservationRequest request) 
        {
            return new GetGroupsForCapacityReservationPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetInstanceTypesFromInstanceRequirements operation
        ///</summary>
        public IGetInstanceTypesFromInstanceRequirementsPaginator GetInstanceTypesFromInstanceRequirements(GetInstanceTypesFromInstanceRequirementsRequest request) 
        {
            return new GetInstanceTypesFromInstanceRequirementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetIpamAddressHistory operation
        ///</summary>
        public IGetIpamAddressHistoryPaginator GetIpamAddressHistory(GetIpamAddressHistoryRequest request) 
        {
            return new GetIpamAddressHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetIpamPoolAllocations operation
        ///</summary>
        public IGetIpamPoolAllocationsPaginator GetIpamPoolAllocations(GetIpamPoolAllocationsRequest request) 
        {
            return new GetIpamPoolAllocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetIpamPoolCidrs operation
        ///</summary>
        public IGetIpamPoolCidrsPaginator GetIpamPoolCidrs(GetIpamPoolCidrsRequest request) 
        {
            return new GetIpamPoolCidrsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetIpamResourceCidrs operation
        ///</summary>
        public IGetIpamResourceCidrsPaginator GetIpamResourceCidrs(GetIpamResourceCidrsRequest request) 
        {
            return new GetIpamResourceCidrsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetManagedPrefixListAssociations operation
        ///</summary>
        public IGetManagedPrefixListAssociationsPaginator GetManagedPrefixListAssociations(GetManagedPrefixListAssociationsRequest request) 
        {
            return new GetManagedPrefixListAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetManagedPrefixListEntries operation
        ///</summary>
        public IGetManagedPrefixListEntriesPaginator GetManagedPrefixListEntries(GetManagedPrefixListEntriesRequest request) 
        {
            return new GetManagedPrefixListEntriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetSpotPlacementScores operation
        ///</summary>
        public IGetSpotPlacementScoresPaginator GetSpotPlacementScores(GetSpotPlacementScoresRequest request) 
        {
            return new GetSpotPlacementScoresPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayAttachmentPropagations operation
        ///</summary>
        public IGetTransitGatewayAttachmentPropagationsPaginator GetTransitGatewayAttachmentPropagations(GetTransitGatewayAttachmentPropagationsRequest request) 
        {
            return new GetTransitGatewayAttachmentPropagationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayMulticastDomainAssociations operation
        ///</summary>
        public IGetTransitGatewayMulticastDomainAssociationsPaginator GetTransitGatewayMulticastDomainAssociations(GetTransitGatewayMulticastDomainAssociationsRequest request) 
        {
            return new GetTransitGatewayMulticastDomainAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayPolicyTableAssociations operation
        ///</summary>
        public IGetTransitGatewayPolicyTableAssociationsPaginator GetTransitGatewayPolicyTableAssociations(GetTransitGatewayPolicyTableAssociationsRequest request) 
        {
            return new GetTransitGatewayPolicyTableAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayPrefixListReferences operation
        ///</summary>
        public IGetTransitGatewayPrefixListReferencesPaginator GetTransitGatewayPrefixListReferences(GetTransitGatewayPrefixListReferencesRequest request) 
        {
            return new GetTransitGatewayPrefixListReferencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayRouteTableAssociations operation
        ///</summary>
        public IGetTransitGatewayRouteTableAssociationsPaginator GetTransitGatewayRouteTableAssociations(GetTransitGatewayRouteTableAssociationsRequest request) 
        {
            return new GetTransitGatewayRouteTableAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetTransitGatewayRouteTablePropagations operation
        ///</summary>
        public IGetTransitGatewayRouteTablePropagationsPaginator GetTransitGatewayRouteTablePropagations(GetTransitGatewayRouteTablePropagationsRequest request) 
        {
            return new GetTransitGatewayRouteTablePropagationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetVpnConnectionDeviceTypes operation
        ///</summary>
        public IGetVpnConnectionDeviceTypesPaginator GetVpnConnectionDeviceTypes(GetVpnConnectionDeviceTypesRequest request) 
        {
            return new GetVpnConnectionDeviceTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImagesInRecycleBin operation
        ///</summary>
        public IListImagesInRecycleBinPaginator ListImagesInRecycleBin(ListImagesInRecycleBinRequest request) 
        {
            return new ListImagesInRecycleBinPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSnapshotsInRecycleBin operation
        ///</summary>
        public IListSnapshotsInRecycleBinPaginator ListSnapshotsInRecycleBin(ListSnapshotsInRecycleBinRequest request) 
        {
            return new ListSnapshotsInRecycleBinPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchLocalGatewayRoutes operation
        ///</summary>
        public ISearchLocalGatewayRoutesPaginator SearchLocalGatewayRoutes(SearchLocalGatewayRoutesRequest request) 
        {
            return new SearchLocalGatewayRoutesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchTransitGatewayMulticastGroups operation
        ///</summary>
        public ISearchTransitGatewayMulticastGroupsPaginator SearchTransitGatewayMulticastGroups(SearchTransitGatewayMulticastGroupsRequest request) 
        {
            return new SearchTransitGatewayMulticastGroupsPaginator(this.client, request);
        }
    }
}