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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations;
using Amazon.KinesisAnalyticsV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisAnalyticsV2
{
    /// <summary>
    /// Implementation for accessing KinesisAnalyticsV2
    ///
    /// Amazon Kinesis Data Analytics is a fully managed service that you can use to process
    /// and analyze streaming data using Java, SQL, or Scala. The service enables you to quickly
    /// author and run Java, SQL, or Scala code against streaming sources to perform time
    /// series analytics, feed real-time dashboards, and create real-time metrics.
    /// </summary>
    public partial class AmazonKinesisAnalyticsV2Client : AmazonServiceClient, IAmazonKinesisAnalyticsV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisAnalyticsV2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKinesisAnalyticsV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisAnalyticsV2Config()) { }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisAnalyticsV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisAnalyticsV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKinesisAnalyticsV2Client Configuration Object</param>
        public AmazonKinesisAnalyticsV2Client(AmazonKinesisAnalyticsV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisAnalyticsV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisAnalyticsV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisAnalyticsV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisAnalyticsV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Credentials and an
        /// AmazonKinesisAnalyticsV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisAnalyticsV2Client Configuration Object</param>
        public AmazonKinesisAnalyticsV2Client(AWSCredentials credentials, AmazonKinesisAnalyticsV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisAnalyticsV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisAnalyticsV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisAnalyticsV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisAnalyticsV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisAnalyticsV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisAnalyticsV2Client Configuration Object</param>
        public AmazonKinesisAnalyticsV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisAnalyticsV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisAnalyticsV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisAnalyticsV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisAnalyticsV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisAnalyticsV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisAnalyticsV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisAnalyticsV2Client Configuration Object</param>
        public AmazonKinesisAnalyticsV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisAnalyticsV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisAnalyticsV2EndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AddApplicationCloudWatchLoggingOption

        internal virtual AddApplicationCloudWatchLoggingOptionResponse AddApplicationCloudWatchLoggingOption(AddApplicationCloudWatchLoggingOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<AddApplicationCloudWatchLoggingOptionResponse>(request, options);
        }



        /// <summary>
        /// Adds an Amazon CloudWatch log stream to monitor application configuration errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        public virtual Task<AddApplicationCloudWatchLoggingOptionResponse> AddApplicationCloudWatchLoggingOptionAsync(AddApplicationCloudWatchLoggingOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationCloudWatchLoggingOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationInput

        internal virtual AddApplicationInputResponse AddApplicationInput(AddApplicationInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputResponse>(request, options);
        }



        /// <summary>
        /// Adds a streaming source to your SQL-based Kinesis Data Analytics application. 
        /// 
        ///  
        /// <para>
        /// You can add a streaming source when you create an application, or you can use this
        /// operation to add a streaming source after you create an application. For more information,
        /// see <a>CreateApplication</a>.
        /// </para>
        ///  
        /// <para>
        /// Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a>DescribeApplication</a>
        /// operation to find the current application version. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationInput service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.CodeValidationException">
        /// The user-provided application code (query) is not valid. This can be a simple syntax
        /// error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
        public virtual Task<AddApplicationInputResponse> AddApplicationInputAsync(AddApplicationInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationInputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationInputProcessingConfiguration

        internal virtual AddApplicationInputProcessingConfigurationResponse AddApplicationInputProcessingConfiguration(AddApplicationInputProcessingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputProcessingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Adds an <a>InputProcessingConfiguration</a> to a SQL-based Kinesis Data Analytics
        /// application. An input processor pre-processes records on the input stream before the
        /// application's SQL code executes. Currently, the only input processor available is
        /// <a href="https://docs.aws.amazon.com/lambda/">Amazon Lambda</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationInputProcessingConfiguration service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
        public virtual Task<AddApplicationInputProcessingConfigurationResponse> AddApplicationInputProcessingConfigurationAsync(AddApplicationInputProcessingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationInputProcessingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationOutput

        internal virtual AddApplicationOutputResponse AddApplicationOutput(AddApplicationOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationOutputResponse>(request, options);
        }



        /// <summary>
        /// Adds an external destination to your SQL-based Kinesis Data Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want Kinesis Data Analytics to deliver data from an in-application stream within
        /// your application to an external destination (such as an Kinesis data stream, a Kinesis
        /// Data Firehose delivery stream, or an Amazon Lambda function), you add the relevant
        /// configuration to your application using this operation. You can configure one or more
        /// outputs for your application. Each output configuration maps an in-application stream
        /// and an external destination.
        /// </para>
        ///  
        /// <para>
        ///  You can use one of the output configurations to deliver data from your in-application
        /// error stream to an external destination so that you can analyze the errors. 
        /// </para>
        ///  
        /// <para>
        ///  Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a>DescribeApplication</a>
        /// operation to find the current application version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationOutput service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
        public virtual Task<AddApplicationOutputResponse> AddApplicationOutputAsync(AddApplicationOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationOutputResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationReferenceDataSource

        internal virtual AddApplicationReferenceDataSourceResponse AddApplicationReferenceDataSource(AddApplicationReferenceDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<AddApplicationReferenceDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Adds a reference data source to an existing SQL-based Kinesis Data Analytics application.
        /// 
        ///  
        /// <para>
        /// Kinesis Data Analytics reads reference data (that is, an Amazon S3 object) and creates
        /// an in-application table within your application. In the request, you provide the source
        /// (S3 bucket name and object key name), name of the in-application table to create,
        /// and the necessary mapping information that describes how data in an Amazon S3 object
        /// maps to columns in the resulting in-application table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationReferenceDataSource service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        public virtual Task<AddApplicationReferenceDataSourceResponse> AddApplicationReferenceDataSourceAsync(AddApplicationReferenceDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationReferenceDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationVpcConfiguration

        internal virtual AddApplicationVpcConfigurationResponse AddApplicationVpcConfiguration(AddApplicationVpcConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationVpcConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationVpcConfigurationResponseUnmarshaller.Instance;

            return Invoke<AddApplicationVpcConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Adds a Virtual Private Cloud (VPC) configuration to the application. Applications
        /// can use VPCs to store and access resources securely.
        /// 
        ///  
        /// <para>
        /// Note the following about VPC configurations for Kinesis Data Analytics applications:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VPC configurations are not supported for SQL applications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When a VPC is added to a Kinesis Data Analytics application, the application can no
        /// longer be accessed from the Internet directly. To enable Internet access to the application,
        /// add an Internet gateway to your VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationVpcConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationVpcConfiguration service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationVpcConfiguration">REST API Reference for AddApplicationVpcConfiguration Operation</seealso>
        public virtual Task<AddApplicationVpcConfigurationResponse> AddApplicationVpcConfigurationAsync(AddApplicationVpcConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationVpcConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationVpcConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationVpcConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates a Kinesis Data Analytics application. For information about creating a Kinesis
        /// Data Analytics application, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/getting-started.html">Creating
        /// an Application</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.CodeValidationException">
        /// The user-provided application code (query) is not valid. This can be a simple syntax
        /// error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.LimitExceededException">
        /// The number of allowed resources has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.TooManyTagsException">
        /// Application created with too many tags, or too many tags added to an application.
        /// Note that the maximum number of application tags includes system tags. The maximum
        /// number of user-defined application tags is 50.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationPresignedUrl

        internal virtual CreateApplicationPresignedUrlResponse CreateApplicationPresignedUrl(CreateApplicationPresignedUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationPresignedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationPresignedUrlResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationPresignedUrlResponse>(request, options);
        }



        /// <summary>
        /// Creates and returns a URL that you can use to connect to an application's extension.
        /// 
        ///  
        /// <para>
        /// The IAM role or user used to call this API defines the permissions to access the extension.
        /// After the presigned URL is created, no additional permission is required to access
        /// this URL. IAM authorization policies for this API are also enforced for every HTTP
        /// request that attempts to connect to the extension. 
        /// </para>
        ///  
        /// <para>
        /// You control the amount of time that the URL will be valid using the <code>SessionExpirationDurationInSeconds</code>
        /// parameter. If you do not provide this parameter, the returned URL is valid for twelve
        /// hours.
        /// </para>
        ///  <note> 
        /// <para>
        /// The URL that you get from a call to CreateApplicationPresignedUrl must be used within
        /// 3 minutes to be valid. If you first try to use the URL after the 3-minute limit expires,
        /// the service returns an HTTP 403 Forbidden error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationPresignedUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplicationPresignedUrl service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplicationPresignedUrl">REST API Reference for CreateApplicationPresignedUrl Operation</seealso>
        public virtual Task<CreateApplicationPresignedUrlResponse> CreateApplicationPresignedUrlAsync(CreateApplicationPresignedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationPresignedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationPresignedUrlResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationPresignedUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationSnapshot

        internal virtual CreateApplicationSnapshotResponse CreateApplicationSnapshot(CreateApplicationSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the application's state data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.LimitExceededException">
        /// The number of allowed resources has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplicationSnapshot">REST API Reference for CreateApplicationSnapshot Operation</seealso>
        public virtual Task<CreateApplicationSnapshotResponse> CreateApplicationSnapshotAsync(CreateApplicationSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified application. Kinesis Data Analytics halts application execution
        /// and deletes the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationCloudWatchLoggingOption

        internal virtual DeleteApplicationCloudWatchLoggingOptionResponse DeleteApplicationCloudWatchLoggingOption(DeleteApplicationCloudWatchLoggingOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationCloudWatchLoggingOptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon CloudWatch log stream from an Kinesis Data Analytics application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        public virtual Task<DeleteApplicationCloudWatchLoggingOptionResponse> DeleteApplicationCloudWatchLoggingOptionAsync(DeleteApplicationCloudWatchLoggingOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationCloudWatchLoggingOptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationInputProcessingConfiguration

        internal virtual DeleteApplicationInputProcessingConfigurationResponse DeleteApplicationInputProcessingConfiguration(DeleteApplicationInputProcessingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationInputProcessingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an <a>InputProcessingConfiguration</a> from an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationInputProcessingConfiguration service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
        public virtual Task<DeleteApplicationInputProcessingConfigurationResponse> DeleteApplicationInputProcessingConfigurationAsync(DeleteApplicationInputProcessingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationInputProcessingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationOutput

        internal virtual DeleteApplicationOutputResponse DeleteApplicationOutput(DeleteApplicationOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationOutputResponse>(request, options);
        }



        /// <summary>
        /// Deletes the output destination configuration from your SQL-based Kinesis Data Analytics
        /// application's configuration. Kinesis Data Analytics will no longer write data from
        /// the corresponding in-application stream to the external output destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationOutput service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
        public virtual Task<DeleteApplicationOutputResponse> DeleteApplicationOutputAsync(DeleteApplicationOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationOutputResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationReferenceDataSource

        internal virtual DeleteApplicationReferenceDataSourceResponse DeleteApplicationReferenceDataSource(DeleteApplicationReferenceDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationReferenceDataSourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a reference data source configuration from the specified SQL-based Kinesis
        /// Data Analytics application's configuration.
        /// 
        ///  
        /// <para>
        /// If the application is running, Kinesis Data Analytics immediately removes the in-application
        /// table that you created using the <a>AddApplicationReferenceDataSource</a> operation.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationReferenceDataSource service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        public virtual Task<DeleteApplicationReferenceDataSourceResponse> DeleteApplicationReferenceDataSourceAsync(DeleteApplicationReferenceDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationReferenceDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationSnapshot

        internal virtual DeleteApplicationSnapshotResponse DeleteApplicationSnapshot(DeleteApplicationSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes a snapshot of application state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationSnapshot">REST API Reference for DeleteApplicationSnapshot Operation</seealso>
        public virtual Task<DeleteApplicationSnapshotResponse> DeleteApplicationSnapshotAsync(DeleteApplicationSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationVpcConfiguration

        internal virtual DeleteApplicationVpcConfigurationResponse DeleteApplicationVpcConfiguration(DeleteApplicationVpcConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationVpcConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationVpcConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationVpcConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Removes a VPC configuration from a Kinesis Data Analytics application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVpcConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationVpcConfiguration service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationVpcConfiguration">REST API Reference for DeleteApplicationVpcConfiguration Operation</seealso>
        public virtual Task<DeleteApplicationVpcConfigurationResponse> DeleteApplicationVpcConfigurationAsync(DeleteApplicationVpcConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationVpcConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationVpcConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationVpcConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplication

        internal virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific Kinesis Data Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want to retrieve a list of all applications in your account, use the <a>ListApplications</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationSnapshot

        internal virtual DescribeApplicationSnapshotResponse DescribeApplicationSnapshot(DescribeApplicationSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a snapshot of application state data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplicationSnapshot">REST API Reference for DescribeApplicationSnapshot Operation</seealso>
        public virtual Task<DescribeApplicationSnapshotResponse> DescribeApplicationSnapshotAsync(DescribeApplicationSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationVersion

        internal virtual DescribeApplicationVersionResponse DescribeApplicationVersion(DescribeApplicationVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationVersionResponse>(request, options);
        }



        /// <summary>
        /// Provides a detailed description of a specified version of the application. To see
        /// a list of all the versions of an application, invoke the <a>ListApplicationVersions</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is supported only for Amazon Kinesis Data Analytics for Apache Flink.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationVersion service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplicationVersion">REST API Reference for DescribeApplicationVersion Operation</seealso>
        public virtual Task<DescribeApplicationVersionResponse> DescribeApplicationVersionAsync(DescribeApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DiscoverInputSchema

        internal virtual DiscoverInputSchemaResponse DiscoverInputSchema(DiscoverInputSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DiscoverInputSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscoverInputSchemaResponseUnmarshaller.Instance;

            return Invoke<DiscoverInputSchemaResponse>(request, options);
        }



        /// <summary>
        /// Infers a schema for a SQL-based Kinesis Data Analytics application by evaluating sample
        /// records on the specified streaming source (Kinesis data stream or Kinesis Data Firehose
        /// delivery stream) or Amazon S3 object. In the response, the operation returns the inferred
        /// schema and also the sample records that the operation used to infer the schema.
        /// 
        ///  
        /// <para>
        ///  You can use the inferred schema when configuring a streaming source for your application.
        /// When you create an application using the Kinesis Data Analytics console, the console
        /// uses this operation to infer a schema and show it in the console user interface. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DiscoverInputSchema service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceProvisionedThroughputExceededException">
        /// Discovery failed to get a record from the streaming source because of the Kinesis
        /// Streams <code>ProvisionedThroughputExceededException</code>. For more information,
        /// see <a href="http://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetRecords.html">GetRecords</a>
        /// in the Amazon Kinesis Streams API Reference.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnableToDetectSchemaException">
        /// The data format is not valid. Kinesis Data Analytics cannot detect the schema for
        /// the given streaming source.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        public virtual Task<DiscoverInputSchemaResponse> DiscoverInputSchemaAsync(DiscoverInputSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DiscoverInputSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscoverInputSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DiscoverInputSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of Kinesis Data Analytics applications in your account. For each application,
        /// the response includes the application name, Amazon Resource Name (ARN), and status.
        /// 
        /// 
        ///  
        /// <para>
        /// If you want detailed information about a specific application, use <a>DescribeApplication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationSnapshots

        internal virtual ListApplicationSnapshotsResponse ListApplicationSnapshots(ListApplicationSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about the current application snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationSnapshots service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplicationSnapshots">REST API Reference for ListApplicationSnapshots Operation</seealso>
        public virtual Task<ListApplicationSnapshotsResponse> ListApplicationSnapshotsAsync(ListApplicationSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationVersions

        internal virtual ListApplicationVersionsResponse ListApplicationVersions(ListApplicationVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the versions for the specified application, including versions that were
        /// rolled back. The response also includes a summary of the configuration associated
        /// with each version.
        /// 
        ///  
        /// <para>
        /// To get the complete description of a specific application version, invoke the <a>DescribeApplicationVersion</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is supported only for Amazon Kinesis Data Analytics for Apache Flink.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationVersions service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        public virtual Task<ListApplicationVersionsResponse> ListApplicationVersionsAsync(ListApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the list of key-value tags assigned to the application. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/how-tagging.html">Using
        /// Tagging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RollbackApplication

        internal virtual RollbackApplicationResponse RollbackApplication(RollbackApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RollbackApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackApplicationResponseUnmarshaller.Instance;

            return Invoke<RollbackApplicationResponse>(request, options);
        }



        /// <summary>
        /// Reverts the application to the previous running version. You can roll back an application
        /// if you suspect it is stuck in a transient status. 
        /// 
        ///  
        /// <para>
        /// You can roll back an application only if it is in the <code>UPDATING</code> or <code>AUTOSCALING</code>
        /// status.
        /// </para>
        ///  
        /// <para>
        /// When you rollback an application, it loads state data from the last successful snapshot.
        /// If the application has no snapshots, Kinesis Data Analytics rejects the rollback request.
        /// </para>
        ///  
        /// <para>
        /// This action is not supported for Kinesis Data Analytics for SQL applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RollbackApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/RollbackApplication">REST API Reference for RollbackApplication Operation</seealso>
        public virtual Task<RollbackApplicationResponse> RollbackApplicationAsync(RollbackApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RollbackApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<RollbackApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartApplication

        internal virtual StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return Invoke<StartApplicationResponse>(request, options);
        }



        /// <summary>
        /// Starts the specified Kinesis Data Analytics application. After creating an application,
        /// you must exclusively call this operation to start your application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopApplication

        internal virtual StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return Invoke<StopApplicationResponse>(request, options);
        }



        /// <summary>
        /// Stops the application from processing data. You can stop an application only if it
        /// is in the running status, unless you set the <code>Force</code> parameter to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>DescribeApplication</a> operation to find the application status.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Kinesis Data Analytics takes a snapshot when the application is stopped, unless <code>Force</code>
        /// is set to <code>true</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StopApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more key-value tags to a Kinesis Data Analytics application. Note that
        /// the maximum number of application tags includes system tags. The maximum number of
        /// user-defined application tags is 50. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/how-tagging.html">Using
        /// Tagging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.TooManyTagsException">
        /// Application created with too many tags, or too many tags added to an application.
        /// Note that the maximum number of application tags includes system tags. The maximum
        /// number of user-defined application tags is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a Kinesis Data Analytics application. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/how-tagging.html">Using
        /// Tagging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.TooManyTagsException">
        /// Application created with too many tags, or too many tags added to an application.
        /// Note that the maximum number of application tags includes system tags. The maximum
        /// number of user-defined application tags is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Kinesis Data Analytics application. Using this operation, you
        /// can update application code, input configuration, and output configuration. 
        /// 
        ///  
        /// <para>
        /// Kinesis Data Analytics updates the <code>ApplicationVersionId</code> each time you
        /// update your application. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot update the <code>RuntimeEnvironment</code> of an existing application.
        /// If you need to update an application's <code>RuntimeEnvironment</code>, you must delete
        /// the application and create it again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.CodeValidationException">
        /// The user-provided application code (query) is not valid. This can be a simple syntax
        /// error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.LimitExceededException">
        /// The number of allowed resources has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationMaintenanceConfiguration

        internal virtual UpdateApplicationMaintenanceConfigurationResponse UpdateApplicationMaintenanceConfiguration(UpdateApplicationMaintenanceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationMaintenanceConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationMaintenanceConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the maintenance configuration of the Kinesis Data Analytics application. 
        /// 
        ///  
        /// <para>
        /// You can invoke this operation on an application that is in one of the two following
        /// states: <code>READY</code> or <code>RUNNING</code>. If you invoke it when the application
        /// is in a state other than these two states, it throws a <code>ResourceInUseException</code>.
        /// The service makes use of the updated configuration the next time it schedules maintenance
        /// for the application. If you invoke this operation after the service schedules maintenance,
        /// the service will apply the configuration update the next time it schedules maintenance
        /// for the application. This means that you might not see the maintenance configuration
        /// update applied to the maintenance process that follows a successful invocation of
        /// this operation, but to the following maintenance process instead.
        /// </para>
        ///  
        /// <para>
        /// To see the current maintenance configuration of your application, invoke the <a>DescribeApplication</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For information about application maintenance, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/maintenance.html">Kinesis
        /// Data Analytics for Apache Flink Maintenance</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is supported only for Amazon Kinesis Data Analytics for Apache Flink.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationMaintenanceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplicationMaintenanceConfiguration service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UpdateApplicationMaintenanceConfiguration">REST API Reference for UpdateApplicationMaintenanceConfiguration Operation</seealso>
        public virtual Task<UpdateApplicationMaintenanceConfigurationResponse> UpdateApplicationMaintenanceConfigurationAsync(UpdateApplicationMaintenanceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationMaintenanceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationMaintenanceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationMaintenanceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}