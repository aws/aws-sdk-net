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

using Amazon.AutoScaling;
using Amazon.CloudFormation;
using Amazon.CloudFront;
using Amazon.CloudWatch;
using Amazon.DataPipeline;
using Amazon.DirectConnect;
using Amazon.EC2;
using Amazon.ElastiCache;
using Amazon.ElasticBeanstalk;
using Amazon.ElasticLoadBalancing;
using Amazon.ElasticMapReduce;
using Amazon.ElasticTranscoder;
using Amazon.IdentityManagement;
using Amazon.ImportExport;
using Amazon.OpsWorks;
using Amazon.RDS;
using Amazon.Redshift;
using Amazon.Route53;
using Amazon.S3;
using Amazon.SQS;
using Amazon.SecurityToken;
using Amazon.SimpleDB;
using Amazon.SimpleEmail;
using Amazon.SimpleNotificationService;
using Amazon.SimpleWorkflow;
using Amazon.AWSSupport;

using DynamoDBV1 = Amazon.DynamoDB.AmazonDynamoDB;
using DynamoDBClientV1 = Amazon.DynamoDB.AmazonDynamoDBClient;
using AmazonDynamoDBConfigV1 = Amazon.DynamoDB.AmazonDynamoDBConfig;

using DynamoDBV2 = Amazon.DynamoDBv2.AmazonDynamoDB;
using DynamoDBClientV2 = Amazon.DynamoDBv2.AmazonDynamoDBClient;
using AmazonDynamoDBConfigV2 = Amazon.DynamoDBv2.AmazonDynamoDBConfig;

