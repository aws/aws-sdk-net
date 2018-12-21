/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Documentation for Kinesis Data Analytics API v2
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


        /// <summary>
        /// Adds an Amazon CloudWatch log stream to monitor application configuration errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption service method.</param>
        /// 
        /// <returns>The response from the AddApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalyticsV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        public virtual AddApplicationCloudWatchLoggingOptionResponse AddApplicationCloudWatchLoggingOption(AddApplicationCloudWatchLoggingOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<AddApplicationCloudWatchLoggingOptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Adds a streaming source to your SQL-based Amazon Kinesis Data Analytics application.
        /// 
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
        public virtual AddApplicationInputResponse AddApplicationInput(AddApplicationInputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Adds an <a>InputProcessingConfiguration</a> to an SQL-based Kinesis Data Analytics
        /// application. An input processor pre-processes records on the input stream before the
        /// application's SQL code executes. Currently, the only input processor available is
        /// <a href="https://aws.amazon.com/documentation/lambda/">AWS Lambda</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration service method.</param>
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
        public virtual AddApplicationInputProcessingConfigurationResponse AddApplicationInputProcessingConfiguration(AddApplicationInputProcessingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputProcessingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Adds an external destination to your SQL-based Amazon Kinesis Data Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want Kinesis Data Analytics to deliver data from an in-application stream within
        /// your application to an external destination (such as an Kinesis data stream, a Kinesis
        /// Data Firehose delivery stream, or an AWS Lambda function), you add the relevant configuration
        /// to your application using this operation. You can configure one or more outputs for
        /// your application. Each output configuration maps an in-application stream and an external
        /// destination.
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
        public virtual AddApplicationOutputResponse AddApplicationOutput(AddApplicationOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Adds a reference data source to an existing SQL-based Amazon Kinesis Data Analytics
        /// application.
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
        public virtual AddApplicationReferenceDataSourceResponse AddApplicationReferenceDataSource(AddApplicationReferenceDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<AddApplicationReferenceDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        public virtual Task<AddApplicationReferenceDataSourceResponse> AddApplicationReferenceDataSourceAsync(AddApplicationReferenceDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddApplicationReferenceDataSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an Amazon Kinesis Data Analytics application. For information about creating
        /// a Kinesis Data Analytics application, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/Java/creating-app.html">Creating
        /// an Application</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// SQL is not enabled for this private beta release. Using SQL parameters (such as <a>SqlApplicationConfiguration</a>)
        /// will result in an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.CodeValidationException">
        /// The user-provided application code (query) is not valid. This can be a simple syntax
        /// error.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationSnapshot


        /// <summary>
        /// Creates a snapshot of the application's state data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
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
        public virtual CreateApplicationSnapshotResponse CreateApplicationSnapshot(CreateApplicationSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes the specified application. Kinesis Data Analytics halts application execution
        /// and deletes the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by KinesisAnalyticsV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes an Amazon CloudWatch log stream from an Amazon Kinesis Data Analytics application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalyticsV2.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        public virtual DeleteApplicationCloudWatchLoggingOptionResponse DeleteApplicationCloudWatchLoggingOption(DeleteApplicationCloudWatchLoggingOptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationCloudWatchLoggingOptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes an <a>InputProcessingConfiguration</a> from an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration service method.</param>
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
        public virtual DeleteApplicationInputProcessingConfigurationResponse DeleteApplicationInputProcessingConfiguration(DeleteApplicationInputProcessingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationInputProcessingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes the output destination configuration from your SQL-based Amazon Kinesis Data
        /// Analytics application's configuration. Kinesis Data Analytics will no longer write
        /// data from the corresponding in-application stream to the external output destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput service method.</param>
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
        public virtual DeleteApplicationOutputResponse DeleteApplicationOutput(DeleteApplicationOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes a reference data source configuration from the specified SQL-based Amazon
        /// Kinesis Data Analytics application's configuration.
        /// 
        ///  
        /// <para>
        /// If the application is running, Kinesis Data Analytics immediately removes the in-application
        /// table that you created using the <a>AddApplicationReferenceDataSource</a> operation.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource service method.</param>
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
        public virtual DeleteApplicationReferenceDataSourceResponse DeleteApplicationReferenceDataSource(DeleteApplicationReferenceDataSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationReferenceDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Deletes a snapshot of application state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
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
        public virtual DeleteApplicationSnapshotResponse DeleteApplicationSnapshot(DeleteApplicationSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationSnapshot">REST API Reference for DeleteApplicationSnapshot Operation</seealso>
        public virtual Task<DeleteApplicationSnapshotResponse> DeleteApplicationSnapshotAsync(DeleteApplicationSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApplicationSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplication


        /// <summary>
        /// Returns information about a specific Amazon Kinesis Data Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want to retrieve a list of all applications in your account, use the <a>ListApplications</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
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
        public virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns information about a snapshot of application state data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationSnapshot service method.</param>
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
        public virtual DescribeApplicationSnapshotResponse DescribeApplicationSnapshot(DescribeApplicationSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplicationSnapshot">REST API Reference for DescribeApplicationSnapshot Operation</seealso>
        public virtual Task<DescribeApplicationSnapshotResponse> DescribeApplicationSnapshotAsync(DescribeApplicationSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeApplicationSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DiscoverInputSchema


        /// <summary>
        /// Infers a schema for an SQL-based Amazon Kinesis Data Analytics application by evaluating
        /// sample records on the specified streaming source (Kinesis data stream or Kinesis Data
        /// Firehose delivery stream) or Amazon S3 object. In the response, the operation returns
        /// the inferred schema and also the sample records that the operation used to infer the
        /// schema.
        /// 
        ///  
        /// <para>
        ///  You can use the inferred schema when configuring a streaming source for your application.
        /// When you create an application using the Kinesis Data Analytics console, the console
        /// uses this operation to infer a schema and show it in the console user interface. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema service method.</param>
        /// 
        /// <returns>The response from the DiscoverInputSchema service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceProvisionedThroughputExceededException">
        /// Discovery failed to get a record from the streaming source because of the Amazon Kinesis
        /// Streams <code>ProvisionedThroughputExceededException</code>. For more information,
        /// see <a href="http://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetRecords.html">GetRecords</a>
        /// in the Amazon Kinesis Streams API Reference.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnableToDetectSchemaException">
        /// The data format is not valid. Amazon Kinesis Data Analytics cannot detect the schema
        /// for the given streaming source.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        public virtual DiscoverInputSchemaResponse DiscoverInputSchema(DiscoverInputSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DiscoverInputSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscoverInputSchemaResponseUnmarshaller.Instance;

            return Invoke<DiscoverInputSchemaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DiscoverInputSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Returns a list of Amazon Kinesis Data Analytics applications in your account. For
        /// each application, the response includes the application name, Amazon Resource Name
        /// (ARN), and status. 
        /// 
        ///  
        /// <para>
        /// If you want detailed information about a specific application, use <a>DescribeApplication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Lists information about the current application snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationSnapshots service method.</param>
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
        public virtual ListApplicationSnapshotsResponse ListApplicationSnapshots(ListApplicationSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplicationSnapshots">REST API Reference for ListApplicationSnapshots Operation</seealso>
        public virtual Task<ListApplicationSnapshotsResponse> ListApplicationSnapshotsAsync(ListApplicationSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartApplication


        /// <summary>
        /// Starts the specified Amazon Kinesis Data Analytics application. After creating an
        /// application, you must exclusively call this operation to start your application.
        /// 
        ///  <note> 
        /// <para>
        /// SQL is not enabled for this private beta. Using SQL parameters (such as <a>RunConfiguration$SqlRunConfigurations</a>)
        /// will result in an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
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
        public virtual StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return Invoke<StartApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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


        /// <summary>
        /// Stops the application from processing data. You can stop an application only if it
        /// is in the running state. You can use the <a>DescribeApplication</a> operation to find
        /// the application state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by KinesisAnalyticsV2.</returns>
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
        public virtual StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return Invoke<StopApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates an existing Amazon Kinesis Data Analytics application. Using this operation,
        /// you can update application code, input configuration, and output configuration. 
        /// 
        ///  
        /// <para>
        /// Kinesis Data Analytics updates the <code>ApplicationVersionId</code> each time you
        /// update your application. 
        /// </para>
        ///  <note> 
        /// <para>
        /// SQL is not enabled for this private beta. Using SQL parameters (such as <a>SqlApplicationConfigurationUpdate</a>)
        /// will result in an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}