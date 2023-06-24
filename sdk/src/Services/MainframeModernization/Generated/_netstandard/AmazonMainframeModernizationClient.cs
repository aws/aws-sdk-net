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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MainframeModernization.Model;
using Amazon.MainframeModernization.Model.Internal.MarshallTransformations;
using Amazon.MainframeModernization.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MainframeModernization
{
    /// <summary>
    /// Implementation for accessing MainframeModernization
    ///
    /// Amazon Web Services Mainframe Modernization provides tools and resources to help you
    /// plan and implement migration and modernization from mainframes to Amazon Web Services
    /// managed runtime environments. It provides tools for analyzing existing mainframe applications,
    /// developing or updating mainframe applications using COBOL or PL/I, and implementing
    /// an automated pipeline for continuous integration and continuous delivery (CI/CD) of
    /// the applications.
    /// </summary>
    public partial class AmazonMainframeModernizationClient : AmazonServiceClient, IAmazonMainframeModernization
    {
        private static IServiceMetadata serviceMetadata = new AmazonMainframeModernizationMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with the credentials loaded from the application's
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
        public AmazonMainframeModernizationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMainframeModernizationConfig()) { }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with the credentials loaded from the application's
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
        public AmazonMainframeModernizationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMainframeModernizationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMainframeModernizationClient Configuration Object</param>
        public AmazonMainframeModernizationClient(AmazonMainframeModernizationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMainframeModernizationClient(AWSCredentials credentials)
            : this(credentials, new AmazonMainframeModernizationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMainframeModernizationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMainframeModernizationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Credentials and an
        /// AmazonMainframeModernizationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMainframeModernizationClient Configuration Object</param>
        public AmazonMainframeModernizationClient(AWSCredentials credentials, AmazonMainframeModernizationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMainframeModernizationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMainframeModernizationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMainframeModernizationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMainframeModernizationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMainframeModernizationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMainframeModernizationClient Configuration Object</param>
        public AmazonMainframeModernizationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMainframeModernizationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMainframeModernizationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMainframeModernizationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMainframeModernizationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMainframeModernizationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMainframeModernizationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMainframeModernizationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMainframeModernizationClient Configuration Object</param>
        public AmazonMainframeModernizationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMainframeModernizationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMainframeModernizationPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMainframeModernizationPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MainframeModernizationPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMainframeModernizationEndpointResolver());
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


        #region  CancelBatchJobExecution

        internal virtual CancelBatchJobExecutionResponse CancelBatchJobExecution(CancelBatchJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBatchJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBatchJobExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelBatchJobExecutionResponse>(request, options);
        }



        /// <summary>
        /// Cancels the running of a specific batch job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchJobExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelBatchJobExecution service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CancelBatchJobExecution">REST API Reference for CancelBatchJobExecution Operation</seealso>
        public virtual Task<CancelBatchJobExecutionResponse> CancelBatchJobExecutionAsync(CancelBatchJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBatchJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBatchJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelBatchJobExecutionResponse>(request, options, cancellationToken);
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
        /// Creates a new application with given parameters. Requires an existing runtime environment
        /// and application definition file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSetImportTask

        internal virtual CreateDataSetImportTaskResponse CreateDataSetImportTask(CreateDataSetImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetImportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateDataSetImportTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts a data set import task for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSetImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSetImportTask service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateDataSetImportTask">REST API Reference for CreateDataSetImportTask Operation</seealso>
        public virtual Task<CreateDataSetImportTaskResponse> CreateDataSetImportTaskAsync(CreateDataSetImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataSetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSetImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSetImportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Creates and starts a deployment to deploy an application into a runtime environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironment

        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Creates a runtime environment for a given runtime engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
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
        /// Deletes a specific application. You cannot delete a running application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationFromEnvironment

        internal virtual DeleteApplicationFromEnvironmentResponse DeleteApplicationFromEnvironment(DeleteApplicationFromEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationFromEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationFromEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationFromEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specific application from the specific runtime environment where it was
        /// previously deployed. You cannot delete a runtime environment using DeleteEnvironment
        /// if any application has ever been deployed to it. This API removes the association
        /// of the application with the runtime environment so you can delete the environment
        /// smoothly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationFromEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationFromEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/DeleteApplicationFromEnvironment">REST API Reference for DeleteApplicationFromEnvironment Operation</seealso>
        public virtual Task<DeleteApplicationFromEnvironmentResponse> DeleteApplicationFromEnvironmentAsync(DeleteApplicationFromEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationFromEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationFromEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationFromEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironment

        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specific runtime environment. The environment cannot contain deployed applications.
        /// If it does, you must delete those applications before you delete the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplication

        internal virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }



        /// <summary>
        /// Describes the details of a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplicationVersion

        internal virtual GetApplicationVersionResponse GetApplicationVersion(GetApplicationVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<GetApplicationVersionResponse>(request, options);
        }



        /// <summary>
        /// Returns details about a specific version of a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationVersion service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetApplicationVersion">REST API Reference for GetApplicationVersion Operation</seealso>
        public virtual Task<GetApplicationVersionResponse> GetApplicationVersionAsync(GetApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBatchJobExecution

        internal virtual GetBatchJobExecutionResponse GetBatchJobExecution(GetBatchJobExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchJobExecutionResponseUnmarshaller.Instance;

            return Invoke<GetBatchJobExecutionResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a specific batch job execution for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchJobExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBatchJobExecution service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetBatchJobExecution">REST API Reference for GetBatchJobExecution Operation</seealso>
        public virtual Task<GetBatchJobExecutionResponse> GetBatchJobExecutionAsync(GetBatchJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBatchJobExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBatchJobExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<GetBatchJobExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSetDetails

        internal virtual GetDataSetDetailsResponse GetDataSetDetails(GetDataSetDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetDetailsResponseUnmarshaller.Instance;

            return Invoke<GetDataSetDetailsResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a specific data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSetDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSetDetails service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetDataSetDetails">REST API Reference for GetDataSetDetails Operation</seealso>
        public virtual Task<GetDataSetDetailsResponse> GetDataSetDetailsAsync(GetDataSetDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSetDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataSetImportTask

        internal virtual GetDataSetImportTaskResponse GetDataSetImportTask(GetDataSetImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetImportTaskResponseUnmarshaller.Instance;

            return Invoke<GetDataSetImportTaskResponse>(request, options);
        }



        /// <summary>
        /// Gets the status of a data set import task initiated with the <a>CreateDataSetImportTask</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSetImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSetImportTask service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetDataSetImportTask">REST API Reference for GetDataSetImportTask Operation</seealso>
        public virtual Task<GetDataSetImportTaskResponse> GetDataSetImportTaskAsync(GetDataSetImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataSetImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSetImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSetImportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeployment

        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Gets details of a specific deployment with a given deployment identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironment

        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Describes a specific runtime environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
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
        /// Lists the applications associated with a specific Amazon Web Services account. You
        /// can provide the unique identifier of a specific runtime environment in a query parameter
        /// to see all applications associated with that environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
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
        /// Returns a list of the application versions for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationVersions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        public virtual Task<ListApplicationVersionsResponse> ListApplicationVersionsAsync(ListApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBatchJobDefinitions

        internal virtual ListBatchJobDefinitionsResponse ListBatchJobDefinitions(ListBatchJobDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchJobDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListBatchJobDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the available batch job definitions based on the batch job resources uploaded
        /// during the application creation. You can use the batch job definitions in the list
        /// to start a batch job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBatchJobDefinitions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListBatchJobDefinitions">REST API Reference for ListBatchJobDefinitions Operation</seealso>
        public virtual Task<ListBatchJobDefinitionsResponse> ListBatchJobDefinitionsAsync(ListBatchJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchJobDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBatchJobDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBatchJobExecutions

        internal virtual ListBatchJobExecutionsResponse ListBatchJobExecutions(ListBatchJobExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchJobExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchJobExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListBatchJobExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Lists historical, current, and scheduled batch job executions for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchJobExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBatchJobExecutions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListBatchJobExecutions">REST API Reference for ListBatchJobExecutions Operation</seealso>
        public virtual Task<ListBatchJobExecutionsResponse> ListBatchJobExecutionsAsync(ListBatchJobExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBatchJobExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBatchJobExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBatchJobExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSetImportHistory

        internal virtual ListDataSetImportHistoryResponse ListDataSetImportHistory(ListDataSetImportHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetImportHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetImportHistoryResponseUnmarshaller.Instance;

            return Invoke<ListDataSetImportHistoryResponse>(request, options);
        }



        /// <summary>
        /// Lists the data set imports for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetImportHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSetImportHistory service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListDataSetImportHistory">REST API Reference for ListDataSetImportHistory Operation</seealso>
        public virtual Task<ListDataSetImportHistoryResponse> ListDataSetImportHistoryAsync(ListDataSetImportHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetImportHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetImportHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSetImportHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataSets

        internal virtual ListDataSetsResponse ListDataSets(ListDataSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return Invoke<ListDataSetsResponse>(request, options);
        }



        /// <summary>
        /// Lists the data sets imported for a specific application. In Amazon Web Services Mainframe
        /// Modernization, data sets are associated with applications deployed on runtime environments.
        /// This is known as importing data sets. Currently, Amazon Web Services Mainframe Modernization
        /// can import data sets into catalogs using <a href="https://docs.aws.amazon.com/m2/latest/APIReference/API_CreateDataSetImportTask.html">CreateDataSetImportTask</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        public virtual Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeployments

        internal virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all deployments of a specific application. A deployment is a combination
        /// of a specific application and a specific version of that application. Each deployment
        /// is mapped to a particular application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngineVersions

        internal virtual ListEngineVersionsResponse ListEngineVersions(ListEngineVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<ListEngineVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the available engine versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngineVersions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListEngineVersions">REST API Reference for ListEngineVersions Operation</seealso>
        public virtual Task<ListEngineVersionsResponse> ListEngineVersionsAsync(ListEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEngineVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironments

        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the runtime environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
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
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Starts an application that is currently stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartBatchJob

        internal virtual StartBatchJobResponse StartBatchJob(StartBatchJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBatchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBatchJobResponseUnmarshaller.Instance;

            return Invoke<StartBatchJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a batch job and returns the unique identifier of this execution of the batch
        /// job. The associated application must be running in order to start the batch job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBatchJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBatchJob service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/StartBatchJob">REST API Reference for StartBatchJob Operation</seealso>
        public virtual Task<StartBatchJobResponse> StartBatchJobAsync(StartBatchJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBatchJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBatchJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartBatchJobResponse>(request, options, cancellationToken);
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
        /// Stops a running application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/StopApplication">REST API Reference for StopApplication Operation</seealso>
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
        /// Adds one or more tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// Updates an application and creates a new version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment

        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration details for a specific runtime environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}