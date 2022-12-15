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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Additional details about a resource related to a finding.
    /// 
    ///  
    /// <para>
    /// To provide the details, use the object that corresponds to the resource type. For
    /// example, if the resource type is <code>AwsEc2Instance</code>, then you use the <code>AwsEc2Instance</code>
    /// object to provide the details.
    /// </para>
    ///  
    /// <para>
    /// If the type-specific object does not contain all of the fields you want to populate,
    /// then you use the <code>Other</code> object to populate those additional fields.
    /// </para>
    ///  
    /// <para>
    /// You also use the <code>Other</code> object to populate the details when the selected
    /// type does not have a corresponding object.
    /// </para>
    /// </summary>
    public partial class ResourceDetails
    {
        private AwsApiGatewayRestApiDetails _awsApiGatewayRestApi;
        private AwsApiGatewayStageDetails _awsApiGatewayStage;
        private AwsApiGatewayV2ApiDetails _awsApiGatewayV2Api;
        private AwsApiGatewayV2StageDetails _awsApiGatewayV2Stage;
        private AwsAutoScalingAutoScalingGroupDetails _awsAutoScalingAutoScalingGroup;
        private AwsAutoScalingLaunchConfigurationDetails _awsAutoScalingLaunchConfiguration;
        private AwsBackupBackupPlanDetails _awsBackupBackupPlan;
        private AwsBackupBackupVaultDetails _awsBackupBackupVault;
        private AwsBackupRecoveryPointDetails _awsBackupRecoveryPoint;
        private AwsCertificateManagerCertificateDetails _awsCertificateManagerCertificate;
        private AwsCloudFormationStackDetails _awsCloudFormationStack;
        private AwsCloudFrontDistributionDetails _awsCloudFrontDistribution;
        private AwsCloudTrailTrailDetails _awsCloudTrailTrail;
        private AwsCloudWatchAlarmDetails _awsCloudWatchAlarm;
        private AwsCodeBuildProjectDetails _awsCodeBuildProject;
        private AwsDynamoDbTableDetails _awsDynamoDbTable;
        private AwsEc2EipDetails _awsEc2Eip;
        private AwsEc2InstanceDetails _awsEc2Instance;
        private AwsEc2LaunchTemplateDetails _awsEc2LaunchTemplate;
        private AwsEc2NetworkAclDetails _awsEc2NetworkAcl;
        private AwsEc2NetworkInterfaceDetails _awsEc2NetworkInterface;
        private AwsEc2SecurityGroupDetails _awsEc2SecurityGroup;
        private AwsEc2SubnetDetails _awsEc2Subnet;
        private AwsEc2TransitGatewayDetails _awsEc2TransitGateway;
        private AwsEc2VolumeDetails _awsEc2Volume;
        private AwsEc2VpcDetails _awsEc2Vpc;
        private AwsEc2VpcEndpointServiceDetails _awsEc2VpcEndpointService;
        private AwsEc2VpcPeeringConnectionDetails _awsEc2VpcPeeringConnection;
        private AwsEc2VpnConnectionDetails _awsEc2VpnConnection;
        private AwsEcrContainerImageDetails _awsEcrContainerImage;
        private AwsEcrRepositoryDetails _awsEcrRepository;
        private AwsEcsClusterDetails _awsEcsCluster;
        private AwsEcsContainerDetails _awsEcsContainer;
        private AwsEcsServiceDetails _awsEcsService;
        private AwsEcsTaskDetails _awsEcsTask;
        private AwsEcsTaskDefinitionDetails _awsEcsTaskDefinition;
        private AwsEfsAccessPointDetails _awsEfsAccessPoint;
        private AwsEksClusterDetails _awsEksCluster;
        private AwsElasticBeanstalkEnvironmentDetails _awsElasticBeanstalkEnvironment;
        private AwsElasticsearchDomainDetails _awsElasticsearchDomain;
        private AwsElbLoadBalancerDetails _awsElbLoadBalancer;
        private AwsElbv2LoadBalancerDetails _awsElbv2LoadBalancer;
        private AwsIamAccessKeyDetails _awsIamAccessKey;
        private AwsIamGroupDetails _awsIamGroup;
        private AwsIamPolicyDetails _awsIamPolicy;
        private AwsIamRoleDetails _awsIamRole;
        private AwsIamUserDetails _awsIamUser;
        private AwsKinesisStreamDetails _awsKinesisStream;
        private AwsKmsKeyDetails _awsKmsKey;
        private AwsLambdaFunctionDetails _awsLambdaFunction;
        private AwsLambdaLayerVersionDetails _awsLambdaLayerVersion;
        private AwsNetworkFirewallFirewallDetails _awsNetworkFirewallFirewall;
        private AwsNetworkFirewallFirewallPolicyDetails _awsNetworkFirewallFirewallPolicy;
        private AwsNetworkFirewallRuleGroupDetails _awsNetworkFirewallRuleGroup;
        private AwsOpenSearchServiceDomainDetails _awsOpenSearchServiceDomain;
        private AwsRdsDbClusterDetails _awsRdsDbCluster;
        private AwsRdsDbClusterSnapshotDetails _awsRdsDbClusterSnapshot;
        private AwsRdsDbInstanceDetails _awsRdsDbInstance;
        private AwsRdsDbSecurityGroupDetails _awsRdsDbSecurityGroup;
        private AwsRdsDbSnapshotDetails _awsRdsDbSnapshot;
        private AwsRdsEventSubscriptionDetails _awsRdsEventSubscription;
        private AwsRedshiftClusterDetails _awsRedshiftCluster;
        private AwsS3AccountPublicAccessBlockDetails _awsS3AccountPublicAccessBlock;
        private AwsS3BucketDetails _awsS3Bucket;
        private AwsS3ObjectDetails _awsS3Object;
        private AwsSageMakerNotebookInstanceDetails _awsSageMakerNotebookInstance;
        private AwsSecretsManagerSecretDetails _awsSecretsManagerSecret;
        private AwsSnsTopicDetails _awsSnsTopic;
        private AwsSqsQueueDetails _awsSqsQueue;
        private AwsSsmPatchComplianceDetails _awsSsmPatchCompliance;
        private AwsWafRateBasedRuleDetails _awsWafRateBasedRule;
        private AwsWafRegionalRateBasedRuleDetails _awsWafRegionalRateBasedRule;
        private AwsWafRegionalRuleDetails _awsWafRegionalRule;
        private AwsWafRegionalRuleGroupDetails _awsWafRegionalRuleGroup;
        private AwsWafRegionalWebAclDetails _awsWafRegionalWebAcl;
        private AwsWafRuleDetails _awsWafRule;
        private AwsWafRuleGroupDetails _awsWafRuleGroup;
        private AwsWafv2RuleGroupDetails _awsWafv2RuleGroup;
        private AwsWafv2WebAclDetails _awsWafv2WebAcl;
        private AwsWafWebAclDetails _awsWafWebAcl;
        private AwsXrayEncryptionConfigDetails _awsXrayEncryptionConfig;
        private ContainerDetails _container;
        private Dictionary<string, string> _other = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AwsApiGatewayRestApi. 
        /// <para>
        /// Provides information about a REST API in version 1 of Amazon API Gateway.
        /// </para>
        /// </summary>
        public AwsApiGatewayRestApiDetails AwsApiGatewayRestApi
        {
            get { return this._awsApiGatewayRestApi; }
            set { this._awsApiGatewayRestApi = value; }
        }

        // Check to see if AwsApiGatewayRestApi property is set
        internal bool IsSetAwsApiGatewayRestApi()
        {
            return this._awsApiGatewayRestApi != null;
        }

        /// <summary>
        /// Gets and sets the property AwsApiGatewayStage. 
        /// <para>
        /// Provides information about a version 1 Amazon API Gateway stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayStageDetails AwsApiGatewayStage
        {
            get { return this._awsApiGatewayStage; }
            set { this._awsApiGatewayStage = value; }
        }

        // Check to see if AwsApiGatewayStage property is set
        internal bool IsSetAwsApiGatewayStage()
        {
            return this._awsApiGatewayStage != null;
        }

        /// <summary>
        /// Gets and sets the property AwsApiGatewayV2Api. 
        /// <para>
        /// Provides information about a version 2 API in Amazon API Gateway.
        /// </para>
        /// </summary>
        public AwsApiGatewayV2ApiDetails AwsApiGatewayV2Api
        {
            get { return this._awsApiGatewayV2Api; }
            set { this._awsApiGatewayV2Api = value; }
        }

        // Check to see if AwsApiGatewayV2Api property is set
        internal bool IsSetAwsApiGatewayV2Api()
        {
            return this._awsApiGatewayV2Api != null;
        }

        /// <summary>
        /// Gets and sets the property AwsApiGatewayV2Stage. 
        /// <para>
        /// Provides information about a version 2 stage for Amazon API Gateway.
        /// </para>
        /// </summary>
        public AwsApiGatewayV2StageDetails AwsApiGatewayV2Stage
        {
            get { return this._awsApiGatewayV2Stage; }
            set { this._awsApiGatewayV2Stage = value; }
        }

        // Check to see if AwsApiGatewayV2Stage property is set
        internal bool IsSetAwsApiGatewayV2Stage()
        {
            return this._awsApiGatewayV2Stage != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAutoScalingAutoScalingGroup. 
        /// <para>
        /// Details for an autoscaling group.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupDetails AwsAutoScalingAutoScalingGroup
        {
            get { return this._awsAutoScalingAutoScalingGroup; }
            set { this._awsAutoScalingAutoScalingGroup = value; }
        }

        // Check to see if AwsAutoScalingAutoScalingGroup property is set
        internal bool IsSetAwsAutoScalingAutoScalingGroup()
        {
            return this._awsAutoScalingAutoScalingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAutoScalingLaunchConfiguration. 
        /// <para>
        /// Provides details about a launch configuration.
        /// </para>
        /// </summary>
        public AwsAutoScalingLaunchConfigurationDetails AwsAutoScalingLaunchConfiguration
        {
            get { return this._awsAutoScalingLaunchConfiguration; }
            set { this._awsAutoScalingLaunchConfiguration = value; }
        }

        // Check to see if AwsAutoScalingLaunchConfiguration property is set
        internal bool IsSetAwsAutoScalingLaunchConfiguration()
        {
            return this._awsAutoScalingLaunchConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AwsBackupBackupPlan. 
        /// <para>
        /// Provides details about an Backup backup plan. 
        /// </para>
        /// </summary>
        public AwsBackupBackupPlanDetails AwsBackupBackupPlan
        {
            get { return this._awsBackupBackupPlan; }
            set { this._awsBackupBackupPlan = value; }
        }

        // Check to see if AwsBackupBackupPlan property is set
        internal bool IsSetAwsBackupBackupPlan()
        {
            return this._awsBackupBackupPlan != null;
        }

        /// <summary>
        /// Gets and sets the property AwsBackupBackupVault. 
        /// <para>
        /// Provides details about an Backup backup vault. 
        /// </para>
        /// </summary>
        public AwsBackupBackupVaultDetails AwsBackupBackupVault
        {
            get { return this._awsBackupBackupVault; }
            set { this._awsBackupBackupVault = value; }
        }

        // Check to see if AwsBackupBackupVault property is set
        internal bool IsSetAwsBackupBackupVault()
        {
            return this._awsBackupBackupVault != null;
        }

        /// <summary>
        /// Gets and sets the property AwsBackupRecoveryPoint. 
        /// <para>
        /// Provides details about an Backup backup, or recovery point. 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointDetails AwsBackupRecoveryPoint
        {
            get { return this._awsBackupRecoveryPoint; }
            set { this._awsBackupRecoveryPoint = value; }
        }

        // Check to see if AwsBackupRecoveryPoint property is set
        internal bool IsSetAwsBackupRecoveryPoint()
        {
            return this._awsBackupRecoveryPoint != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCertificateManagerCertificate. 
        /// <para>
        /// Provides details about an Certificate Manager certificate.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateDetails AwsCertificateManagerCertificate
        {
            get { return this._awsCertificateManagerCertificate; }
            set { this._awsCertificateManagerCertificate = value; }
        }

        // Check to see if AwsCertificateManagerCertificate property is set
        internal bool IsSetAwsCertificateManagerCertificate()
        {
            return this._awsCertificateManagerCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCloudFormationStack. 
        /// <para>
        /// Details about an CloudFormation stack. A stack is a collection of Amazon Web Services
        /// resources that you can manage as a single unit.
        /// </para>
        /// </summary>
        public AwsCloudFormationStackDetails AwsCloudFormationStack
        {
            get { return this._awsCloudFormationStack; }
            set { this._awsCloudFormationStack = value; }
        }

        // Check to see if AwsCloudFormationStack property is set
        internal bool IsSetAwsCloudFormationStack()
        {
            return this._awsCloudFormationStack != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCloudFrontDistribution. 
        /// <para>
        /// Details about a CloudFront distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionDetails AwsCloudFrontDistribution
        {
            get { return this._awsCloudFrontDistribution; }
            set { this._awsCloudFrontDistribution = value; }
        }

        // Check to see if AwsCloudFrontDistribution property is set
        internal bool IsSetAwsCloudFrontDistribution()
        {
            return this._awsCloudFrontDistribution != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCloudTrailTrail. 
        /// <para>
        /// Provides details about a CloudTrail trail.
        /// </para>
        /// </summary>
        public AwsCloudTrailTrailDetails AwsCloudTrailTrail
        {
            get { return this._awsCloudTrailTrail; }
            set { this._awsCloudTrailTrail = value; }
        }

        // Check to see if AwsCloudTrailTrail property is set
        internal bool IsSetAwsCloudTrailTrail()
        {
            return this._awsCloudTrailTrail != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCloudWatchAlarm. 
        /// <para>
        /// Details about an Amazon CloudWatch alarm. An alarm allows you to monitor and receive
        /// alerts about your Amazon Web Services resources and applications across multiple Regions.
        /// </para>
        /// </summary>
        public AwsCloudWatchAlarmDetails AwsCloudWatchAlarm
        {
            get { return this._awsCloudWatchAlarm; }
            set { this._awsCloudWatchAlarm = value; }
        }

        // Check to see if AwsCloudWatchAlarm property is set
        internal bool IsSetAwsCloudWatchAlarm()
        {
            return this._awsCloudWatchAlarm != null;
        }

        /// <summary>
        /// Gets and sets the property AwsCodeBuildProject. 
        /// <para>
        /// Details for an CodeBuild project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectDetails AwsCodeBuildProject
        {
            get { return this._awsCodeBuildProject; }
            set { this._awsCodeBuildProject = value; }
        }

        // Check to see if AwsCodeBuildProject property is set
        internal bool IsSetAwsCodeBuildProject()
        {
            return this._awsCodeBuildProject != null;
        }

        /// <summary>
        /// Gets and sets the property AwsDynamoDbTable. 
        /// <para>
        /// Details about a DynamoDB table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableDetails AwsDynamoDbTable
        {
            get { return this._awsDynamoDbTable; }
            set { this._awsDynamoDbTable = value; }
        }

        // Check to see if AwsDynamoDbTable property is set
        internal bool IsSetAwsDynamoDbTable()
        {
            return this._awsDynamoDbTable != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2Eip. 
        /// <para>
        /// Details about an Elastic IP address.
        /// </para>
        /// </summary>
        public AwsEc2EipDetails AwsEc2Eip
        {
            get { return this._awsEc2Eip; }
            set { this._awsEc2Eip = value; }
        }

        // Check to see if AwsEc2Eip property is set
        internal bool IsSetAwsEc2Eip()
        {
            return this._awsEc2Eip != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2Instance. 
        /// <para>
        /// Details about an EC2 instance related to a finding.
        /// </para>
        /// </summary>
        public AwsEc2InstanceDetails AwsEc2Instance
        {
            get { return this._awsEc2Instance; }
            set { this._awsEc2Instance = value; }
        }

        // Check to see if AwsEc2Instance property is set
        internal bool IsSetAwsEc2Instance()
        {
            return this._awsEc2Instance != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2LaunchTemplate.
        /// </summary>
        public AwsEc2LaunchTemplateDetails AwsEc2LaunchTemplate
        {
            get { return this._awsEc2LaunchTemplate; }
            set { this._awsEc2LaunchTemplate = value; }
        }

        // Check to see if AwsEc2LaunchTemplate property is set
        internal bool IsSetAwsEc2LaunchTemplate()
        {
            return this._awsEc2LaunchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkAcl. 
        /// <para>
        /// Details about an EC2 network access control list (ACL).
        /// </para>
        /// </summary>
        public AwsEc2NetworkAclDetails AwsEc2NetworkAcl
        {
            get { return this._awsEc2NetworkAcl; }
            set { this._awsEc2NetworkAcl = value; }
        }

        // Check to see if AwsEc2NetworkAcl property is set
        internal bool IsSetAwsEc2NetworkAcl()
        {
            return this._awsEc2NetworkAcl != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkInterface. 
        /// <para>
        /// Details for an EC2 network interface.
        /// </para>
        /// </summary>
        public AwsEc2NetworkInterfaceDetails AwsEc2NetworkInterface
        {
            get { return this._awsEc2NetworkInterface; }
            set { this._awsEc2NetworkInterface = value; }
        }

        // Check to see if AwsEc2NetworkInterface property is set
        internal bool IsSetAwsEc2NetworkInterface()
        {
            return this._awsEc2NetworkInterface != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2SecurityGroup. 
        /// <para>
        /// Details for an EC2 security group.
        /// </para>
        /// </summary>
        public AwsEc2SecurityGroupDetails AwsEc2SecurityGroup
        {
            get { return this._awsEc2SecurityGroup; }
            set { this._awsEc2SecurityGroup = value; }
        }

        // Check to see if AwsEc2SecurityGroup property is set
        internal bool IsSetAwsEc2SecurityGroup()
        {
            return this._awsEc2SecurityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2Subnet. 
        /// <para>
        /// Details about a subnet in Amazon EC2.
        /// </para>
        /// </summary>
        public AwsEc2SubnetDetails AwsEc2Subnet
        {
            get { return this._awsEc2Subnet; }
            set { this._awsEc2Subnet = value; }
        }

        // Check to see if AwsEc2Subnet property is set
        internal bool IsSetAwsEc2Subnet()
        {
            return this._awsEc2Subnet != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2TransitGateway. 
        /// <para>
        /// Details about an Amazon EC2 transit gateway that interconnects your virtual private
        /// clouds (VPC) and on-premises networks.
        /// </para>
        /// </summary>
        public AwsEc2TransitGatewayDetails AwsEc2TransitGateway
        {
            get { return this._awsEc2TransitGateway; }
            set { this._awsEc2TransitGateway = value; }
        }

        // Check to see if AwsEc2TransitGateway property is set
        internal bool IsSetAwsEc2TransitGateway()
        {
            return this._awsEc2TransitGateway != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2Volume. 
        /// <para>
        /// Details for an Amazon EC2 volume.
        /// </para>
        /// </summary>
        public AwsEc2VolumeDetails AwsEc2Volume
        {
            get { return this._awsEc2Volume; }
            set { this._awsEc2Volume = value; }
        }

        // Check to see if AwsEc2Volume property is set
        internal bool IsSetAwsEc2Volume()
        {
            return this._awsEc2Volume != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2Vpc. 
        /// <para>
        /// Details for an Amazon EC2 VPC.
        /// </para>
        /// </summary>
        public AwsEc2VpcDetails AwsEc2Vpc
        {
            get { return this._awsEc2Vpc; }
            set { this._awsEc2Vpc = value; }
        }

        // Check to see if AwsEc2Vpc property is set
        internal bool IsSetAwsEc2Vpc()
        {
            return this._awsEc2Vpc != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2VpcEndpointService. 
        /// <para>
        /// Details about the service configuration for a VPC endpoint service.
        /// </para>
        /// </summary>
        public AwsEc2VpcEndpointServiceDetails AwsEc2VpcEndpointService
        {
            get { return this._awsEc2VpcEndpointService; }
            set { this._awsEc2VpcEndpointService = value; }
        }

        // Check to see if AwsEc2VpcEndpointService property is set
        internal bool IsSetAwsEc2VpcEndpointService()
        {
            return this._awsEc2VpcEndpointService != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2VpcPeeringConnection. 
        /// <para>
        /// Details about an Amazon EC2 VPC peering connection. A VPC peering connection is a
        /// networking connection between two VPCs that enables you to route traffic between them
        /// privately. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionDetails AwsEc2VpcPeeringConnection
        {
            get { return this._awsEc2VpcPeeringConnection; }
            set { this._awsEc2VpcPeeringConnection = value; }
        }

        // Check to see if AwsEc2VpcPeeringConnection property is set
        internal bool IsSetAwsEc2VpcPeeringConnection()
        {
            return this._awsEc2VpcPeeringConnection != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEc2VpnConnection. 
        /// <para>
        /// Details about an Amazon EC2 VPN connection.
        /// </para>
        /// </summary>
        public AwsEc2VpnConnectionDetails AwsEc2VpnConnection
        {
            get { return this._awsEc2VpnConnection; }
            set { this._awsEc2VpnConnection = value; }
        }

        // Check to see if AwsEc2VpnConnection property is set
        internal bool IsSetAwsEc2VpnConnection()
        {
            return this._awsEc2VpnConnection != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcrContainerImage. 
        /// <para>
        /// Information about an Amazon ECR image.
        /// </para>
        /// </summary>
        public AwsEcrContainerImageDetails AwsEcrContainerImage
        {
            get { return this._awsEcrContainerImage; }
            set { this._awsEcrContainerImage = value; }
        }

        // Check to see if AwsEcrContainerImage property is set
        internal bool IsSetAwsEcrContainerImage()
        {
            return this._awsEcrContainerImage != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcrRepository. 
        /// <para>
        /// Information about an Amazon Elastic Container Registry repository.
        /// </para>
        /// </summary>
        public AwsEcrRepositoryDetails AwsEcrRepository
        {
            get { return this._awsEcrRepository; }
            set { this._awsEcrRepository = value; }
        }

        // Check to see if AwsEcrRepository property is set
        internal bool IsSetAwsEcrRepository()
        {
            return this._awsEcrRepository != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcsCluster. 
        /// <para>
        /// Details about an Amazon ECS cluster.
        /// </para>
        /// </summary>
        public AwsEcsClusterDetails AwsEcsCluster
        {
            get { return this._awsEcsCluster; }
            set { this._awsEcsCluster = value; }
        }

        // Check to see if AwsEcsCluster property is set
        internal bool IsSetAwsEcsCluster()
        {
            return this._awsEcsCluster != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcsContainer. 
        /// <para>
        /// Provides information about a Docker container that's part of a task. 
        /// </para>
        /// </summary>
        public AwsEcsContainerDetails AwsEcsContainer
        {
            get { return this._awsEcsContainer; }
            set { this._awsEcsContainer = value; }
        }

        // Check to see if AwsEcsContainer property is set
        internal bool IsSetAwsEcsContainer()
        {
            return this._awsEcsContainer != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcsService. 
        /// <para>
        /// Details about a service within an ECS cluster.
        /// </para>
        /// </summary>
        public AwsEcsServiceDetails AwsEcsService
        {
            get { return this._awsEcsService; }
            set { this._awsEcsService = value; }
        }

        // Check to see if AwsEcsService property is set
        internal bool IsSetAwsEcsService()
        {
            return this._awsEcsService != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcsTask. 
        /// <para>
        /// Details about a task in a cluster. 
        /// </para>
        /// </summary>
        public AwsEcsTaskDetails AwsEcsTask
        {
            get { return this._awsEcsTask; }
            set { this._awsEcsTask = value; }
        }

        // Check to see if AwsEcsTask property is set
        internal bool IsSetAwsEcsTask()
        {
            return this._awsEcsTask != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEcsTaskDefinition. 
        /// <para>
        /// Details about a task definition. A task definition describes the container and volume
        /// definitions of an Amazon Elastic Container Service task.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionDetails AwsEcsTaskDefinition
        {
            get { return this._awsEcsTaskDefinition; }
            set { this._awsEcsTaskDefinition = value; }
        }

        // Check to see if AwsEcsTaskDefinition property is set
        internal bool IsSetAwsEcsTaskDefinition()
        {
            return this._awsEcsTaskDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEfsAccessPoint. 
        /// <para>
        /// Details about an Amazon EFS access point. An access point is an application-specific
        /// view into an EFS file system that applies an operating system user and group, and
        /// a file system path, to any file system request made through the access point. 
        /// </para>
        /// </summary>
        public AwsEfsAccessPointDetails AwsEfsAccessPoint
        {
            get { return this._awsEfsAccessPoint; }
            set { this._awsEfsAccessPoint = value; }
        }

        // Check to see if AwsEfsAccessPoint property is set
        internal bool IsSetAwsEfsAccessPoint()
        {
            return this._awsEfsAccessPoint != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEksCluster. 
        /// <para>
        /// Details about an Amazon EKS cluster.
        /// </para>
        /// </summary>
        public AwsEksClusterDetails AwsEksCluster
        {
            get { return this._awsEksCluster; }
            set { this._awsEksCluster = value; }
        }

        // Check to see if AwsEksCluster property is set
        internal bool IsSetAwsEksCluster()
        {
            return this._awsEksCluster != null;
        }

        /// <summary>
        /// Gets and sets the property AwsElasticBeanstalkEnvironment. 
        /// <para>
        /// Details about an Elastic Beanstalk environment.
        /// </para>
        /// </summary>
        public AwsElasticBeanstalkEnvironmentDetails AwsElasticBeanstalkEnvironment
        {
            get { return this._awsElasticBeanstalkEnvironment; }
            set { this._awsElasticBeanstalkEnvironment = value; }
        }

        // Check to see if AwsElasticBeanstalkEnvironment property is set
        internal bool IsSetAwsElasticBeanstalkEnvironment()
        {
            return this._awsElasticBeanstalkEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property AwsElasticsearchDomain. 
        /// <para>
        /// Details for an Elasticsearch domain.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainDetails AwsElasticsearchDomain
        {
            get { return this._awsElasticsearchDomain; }
            set { this._awsElasticsearchDomain = value; }
        }

        // Check to see if AwsElasticsearchDomain property is set
        internal bool IsSetAwsElasticsearchDomain()
        {
            return this._awsElasticsearchDomain != null;
        }

        /// <summary>
        /// Gets and sets the property AwsElbLoadBalancer. 
        /// <para>
        /// Contains details about a Classic Load Balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerDetails AwsElbLoadBalancer
        {
            get { return this._awsElbLoadBalancer; }
            set { this._awsElbLoadBalancer = value; }
        }

        // Check to see if AwsElbLoadBalancer property is set
        internal bool IsSetAwsElbLoadBalancer()
        {
            return this._awsElbLoadBalancer != null;
        }

        /// <summary>
        /// Gets and sets the property AwsElbv2LoadBalancer. 
        /// <para>
        /// Details about a load balancer.
        /// </para>
        /// </summary>
        public AwsElbv2LoadBalancerDetails AwsElbv2LoadBalancer
        {
            get { return this._awsElbv2LoadBalancer; }
            set { this._awsElbv2LoadBalancer = value; }
        }

        // Check to see if AwsElbv2LoadBalancer property is set
        internal bool IsSetAwsElbv2LoadBalancer()
        {
            return this._awsElbv2LoadBalancer != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamAccessKey. 
        /// <para>
        /// Details about an IAM access key related to a finding.
        /// </para>
        /// </summary>
        public AwsIamAccessKeyDetails AwsIamAccessKey
        {
            get { return this._awsIamAccessKey; }
            set { this._awsIamAccessKey = value; }
        }

        // Check to see if AwsIamAccessKey property is set
        internal bool IsSetAwsIamAccessKey()
        {
            return this._awsIamAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamGroup. 
        /// <para>
        /// Contains details about an IAM group.
        /// </para>
        /// </summary>
        public AwsIamGroupDetails AwsIamGroup
        {
            get { return this._awsIamGroup; }
            set { this._awsIamGroup = value; }
        }

        // Check to see if AwsIamGroup property is set
        internal bool IsSetAwsIamGroup()
        {
            return this._awsIamGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamPolicy. 
        /// <para>
        /// Details about an IAM permissions policy.
        /// </para>
        /// </summary>
        public AwsIamPolicyDetails AwsIamPolicy
        {
            get { return this._awsIamPolicy; }
            set { this._awsIamPolicy = value; }
        }

        // Check to see if AwsIamPolicy property is set
        internal bool IsSetAwsIamPolicy()
        {
            return this._awsIamPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamRole. 
        /// <para>
        /// Details about an IAM role.
        /// </para>
        /// </summary>
        public AwsIamRoleDetails AwsIamRole
        {
            get { return this._awsIamRole; }
            set { this._awsIamRole = value; }
        }

        // Check to see if AwsIamRole property is set
        internal bool IsSetAwsIamRole()
        {
            return this._awsIamRole != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIamUser. 
        /// <para>
        /// Details about an IAM user.
        /// </para>
        /// </summary>
        public AwsIamUserDetails AwsIamUser
        {
            get { return this._awsIamUser; }
            set { this._awsIamUser = value; }
        }

        // Check to see if AwsIamUser property is set
        internal bool IsSetAwsIamUser()
        {
            return this._awsIamUser != null;
        }

        /// <summary>
        /// Gets and sets the property AwsKinesisStream. 
        /// <para>
        /// Details about an Amazon Kinesis data stream.
        /// </para>
        /// </summary>
        public AwsKinesisStreamDetails AwsKinesisStream
        {
            get { return this._awsKinesisStream; }
            set { this._awsKinesisStream = value; }
        }

        // Check to see if AwsKinesisStream property is set
        internal bool IsSetAwsKinesisStream()
        {
            return this._awsKinesisStream != null;
        }

        /// <summary>
        /// Gets and sets the property AwsKmsKey. 
        /// <para>
        /// Details about an KMS key.
        /// </para>
        /// </summary>
        public AwsKmsKeyDetails AwsKmsKey
        {
            get { return this._awsKmsKey; }
            set { this._awsKmsKey = value; }
        }

        // Check to see if AwsKmsKey property is set
        internal bool IsSetAwsKmsKey()
        {
            return this._awsKmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property AwsLambdaFunction. 
        /// <para>
        /// Details about a Lambda function.
        /// </para>
        /// </summary>
        public AwsLambdaFunctionDetails AwsLambdaFunction
        {
            get { return this._awsLambdaFunction; }
            set { this._awsLambdaFunction = value; }
        }

        // Check to see if AwsLambdaFunction property is set
        internal bool IsSetAwsLambdaFunction()
        {
            return this._awsLambdaFunction != null;
        }

        /// <summary>
        /// Gets and sets the property AwsLambdaLayerVersion. 
        /// <para>
        /// Details for a Lambda layer version.
        /// </para>
        /// </summary>
        public AwsLambdaLayerVersionDetails AwsLambdaLayerVersion
        {
            get { return this._awsLambdaLayerVersion; }
            set { this._awsLambdaLayerVersion = value; }
        }

        // Check to see if AwsLambdaLayerVersion property is set
        internal bool IsSetAwsLambdaLayerVersion()
        {
            return this._awsLambdaLayerVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AwsNetworkFirewallFirewall. 
        /// <para>
        /// Details about an Network Firewall firewall.
        /// </para>
        /// </summary>
        public AwsNetworkFirewallFirewallDetails AwsNetworkFirewallFirewall
        {
            get { return this._awsNetworkFirewallFirewall; }
            set { this._awsNetworkFirewallFirewall = value; }
        }

        // Check to see if AwsNetworkFirewallFirewall property is set
        internal bool IsSetAwsNetworkFirewallFirewall()
        {
            return this._awsNetworkFirewallFirewall != null;
        }

        /// <summary>
        /// Gets and sets the property AwsNetworkFirewallFirewallPolicy. 
        /// <para>
        /// Details about an Network Firewall firewall policy.
        /// </para>
        /// </summary>
        public AwsNetworkFirewallFirewallPolicyDetails AwsNetworkFirewallFirewallPolicy
        {
            get { return this._awsNetworkFirewallFirewallPolicy; }
            set { this._awsNetworkFirewallFirewallPolicy = value; }
        }

        // Check to see if AwsNetworkFirewallFirewallPolicy property is set
        internal bool IsSetAwsNetworkFirewallFirewallPolicy()
        {
            return this._awsNetworkFirewallFirewallPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AwsNetworkFirewallRuleGroup. 
        /// <para>
        /// Details about an Network Firewall rule group.
        /// </para>
        /// </summary>
        public AwsNetworkFirewallRuleGroupDetails AwsNetworkFirewallRuleGroup
        {
            get { return this._awsNetworkFirewallRuleGroup; }
            set { this._awsNetworkFirewallRuleGroup = value; }
        }

        // Check to see if AwsNetworkFirewallRuleGroup property is set
        internal bool IsSetAwsNetworkFirewallRuleGroup()
        {
            return this._awsNetworkFirewallRuleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsOpenSearchServiceDomain. 
        /// <para>
        /// Details about an Amazon OpenSearch Service domain.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainDetails AwsOpenSearchServiceDomain
        {
            get { return this._awsOpenSearchServiceDomain; }
            set { this._awsOpenSearchServiceDomain = value; }
        }

        // Check to see if AwsOpenSearchServiceDomain property is set
        internal bool IsSetAwsOpenSearchServiceDomain()
        {
            return this._awsOpenSearchServiceDomain != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRdsDbCluster. 
        /// <para>
        /// Details about an Amazon RDS database cluster.
        /// </para>
        /// </summary>
        public AwsRdsDbClusterDetails AwsRdsDbCluster
        {
            get { return this._awsRdsDbCluster; }
            set { this._awsRdsDbCluster = value; }
        }

        // Check to see if AwsRdsDbCluster property is set
        internal bool IsSetAwsRdsDbCluster()
        {
            return this._awsRdsDbCluster != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRdsDbClusterSnapshot. 
        /// <para>
        /// Details about an Amazon RDS database cluster snapshot.
        /// </para>
        /// </summary>
        public AwsRdsDbClusterSnapshotDetails AwsRdsDbClusterSnapshot
        {
            get { return this._awsRdsDbClusterSnapshot; }
            set { this._awsRdsDbClusterSnapshot = value; }
        }

        // Check to see if AwsRdsDbClusterSnapshot property is set
        internal bool IsSetAwsRdsDbClusterSnapshot()
        {
            return this._awsRdsDbClusterSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRdsDbInstance. 
        /// <para>
        /// Details about an Amazon RDS database instance.
        /// </para>
        /// </summary>
        public AwsRdsDbInstanceDetails AwsRdsDbInstance
        {
            get { return this._awsRdsDbInstance; }
            set { this._awsRdsDbInstance = value; }
        }

        // Check to see if AwsRdsDbInstance property is set
        internal bool IsSetAwsRdsDbInstance()
        {
            return this._awsRdsDbInstance != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRdsDbSecurityGroup. 
        /// <para>
        /// Details about an Amazon RDS DB security group.
        /// </para>
        /// </summary>
        public AwsRdsDbSecurityGroupDetails AwsRdsDbSecurityGroup
        {
            get { return this._awsRdsDbSecurityGroup; }
            set { this._awsRdsDbSecurityGroup = value; }
        }

        // Check to see if AwsRdsDbSecurityGroup property is set
        internal bool IsSetAwsRdsDbSecurityGroup()
        {
            return this._awsRdsDbSecurityGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRdsDbSnapshot. 
        /// <para>
        /// Details about an Amazon RDS database snapshot.
        /// </para>
        /// </summary>
        public AwsRdsDbSnapshotDetails AwsRdsDbSnapshot
        {
            get { return this._awsRdsDbSnapshot; }
            set { this._awsRdsDbSnapshot = value; }
        }

        // Check to see if AwsRdsDbSnapshot property is set
        internal bool IsSetAwsRdsDbSnapshot()
        {
            return this._awsRdsDbSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRdsEventSubscription. 
        /// <para>
        /// Details about an RDS event notification subscription.
        /// </para>
        /// </summary>
        public AwsRdsEventSubscriptionDetails AwsRdsEventSubscription
        {
            get { return this._awsRdsEventSubscription; }
            set { this._awsRdsEventSubscription = value; }
        }

        // Check to see if AwsRdsEventSubscription property is set
        internal bool IsSetAwsRdsEventSubscription()
        {
            return this._awsRdsEventSubscription != null;
        }

        /// <summary>
        /// Gets and sets the property AwsRedshiftCluster. 
        /// <para>
        /// Contains details about an Amazon Redshift cluster.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterDetails AwsRedshiftCluster
        {
            get { return this._awsRedshiftCluster; }
            set { this._awsRedshiftCluster = value; }
        }

        // Check to see if AwsRedshiftCluster property is set
        internal bool IsSetAwsRedshiftCluster()
        {
            return this._awsRedshiftCluster != null;
        }

        /// <summary>
        /// Gets and sets the property AwsS3AccountPublicAccessBlock. 
        /// <para>
        /// Details about the Amazon S3 Public Access Block configuration for an account.
        /// </para>
        /// </summary>
        public AwsS3AccountPublicAccessBlockDetails AwsS3AccountPublicAccessBlock
        {
            get { return this._awsS3AccountPublicAccessBlock; }
            set { this._awsS3AccountPublicAccessBlock = value; }
        }

        // Check to see if AwsS3AccountPublicAccessBlock property is set
        internal bool IsSetAwsS3AccountPublicAccessBlock()
        {
            return this._awsS3AccountPublicAccessBlock != null;
        }

        /// <summary>
        /// Gets and sets the property AwsS3Bucket. 
        /// <para>
        /// Details about an S3 bucket related to a finding.
        /// </para>
        /// </summary>
        public AwsS3BucketDetails AwsS3Bucket
        {
            get { return this._awsS3Bucket; }
            set { this._awsS3Bucket = value; }
        }

        // Check to see if AwsS3Bucket property is set
        internal bool IsSetAwsS3Bucket()
        {
            return this._awsS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property AwsS3Object. 
        /// <para>
        /// Details about an S3 object related to a finding.
        /// </para>
        /// </summary>
        public AwsS3ObjectDetails AwsS3Object
        {
            get { return this._awsS3Object; }
            set { this._awsS3Object = value; }
        }

        // Check to see if AwsS3Object property is set
        internal bool IsSetAwsS3Object()
        {
            return this._awsS3Object != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSageMakerNotebookInstance.
        /// </summary>
        public AwsSageMakerNotebookInstanceDetails AwsSageMakerNotebookInstance
        {
            get { return this._awsSageMakerNotebookInstance; }
            set { this._awsSageMakerNotebookInstance = value; }
        }

        // Check to see if AwsSageMakerNotebookInstance property is set
        internal bool IsSetAwsSageMakerNotebookInstance()
        {
            return this._awsSageMakerNotebookInstance != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSecretsManagerSecret. 
        /// <para>
        /// Details about a Secrets Manager secret.
        /// </para>
        /// </summary>
        public AwsSecretsManagerSecretDetails AwsSecretsManagerSecret
        {
            get { return this._awsSecretsManagerSecret; }
            set { this._awsSecretsManagerSecret = value; }
        }

        // Check to see if AwsSecretsManagerSecret property is set
        internal bool IsSetAwsSecretsManagerSecret()
        {
            return this._awsSecretsManagerSecret != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSnsTopic. 
        /// <para>
        /// Details about an SNS topic.
        /// </para>
        /// </summary>
        public AwsSnsTopicDetails AwsSnsTopic
        {
            get { return this._awsSnsTopic; }
            set { this._awsSnsTopic = value; }
        }

        // Check to see if AwsSnsTopic property is set
        internal bool IsSetAwsSnsTopic()
        {
            return this._awsSnsTopic != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSqsQueue. 
        /// <para>
        /// Details about an SQS queue.
        /// </para>
        /// </summary>
        public AwsSqsQueueDetails AwsSqsQueue
        {
            get { return this._awsSqsQueue; }
            set { this._awsSqsQueue = value; }
        }

        // Check to see if AwsSqsQueue property is set
        internal bool IsSetAwsSqsQueue()
        {
            return this._awsSqsQueue != null;
        }

        /// <summary>
        /// Gets and sets the property AwsSsmPatchCompliance. 
        /// <para>
        /// Provides information about the state of a patch on an instance based on the patch
        /// baseline that was used to patch the instance.
        /// </para>
        /// </summary>
        public AwsSsmPatchComplianceDetails AwsSsmPatchCompliance
        {
            get { return this._awsSsmPatchCompliance; }
            set { this._awsSsmPatchCompliance = value; }
        }

        // Check to see if AwsSsmPatchCompliance property is set
        internal bool IsSetAwsSsmPatchCompliance()
        {
            return this._awsSsmPatchCompliance != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafRateBasedRule. 
        /// <para>
        /// Details about a rate-based rule for global resources.
        /// </para>
        /// </summary>
        public AwsWafRateBasedRuleDetails AwsWafRateBasedRule
        {
            get { return this._awsWafRateBasedRule; }
            set { this._awsWafRateBasedRule = value; }
        }

        // Check to see if AwsWafRateBasedRule property is set
        internal bool IsSetAwsWafRateBasedRule()
        {
            return this._awsWafRateBasedRule != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafRegionalRateBasedRule. 
        /// <para>
        /// Details about a rate-based rule for Regional resources.
        /// </para>
        /// </summary>
        public AwsWafRegionalRateBasedRuleDetails AwsWafRegionalRateBasedRule
        {
            get { return this._awsWafRegionalRateBasedRule; }
            set { this._awsWafRegionalRateBasedRule = value; }
        }

        // Check to see if AwsWafRegionalRateBasedRule property is set
        internal bool IsSetAwsWafRegionalRateBasedRule()
        {
            return this._awsWafRegionalRateBasedRule != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafRegionalRule. 
        /// <para>
        /// Details about an WAF rule for Regional resources. 
        /// </para>
        /// </summary>
        public AwsWafRegionalRuleDetails AwsWafRegionalRule
        {
            get { return this._awsWafRegionalRule; }
            set { this._awsWafRegionalRule = value; }
        }

        // Check to see if AwsWafRegionalRule property is set
        internal bool IsSetAwsWafRegionalRule()
        {
            return this._awsWafRegionalRule != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafRegionalRuleGroup. 
        /// <para>
        /// Details about an WAF rule group for Regional resources. 
        /// </para>
        /// </summary>
        public AwsWafRegionalRuleGroupDetails AwsWafRegionalRuleGroup
        {
            get { return this._awsWafRegionalRuleGroup; }
            set { this._awsWafRegionalRuleGroup = value; }
        }

        // Check to see if AwsWafRegionalRuleGroup property is set
        internal bool IsSetAwsWafRegionalRuleGroup()
        {
            return this._awsWafRegionalRuleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafRegionalWebAcl. 
        /// <para>
        /// Details about an WAF web access control list (web ACL) for Regional resources. 
        /// </para>
        /// </summary>
        public AwsWafRegionalWebAclDetails AwsWafRegionalWebAcl
        {
            get { return this._awsWafRegionalWebAcl; }
            set { this._awsWafRegionalWebAcl = value; }
        }

        // Check to see if AwsWafRegionalWebAcl property is set
        internal bool IsSetAwsWafRegionalWebAcl()
        {
            return this._awsWafRegionalWebAcl != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafRule. 
        /// <para>
        /// Details about an WAF rule for global resources. 
        /// </para>
        /// </summary>
        public AwsWafRuleDetails AwsWafRule
        {
            get { return this._awsWafRule; }
            set { this._awsWafRule = value; }
        }

        // Check to see if AwsWafRule property is set
        internal bool IsSetAwsWafRule()
        {
            return this._awsWafRule != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafRuleGroup. 
        /// <para>
        /// Details about an WAF rule group for global resources. 
        /// </para>
        /// </summary>
        public AwsWafRuleGroupDetails AwsWafRuleGroup
        {
            get { return this._awsWafRuleGroup; }
            set { this._awsWafRuleGroup = value; }
        }

        // Check to see if AwsWafRuleGroup property is set
        internal bool IsSetAwsWafRuleGroup()
        {
            return this._awsWafRuleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafv2RuleGroup.
        /// </summary>
        public AwsWafv2RuleGroupDetails AwsWafv2RuleGroup
        {
            get { return this._awsWafv2RuleGroup; }
            set { this._awsWafv2RuleGroup = value; }
        }

        // Check to see if AwsWafv2RuleGroup property is set
        internal bool IsSetAwsWafv2RuleGroup()
        {
            return this._awsWafv2RuleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafv2WebAcl.
        /// </summary>
        public AwsWafv2WebAclDetails AwsWafv2WebAcl
        {
            get { return this._awsWafv2WebAcl; }
            set { this._awsWafv2WebAcl = value; }
        }

        // Check to see if AwsWafv2WebAcl property is set
        internal bool IsSetAwsWafv2WebAcl()
        {
            return this._awsWafv2WebAcl != null;
        }

        /// <summary>
        /// Gets and sets the property AwsWafWebAcl. 
        /// <para>
        /// Details for an WAF web ACL.
        /// </para>
        /// </summary>
        public AwsWafWebAclDetails AwsWafWebAcl
        {
            get { return this._awsWafWebAcl; }
            set { this._awsWafWebAcl = value; }
        }

        // Check to see if AwsWafWebAcl property is set
        internal bool IsSetAwsWafWebAcl()
        {
            return this._awsWafWebAcl != null;
        }

        /// <summary>
        /// Gets and sets the property AwsXrayEncryptionConfig. 
        /// <para>
        /// Information about the encryption configuration for X-Ray.
        /// </para>
        /// </summary>
        public AwsXrayEncryptionConfigDetails AwsXrayEncryptionConfig
        {
            get { return this._awsXrayEncryptionConfig; }
            set { this._awsXrayEncryptionConfig = value; }
        }

        // Check to see if AwsXrayEncryptionConfig property is set
        internal bool IsSetAwsXrayEncryptionConfig()
        {
            return this._awsXrayEncryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Details about a container resource related to a finding.
        /// </para>
        /// </summary>
        public ContainerDetails Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property Other. 
        /// <para>
        /// Details about a resource that are not available in a type-specific details object.
        /// Use the <code>Other</code> object in the following cases.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The type-specific object does not contain all of the fields that you want to populate.
        /// In this case, first use the type-specific object to populate those fields. Use the
        /// <code>Other</code> object to populate the fields that are missing from the type-specific
        /// object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resource type does not have a corresponding object. This includes resources for
        /// which the type is <code>Other</code>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Other
        {
            get { return this._other; }
            set { this._other = value; }
        }

        // Check to see if Other property is set
        internal bool IsSetOther()
        {
            return this._other != null && this._other.Count > 0; 
        }

    }
}