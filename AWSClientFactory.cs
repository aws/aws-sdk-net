/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using Amazon.AutoScaling;
using Amazon.CloudFormation;
using Amazon.CloudFront;
using Amazon.CloudWatch;
using Amazon.EC2;
using Amazon.ElasticBeanstalk;
using Amazon.ElasticLoadBalancing;
using Amazon.ElasticMapReduce;
using Amazon.IdentityManagement;
using Amazon.RDS;
using Amazon.S3;
using Amazon.SQS;
using Amazon.SimpleDB;
using Amazon.SimpleEmail;
using Amazon.SimpleNotificationService;

namespace Amazon
{
    /// <summary>
    /// The Amazon Web Services SDK provides devlopers with a coherent and unified interface to the
    /// suite of Amazon Web Services. The intent is to facilitate the rapid building of
    /// applications that leverage multiple Amazon Web Services.
    /// <para>
    /// To get started, request an instance of the AWSClientFactory via this class's static Instance
    /// member. Use the factory instance to create clients for all the Web Services needed by
    /// the application.</para>
    /// </summary>

    public static class AWSClientFactory
    {
        /// <summary>
        /// Create a client for the Amazon EC2 Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonEC2 CreateAmazonEC2Client(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonEC2Client(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonEC2 CreateAmazonEC2Client(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonEC2Config config
            )
        {
            return new AmazonEC2Client(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSimpleDBClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonSimpleDBConfig config
            )
        {
            return new AmazonSimpleDBClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElasticMaReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElasticMapReduceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonElasticMapReduceConfig config
            )
        {
            return new AmazonElasticMapReduceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SQS service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSQS CreateAmazonSQSClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSQSClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SQS service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSQS CreateAmazonSQSClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonSQSConfig config
            )
        {
            return new AmazonSQSClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonCloudWatchClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonCloudWatchConfig config
            )
        {
            return new AmazonCloudWatchClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon Elastic Load Balancing service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Elastic Load Balancing client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElasticLoadBalancingClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Elastic Load Balancing service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Elastic Load Balancing client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonElasticLoadBalancingConfig config
            )
        {
            return new AmazonElasticLoadBalancingClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon Auto Scaling service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Auto Scaling client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonAutoScalingClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Auto Scaling service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Auto Scaling client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonAutoScalingConfig config
            )
        {
            return new AmazonAutoScalingClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon S3 service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon S3 service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonS3Config config
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon RDS service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonRDS CreateAmazonRDSClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonRDSClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon RDS service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonRDS CreateAmazonRDSClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonRDSConfig config
            )
        {
            return new AmazonRDSClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonCloudFront CreateAmazonCloudFrontClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonCloudFrontClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonCloudFront CreateAmazonCloudFrontClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonCloudFrontConfig config
            )
        {
            return new AmazonCloudFrontClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SNS service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SNS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSimpleNotificationServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SNS service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SNS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonSimpleNotificationServiceConfig config
            )
        {
            return new AmazonSimpleNotificationServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

         /// <summary>
         /// Create a client for the Amazon Identity Management service with the default configuration
         /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
         /// <returns>An Amazon Identity Management client</returns>
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Identity Management service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service</param>
        /// <returns>An Amazon Identity Management client</returns>
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonIdentityManagementServiceConfig config
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElasticBeanstalkClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonElasticBeanstalkConfig config
            )
        {
            return new AmazonElasticBeanstalkClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon Simple Email Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Simple Email Service client</returns>
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSimpleEmailServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Simple Email Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service</param>
        /// <returns>An Amazon Simple Email Service client</returns>
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonSimpleEmailServiceConfig config
            )
        {
            return new AmazonSimpleEmailServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonCloudFormationClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonCloudFormationConfig config
            )
        {
            return new AmazonCloudFormationClient(awsAccessKey, awsSecretAccessKey, config);
        }  
    }
}