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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAwsApiGatewayRestApi())
            {
                context.Writer.WritePropertyName("AwsApiGatewayRestApi");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayRestApiDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayRestApi, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsApiGatewayStage())
            {
                context.Writer.WritePropertyName("AwsApiGatewayStage");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayStageDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayStage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsApiGatewayV2Api())
            {
                context.Writer.WritePropertyName("AwsApiGatewayV2Api");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayV2ApiDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayV2Api, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsApiGatewayV2Stage())
            {
                context.Writer.WritePropertyName("AwsApiGatewayV2Stage");
                context.Writer.WriteObjectStart();

                var marshaller = AwsApiGatewayV2StageDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsApiGatewayV2Stage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsAutoScalingAutoScalingGroup())
            {
                context.Writer.WritePropertyName("AwsAutoScalingAutoScalingGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAutoScalingAutoScalingGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAutoScalingAutoScalingGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsAutoScalingLaunchConfiguration())
            {
                context.Writer.WritePropertyName("AwsAutoScalingLaunchConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsAutoScalingLaunchConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAutoScalingLaunchConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsBackupBackupPlan())
            {
                context.Writer.WritePropertyName("AwsBackupBackupPlan");
                context.Writer.WriteObjectStart();

                var marshaller = AwsBackupBackupPlanDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsBackupBackupPlan, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsBackupBackupVault())
            {
                context.Writer.WritePropertyName("AwsBackupBackupVault");
                context.Writer.WriteObjectStart();

                var marshaller = AwsBackupBackupVaultDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsBackupBackupVault, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsBackupRecoveryPoint())
            {
                context.Writer.WritePropertyName("AwsBackupRecoveryPoint");
                context.Writer.WriteObjectStart();

                var marshaller = AwsBackupRecoveryPointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsBackupRecoveryPoint, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCertificateManagerCertificate())
            {
                context.Writer.WritePropertyName("AwsCertificateManagerCertificate");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCertificateManagerCertificateDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCertificateManagerCertificate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCloudFormationStack())
            {
                context.Writer.WritePropertyName("AwsCloudFormationStack");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCloudFormationStackDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudFormationStack, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCloudFrontDistribution())
            {
                context.Writer.WritePropertyName("AwsCloudFrontDistribution");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCloudFrontDistributionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudFrontDistribution, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCloudTrailTrail())
            {
                context.Writer.WritePropertyName("AwsCloudTrailTrail");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCloudTrailTrailDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudTrailTrail, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCloudWatchAlarm())
            {
                context.Writer.WritePropertyName("AwsCloudWatchAlarm");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCloudWatchAlarmDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCloudWatchAlarm, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsCodeBuildProject())
            {
                context.Writer.WritePropertyName("AwsCodeBuildProject");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCodeBuildProjectDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsCodeBuildProject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsDynamoDbTable())
            {
                context.Writer.WritePropertyName("AwsDynamoDbTable");
                context.Writer.WriteObjectStart();

                var marshaller = AwsDynamoDbTableDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsDynamoDbTable, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Eip())
            {
                context.Writer.WritePropertyName("AwsEc2Eip");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2EipDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Eip, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Instance())
            {
                context.Writer.WritePropertyName("AwsEc2Instance");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2InstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Instance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2LaunchTemplate())
            {
                context.Writer.WritePropertyName("AwsEc2LaunchTemplate");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2LaunchTemplate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2NetworkAcl())
            {
                context.Writer.WritePropertyName("AwsEc2NetworkAcl");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2NetworkAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2NetworkAcl, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2NetworkInterface())
            {
                context.Writer.WritePropertyName("AwsEc2NetworkInterface");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2NetworkInterfaceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2NetworkInterface, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2RouteTable())
            {
                context.Writer.WritePropertyName("AwsEc2RouteTable");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2RouteTableDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2RouteTable, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2SecurityGroup())
            {
                context.Writer.WritePropertyName("AwsEc2SecurityGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2SecurityGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2SecurityGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Subnet())
            {
                context.Writer.WritePropertyName("AwsEc2Subnet");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2SubnetDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Subnet, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2TransitGateway())
            {
                context.Writer.WritePropertyName("AwsEc2TransitGateway");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2TransitGatewayDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2TransitGateway, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Volume())
            {
                context.Writer.WritePropertyName("AwsEc2Volume");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2VolumeDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Volume, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2Vpc())
            {
                context.Writer.WritePropertyName("AwsEc2Vpc");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2VpcDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2Vpc, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2VpcEndpointService())
            {
                context.Writer.WritePropertyName("AwsEc2VpcEndpointService");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2VpcEndpointServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2VpcEndpointService, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2VpcPeeringConnection())
            {
                context.Writer.WritePropertyName("AwsEc2VpcPeeringConnection");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2VpcPeeringConnectionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2VpcPeeringConnection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEc2VpnConnection())
            {
                context.Writer.WritePropertyName("AwsEc2VpnConnection");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2VpnConnectionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEc2VpnConnection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcrContainerImage())
            {
                context.Writer.WritePropertyName("AwsEcrContainerImage");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcrContainerImageDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcrContainerImage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcrRepository())
            {
                context.Writer.WritePropertyName("AwsEcrRepository");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcrRepositoryDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcrRepository, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcsCluster())
            {
                context.Writer.WritePropertyName("AwsEcsCluster");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsCluster, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcsContainer())
            {
                context.Writer.WritePropertyName("AwsEcsContainer");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsContainerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsContainer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcsService())
            {
                context.Writer.WritePropertyName("AwsEcsService");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsServiceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsService, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcsTask())
            {
                context.Writer.WritePropertyName("AwsEcsTask");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsTask, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEcsTaskDefinition())
            {
                context.Writer.WritePropertyName("AwsEcsTaskDefinition");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsTaskDefinitionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEcsTaskDefinition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEfsAccessPoint())
            {
                context.Writer.WritePropertyName("AwsEfsAccessPoint");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEfsAccessPointDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEfsAccessPoint, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsEksCluster())
            {
                context.Writer.WritePropertyName("AwsEksCluster");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEksClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsEksCluster, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsElasticBeanstalkEnvironment())
            {
                context.Writer.WritePropertyName("AwsElasticBeanstalkEnvironment");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticBeanstalkEnvironmentDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElasticBeanstalkEnvironment, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsElasticsearchDomain())
            {
                context.Writer.WritePropertyName("AwsElasticsearchDomain");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticsearchDomainDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElasticsearchDomain, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsElbLoadBalancer())
            {
                context.Writer.WritePropertyName("AwsElbLoadBalancer");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElbLoadBalancerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElbLoadBalancer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsElbv2LoadBalancer())
            {
                context.Writer.WritePropertyName("AwsElbv2LoadBalancer");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElbv2LoadBalancerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsElbv2LoadBalancer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamAccessKey())
            {
                context.Writer.WritePropertyName("AwsIamAccessKey");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamAccessKeyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamAccessKey, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamGroup())
            {
                context.Writer.WritePropertyName("AwsIamGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamPolicy())
            {
                context.Writer.WritePropertyName("AwsIamPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamPolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamPolicy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamRole())
            {
                context.Writer.WritePropertyName("AwsIamRole");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamRoleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamRole, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsIamUser())
            {
                context.Writer.WritePropertyName("AwsIamUser");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamUserDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsIamUser, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsKinesisStream())
            {
                context.Writer.WritePropertyName("AwsKinesisStream");
                context.Writer.WriteObjectStart();

                var marshaller = AwsKinesisStreamDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsKinesisStream, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsKmsKey())
            {
                context.Writer.WritePropertyName("AwsKmsKey");
                context.Writer.WriteObjectStart();

                var marshaller = AwsKmsKeyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsKmsKey, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsLambdaFunction())
            {
                context.Writer.WritePropertyName("AwsLambdaFunction");
                context.Writer.WriteObjectStart();

                var marshaller = AwsLambdaFunctionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsLambdaFunction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsLambdaLayerVersion())
            {
                context.Writer.WritePropertyName("AwsLambdaLayerVersion");
                context.Writer.WriteObjectStart();

                var marshaller = AwsLambdaLayerVersionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsLambdaLayerVersion, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsNetworkFirewallFirewall())
            {
                context.Writer.WritePropertyName("AwsNetworkFirewallFirewall");
                context.Writer.WriteObjectStart();

                var marshaller = AwsNetworkFirewallFirewallDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsNetworkFirewallFirewall, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsNetworkFirewallFirewallPolicy())
            {
                context.Writer.WritePropertyName("AwsNetworkFirewallFirewallPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = AwsNetworkFirewallFirewallPolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsNetworkFirewallFirewallPolicy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsNetworkFirewallRuleGroup())
            {
                context.Writer.WritePropertyName("AwsNetworkFirewallRuleGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsNetworkFirewallRuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsNetworkFirewallRuleGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsOpenSearchServiceDomain())
            {
                context.Writer.WritePropertyName("AwsOpenSearchServiceDomain");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsOpenSearchServiceDomain, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRdsDbCluster())
            {
                context.Writer.WritePropertyName("AwsRdsDbCluster");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbCluster, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRdsDbClusterSnapshot())
            {
                context.Writer.WritePropertyName("AwsRdsDbClusterSnapshot");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbClusterSnapshotDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbClusterSnapshot, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRdsDbInstance())
            {
                context.Writer.WritePropertyName("AwsRdsDbInstance");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbInstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbInstance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRdsDbSecurityGroup())
            {
                context.Writer.WritePropertyName("AwsRdsDbSecurityGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbSecurityGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbSecurityGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRdsDbSnapshot())
            {
                context.Writer.WritePropertyName("AwsRdsDbSnapshot");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbSnapshotDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsDbSnapshot, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRdsEventSubscription())
            {
                context.Writer.WritePropertyName("AwsRdsEventSubscription");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsEventSubscriptionDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRdsEventSubscription, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsRedshiftCluster())
            {
                context.Writer.WritePropertyName("AwsRedshiftCluster");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRedshiftClusterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRedshiftCluster, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsS3AccountPublicAccessBlock())
            {
                context.Writer.WritePropertyName("AwsS3AccountPublicAccessBlock");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3AccountPublicAccessBlockDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3AccountPublicAccessBlock, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsS3Bucket())
            {
                context.Writer.WritePropertyName("AwsS3Bucket");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3BucketDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3Bucket, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsS3Object())
            {
                context.Writer.WritePropertyName("AwsS3Object");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3ObjectDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsS3Object, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsSageMakerNotebookInstance())
            {
                context.Writer.WritePropertyName("AwsSageMakerNotebookInstance");
                context.Writer.WriteObjectStart();

                var marshaller = AwsSageMakerNotebookInstanceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSageMakerNotebookInstance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsSecretsManagerSecret())
            {
                context.Writer.WritePropertyName("AwsSecretsManagerSecret");
                context.Writer.WriteObjectStart();

                var marshaller = AwsSecretsManagerSecretDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSecretsManagerSecret, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsSnsTopic())
            {
                context.Writer.WritePropertyName("AwsSnsTopic");
                context.Writer.WriteObjectStart();

                var marshaller = AwsSnsTopicDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSnsTopic, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsSqsQueue())
            {
                context.Writer.WritePropertyName("AwsSqsQueue");
                context.Writer.WriteObjectStart();

                var marshaller = AwsSqsQueueDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSqsQueue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsSsmPatchCompliance())
            {
                context.Writer.WritePropertyName("AwsSsmPatchCompliance");
                context.Writer.WriteObjectStart();

                var marshaller = AwsSsmPatchComplianceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsSsmPatchCompliance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafRateBasedRule())
            {
                context.Writer.WritePropertyName("AwsWafRateBasedRule");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafRateBasedRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRateBasedRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafRegionalRateBasedRule())
            {
                context.Writer.WritePropertyName("AwsWafRegionalRateBasedRule");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafRegionalRateBasedRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalRateBasedRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafRegionalRule())
            {
                context.Writer.WritePropertyName("AwsWafRegionalRule");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafRegionalRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafRegionalRuleGroup())
            {
                context.Writer.WritePropertyName("AwsWafRegionalRuleGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafRegionalRuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalRuleGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafRegionalWebAcl())
            {
                context.Writer.WritePropertyName("AwsWafRegionalWebAcl");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafRegionalWebAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRegionalWebAcl, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafRule())
            {
                context.Writer.WritePropertyName("AwsWafRule");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafRuleDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRule, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafRuleGroup())
            {
                context.Writer.WritePropertyName("AwsWafRuleGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafRuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafRuleGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafv2RuleGroup())
            {
                context.Writer.WritePropertyName("AwsWafv2RuleGroup");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2RuleGroupDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafv2RuleGroup, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafv2WebAcl())
            {
                context.Writer.WritePropertyName("AwsWafv2WebAcl");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafv2WebAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafv2WebAcl, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsWafWebAcl())
            {
                context.Writer.WritePropertyName("AwsWafWebAcl");
                context.Writer.WriteObjectStart();

                var marshaller = AwsWafWebAclDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsWafWebAcl, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAwsXrayEncryptionConfig())
            {
                context.Writer.WritePropertyName("AwsXrayEncryptionConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AwsXrayEncryptionConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsXrayEncryptionConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContainer())
            {
                context.Writer.WritePropertyName("Container");
                context.Writer.WriteObjectStart();

                var marshaller = ContainerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Container, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOther())
            {
                context.Writer.WritePropertyName("Other");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectOtherKvp in requestObject.Other)
                {
                    context.Writer.WritePropertyName(requestObjectOtherKvp.Key);
                    var requestObjectOtherValue = requestObjectOtherKvp.Value;

                        context.Writer.Write(requestObjectOtherValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceDetailsMarshaller Instance = new ResourceDetailsMarshaller();

    }
}