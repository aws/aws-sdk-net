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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceDetails Object
    /// </summary>  
    public class ResourceDetailsUnmarshaller : IJsonUnmarshaller<ResourceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResourceDetails unmarshalledObject = new ResourceDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AwsAmazonMqBroker", targetDepth, ref reader))
                {
                    var unmarshaller = AwsAmazonMqBrokerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsAmazonMqBroker = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsApiGatewayRestApi", targetDepth, ref reader))
                {
                    var unmarshaller = AwsApiGatewayRestApiDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayRestApi = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsApiGatewayStage", targetDepth, ref reader))
                {
                    var unmarshaller = AwsApiGatewayStageDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayStage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsApiGatewayV2Api", targetDepth, ref reader))
                {
                    var unmarshaller = AwsApiGatewayV2ApiDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayV2Api = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsApiGatewayV2Stage", targetDepth, ref reader))
                {
                    var unmarshaller = AwsApiGatewayV2StageDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayV2Stage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAppSyncGraphQlApi", targetDepth, ref reader))
                {
                    var unmarshaller = AwsAppSyncGraphQlApiDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsAppSyncGraphQlApi = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAthenaWorkGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsAthenaWorkGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsAthenaWorkGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAutoScalingAutoScalingGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsAutoScalingAutoScalingGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsAutoScalingAutoScalingGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAutoScalingLaunchConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = AwsAutoScalingLaunchConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsAutoScalingLaunchConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsBackupBackupPlan", targetDepth, ref reader))
                {
                    var unmarshaller = AwsBackupBackupPlanDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsBackupBackupPlan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsBackupBackupVault", targetDepth, ref reader))
                {
                    var unmarshaller = AwsBackupBackupVaultDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsBackupBackupVault = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsBackupRecoveryPoint", targetDepth, ref reader))
                {
                    var unmarshaller = AwsBackupRecoveryPointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsBackupRecoveryPoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsCertificateManagerCertificate", targetDepth, ref reader))
                {
                    var unmarshaller = AwsCertificateManagerCertificateDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCertificateManagerCertificate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsCloudFormationStack", targetDepth, ref reader))
                {
                    var unmarshaller = AwsCloudFormationStackDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudFormationStack = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsCloudFrontDistribution", targetDepth, ref reader))
                {
                    var unmarshaller = AwsCloudFrontDistributionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudFrontDistribution = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsCloudTrailTrail", targetDepth, ref reader))
                {
                    var unmarshaller = AwsCloudTrailTrailDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudTrailTrail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsCloudWatchAlarm", targetDepth, ref reader))
                {
                    var unmarshaller = AwsCloudWatchAlarmDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudWatchAlarm = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsCodeBuildProject", targetDepth, ref reader))
                {
                    var unmarshaller = AwsCodeBuildProjectDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCodeBuildProject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsDmsEndpoint", targetDepth, ref reader))
                {
                    var unmarshaller = AwsDmsEndpointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsDmsEndpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsDmsReplicationInstance", targetDepth, ref reader))
                {
                    var unmarshaller = AwsDmsReplicationInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsDmsReplicationInstance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsDmsReplicationTask", targetDepth, ref reader))
                {
                    var unmarshaller = AwsDmsReplicationTaskDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsDmsReplicationTask = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsDynamoDbTable", targetDepth, ref reader))
                {
                    var unmarshaller = AwsDynamoDbTableDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsDynamoDbTable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2ClientVpnEndpoint", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2ClientVpnEndpointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2ClientVpnEndpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2Eip", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2EipDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Eip = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2Instance", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2InstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Instance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2LaunchTemplate", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2LaunchTemplate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2NetworkAcl", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2NetworkAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2NetworkAcl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2NetworkInterface", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2NetworkInterfaceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2NetworkInterface = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2RouteTable", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2RouteTableDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2RouteTable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2SecurityGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2SecurityGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2SecurityGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2Subnet", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2SubnetDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Subnet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2TransitGateway", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2TransitGatewayDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2TransitGateway = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2Volume", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VolumeDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Volume = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2Vpc", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VpcDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Vpc = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2VpcEndpointService", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VpcEndpointServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2VpcEndpointService = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2VpcPeeringConnection", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VpcPeeringConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2VpcPeeringConnection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEc2VpnConnection", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEc2VpnConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2VpnConnection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEcrContainerImage", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEcrContainerImageDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcrContainerImage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEcrRepository", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEcrRepositoryDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcrRepository = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEcsCluster", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEcsClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsCluster = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEcsContainer", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEcsContainerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsContainer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEcsService", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEcsServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsService = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEcsTask", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEcsTaskDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsTask = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEcsTaskDefinition", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEcsTaskDefinitionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsTaskDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEfsAccessPoint", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEfsAccessPointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEfsAccessPoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEksCluster", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEksClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEksCluster = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsElasticBeanstalkEnvironment", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElasticBeanstalkEnvironmentDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElasticBeanstalkEnvironment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsElasticsearchDomain", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElasticsearchDomainDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElasticsearchDomain = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsElbLoadBalancer", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElbLoadBalancerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElbLoadBalancer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsElbv2LoadBalancer", targetDepth, ref reader))
                {
                    var unmarshaller = AwsElbv2LoadBalancerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElbv2LoadBalancer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEventSchemasRegistry", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEventSchemasRegistryDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEventSchemasRegistry = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEventsEndpoint", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEventsEndpointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEventsEndpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsEventsEventbus", targetDepth, ref reader))
                {
                    var unmarshaller = AwsEventsEventbusDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEventsEventbus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsGuardDutyDetector", targetDepth, ref reader))
                {
                    var unmarshaller = AwsGuardDutyDetectorDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsGuardDutyDetector = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsIamAccessKey", targetDepth, ref reader))
                {
                    var unmarshaller = AwsIamAccessKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamAccessKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsIamGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsIamGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsIamPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = AwsIamPolicyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsIamRole", targetDepth, ref reader))
                {
                    var unmarshaller = AwsIamRoleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsIamUser", targetDepth, ref reader))
                {
                    var unmarshaller = AwsIamUserDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamUser = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsKinesisStream", targetDepth, ref reader))
                {
                    var unmarshaller = AwsKinesisStreamDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsKinesisStream = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsKmsKey", targetDepth, ref reader))
                {
                    var unmarshaller = AwsKmsKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsKmsKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsLambdaFunction", targetDepth, ref reader))
                {
                    var unmarshaller = AwsLambdaFunctionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsLambdaFunction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsLambdaLayerVersion", targetDepth, ref reader))
                {
                    var unmarshaller = AwsLambdaLayerVersionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsLambdaLayerVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsMskCluster", targetDepth, ref reader))
                {
                    var unmarshaller = AwsMskClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsMskCluster = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsNetworkFirewallFirewall", targetDepth, ref reader))
                {
                    var unmarshaller = AwsNetworkFirewallFirewallDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsNetworkFirewallFirewall = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsNetworkFirewallFirewallPolicy", targetDepth, ref reader))
                {
                    var unmarshaller = AwsNetworkFirewallFirewallPolicyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsNetworkFirewallFirewallPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsNetworkFirewallRuleGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsNetworkFirewallRuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsNetworkFirewallRuleGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsOpenSearchServiceDomain", targetDepth, ref reader))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsOpenSearchServiceDomain = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbCluster", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRdsDbClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbCluster = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbClusterSnapshot", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRdsDbClusterSnapshotDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbClusterSnapshot = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbInstance", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRdsDbInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbInstance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbSecurityGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRdsDbSecurityGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbSecurityGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbSnapshot", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRdsDbSnapshotDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbSnapshot = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRdsEventSubscription", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRdsEventSubscriptionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsEventSubscription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRedshiftCluster", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRedshiftClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRedshiftCluster = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsRoute53HostedZone", targetDepth, ref reader))
                {
                    var unmarshaller = AwsRoute53HostedZoneDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRoute53HostedZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsS3AccessPoint", targetDepth, ref reader))
                {
                    var unmarshaller = AwsS3AccessPointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3AccessPoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsS3AccountPublicAccessBlock", targetDepth, ref reader))
                {
                    var unmarshaller = AwsS3AccountPublicAccessBlockDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3AccountPublicAccessBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsS3Bucket", targetDepth, ref reader))
                {
                    var unmarshaller = AwsS3BucketDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3Bucket = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsS3Object", targetDepth, ref reader))
                {
                    var unmarshaller = AwsS3ObjectDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3Object = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsSageMakerNotebookInstance", targetDepth, ref reader))
                {
                    var unmarshaller = AwsSageMakerNotebookInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSageMakerNotebookInstance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsSecretsManagerSecret", targetDepth, ref reader))
                {
                    var unmarshaller = AwsSecretsManagerSecretDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSecretsManagerSecret = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsSnsTopic", targetDepth, ref reader))
                {
                    var unmarshaller = AwsSnsTopicDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSnsTopic = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsSqsQueue", targetDepth, ref reader))
                {
                    var unmarshaller = AwsSqsQueueDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSqsQueue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsSsmPatchCompliance", targetDepth, ref reader))
                {
                    var unmarshaller = AwsSsmPatchComplianceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSsmPatchCompliance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsStepFunctionStateMachine", targetDepth, ref reader))
                {
                    var unmarshaller = AwsStepFunctionStateMachineDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsStepFunctionStateMachine = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafRateBasedRule", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafRateBasedRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRateBasedRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalRateBasedRule", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafRegionalRateBasedRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalRateBasedRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalRule", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafRegionalRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalRuleGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafRegionalRuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalRuleGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalWebAcl", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafRegionalWebAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalWebAcl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafRule", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafRuleGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafRuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRuleGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafv2RuleGroup", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafv2RuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafv2RuleGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafv2WebAcl", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafv2WebAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafv2WebAcl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsWafWebAcl", targetDepth, ref reader))
                {
                    var unmarshaller = AwsWafWebAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafWebAcl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsXrayEncryptionConfig", targetDepth, ref reader))
                {
                    var unmarshaller = AwsXrayEncryptionConfigDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsXrayEncryptionConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AzureResource", targetDepth, ref reader))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.AzureResource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CodeRepository", targetDepth, ref reader))
                {
                    var unmarshaller = CodeRepositoryDetailsUnmarshaller.Instance;
                    unmarshalledObject.CodeRepository = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Container", targetDepth, ref reader))
                {
                    var unmarshaller = ContainerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Container = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Other", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Other = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceDetailsUnmarshaller _instance = new ResourceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}