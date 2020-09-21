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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ResourceGroupsTaggingAPI.Model;

namespace Amazon.ResourceGroupsTaggingAPI
{
    /// <summary>
    /// Interface for accessing ResourceGroupsTaggingAPI
    ///
    /// Resource Groups Tagging API 
    /// <para>
    /// This guide describes the API operations for the resource groups tagging.
    /// </para>
    ///  
    /// <para>
    /// A tag is a label that you assign to an AWS resource. A tag consists of a key and a
    /// value, both of which you define. For example, if you have two Amazon EC2 instances,
    /// you might assign both a tag key of "Stack." But the value of "Stack" might be "Testing"
    /// for one and "Production" for the other.
    /// </para>
    ///  <important> 
    /// <para>
    /// Do not store personally identifiable information (PII) or other confidential or sensitive
    /// information in tags. We use tags to provide you with billing and administration services.
    /// Tags are not intended to be used for private or sensitive data.
    /// </para>
    ///  </important> 
    /// <para>
    /// Tagging can help you organize your resources and enables you to simplify resource
    /// management, access management and cost allocation. 
    /// </para>
    ///  
    /// <para>
    /// You can use the resource groups tagging API operations to complete the following tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tag and untag supported resources located in the specified Region for the AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use tag-based filters to search for resources located in the specified Region for
    /// the AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing tag keys in the specified Region for the AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// List all existing values for the specified key in the specified Region for the AWS
    /// account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To use resource groups tagging API operations, you must add the following permissions
    /// to your IAM policy:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>tag:GetResources</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tag:TagResources</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tag:UntagResources</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tag:GetTagKeys</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tag:GetTagValues</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You'll also need permissions to access the resources of individual services so that
    /// you can tag and untag those resources.
    /// </para>
    ///  
    /// <para>
    /// For more information on IAM policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_manage.html">Managing
    /// IAM Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <i> <b>Services that support the Resource Groups Tagging API</b> </i> 
    /// </para>
    ///  
    /// <para>
    /// You can use the Resource Groups Tagging API to tag resources for the following AWS
    /// services.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/a4b">Alexa for Business (a4b)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/apigateway">API Gateway</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appstream2">Amazon AppStream</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/appsync">AWS AppSync</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/app-mesh">AWS App Mesh</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/athena">Amazon Athena</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide">Amazon Aurora</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/aws-backup">AWS Backup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/acm">AWS Certificate Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/acm">AWS Certificate Manager Private CA</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/clouddirectory">Amazon Cloud Directory</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloud-map">AWS Cloud Map</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudformation">AWS CloudFormation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudfront">Amazon CloudFront</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudhsm">AWS CloudHSM</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudtrail">AWS CloudTrail</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudwatch">Amazon CloudWatch (alarms only)</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudwatch/?id=docs_gateway#amazon-cloudwatch-events">Amazon
    /// CloudWatch Events</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudwatch/?id=docs_gateway#amazon-cloudwatch-logs">Amazon
    /// CloudWatch Logs</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudwatch">Amazon Cloudwatch Synthetics</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codebuild">AWS CodeBuild</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codecommit">AWS CodeCommit</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/">AWS CodeGuru Profiler</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codepipeline">AWS CodePipeline</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codestar">AWS CodeStar</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/codestar-connections/latest/APIReference/">AWS
    /// CodeStar Connections</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito">Amazon Cognito Identity</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito">Amazon Cognito User Pools</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/comprehend">Amazon Comprehend</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/config">AWS Config</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/connect/resources/?whats-new-cards#Documentation">Amazon
    /// Connect</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/data-exchange">AWS Data Exchange</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/data-pipeline">AWS Data Pipeline</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/dms">AWS Database Migration Service</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/datasync">AWS DataSync</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/devicefarm">AWS Device Farm</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/directconnect">AWS Direct Connect</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/directory-service">AWS Directory Service</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/dynamodb">Amazon DynamoDB</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ebs">Amazon EBS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ec2">Amazon EC2</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/imagebuilder">EC2 Image Builder</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ecr">Amazon ECR</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ecs">Amazon ECS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/eks">Amazon EKS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elastic-beanstalk">AWS Elastic Beanstalk</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/efs">Amazon Elastic File System</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing">Elastic Load Balancing</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elastic-inference">Amazon Elastic Inference</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticache">Amazon ElastiCache</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/elasticsearch-service">Amazon Elasticsearch
    /// Service</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/medialive">AWS Elemental MediaLive</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/mediapackage">AWS Elemental MediaPackage</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/mediapackage">AWS Elemental MediaPackage VoD</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/mediatailor">AWS Elemental MediaTailor</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/emr">Amazon EMR</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/eventbridge">Amazon EventBridge Schema</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/firewall-manager">AWS Firewall Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/forecast">Amazon Forecast</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/frauddetector">Amazon Fraud Detector</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/fsx">Amazon FSx</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/s3/?id=docs_gateway#amazon-s3-glacier">Amazon
    /// S3 Glacier</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/global-accelerator">AWS Global Accelerator</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ground-station">AWS Ground Station</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/glue">AWS Glue</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/guardduty">Amazon GuardDuty</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/inspector">Amazon Inspector</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ivs">Amazon Interactive Video Service</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iotanalytics">AWS IoT Analytics</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iot">AWS IoT Core</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iot-device-defender">AWS IoT Device Defender</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iot-device-management">AWS IoT Device Management</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iotevents">AWS IoT Events</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/greengrass">AWS IoT Greengrass</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iot-1-click">AWS IoT 1-Click</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iot-sitewise">AWS IoT Sitewise</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/thingsgraph">AWS IoT Things Graph</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kendra">Amazon Kendra</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms">AWS Key Management Service</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kinesis">Amazon Kinesis</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kinesis/?id=docs_gateway#amazon-kinesis-data-analytics">Amazon
    /// Kinesis Data Analytics</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kinesis/?id=docs_gateway#amazon-kinesis-data-firehose">Amazon
    /// Kinesis Data Firehose</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda">AWS Lambda</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lex">Amazon Lex</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/license-manager">AWS License Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lightsail">Amazon Lightsail</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/macie">Amazon Macie</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/machine-learning">Amazon Machine Learning</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/amazon-mq">Amazon MQ</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/msk">Amazon MSK</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/msk">Amazon MSK</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/neptune">Amazon Neptune</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/vpc/latest/tgw/what-is-network-manager.html">AWS
    /// Network Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/opsworks">AWS OpsWorks</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/opsworks">AWS OpsWorks CM</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/organizations">AWS Organizations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/pinpoint">Amazon Pinpoint</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/qldb">Amazon Quantum Ledger Database (QLDB)</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/rds">Amazon RDS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/redshift">Amazon Redshift</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ram">AWS Resource Access Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ARG">AWS Resource Groups</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/robomaker">AWS RoboMaker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/route53">Amazon Route 53</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/route53">Amazon Route 53 Resolver</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/s3">Amazon S3 (buckets only)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker">Amazon SageMaker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/savingsplans">Savings Plans</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/secretsmanager">AWS Secrets Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/securityhub">AWS Security Hub</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/servicecatalog">AWS Service Catalog</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ses">Amazon Simple Email Service (SES)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sns">Amazon Simple Notification Service (SNS)</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sqs">Amazon Simple Queue Service (SQS)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/swf">Amazon Simple Workflow Service</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/step-functions">AWS Step Functions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/storagegateway">AWS Storage Gateway</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/systems-manager">AWS Systems Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/transfer">AWS Transfer for SFTP</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/vpc">Amazon VPC</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/waf">AWS WAF</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/waf">AWS WAF Regional</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/worklink">Amazon WorkLink</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/workspaces">Amazon WorkSpaces</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonResourceGroupsTaggingAPI : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IResourceGroupsTaggingAPIPaginatorFactory Paginators { get; }

        
        #region  DescribeReportCreation


