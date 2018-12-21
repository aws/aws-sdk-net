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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMaker.Model;
using Amazon.SageMaker.Model.Internal.MarshallTransformations;
using Amazon.SageMaker.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Implementation for accessing SageMaker
    ///
    /// Definition of the public APIs exposed by SageMaker
    /// </summary>
    public partial class AmazonSageMakerClient : AmazonServiceClient, IAmazonSageMaker
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
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
        public AmazonSageMakerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
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
        public AmazonSageMakerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AmazonSageMakerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Credentials and an
        /// AmazonSageMakerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(AWSCredentials credentials, AmazonSageMakerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerClient Configuration Object</param>
        public AmazonSageMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerConfig clientConfig)
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


        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlgorithm

        internal virtual CreateAlgorithmResponse CreateAlgorithm(CreateAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlgorithmResponseUnmarshaller.Instance;

            return Invoke<CreateAlgorithmResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        public virtual Task<CreateAlgorithmResponse> CreateAlgorithmAsync(CreateAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlgorithmResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAlgorithmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCodeRepository

        internal virtual CreateCodeRepositoryResponse CreateCodeRepository(CreateCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateCodeRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        public virtual Task<CreateCodeRepositoryResponse> CreateCodeRepositoryAsync(CreateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCompilationJob

        internal virtual CreateCompilationJobResponse CreateCompilationJob(CreateCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCompilationJobResponseUnmarshaller.Instance;

            return Invoke<CreateCompilationJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        public virtual Task<CreateCompilationJobResponse> CreateCompilationJobAsync(CreateCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCompilationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCompilationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpoint

        internal virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpointConfig

        internal virtual CreateEndpointConfigResponse CreateEndpointConfig(CreateEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        public virtual Task<CreateEndpointConfigResponse> CreateEndpointConfigAsync(CreateEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHyperParameterTuningJob

        internal virtual CreateHyperParameterTuningJobResponse CreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<CreateHyperParameterTuningJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        public virtual Task<CreateHyperParameterTuningJobResponse> CreateHyperParameterTuningJobAsync(CreateHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLabelingJob

        internal virtual CreateLabelingJobResponse CreateLabelingJob(CreateLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelingJobResponseUnmarshaller.Instance;

            return Invoke<CreateLabelingJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        public virtual Task<CreateLabelingJobResponse> CreateLabelingJobAsync(CreateLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelingJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLabelingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModel

        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelPackage

        internal virtual CreateModelPackageResponse CreateModelPackage(CreateModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageResponseUnmarshaller.Instance;

            return Invoke<CreateModelPackageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        public virtual Task<CreateModelPackageResponse> CreateModelPackageAsync(CreateModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotebookInstance

        internal virtual CreateNotebookInstanceResponse CreateNotebookInstance(CreateNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        public virtual Task<CreateNotebookInstanceResponse> CreateNotebookInstanceAsync(CreateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNotebookInstanceLifecycleConfig

        internal virtual CreateNotebookInstanceLifecycleConfigResponse CreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<CreateNotebookInstanceLifecycleConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual Task<CreateNotebookInstanceLifecycleConfigResponse> CreateNotebookInstanceLifecycleConfigAsync(CreateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePresignedNotebookInstanceUrl

        internal virtual CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookInstanceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return Invoke<CreatePresignedNotebookInstanceUrlResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        public virtual Task<CreatePresignedNotebookInstanceUrlResponse> CreatePresignedNotebookInstanceUrlAsync(CreatePresignedNotebookInstanceUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePresignedNotebookInstanceUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePresignedNotebookInstanceUrlResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePresignedNotebookInstanceUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrainingJob

        internal virtual CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return Invoke<CreateTrainingJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        public virtual Task<CreateTrainingJobResponse> CreateTrainingJobAsync(CreateTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransformJob

        internal virtual CreateTransformJobResponse CreateTransformJob(CreateTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformJobResponseUnmarshaller.Instance;

            return Invoke<CreateTransformJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        public virtual Task<CreateTransformJobResponse> CreateTransformJobAsync(CreateTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransformJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkteam

        internal virtual CreateWorkteamResponse CreateWorkteam(CreateWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkteamResponseUnmarshaller.Instance;

            return Invoke<CreateWorkteamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        public virtual Task<CreateWorkteamResponse> CreateWorkteamAsync(CreateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlgorithm

        internal virtual DeleteAlgorithmResponse DeleteAlgorithm(DeleteAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DeleteAlgorithmResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        public virtual Task<DeleteAlgorithmResponse> DeleteAlgorithmAsync(DeleteAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlgorithmResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlgorithmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCodeRepository

        internal virtual DeleteCodeRepositoryResponse DeleteCodeRepository(DeleteCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteCodeRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        public virtual Task<DeleteCodeRepositoryResponse> DeleteCodeRepositoryAsync(DeleteCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpointConfig

        internal virtual DeleteEndpointConfigResponse DeleteEndpointConfig(DeleteEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        public virtual Task<DeleteEndpointConfigResponse> DeleteEndpointConfigAsync(DeleteEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel

        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelPackage

        internal virtual DeleteModelPackageResponse DeleteModelPackage(DeleteModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageResponseUnmarshaller.Instance;

            return Invoke<DeleteModelPackageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        public virtual Task<DeleteModelPackageResponse> DeleteModelPackageAsync(DeleteModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotebookInstance

        internal virtual DeleteNotebookInstanceResponse DeleteNotebookInstance(DeleteNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        public virtual Task<DeleteNotebookInstanceResponse> DeleteNotebookInstanceAsync(DeleteNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotebookInstanceLifecycleConfig

        internal virtual DeleteNotebookInstanceLifecycleConfigResponse DeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteNotebookInstanceLifecycleConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual Task<DeleteNotebookInstanceLifecycleConfigResponse> DeleteNotebookInstanceLifecycleConfigAsync(DeleteNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkteam

        internal virtual DeleteWorkteamResponse DeleteWorkteam(DeleteWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkteamResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkteamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        public virtual Task<DeleteWorkteamResponse> DeleteWorkteamAsync(DeleteWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlgorithm

        internal virtual DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return Invoke<DescribeAlgorithmResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        public virtual Task<DescribeAlgorithmResponse> DescribeAlgorithmAsync(DescribeAlgorithmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlgorithmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlgorithmResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlgorithmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCodeRepository

        internal virtual DescribeCodeRepositoryResponse DescribeCodeRepository(DescribeCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        public virtual Task<DescribeCodeRepositoryResponse> DescribeCodeRepositoryAsync(DescribeCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCompilationJob

        internal virtual DescribeCompilationJobResponse DescribeCompilationJob(DescribeCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompilationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeCompilationJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        public virtual Task<DescribeCompilationJobResponse> DescribeCompilationJobAsync(DescribeCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompilationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCompilationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoint

        internal virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpointConfig

        internal virtual DescribeEndpointConfigResponse DescribeEndpointConfig(DescribeEndpointConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        public virtual Task<DescribeEndpointConfigResponse> DescribeEndpointConfigAsync(DescribeEndpointConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHyperParameterTuningJob

        internal virtual DescribeHyperParameterTuningJobResponse DescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<DescribeHyperParameterTuningJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        public virtual Task<DescribeHyperParameterTuningJobResponse> DescribeHyperParameterTuningJobAsync(DescribeHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLabelingJob

        internal virtual DescribeLabelingJobResponse DescribeLabelingJob(DescribeLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeLabelingJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        public virtual Task<DescribeLabelingJobResponse> DescribeLabelingJobAsync(DescribeLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLabelingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModel

        internal virtual DescribeModelResponse DescribeModel(DescribeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeModelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelPackage

        internal virtual DescribeModelPackageResponse DescribeModelPackage(DescribeModelPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageResponseUnmarshaller.Instance;

            return Invoke<DescribeModelPackageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        public virtual Task<DescribeModelPackageResponse> DescribeModelPackageAsync(DescribeModelPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotebookInstance

        internal virtual DescribeNotebookInstanceResponse DescribeNotebookInstance(DescribeNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        public virtual Task<DescribeNotebookInstanceResponse> DescribeNotebookInstanceAsync(DescribeNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotebookInstanceLifecycleConfig

        internal virtual DescribeNotebookInstanceLifecycleConfigResponse DescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookInstanceLifecycleConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual Task<DescribeNotebookInstanceLifecycleConfigResponse> DescribeNotebookInstanceLifecycleConfigAsync(DescribeNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubscribedWorkteam

        internal virtual DescribeSubscribedWorkteamResponse DescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribedWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribedWorkteamResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscribedWorkteamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscribedWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        public virtual Task<DescribeSubscribedWorkteamResponse> DescribeSubscribedWorkteamAsync(DescribeSubscribedWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscribedWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscribedWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubscribedWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrainingJob

        internal virtual DescribeTrainingJobResponse DescribeTrainingJob(DescribeTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTrainingJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        public virtual Task<DescribeTrainingJobResponse> DescribeTrainingJobAsync(DescribeTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransformJob

        internal virtual DescribeTransformJobResponse DescribeTransformJob(DescribeTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransformJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTransformJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        public virtual Task<DescribeTransformJobResponse> DescribeTransformJobAsync(DescribeTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransformJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkteam

        internal virtual DescribeWorkteamResponse DescribeWorkteam(DescribeWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkteamResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkteamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        public virtual Task<DescribeWorkteamResponse> DescribeWorkteamAsync(DescribeWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSearchSuggestions

        internal virtual GetSearchSuggestionsResponse GetSearchSuggestions(GetSearchSuggestionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSearchSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchSuggestionsResponseUnmarshaller.Instance;

            return Invoke<GetSearchSuggestionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSearchSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        public virtual Task<GetSearchSuggestionsResponse> GetSearchSuggestionsAsync(GetSearchSuggestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSearchSuggestionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchSuggestionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSearchSuggestionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAlgorithms

        internal virtual ListAlgorithmsResponse ListAlgorithms(ListAlgorithmsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlgorithmsResponseUnmarshaller.Instance;

            return Invoke<ListAlgorithmsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        public virtual Task<ListAlgorithmsResponse> ListAlgorithmsAsync(ListAlgorithmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlgorithmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlgorithmsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAlgorithmsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCodeRepositories

        internal virtual ListCodeRepositoriesResponse ListCodeRepositories(ListCodeRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListCodeRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        public virtual Task<ListCodeRepositoriesResponse> ListCodeRepositoriesAsync(ListCodeRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCompilationJobs

        internal virtual ListCompilationJobsResponse ListCompilationJobs(ListCompilationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompilationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompilationJobsResponseUnmarshaller.Instance;

            return Invoke<ListCompilationJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListCompilationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        public virtual Task<ListCompilationJobsResponse> ListCompilationJobsAsync(ListCompilationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompilationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompilationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCompilationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpointConfigs

        internal virtual ListEndpointConfigsResponse ListEndpointConfigs(ListEndpointConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointConfigsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        public virtual Task<ListEndpointConfigsResponse> ListEndpointConfigsAsync(ListEndpointConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpoints

        internal virtual ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHyperParameterTuningJobs

        internal virtual ListHyperParameterTuningJobsResponse ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHyperParameterTuningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHyperParameterTuningJobsResponseUnmarshaller.Instance;

            return Invoke<ListHyperParameterTuningJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHyperParameterTuningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        public virtual Task<ListHyperParameterTuningJobsResponse> ListHyperParameterTuningJobsAsync(ListHyperParameterTuningJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHyperParameterTuningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHyperParameterTuningJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHyperParameterTuningJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLabelingJobs

        internal virtual ListLabelingJobsResponse ListLabelingJobs(ListLabelingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsResponseUnmarshaller.Instance;

            return Invoke<ListLabelingJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        public virtual Task<ListLabelingJobsResponse> ListLabelingJobsAsync(ListLabelingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLabelingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLabelingJobsForWorkteam

        internal virtual ListLabelingJobsForWorkteamResponse ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsForWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsForWorkteamResponseUnmarshaller.Instance;

            return Invoke<ListLabelingJobsForWorkteamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobsForWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        public virtual Task<ListLabelingJobsForWorkteamResponse> ListLabelingJobsForWorkteamAsync(ListLabelingJobsForWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelingJobsForWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelingJobsForWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<ListLabelingJobsForWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModelPackages

        internal virtual ListModelPackagesResponse ListModelPackages(ListModelPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagesResponseUnmarshaller.Instance;

            return Invoke<ListModelPackagesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListModelPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        public virtual Task<ListModelPackagesResponse> ListModelPackagesAsync(ListModelPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelPackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListModels

        internal virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotebookInstanceLifecycleConfigs

        internal virtual ListNotebookInstanceLifecycleConfigsResponse ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstanceLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstanceLifecycleConfigsResponseUnmarshaller.Instance;

            return Invoke<ListNotebookInstanceLifecycleConfigsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstanceLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        public virtual Task<ListNotebookInstanceLifecycleConfigsResponse> ListNotebookInstanceLifecycleConfigsAsync(ListNotebookInstanceLifecycleConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstanceLifecycleConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstanceLifecycleConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotebookInstanceLifecycleConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNotebookInstances

        internal virtual ListNotebookInstancesResponse ListNotebookInstances(ListNotebookInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return Invoke<ListNotebookInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        public virtual Task<ListNotebookInstancesResponse> ListNotebookInstancesAsync(ListNotebookInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotebookInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscribedWorkteams

        internal virtual ListSubscribedWorkteamsResponse ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribedWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedWorkteamsResponseUnmarshaller.Instance;

            return Invoke<ListSubscribedWorkteamsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscribedWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        public virtual Task<ListSubscribedWorkteamsResponse> ListSubscribedWorkteamsAsync(ListSubscribedWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribedWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribedWorkteamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubscribedWorkteamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrainingJobs

        internal virtual ListTrainingJobsResponse ListTrainingJobs(ListTrainingJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return Invoke<ListTrainingJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        public virtual Task<ListTrainingJobsResponse> ListTrainingJobsAsync(ListTrainingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrainingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrainingJobsForHyperParameterTuningJob

        internal virtual ListTrainingJobsForHyperParameterTuningJobResponse ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsForHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsForHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<ListTrainingJobsForHyperParameterTuningJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobsForHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        public virtual Task<ListTrainingJobsForHyperParameterTuningJobResponse> ListTrainingJobsForHyperParameterTuningJobAsync(ListTrainingJobsForHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingJobsForHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingJobsForHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrainingJobsForHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTransformJobs

        internal virtual ListTransformJobsResponse ListTransformJobs(ListTransformJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformJobsResponseUnmarshaller.Instance;

            return Invoke<ListTransformJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        public virtual Task<ListTransformJobsResponse> ListTransformJobsAsync(ListTransformJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTransformJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTransformJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkteams

        internal virtual ListWorkteamsResponse ListWorkteams(ListWorkteamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkteamsResponseUnmarshaller.Instance;

            return Invoke<ListWorkteamsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        public virtual Task<ListWorkteamsResponse> ListWorkteamsAsync(ListWorkteamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkteamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkteamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkteamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RenderUiTemplate

        internal virtual RenderUiTemplateResponse RenderUiTemplate(RenderUiTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenderUiTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderUiTemplateResponseUnmarshaller.Instance;

            return Invoke<RenderUiTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RenderUiTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        public virtual Task<RenderUiTemplateResponse> RenderUiTemplateAsync(RenderUiTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RenderUiTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RenderUiTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<RenderUiTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Search

        internal virtual SearchResponse Search(SearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        public virtual Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return InvokeAsync<SearchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartNotebookInstance

        internal virtual StartNotebookInstanceResponse StartNotebookInstance(StartNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StartNotebookInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        public virtual Task<StartNotebookInstanceResponse> StartNotebookInstanceAsync(StartNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopCompilationJob

        internal virtual StopCompilationJobResponse StopCompilationJob(StopCompilationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompilationJobResponseUnmarshaller.Instance;

            return Invoke<StopCompilationJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        public virtual Task<StopCompilationJobResponse> StopCompilationJobAsync(StopCompilationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompilationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompilationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopCompilationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopHyperParameterTuningJob

        internal virtual StopHyperParameterTuningJobResponse StopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHyperParameterTuningJobResponseUnmarshaller.Instance;

            return Invoke<StopHyperParameterTuningJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        public virtual Task<StopHyperParameterTuningJobResponse> StopHyperParameterTuningJobAsync(StopHyperParameterTuningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHyperParameterTuningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHyperParameterTuningJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopHyperParameterTuningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopLabelingJob

        internal virtual StopLabelingJobResponse StopLabelingJob(StopLabelingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLabelingJobResponseUnmarshaller.Instance;

            return Invoke<StopLabelingJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        public virtual Task<StopLabelingJobResponse> StopLabelingJobAsync(StopLabelingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopLabelingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopLabelingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopLabelingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopNotebookInstance

        internal virtual StopNotebookInstanceResponse StopNotebookInstance(StopNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<StopNotebookInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        public virtual Task<StopNotebookInstanceResponse> StopNotebookInstanceAsync(StopNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTrainingJob

        internal virtual StopTrainingJobResponse StopTrainingJob(StopTrainingJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return Invoke<StopTrainingJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        public virtual Task<StopTrainingJobResponse> StopTrainingJobAsync(StopTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTransformJob

        internal virtual StopTransformJobResponse StopTransformJob(StopTransformJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTransformJobResponseUnmarshaller.Instance;

            return Invoke<StopTransformJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        public virtual Task<StopTransformJobResponse> StopTransformJobAsync(StopTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTransformJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCodeRepository

        internal virtual UpdateCodeRepositoryResponse UpdateCodeRepository(UpdateCodeRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeRepositoryResponseUnmarshaller.Instance;

            return Invoke<UpdateCodeRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        public virtual Task<UpdateCodeRepositoryResponse> UpdateCodeRepositoryAsync(UpdateCodeRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCodeRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpoint

        internal virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpointWeightsAndCapacities

        internal virtual UpdateEndpointWeightsAndCapacitiesResponse UpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointWeightsAndCapacitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointWeightsAndCapacitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        public virtual Task<UpdateEndpointWeightsAndCapacitiesResponse> UpdateEndpointWeightsAndCapacitiesAsync(UpdateEndpointWeightsAndCapacitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointWeightsAndCapacitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointWeightsAndCapacitiesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointWeightsAndCapacitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotebookInstance

        internal virtual UpdateNotebookInstanceResponse UpdateNotebookInstance(UpdateNotebookInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        public virtual Task<UpdateNotebookInstanceResponse> UpdateNotebookInstanceAsync(UpdateNotebookInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotebookInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNotebookInstanceLifecycleConfig

        internal virtual UpdateNotebookInstanceLifecycleConfigResponse UpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateNotebookInstanceLifecycleConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        public virtual Task<UpdateNotebookInstanceLifecycleConfigResponse> UpdateNotebookInstanceLifecycleConfigAsync(UpdateNotebookInstanceLifecycleConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNotebookInstanceLifecycleConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotebookInstanceLifecycleConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotebookInstanceLifecycleConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkteam

        internal virtual UpdateWorkteamResponse UpdateWorkteam(UpdateWorkteamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkteamResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkteamResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        public virtual Task<UpdateWorkteamResponse> UpdateWorkteamAsync(UpdateWorkteamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkteamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkteamResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkteamResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}