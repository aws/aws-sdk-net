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

namespace Amazon.KinesisAnalytics
{
    /// <summary>
    /// Implementation for accessing KinesisAnalytics
    ///
    /// 
    /// </summary>
    public partial class AmazonKinesisAnalyticsClient : AmazonServiceClient, IAmazonKinesisAnalytics
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisAnalyticsMetadata();
        
        #region Constructors

#if CORECLR
    
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisAnalyticsConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisAnalyticsConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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

        internal virtual AddApplicationCloudWatchLoggingOptionResponse AddApplicationCloudWatchLoggingOption(AddApplicationCloudWatchLoggingOptionRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
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
        /// Initiates the asynchronous execution of the AddApplicationInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
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
        /// Initiates the asynchronous execution of the AddApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
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
        /// Initiates the asynchronous execution of the AddApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
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
        /// Initiates the asynchronous execution of the AddApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        public virtual Task<AddApplicationReferenceDataSourceResponse> AddApplicationReferenceDataSourceAsync(AddApplicationReferenceDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationReferenceDataSourceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
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
        /// Initiates the asynchronous execution of the DeleteApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
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
        /// Initiates the asynchronous execution of the DeleteApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
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
        /// Initiates the asynchronous execution of the DeleteApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
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
        /// Initiates the asynchronous execution of the DeleteApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        public virtual Task<DeleteApplicationReferenceDataSourceResponse> DeleteApplicationReferenceDataSourceAsync(DeleteApplicationReferenceDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationReferenceDataSourceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DiscoverInputSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
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
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the StartApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StartApplication">REST API Reference for StartApplication Operation</seealso>
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
        /// Initiates the asynchronous execution of the StopApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StopApplicationResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
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