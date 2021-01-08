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
        private AwsCertificateManagerCertificateDetails _awsCertificateManagerCertificate;
        private AwsCloudFrontDistributionDetails _awsCloudFrontDistribution;
        private AwsCloudTrailTrailDetails _awsCloudTrailTrail;
        private AwsCodeBuildProjectDetails _awsCodeBuildProject;
        private AwsDynamoDbTableDetails _awsDynamoDbTable;
        private AwsEc2EipDetails _awsEc2Eip;
        private AwsEc2InstanceDetails _awsEc2Instance;
        private AwsEc2NetworkInterfaceDetails _awsEc2NetworkInterface;
        private AwsEc2SecurityGroupDetails _awsEc2SecurityGroup;
        private AwsEc2VolumeDetails _awsEc2Volume;
        private AwsEc2VpcDetails _awsEc2Vpc;
        private AwsElasticsearchDomainDetails _awsElasticsearchDomain;
        private AwsElbLoadBalancerDetails _awsElbLoadBalancer;
        private AwsElbv2LoadBalancerDetails _awsElbv2LoadBalancer;
        private AwsIamAccessKeyDetails _awsIamAccessKey;
        private AwsIamGroupDetails _awsIamGroup;
        private AwsIamPolicyDetails _awsIamPolicy;
        private AwsIamRoleDetails _awsIamRole;
        private AwsIamUserDetails _awsIamUser;
        private AwsKmsKeyDetails _awsKmsKey;
        private AwsLambdaFunctionDetails _awsLambdaFunction;
        private AwsLambdaLayerVersionDetails _awsLambdaLayerVersion;
        private AwsRdsDbClusterDetails _awsRdsDbCluster;
        private AwsRdsDbClusterSnapshotDetails _awsRdsDbClusterSnapshot;
        private AwsRdsDbInstanceDetails _awsRdsDbInstance;
        private AwsRdsDbSnapshotDetails _awsRdsDbSnapshot;
        private AwsRedshiftClusterDetails _awsRedshiftCluster;
        private AwsS3BucketDetails _awsS3Bucket;
        private AwsS3ObjectDetails _awsS3Object;
        private AwsSecretsManagerSecretDetails _awsSecretsManagerSecret;
        private AwsSnsTopicDetails _awsSnsTopic;
        private AwsSqsQueueDetails _awsSqsQueue;
        private AwsWafWebAclDetails _awsWafWebAcl;
        private ContainerDetails _container;
        private Dictionary<string, string> _other = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AwsApiGatewayRestApi.
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
        /// Gets and sets the property AwsCertificateManagerCertificate.
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
        /// Gets and sets the property AwsCodeBuildProject. 
        /// <para>
        /// Details for an AWS CodeBuild project.
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
        /// Details about an Amazon EC2 instance related to a finding.
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
        /// Gets and sets the property AwsEc2NetworkInterface. 
        /// <para>
        /// Details for an Amazon EC2 network interface.
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
        /// Gets and sets the property AwsEc2Volume. 
        /// <para>
        /// Details for an EC2 volume.
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
        /// Details for an EC2 VPC.
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
        /// Gets and sets the property AwsKmsKey. 
        /// <para>
        /// Details about a KMS key.
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
        /// Gets and sets the property AwsRedshiftCluster.
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
        /// Gets and sets the property AwsS3Bucket. 
        /// <para>
        /// Details about an Amazon S3 bucket related to a finding.
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
        /// Details about an Amazon S3 object related to a finding.
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
        /// Gets and sets the property AwsWafWebAcl. 
        /// <para>
        /// Details for a WAF WebACL.
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