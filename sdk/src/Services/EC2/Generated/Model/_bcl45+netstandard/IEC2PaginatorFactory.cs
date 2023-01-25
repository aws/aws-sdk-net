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
        IDescribeAddressesAttributePaginator DescribeAddressesAttribute(DescribeAddressesAttributeRequest request);

        /// <summary>
        /// Paginator for DescribeAddressTransfers operation
        ///</summary>
        IDescribeAddressTransfersPaginator DescribeAddressTransfers(DescribeAddressTransfersRequest request);

        /// <summary>
        /// Paginator for DescribeAwsNetworkPerformanceMetricSubscriptions operation
        ///</summary>
        IDescribeAwsNetworkPerformanceMetricSubscriptionsPaginator DescribeAwsNetworkPerformanceMetricSubscriptions(DescribeAwsNetworkPerformanceMetricSubscriptionsRequest request);

        /// <summary>
        /// Paginator for DescribeByoipCidrs operation
        ///</summary>
        IDescribeByoipCidrsPaginator DescribeByoipCidrs(DescribeByoipCidrsRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityReservationFleets operation
        ///</summary>
        IDescribeCapacityReservationFleetsPaginator DescribeCapacityReservationFleets(DescribeCapacityReservationFleetsRequest request);

        /// <summary>
        /// Paginator for DescribeCapacityReservations operation
        ///</summary>
        IDescribeCapacityReservationsPaginator DescribeCapacityReservations(DescribeCapacityReservationsRequest request);

        /// <summary>
        /// Paginator for DescribeCarrierGateways operation
        ///</summary>
        IDescribeCarrierGatewaysPaginator DescribeCarrierGateways(DescribeCarrierGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeClassicLinkInstances operation
        ///</summary>
        IDescribeClassicLinkInstancesPaginator DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnAuthorizationRules operation
        ///</summary>
        IDescribeClientVpnAuthorizationRulesPaginator DescribeClientVpnAuthorizationRules(DescribeClientVpnAuthorizationRulesRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnConnections operation
        ///</summary>
        IDescribeClientVpnConnectionsPaginator DescribeClientVpnConnections(DescribeClientVpnConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnEndpoints operation
        ///</summary>
        IDescribeClientVpnEndpointsPaginator DescribeClientVpnEndpoints(DescribeClientVpnEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnRoutes operation
        ///</summary>
        IDescribeClientVpnRoutesPaginator DescribeClientVpnRoutes(DescribeClientVpnRoutesRequest request);

        /// <summary>
        /// Paginator for DescribeClientVpnTargetNetworks operation
        ///</summary>
        IDescribeClientVpnTargetNetworksPaginator DescribeClientVpnTargetNetworks(DescribeClientVpnTargetNetworksRequest request);

        /// <summary>
        /// Paginator for DescribeCoipPools operation
        ///</summary>
        IDescribeCoipPoolsPaginator DescribeCoipPools(DescribeCoipPoolsRequest request);

        /// <summary>
        /// Paginator for DescribeDhcpOptions operation
        ///</summary>
        IDescribeDhcpOptionsPaginator DescribeDhcpOptions(DescribeDhcpOptionsRequest request);

        /// <summary>
        /// Paginator for DescribeEgressOnlyInternetGateways operation
        ///</summary>
        IDescribeEgressOnlyInternetGatewaysPaginator DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeExportImageTasks operation
        ///</summary>
        IDescribeExportImageTasksPaginator DescribeExportImageTasks(DescribeExportImageTasksRequest request);

        /// <summary>
        /// Paginator for DescribeFastLaunchImages operation
        ///</summary>
        IDescribeFastLaunchImagesPaginator DescribeFastLaunchImages(DescribeFastLaunchImagesRequest request);

        /// <summary>
        /// Paginator for DescribeFastSnapshotRestores operation
        ///</summary>
        IDescribeFastSnapshotRestoresPaginator DescribeFastSnapshotRestores(DescribeFastSnapshotRestoresRequest request);

        /// <summary>
        /// Paginator for DescribeFleets operation
        ///</summary>
        IDescribeFleetsPaginator DescribeFleets(DescribeFleetsRequest request);

        /// <summary>
        /// Paginator for DescribeFlowLogs operation
        ///</summary>
        IDescribeFlowLogsPaginator DescribeFlowLogs(DescribeFlowLogsRequest request);

        /// <summary>
        /// Paginator for DescribeFpgaImages operation
        ///</summary>
        IDescribeFpgaImagesPaginator DescribeFpgaImages(DescribeFpgaImagesRequest request);

        /// <summary>
        /// Paginator for DescribeHostReservationOfferings operation
        ///</summary>
        IDescribeHostReservationOfferingsPaginator DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeHostReservations operation
        ///</summary>
        IDescribeHostReservationsPaginator DescribeHostReservations(DescribeHostReservationsRequest request);

        /// <summary>
        /// Paginator for DescribeHosts operation
        ///</summary>
        IDescribeHostsPaginator DescribeHosts(DescribeHostsRequest request);

        /// <summary>
        /// Paginator for DescribeIamInstanceProfileAssociations operation
        ///</summary>
        IDescribeIamInstanceProfileAssociationsPaginator DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeImages operation
        ///</summary>
        IDescribeImagesPaginator DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Paginator for DescribeImportImageTasks operation
        ///</summary>
        IDescribeImportImageTasksPaginator DescribeImportImageTasks(DescribeImportImageTasksRequest request);

        /// <summary>
        /// Paginator for DescribeImportSnapshotTasks operation
        ///</summary>
        IDescribeImportSnapshotTasksPaginator DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceCreditSpecifications operation
        ///</summary>
        IDescribeInstanceCreditSpecificationsPaginator DescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceEventWindows operation
        ///</summary>
        IDescribeInstanceEventWindowsPaginator DescribeInstanceEventWindows(DescribeInstanceEventWindowsRequest request);

        /// <summary>
        /// Paginator for DescribeInstances operation
        ///</summary>
        IDescribeInstancesPaginator DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceStatus operation
        ///</summary>
        IDescribeInstanceStatusPaginator DescribeInstanceStatus(DescribeInstanceStatusRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceTypeOfferings operation
        ///</summary>
        IDescribeInstanceTypeOfferingsPaginator DescribeInstanceTypeOfferings(DescribeInstanceTypeOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeInstanceTypes operation
        ///</summary>
        IDescribeInstanceTypesPaginator DescribeInstanceTypes(DescribeInstanceTypesRequest request);

        /// <summary>
        /// Paginator for DescribeInternetGateways operation
        ///</summary>
        IDescribeInternetGatewaysPaginator DescribeInternetGateways(DescribeInternetGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeIpamPools operation
        ///</summary>
        IDescribeIpamPoolsPaginator DescribeIpamPools(DescribeIpamPoolsRequest request);

        /// <summary>
        /// Paginator for DescribeIpamResourceDiscoveries operation
        ///</summary>
        IDescribeIpamResourceDiscoveriesPaginator DescribeIpamResourceDiscoveries(DescribeIpamResourceDiscoveriesRequest request);

        /// <summary>
        /// Paginator for DescribeIpamResourceDiscoveryAssociations operation
        ///</summary>
        IDescribeIpamResourceDiscoveryAssociationsPaginator DescribeIpamResourceDiscoveryAssociations(DescribeIpamResourceDiscoveryAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeIpams operation
        ///</summary>
        IDescribeIpamsPaginator DescribeIpams(DescribeIpamsRequest request);

        /// <summary>
        /// Paginator for DescribeIpamScopes operation
        ///</summary>
        IDescribeIpamScopesPaginator DescribeIpamScopes(DescribeIpamScopesRequest request);

        /// <summary>
        /// Paginator for DescribeIpv6Pools operation
        ///</summary>
        IDescribeIpv6PoolsPaginator DescribeIpv6Pools(DescribeIpv6PoolsRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchTemplates operation
        ///</summary>
        IDescribeLaunchTemplatesPaginator DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeLaunchTemplateVersions operation
        ///</summary>
        IDescribeLaunchTemplateVersionsPaginator DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTables operation
        ///</summary>
        IDescribeLocalGatewayRouteTablesPaginator DescribeLocalGatewayRouteTables(DescribeLocalGatewayRouteTablesRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations operation
        ///</summary>
        IDescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsPaginator DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations(DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayRouteTableVpcAssociations operation
        ///</summary>
        IDescribeLocalGatewayRouteTableVpcAssociationsPaginator DescribeLocalGatewayRouteTableVpcAssociations(DescribeLocalGatewayRouteTableVpcAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGateways operation
        ///</summary>
        IDescribeLocalGatewaysPaginator DescribeLocalGateways(DescribeLocalGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayVirtualInterfaceGroups operation
        ///</summary>
        IDescribeLocalGatewayVirtualInterfaceGroupsPaginator DescribeLocalGatewayVirtualInterfaceGroups(DescribeLocalGatewayVirtualInterfaceGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeLocalGatewayVirtualInterfaces operation
        ///</summary>
        IDescribeLocalGatewayVirtualInterfacesPaginator DescribeLocalGatewayVirtualInterfaces(DescribeLocalGatewayVirtualInterfacesRequest request);

        /// <summary>
        /// Paginator for DescribeManagedPrefixLists operation
        ///</summary>
        IDescribeManagedPrefixListsPaginator DescribeManagedPrefixLists(DescribeManagedPrefixListsRequest request);

        /// <summary>
        /// Paginator for DescribeMovingAddresses operation
        ///</summary>
        IDescribeMovingAddressesPaginator DescribeMovingAddresses(DescribeMovingAddressesRequest request);

        /// <summary>
        /// Paginator for DescribeNatGateways operation
        ///</summary>
        IDescribeNatGatewaysPaginator DescribeNatGateways(DescribeNatGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkAcls operation
        ///</summary>
        IDescribeNetworkAclsPaginator DescribeNetworkAcls(DescribeNetworkAclsRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAccessScopeAnalyses operation
        ///</summary>
        IDescribeNetworkInsightsAccessScopeAnalysesPaginator DescribeNetworkInsightsAccessScopeAnalyses(DescribeNetworkInsightsAccessScopeAnalysesRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAccessScopes operation
        ///</summary>
        IDescribeNetworkInsightsAccessScopesPaginator DescribeNetworkInsightsAccessScopes(DescribeNetworkInsightsAccessScopesRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsAnalyses operation
        ///</summary>
        IDescribeNetworkInsightsAnalysesPaginator DescribeNetworkInsightsAnalyses(DescribeNetworkInsightsAnalysesRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInsightsPaths operation
        ///</summary>
        IDescribeNetworkInsightsPathsPaginator DescribeNetworkInsightsPaths(DescribeNetworkInsightsPathsRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInterfacePermissions operation
        ///</summary>
        IDescribeNetworkInterfacePermissionsPaginator DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeNetworkInterfaces operation
        ///</summary>
        IDescribeNetworkInterfacesPaginator DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request);

        /// <summary>
        /// Paginator for DescribePrefixLists operation
        ///</summary>
        IDescribePrefixListsPaginator DescribePrefixLists(DescribePrefixListsRequest request);

        /// <summary>
        /// Paginator for DescribePrincipalIdFormat operation
        ///</summary>
        IDescribePrincipalIdFormatPaginator DescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request);

        /// <summary>
        /// Paginator for DescribePublicIpv4Pools operation
        ///</summary>
        IDescribePublicIpv4PoolsPaginator DescribePublicIpv4Pools(DescribePublicIpv4PoolsRequest request);

        /// <summary>
        /// Paginator for DescribeReplaceRootVolumeTasks operation
        ///</summary>
        IDescribeReplaceRootVolumeTasksPaginator DescribeReplaceRootVolumeTasks(DescribeReplaceRootVolumeTasksRequest request);

        /// <summary>
        /// Paginator for DescribeReservedInstancesModifications operation
        ///</summary>
        IDescribeReservedInstancesModificationsPaginator DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request);

        /// <summary>
        /// Paginator for DescribeReservedInstancesOfferings operation
        ///</summary>
        IDescribeReservedInstancesOfferingsPaginator DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request);

        /// <summary>
        /// Paginator for DescribeRouteTables operation
        ///</summary>
        IDescribeRouteTablesPaginator DescribeRouteTables(DescribeRouteTablesRequest request);

        /// <summary>
        /// Paginator for DescribeScheduledInstanceAvailability operation
        ///</summary>
        IDescribeScheduledInstanceAvailabilityPaginator DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request);

        /// <summary>
        /// Paginator for DescribeScheduledInstances operation
        ///</summary>
        IDescribeScheduledInstancesPaginator DescribeScheduledInstances(DescribeScheduledInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeSecurityGroupRules operation
        ///</summary>
        IDescribeSecurityGroupRulesPaginator DescribeSecurityGroupRules(DescribeSecurityGroupRulesRequest request);

        /// <summary>
        /// Paginator for DescribeSecurityGroups operation
        ///</summary>
        IDescribeSecurityGroupsPaginator DescribeSecurityGroups(DescribeSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshots operation
        ///</summary>
        IDescribeSnapshotsPaginator DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Paginator for DescribeSnapshotTierStatus operation
        ///</summary>
        IDescribeSnapshotTierStatusPaginator DescribeSnapshotTierStatus(DescribeSnapshotTierStatusRequest request);

        /// <summary>
        /// Paginator for DescribeSpotFleetRequests operation
        ///</summary>
        IDescribeSpotFleetRequestsPaginator DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request);

        /// <summary>
        /// Paginator for DescribeSpotInstanceRequests operation
        ///</summary>
        IDescribeSpotInstanceRequestsPaginator DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request);

        /// <summary>
        /// Paginator for DescribeSpotPriceHistory operation
        ///</summary>
        IDescribeSpotPriceHistoryPaginator DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request);

        /// <summary>
        /// Paginator for DescribeStaleSecurityGroups operation
        ///</summary>
        IDescribeStaleSecurityGroupsPaginator DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeStoreImageTasks operation
        ///</summary>
        IDescribeStoreImageTasksPaginator DescribeStoreImageTasks(DescribeStoreImageTasksRequest request);

        /// <summary>
        /// Paginator for DescribeSubnets operation
        ///</summary>
        IDescribeSubnetsPaginator DescribeSubnets(DescribeSubnetsRequest request);

        /// <summary>
        /// Paginator for DescribeTags operation
        ///</summary>
        IDescribeTagsPaginator DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Paginator for DescribeTrafficMirrorFilters operation
        ///</summary>
        IDescribeTrafficMirrorFiltersPaginator DescribeTrafficMirrorFilters(DescribeTrafficMirrorFiltersRequest request);

        /// <summary>
        /// Paginator for DescribeTrafficMirrorSessions operation
        ///</summary>
        IDescribeTrafficMirrorSessionsPaginator DescribeTrafficMirrorSessions(DescribeTrafficMirrorSessionsRequest request);

        /// <summary>
        /// Paginator for DescribeTrafficMirrorTargets operation
        ///</summary>
        IDescribeTrafficMirrorTargetsPaginator DescribeTrafficMirrorTargets(DescribeTrafficMirrorTargetsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayAttachments operation
        ///</summary>
        IDescribeTransitGatewayAttachmentsPaginator DescribeTransitGatewayAttachments(DescribeTransitGatewayAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayConnectPeers operation
        ///</summary>
        IDescribeTransitGatewayConnectPeersPaginator DescribeTransitGatewayConnectPeers(DescribeTransitGatewayConnectPeersRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayConnects operation
        ///</summary>
        IDescribeTransitGatewayConnectsPaginator DescribeTransitGatewayConnects(DescribeTransitGatewayConnectsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayMulticastDomains operation
        ///</summary>
        IDescribeTransitGatewayMulticastDomainsPaginator DescribeTransitGatewayMulticastDomains(DescribeTransitGatewayMulticastDomainsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayPeeringAttachments operation
        ///</summary>
        IDescribeTransitGatewayPeeringAttachmentsPaginator DescribeTransitGatewayPeeringAttachments(DescribeTransitGatewayPeeringAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayPolicyTables operation
        ///</summary>
        IDescribeTransitGatewayPolicyTablesPaginator DescribeTransitGatewayPolicyTables(DescribeTransitGatewayPolicyTablesRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayRouteTableAnnouncements operation
        ///</summary>
        IDescribeTransitGatewayRouteTableAnnouncementsPaginator DescribeTransitGatewayRouteTableAnnouncements(DescribeTransitGatewayRouteTableAnnouncementsRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayRouteTables operation
        ///</summary>
        IDescribeTransitGatewayRouteTablesPaginator DescribeTransitGatewayRouteTables(DescribeTransitGatewayRouteTablesRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGateways operation
        ///</summary>
        IDescribeTransitGatewaysPaginator DescribeTransitGateways(DescribeTransitGatewaysRequest request);

        /// <summary>
        /// Paginator for DescribeTransitGatewayVpcAttachments operation
        ///</summary>
        IDescribeTransitGatewayVpcAttachmentsPaginator DescribeTransitGatewayVpcAttachments(DescribeTransitGatewayVpcAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeTrunkInterfaceAssociations operation
        ///</summary>
        IDescribeTrunkInterfaceAssociationsPaginator DescribeTrunkInterfaceAssociations(DescribeTrunkInterfaceAssociationsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessEndpoints operation
        ///</summary>
        IDescribeVerifiedAccessEndpointsPaginator DescribeVerifiedAccessEndpoints(DescribeVerifiedAccessEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessGroups operation
        ///</summary>
        IDescribeVerifiedAccessGroupsPaginator DescribeVerifiedAccessGroups(DescribeVerifiedAccessGroupsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessInstanceLoggingConfigurations operation
        ///</summary>
        IDescribeVerifiedAccessInstanceLoggingConfigurationsPaginator DescribeVerifiedAccessInstanceLoggingConfigurations(DescribeVerifiedAccessInstanceLoggingConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessInstances operation
        ///</summary>
        IDescribeVerifiedAccessInstancesPaginator DescribeVerifiedAccessInstances(DescribeVerifiedAccessInstancesRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedAccessTrustProviders operation
        ///</summary>
        IDescribeVerifiedAccessTrustProvidersPaginator DescribeVerifiedAccessTrustProviders(DescribeVerifiedAccessTrustProvidersRequest request);

        /// <summary>
        /// Paginator for DescribeVolumes operation
        ///</summary>
        IDescribeVolumesPaginator DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Paginator for DescribeVolumesModifications operation
        ///</summary>
        IDescribeVolumesModificationsPaginator DescribeVolumesModifications(DescribeVolumesModificationsRequest request);

        /// <summary>
        /// Paginator for DescribeVolumeStatus operation
        ///</summary>
        IDescribeVolumeStatusPaginator DescribeVolumeStatus(DescribeVolumeStatusRequest request);

        /// <summary>
        /// Paginator for DescribeVpcClassicLinkDnsSupport operation
        ///</summary>
        IDescribeVpcClassicLinkDnsSupportPaginator DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointConnectionNotifications operation
        ///</summary>
        IDescribeVpcEndpointConnectionNotificationsPaginator DescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointConnections operation
        ///</summary>
        IDescribeVpcEndpointConnectionsPaginator DescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpoints operation
        ///</summary>
        IDescribeVpcEndpointsPaginator DescribeVpcEndpoints(DescribeVpcEndpointsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointServiceConfigurations operation
        ///</summary>
        IDescribeVpcEndpointServiceConfigurationsPaginator DescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcEndpointServicePermissions operation
        ///</summary>
        IDescribeVpcEndpointServicePermissionsPaginator DescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcPeeringConnections operation
        ///</summary>
        IDescribeVpcPeeringConnectionsPaginator DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request);

        /// <summary>
        /// Paginator for DescribeVpcs operation
        ///</summary>
        IDescribeVpcsPaginator DescribeVpcs(DescribeVpcsRequest request);

        /// <summary>
        /// Paginator for GetAssociatedIpv6PoolCidrs operation
        ///</summary>
        IGetAssociatedIpv6PoolCidrsPaginator GetAssociatedIpv6PoolCidrs(GetAssociatedIpv6PoolCidrsRequest request);

        /// <summary>
        /// Paginator for GetAwsNetworkPerformanceData operation
        ///</summary>
        IGetAwsNetworkPerformanceDataPaginator GetAwsNetworkPerformanceData(GetAwsNetworkPerformanceDataRequest request);

        /// <summary>
        /// Paginator for GetGroupsForCapacityReservation operation
        ///</summary>
        IGetGroupsForCapacityReservationPaginator GetGroupsForCapacityReservation(GetGroupsForCapacityReservationRequest request);

        /// <summary>
        /// Paginator for GetInstanceTypesFromInstanceRequirements operation
        ///</summary>
        IGetInstanceTypesFromInstanceRequirementsPaginator GetInstanceTypesFromInstanceRequirements(GetInstanceTypesFromInstanceRequirementsRequest request);

        /// <summary>
        /// Paginator for GetIpamAddressHistory operation
        ///</summary>
        IGetIpamAddressHistoryPaginator GetIpamAddressHistory(GetIpamAddressHistoryRequest request);

        /// <summary>
        /// Paginator for GetIpamDiscoveredAccounts operation
        ///</summary>
        IGetIpamDiscoveredAccountsPaginator GetIpamDiscoveredAccounts(GetIpamDiscoveredAccountsRequest request);

        /// <summary>
        /// Paginator for GetIpamDiscoveredResourceCidrs operation
        ///</summary>
        IGetIpamDiscoveredResourceCidrsPaginator GetIpamDiscoveredResourceCidrs(GetIpamDiscoveredResourceCidrsRequest request);

        /// <summary>
        /// Paginator for GetIpamPoolAllocations operation
        ///</summary>
        IGetIpamPoolAllocationsPaginator GetIpamPoolAllocations(GetIpamPoolAllocationsRequest request);

        /// <summary>
        /// Paginator for GetIpamPoolCidrs operation
        ///</summary>
        IGetIpamPoolCidrsPaginator GetIpamPoolCidrs(GetIpamPoolCidrsRequest request);

        /// <summary>
        /// Paginator for GetIpamResourceCidrs operation
        ///</summary>
        IGetIpamResourceCidrsPaginator GetIpamResourceCidrs(GetIpamResourceCidrsRequest request);

        /// <summary>
        /// Paginator for GetManagedPrefixListAssociations operation
        ///</summary>
        IGetManagedPrefixListAssociationsPaginator GetManagedPrefixListAssociations(GetManagedPrefixListAssociationsRequest request);

        /// <summary>
        /// Paginator for GetManagedPrefixListEntries operation
        ///</summary>
        IGetManagedPrefixListEntriesPaginator GetManagedPrefixListEntries(GetManagedPrefixListEntriesRequest request);

        /// <summary>
        /// Paginator for GetSpotPlacementScores operation
        ///</summary>
        IGetSpotPlacementScoresPaginator GetSpotPlacementScores(GetSpotPlacementScoresRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayAttachmentPropagations operation
        ///</summary>
        IGetTransitGatewayAttachmentPropagationsPaginator GetTransitGatewayAttachmentPropagations(GetTransitGatewayAttachmentPropagationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayMulticastDomainAssociations operation
        ///</summary>
        IGetTransitGatewayMulticastDomainAssociationsPaginator GetTransitGatewayMulticastDomainAssociations(GetTransitGatewayMulticastDomainAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayPolicyTableAssociations operation
        ///</summary>
        IGetTransitGatewayPolicyTableAssociationsPaginator GetTransitGatewayPolicyTableAssociations(GetTransitGatewayPolicyTableAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayPrefixListReferences operation
        ///</summary>
        IGetTransitGatewayPrefixListReferencesPaginator GetTransitGatewayPrefixListReferences(GetTransitGatewayPrefixListReferencesRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayRouteTableAssociations operation
        ///</summary>
        IGetTransitGatewayRouteTableAssociationsPaginator GetTransitGatewayRouteTableAssociations(GetTransitGatewayRouteTableAssociationsRequest request);

        /// <summary>
        /// Paginator for GetTransitGatewayRouteTablePropagations operation
        ///</summary>
        IGetTransitGatewayRouteTablePropagationsPaginator GetTransitGatewayRouteTablePropagations(GetTransitGatewayRouteTablePropagationsRequest request);

        /// <summary>
        /// Paginator for GetVpnConnectionDeviceTypes operation
        ///</summary>
        IGetVpnConnectionDeviceTypesPaginator GetVpnConnectionDeviceTypes(GetVpnConnectionDeviceTypesRequest request);

        /// <summary>
        /// Paginator for ListImagesInRecycleBin operation
        ///</summary>
        IListImagesInRecycleBinPaginator ListImagesInRecycleBin(ListImagesInRecycleBinRequest request);

        /// <summary>
        /// Paginator for ListSnapshotsInRecycleBin operation
        ///</summary>
        IListSnapshotsInRecycleBinPaginator ListSnapshotsInRecycleBin(ListSnapshotsInRecycleBinRequest request);

        /// <summary>
        /// Paginator for SearchLocalGatewayRoutes operation
        ///</summary>
        ISearchLocalGatewayRoutesPaginator SearchLocalGatewayRoutes(SearchLocalGatewayRoutesRequest request);

        /// <summary>
        /// Paginator for SearchTransitGatewayMulticastGroups operation
        ///</summary>
        ISearchTransitGatewayMulticastGroupsPaginator SearchTransitGatewayMulticastGroups(SearchTransitGatewayMulticastGroupsRequest request);
    }
}