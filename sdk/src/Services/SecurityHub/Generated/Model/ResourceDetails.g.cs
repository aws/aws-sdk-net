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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Additional details about a resource related to a finding.
    /// 
    ///  
    /// <para>
    /// To provide the details, use the object that corresponds to the resource type. For
    /// example, if the resource type is <c>AwsEc2Instance</c>, then you use the <c>AwsEc2Instance</c>
    /// object to provide the details.
    /// </para>
    ///  
    /// <para>
    /// If the type-specific object does not contain all of the fields you want to populate,
    /// then you use the <c>Other</c> object to populate those additional fields.
    /// </para>
    ///  
    /// <para>
    /// You also use the <c>Other</c> object to populate the details when the selected type
    /// does not have a corresponding object.
    /// </para>
    /// </summary>
    public partial class ResourceDetails
    {
        /// <summary>
        /// Gets and sets the property AwsAmazonMqBroker. 
        /// <para>
        ///  Provides details about AppSync message broker. A message broker allows software applications
        /// and components to communicate using various programming languages, operating systems,
        /// and formal messaging protocols. 
        /// </para>
        /// </summary>
        public AwsAmazonMqBrokerDetails AwsAmazonMqBroker { get; set; }

        /// <summary>
        /// Checks to see if the AwsAmazonMqBroker property is set.
        /// </summary>
        internal bool IsSetAwsAmazonMqBroker() => this.AwsAmazonMqBroker != null;

        /// <summary>
        /// Gets and sets the property AwsApiGatewayRestApi. 
        /// <para>
        /// Provides information about a REST API in version 1 of Amazon API Gateway.
        /// </para>
        /// </summary>
        public AwsApiGatewayRestApiDetails AwsApiGatewayRestApi { get; set; }

        /// <summary>
        /// Checks to see if the AwsApiGatewayRestApi property is set.
        /// </summary>
        internal bool IsSetAwsApiGatewayRestApi() => this.AwsApiGatewayRestApi != null;

        /// <summary>
        /// Gets and sets the property AwsApiGatewayStage. 
        /// <para>
        /// Provides information about a version 1 Amazon API Gateway stage.
        /// </para>
        /// </summary>
        public AwsApiGatewayStageDetails AwsApiGatewayStage { get; set; }

        /// <summary>
        /// Checks to see if the AwsApiGatewayStage property is set.
        /// </summary>
        internal bool IsSetAwsApiGatewayStage() => this.AwsApiGatewayStage != null;

        /// <summary>
        /// Gets and sets the property AwsApiGatewayV2Api. 
        /// <para>
        /// Provides information about a version 2 API in Amazon API Gateway.
        /// </para>
        /// </summary>
        public AwsApiGatewayV2ApiDetails AwsApiGatewayV2Api { get; set; }

        /// <summary>
        /// Checks to see if the AwsApiGatewayV2Api property is set.
        /// </summary>
        internal bool IsSetAwsApiGatewayV2Api() => this.AwsApiGatewayV2Api != null;

        /// <summary>
        /// Gets and sets the property AwsApiGatewayV2Stage. 
        /// <para>
        /// Provides information about a version 2 stage for Amazon API Gateway.
        /// </para>
        /// </summary>
        public AwsApiGatewayV2StageDetails AwsApiGatewayV2Stage { get; set; }

        /// <summary>
        /// Checks to see if the AwsApiGatewayV2Stage property is set.
        /// </summary>
        internal bool IsSetAwsApiGatewayV2Stage() => this.AwsApiGatewayV2Stage != null;

        /// <summary>
        /// Gets and sets the property AwsAppSyncGraphQlApi. 
        /// <para>
        ///  Provides details about an AppSync Graph QL API, which lets you query multiple databases,
        /// microservices, and APIs from a single GraphQL endpoint. 
        /// </para>
        /// </summary>
        public AwsAppSyncGraphQlApiDetails AwsAppSyncGraphQlApi { get; set; }

        /// <summary>
        /// Checks to see if the AwsAppSyncGraphQlApi property is set.
        /// </summary>
        internal bool IsSetAwsAppSyncGraphQlApi() => this.AwsAppSyncGraphQlApi != null;

        /// <summary>
        /// Gets and sets the property AwsAthenaWorkGroup. 
        /// <para>
        ///  Provides information about an Amazon Athena workgroup. A workgroup helps you separate
        /// users, teams, applications, or workloads. It also helps you set limits on data processing
        /// and track costs. 
        /// </para>
        /// </summary>
        public AwsAthenaWorkGroupDetails AwsAthenaWorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsAthenaWorkGroup property is set.
        /// </summary>
        internal bool IsSetAwsAthenaWorkGroup() => this.AwsAthenaWorkGroup != null;

        /// <summary>
        /// Gets and sets the property AwsAutoScalingAutoScalingGroup. 
        /// <para>
        /// Details for an autoscaling group.
        /// </para>
        /// </summary>
        public AwsAutoScalingAutoScalingGroupDetails AwsAutoScalingAutoScalingGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsAutoScalingAutoScalingGroup property is set.
        /// </summary>
        internal bool IsSetAwsAutoScalingAutoScalingGroup() => this.AwsAutoScalingAutoScalingGroup != null;

        /// <summary>
        /// Gets and sets the property AwsAutoScalingLaunchConfiguration. 
        /// <para>
        /// Provides details about a launch configuration.
        /// </para>
        /// </summary>
        public AwsAutoScalingLaunchConfigurationDetails AwsAutoScalingLaunchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AwsAutoScalingLaunchConfiguration property is set.
        /// </summary>
        internal bool IsSetAwsAutoScalingLaunchConfiguration() => this.AwsAutoScalingLaunchConfiguration != null;

        /// <summary>
        /// Gets and sets the property AwsBackupBackupPlan. 
        /// <para>
        /// Provides details about an Backup backup plan. 
        /// </para>
        /// </summary>
        public AwsBackupBackupPlanDetails AwsBackupBackupPlan { get; set; }

        /// <summary>
        /// Checks to see if the AwsBackupBackupPlan property is set.
        /// </summary>
        internal bool IsSetAwsBackupBackupPlan() => this.AwsBackupBackupPlan != null;

        /// <summary>
        /// Gets and sets the property AwsBackupBackupVault. 
        /// <para>
        /// Provides details about an Backup backup vault. 
        /// </para>
        /// </summary>
        public AwsBackupBackupVaultDetails AwsBackupBackupVault { get; set; }

        /// <summary>
        /// Checks to see if the AwsBackupBackupVault property is set.
        /// </summary>
        internal bool IsSetAwsBackupBackupVault() => this.AwsBackupBackupVault != null;

        /// <summary>
        /// Gets and sets the property AwsBackupRecoveryPoint. 
        /// <para>
        /// Provides details about an Backup backup, or recovery point. 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointDetails AwsBackupRecoveryPoint { get; set; }

        /// <summary>
        /// Checks to see if the AwsBackupRecoveryPoint property is set.
        /// </summary>
        internal bool IsSetAwsBackupRecoveryPoint() => this.AwsBackupRecoveryPoint != null;

        /// <summary>
        /// Gets and sets the property AwsCertificateManagerCertificate. 
        /// <para>
        /// Provides details about an Certificate Manager certificate.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateDetails AwsCertificateManagerCertificate { get; set; }

        /// <summary>
        /// Checks to see if the AwsCertificateManagerCertificate property is set.
        /// </summary>
        internal bool IsSetAwsCertificateManagerCertificate() => this.AwsCertificateManagerCertificate != null;

        /// <summary>
        /// Gets and sets the property AwsCloudFormationStack. 
        /// <para>
        /// Details about an CloudFormation stack. A stack is a collection of Amazon Web Services
        /// resources that you can manage as a single unit.
        /// </para>
        /// </summary>
        public AwsCloudFormationStackDetails AwsCloudFormationStack { get; set; }

        /// <summary>
        /// Checks to see if the AwsCloudFormationStack property is set.
        /// </summary>
        internal bool IsSetAwsCloudFormationStack() => this.AwsCloudFormationStack != null;

        /// <summary>
        /// Gets and sets the property AwsCloudFrontDistribution. 
        /// <para>
        /// Details about a CloudFront distribution.
        /// </para>
        /// </summary>
        public AwsCloudFrontDistributionDetails AwsCloudFrontDistribution { get; set; }

        /// <summary>
        /// Checks to see if the AwsCloudFrontDistribution property is set.
        /// </summary>
        internal bool IsSetAwsCloudFrontDistribution() => this.AwsCloudFrontDistribution != null;

        /// <summary>
        /// Gets and sets the property AwsCloudTrailTrail. 
        /// <para>
        /// Provides details about a CloudTrail trail.
        /// </para>
        /// </summary>
        public AwsCloudTrailTrailDetails AwsCloudTrailTrail { get; set; }

        /// <summary>
        /// Checks to see if the AwsCloudTrailTrail property is set.
        /// </summary>
        internal bool IsSetAwsCloudTrailTrail() => this.AwsCloudTrailTrail != null;

        /// <summary>
        /// Gets and sets the property AwsCloudWatchAlarm. 
        /// <para>
        /// Details about an Amazon CloudWatch alarm. An alarm allows you to monitor and receive
        /// alerts about your Amazon Web Services resources and applications across multiple Regions.
        /// </para>
        /// </summary>
        public AwsCloudWatchAlarmDetails AwsCloudWatchAlarm { get; set; }

        /// <summary>
        /// Checks to see if the AwsCloudWatchAlarm property is set.
        /// </summary>
        internal bool IsSetAwsCloudWatchAlarm() => this.AwsCloudWatchAlarm != null;

        /// <summary>
        /// Gets and sets the property AwsCodeBuildProject. 
        /// <para>
        /// Details for an CodeBuild project.
        /// </para>
        /// </summary>
        public AwsCodeBuildProjectDetails AwsCodeBuildProject { get; set; }

        /// <summary>
        /// Checks to see if the AwsCodeBuildProject property is set.
        /// </summary>
        internal bool IsSetAwsCodeBuildProject() => this.AwsCodeBuildProject != null;

        /// <summary>
        /// Gets and sets the property AwsDmsEndpoint. 
        /// <para>
        ///  Provides details about an Database Migration Service (DMS) endpoint. An endpoint
        /// provides connection, data store type, and location information about your data store.
        /// </para>
        /// </summary>
        public AwsDmsEndpointDetails AwsDmsEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AwsDmsEndpoint property is set.
        /// </summary>
        internal bool IsSetAwsDmsEndpoint() => this.AwsDmsEndpoint != null;

        /// <summary>
        /// Gets and sets the property AwsDmsReplicationInstance. 
        /// <para>
        ///  Provides details about an DMS replication instance. DMS uses a replication instance
        /// to connect to your source data store, read the source data, and format the data for
        /// consumption by the target data store.
        /// </para>
        /// </summary>
        public AwsDmsReplicationInstanceDetails AwsDmsReplicationInstance { get; set; }

        /// <summary>
        /// Checks to see if the AwsDmsReplicationInstance property is set.
        /// </summary>
        internal bool IsSetAwsDmsReplicationInstance() => this.AwsDmsReplicationInstance != null;

        /// <summary>
        /// Gets and sets the property AwsDmsReplicationTask. 
        /// <para>
        ///  Provides details about an DMS replication task. A replication task moves a set of
        /// data from the source endpoint to the target endpoint.
        /// </para>
        /// </summary>
        public AwsDmsReplicationTaskDetails AwsDmsReplicationTask { get; set; }

        /// <summary>
        /// Checks to see if the AwsDmsReplicationTask property is set.
        /// </summary>
        internal bool IsSetAwsDmsReplicationTask() => this.AwsDmsReplicationTask != null;

        /// <summary>
        /// Gets and sets the property AwsDynamoDbTable. 
        /// <para>
        /// Details about a DynamoDB table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableDetails AwsDynamoDbTable { get; set; }

        /// <summary>
        /// Checks to see if the AwsDynamoDbTable property is set.
        /// </summary>
        internal bool IsSetAwsDynamoDbTable() => this.AwsDynamoDbTable != null;

        /// <summary>
        /// Gets and sets the property AwsEc2ClientVpnEndpoint. 
        /// <para>
        ///  Provides details about an Client VPN endpoint. A Client VPN endpoint is the resource
        /// that you create and configure to enable and manage client VPN sessions. It's the termination
        /// point for all client VPN sessions. 
        /// </para>
        /// </summary>
        public AwsEc2ClientVpnEndpointDetails AwsEc2ClientVpnEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2ClientVpnEndpoint property is set.
        /// </summary>
        internal bool IsSetAwsEc2ClientVpnEndpoint() => this.AwsEc2ClientVpnEndpoint != null;

        /// <summary>
        /// Gets and sets the property AwsEc2Eip. 
        /// <para>
        /// Details about an Elastic IP address.
        /// </para>
        /// </summary>
        public AwsEc2EipDetails AwsEc2Eip { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2Eip property is set.
        /// </summary>
        internal bool IsSetAwsEc2Eip() => this.AwsEc2Eip != null;

        /// <summary>
        /// Gets and sets the property AwsEc2Instance. 
        /// <para>
        /// Details about an EC2 instance related to a finding.
        /// </para>
        /// </summary>
        public AwsEc2InstanceDetails AwsEc2Instance { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2Instance property is set.
        /// </summary>
        internal bool IsSetAwsEc2Instance() => this.AwsEc2Instance != null;

        /// <summary>
        /// Gets and sets the property AwsEc2LaunchTemplate.
        /// </summary>
        public AwsEc2LaunchTemplateDetails AwsEc2LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetAwsEc2LaunchTemplate() => this.AwsEc2LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkAcl. 
        /// <para>
        /// Details about an EC2 network access control list (ACL).
        /// </para>
        /// </summary>
        public AwsEc2NetworkAclDetails AwsEc2NetworkAcl { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2NetworkAcl property is set.
        /// </summary>
        internal bool IsSetAwsEc2NetworkAcl() => this.AwsEc2NetworkAcl != null;

        /// <summary>
        /// Gets and sets the property AwsEc2NetworkInterface. 
        /// <para>
        /// Details for an EC2 network interface.
        /// </para>
        /// </summary>
        public AwsEc2NetworkInterfaceDetails AwsEc2NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2NetworkInterface property is set.
        /// </summary>
        internal bool IsSetAwsEc2NetworkInterface() => this.AwsEc2NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property AwsEc2RouteTable. 
        /// <para>
        ///  Provides details about a route table. A route table contains a set of rules, called
        /// routes, that determine where to direct network traffic from your subnet or gateway.
        /// 
        /// </para>
        /// </summary>
        public AwsEc2RouteTableDetails AwsEc2RouteTable { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2RouteTable property is set.
        /// </summary>
        internal bool IsSetAwsEc2RouteTable() => this.AwsEc2RouteTable != null;

        /// <summary>
        /// Gets and sets the property AwsEc2SecurityGroup. 
        /// <para>
        /// Details for an EC2 security group.
        /// </para>
        /// </summary>
        public AwsEc2SecurityGroupDetails AwsEc2SecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2SecurityGroup property is set.
        /// </summary>
        internal bool IsSetAwsEc2SecurityGroup() => this.AwsEc2SecurityGroup != null;

        /// <summary>
        /// Gets and sets the property AwsEc2Subnet. 
        /// <para>
        /// Details about a subnet in Amazon EC2.
        /// </para>
        /// </summary>
        public AwsEc2SubnetDetails AwsEc2Subnet { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2Subnet property is set.
        /// </summary>
        internal bool IsSetAwsEc2Subnet() => this.AwsEc2Subnet != null;

        /// <summary>
        /// Gets and sets the property AwsEc2TransitGateway. 
        /// <para>
        /// Details about an Amazon EC2 transit gateway that interconnects your virtual private
        /// clouds (VPC) and on-premises networks.
        /// </para>
        /// </summary>
        public AwsEc2TransitGatewayDetails AwsEc2TransitGateway { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2TransitGateway property is set.
        /// </summary>
        internal bool IsSetAwsEc2TransitGateway() => this.AwsEc2TransitGateway != null;

        /// <summary>
        /// Gets and sets the property AwsEc2Volume. 
        /// <para>
        /// Details for an Amazon EC2 volume.
        /// </para>
        /// </summary>
        public AwsEc2VolumeDetails AwsEc2Volume { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2Volume property is set.
        /// </summary>
        internal bool IsSetAwsEc2Volume() => this.AwsEc2Volume != null;

        /// <summary>
        /// Gets and sets the property AwsEc2Vpc. 
        /// <para>
        /// Details for an Amazon EC2 VPC.
        /// </para>
        /// </summary>
        public AwsEc2VpcDetails AwsEc2Vpc { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2Vpc property is set.
        /// </summary>
        internal bool IsSetAwsEc2Vpc() => this.AwsEc2Vpc != null;

        /// <summary>
        /// Gets and sets the property AwsEc2VpcEndpointService. 
        /// <para>
        /// Details about the service configuration for a VPC endpoint service.
        /// </para>
        /// </summary>
        public AwsEc2VpcEndpointServiceDetails AwsEc2VpcEndpointService { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2VpcEndpointService property is set.
        /// </summary>
        internal bool IsSetAwsEc2VpcEndpointService() => this.AwsEc2VpcEndpointService != null;

        /// <summary>
        /// Gets and sets the property AwsEc2VpcPeeringConnection. 
        /// <para>
        /// Details about an Amazon EC2 VPC peering connection. A VPC peering connection is a
        /// networking connection between two VPCs that enables you to route traffic between them
        /// privately. 
        /// </para>
        /// </summary>
        public AwsEc2VpcPeeringConnectionDetails AwsEc2VpcPeeringConnection { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2VpcPeeringConnection property is set.
        /// </summary>
        internal bool IsSetAwsEc2VpcPeeringConnection() => this.AwsEc2VpcPeeringConnection != null;

        /// <summary>
        /// Gets and sets the property AwsEc2VpnConnection. 
        /// <para>
        /// Details about an Amazon EC2 VPN connection.
        /// </para>
        /// </summary>
        public AwsEc2VpnConnectionDetails AwsEc2VpnConnection { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2VpnConnection property is set.
        /// </summary>
        internal bool IsSetAwsEc2VpnConnection() => this.AwsEc2VpnConnection != null;

        /// <summary>
        /// Gets and sets the property AwsEcrContainerImage. 
        /// <para>
        /// Information about an Amazon ECR image.
        /// </para>
        /// </summary>
        public AwsEcrContainerImageDetails AwsEcrContainerImage { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcrContainerImage property is set.
        /// </summary>
        internal bool IsSetAwsEcrContainerImage() => this.AwsEcrContainerImage != null;

        /// <summary>
        /// Gets and sets the property AwsEcrRepository. 
        /// <para>
        /// Information about an Amazon Elastic Container Registry repository.
        /// </para>
        /// </summary>
        public AwsEcrRepositoryDetails AwsEcrRepository { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcrRepository property is set.
        /// </summary>
        internal bool IsSetAwsEcrRepository() => this.AwsEcrRepository != null;

        /// <summary>
        /// Gets and sets the property AwsEcsCluster. 
        /// <para>
        /// Details about an Amazon ECS cluster.
        /// </para>
        /// </summary>
        public AwsEcsClusterDetails AwsEcsCluster { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcsCluster property is set.
        /// </summary>
        internal bool IsSetAwsEcsCluster() => this.AwsEcsCluster != null;

        /// <summary>
        /// Gets and sets the property AwsEcsContainer. 
        /// <para>
        /// Provides information about a Docker container that's part of a task. 
        /// </para>
        /// </summary>
        public AwsEcsContainerDetails AwsEcsContainer { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcsContainer property is set.
        /// </summary>
        internal bool IsSetAwsEcsContainer() => this.AwsEcsContainer != null;

        /// <summary>
        /// Gets and sets the property AwsEcsService. 
        /// <para>
        /// Details about a service within an ECS cluster.
        /// </para>
        /// </summary>
        public AwsEcsServiceDetails AwsEcsService { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcsService property is set.
        /// </summary>
        internal bool IsSetAwsEcsService() => this.AwsEcsService != null;

        /// <summary>
        /// Gets and sets the property AwsEcsTask. 
        /// <para>
        /// Details about a task in a cluster. 
        /// </para>
        /// </summary>
        public AwsEcsTaskDetails AwsEcsTask { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcsTask property is set.
        /// </summary>
        internal bool IsSetAwsEcsTask() => this.AwsEcsTask != null;

        /// <summary>
        /// Gets and sets the property AwsEcsTaskDefinition. 
        /// <para>
        /// Details about a task definition. A task definition describes the container and volume
        /// definitions of an Amazon Elastic Container Service task.
        /// </para>
        /// </summary>
        public AwsEcsTaskDefinitionDetails AwsEcsTaskDefinition { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcsTaskDefinition property is set.
        /// </summary>
        internal bool IsSetAwsEcsTaskDefinition() => this.AwsEcsTaskDefinition != null;

        /// <summary>
        /// Gets and sets the property AwsEfsAccessPoint. 
        /// <para>
        /// Details about an Amazon EFS access point. An access point is an application-specific
        /// view into an EFS file system that applies an operating system user and group, and
        /// a file system path, to any file system request made through the access point. 
        /// </para>
        /// </summary>
        public AwsEfsAccessPointDetails AwsEfsAccessPoint { get; set; }

        /// <summary>
        /// Checks to see if the AwsEfsAccessPoint property is set.
        /// </summary>
        internal bool IsSetAwsEfsAccessPoint() => this.AwsEfsAccessPoint != null;

        /// <summary>
        /// Gets and sets the property AwsEksCluster. 
        /// <para>
        /// Details about an Amazon EKS cluster.
        /// </para>
        /// </summary>
        public AwsEksClusterDetails AwsEksCluster { get; set; }

        /// <summary>
        /// Checks to see if the AwsEksCluster property is set.
        /// </summary>
        internal bool IsSetAwsEksCluster() => this.AwsEksCluster != null;

        /// <summary>
        /// Gets and sets the property AwsElasticBeanstalkEnvironment. 
        /// <para>
        /// Details about an Elastic Beanstalk environment.
        /// </para>
        /// </summary>
        public AwsElasticBeanstalkEnvironmentDetails AwsElasticBeanstalkEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the AwsElasticBeanstalkEnvironment property is set.
        /// </summary>
        internal bool IsSetAwsElasticBeanstalkEnvironment() => this.AwsElasticBeanstalkEnvironment != null;

        /// <summary>
        /// Gets and sets the property AwsElasticsearchDomain. 
        /// <para>
        /// Details for an Elasticsearch domain.
        /// </para>
        /// </summary>
        public AwsElasticsearchDomainDetails AwsElasticsearchDomain { get; set; }

        /// <summary>
        /// Checks to see if the AwsElasticsearchDomain property is set.
        /// </summary>
        internal bool IsSetAwsElasticsearchDomain() => this.AwsElasticsearchDomain != null;

        /// <summary>
        /// Gets and sets the property AwsElbLoadBalancer. 
        /// <para>
        /// Contains details about a Classic Load Balancer.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerDetails AwsElbLoadBalancer { get; set; }

        /// <summary>
        /// Checks to see if the AwsElbLoadBalancer property is set.
        /// </summary>
        internal bool IsSetAwsElbLoadBalancer() => this.AwsElbLoadBalancer != null;

        /// <summary>
        /// Gets and sets the property AwsElbv2LoadBalancer. 
        /// <para>
        /// Details about a load balancer.
        /// </para>
        /// </summary>
        public AwsElbv2LoadBalancerDetails AwsElbv2LoadBalancer { get; set; }

        /// <summary>
        /// Checks to see if the AwsElbv2LoadBalancer property is set.
        /// </summary>
        internal bool IsSetAwsElbv2LoadBalancer() => this.AwsElbv2LoadBalancer != null;

        /// <summary>
        /// Gets and sets the property AwsEventSchemasRegistry. 
        /// <para>
        ///  A schema defines the structure of events that are sent to Amazon EventBridge. Schema
        /// registries are containers for schemas. They collect and organize schemas so that your
        /// schemas are in logical groups. 
        /// </para>
        /// </summary>
        public AwsEventSchemasRegistryDetails AwsEventSchemasRegistry { get; set; }

        /// <summary>
        /// Checks to see if the AwsEventSchemasRegistry property is set.
        /// </summary>
        internal bool IsSetAwsEventSchemasRegistry() => this.AwsEventSchemasRegistry != null;

        /// <summary>
        /// Gets and sets the property AwsEventsEndpoint. 
        /// <para>
        ///  Provides details about an Amazon EventBridge global endpoint. The endpoint can improve
        /// your application’s availability by making it Regional-fault tolerant.
        /// </para>
        /// </summary>
        public AwsEventsEndpointDetails AwsEventsEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AwsEventsEndpoint property is set.
        /// </summary>
        internal bool IsSetAwsEventsEndpoint() => this.AwsEventsEndpoint != null;

        /// <summary>
        /// Gets and sets the property AwsEventsEventbus. 
        /// <para>
        ///  Provides details about Amazon EventBridge event bus for an endpoint. An event bus
        /// is a router that receives events and delivers them to zero or more destinations, or
        /// targets.
        /// </para>
        /// </summary>
        public AwsEventsEventbusDetails AwsEventsEventbus { get; set; }

        /// <summary>
        /// Checks to see if the AwsEventsEventbus property is set.
        /// </summary>
        internal bool IsSetAwsEventsEventbus() => this.AwsEventsEventbus != null;

        /// <summary>
        /// Gets and sets the property AwsGuardDutyDetector. 
        /// <para>
        ///  Provides details about an Amazon GuardDuty detector. A detector is an object that
        /// represents the GuardDuty service. A detector is required for GuardDuty to become operational.
        /// 
        /// </para>
        /// </summary>
        public AwsGuardDutyDetectorDetails AwsGuardDutyDetector { get; set; }

        /// <summary>
        /// Checks to see if the AwsGuardDutyDetector property is set.
        /// </summary>
        internal bool IsSetAwsGuardDutyDetector() => this.AwsGuardDutyDetector != null;

        /// <summary>
        /// Gets and sets the property AwsIamAccessKey. 
        /// <para>
        /// Details about an IAM access key related to a finding.
        /// </para>
        /// </summary>
        public AwsIamAccessKeyDetails AwsIamAccessKey { get; set; }

        /// <summary>
        /// Checks to see if the AwsIamAccessKey property is set.
        /// </summary>
        internal bool IsSetAwsIamAccessKey() => this.AwsIamAccessKey != null;

        /// <summary>
        /// Gets and sets the property AwsIamGroup. 
        /// <para>
        /// Contains details about an IAM group.
        /// </para>
        /// </summary>
        public AwsIamGroupDetails AwsIamGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsIamGroup property is set.
        /// </summary>
        internal bool IsSetAwsIamGroup() => this.AwsIamGroup != null;

        /// <summary>
        /// Gets and sets the property AwsIamPolicy. 
        /// <para>
        /// Details about an IAM permissions policy.
        /// </para>
        /// </summary>
        public AwsIamPolicyDetails AwsIamPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AwsIamPolicy property is set.
        /// </summary>
        internal bool IsSetAwsIamPolicy() => this.AwsIamPolicy != null;

        /// <summary>
        /// Gets and sets the property AwsIamRole. 
        /// <para>
        /// Details about an IAM role.
        /// </para>
        /// </summary>
        public AwsIamRoleDetails AwsIamRole { get; set; }

        /// <summary>
        /// Checks to see if the AwsIamRole property is set.
        /// </summary>
        internal bool IsSetAwsIamRole() => this.AwsIamRole != null;

        /// <summary>
        /// Gets and sets the property AwsIamUser. 
        /// <para>
        /// Details about an IAM user.
        /// </para>
        /// </summary>
        public AwsIamUserDetails AwsIamUser { get; set; }

        /// <summary>
        /// Checks to see if the AwsIamUser property is set.
        /// </summary>
        internal bool IsSetAwsIamUser() => this.AwsIamUser != null;

        /// <summary>
        /// Gets and sets the property AwsKinesisStream. 
        /// <para>
        /// Details about an Amazon Kinesis data stream.
        /// </para>
        /// </summary>
        public AwsKinesisStreamDetails AwsKinesisStream { get; set; }

        /// <summary>
        /// Checks to see if the AwsKinesisStream property is set.
        /// </summary>
        internal bool IsSetAwsKinesisStream() => this.AwsKinesisStream != null;

        /// <summary>
        /// Gets and sets the property AwsKmsKey. 
        /// <para>
        /// Details about an KMS key.
        /// </para>
        /// </summary>
        public AwsKmsKeyDetails AwsKmsKey { get; set; }

        /// <summary>
        /// Checks to see if the AwsKmsKey property is set.
        /// </summary>
        internal bool IsSetAwsKmsKey() => this.AwsKmsKey != null;

        /// <summary>
        /// Gets and sets the property AwsLambdaFunction. 
        /// <para>
        /// Details about a Lambda function.
        /// </para>
        /// </summary>
        public AwsLambdaFunctionDetails AwsLambdaFunction { get; set; }

        /// <summary>
        /// Checks to see if the AwsLambdaFunction property is set.
        /// </summary>
        internal bool IsSetAwsLambdaFunction() => this.AwsLambdaFunction != null;

        /// <summary>
        /// Gets and sets the property AwsLambdaLayerVersion. 
        /// <para>
        /// Details for a Lambda layer version.
        /// </para>
        /// </summary>
        public AwsLambdaLayerVersionDetails AwsLambdaLayerVersion { get; set; }

        /// <summary>
        /// Checks to see if the AwsLambdaLayerVersion property is set.
        /// </summary>
        internal bool IsSetAwsLambdaLayerVersion() => this.AwsLambdaLayerVersion != null;

        /// <summary>
        /// Gets and sets the property AwsMskCluster. 
        /// <para>
        ///  Provides details about an Amazon Managed Streaming for Apache Kafka (Amazon MSK)
        /// cluster.
        /// </para>
        /// </summary>
        public AwsMskClusterDetails AwsMskCluster { get; set; }

        /// <summary>
        /// Checks to see if the AwsMskCluster property is set.
        /// </summary>
        internal bool IsSetAwsMskCluster() => this.AwsMskCluster != null;

        /// <summary>
        /// Gets and sets the property AwsNetworkFirewallFirewall. 
        /// <para>
        /// Details about an Network Firewall firewall.
        /// </para>
        /// </summary>
        public AwsNetworkFirewallFirewallDetails AwsNetworkFirewallFirewall { get; set; }

        /// <summary>
        /// Checks to see if the AwsNetworkFirewallFirewall property is set.
        /// </summary>
        internal bool IsSetAwsNetworkFirewallFirewall() => this.AwsNetworkFirewallFirewall != null;

        /// <summary>
        /// Gets and sets the property AwsNetworkFirewallFirewallPolicy. 
        /// <para>
        /// Details about an Network Firewall firewall policy.
        /// </para>
        /// </summary>
        public AwsNetworkFirewallFirewallPolicyDetails AwsNetworkFirewallFirewallPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AwsNetworkFirewallFirewallPolicy property is set.
        /// </summary>
        internal bool IsSetAwsNetworkFirewallFirewallPolicy() => this.AwsNetworkFirewallFirewallPolicy != null;

        /// <summary>
        /// Gets and sets the property AwsNetworkFirewallRuleGroup. 
        /// <para>
        /// Details about an Network Firewall rule group.
        /// </para>
        /// </summary>
        public AwsNetworkFirewallRuleGroupDetails AwsNetworkFirewallRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsNetworkFirewallRuleGroup property is set.
        /// </summary>
        internal bool IsSetAwsNetworkFirewallRuleGroup() => this.AwsNetworkFirewallRuleGroup != null;

        /// <summary>
        /// Gets and sets the property AwsOpenSearchServiceDomain. 
        /// <para>
        /// Details about an Amazon OpenSearch Service domain.
        /// </para>
        /// </summary>
        public AwsOpenSearchServiceDomainDetails AwsOpenSearchServiceDomain { get; set; }

        /// <summary>
        /// Checks to see if the AwsOpenSearchServiceDomain property is set.
        /// </summary>
        internal bool IsSetAwsOpenSearchServiceDomain() => this.AwsOpenSearchServiceDomain != null;

        /// <summary>
        /// Gets and sets the property AwsRdsDbCluster. 
        /// <para>
        /// Details about an Amazon RDS database cluster.
        /// </para>
        /// </summary>
        public AwsRdsDbClusterDetails AwsRdsDbCluster { get; set; }

        /// <summary>
        /// Checks to see if the AwsRdsDbCluster property is set.
        /// </summary>
        internal bool IsSetAwsRdsDbCluster() => this.AwsRdsDbCluster != null;

        /// <summary>
        /// Gets and sets the property AwsRdsDbClusterSnapshot. 
        /// <para>
        /// Details about an Amazon RDS database cluster snapshot.
        /// </para>
        /// </summary>
        public AwsRdsDbClusterSnapshotDetails AwsRdsDbClusterSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the AwsRdsDbClusterSnapshot property is set.
        /// </summary>
        internal bool IsSetAwsRdsDbClusterSnapshot() => this.AwsRdsDbClusterSnapshot != null;

        /// <summary>
        /// Gets and sets the property AwsRdsDbInstance. 
        /// <para>
        /// Details about an Amazon RDS database instance.
        /// </para>
        /// </summary>
        public AwsRdsDbInstanceDetails AwsRdsDbInstance { get; set; }

        /// <summary>
        /// Checks to see if the AwsRdsDbInstance property is set.
        /// </summary>
        internal bool IsSetAwsRdsDbInstance() => this.AwsRdsDbInstance != null;

        /// <summary>
        /// Gets and sets the property AwsRdsDbSecurityGroup. 
        /// <para>
        /// Details about an Amazon RDS DB security group.
        /// </para>
        /// </summary>
        public AwsRdsDbSecurityGroupDetails AwsRdsDbSecurityGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsRdsDbSecurityGroup property is set.
        /// </summary>
        internal bool IsSetAwsRdsDbSecurityGroup() => this.AwsRdsDbSecurityGroup != null;

        /// <summary>
        /// Gets and sets the property AwsRdsDbSnapshot. 
        /// <para>
        /// Details about an Amazon RDS database snapshot.
        /// </para>
        /// </summary>
        public AwsRdsDbSnapshotDetails AwsRdsDbSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the AwsRdsDbSnapshot property is set.
        /// </summary>
        internal bool IsSetAwsRdsDbSnapshot() => this.AwsRdsDbSnapshot != null;

        /// <summary>
        /// Gets and sets the property AwsRdsEventSubscription. 
        /// <para>
        /// Details about an RDS event notification subscription.
        /// </para>
        /// </summary>
        public AwsRdsEventSubscriptionDetails AwsRdsEventSubscription { get; set; }

        /// <summary>
        /// Checks to see if the AwsRdsEventSubscription property is set.
        /// </summary>
        internal bool IsSetAwsRdsEventSubscription() => this.AwsRdsEventSubscription != null;

        /// <summary>
        /// Gets and sets the property AwsRedshiftCluster. 
        /// <para>
        /// Contains details about an Amazon Redshift cluster.
        /// </para>
        /// </summary>
        public AwsRedshiftClusterDetails AwsRedshiftCluster { get; set; }

        /// <summary>
        /// Checks to see if the AwsRedshiftCluster property is set.
        /// </summary>
        internal bool IsSetAwsRedshiftCluster() => this.AwsRedshiftCluster != null;

        /// <summary>
        /// Gets and sets the property AwsRoute53HostedZone. 
        /// <para>
        ///  Provides details about an Amazon Route 53 hosted zone, including the four name servers
        /// assigned to the hosted zone. A hosted zone represents a collection of records that
        /// can be managed together, belonging to a single parent domain name.
        /// </para>
        /// </summary>
        public AwsRoute53HostedZoneDetails AwsRoute53HostedZone { get; set; }

        /// <summary>
        /// Checks to see if the AwsRoute53HostedZone property is set.
        /// </summary>
        internal bool IsSetAwsRoute53HostedZone() => this.AwsRoute53HostedZone != null;

        /// <summary>
        /// Gets and sets the property AwsS3AccessPoint. 
        /// <para>
        ///  Provides details about an Amazon Simple Storage Service (Amazon S3) access point.
        /// S3 access points are named network endpoints that are attached to S3 buckets that
        /// you can use to perform S3 object operations. 
        /// </para>
        /// </summary>
        public AwsS3AccessPointDetails AwsS3AccessPoint { get; set; }

        /// <summary>
        /// Checks to see if the AwsS3AccessPoint property is set.
        /// </summary>
        internal bool IsSetAwsS3AccessPoint() => this.AwsS3AccessPoint != null;

        /// <summary>
        /// Gets and sets the property AwsS3AccountPublicAccessBlock. 
        /// <para>
        /// Details about the Amazon S3 Public Access Block configuration for an account.
        /// </para>
        /// </summary>
        public AwsS3AccountPublicAccessBlockDetails AwsS3AccountPublicAccessBlock { get; set; }

        /// <summary>
        /// Checks to see if the AwsS3AccountPublicAccessBlock property is set.
        /// </summary>
        internal bool IsSetAwsS3AccountPublicAccessBlock() => this.AwsS3AccountPublicAccessBlock != null;

        /// <summary>
        /// Gets and sets the property AwsS3Bucket. 
        /// <para>
        /// Details about an S3 bucket related to a finding.
        /// </para>
        /// </summary>
        public AwsS3BucketDetails AwsS3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the AwsS3Bucket property is set.
        /// </summary>
        internal bool IsSetAwsS3Bucket() => this.AwsS3Bucket != null;

        /// <summary>
        /// Gets and sets the property AwsS3Object. 
        /// <para>
        /// Details about an S3 object related to a finding.
        /// </para>
        /// </summary>
        public AwsS3ObjectDetails AwsS3Object { get; set; }

        /// <summary>
        /// Checks to see if the AwsS3Object property is set.
        /// </summary>
        internal bool IsSetAwsS3Object() => this.AwsS3Object != null;

        /// <summary>
        /// Gets and sets the property AwsSageMakerNotebookInstance.
        /// </summary>
        public AwsSageMakerNotebookInstanceDetails AwsSageMakerNotebookInstance { get; set; }

        /// <summary>
        /// Checks to see if the AwsSageMakerNotebookInstance property is set.
        /// </summary>
        internal bool IsSetAwsSageMakerNotebookInstance() => this.AwsSageMakerNotebookInstance != null;

        /// <summary>
        /// Gets and sets the property AwsSecretsManagerSecret. 
        /// <para>
        /// Details about a Secrets Manager secret.
        /// </para>
        /// </summary>
        public AwsSecretsManagerSecretDetails AwsSecretsManagerSecret { get; set; }

        /// <summary>
        /// Checks to see if the AwsSecretsManagerSecret property is set.
        /// </summary>
        internal bool IsSetAwsSecretsManagerSecret() => this.AwsSecretsManagerSecret != null;

        /// <summary>
        /// Gets and sets the property AwsSnsTopic. 
        /// <para>
        /// Details about an SNS topic.
        /// </para>
        /// </summary>
        public AwsSnsTopicDetails AwsSnsTopic { get; set; }

        /// <summary>
        /// Checks to see if the AwsSnsTopic property is set.
        /// </summary>
        internal bool IsSetAwsSnsTopic() => this.AwsSnsTopic != null;

        /// <summary>
        /// Gets and sets the property AwsSqsQueue. 
        /// <para>
        /// Details about an SQS queue.
        /// </para>
        /// </summary>
        public AwsSqsQueueDetails AwsSqsQueue { get; set; }

        /// <summary>
        /// Checks to see if the AwsSqsQueue property is set.
        /// </summary>
        internal bool IsSetAwsSqsQueue() => this.AwsSqsQueue != null;

        /// <summary>
        /// Gets and sets the property AwsSsmPatchCompliance. 
        /// <para>
        /// Provides information about the state of a patch on an instance based on the patch
        /// baseline that was used to patch the instance.
        /// </para>
        /// </summary>
        public AwsSsmPatchComplianceDetails AwsSsmPatchCompliance { get; set; }

        /// <summary>
        /// Checks to see if the AwsSsmPatchCompliance property is set.
        /// </summary>
        internal bool IsSetAwsSsmPatchCompliance() => this.AwsSsmPatchCompliance != null;

        /// <summary>
        /// Gets and sets the property AwsStepFunctionStateMachine. 
        /// <para>
        ///  Provides details about an Step Functions state machine, which is a workflow consisting
        /// of a series of event-driven steps. 
        /// </para>
        /// </summary>
        public AwsStepFunctionStateMachineDetails AwsStepFunctionStateMachine { get; set; }

        /// <summary>
        /// Checks to see if the AwsStepFunctionStateMachine property is set.
        /// </summary>
        internal bool IsSetAwsStepFunctionStateMachine() => this.AwsStepFunctionStateMachine != null;

        /// <summary>
        /// Gets and sets the property AwsWafRateBasedRule. 
        /// <para>
        /// Details about a rate-based rule for global resources.
        /// </para>
        /// </summary>
        public AwsWafRateBasedRuleDetails AwsWafRateBasedRule { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafRateBasedRule property is set.
        /// </summary>
        internal bool IsSetAwsWafRateBasedRule() => this.AwsWafRateBasedRule != null;

        /// <summary>
        /// Gets and sets the property AwsWafRegionalRateBasedRule. 
        /// <para>
        /// Details about a rate-based rule for Regional resources.
        /// </para>
        /// </summary>
        public AwsWafRegionalRateBasedRuleDetails AwsWafRegionalRateBasedRule { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafRegionalRateBasedRule property is set.
        /// </summary>
        internal bool IsSetAwsWafRegionalRateBasedRule() => this.AwsWafRegionalRateBasedRule != null;

        /// <summary>
        /// Gets and sets the property AwsWafRegionalRule. 
        /// <para>
        /// Details about an WAF rule for Regional resources. 
        /// </para>
        /// </summary>
        public AwsWafRegionalRuleDetails AwsWafRegionalRule { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafRegionalRule property is set.
        /// </summary>
        internal bool IsSetAwsWafRegionalRule() => this.AwsWafRegionalRule != null;

        /// <summary>
        /// Gets and sets the property AwsWafRegionalRuleGroup. 
        /// <para>
        /// Details about an WAF rule group for Regional resources. 
        /// </para>
        /// </summary>
        public AwsWafRegionalRuleGroupDetails AwsWafRegionalRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafRegionalRuleGroup property is set.
        /// </summary>
        internal bool IsSetAwsWafRegionalRuleGroup() => this.AwsWafRegionalRuleGroup != null;

        /// <summary>
        /// Gets and sets the property AwsWafRegionalWebAcl. 
        /// <para>
        /// Details about an WAF web access control list (web ACL) for Regional resources. 
        /// </para>
        /// </summary>
        public AwsWafRegionalWebAclDetails AwsWafRegionalWebAcl { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafRegionalWebAcl property is set.
        /// </summary>
        internal bool IsSetAwsWafRegionalWebAcl() => this.AwsWafRegionalWebAcl != null;

        /// <summary>
        /// Gets and sets the property AwsWafRule. 
        /// <para>
        /// Details about an WAF rule for global resources. 
        /// </para>
        /// </summary>
        public AwsWafRuleDetails AwsWafRule { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafRule property is set.
        /// </summary>
        internal bool IsSetAwsWafRule() => this.AwsWafRule != null;

        /// <summary>
        /// Gets and sets the property AwsWafRuleGroup. 
        /// <para>
        /// Details about an WAF rule group for global resources. 
        /// </para>
        /// </summary>
        public AwsWafRuleGroupDetails AwsWafRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafRuleGroup property is set.
        /// </summary>
        internal bool IsSetAwsWafRuleGroup() => this.AwsWafRuleGroup != null;

        /// <summary>
        /// Gets and sets the property AwsWafWebAcl. 
        /// <para>
        /// Details for an WAF web ACL.
        /// </para>
        /// </summary>
        public AwsWafWebAclDetails AwsWafWebAcl { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafWebAcl property is set.
        /// </summary>
        internal bool IsSetAwsWafWebAcl() => this.AwsWafWebAcl != null;

        /// <summary>
        /// Gets and sets the property AwsWafv2RuleGroup.
        /// </summary>
        public AwsWafv2RuleGroupDetails AwsWafv2RuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafv2RuleGroup property is set.
        /// </summary>
        internal bool IsSetAwsWafv2RuleGroup() => this.AwsWafv2RuleGroup != null;

        /// <summary>
        /// Gets and sets the property AwsWafv2WebAcl.
        /// </summary>
        public AwsWafv2WebAclDetails AwsWafv2WebAcl { get; set; }

        /// <summary>
        /// Checks to see if the AwsWafv2WebAcl property is set.
        /// </summary>
        internal bool IsSetAwsWafv2WebAcl() => this.AwsWafv2WebAcl != null;

        /// <summary>
        /// Gets and sets the property AwsXrayEncryptionConfig. 
        /// <para>
        /// Information about the encryption configuration for X-Ray.
        /// </para>
        /// </summary>
        public AwsXrayEncryptionConfigDetails AwsXrayEncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the AwsXrayEncryptionConfig property is set.
        /// </summary>
        internal bool IsSetAwsXrayEncryptionConfig() => this.AwsXrayEncryptionConfig != null;

        /// <summary>
        /// Gets and sets the property AzureResource. 
        /// <para>
        /// Details about an Azure resource that is related to a finding.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AzureResource { get; set; }

        /// <summary>
        /// Checks to see if the AzureResource property is set.
        /// </summary>
        internal bool IsSetAzureResource() => !this.AzureResource.IsNull();

        /// <summary>
        /// Gets and sets the property CodeRepository. 
        /// <para>
        ///  Details about an external code repository with which you can connect your Amazon
        /// Web Services resources. The connection is established through Amazon Inspector. 
        /// </para>
        /// </summary>
        public CodeRepositoryDetails CodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepository property is set.
        /// </summary>
        internal bool IsSetCodeRepository() => this.CodeRepository != null;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// Details about a container resource related to a finding.
        /// </para>
        /// </summary>
        public ContainerDetails Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property Other. 
        /// <para>
        /// Details about a resource that are not available in a type-specific details object.
        /// Use the <c>Other</c> object in the following cases.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The type-specific object does not contain all of the fields that you want to populate.
        /// In this case, first use the type-specific object to populate those fields. Use the
        /// <c>Other</c> object to populate the fields that are missing from the type-specific
        /// object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resource type does not have a corresponding object. This includes resources for
        /// which the type is <c>Other</c>. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Other { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Other property is set.
        /// </summary>
        internal bool IsSetOther() => this.Other != null && (this.Other.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
