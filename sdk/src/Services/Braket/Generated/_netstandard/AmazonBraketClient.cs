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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Braket.Model;
using Amazon.Braket.Model.Internal.MarshallTransformations;
using Amazon.Braket.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Braket
{
    /// <summary>
    /// Implementation for accessing Braket
    ///
    /// The Amazon Braket API Reference provides information about the operations and structures
    /// supported in Amazon Braket.
    /// 
    ///  
    /// <para>
    /// Additional Resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/braket/latest/developerguide/what-is-braket.html">Amazon
    /// Braket Developer Guide</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonBraketClient : AmazonServiceClient, IAmazonBraket
    {
        private static IServiceMetadata serviceMetadata = new AmazonBraketMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBraketClient with the credentials loaded from the application's
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
        public AmazonBraketClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBraketConfig()) { }

        /// <summary>
        /// Constructs AmazonBraketClient with the credentials loaded from the application's
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
        public AmazonBraketClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBraketConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBraketClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBraketClient Configuration Object</param>
        public AmazonBraketClient(AmazonBraketConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonBraketClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBraketClient(AWSCredentials credentials)
            : this(credentials, new AmazonBraketConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBraketClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBraketConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Credentials and an
        /// AmazonBraketClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBraketClient Configuration Object</param>
        public AmazonBraketClient(AWSCredentials credentials, AmazonBraketConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBraketClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBraketConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBraketClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBraketConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBraketClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBraketClient Configuration Object</param>
        public AmazonBraketClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBraketConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBraketClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBraketConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBraketClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBraketConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBraketClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBraketClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBraketClient Configuration Object</param>
        public AmazonBraketClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBraketConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IBraketPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBraketPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BraketPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBraketEndpointResolver());
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


        #region  CancelJob

        internal virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels an Amazon Braket job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelQuantumTask

        internal virtual CancelQuantumTaskResponse CancelQuantumTask(CancelQuantumTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelQuantumTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQuantumTaskResponseUnmarshaller.Instance;

            return Invoke<CancelQuantumTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels the specified task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuantumTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CancelQuantumTask">REST API Reference for CancelQuantumTask Operation</seealso>
        public virtual Task<CancelQuantumTaskResponse> CancelQuantumTaskAsync(CancelQuantumTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelQuantumTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQuantumTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelQuantumTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob

        internal virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Braket job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceRetiredException">
        /// The specified device has been retired.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQuantumTask

        internal virtual CreateQuantumTaskResponse CreateQuantumTask(CreateQuantumTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuantumTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuantumTaskResponseUnmarshaller.Instance;

            return Invoke<CreateQuantumTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a quantum task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuantumTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceOfflineException">
        /// The specified device is currently offline.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceRetiredException">
        /// The specified device has been retired.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CreateQuantumTask">REST API Reference for CreateQuantumTask Operation</seealso>
        public virtual Task<CreateQuantumTaskResponse> CreateQuantumTaskAsync(CreateQuantumTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQuantumTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQuantumTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQuantumTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevice

        internal virtual GetDeviceResponse GetDevice(GetDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return Invoke<GetDeviceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the devices available in Amazon Braket.
        /// 
        ///  <note> 
        /// <para>
        /// For backwards compatibility with older versions of BraketSchemas, OpenQASM information
        /// is omitted from GetDevice API calls. To get this information the user-agent needs
        /// to present a recent version of the BraketSchemas (1.8.0 or later). The Braket SDK
        /// automatically reports this for you. If you do not see OpenQASM results in the GetDevice
        /// response when using a Braket SDK, you may need to set AWS_EXECUTION_ENV environment
        /// variable to configure user-agent. See the code examples provided below for how to
        /// do this for the AWS CLI, Boto3, and the Go, Java, and JavaScript/TypeScript SDKs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetDevice">REST API Reference for GetDevice Operation</seealso>
        public virtual Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob

        internal virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified Amazon Braket job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQuantumTask

        internal virtual GetQuantumTaskResponse GetQuantumTask(GetQuantumTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQuantumTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuantumTaskResponseUnmarshaller.Instance;

            return Invoke<GetQuantumTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified quantum task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuantumTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetQuantumTask">REST API Reference for GetQuantumTask Operation</seealso>
        public virtual Task<GetQuantumTaskResponse> GetQuantumTaskAsync(GetQuantumTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQuantumTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQuantumTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetQuantumTaskResponse>(request, options, cancellationToken);
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
        /// Shows the tags associated with this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchDevices

        internal virtual SearchDevicesResponse SearchDevices(SearchDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return Invoke<SearchDevicesResponse>(request, options);
        }



        /// <summary>
        /// Searches for devices using the specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDevices service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        public virtual Task<SearchDevicesResponse> SearchDevicesAsync(SearchDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchJobs

        internal virtual SearchJobsResponse SearchJobs(SearchJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchJobsResponseUnmarshaller.Instance;

            return Invoke<SearchJobsResponse>(request, options);
        }



        /// <summary>
        /// Searches for Amazon Braket jobs that match the specified filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchJobs service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        public virtual Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchJobsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchQuantumTasks

        internal virtual SearchQuantumTasksResponse SearchQuantumTasks(SearchQuantumTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchQuantumTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQuantumTasksResponseUnmarshaller.Instance;

            return Invoke<SearchQuantumTasksResponse>(request, options);
        }



        /// <summary>
        /// Searches for tasks that match the specified filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuantumTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchQuantumTasks service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchQuantumTasks">REST API Reference for SearchQuantumTasks Operation</seealso>
        public virtual Task<SearchQuantumTasksResponse> SearchQuantumTasksAsync(SearchQuantumTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchQuantumTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchQuantumTasksResponseUnmarshaller.Instance;

            return InvokeAsync<SearchQuantumTasksResponse>(request, options, cancellationToken);
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
        /// Add a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}