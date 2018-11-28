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

#if CORECLR
    
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

#endif

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

        internal virtual AddApplicationCloudWatchLoggingOptionResponse AddApplicationCloudWatchLoggingOption(AddApplicationCloudWatchLoggingOptionRequest request)
        {
            var marshaller = AddApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            var unmarshaller = AddApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<AddApplicationCloudWatchLoggingOptionRequest,AddApplicationCloudWatchLoggingOptionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            var unmarshaller = AddApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationCloudWatchLoggingOptionRequest,AddApplicationCloudWatchLoggingOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationInput

        internal virtual AddApplicationInputResponse AddApplicationInput(AddApplicationInputRequest request)
        {
            var marshaller = AddApplicationInputRequestMarshaller.Instance;
            var unmarshaller = AddApplicationInputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputRequest,AddApplicationInputResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddApplicationInputRequestMarshaller.Instance;
            var unmarshaller = AddApplicationInputResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationInputRequest,AddApplicationInputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationInputProcessingConfiguration

        internal virtual AddApplicationInputProcessingConfigurationResponse AddApplicationInputProcessingConfiguration(AddApplicationInputProcessingConfigurationRequest request)
        {
            var marshaller = AddApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            var unmarshaller = AddApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<AddApplicationInputProcessingConfigurationRequest,AddApplicationInputProcessingConfigurationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            var unmarshaller = AddApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationInputProcessingConfigurationRequest,AddApplicationInputProcessingConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationOutput

        internal virtual AddApplicationOutputResponse AddApplicationOutput(AddApplicationOutputRequest request)
        {
            var marshaller = AddApplicationOutputRequestMarshaller.Instance;
            var unmarshaller = AddApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<AddApplicationOutputRequest,AddApplicationOutputResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddApplicationOutputRequestMarshaller.Instance;
            var unmarshaller = AddApplicationOutputResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationOutputRequest,AddApplicationOutputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddApplicationReferenceDataSource

        internal virtual AddApplicationReferenceDataSourceResponse AddApplicationReferenceDataSource(AddApplicationReferenceDataSourceRequest request)
        {
            var marshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            var unmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<AddApplicationReferenceDataSourceRequest,AddApplicationReferenceDataSourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddApplicationReferenceDataSourceRequestMarshaller.Instance;
            var unmarshaller = AddApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddApplicationReferenceDataSourceRequest,AddApplicationReferenceDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateApplicationRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationRequest,CreateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationSnapshot

        internal virtual CreateApplicationSnapshotResponse CreateApplicationSnapshot(CreateApplicationSnapshotRequest request)
        {
            var marshaller = CreateApplicationSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationSnapshotRequest,CreateApplicationSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateApplicationSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateApplicationSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationSnapshotRequest,CreateApplicationSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApplicationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationRequest,DeleteApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationCloudWatchLoggingOption

        internal virtual DeleteApplicationCloudWatchLoggingOptionResponse DeleteApplicationCloudWatchLoggingOption(DeleteApplicationCloudWatchLoggingOptionRequest request)
        {
            var marshaller = DeleteApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationCloudWatchLoggingOptionRequest,DeleteApplicationCloudWatchLoggingOptionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApplicationCloudWatchLoggingOptionRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationCloudWatchLoggingOptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationCloudWatchLoggingOptionRequest,DeleteApplicationCloudWatchLoggingOptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationInputProcessingConfiguration

        internal virtual DeleteApplicationInputProcessingConfigurationResponse DeleteApplicationInputProcessingConfiguration(DeleteApplicationInputProcessingConfigurationRequest request)
        {
            var marshaller = DeleteApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationInputProcessingConfigurationRequest,DeleteApplicationInputProcessingConfigurationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApplicationInputProcessingConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationInputProcessingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationInputProcessingConfigurationRequest,DeleteApplicationInputProcessingConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationOutput

        internal virtual DeleteApplicationOutputResponse DeleteApplicationOutput(DeleteApplicationOutputRequest request)
        {
            var marshaller = DeleteApplicationOutputRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationOutputResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationOutputRequest,DeleteApplicationOutputResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApplicationOutputRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationOutputResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationOutputRequest,DeleteApplicationOutputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationReferenceDataSource

        internal virtual DeleteApplicationReferenceDataSourceResponse DeleteApplicationReferenceDataSource(DeleteApplicationReferenceDataSourceRequest request)
        {
            var marshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationReferenceDataSourceRequest,DeleteApplicationReferenceDataSourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApplicationReferenceDataSourceRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationReferenceDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationReferenceDataSourceRequest,DeleteApplicationReferenceDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationSnapshot

        internal virtual DeleteApplicationSnapshotResponse DeleteApplicationSnapshot(DeleteApplicationSnapshotRequest request)
        {
            var marshaller = DeleteApplicationSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationSnapshotRequest,DeleteApplicationSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteApplicationSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteApplicationSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationSnapshotRequest,DeleteApplicationSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplication

        internal virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var marshaller = DescribeApplicationRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationRequest,DescribeApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeApplicationRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationRequest,DescribeApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationSnapshot

        internal virtual DescribeApplicationSnapshotResponse DescribeApplicationSnapshot(DescribeApplicationSnapshotRequest request)
        {
            var marshaller = DescribeApplicationSnapshotRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationSnapshotResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationSnapshotRequest,DescribeApplicationSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeApplicationSnapshotRequestMarshaller.Instance;
            var unmarshaller = DescribeApplicationSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationSnapshotRequest,DescribeApplicationSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DiscoverInputSchema

        internal virtual DiscoverInputSchemaResponse DiscoverInputSchema(DiscoverInputSchemaRequest request)
        {
            var marshaller = DiscoverInputSchemaRequestMarshaller.Instance;
            var unmarshaller = DiscoverInputSchemaResponseUnmarshaller.Instance;

            return Invoke<DiscoverInputSchemaRequest,DiscoverInputSchemaResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DiscoverInputSchemaRequestMarshaller.Instance;
            var unmarshaller = DiscoverInputSchemaResponseUnmarshaller.Instance;

            return InvokeAsync<DiscoverInputSchemaRequest,DiscoverInputSchemaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var marshaller = ListApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListApplicationsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsRequest,ListApplicationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApplicationSnapshots

        internal virtual ListApplicationSnapshotsResponse ListApplicationSnapshots(ListApplicationSnapshotsRequest request)
        {
            var marshaller = ListApplicationSnapshotsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationSnapshotsRequest,ListApplicationSnapshotsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListApplicationSnapshotsRequestMarshaller.Instance;
            var unmarshaller = ListApplicationSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationSnapshotsRequest,ListApplicationSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartApplication

        internal virtual StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            var marshaller = StartApplicationRequestMarshaller.Instance;
            var unmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return Invoke<StartApplicationRequest,StartApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartApplicationRequestMarshaller.Instance;
            var unmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartApplicationRequest,StartApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopApplication

        internal virtual StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            var marshaller = StopApplicationRequestMarshaller.Instance;
            var unmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return Invoke<StopApplicationRequest,StopApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StopApplicationRequestMarshaller.Instance;
            var unmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StopApplicationRequest,StopApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateApplicationRequestMarshaller.Instance;
            var unmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationRequest,UpdateApplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}