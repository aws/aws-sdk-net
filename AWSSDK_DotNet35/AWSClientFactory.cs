
/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using Amazon.Runtime;

using Amazon.AutoScaling;
using Amazon.AWSSupport;
using Amazon.CloudFormation;
using Amazon.CloudFront;
using Amazon.CloudSearch;
using Amazon.CloudTrail;
using Amazon.CloudWatch;
using Amazon.DataPipeline;
using Amazon.DirectConnect;
using Amazon.DynamoDBv2;
using Amazon.EC2;
using Amazon.ElastiCache;
using Amazon.ElasticBeanstalk;
using Amazon.ElasticLoadBalancing;
using Amazon.ElasticMapReduce;
using Amazon.ElasticTranscoder;
using Amazon.Glacier;
using Amazon.IdentityManagement;
using Amazon.ImportExport;
using Amazon.Kinesis;
using Amazon.OpsWorks;
using Amazon.RDS;
using Amazon.Redshift;
using Amazon.Route53;
using Amazon.S3;
using Amazon.SecurityToken;
using Amazon.SimpleDB;
using Amazon.SimpleEmail;
using Amazon.SimpleNotificationService;
using Amazon.SimpleWorkflow;
using Amazon.SQS;
using Amazon.StorageGateway;

namespace Amazon
{
    /// <summary>
    /// The Amazon Web Services SDK provides developers with a coherent and unified interface to the
    /// suite of Amazon Web Services. The intent is to facilitate the rapid building of
    /// applications that leverage multiple Amazon Web Services.
    /// <para>
    /// To get started, request an instance of the AWSClientFactory via this class's static Instance
    /// member. Use the factory instance to create clients for all the Web Services needed by
    /// the application.</para>
    /// </summary>