using Amazon.Runtime;

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
        #region EC2

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
        public static AmazonEC2 CreateAmazonEC2Client()
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
        public static AmazonEC2 CreateAmazonEC2Client(AmazonEC2Config config)
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
        public static AmazonEC2 CreateAmazonEC2Client(RegionEndpoint region)
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
        public static AmazonEC2 CreateAmazonEC2Client(
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
        public static AmazonEC2 CreateAmazonEC2Client(AWSCredentials credentials)
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
        public static AmazonEC2 CreateAmazonEC2Client(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonEC2 CreateAmazonEC2Client(AWSCredentials credentials, AmazonEC2Config config)
        {
            return new AmazonEC2Client(credentials, config);
        }

        #endregion

        #region SimpleDB

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
        public static AmazonSimpleDB CreateAmazonSimpleDBClient()
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
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(AmazonSimpleDBConfig config)
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
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(RegionEndpoint region)
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
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(
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
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(AWSCredentials credentials)
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
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonSimpleDB CreateAmazonSimpleDBClient(AWSCredentials credentials, AmazonSimpleDBConfig config)
        {
            return new AmazonSimpleDBClient(credentials, config);
        }

        #endregion

        #region Elastic Map Reduce

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
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient()
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
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AmazonElasticMapReduceConfig config)
        {
            return new AmazonElasticMapReduceClient(config);
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
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(RegionEndpoint region)
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
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(
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
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AWSCredentials credentials)
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
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonElasticMapReduce CreateAmazonElasticMapReduceClient(AWSCredentials credentials, AmazonElasticMapReduceConfig config)
        {
            return new AmazonElasticMapReduceClient(credentials, config);
        }

        #endregion

        #region SQS

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
        public static AmazonSQS CreateAmazonSQSClient()
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
        public static AmazonSQS CreateAmazonSQSClient(AmazonSQSConfig config)
        {
            return new AmazonSQSClient(config);
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
        public static AmazonSQS CreateAmazonSQSClient(RegionEndpoint region)
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
        public static AmazonSQS CreateAmazonSQSClient(
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
        public static AmazonSQS CreateAmazonSQSClient(AWSCredentials credentials)
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
        public static AmazonSQS CreateAmazonSQSClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonSQS CreateAmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig config)
        {
            return new AmazonSQSClient(credentials, config);
        }

        #endregion

        #region CloudWatch

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
        public static AmazonCloudWatch CreateAmazonCloudWatchClient()
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
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(AmazonCloudWatchConfig config)
        {
            return new AmazonCloudWatchClient(config);
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
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(RegionEndpoint region)
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
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(
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
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(AWSCredentials credentials)
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
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonCloudWatch CreateAmazonCloudWatchClient(AWSCredentials credentials, AmazonCloudWatchConfig config)
        {
            return new AmazonCloudWatchClient(credentials, config);
        }

        #endregion

        #region ElasticLoadBalancing

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
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient()
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
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
        {
            return new AmazonElasticLoadBalancingClient(config);
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
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(RegionEndpoint region)
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
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(
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
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AWSCredentials credentials)
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
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonElasticLoadBalancing CreateAmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig config)
        {
            return new AmazonElasticLoadBalancingClient(credentials, config);
        }

        #endregion

        #region AutoScaling

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
        public static AmazonAutoScaling CreateAmazonAutoScalingClient()
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
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(AmazonAutoScalingConfig config)
        {
            return new AmazonAutoScalingClient(config);
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
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(RegionEndpoint region)
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
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(
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
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(AWSCredentials credentials)
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
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonAutoScaling CreateAmazonAutoScalingClient(AWSCredentials credentials, AmazonAutoScalingConfig config)
        {
            return new AmazonAutoScalingClient(credentials, config);
        }

        #endregion

        #region S3

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
        public static AmazonS3 CreateAmazonS3Client()
        {
            return new AmazonS3Client(RegionEndpoint.USEast1);
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
        public static AmazonS3 CreateAmazonS3Client(AmazonS3Config config)
        {
            return new AmazonS3Client(config);
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
        public static AmazonS3 CreateAmazonS3Client(RegionEndpoint region)
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
        public static AmazonS3 CreateAmazonS3Client(
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
        public static AmazonS3 CreateAmazonS3Client(AWSCredentials credentials)
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
        public static AmazonS3 CreateAmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonS3 CreateAmazonS3Client(AWSCredentials credentials, AmazonS3Config config)
        {
            return new AmazonS3Client(credentials, config);
        }

        #endregion

        #region RDS

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
        public static AmazonRDS CreateAmazonRDSClient()
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
        public static AmazonRDS CreateAmazonRDSClient(AmazonRDSConfig config)
        {
            return new AmazonRDSClient(config);
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
        public static AmazonRDS CreateAmazonRDSClient(RegionEndpoint region)
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
        public static AmazonRDS CreateAmazonRDSClient(
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
        public static AmazonRDS CreateAmazonRDSClient(AWSCredentials credentials)
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
        public static AmazonRDS CreateAmazonRDSClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonRDS CreateAmazonRDSClient(AWSCredentials credentials, AmazonRDSConfig config)
        {
            return new AmazonRDSClient(credentials, config);
        }

        #endregion

        #region CloudFront
        
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
        public static AmazonCloudFront CreateAmazonCloudFrontClient()
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
        public static AmazonCloudFront CreateAmazonCloudFrontClient(AmazonCloudFrontConfig config)
        {
            return new AmazonCloudFrontClient(config);
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
        public static AmazonCloudFront CreateAmazonCloudFrontClient(RegionEndpoint region)
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
        public static AmazonCloudFront CreateAmazonCloudFrontClient(
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
        public static AmazonCloudFront CreateAmazonCloudFrontClient(AWSCredentials credentials)
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
        public static AmazonCloudFront CreateAmazonCloudFrontClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonCloudFront CreateAmazonCloudFrontClient(AWSCredentials credentials, AmazonCloudFrontConfig config)
        {
            return new AmazonCloudFrontClient(credentials, config);
        }

        #endregion

        #region SNS
        
        /// <summary>
        /// Create a client for the Amazon SNS Service with the credentials loaded from the application's
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
        /// <returns>An Amazon SNS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient()
        {
            return new AmazonSimpleNotificationServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon SNS Service with the credentials loaded from the application's
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
        /// <returns>An Amazon SNS client</returns>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(AmazonSimpleNotificationServiceConfig config)
        {
            return new AmazonSimpleNotificationServiceClient(config);
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
        /// Create a client for the Amazon SNS Service with the credentials loaded from the application's
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
        /// <returns>An Amazon SNS client</returns>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(RegionEndpoint region)
        {
            return new AmazonSimpleNotificationServiceClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon SNS Service with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SNS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonSimpleNotificationServiceClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon SNS Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon SNS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(AWSCredentials credentials)
        {
            return new AmazonSimpleNotificationServiceClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon SNS Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon SNS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonSimpleNotificationServiceClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon SNS Service with AWSCredentials and an AmazonSNS Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon SNS client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleNotificationService CreateAmazonSNSClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig config)
        {
            return new AmazonSimpleNotificationServiceClient(credentials, config);
        }

        #endregion

        #region IAM
        
        /// <summary>
        /// Create a client for the Amazon IdentityManagement Service with the credentials loaded from the application's
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
        /// <returns>An Amazon IdentityManagement client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementClient()
        {
            return new AmazonIdentityManagementServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon IdentityManagement Service with the credentials loaded from the application's
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
        /// <returns>An Amazon IdentityManagement client</returns>
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementClient(AmazonIdentityManagementServiceConfig config)
        {
            return new AmazonIdentityManagementServiceClient(config);
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
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(RegionEndpoint region)
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
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(
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
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials)
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
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonIdentityManagementService CreateAmazonIdentityManagementServiceClient(AWSCredentials credentials, AmazonIdentityManagementServiceConfig config)
        {
            return new AmazonIdentityManagementServiceClient(credentials, config);
        }

        #endregion

        #region ElasticBeanstalk

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
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient()
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
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AmazonElasticBeanstalkConfig config)
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
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(RegionEndpoint region)
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
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(
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
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AWSCredentials credentials)
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
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonElasticBeanstalk CreateAmazonElasticBeanstalkClient(AWSCredentials credentials, AmazonElasticBeanstalkConfig config)
        {
            return new AmazonElasticBeanstalkClient(credentials, config);
        }

        #endregion

        #region SimpleEmail

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
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient()
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
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AmazonSimpleEmailServiceConfig config)
        {
            return new AmazonSimpleEmailServiceClient(config);
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
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(RegionEndpoint region)
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
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(
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
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AWSCredentials credentials)
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
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonSimpleEmailService CreateAmazonSimpleEmailServiceClient(AWSCredentials credentials, AmazonSimpleEmailServiceConfig config)
        {
            return new AmazonSimpleEmailServiceClient(credentials, config);
        }

        #endregion

        #region CloudFormation
        
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
        public static AmazonCloudFormation CreateAmazonCloudFormationClient()
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
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(AmazonCloudFormationConfig config)
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
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(RegionEndpoint region)
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
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(
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
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(AWSCredentials credentials)
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
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonCloudFormation CreateAmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig config)
        {
            return new AmazonCloudFormationClient(credentials, config);
        }

        #endregion

        #region ElastiCache
        
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient()
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(AmazonElastiCacheConfig config)
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(RegionEndpoint region)
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(AWSCredentials credentials)
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonElastiCache CreateAmazonElastiCacheClient(AWSCredentials credentials, AmazonElastiCacheConfig config)
        {
            return new AmazonElastiCacheClient(credentials, config);
        }

        #endregion

        #region ImportExport

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
        public static AmazonImportExport CreateAmazonImportExportClient()
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
        public static AmazonImportExport CreateAmazonImportExportClient(AmazonImportExportConfig config)
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
        public static AmazonImportExport CreateAmazonImportExportClient(
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
        public static AmazonImportExport CreateAmazonImportExportClient(
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
        public static AmazonImportExport CreateAmazonImportExportClient(RegionEndpoint region)
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
        public static AmazonImportExport CreateAmazonImportExportClient(
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
        public static AmazonImportExport CreateAmazonImportExportClient(AWSCredentials credentials)
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
        public static AmazonImportExport CreateAmazonImportExportClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonImportExport CreateAmazonImportExportClient(AWSCredentials credentials, AmazonImportExportConfig config)
        {
            return new AmazonImportExportClient(credentials, config);
        }

        #endregion

        #region STS

        /// <summary>
        /// Create a client for the Amazon SecurityToken Service with the credentials loaded from the application's
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
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient()
        {
            return new AmazonSecurityTokenServiceClient();
        }

        /// <summary>
        /// Create a client for the Amazon SecurityToken Service with the credentials loaded from the application's
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
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
        {
            return new AmazonSecurityTokenServiceClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityToken Service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSecurityTokenServiceClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SecurityToken Service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SecurityTokenService client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
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
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(RegionEndpoint region)
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
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(
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
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials)
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
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonSecurityTokenService CreateAmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig config)
        {
            return new AmazonSecurityTokenServiceClient(credentials, config);
        }

        #endregion

        #region SimpleWorkflow

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
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient()
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
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AmazonSimpleWorkflowConfig config)
        {
            return new AmazonSimpleWorkflowClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonSimpleWorkflowClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon SimpleWorkflow service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon SimpleWorkflow client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonSimpleWorkflowConfig config
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
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(RegionEndpoint region)
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
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(
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
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AWSCredentials credentials)
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
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonSimpleWorkflow CreateAmazonSimpleWorkflowClient(AWSCredentials credentials, AmazonSimpleWorkflowConfig config)
        {
            return new AmazonSimpleWorkflowClient(credentials, config);
        }

        #endregion

        #region DirectConnect
        
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
        public static AmazonDirectConnect CreateAmazonDirectConnectClient()
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
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(AmazonDirectConnectConfig config)
        {
            return new AmazonDirectConnectClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonDirectConnectClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DirectConnect service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DirectConnect client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonDirectConnectConfig config
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
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(RegionEndpoint region)
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
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(
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
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(AWSCredentials credentials)
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
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonDirectConnect CreateAmazonDirectConnectClient(AWSCredentials credentials, AmazonDirectConnectConfig config)
        {
            return new AmazonDirectConnectClient(credentials, config);
        }

        #endregion

        #region ElasticTranscoder

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
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient()
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
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AmazonElasticTranscoderConfig config)
        {
            return new AmazonElasticTranscoderClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonElasticTranscoderClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon ElasticTranscoder service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon ElasticTranscoder client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonElasticTranscoderConfig config
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
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(RegionEndpoint region)
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
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(
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
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AWSCredentials credentials)
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
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonElasticTranscoder CreateAmazonElasticTranscoderClient(AWSCredentials credentials, AmazonElasticTranscoderConfig config)
        {
            return new AmazonElasticTranscoderClient(credentials, config);
        }

        #endregion

        #region Redshift

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
        public static AmazonRedshift CreateAmazonRedshiftClient()
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
        public static AmazonRedshift CreateAmazonRedshiftClient(AmazonRedshiftConfig config)
        {
            return new AmazonRedshiftClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonRedshift CreateAmazonRedshiftClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonRedshiftClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Redshift service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Redshift client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonRedshift CreateAmazonRedshiftClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonRedshiftConfig config
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
        public static AmazonRedshift CreateAmazonRedshiftClient(RegionEndpoint region)
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
        public static AmazonRedshift CreateAmazonRedshiftClient(
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
        public static AmazonRedshift CreateAmazonRedshiftClient(AWSCredentials credentials)
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
        public static AmazonRedshift CreateAmazonRedshiftClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonRedshift CreateAmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig config)
        {
            return new AmazonRedshiftClient(credentials, config);
        }

        #endregion

        #region AWSSupport

        /// <summary>
        /// Create a client for the Amazon AWS Support API with the credentials loaded from the application's
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
        /// <returns>An Amazon AWS Support API client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient()
        {
            return new AmazonAWSSupportClient();
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with the credentials loaded from the application's
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
        /// <returns>An Amazon AWS Support API client</returns>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(AmazonAWSSupportConfig config)
        {
            return new AmazonAWSSupportClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon AWS Support API client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonAWSSupportClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon AWS Support API client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonAWSSupportConfig config
            )
        {
            return new AmazonAWSSupportClient(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with the credentials loaded from the application's
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
        /// <returns>An Amazon AWS Support API client</returns>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(RegionEndpoint region)
        {
            return new AmazonAWSSupportClient(region);
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AWS Support API client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new AmazonAWSSupportClient(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon AWS Support API client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(AWSCredentials credentials)
        {
            return new AmazonAWSSupportClient(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon AWS Support API client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new AmazonAWSSupportClient(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon AWS Support API with AWSCredentials and an Amazon AWSSupportConfig object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon AWS Support API client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonAWSSupport CreateAmazonAWSSupportClient(AWSCredentials credentials, AmazonAWSSupportConfig config)
        {
            return new AmazonAWSSupportClient(credentials, config);
        }

        

        #endregion

        #region OpsWorks

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
        public static AmazonOpsWorks CreateAmazonOpsWorksClient()
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
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(AmazonOpsWorksConfig config)
        {
            return new AmazonOpsWorksClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonOpsWorksClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon OpsWorks service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon OpsWorks client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonOpsWorksConfig config
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
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(RegionEndpoint region)
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
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(
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
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(AWSCredentials credentials)
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
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonOpsWorks CreateAmazonOpsWorksClient(AWSCredentials credentials, AmazonOpsWorksConfig config)
        {
            return new AmazonOpsWorksClient(credentials, config);
        }

        #endregion

        #region DatePipeline

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
        public static AmazonDataPipeline CreateAmazonDataPipelineClient()
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
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(AmazonDataPipelineConfig config)
        {
            return new AmazonDataPipelineClient(config);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonDataPipelineClient(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DataPipeline service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DataPipeline client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonDataPipelineConfig config
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
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(RegionEndpoint region)
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
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(
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
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(AWSCredentials credentials)
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
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonDataPipeline CreateAmazonDataPipelineClient(AWSCredentials credentials, AmazonDataPipelineConfig config)
        {
            return new AmazonDataPipelineClient(credentials, config);
        }

        #endregion

        #region DynamoDB

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
        public static DynamoDBV1 CreateAmazonDynamoDBClient()
        {
            return new DynamoDBClientV1();
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
        public static DynamoDBV1 CreateAmazonDynamoDBClient(AmazonDynamoDBConfigV1 config)
        {
            return new DynamoDBClientV1(config);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV1 CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new DynamoDBClientV1(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV1 CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonDynamoDBConfigV1 config
            )
        {
            return new DynamoDBClientV1(awsAccessKey, awsSecretAccessKey, config);
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
        public static DynamoDBV1 CreateAmazonDynamoDBClient(RegionEndpoint region)
        {
            return new DynamoDBClientV1(region);
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
        public static DynamoDBV1 CreateAmazonDynamoDBClient(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new DynamoDBClientV1(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV1 CreateAmazonDynamoDBClient(AWSCredentials credentials)
        {
            return new DynamoDBClientV1(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV1 CreateAmazonDynamoDBClient(AWSCredentials credentials, RegionEndpoint region)
        {
            return new DynamoDBClientV1(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service with AWSCredentials and an AmazonDynamoDB Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV1 CreateAmazonDynamoDBClient(AWSCredentials credentials, AmazonDynamoDBConfigV1 config)
        {
            return new DynamoDBClientV1(credentials, config);
        }

        #endregion

        #region DynamoDBv2

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service v2 with the credentials loaded from the application's
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
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client()
        {
            return new DynamoDBClientV2();
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service v2 with the credentials loaded from the application's
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
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(AmazonDynamoDBConfigV2 config)
        {
            return new DynamoDBClientV2(config);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new DynamoDBClientV2(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonDynamoDBConfigV2 config
            )
        {
            return new DynamoDBClientV2(awsAccessKey, awsSecretAccessKey, config);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service v2 with the credentials loaded from the application's
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
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(RegionEndpoint region)
        {
            return new DynamoDBClientV2(region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service v2 with the specified region
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(
            string awsAccessKey,
            string awsSecretAccessKey, RegionEndpoint region
            )
        {
            return new DynamoDBClientV2(awsAccessKey, awsSecretAccessKey, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service v2 with AWSCredentials.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(AWSCredentials credentials)
        {
            return new DynamoDBClientV2(credentials);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service v2 with AWSCredentials and region.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect to.</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(AWSCredentials credentials, RegionEndpoint region)
        {
            return new DynamoDBClientV2(credentials, region);
        }

        /// <summary>
        /// Create a client for the Amazon DynamoDB Service v2 with AWSCredentials and an AmazonDynamoDB Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc</param>
        /// <returns>An Amazon DynamoDB client</returns>
        /// <remarks>
        /// </remarks>
        public static DynamoDBV2 CreateAmazonDynamoDBv2Client(AWSCredentials credentials, AmazonDynamoDBConfigV2 config)
        {
            return new DynamoDBClientV2(credentials, config);
        }

        #endregion

        #region Route53

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
        public static AmazonRoute53 CreateAmazonRoute53Client()
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
        public static AmazonRoute53 CreateAmazonRoute53Client(AmazonRoute53Config config)
        {
            return new AmazonRoute53Client(config);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 service with the default configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonRoute53 CreateAmazonRoute53Client(
            string awsAccessKey,
            string awsSecretAccessKey
            )
        {
            return new AmazonRoute53Client(awsAccessKey, awsSecretAccessKey);
        }

        /// <summary>
        /// Create a client for the Amazon Route53 service with the specified configuration
        /// </summary>
        /// <param name="awsAccessKey">The AWS Access Key associated with the account</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key associated with the account</param>
        /// <param name="config">Configuration options for the service like HTTP Proxy, # of connections, etc
        /// </param>
        /// <returns>An Amazon Route53 client</returns>
        /// <remarks>
        /// </remarks>
        public static AmazonRoute53 CreateAmazonRoute53Client(
            string awsAccessKey,
            string awsSecretAccessKey,
            AmazonRoute53Config config
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
        public static AmazonRoute53 CreateAmazonRoute53Client(RegionEndpoint region)
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
        public static AmazonRoute53 CreateAmazonRoute53Client(
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
        public static AmazonRoute53 CreateAmazonRoute53Client(AWSCredentials credentials)
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
        public static AmazonRoute53 CreateAmazonRoute53Client(AWSCredentials credentials, RegionEndpoint region)
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
        public static AmazonRoute53 CreateAmazonRoute53Client(AWSCredentials credentials, AmazonRoute53Config config)
        {
            return new AmazonRoute53Client(credentials, config);
        }

        #endregion

    }
}