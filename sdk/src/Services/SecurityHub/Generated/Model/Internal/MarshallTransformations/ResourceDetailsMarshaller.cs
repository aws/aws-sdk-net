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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceDetails Marshaller
    /// </summary>
    public class ResourceDetailsMarshaller : IRequestMarshaller<ResourceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAwsAmazonMqBroker())
            {
                context.Writer.WritePropertyName("AwsAmazonMqBroker");
                context.Writer.WriteStartObject();

                var marshaller = AwsAmazonMqBrokerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAmazonMqBroker, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsApiGatewayRestApi())
            {
                context.Writer.WritePropertyName("AwsApiGatewayRestApi");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayRestApiDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayRestApi, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsApiGatewayStage())
            {
                context.Writer.WritePropertyName("AwsApiGatewayStage");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayStageDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayStage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsApiGatewayV2Api())
            {
                context.Writer.WritePropertyName("AwsApiGatewayV2Api");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayV2ApiDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayV2Api, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsApiGatewayV2Stage())
            {
                context.Writer.WritePropertyName("AwsApiGatewayV2Stage");
                context.Writer.WriteStartObject();

                var marshaller = AwsApiGatewayV2StageDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayV2Stage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsAppSyncGraphQlApi())
            {
                context.Writer.WritePropertyName("AwsAppSyncGraphQlApi");
                context.Writer.WriteStartObject();

                var marshaller = AwsAppSyncGraphQlApiDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAppSyncGraphQlApi, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsAthenaWorkGroup())
            {
                context.Writer.WritePropertyName("AwsAthenaWorkGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsAthenaWorkGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAthenaWorkGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsAutoScalingAutoScalingGroup())
            {
                context.Writer.WritePropertyName("AwsAutoScalingAutoScalingGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsAutoScalingAutoScalingGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAutoScalingAutoScalingGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsAutoScalingLaunchConfiguration())
            {
                context.Writer.WritePropertyName("AwsAutoScalingLaunchConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsAutoScalingLaunchConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAutoScalingLaunchConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsBackupBackupPlan())
            {
                context.Writer.WritePropertyName("AwsBackupBackupPlan");
                context.Writer.WriteStartObject();

                var marshaller = AwsBackupBackupPlanDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsBackupBackupPlan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsBackupBackupVault())
            {
                context.Writer.WritePropertyName("AwsBackupBackupVault");
                context.Writer.WriteStartObject();

                var marshaller = AwsBackupBackupVaultDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsBackupBackupVault, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsBackupRecoveryPoint())
            {
                context.Writer.WritePropertyName("AwsBackupRecoveryPoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsBackupRecoveryPointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsBackupRecoveryPoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsCertificateManagerCertificate())
            {
                context.Writer.WritePropertyName("AwsCertificateManagerCertificate");
                context.Writer.WriteStartObject();

                var marshaller = AwsCertificateManagerCertificateDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCertificateManagerCertificate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsCloudFormationStack())
            {
                context.Writer.WritePropertyName("AwsCloudFormationStack");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFormationStackDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudFormationStack, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsCloudFrontDistribution())
            {
                context.Writer.WritePropertyName("AwsCloudFrontDistribution");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFrontDistributionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudFrontDistribution, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsCloudTrailTrail())
            {
                context.Writer.WritePropertyName("AwsCloudTrailTrail");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudTrailTrailDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudTrailTrail, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsCloudWatchAlarm())
            {
                context.Writer.WritePropertyName("AwsCloudWatchAlarm");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudWatchAlarmDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudWatchAlarm, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsCodeBuildProject())
            {
                context.Writer.WritePropertyName("AwsCodeBuildProject");
                context.Writer.WriteStartObject();

                var marshaller = AwsCodeBuildProjectDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCodeBuildProject, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsDmsEndpoint())
            {
                context.Writer.WritePropertyName("AwsDmsEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsDmsEndpointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsDmsEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsDmsReplicationInstance())
            {
                context.Writer.WritePropertyName("AwsDmsReplicationInstance");
                context.Writer.WriteStartObject();

                var marshaller = AwsDmsReplicationInstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsDmsReplicationInstance, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsDmsReplicationTask())
            {
                context.Writer.WritePropertyName("AwsDmsReplicationTask");
                context.Writer.WriteStartObject();

                var marshaller = AwsDmsReplicationTaskDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsDmsReplicationTask, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsDynamoDbTable())
            {
                context.Writer.WritePropertyName("AwsDynamoDbTable");
                context.Writer.WriteStartObject();

                var marshaller = AwsDynamoDbTableDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsDynamoDbTable, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2ClientVpnEndpoint())
            {
                context.Writer.WritePropertyName("AwsEc2ClientVpnEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2ClientVpnEndpointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2ClientVpnEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2Eip())
            {
                context.Writer.WritePropertyName("AwsEc2Eip");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2EipDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Eip, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2Instance())
            {
                context.Writer.WritePropertyName("AwsEc2Instance");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2InstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Instance, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2LaunchTemplate())
            {
                context.Writer.WritePropertyName("AwsEc2LaunchTemplate");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2LaunchTemplate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2NetworkAcl())
            {
                context.Writer.WritePropertyName("AwsEc2NetworkAcl");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2NetworkAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2NetworkAcl, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2NetworkInterface())
            {
                context.Writer.WritePropertyName("AwsEc2NetworkInterface");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2NetworkInterfaceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2NetworkInterface, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2RouteTable())
            {
                context.Writer.WritePropertyName("AwsEc2RouteTable");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2RouteTableDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2RouteTable, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2SecurityGroup())
            {
                context.Writer.WritePropertyName("AwsEc2SecurityGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2SecurityGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2SecurityGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2Subnet())
            {
                context.Writer.WritePropertyName("AwsEc2Subnet");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2SubnetDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Subnet, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2TransitGateway())
            {
                context.Writer.WritePropertyName("AwsEc2TransitGateway");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2TransitGatewayDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2TransitGateway, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2Volume())
            {
                context.Writer.WritePropertyName("AwsEc2Volume");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VolumeDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Volume, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2Vpc())
            {
                context.Writer.WritePropertyName("AwsEc2Vpc");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpcDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Vpc, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2VpcEndpointService())
            {
                context.Writer.WritePropertyName("AwsEc2VpcEndpointService");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpcEndpointServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2VpcEndpointService, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2VpcPeeringConnection())
            {
                context.Writer.WritePropertyName("AwsEc2VpcPeeringConnection");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpcPeeringConnectionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2VpcPeeringConnection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEc2VpnConnection())
            {
                context.Writer.WritePropertyName("AwsEc2VpnConnection");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2VpnConnectionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2VpnConnection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEcrContainerImage())
            {
                context.Writer.WritePropertyName("AwsEcrContainerImage");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcrContainerImageDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcrContainerImage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEcrRepository())
            {
                context.Writer.WritePropertyName("AwsEcrRepository");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcrRepositoryDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcrRepository, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEcsCluster())
            {
                context.Writer.WritePropertyName("AwsEcsCluster");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsCluster, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEcsContainer())
            {
                context.Writer.WritePropertyName("AwsEcsContainer");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsContainerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsContainer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEcsService())
            {
                context.Writer.WritePropertyName("AwsEcsService");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsService, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEcsTask())
            {
                context.Writer.WritePropertyName("AwsEcsTask");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsTask, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEcsTaskDefinition())
            {
                context.Writer.WritePropertyName("AwsEcsTaskDefinition");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsTaskDefinitionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsTaskDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEfsAccessPoint())
            {
                context.Writer.WritePropertyName("AwsEfsAccessPoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsEfsAccessPointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEfsAccessPoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEksCluster())
            {
                context.Writer.WritePropertyName("AwsEksCluster");
                context.Writer.WriteStartObject();

                var marshaller = AwsEksClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEksCluster, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsElasticBeanstalkEnvironment())
            {
                context.Writer.WritePropertyName("AwsElasticBeanstalkEnvironment");
                context.Writer.WriteStartObject();

                var marshaller = AwsElasticBeanstalkEnvironmentDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElasticBeanstalkEnvironment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsElasticsearchDomain())
            {
                context.Writer.WritePropertyName("AwsElasticsearchDomain");
                context.Writer.WriteStartObject();

                var marshaller = AwsElasticsearchDomainDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElasticsearchDomain, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsElbLoadBalancer())
            {
                context.Writer.WritePropertyName("AwsElbLoadBalancer");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbLoadBalancerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElbLoadBalancer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsElbv2LoadBalancer())
            {
                context.Writer.WritePropertyName("AwsElbv2LoadBalancer");
                context.Writer.WriteStartObject();

                var marshaller = AwsElbv2LoadBalancerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElbv2LoadBalancer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEventSchemasRegistry())
            {
                context.Writer.WritePropertyName("AwsEventSchemasRegistry");
                context.Writer.WriteStartObject();

                var marshaller = AwsEventSchemasRegistryDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEventSchemasRegistry, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEventsEndpoint())
            {
                context.Writer.WritePropertyName("AwsEventsEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsEventsEndpointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEventsEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsEventsEventbus())
            {
                context.Writer.WritePropertyName("AwsEventsEventbus");
                context.Writer.WriteStartObject();

                var marshaller = AwsEventsEventbusDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEventsEventbus, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsGuardDutyDetector())
            {
                context.Writer.WritePropertyName("AwsGuardDutyDetector");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsGuardDutyDetector, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsIamAccessKey())
            {
                context.Writer.WritePropertyName("AwsIamAccessKey");
                context.Writer.WriteStartObject();

                var marshaller = AwsIamAccessKeyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamAccessKey, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsIamGroup())
            {
                context.Writer.WritePropertyName("AwsIamGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsIamGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsIamPolicy())
            {
                context.Writer.WritePropertyName("AwsIamPolicy");
                context.Writer.WriteStartObject();

                var marshaller = AwsIamPolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsIamRole())
            {
                context.Writer.WritePropertyName("AwsIamRole");
                context.Writer.WriteStartObject();

                var marshaller = AwsIamRoleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamRole, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsIamUser())
            {
                context.Writer.WritePropertyName("AwsIamUser");
                context.Writer.WriteStartObject();

                var marshaller = AwsIamUserDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamUser, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsKinesisStream())
            {
                context.Writer.WritePropertyName("AwsKinesisStream");
                context.Writer.WriteStartObject();

                var marshaller = AwsKinesisStreamDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsKinesisStream, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsKmsKey())
            {
                context.Writer.WritePropertyName("AwsKmsKey");
                context.Writer.WriteStartObject();

                var marshaller = AwsKmsKeyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsKmsKey, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsLambdaFunction())
            {
                context.Writer.WritePropertyName("AwsLambdaFunction");
                context.Writer.WriteStartObject();

                var marshaller = AwsLambdaFunctionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsLambdaFunction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsLambdaLayerVersion())
            {
                context.Writer.WritePropertyName("AwsLambdaLayerVersion");
                context.Writer.WriteStartObject();

                var marshaller = AwsLambdaLayerVersionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsLambdaLayerVersion, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsMskCluster())
            {
                context.Writer.WritePropertyName("AwsMskCluster");
                context.Writer.WriteStartObject();

                var marshaller = AwsMskClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsMskCluster, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsNetworkFirewallFirewall())
            {
                context.Writer.WritePropertyName("AwsNetworkFirewallFirewall");
                context.Writer.WriteStartObject();

                var marshaller = AwsNetworkFirewallFirewallDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsNetworkFirewallFirewall, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsNetworkFirewallFirewallPolicy())
            {
                context.Writer.WritePropertyName("AwsNetworkFirewallFirewallPolicy");
                context.Writer.WriteStartObject();

                var marshaller = AwsNetworkFirewallFirewallPolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsNetworkFirewallFirewallPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsNetworkFirewallRuleGroup())
            {
                context.Writer.WritePropertyName("AwsNetworkFirewallRuleGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsNetworkFirewallRuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsNetworkFirewallRuleGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsOpenSearchServiceDomain())
            {
                context.Writer.WritePropertyName("AwsOpenSearchServiceDomain");
                context.Writer.WriteStartObject();

                var marshaller = AwsOpenSearchServiceDomainDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsOpenSearchServiceDomain, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRdsDbCluster())
            {
                context.Writer.WritePropertyName("AwsRdsDbCluster");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbCluster, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRdsDbClusterSnapshot())
            {
                context.Writer.WritePropertyName("AwsRdsDbClusterSnapshot");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbClusterSnapshotDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbClusterSnapshot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRdsDbInstance())
            {
                context.Writer.WritePropertyName("AwsRdsDbInstance");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbInstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbInstance, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRdsDbSecurityGroup())
            {
                context.Writer.WritePropertyName("AwsRdsDbSecurityGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbSecurityGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbSecurityGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRdsDbSnapshot())
            {
                context.Writer.WritePropertyName("AwsRdsDbSnapshot");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsDbSnapshotDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbSnapshot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRdsEventSubscription())
            {
                context.Writer.WritePropertyName("AwsRdsEventSubscription");
                context.Writer.WriteStartObject();

                var marshaller = AwsRdsEventSubscriptionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsEventSubscription, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRedshiftCluster())
            {
                context.Writer.WritePropertyName("AwsRedshiftCluster");
                context.Writer.WriteStartObject();

                var marshaller = AwsRedshiftClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRedshiftCluster, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRoute53HostedZone())
            {
                context.Writer.WritePropertyName("AwsRoute53HostedZone");
                context.Writer.WriteStartObject();

                var marshaller = AwsRoute53HostedZoneDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRoute53HostedZone, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsS3AccessPoint())
            {
                context.Writer.WritePropertyName("AwsS3AccessPoint");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3AccessPointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3AccessPoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsS3AccountPublicAccessBlock())
            {
                context.Writer.WritePropertyName("AwsS3AccountPublicAccessBlock");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3AccountPublicAccessBlockDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3AccountPublicAccessBlock, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsS3Bucket())
            {
                context.Writer.WritePropertyName("AwsS3Bucket");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3Bucket, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsS3Object())
            {
                context.Writer.WritePropertyName("AwsS3Object");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3ObjectDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3Object, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsSageMakerNotebookInstance())
            {
                context.Writer.WritePropertyName("AwsSageMakerNotebookInstance");
                context.Writer.WriteStartObject();

                var marshaller = AwsSageMakerNotebookInstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSageMakerNotebookInstance, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsSecretsManagerSecret())
            {
                context.Writer.WritePropertyName("AwsSecretsManagerSecret");
                context.Writer.WriteStartObject();

                var marshaller = AwsSecretsManagerSecretDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSecretsManagerSecret, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsSnsTopic())
            {
                context.Writer.WritePropertyName("AwsSnsTopic");
                context.Writer.WriteStartObject();

                var marshaller = AwsSnsTopicDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSnsTopic, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsSqsQueue())
            {
                context.Writer.WritePropertyName("AwsSqsQueue");
                context.Writer.WriteStartObject();

                var marshaller = AwsSqsQueueDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSqsQueue, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsSsmPatchCompliance())
            {
                context.Writer.WritePropertyName("AwsSsmPatchCompliance");
                context.Writer.WriteStartObject();

                var marshaller = AwsSsmPatchComplianceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSsmPatchCompliance, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsStepFunctionStateMachine())
            {
                context.Writer.WritePropertyName("AwsStepFunctionStateMachine");
                context.Writer.WriteStartObject();

                var marshaller = AwsStepFunctionStateMachineDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsStepFunctionStateMachine, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafRateBasedRule())
            {
                context.Writer.WritePropertyName("AwsWafRateBasedRule");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafRateBasedRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRateBasedRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafRegionalRateBasedRule())
            {
                context.Writer.WritePropertyName("AwsWafRegionalRateBasedRule");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafRegionalRateBasedRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalRateBasedRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafRegionalRule())
            {
                context.Writer.WritePropertyName("AwsWafRegionalRule");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafRegionalRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafRegionalRuleGroup())
            {
                context.Writer.WritePropertyName("AwsWafRegionalRuleGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafRegionalRuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalRuleGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafRegionalWebAcl())
            {
                context.Writer.WritePropertyName("AwsWafRegionalWebAcl");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafRegionalWebAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalWebAcl, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafRule())
            {
                context.Writer.WritePropertyName("AwsWafRule");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafRuleGroup())
            {
                context.Writer.WritePropertyName("AwsWafRuleGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafRuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRuleGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafv2RuleGroup())
            {
                context.Writer.WritePropertyName("AwsWafv2RuleGroup");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafv2RuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafv2RuleGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafv2WebAcl())
            {
                context.Writer.WritePropertyName("AwsWafv2WebAcl");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafv2WebAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafv2WebAcl, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsWafWebAcl())
            {
                context.Writer.WritePropertyName("AwsWafWebAcl");
                context.Writer.WriteStartObject();

                var marshaller = AwsWafWebAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafWebAcl, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsXrayEncryptionConfig())
            {
                context.Writer.WritePropertyName("AwsXrayEncryptionConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsXrayEncryptionConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsXrayEncryptionConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCodeRepository())
            {
                context.Writer.WritePropertyName("CodeRepository");
                context.Writer.WriteStartObject();

                var marshaller = CodeRepositoryDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeRepository, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("Container");
                context.Writer.WriteStartObject();

                var marshaller = ContainerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Container, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOther())
            {
                context.Writer.WritePropertyName("Other");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOtherKvp in requestObject.Other)
                {
                    context.Writer.WritePropertyName(requestObjectOtherKvp.Key);
                    var requestObjectOtherValue = requestObjectOtherKvp.Value;

                        context.Writer.WriteStringValue(requestObjectOtherValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceDetailsMarshaller Instance = new ResourceDetailsMarshaller();

    }
}