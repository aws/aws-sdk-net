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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisAnalytics.Model;
using Amazon.KinesisAnalytics.Model.Internal.MarshallTransformations;
using Amazon.KinesisAnalytics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.KinesisAnalytics
{
    /// <summary>
    /// <para>Implementation for accessing KinesisAnalytics</para>
    ///
    /// Amazon Kinesis Analytics 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This is the <i>Amazon Kinesis Analytics v1 API Reference</i>. The Amazon Kinesis Analytics
    /// Developer Guide provides additional information. 
    /// </para>
    /// </summary>
    public partial class AmazonKinesisAnalyticsClient : AmazonServiceClient, IAmazonKinesisAnalytics
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisAnalyticsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with the credentials loaded from the application's
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
        public AmazonKinesisAnalyticsClient()
            : base(new AmazonKinesisAnalyticsConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with the credentials loaded from the application's
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
        public AmazonKinesisAnalyticsClient(RegionEndpoint region)
            : base(new AmazonKinesisAnalyticsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisAnalyticsClient Configuration Object</param>
        public AmazonKinesisAnalyticsClient(AmazonKinesisAnalyticsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisAnalyticsClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisAnalyticsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Credentials and an
        /// AmazonKinesisAnalyticsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisAnalyticsClient Configuration Object</param>
        public AmazonKinesisAnalyticsClient(AWSCredentials credentials, AmazonKinesisAnalyticsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisAnalyticsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisAnalyticsClient Configuration Object</param>
        public AmazonKinesisAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisAnalyticsClient Configuration Object</param>
        public AmazonKinesisAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisAnalyticsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisAnalyticsAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<AddApplicationCloudWatchLoggingOptionResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Adds a CloudWatch log stream to monitor application configuration errors. For more
        /// information about using CloudWatch log streams with Amazon Kinesis Analytics applications,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-logs.html">Working
        /// with Amazon CloudWatch Logs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        public virtual Task<AddApplicationCloudWatchLoggingOptionResponse> AddApplicationCloudWatchLoggingOptionAsync(AddApplicationCloudWatchLoggingOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationCloudWatchLoggingOptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddApplicationInput

        internal virtual AddApplicationInputResponse AddApplicationInput(AddApplicationInputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Adds a streaming source to your Amazon Kinesis application. For conceptual information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can add a streaming source either when you create an application or you can use
        /// this operation to add a streaming source after you create an application. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_CreateApplication.html">CreateApplication</a>.
        /// </para>
        ///  
        /// <para>
        /// Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
        /// operation to find the current application version. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:AddApplicationInput</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationInput service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.CodeValidationException">
        /// User-provided application code (query) is invalid. This can be a simple syntax error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
        public virtual Task<AddApplicationInputResponse> AddApplicationInputAsync(AddApplicationInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationInputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationInputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddApplicationInputProcessingConfiguration

        internal virtual AddApplicationInputProcessingConfigurationResponse AddApplicationInputProcessingConfiguration(AddApplicationInputProcessingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputProcessingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Adds an <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputProcessingConfiguration.html">InputProcessingConfiguration</a>
        /// to an application. An input processor preprocesses records on the input stream before
        /// the application's SQL code executes. Currently, the only input processor available
        /// is <a href="https://docs.aws.amazon.com/lambda/">AWS Lambda</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationInputProcessingConfiguration service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
        public virtual Task<AddApplicationInputProcessingConfigurationResponse> AddApplicationInputProcessingConfigurationAsync(AddApplicationInputProcessingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationInputProcessingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddApplicationOutput

        internal virtual AddApplicationOutputResponse AddApplicationOutput(AddApplicationOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationOutputResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Adds an external destination to your Amazon Kinesis Analytics application.
        /// </para>
        ///  
        /// <para>
        /// If you want Amazon Kinesis Analytics to deliver data from an in-application stream
        /// within your application to an external destination (such as an Amazon Kinesis stream,
        /// an Amazon Kinesis Firehose delivery stream, or an AWS Lambda function), you add the
        /// relevant configuration to your application using this operation. You can configure
        /// one or more outputs for your application. Each output configuration maps an in-application
        /// stream and an external destination.
        /// </para>
        ///  
        /// <para>
        ///  You can use one of the output configurations to deliver data from your in-application
        /// error stream to an external destination so that you can analyze the errors. For more
        /// information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Understanding
        /// Application Output (Destination)</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
        /// operation to find the current application version.
        /// </para>
        ///  
        /// <para>
        /// For the limits on the number of application inputs and outputs you can configure,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/limits.html">Limits</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:AddApplicationOutput</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationOutput service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
        public virtual Task<AddApplicationOutputResponse> AddApplicationOutputAsync(AddApplicationOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationOutputResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddApplicationReferenceDataSource

        internal virtual AddApplicationReferenceDataSourceResponse AddApplicationReferenceDataSource(AddApplicationReferenceDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<AddApplicationReferenceDataSourceResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Adds a reference data source to an existing application.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kinesis Analytics reads reference data (that is, an Amazon S3 object) and creates
        /// an in-application table within your application. In the request, you provide the source
        /// (S3 bucket name and object key name), name of the in-application table to create,
        /// and the necessary mapping information that describes how data in Amazon S3 object
        /// maps to columns in the resulting in-application table.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. For the limits on data sources you can add to your application,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/limits.html">Limits</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions to perform the <c>kinesisanalytics:AddApplicationOutput</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddApplicationReferenceDataSource service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        public virtual Task<AddApplicationReferenceDataSourceResponse> AddApplicationReferenceDataSourceAsync(AddApplicationReferenceDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationReferenceDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  Creates an Amazon Kinesis Analytics application. You can configure each application
        /// with one streaming source as input, application code to process the input, and up
        /// to three destinations where you want Amazon Kinesis Analytics to write the output
        /// data from your application. For an overview, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works.html">How
        /// it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// In the input configuration, you map the streaming source to an in-application stream,
        /// which you can think of as a constantly updating table. In the mapping, you must provide
        /// a schema for the in-application stream and map each data column in the in-application
        /// stream to a data element in the streaming source.
        /// </para>
        ///  
        /// <para>
        /// Your application code is one or more SQL statements that read input data, transform
        /// it, and generate output. Your application code can create one or more SQL artifacts
        /// like SQL streams or pumps.
        /// </para>
        ///  
        /// <para>
        /// In the output configuration, you can configure the application to write data from
        /// in-application streams created in your applications to up to three destinations.
        /// </para>
        ///  
        /// <para>
        ///  To read data from your source stream or write data to destination streams, Amazon
        /// Kinesis Analytics needs your permissions. You grant these permissions by creating
        /// IAM roles. This operation requires permissions to perform the <c>kinesisanalytics:CreateApplication</c>
        /// action. 
        /// </para>
        ///  
        /// <para>
        ///  For introductory exercises to create an Amazon Kinesis Analytics application, see
        /// <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/getting-started.html">Getting
        /// Started</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.CodeValidationException">
        /// User-provided application code (query) is invalid. This can be a simple syntax error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.LimitExceededException">
        /// Exceeded the number of applications allowed.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.TooManyTagsException">
        /// Application created with too many tags, or too many tags added to an application.
        /// Note that the maximum number of application tags includes system tags. The maximum
        /// number of user-defined application tags is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the specified application. Amazon Kinesis Analytics halts application execution
        /// and deletes the application, including any application artifacts (such as in-application
        /// streams, reference table, and application code).
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:DeleteApplication</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplicationCloudWatchLoggingOption

        internal virtual DeleteApplicationCloudWatchLoggingOptionResponse DeleteApplicationCloudWatchLoggingOption(DeleteApplicationCloudWatchLoggingOptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationCloudWatchLoggingOptionResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes a CloudWatch log stream from an application. For more information about using
        /// CloudWatch log streams with Amazon Kinesis Analytics applications, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-logs.html">Working
        /// with Amazon CloudWatch Logs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        public virtual Task<DeleteApplicationCloudWatchLoggingOptionResponse> DeleteApplicationCloudWatchLoggingOptionAsync(DeleteApplicationCloudWatchLoggingOptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationCloudWatchLoggingOptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplicationInputProcessingConfiguration

        internal virtual DeleteApplicationInputProcessingConfigurationResponse DeleteApplicationInputProcessingConfiguration(DeleteApplicationInputProcessingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationInputProcessingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes an <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_InputProcessingConfiguration.html">InputProcessingConfiguration</a>
        /// from an input.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationInputProcessingConfiguration service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
        public virtual Task<DeleteApplicationInputProcessingConfigurationResponse> DeleteApplicationInputProcessingConfigurationAsync(DeleteApplicationInputProcessingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationInputProcessingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplicationOutput

        internal virtual DeleteApplicationOutputResponse DeleteApplicationOutput(DeleteApplicationOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationOutputResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes output destination configuration from your application configuration. Amazon
        /// Kinesis Analytics will no longer write data from the corresponding in-application
        /// stream to the external output destination.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:DeleteApplicationOutput</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationOutput service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
        public virtual Task<DeleteApplicationOutputResponse> DeleteApplicationOutputAsync(DeleteApplicationOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationOutputResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationOutputResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplicationReferenceDataSource

        internal virtual DeleteApplicationReferenceDataSourceResponse DeleteApplicationReferenceDataSource(DeleteApplicationReferenceDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationReferenceDataSourceResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes a reference data source configuration from the specified application configuration.
        /// </para>
        ///  
        /// <para>
        /// If the application is running, Amazon Kinesis Analytics immediately removes the in-application
        /// table that you created using the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_AddApplicationReferenceDataSource.html">AddApplicationReferenceDataSource</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics.DeleteApplicationReferenceDataSource</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationReferenceDataSource service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        public virtual Task<DeleteApplicationReferenceDataSourceResponse> DeleteApplicationReferenceDataSourceAsync(DeleteApplicationReferenceDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationReferenceDataSourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeApplication

        internal virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns information about a specific Amazon Kinesis Analytics application.
        /// </para>
        ///  
        /// <para>
        /// If you want to retrieve a list of all applications in your account, use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_ListApplications.html">ListApplications</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:DescribeApplication</c>
        /// action. You can use <c>DescribeApplication</c> to get the current application versionId,
        /// which you need to call other operations such as <c>Update</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DiscoverInputSchema

        internal virtual DiscoverInputSchemaResponse DiscoverInputSchema(DiscoverInputSchemaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DiscoverInputSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscoverInputSchemaResponseUnmarshaller.Instance;

            return Invoke<DiscoverInputSchemaResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Infers a schema by evaluating sample records on the specified streaming source (Amazon
        /// Kinesis stream or Amazon Kinesis Firehose delivery stream) or S3 object. In the response,
        /// the operation returns the inferred schema and also the sample records that the operation
        /// used to infer the schema.
        /// </para>
        ///  
        /// <para>
        ///  You can use the inferred schema when configuring a streaming source for your application.
        /// For conceptual information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. Note that when you create an application using the Amazon Kinesis
        /// Analytics console, the console uses this operation to infer a schema and show it in
        /// the console user interface. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions to perform the <c>kinesisanalytics:DiscoverInputSchema</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DiscoverInputSchema service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceProvisionedThroughputExceededException">
        /// Discovery failed to get a record from the streaming source because of the Amazon Kinesis
        /// Streams ProvisionedThroughputExceededException. For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetRecords.html">GetRecords</a>
        /// in the Amazon Kinesis Streams API Reference.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnableToDetectSchemaException">
        /// Data format is not valid. Amazon Kinesis Analytics is not able to detect schema for
        /// the given streaming source.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        public virtual Task<DiscoverInputSchemaResponse> DiscoverInputSchemaAsync(DiscoverInputSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DiscoverInputSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscoverInputSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DiscoverInputSchemaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns a list of Amazon Kinesis Analytics applications in your account. For each
        /// application, the response includes the application name, Amazon Resource Name (ARN),
        /// and status. If the response returns the <c>HasMoreApplications</c> value as true,
        /// you can send another request by adding the <c>ExclusiveStartApplicationName</c> in
        /// the request body, and set the value of this to the last application name from the
        /// previous response. 
        /// </para>
        ///  
        /// <para>
        /// If you want detailed information about a specific application, use <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:ListApplications</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by KinesisAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the list of key-value tags assigned to the application. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-tagging.html">Using
        /// Tagging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartApplication

        internal virtual StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return Invoke<StartApplicationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Starts the specified Amazon Kinesis Analytics application. After creating an application,
        /// you must exclusively call this operation to start your application.
        /// </para>
        ///  
        /// <para>
        /// After the application starts, it begins consuming the input data, processes it, and
        /// writes the output to the configured destination.
        /// </para>
        ///  
        /// <para>
        ///  The application status must be <c>READY</c> for you to start an application. You
        /// can get the application status in the console or using the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// After you start the application, you can stop the application from processing the
        /// input by calling the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_StopApplication.html">StopApplication</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:StartApplication</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidApplicationConfigurationException">
        /// User-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopApplication

        internal virtual StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return Invoke<StopApplicationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Stops the application from processing input data. You can stop an application only
        /// if it is in the running state. You can use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
        /// operation to find the application state. After the application is stopped, Amazon
        /// Kinesis Analytics stops reading data from the input, the application stops processing
        /// data, and there is no output written to the destination. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>kinesisanalytics:StopApplication</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StopApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more key-value tags to a Kinesis Analytics application. Note that the
        /// maximum number of application tags includes system tags. The maximum number of user-defined
        /// application tags is 50. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-tagging.html">Using
        /// Tagging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.TooManyTagsException">
        /// Application created with too many tags, or too many tags added to an application.
        /// Note that the maximum number of application tags includes system tags. The maximum
        /// number of user-defined application tags is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a Kinesis Analytics application. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-tagging.html">Using
        /// Tagging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.TooManyTagsException">
        /// Application created with too many tags, or too many tags added to an application.
        /// Note that the maximum number of application tags includes system tags. The maximum
        /// number of user-defined application tags is 50.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
        /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
        /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
        /// Kinesis Data Analytics API V2 Documentation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Updates an existing Amazon Kinesis Analytics application. Using this API, you can
        /// update application code, input configuration, and output configuration. 
        /// </para>
        ///  
        /// <para>
        /// Note that Amazon Kinesis Analytics updates the <c>CurrentApplicationVersionId</c>
        /// each time you update your application. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>kinesisanalytics:UpdateApplication</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.CodeValidationException">
        /// User-provided application code (query) is invalid. This can be a simple syntax error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}