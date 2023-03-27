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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceDetails Object
    /// </summary>  
    public class ResourceDetailsUnmarshaller : IUnmarshaller<ResourceDetails, XmlUnmarshallerContext>, IUnmarshaller<ResourceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceDetails IUnmarshaller<ResourceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResourceDetails unmarshalledObject = new ResourceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AwsApiGatewayRestApi", targetDepth))
                {
                    var unmarshaller = AwsApiGatewayRestApiDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayRestApi = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsApiGatewayStage", targetDepth))
                {
                    var unmarshaller = AwsApiGatewayStageDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayStage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsApiGatewayV2Api", targetDepth))
                {
                    var unmarshaller = AwsApiGatewayV2ApiDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayV2Api = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsApiGatewayV2Stage", targetDepth))
                {
                    var unmarshaller = AwsApiGatewayV2StageDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsApiGatewayV2Stage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsAutoScalingAutoScalingGroup", targetDepth))
                {
                    var unmarshaller = AwsAutoScalingAutoScalingGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsAutoScalingAutoScalingGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsAutoScalingLaunchConfiguration", targetDepth))
                {
                    var unmarshaller = AwsAutoScalingLaunchConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsAutoScalingLaunchConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsBackupBackupPlan", targetDepth))
                {
                    var unmarshaller = AwsBackupBackupPlanDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsBackupBackupPlan = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsBackupBackupVault", targetDepth))
                {
                    var unmarshaller = AwsBackupBackupVaultDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsBackupBackupVault = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsBackupRecoveryPoint", targetDepth))
                {
                    var unmarshaller = AwsBackupRecoveryPointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsBackupRecoveryPoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsCertificateManagerCertificate", targetDepth))
                {
                    var unmarshaller = AwsCertificateManagerCertificateDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCertificateManagerCertificate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsCloudFormationStack", targetDepth))
                {
                    var unmarshaller = AwsCloudFormationStackDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudFormationStack = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsCloudFrontDistribution", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudFrontDistribution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsCloudTrailTrail", targetDepth))
                {
                    var unmarshaller = AwsCloudTrailTrailDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudTrailTrail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsCloudWatchAlarm", targetDepth))
                {
                    var unmarshaller = AwsCloudWatchAlarmDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudWatchAlarm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsCodeBuildProject", targetDepth))
                {
                    var unmarshaller = AwsCodeBuildProjectDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCodeBuildProject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsDynamoDbTable", targetDepth))
                {
                    var unmarshaller = AwsDynamoDbTableDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsDynamoDbTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2Eip", targetDepth))
                {
                    var unmarshaller = AwsEc2EipDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Eip = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2Instance", targetDepth))
                {
                    var unmarshaller = AwsEc2InstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Instance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2LaunchTemplate", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2LaunchTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2NetworkAcl", targetDepth))
                {
                    var unmarshaller = AwsEc2NetworkAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2NetworkAcl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2NetworkInterface", targetDepth))
                {
                    var unmarshaller = AwsEc2NetworkInterfaceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2NetworkInterface = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2RouteTable", targetDepth))
                {
                    var unmarshaller = AwsEc2RouteTableDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2RouteTable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2SecurityGroup", targetDepth))
                {
                    var unmarshaller = AwsEc2SecurityGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2SecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2Subnet", targetDepth))
                {
                    var unmarshaller = AwsEc2SubnetDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Subnet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2TransitGateway", targetDepth))
                {
                    var unmarshaller = AwsEc2TransitGatewayDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2TransitGateway = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2Volume", targetDepth))
                {
                    var unmarshaller = AwsEc2VolumeDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Volume = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2Vpc", targetDepth))
                {
                    var unmarshaller = AwsEc2VpcDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Vpc = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2VpcEndpointService", targetDepth))
                {
                    var unmarshaller = AwsEc2VpcEndpointServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2VpcEndpointService = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2VpcPeeringConnection", targetDepth))
                {
                    var unmarshaller = AwsEc2VpcPeeringConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2VpcPeeringConnection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2VpnConnection", targetDepth))
                {
                    var unmarshaller = AwsEc2VpnConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2VpnConnection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEcrContainerImage", targetDepth))
                {
                    var unmarshaller = AwsEcrContainerImageDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcrContainerImage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEcrRepository", targetDepth))
                {
                    var unmarshaller = AwsEcrRepositoryDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcrRepository = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEcsCluster", targetDepth))
                {
                    var unmarshaller = AwsEcsClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsCluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEcsContainer", targetDepth))
                {
                    var unmarshaller = AwsEcsContainerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsContainer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEcsService", targetDepth))
                {
                    var unmarshaller = AwsEcsServiceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsService = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEcsTask", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsTask = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEcsTaskDefinition", targetDepth))
                {
                    var unmarshaller = AwsEcsTaskDefinitionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEcsTaskDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEfsAccessPoint", targetDepth))
                {
                    var unmarshaller = AwsEfsAccessPointDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEfsAccessPoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEksCluster", targetDepth))
                {
                    var unmarshaller = AwsEksClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEksCluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsElasticBeanstalkEnvironment", targetDepth))
                {
                    var unmarshaller = AwsElasticBeanstalkEnvironmentDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElasticBeanstalkEnvironment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsElasticsearchDomain", targetDepth))
                {
                    var unmarshaller = AwsElasticsearchDomainDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElasticsearchDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsElbLoadBalancer", targetDepth))
                {
                    var unmarshaller = AwsElbLoadBalancerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElbLoadBalancer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsElbv2LoadBalancer", targetDepth))
                {
                    var unmarshaller = AwsElbv2LoadBalancerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElbv2LoadBalancer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIamAccessKey", targetDepth))
                {
                    var unmarshaller = AwsIamAccessKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamAccessKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIamGroup", targetDepth))
                {
                    var unmarshaller = AwsIamGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIamPolicy", targetDepth))
                {
                    var unmarshaller = AwsIamPolicyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIamRole", targetDepth))
                {
                    var unmarshaller = AwsIamRoleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIamUser", targetDepth))
                {
                    var unmarshaller = AwsIamUserDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsKinesisStream", targetDepth))
                {
                    var unmarshaller = AwsKinesisStreamDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsKinesisStream = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsKmsKey", targetDepth))
                {
                    var unmarshaller = AwsKmsKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsKmsKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsLambdaFunction", targetDepth))
                {
                    var unmarshaller = AwsLambdaFunctionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsLambdaFunction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsLambdaLayerVersion", targetDepth))
                {
                    var unmarshaller = AwsLambdaLayerVersionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsLambdaLayerVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsNetworkFirewallFirewall", targetDepth))
                {
                    var unmarshaller = AwsNetworkFirewallFirewallDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsNetworkFirewallFirewall = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsNetworkFirewallFirewallPolicy", targetDepth))
                {
                    var unmarshaller = AwsNetworkFirewallFirewallPolicyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsNetworkFirewallFirewallPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsNetworkFirewallRuleGroup", targetDepth))
                {
                    var unmarshaller = AwsNetworkFirewallRuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsNetworkFirewallRuleGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsOpenSearchServiceDomain", targetDepth))
                {
                    var unmarshaller = AwsOpenSearchServiceDomainDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsOpenSearchServiceDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbCluster", targetDepth))
                {
                    var unmarshaller = AwsRdsDbClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbCluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbClusterSnapshot", targetDepth))
                {
                    var unmarshaller = AwsRdsDbClusterSnapshotDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbClusterSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbInstance", targetDepth))
                {
                    var unmarshaller = AwsRdsDbInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbSecurityGroup", targetDepth))
                {
                    var unmarshaller = AwsRdsDbSecurityGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbSecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbSnapshot", targetDepth))
                {
                    var unmarshaller = AwsRdsDbSnapshotDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRdsEventSubscription", targetDepth))
                {
                    var unmarshaller = AwsRdsEventSubscriptionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsEventSubscription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRedshiftCluster", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRedshiftCluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsS3AccountPublicAccessBlock", targetDepth))
                {
                    var unmarshaller = AwsS3AccountPublicAccessBlockDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3AccountPublicAccessBlock = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsS3Bucket", targetDepth))
                {
                    var unmarshaller = AwsS3BucketDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsS3Object", targetDepth))
                {
                    var unmarshaller = AwsS3ObjectDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3Object = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsSageMakerNotebookInstance", targetDepth))
                {
                    var unmarshaller = AwsSageMakerNotebookInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSageMakerNotebookInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsSecretsManagerSecret", targetDepth))
                {
                    var unmarshaller = AwsSecretsManagerSecretDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSecretsManagerSecret = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsSnsTopic", targetDepth))
                {
                    var unmarshaller = AwsSnsTopicDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSnsTopic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsSqsQueue", targetDepth))
                {
                    var unmarshaller = AwsSqsQueueDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSqsQueue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsSsmPatchCompliance", targetDepth))
                {
                    var unmarshaller = AwsSsmPatchComplianceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSsmPatchCompliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafRateBasedRule", targetDepth))
                {
                    var unmarshaller = AwsWafRateBasedRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRateBasedRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalRateBasedRule", targetDepth))
                {
                    var unmarshaller = AwsWafRegionalRateBasedRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalRateBasedRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalRule", targetDepth))
                {
                    var unmarshaller = AwsWafRegionalRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalRuleGroup", targetDepth))
                {
                    var unmarshaller = AwsWafRegionalRuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalRuleGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafRegionalWebAcl", targetDepth))
                {
                    var unmarshaller = AwsWafRegionalWebAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRegionalWebAcl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafRule", targetDepth))
                {
                    var unmarshaller = AwsWafRuleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafRuleGroup", targetDepth))
                {
                    var unmarshaller = AwsWafRuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafRuleGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafv2RuleGroup", targetDepth))
                {
                    var unmarshaller = AwsWafv2RuleGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafv2RuleGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafv2WebAcl", targetDepth))
                {
                    var unmarshaller = AwsWafv2WebAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafv2WebAcl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafWebAcl", targetDepth))
                {
                    var unmarshaller = AwsWafWebAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafWebAcl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsXrayEncryptionConfig", targetDepth))
                {
                    var unmarshaller = AwsXrayEncryptionConfigDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsXrayEncryptionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Container", targetDepth))
                {
                    var unmarshaller = ContainerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Container = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Other", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Other = unmarshaller.Unmarshall(context);
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