        /// <summary>
        /// Describes the status of the <code>StartReportCreation</code> operation. 
        /// 
        ///  
        /// <para>
        /// You can call this operation only from the organization's master account and from the
        /// us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportCreation service method.</param>
        /// 
        /// <returns>The response from the DescribeReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>AWS Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<code>tagpolicies.tag.amazonaws.com</code>)
        /// to integrate with AWS Organizations For information, see <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DescribeReportCreation">REST API Reference for DescribeReportCreation Operation</seealso>
        DescribeReportCreationResponse DescribeReportCreation(DescribeReportCreationRequest request);



        /// <summary>
        /// Describes the status of the <code>StartReportCreation</code> operation. 
        /// 
        ///  
        /// <para>
        /// You can call this operation only from the organization's master account and from the
        /// us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReportCreation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>AWS Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<code>tagpolicies.tag.amazonaws.com</code>)
        /// to integrate with AWS Organizations For information, see <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/DescribeReportCreation">REST API Reference for DescribeReportCreation Operation</seealso>
        Task<DescribeReportCreationResponse> DescribeReportCreationAsync(DescribeReportCreationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComplianceSummary


        /// <summary>
        /// Returns a table that shows counts of resources that are noncompliant with their tag
        /// policies.
        /// 
        ///  
        /// <para>
        /// For more information on tag policies, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>AWS Organizations User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's master account and from the
        /// us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummary service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummary service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>AWS Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<code>tagpolicies.tag.amazonaws.com</code>)
        /// to integrate with AWS Organizations For information, see <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetComplianceSummary">REST API Reference for GetComplianceSummary Operation</seealso>
        GetComplianceSummaryResponse GetComplianceSummary(GetComplianceSummaryRequest request);



        /// <summary>
        /// Returns a table that shows counts of resources that are noncompliant with their tag
        /// policies.
        /// 
        ///  
        /// <para>
        /// For more information on tag policies, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>AWS Organizations User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's master account and from the
        /// us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceSummary service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>AWS Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<code>tagpolicies.tag.amazonaws.com</code>)
        /// to integrate with AWS Organizations For information, see <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetComplianceSummary">REST API Reference for GetComplianceSummary Operation</seealso>
        Task<GetComplianceSummaryResponse> GetComplianceSummaryAsync(GetComplianceSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResources


        /// <summary>
        /// Returns all the tagged or previously tagged resources that are located in the specified
        /// Region for the AWS account.
        /// 
        ///  
        /// <para>
        /// Depending on what information you want returned, you can also specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Filters</i> that specify what tags and resource types you want returned. The response
        /// includes all tags that are associated with the requested resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information about compliance with the account's effective tag policy. For more information
        /// on tag policies, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>AWS Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You can check the <code>PaginationToken</code> response parameter to determine if
        /// a query is complete. Queries occasionally return fewer results on a page than allowed.
        /// The <code>PaginationToken</code> response parameter value is <code>null</code> <i>only</i>
        /// when there are no more results to display. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        GetResourcesResponse GetResources(GetResourcesRequest request);



        /// <summary>
        /// Returns all the tagged or previously tagged resources that are located in the specified
        /// Region for the AWS account.
        /// 
        ///  
        /// <para>
        /// Depending on what information you want returned, you can also specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Filters</i> that specify what tags and resource types you want returned. The response
        /// includes all tags that are associated with the requested resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information about compliance with the account's effective tag policy. For more information
        /// on tag policies, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
        /// Policies</a> in the <i>AWS Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You can check the <code>PaginationToken</code> response parameter to determine if
        /// a query is complete. Queries occasionally return fewer results on a page than allowed.
        /// The <code>PaginationToken</code> response parameter value is <code>null</code> <i>only</i>
        /// when there are no more results to display. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetResources">REST API Reference for GetResources Operation</seealso>
        Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTagKeys


        /// <summary>
        /// Returns all tag keys in the specified Region for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys service method.</param>
        /// 
        /// <returns>The response from the GetTagKeys service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        GetTagKeysResponse GetTagKeys(GetTagKeysRequest request);



        /// <summary>
        /// Returns all tag keys in the specified Region for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTagKeys service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagKeys">REST API Reference for GetTagKeys Operation</seealso>
        Task<GetTagKeysResponse> GetTagKeysAsync(GetTagKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTagValues


        /// <summary>
        /// Returns all tag values for the specified key in the specified Region for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues service method.</param>
        /// 
        /// <returns>The response from the GetTagValues service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        GetTagValuesResponse GetTagValues(GetTagValuesRequest request);



        /// <summary>
        /// Returns all tag values for the specified key in the specified Region for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTagValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTagValues service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.PaginationTokenExpiredException">
        /// A <code>PaginationToken</code> is valid for a maximum of 15 minutes. Your request
        /// was denied because the specified <code>PaginationToken</code> has expired.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/GetTagValues">REST API Reference for GetTagValues Operation</seealso>
        Task<GetTagValuesResponse> GetTagValuesAsync(GetTagValuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartReportCreation


        /// <summary>
        /// Generates a report that lists all tagged resources in accounts across your organization
        /// and tells whether each resource is compliant with the effective tag policy. Compliance
        /// data is refreshed daily. 
        /// 
        ///  
        /// <para>
        /// The generated report is saved to the following location:
        /// </para>
        ///  
        /// <para>
        ///  <code>s3://example-bucket/AwsTagPolicies/o-exampleorgid/YYYY-MM-ddTHH:mm:ssZ/report.csv</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's master account and from the
        /// us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReportCreation service method.</param>
        /// 
        /// <returns>The response from the StartReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>AWS Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<code>tagpolicies.tag.amazonaws.com</code>)
        /// to integrate with AWS Organizations For information, see <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/StartReportCreation">REST API Reference for StartReportCreation Operation</seealso>
        StartReportCreationResponse StartReportCreation(StartReportCreationRequest request);



        /// <summary>
        /// Generates a report that lists all tagged resources in accounts across your organization
        /// and tells whether each resource is compliant with the effective tag policy. Compliance
        /// data is refreshed daily. 
        /// 
        ///  
        /// <para>
        /// The generated report is saved to the following location:
        /// </para>
        ///  
        /// <para>
        ///  <code>s3://example-bucket/AwsTagPolicies/o-exampleorgid/YYYY-MM-ddTHH:mm:ssZ/report.csv</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can call this operation only from the organization's master account and from the
        /// us-east-1 Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReportCreation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartReportCreation service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ConstraintViolationException">
        /// The request was denied because performing this operation violates a constraint. 
        /// 
        ///  
        /// <para>
        /// Some of the reasons in the following list might not apply to this specific operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must meet the prerequisites for using tag policies. For information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html">Prerequisites
        /// and Permissions for Using Tag Policies</a> in the <i>AWS Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must enable the tag policies service principal (<code>tagpolicies.tag.amazonaws.com</code>)
        /// to integrate with AWS Organizations For information, see <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have a tag policy attached to the organization root, an OU, or an account.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/StartReportCreation">REST API Reference for StartReportCreation Operation</seealso>
        Task<StartReportCreationResponse> StartReportCreationAsync(StartReportCreationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResources


        /// <summary>
        /// Applies one or more tags to the specified resources. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Not all resources can have tags. For a list of services that support tagging, see
        /// <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html">this
        /// list</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. For other limits, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// Naming and Usage Conventions</a> in the <i>AWS General Reference.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Region for the AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html">this
        /// list</a>.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResources service method.</param>
        /// 
        /// <returns>The response from the TagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        TagResourcesResponse TagResources(TagResourcesRequest request);



        /// <summary>
        /// Applies one or more tags to the specified resources. Note the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Not all resources can have tags. For a list of services that support tagging, see
        /// <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html">this
        /// list</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each resource can have up to 50 tags. For other limits, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// Naming and Usage Conventions</a> in the <i>AWS General Reference.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Region for the AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add tags to a resource, you need the necessary permissions for the service that
        /// the resource belongs to as well as permissions for adding tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html">this
        /// list</a>.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Do not store personally identifiable information (PII) or other confidential or sensitive
        /// information in tags. We use tags to provide you with billing and administration services.
        /// Tags are not intended to be used for private or sensitive data.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/TagResources">REST API Reference for TagResources Operation</seealso>
        Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResources


        /// <summary>
        /// Removes the specified tags from the specified resources. When you specify a tag key,
        /// the action removes both that key and its associated value. The operation succeeds
        /// even if you attempt to remove tags from a resource that were already removed. Note
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To remove tags from a resource, you need the necessary permissions for the service
        /// that the resource belongs to as well as permissions for removing tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html">this
        /// list</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Region for the AWS account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResources service method.</param>
        /// 
        /// <returns>The response from the UntagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        UntagResourcesResponse UntagResources(UntagResourcesRequest request);



        /// <summary>
        /// Removes the specified tags from the specified resources. When you specify a tag key,
        /// the action removes both that key and its associated value. The operation succeeds
        /// even if you attempt to remove tags from a resource that were already removed. Note
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To remove tags from a resource, you need the necessary permissions for the service
        /// that the resource belongs to as well as permissions for removing tags. For more information,
        /// see <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/Welcome.html">this
        /// list</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can only tag resources that are located in the specified Region for the AWS account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResources service method, as returned by ResourceGroupsTaggingAPI.</returns>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InternalServiceException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.InvalidParameterException">
        /// This error indicates one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A parameter is missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A malformed string was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An out-of-range value was supplied for the request parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The target ID is invalid, unsupported, or doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't access the Amazon S3 bucket for report storage. For more information, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies-prereqs.html#bucket-policies-org-report">Additional
        /// Requirements for Organization-wide Tag Compliance Reports</a> in the <i>AWS Organizations
        /// User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ResourceGroupsTaggingAPI.Model.ThrottledException">
        /// The request was denied to limit the frequency of submitted requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resourcegroupstaggingapi-2017-01-26/UntagResources">REST API Reference for UntagResources Operation</seealso>
        Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}