    public static class AWSClientFactory
    {
        #region Amazon AutoScaling

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon AutoScaling client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient()
        {
            return new AmazonAutoScalingClient();
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon AutoScaling client</returns>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(AmazonAutoScalingConfig config)
        {
            return new AmazonAutoScalingClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon AutoScaling client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonAutoScalingClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon AutoScaling client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonAutoScalingConfig config
            )
        {
            return new AmazonAutoScalingClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AutoScaling client</returns>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(RegionEndpoint region)
        {
            return new AmazonAutoScalingClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AutoScaling client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonAutoScalingClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon AutoScaling client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(AWSCredentials credentials)
        {
            return new AmazonAutoScalingClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AutoScaling client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonAutoScalingClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon AutoScaling Service with AWSCredentials and an AmazonAutoScaling Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon AutoScaling client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAutoScaling CreateAmazonAutoScalingClient(AWSCredentials credentials, AmazonAutoScalingConfig config)
        {
            return new AmazonAutoScalingClient(credentials, config);
        }
		#endregion

        #region Amazon AWSSupport

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon AWSSupport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient()
        {
            return new AmazonAWSSupportClient();
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon AWSSupport client</returns>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(AmazonAWSSupportConfig config)
        {
            return new AmazonAWSSupportClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon AWSSupport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonAWSSupportClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon AWSSupport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonAWSSupportConfig config
            )
        {
            return new AmazonAWSSupportClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AWSSupport client</returns>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(RegionEndpoint region)
        {
            return new AmazonAWSSupportClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AWSSupport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonAWSSupportClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon AWSSupport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(AWSCredentials credentials)
        {
            return new AmazonAWSSupportClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AWSSupport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonAWSSupportClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon AWSSupport Service with AWSCredentials and an AmazonAWSSupport Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon AWSSupport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonAWSSupport CreateAmazonAWSSupportClient(AWSCredentials credentials, AmazonAWSSupportConfig config)
        {
            return new AmazonAWSSupportClient(credentials, config);
        }
		#endregion

        #region Amazon CloudFormation

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient()
        {
            return new AmazonCloudFormationClient();
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudFormation client</returns>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(AmazonCloudFormationConfig config)
        {
            return new AmazonCloudFormationClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(
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
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonCloudFormationConfig config
            )
        {
            return new AmazonCloudFormationClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudFormation client</returns>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(RegionEndpoint region)
        {
            return new AmazonCloudFormationClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonCloudFormationClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(AWSCredentials credentials)
        {
            return new AmazonCloudFormationClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonCloudFormationClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFormation Service with AWSCredentials and an AmazonCloudFormation Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudFormation client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFormation CreateAmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig config)
        {
            return new AmazonCloudFormationClient(credentials, config);
        }
		#endregion

        #region Amazon CloudFront

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient()
        {
            return new AmazonCloudFrontClient();
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudFront client</returns>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(AmazonCloudFrontConfig config)
        {
            return new AmazonCloudFrontClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonCloudFrontClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonCloudFrontConfig config
            )
        {
            return new AmazonCloudFrontClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudFront client</returns>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(RegionEndpoint region)
        {
            return new AmazonCloudFrontClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonCloudFrontClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(AWSCredentials credentials)
        {
            return new AmazonCloudFrontClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonCloudFrontClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudFront Service with AWSCredentials and an AmazonCloudFront Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudFront client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudFront CreateAmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig config)
        {
            return new AmazonCloudFrontClient(credentials, config);
        }
		#endregion

        #region Amazon CloudSearch

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon CloudSearch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient()
        {
            return new AmazonCloudSearchClient();
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudSearch client</returns>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(AmazonCloudSearchConfig config)
        {
            return new AmazonCloudSearchClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudSearch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonCloudSearchClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon CloudSearch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonCloudSearchConfig config
            )
        {
            return new AmazonCloudSearchClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudSearch client</returns>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(RegionEndpoint region)
        {
            return new AmazonCloudSearchClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudSearch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonCloudSearchClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon CloudSearch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(AWSCredentials credentials)
        {
            return new AmazonCloudSearchClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudSearch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonCloudSearchClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudSearch Service with AWSCredentials and an AmazonCloudSearch Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudSearch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudSearch CreateAmazonCloudSearchClient(AWSCredentials credentials, AmazonCloudSearchConfig config)
        {
            return new AmazonCloudSearchClient(credentials, config);
        }
		#endregion

        #region Amazon CloudTrail

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon CloudTrail client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient()
        {
            return new AmazonCloudTrailClient();
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudTrail client</returns>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(AmazonCloudTrailConfig config)
        {
            return new AmazonCloudTrailClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudTrail client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonCloudTrailClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon CloudTrail client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonCloudTrailConfig config
            )
        {
            return new AmazonCloudTrailClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudTrail client</returns>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(RegionEndpoint region)
        {
            return new AmazonCloudTrailClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudTrail client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonCloudTrailClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon CloudTrail client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(AWSCredentials credentials)
        {
            return new AmazonCloudTrailClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudTrail client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonCloudTrailClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudTrail Service with AWSCredentials and an AmazonCloudTrail Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudTrail client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudTrail CreateAmazonCloudTrailClient(AWSCredentials credentials, AmazonCloudTrailConfig config)
        {
            return new AmazonCloudTrailClient(credentials, config);
        }
		#endregion

        #region Amazon CloudWatch

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient()
        {
            return new AmazonCloudWatchClient();
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudWatch client</returns>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(AmazonCloudWatchConfig config)
        {
            return new AmazonCloudWatchClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonCloudWatchClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonCloudWatchConfig config
            )
        {
            return new AmazonCloudWatchClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudWatch client</returns>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(RegionEndpoint region)
        {
            return new AmazonCloudWatchClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonCloudWatchClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(AWSCredentials credentials)
        {
            return new AmazonCloudWatchClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonCloudWatchClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon CloudWatch Service with AWSCredentials and an AmazonCloudWatch Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon CloudWatch client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonCloudWatch CreateAmazonCloudWatchClient(AWSCredentials credentials, AmazonCloudWatchConfig config)
        {
            return new AmazonCloudWatchClient(credentials, config);
        }
		#endregion

        #region Amazon DataPipeline

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient()
        {
            return new AmazonDataPipelineClient();
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DataPipeline client</returns>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(AmazonDataPipelineConfig config)
        {
            return new AmazonDataPipelineClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonDataPipelineClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonDataPipelineConfig config
            )
        {
            return new AmazonDataPipelineClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DataPipeline client</returns>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(RegionEndpoint region)
        {
            return new AmazonDataPipelineClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonDataPipelineClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(AWSCredentials credentials)
        {
            return new AmazonDataPipelineClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonDataPipelineClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline Service with AWSCredentials and an AmazonDataPipeline Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDataPipeline CreateAmazonDataPipelineClient(AWSCredentials credentials, AmazonDataPipelineConfig config)
        {
            return new AmazonDataPipelineClient(credentials, config);
        }
		#endregion

        #region Amazon DirectConnect

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient()
        {
            return new AmazonDirectConnectClient();
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DirectConnect client</returns>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(AmazonDirectConnectConfig config)
        {
            return new AmazonDirectConnectClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonDirectConnectClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonDirectConnectConfig config
            )
        {
            return new AmazonDirectConnectClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DirectConnect client</returns>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(RegionEndpoint region)
        {
            return new AmazonDirectConnectClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonDirectConnectClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(AWSCredentials credentials)
        {
            return new AmazonDirectConnectClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonDirectConnectClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect Service with AWSCredentials and an AmazonDirectConnect Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDirectConnect CreateAmazonDirectConnectClient(AWSCredentials credentials, AmazonDirectConnectConfig config)
        {
            return new AmazonDirectConnectClient(credentials, config);
        }
		#endregion

        #region Amazon DynamoDB

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient()
        {
            return new AmazonDynamoDBClient();
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DynamoDB client</returns>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AmazonDynamoDBConfig config)
        {
            return new AmazonDynamoDBClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonDynamoDBClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonDynamoDBConfig config
            )
        {
            return new AmazonDynamoDBClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(RegionEndpoint region)
        {
            return new AmazonDynamoDBClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonDynamoDBClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AWSCredentials credentials)
        {
            return new AmazonDynamoDBClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonDynamoDBClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials and an AmazonDynamoDB Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonDynamoDB CreateAmazonDynamoDBClient(AWSCredentials credentials, AmazonDynamoDBConfig config)
        {
            return new AmazonDynamoDBClient(credentials, config);
        }
		#endregion

        #region Amazon EC2

        /// <summary>
        /// Create a client for the Amazon EC2 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonEC2 CreateAmazonEC2Client()
        {
            return new AmazonEC2Client();
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon EC2 client</returns>
        public static IAmazonEC2 CreateAmazonEC2Client(AmazonEC2Config config)
        {
            return new AmazonEC2Client(config);
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonEC2 CreateAmazonEC2Client(
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
        public static IAmazonEC2 CreateAmazonEC2Client(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonEC2Config config
            )
        {
            return new AmazonEC2Client(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon EC2 client</returns>
        public static IAmazonEC2 CreateAmazonEC2Client(RegionEndpoint region)
        {
            return new AmazonEC2Client(region);
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonEC2 CreateAmazonEC2Client(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonEC2Client(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonEC2 CreateAmazonEC2Client(AWSCredentials credentials)
        {
            return new AmazonEC2Client(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonEC2 CreateAmazonEC2Client(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonEC2Client(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon EC2 Service with AWSCredentials and an AmazonEC2 Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon EC2 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonEC2 CreateAmazonEC2Client(AWSCredentials credentials, AmazonEC2Config config)
        {
            return new AmazonEC2Client(credentials, config);
        }
		#endregion

        #region Amazon ElastiCache

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon ElastiCache client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient()
        {
            return new AmazonElastiCacheClient();
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElastiCache client</returns>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(AmazonElastiCacheConfig config)
        {
            return new AmazonElastiCacheClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElastiCache client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElastiCacheClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ElastiCache client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonElastiCacheConfig config
            )
        {
            return new AmazonElastiCacheClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElastiCache client</returns>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(RegionEndpoint region)
        {
            return new AmazonElastiCacheClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElastiCache client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonElastiCacheClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon ElastiCache client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(AWSCredentials credentials)
        {
            return new AmazonElastiCacheClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElastiCache client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonElastiCacheClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElastiCache Service with AWSCredentials and an AmazonElastiCache Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElastiCache client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElastiCache CreateAmazonElastiCacheClient(AWSCredentials credentials, AmazonElastiCacheConfig config)
        {
            return new AmazonElastiCacheClient(credentials, config);
        }
		#endregion

        #region Amazon ElasticBeanstalk

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient()
        {
            return new AmazonElasticBeanstalkClient();
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AmazonElasticBeanstalkConfig config)
        {
            return new AmazonElasticBeanstalkClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(
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
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonElasticBeanstalkConfig config
            )
        {
            return new AmazonElasticBeanstalkClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(RegionEndpoint region)
        {
            return new AmazonElasticBeanstalkClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonElasticBeanstalkClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AWSCredentials credentials)
        {
            return new AmazonElasticBeanstalkClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonElasticBeanstalkClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticBeanstalk Service with AWSCredentials and an AmazonElasticBeanstalk Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticBeanstalk client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AWSCredentials credentials, AmazonElasticBeanstalkConfig config)
        {
            return new AmazonElasticBeanstalkClient(credentials, config);
        }
		#endregion

        #region Amazon ElasticLoadBalancing

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient()
        {
            return new AmazonElasticLoadBalancingClient();
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
        {
            return new AmazonElasticLoadBalancingClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElasticLoadBalancingClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonElasticLoadBalancingConfig config
            )
        {
            return new AmazonElasticLoadBalancingClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(RegionEndpoint region)
        {
            return new AmazonElasticLoadBalancingClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonElasticLoadBalancingClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AWSCredentials credentials)
        {
            return new AmazonElasticLoadBalancingClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonElasticLoadBalancingClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticLoadBalancing Service with AWSCredentials and an AmazonElasticLoadBalancing Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticLoadBalancing client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig config)
        {
            return new AmazonElasticLoadBalancingClient(credentials, config);
        }
		#endregion

        #region Amazon ElasticMapReduce

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient()
        {
            return new AmazonElasticMapReduceClient();
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AmazonElasticMapReduceConfig config)
        {
            return new AmazonElasticMapReduceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElasticMapReduceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonElasticMapReduceConfig config
            )
        {
            return new AmazonElasticMapReduceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(RegionEndpoint region)
        {
            return new AmazonElasticMapReduceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonElasticMapReduceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AWSCredentials credentials)
        {
            return new AmazonElasticMapReduceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonElasticMapReduceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticMapReduce Service with AWSCredentials and an AmazonElasticMapReduce Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticMapReduce client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AWSCredentials credentials, AmazonElasticMapReduceConfig config)
        {
            return new AmazonElasticMapReduceClient(credentials, config);
        }
		#endregion

        #region Amazon ElasticTranscoder

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient()
        {
            return new AmazonElasticTranscoderClient();
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AmazonElasticTranscoderConfig config)
        {
            return new AmazonElasticTranscoderClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElasticTranscoderClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonElasticTranscoderConfig config
            )
        {
            return new AmazonElasticTranscoderClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(RegionEndpoint region)
        {
            return new AmazonElasticTranscoderClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonElasticTranscoderClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AWSCredentials credentials)
        {
            return new AmazonElasticTranscoderClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonElasticTranscoderClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder Service with AWSCredentials and an AmazonElasticTranscoder Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AWSCredentials credentials, AmazonElasticTranscoderConfig config)
        {
            return new AmazonElasticTranscoderClient(credentials, config);
        }
		#endregion

        #region Amazon Glacier

        /// <summary>
        /// Create a client for the Amazon Glacier Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon Glacier client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonGlacier CreateAmazonGlacierClient()
        {
            return new AmazonGlacierClient();
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Glacier client</returns>
        public static IAmazonGlacier CreateAmazonGlacierClient(AmazonGlacierConfig config)
        {
            return new AmazonGlacierClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Glacier client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonGlacier CreateAmazonGlacierClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonGlacierClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Glacier client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonGlacier CreateAmazonGlacierClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonGlacierConfig config
            )
        {
            return new AmazonGlacierClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Glacier client</returns>
        public static IAmazonGlacier CreateAmazonGlacierClient(RegionEndpoint region)
        {
            return new AmazonGlacierClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Glacier client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonGlacier CreateAmazonGlacierClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonGlacierClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon Glacier client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonGlacier CreateAmazonGlacierClient(AWSCredentials credentials)
        {
            return new AmazonGlacierClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Glacier client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonGlacier CreateAmazonGlacierClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonGlacierClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon Glacier Service with AWSCredentials and an AmazonGlacier Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Glacier client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonGlacier CreateAmazonGlacierClient(AWSCredentials credentials, AmazonGlacierConfig config)
        {
            return new AmazonGlacierClient(credentials, config);
        }
		#endregion

        #region Amazon IdentityManagementService

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient()
        {
            return new AmazonIdentityManagementServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AmazonIdentityManagementServiceConfig config)
        {
            return new AmazonIdentityManagementServiceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonIdentityManagementServiceConfig config
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(RegionEndpoint region)
        {
            return new AmazonIdentityManagementServiceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonIdentityManagementServiceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials)
        {
            return new AmazonIdentityManagementServiceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonIdentityManagementServiceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagementService Service with AWSCredentials and an AmazonIdentityManagementService Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon IdentityManagementService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials, AmazonIdentityManagementServiceConfig config)
        {
            return new AmazonIdentityManagementServiceClient(credentials, config);
        }
		#endregion

        #region Amazon ImportExport

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon ImportExport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonImportExport CreateAmazonImportExportClient()
        {
            return new AmazonImportExportClient();
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ImportExport client</returns>
        public static IAmazonImportExport CreateAmazonImportExportClient(AmazonImportExportConfig config)
        {
            return new AmazonImportExportClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ImportExport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonImportExport CreateAmazonImportExportClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonImportExportClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ImportExport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonImportExport CreateAmazonImportExportClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonImportExportConfig config
            )
        {
            return new AmazonImportExportClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ImportExport client</returns>
        public static IAmazonImportExport CreateAmazonImportExportClient(RegionEndpoint region)
        {
            return new AmazonImportExportClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ImportExport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonImportExport CreateAmazonImportExportClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonImportExportClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon ImportExport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonImportExport CreateAmazonImportExportClient(AWSCredentials credentials)
        {
            return new AmazonImportExportClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon ImportExport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonImportExport CreateAmazonImportExportClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonImportExportClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon ImportExport Service with AWSCredentials and an AmazonImportExport Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon ImportExport client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonImportExport CreateAmazonImportExportClient(AWSCredentials credentials, AmazonImportExportConfig config)
        {
            return new AmazonImportExportClient(credentials, config);
        }
		#endregion

        #region Amazon Kinesis

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon Kinesis client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonKinesis CreateAmazonKinesisClient()
        {
            return new AmazonKinesisClient();
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Kinesis client</returns>
        public static IAmazonKinesis CreateAmazonKinesisClient(AmazonKinesisConfig config)
        {
            return new AmazonKinesisClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Kinesis client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonKinesis CreateAmazonKinesisClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonKinesisClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Kinesis client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonKinesis CreateAmazonKinesisClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonKinesisConfig config
            )
        {
            return new AmazonKinesisClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Kinesis client</returns>
        public static IAmazonKinesis CreateAmazonKinesisClient(RegionEndpoint region)
        {
            return new AmazonKinesisClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Kinesis client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonKinesis CreateAmazonKinesisClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonKinesisClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon Kinesis client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonKinesis CreateAmazonKinesisClient(AWSCredentials credentials)
        {
            return new AmazonKinesisClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Kinesis client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonKinesis CreateAmazonKinesisClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonKinesisClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon Kinesis Service with AWSCredentials and an AmazonKinesis Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Kinesis client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonKinesis CreateAmazonKinesisClient(AWSCredentials credentials, AmazonKinesisConfig config)
        {
            return new AmazonKinesisClient(credentials, config);
        }
		#endregion

        #region Amazon OpsWorks

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient()
        {
            return new AmazonOpsWorksClient();
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon OpsWorks client</returns>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(AmazonOpsWorksConfig config)
        {
            return new AmazonOpsWorksClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonOpsWorksClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonOpsWorksConfig config
            )
        {
            return new AmazonOpsWorksClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon OpsWorks client</returns>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(RegionEndpoint region)
        {
            return new AmazonOpsWorksClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonOpsWorksClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(AWSCredentials credentials)
        {
            return new AmazonOpsWorksClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonOpsWorksClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks Service with AWSCredentials and an AmazonOpsWorks Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonOpsWorks CreateAmazonOpsWorksClient(AWSCredentials credentials, AmazonOpsWorksConfig config)
        {
            return new AmazonOpsWorksClient(credentials, config);
        }
		#endregion

        #region Amazon RDS

        /// <summary>
        /// Create a client for the Amazon RDS Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRDS CreateAmazonRDSClient()
        {
            return new AmazonRDSClient();
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon RDS client</returns>
        public static IAmazonRDS CreateAmazonRDSClient(AmazonRDSConfig config)
        {
            return new AmazonRDSClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRDS CreateAmazonRDSClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonRDSClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRDS CreateAmazonRDSClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonRDSConfig config
            )
        {
            return new AmazonRDSClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon RDS client</returns>
        public static IAmazonRDS CreateAmazonRDSClient(RegionEndpoint region)
        {
            return new AmazonRDSClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRDS CreateAmazonRDSClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonRDSClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRDS CreateAmazonRDSClient(AWSCredentials credentials)
        {
            return new AmazonRDSClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRDS CreateAmazonRDSClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonRDSClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon RDS Service with AWSCredentials and an AmazonRDS Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon RDS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRDS CreateAmazonRDSClient(AWSCredentials credentials, AmazonRDSConfig config)
        {
            return new AmazonRDSClient(credentials, config);
        }
		#endregion

        #region Amazon Redshift

        /// <summary>
        /// Create a client for the Amazon Redshift Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRedshift CreateAmazonRedshiftClient()
        {
            return new AmazonRedshiftClient();
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Redshift client</returns>
        public static IAmazonRedshift CreateAmazonRedshiftClient(AmazonRedshiftConfig config)
        {
            return new AmazonRedshiftClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRedshift CreateAmazonRedshiftClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonRedshiftClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRedshift CreateAmazonRedshiftClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonRedshiftConfig config
            )
        {
            return new AmazonRedshiftClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Redshift client</returns>
        public static IAmazonRedshift CreateAmazonRedshiftClient(RegionEndpoint region)
        {
            return new AmazonRedshiftClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRedshift CreateAmazonRedshiftClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonRedshiftClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRedshift CreateAmazonRedshiftClient(AWSCredentials credentials)
        {
            return new AmazonRedshiftClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRedshift CreateAmazonRedshiftClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonRedshiftClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift Service with AWSCredentials and an AmazonRedshift Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRedshift CreateAmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig config)
        {
            return new AmazonRedshiftClient(credentials, config);
        }
		#endregion

        #region Amazon Route53

        /// <summary>
        /// Create a client for the Amazon Route53 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRoute53 CreateAmazonRoute53Client()
        {
            return new AmazonRoute53Client();
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Route53 client</returns>
        public static IAmazonRoute53 CreateAmazonRoute53Client(AmazonRoute53Config config)
        {
            return new AmazonRoute53Client(config);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRoute53 CreateAmazonRoute53Client(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonRoute53Client(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRoute53 CreateAmazonRoute53Client(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonRoute53Config config
            )
        {
            return new AmazonRoute53Client(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Route53 client</returns>
        public static IAmazonRoute53 CreateAmazonRoute53Client(RegionEndpoint region)
        {
            return new AmazonRoute53Client(region);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRoute53 CreateAmazonRoute53Client(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonRoute53Client(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRoute53 CreateAmazonRoute53Client(AWSCredentials credentials)
        {
            return new AmazonRoute53Client(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRoute53 CreateAmazonRoute53Client(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonRoute53Client(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 Service with AWSCredentials and an AmazonRoute53 Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonRoute53 CreateAmazonRoute53Client(AWSCredentials credentials, AmazonRoute53Config config)
        {
            return new AmazonRoute53Client(credentials, config);
        }
		#endregion

        #region Amazon S3

        /// <summary>
        /// Create a client for the Amazon S3 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client()
        {
            return new AmazonS3Client();
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon S3 client</returns>
        public static IAmazonS3 CreateAmazonS3Client(AmazonS3Config config)
        {
            return new AmazonS3Client(config);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonS3Config config
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon S3 client</returns>
        public static IAmazonS3 CreateAmazonS3Client(RegionEndpoint region)
        {
            return new AmazonS3Client(region);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonS3Client(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(AWSCredentials credentials)
        {
            return new AmazonS3Client(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonS3Client(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon S3 Service with AWSCredentials and an AmazonS3 Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon S3 client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonS3 CreateAmazonS3Client(AWSCredentials credentials, AmazonS3Config config)
        {
            return new AmazonS3Client(credentials, config);
        }
		#endregion

        #region Amazon SecurityTokenService

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient()
        {
            return new AmazonSecurityTokenServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
        {
            return new AmazonSecurityTokenServiceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSecurityTokenServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonSecurityTokenServiceConfig config
            )
        {
            return new AmazonSecurityTokenServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(RegionEndpoint region)
        {
            return new AmazonSecurityTokenServiceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSecurityTokenServiceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials)
        {
            return new AmazonSecurityTokenServiceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSecurityTokenServiceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityTokenService Service with AWSCredentials and an AmazonSecurityTokenService Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig config)
        {
            return new AmazonSecurityTokenServiceClient(credentials, config);
        }
		#endregion

        #region Amazon SimpleDB

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient()
        {
            return new AmazonSimpleDBClient();
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleDB client</returns>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(AmazonSimpleDBConfig config)
        {
            return new AmazonSimpleDBClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(
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
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonSimpleDBConfig config
            )
        {
            return new AmazonSimpleDBClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleDB client</returns>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(RegionEndpoint region)
        {
            return new AmazonSimpleDBClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSimpleDBClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(AWSCredentials credentials)
        {
            return new AmazonSimpleDBClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSimpleDBClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleDB Service with AWSCredentials and an AmazonSimpleDB Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleDB client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleDB CreateAmazonSimpleDBClient(AWSCredentials credentials, AmazonSimpleDBConfig config)
        {
            return new AmazonSimpleDBClient(credentials, config);
        }
		#endregion

        #region Amazon SimpleEmailService

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon SimpleEmailService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient()
        {
            return new AmazonSimpleEmailServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AmazonSimpleEmailServiceConfig config)
        {
            return new AmazonSimpleEmailServiceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSimpleEmailServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonSimpleEmailServiceConfig config
            )
        {
            return new AmazonSimpleEmailServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(RegionEndpoint region)
        {
            return new AmazonSimpleEmailServiceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSimpleEmailServiceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AWSCredentials credentials)
        {
            return new AmazonSimpleEmailServiceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSimpleEmailServiceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleEmailService Service with AWSCredentials and an AmazonSimpleEmailService Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleEmailService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig config)
        {
            return new AmazonSimpleEmailServiceClient(credentials, config);
        }
		#endregion

        #region Amazon SimpleNotificationService

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient()
        {
            return new AmazonSimpleNotificationServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(AmazonSimpleNotificationServiceConfig config)
        {
            return new AmazonSimpleNotificationServiceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSimpleNotificationServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonSimpleNotificationServiceConfig config
            )
        {
            return new AmazonSimpleNotificationServiceClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(RegionEndpoint region)
        {
            return new AmazonSimpleNotificationServiceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSimpleNotificationServiceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(AWSCredentials credentials)
        {
            return new AmazonSimpleNotificationServiceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSimpleNotificationServiceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleNotificationService Service with AWSCredentials and an AmazonSimpleNotificationService Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleNotificationService client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleNotificationService CreateAmazonSimpleNotificationServiceClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig config)
        {
            return new AmazonSimpleNotificationServiceClient(credentials, config);
        }
		#endregion

        #region Amazon SimpleWorkflow

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient()
        {
            return new AmazonSimpleWorkflowClient();
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AmazonSimpleWorkflowConfig config)
        {
            return new AmazonSimpleWorkflowClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSimpleWorkflowClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonSimpleWorkflowConfig config
            )
        {
            return new AmazonSimpleWorkflowClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(RegionEndpoint region)
        {
            return new AmazonSimpleWorkflowClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSimpleWorkflowClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AWSCredentials credentials)
        {
            return new AmazonSimpleWorkflowClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSimpleWorkflowClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow Service with AWSCredentials and an AmazonSimpleWorkflow Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AWSCredentials credentials, AmazonSimpleWorkflowConfig config)
        {
            return new AmazonSimpleWorkflowClient(credentials, config);
        }
		#endregion

        #region Amazon SQS

        /// <summary>
        /// Create a client for the Amazon SQS Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSQS CreateAmazonSQSClient()
        {
            return new AmazonSQSClient();
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SQS client</returns>
        public static IAmazonSQS CreateAmazonSQSClient(AmazonSQSConfig config)
        {
            return new AmazonSQSClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSQS CreateAmazonSQSClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSQSClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSQS CreateAmazonSQSClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonSQSConfig config
            )
        {
            return new AmazonSQSClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SQS client</returns>
        public static IAmazonSQS CreateAmazonSQSClient(RegionEndpoint region)
        {
            return new AmazonSQSClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSQS CreateAmazonSQSClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSQSClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSQS CreateAmazonSQSClient(AWSCredentials credentials)
        {
            return new AmazonSQSClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSQS CreateAmazonSQSClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSQSClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SQS Service with AWSCredentials and an AmazonSQS Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SQS client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonSQS CreateAmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig config)
        {
            return new AmazonSQSClient(credentials, config);
        }
		#endregion

        #region Amazon StorageGateway

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <returns>An Amazon StorageGateway client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient()
        {
            return new AmazonStorageGatewayClient();
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon StorageGateway client</returns>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(AmazonStorageGatewayConfig config)
        {
            return new AmazonStorageGatewayClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon StorageGateway client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonStorageGatewayClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon StorageGateway client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(
            string awsAccessKey,
            string awsSecretAccessKey, AmazonStorageGatewayConfig config
            )
        {
            return new AmazonStorageGatewayClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        /// </summary>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon StorageGateway client</returns>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(RegionEndpoint region)
        {
            return new AmazonStorageGatewayClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon StorageGateway client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonStorageGatewayClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon StorageGateway client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(AWSCredentials credentials)
        {
            return new AmazonStorageGatewayClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon StorageGateway client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonStorageGatewayClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon StorageGateway Service with AWSCredentials and an AmazonStorageGateway Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon StorageGateway client</returns>
        /// <remarks>
        /// </remarks>
        public static IAmazonStorageGateway CreateAmazonStorageGatewayClient(AWSCredentials credentials, AmazonStorageGatewayConfig config)
        {
            return new AmazonStorageGatewayClient(credentials, config);
        }
		#endregion


	}
}