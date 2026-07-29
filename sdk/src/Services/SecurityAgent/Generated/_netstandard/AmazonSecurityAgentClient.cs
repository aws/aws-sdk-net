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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityAgent.Model;
using Amazon.SecurityAgent.Model.Internal.MarshallTransformations;
using Amazon.SecurityAgent.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SecurityAgent
{
    /// <summary>
    /// <para>Implementation for accessing SecurityAgent</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Security Agent is a frontier agent that proactively secures your applications
    /// throughout the development lifecycle. It conducts automated security reviews tailored
    /// to your organizational requirements and delivers context-aware penetration testing
    /// on demand. By continuously validating security from design to deployment, AWS Security
    /// Agent helps prevent vulnerabilities early across all your environments. Key capabilities
    /// include design security review for architecture documents, code security review for
    /// pull requests in connected repositories, and on-demand penetration testing that discovers,
    /// validates, and remediates security vulnerabilities through tailored multi-step attack
    /// scenarios. For more information, see the <a href="https://docs.aws.amazon.com/securityagent/latest/userguide/what-is.html">AWS
    /// Security Agent User Guide</a>.
    /// </summary>
    public partial class AmazonSecurityAgentClient : AmazonServiceClient, IAmazonSecurityAgent
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityAgentMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with the credentials loaded from the application's
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
        public AmazonSecurityAgentClient()
            : base(new AmazonSecurityAgentConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with the credentials loaded from the application's
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
        public AmazonSecurityAgentClient(RegionEndpoint region)
            : base(new AmazonSecurityAgentConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSecurityAgentClient Configuration Object</param>
        public AmazonSecurityAgentClient(AmazonSecurityAgentConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityAgentClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityAgentClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Credentials and an
        /// AmazonSecurityAgentClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityAgentClient Configuration Object</param>
        public AmazonSecurityAgentClient(AWSCredentials credentials, AmazonSecurityAgentConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityAgentClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityAgentClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityAgentConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityAgentClient Configuration Object</param>
        public AmazonSecurityAgentClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityAgentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityAgentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityAgentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityAgentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityAgentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityAgentClient Configuration Object</param>
        public AmazonSecurityAgentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityAgentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISecurityAgentPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISecurityAgentPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SecurityAgentPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityAgentEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityAgentAuthSchemeHandler());
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


        #region  AddArtifact

        internal virtual AddArtifactResponse AddArtifact(AddArtifactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddArtifactResponseUnmarshaller.Instance;

            return Invoke<AddArtifactResponse>(request, options);
        }



        /// <summary>
        /// Uploads an artifact to an agent space. Artifacts provide additional context for security
        /// testing, such as architecture diagrams, API specifications, or configuration files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/AddArtifact">REST API Reference for AddArtifact Operation</seealso>
        public virtual Task<AddArtifactResponse> AddArtifactAsync(AddArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<AddArtifactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchCreateSecurityRequirements

        internal virtual BatchCreateSecurityRequirementsResponse BatchCreateSecurityRequirements(BatchCreateSecurityRequirementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateSecurityRequirementsResponseUnmarshaller.Instance;

            return Invoke<BatchCreateSecurityRequirementsResponse>(request, options);
        }



        /// <summary>
        /// Batch creates security requirements in a customer managed pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota. Review your current usage and request a quota
        /// increase if needed.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchCreateSecurityRequirements">REST API Reference for BatchCreateSecurityRequirements Operation</seealso>
        public virtual Task<BatchCreateSecurityRequirementsResponse> BatchCreateSecurityRequirementsAsync(BatchCreateSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateSecurityRequirementsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateSecurityRequirementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteCodeReviews

        internal virtual BatchDeleteCodeReviewsResponse BatchDeleteCodeReviews(BatchDeleteCodeReviewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteCodeReviewsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteCodeReviewsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more code reviews from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCodeReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteCodeReviews service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeleteCodeReviews">REST API Reference for BatchDeleteCodeReviews Operation</seealso>
        public virtual Task<BatchDeleteCodeReviewsResponse> BatchDeleteCodeReviewsAsync(BatchDeleteCodeReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteCodeReviewsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteCodeReviewsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeletePentests

        internal virtual BatchDeletePentestsResponse BatchDeletePentests(BatchDeletePentestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeletePentestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePentestsResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePentestsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more pentests from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeletePentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeletePentests">REST API Reference for BatchDeletePentests Operation</seealso>
        public virtual Task<BatchDeletePentestsResponse> BatchDeletePentestsAsync(BatchDeletePentestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeletePentestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePentestsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeletePentestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteSecurityRequirements

        internal virtual BatchDeleteSecurityRequirementsResponse BatchDeleteSecurityRequirements(BatchDeleteSecurityRequirementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteSecurityRequirementsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteSecurityRequirementsResponse>(request, options);
        }



        /// <summary>
        /// Batch deletes security requirements from a customer managed pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeleteSecurityRequirements">REST API Reference for BatchDeleteSecurityRequirements Operation</seealso>
        public virtual Task<BatchDeleteSecurityRequirementsResponse> BatchDeleteSecurityRequirementsAsync(BatchDeleteSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteSecurityRequirementsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteSecurityRequirementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteThreatModels

        internal virtual BatchDeleteThreatModelsResponse BatchDeleteThreatModels(BatchDeleteThreatModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteThreatModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteThreatModelsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteThreatModelsResponse>(request, options);
        }



        /// <summary>
        /// Deletes one or more threat models from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteThreatModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteThreatModels service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeleteThreatModels">REST API Reference for BatchDeleteThreatModels Operation</seealso>
        public virtual Task<BatchDeleteThreatModelsResponse> BatchDeleteThreatModelsAsync(BatchDeleteThreatModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteThreatModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteThreatModelsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteThreatModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetAgentSpaces

        internal virtual BatchGetAgentSpacesResponse BatchGetAgentSpaces(BatchGetAgentSpacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAgentSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAgentSpacesResponseUnmarshaller.Instance;

            return Invoke<BatchGetAgentSpacesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more agent spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetAgentSpaces">REST API Reference for BatchGetAgentSpaces Operation</seealso>
        public virtual Task<BatchGetAgentSpacesResponse> BatchGetAgentSpacesAsync(BatchGetAgentSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAgentSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAgentSpacesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetAgentSpacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetArtifactMetadata

        internal virtual BatchGetArtifactMetadataResponse BatchGetArtifactMetadata(BatchGetArtifactMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetArtifactMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetArtifactMetadataResponseUnmarshaller.Instance;

            return Invoke<BatchGetArtifactMetadataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves metadata for one or more artifacts in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetArtifactMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetArtifactMetadata service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetArtifactMetadata">REST API Reference for BatchGetArtifactMetadata Operation</seealso>
        public virtual Task<BatchGetArtifactMetadataResponse> BatchGetArtifactMetadataAsync(BatchGetArtifactMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetArtifactMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetArtifactMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetArtifactMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetCodeReviewJobs

        internal virtual BatchGetCodeReviewJobsResponse BatchGetCodeReviewJobs(BatchGetCodeReviewJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeReviewJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeReviewJobsResponseUnmarshaller.Instance;

            return Invoke<BatchGetCodeReviewJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more code review jobs in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeReviewJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeReviewJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetCodeReviewJobs">REST API Reference for BatchGetCodeReviewJobs Operation</seealso>
        public virtual Task<BatchGetCodeReviewJobsResponse> BatchGetCodeReviewJobsAsync(BatchGetCodeReviewJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeReviewJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeReviewJobsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetCodeReviewJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetCodeReviewJobTasks

        internal virtual BatchGetCodeReviewJobTasksResponse BatchGetCodeReviewJobTasks(BatchGetCodeReviewJobTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeReviewJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeReviewJobTasksResponseUnmarshaller.Instance;

            return Invoke<BatchGetCodeReviewJobTasksResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more tasks within a code review job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeReviewJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeReviewJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetCodeReviewJobTasks">REST API Reference for BatchGetCodeReviewJobTasks Operation</seealso>
        public virtual Task<BatchGetCodeReviewJobTasksResponse> BatchGetCodeReviewJobTasksAsync(BatchGetCodeReviewJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeReviewJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeReviewJobTasksResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetCodeReviewJobTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetCodeReviews

        internal virtual BatchGetCodeReviewsResponse BatchGetCodeReviews(BatchGetCodeReviewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeReviewsResponseUnmarshaller.Instance;

            return Invoke<BatchGetCodeReviewsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more code reviews in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeReviews service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetCodeReviews">REST API Reference for BatchGetCodeReviews Operation</seealso>
        public virtual Task<BatchGetCodeReviewsResponse> BatchGetCodeReviewsAsync(BatchGetCodeReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCodeReviewsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetCodeReviewsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetFindings

        internal virtual BatchGetFindingsResponse BatchGetFindings(BatchGetFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFindingsResponseUnmarshaller.Instance;

            return Invoke<BatchGetFindingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more security findings in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        public virtual Task<BatchGetFindingsResponse> BatchGetFindingsAsync(BatchGetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetFindingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetPentestJobs

        internal virtual BatchGetPentestJobsResponse BatchGetPentestJobs(BatchGetPentestJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetPentestJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPentestJobsResponseUnmarshaller.Instance;

            return Invoke<BatchGetPentestJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more pentest jobs in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentestJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobs">REST API Reference for BatchGetPentestJobs Operation</seealso>
        public virtual Task<BatchGetPentestJobsResponse> BatchGetPentestJobsAsync(BatchGetPentestJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetPentestJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPentestJobsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetPentestJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetPentestJobTasks

        internal virtual BatchGetPentestJobTasksResponse BatchGetPentestJobTasks(BatchGetPentestJobTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetPentestJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPentestJobTasksResponseUnmarshaller.Instance;

            return Invoke<BatchGetPentestJobTasksResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more tasks within a pentest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobTasks">REST API Reference for BatchGetPentestJobTasks Operation</seealso>
        public virtual Task<BatchGetPentestJobTasksResponse> BatchGetPentestJobTasksAsync(BatchGetPentestJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetPentestJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPentestJobTasksResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetPentestJobTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetPentests

        internal virtual BatchGetPentestsResponse BatchGetPentests(BatchGetPentestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetPentestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPentestsResponseUnmarshaller.Instance;

            return Invoke<BatchGetPentestsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more pentests in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentests">REST API Reference for BatchGetPentests Operation</seealso>
        public virtual Task<BatchGetPentestsResponse> BatchGetPentestsAsync(BatchGetPentestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetPentestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetPentestsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetPentestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetSecurityRequirements

        internal virtual BatchGetSecurityRequirementsResponse BatchGetSecurityRequirements(BatchGetSecurityRequirementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecurityRequirementsResponseUnmarshaller.Instance;

            return Invoke<BatchGetSecurityRequirementsResponse>(request, options);
        }



        /// <summary>
        /// Batch retrieves security requirements from a pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetSecurityRequirements">REST API Reference for BatchGetSecurityRequirements Operation</seealso>
        public virtual Task<BatchGetSecurityRequirementsResponse> BatchGetSecurityRequirementsAsync(BatchGetSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetSecurityRequirementsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetSecurityRequirementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetTargetDomains

        internal virtual BatchGetTargetDomainsResponse BatchGetTargetDomains(BatchGetTargetDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetTargetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTargetDomainsResponseUnmarshaller.Instance;

            return Invoke<BatchGetTargetDomainsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more target domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTargetDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetTargetDomains">REST API Reference for BatchGetTargetDomains Operation</seealso>
        public virtual Task<BatchGetTargetDomainsResponse> BatchGetTargetDomainsAsync(BatchGetTargetDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetTargetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetTargetDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetTargetDomainsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetThreatModelJobs

        internal virtual BatchGetThreatModelJobsResponse BatchGetThreatModelJobs(BatchGetThreatModelJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatModelJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatModelJobsResponseUnmarshaller.Instance;

            return Invoke<BatchGetThreatModelJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more threat model jobs in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreatModelJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreatModelJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreatModelJobs">REST API Reference for BatchGetThreatModelJobs Operation</seealso>
        public virtual Task<BatchGetThreatModelJobsResponse> BatchGetThreatModelJobsAsync(BatchGetThreatModelJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatModelJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatModelJobsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetThreatModelJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetThreatModelJobTasks

        internal virtual BatchGetThreatModelJobTasksResponse BatchGetThreatModelJobTasks(BatchGetThreatModelJobTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatModelJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatModelJobTasksResponseUnmarshaller.Instance;

            return Invoke<BatchGetThreatModelJobTasksResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more tasks within a threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreatModelJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreatModelJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreatModelJobTasks">REST API Reference for BatchGetThreatModelJobTasks Operation</seealso>
        public virtual Task<BatchGetThreatModelJobTasksResponse> BatchGetThreatModelJobTasksAsync(BatchGetThreatModelJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatModelJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatModelJobTasksResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetThreatModelJobTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetThreatModels

        internal virtual BatchGetThreatModelsResponse BatchGetThreatModels(BatchGetThreatModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatModelsResponseUnmarshaller.Instance;

            return Invoke<BatchGetThreatModelsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more threat models in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreatModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreatModels service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreatModels">REST API Reference for BatchGetThreatModels Operation</seealso>
        public virtual Task<BatchGetThreatModelsResponse> BatchGetThreatModelsAsync(BatchGetThreatModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatModelsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetThreatModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetThreats

        internal virtual BatchGetThreatsResponse BatchGetThreats(BatchGetThreatsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatsResponseUnmarshaller.Instance;

            return Invoke<BatchGetThreatsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about one or more threats.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreats service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreats">REST API Reference for BatchGetThreats Operation</seealso>
        public virtual Task<BatchGetThreatsResponse> BatchGetThreatsAsync(BatchGetThreatsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetThreatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetThreatsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetThreatsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchUpdateSecurityRequirements

        internal virtual BatchUpdateSecurityRequirementsResponse BatchUpdateSecurityRequirements(BatchUpdateSecurityRequirementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateSecurityRequirementsResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateSecurityRequirementsResponse>(request, options);
        }



        /// <summary>
        /// Batch updates security requirements within a customer managed pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchUpdateSecurityRequirements">REST API Reference for BatchUpdateSecurityRequirements Operation</seealso>
        public virtual Task<BatchUpdateSecurityRequirementsResponse> BatchUpdateSecurityRequirementsAsync(BatchUpdateSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateSecurityRequirementsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchUpdateSecurityRequirementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAgentSpace

        internal virtual CreateAgentSpaceResponse CreateAgentSpace(CreateAgentSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentSpaceResponseUnmarshaller.Instance;

            return Invoke<CreateAgentSpaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new agent space. An agent space is a dedicated workspace for securing a
        /// specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        public virtual Task<CreateAgentSpaceResponse> CreateAgentSpaceAsync(CreateAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentSpaceResponse>(request, options, cancellationToken);
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
        /// Creates a new application. An application is the top-level organizational unit that
        /// supports IAM Identity Center integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCodeReview

        internal virtual CreateCodeReviewResponse CreateCodeReview(CreateCodeReviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeReviewResponseUnmarshaller.Instance;

            return Invoke<CreateCodeReviewResponse>(request, options);
        }



        /// <summary>
        /// Creates a new code review configuration in an agent space. A code review defines the
        /// parameters for automated security-focused code analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeReview service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateCodeReview">REST API Reference for CreateCodeReview Operation</seealso>
        public virtual Task<CreateCodeReviewResponse> CreateCodeReviewAsync(CreateCodeReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeReviewResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCodeReviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIntegration

        internal virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new integration with a third-party provider, such as GitHub, for code review
        /// and remediation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMembership

        internal virtual CreateMembershipResponse CreateMembership(CreateMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateMembershipResponse>(request, options);
        }



        /// <summary>
        /// Creates a new membership, granting a user access to an agent space within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual Task<CreateMembershipResponse> CreateMembershipAsync(CreateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePentest

        internal virtual CreatePentestResponse CreatePentest(CreatePentestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePentestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePentestResponseUnmarshaller.Instance;

            return Invoke<CreatePentestResponse>(request, options);
        }



        /// <summary>
        /// Creates a new pentest configuration in an agent space. A pentest defines the security
        /// test parameters, including target assets, risk type exclusions, and logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreatePentest">REST API Reference for CreatePentest Operation</seealso>
        public virtual Task<CreatePentestResponse> CreatePentestAsync(CreatePentestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePentestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePentestResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePentestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePrivateConnection

        internal virtual CreatePrivateConnectionResponse CreatePrivateConnection(CreatePrivateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a private connection for reaching a self-hosted provider instance over private
        /// networking using Amazon VPC Lattice.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateConnection service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreatePrivateConnection">REST API Reference for CreatePrivateConnection Operation</seealso>
        public virtual Task<CreatePrivateConnectionResponse> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePrivateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSecurityRequirementPack

        internal virtual CreateSecurityRequirementPackResponse CreateSecurityRequirementPack(CreateSecurityRequirementPackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityRequirementPackResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityRequirementPackResponse>(request, options);
        }



        /// <summary>
        /// Creates a customer managed security requirement pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota. Review your current usage and request a quota
        /// increase if needed.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateSecurityRequirementPack">REST API Reference for CreateSecurityRequirementPack Operation</seealso>
        public virtual Task<CreateSecurityRequirementPackResponse> CreateSecurityRequirementPackAsync(CreateSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityRequirementPackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityRequirementPackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTargetDomain

        internal virtual CreateTargetDomainResponse CreateTargetDomain(CreateTargetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetDomainResponseUnmarshaller.Instance;

            return Invoke<CreateTargetDomainResponse>(request, options);
        }



        /// <summary>
        /// Creates a new target domain for penetration testing. A target domain is a web domain
        /// that must be registered and verified before it can be tested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateTargetDomain">REST API Reference for CreateTargetDomain Operation</seealso>
        public virtual Task<CreateTargetDomainResponse> CreateTargetDomainAsync(CreateTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetDomainResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTargetDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateThreat

        internal virtual CreateThreatResponse CreateThreat(CreateThreatRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateThreatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThreatResponseUnmarshaller.Instance;

            return Invoke<CreateThreatResponse>(request, options);
        }



        /// <summary>
        /// Creates a new threat under a threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThreat service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateThreat">REST API Reference for CreateThreat Operation</seealso>
        public virtual Task<CreateThreatResponse> CreateThreatAsync(CreateThreatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateThreatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThreatResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThreatResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateThreatModel

        internal virtual CreateThreatModelResponse CreateThreatModel(CreateThreatModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateThreatModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThreatModelResponseUnmarshaller.Instance;

            return Invoke<CreateThreatModelResponse>(request, options);
        }



        /// <summary>
        /// Creates a new threat model configuration in an agent space. A threat model defines
        /// the parameters for automated threat analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThreatModel service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateThreatModel">REST API Reference for CreateThreatModel Operation</seealso>
        public virtual Task<CreateThreatModelResponse> CreateThreatModelAsync(CreateThreatModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateThreatModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateThreatModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateThreatModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAgentSpace

        internal virtual DeleteAgentSpaceResponse DeleteAgentSpace(DeleteAgentSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentSpaceResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentSpaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an agent space and all of its associated resources, including pentests, findings,
        /// and artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        public virtual Task<DeleteAgentSpaceResponse> DeleteAgentSpaceAsync(DeleteAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentSpaceResponse>(request, options, cancellationToken);
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
        /// Deletes an application and its associated configuration, including IAM Identity Center
        /// settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteArtifact

        internal virtual DeleteArtifactResponse DeleteArtifact(DeleteArtifactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArtifactResponseUnmarshaller.Instance;

            return Invoke<DeleteArtifactResponse>(request, options);
        }



        /// <summary>
        /// Deletes an artifact from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        public virtual Task<DeleteArtifactResponse> DeleteArtifactAsync(DeleteArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteArtifactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIntegration

        internal virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an integration with a third-party provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMembership

        internal virtual DeleteMembershipResponse DeleteMembership(DeleteMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteMembershipResponse>(request, options);
        }



        /// <summary>
        /// Deletes a membership, revoking a user's access to an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        public virtual Task<DeleteMembershipResponse> DeleteMembershipAsync(DeleteMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMembershipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePrivateConnection

        internal virtual DeletePrivateConnectionResponse DeletePrivateConnection(DeletePrivateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateConnectionResponseUnmarshaller.Instance;

            return Invoke<DeletePrivateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a private connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrivateConnection service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeletePrivateConnection">REST API Reference for DeletePrivateConnection Operation</seealso>
        public virtual Task<DeletePrivateConnectionResponse> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePrivateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePrivateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSecurityRequirementPack

        internal virtual DeleteSecurityRequirementPackResponse DeleteSecurityRequirementPack(DeleteSecurityRequirementPackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityRequirementPackResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityRequirementPackResponse>(request, options);
        }



        /// <summary>
        /// Deletes a customer managed security requirement pack and all its associated security
        /// requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteSecurityRequirementPack">REST API Reference for DeleteSecurityRequirementPack Operation</seealso>
        public virtual Task<DeleteSecurityRequirementPackResponse> DeleteSecurityRequirementPackAsync(DeleteSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityRequirementPackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityRequirementPackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTargetDomain

        internal virtual DeleteTargetDomainResponse DeleteTargetDomain(DeleteTargetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteTargetDomainResponse>(request, options);
        }



        /// <summary>
        /// Deletes a target domain registration. After deletion, the domain can no longer be
        /// used for penetration testing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteTargetDomain">REST API Reference for DeleteTargetDomain Operation</seealso>
        public virtual Task<DeleteTargetDomainResponse> DeleteTargetDomainAsync(DeleteTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTargetDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePrivateConnection

        internal virtual DescribePrivateConnectionResponse DescribePrivateConnection(DescribePrivateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrivateConnectionResponseUnmarshaller.Instance;

            return Invoke<DescribePrivateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a private connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrivateConnection service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DescribePrivateConnection">REST API Reference for DescribePrivateConnection Operation</seealso>
        public virtual Task<DescribePrivateConnectionResponse> DescribePrivateConnectionAsync(DescribePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePrivateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrivateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrivateConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApplication

        internal virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetArtifact

        internal virtual GetArtifactResponse GetArtifact(GetArtifactRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArtifactResponseUnmarshaller.Instance;

            return Invoke<GetArtifactResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an artifact from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetArtifact">REST API Reference for GetArtifact Operation</seealso>
        public virtual Task<GetArtifactResponse> GetArtifactAsync(GetArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArtifactResponseUnmarshaller.Instance;

            return InvokeAsync<GetArtifactResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIntegration

        internal virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSecurityRequirementPack

        internal virtual GetSecurityRequirementPackResponse GetSecurityRequirementPack(GetSecurityRequirementPackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityRequirementPackResponseUnmarshaller.Instance;

            return Invoke<GetSecurityRequirementPackResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a security requirement pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetSecurityRequirementPack">REST API Reference for GetSecurityRequirementPack Operation</seealso>
        public virtual Task<GetSecurityRequirementPackResponse> GetSecurityRequirementPackAsync(GetSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecurityRequirementPackResponseUnmarshaller.Instance;

            return InvokeAsync<GetSecurityRequirementPackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportSecurityRequirements

        internal virtual ImportSecurityRequirementsResponse ImportSecurityRequirements(ImportSecurityRequirementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSecurityRequirementsResponseUnmarshaller.Instance;

            return Invoke<ImportSecurityRequirementsResponse>(request, options);
        }



        /// <summary>
        /// Imports security requirements from uploaded documents into a customer managed security
        /// requirement pack. The import process asynchronously extracts and generates structured
        /// security requirements from the provided source files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota. Review your current usage and request a quota
        /// increase if needed.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ImportSecurityRequirements">REST API Reference for ImportSecurityRequirements Operation</seealso>
        public virtual Task<ImportSecurityRequirementsResponse> ImportSecurityRequirementsAsync(ImportSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSecurityRequirementsResponseUnmarshaller.Instance;

            return InvokeAsync<ImportSecurityRequirementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  InitiateProviderRegistration

        internal virtual InitiateProviderRegistrationResponse InitiateProviderRegistration(InitiateProviderRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateProviderRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateProviderRegistrationResponseUnmarshaller.Instance;

            return Invoke<InitiateProviderRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Initiates the OAuth registration flow with a third-party provider. Returns a redirect
        /// URL and CSRF state token for completing the authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateProviderRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateProviderRegistration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/InitiateProviderRegistration">REST API Reference for InitiateProviderRegistration Operation</seealso>
        public virtual Task<InitiateProviderRegistrationResponse> InitiateProviderRegistrationAsync(InitiateProviderRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitiateProviderRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateProviderRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateProviderRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgentSpaces

        internal virtual ListAgentSpacesResponse ListAgentSpaces(ListAgentSpacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentSpacesResponseUnmarshaller.Instance;

            return Invoke<ListAgentSpacesResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of agent space summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        public virtual Task<ListAgentSpacesResponse> ListAgentSpacesAsync(ListAgentSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgentSpacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentSpacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentSpacesResponse>(request, options, cancellationToken);
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
        /// Returns a paginated list of application summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListArtifacts

        internal virtual ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListArtifactsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of artifact summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public virtual Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return InvokeAsync<ListArtifactsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCodeReviewJobsForCodeReview

        internal virtual ListCodeReviewJobsForCodeReviewResponse ListCodeReviewJobsForCodeReview(ListCodeReviewJobsForCodeReviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeReviewJobsForCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewJobsForCodeReviewResponseUnmarshaller.Instance;

            return Invoke<ListCodeReviewJobsForCodeReviewResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of code review job summaries for the specified code review
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviewJobsForCodeReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeReviewJobsForCodeReview service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListCodeReviewJobsForCodeReview">REST API Reference for ListCodeReviewJobsForCodeReview Operation</seealso>
        public virtual Task<ListCodeReviewJobsForCodeReviewResponse> ListCodeReviewJobsForCodeReviewAsync(ListCodeReviewJobsForCodeReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeReviewJobsForCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewJobsForCodeReviewResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeReviewJobsForCodeReviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCodeReviewJobTasks

        internal virtual ListCodeReviewJobTasksResponse ListCodeReviewJobTasks(ListCodeReviewJobTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeReviewJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewJobTasksResponseUnmarshaller.Instance;

            return Invoke<ListCodeReviewJobTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of task summaries for the specified code review job, optionally
        /// filtered by step name or category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviewJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeReviewJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListCodeReviewJobTasks">REST API Reference for ListCodeReviewJobTasks Operation</seealso>
        public virtual Task<ListCodeReviewJobTasksResponse> ListCodeReviewJobTasksAsync(ListCodeReviewJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeReviewJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewJobTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeReviewJobTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCodeReviews

        internal virtual ListCodeReviewsResponse ListCodeReviews(ListCodeReviewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewsResponseUnmarshaller.Instance;

            return Invoke<ListCodeReviewsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of code review summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeReviews service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        public virtual Task<ListCodeReviewsResponse> ListCodeReviewsAsync(ListCodeReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeReviewsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDiscoveredEndpoints

        internal virtual ListDiscoveredEndpointsResponse ListDiscoveredEndpoints(ListDiscoveredEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveredEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of endpoints discovered during a pentest job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveredEndpoints service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListDiscoveredEndpoints">REST API Reference for ListDiscoveredEndpoints Operation</seealso>
        public virtual Task<ListDiscoveredEndpointsResponse> ListDiscoveredEndpointsAsync(ListDiscoveredEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveredEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoveredEndpointsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFindings

        internal virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return Invoke<ListFindingsResponse>(request, options);
        }



        /// <summary>
        /// Lists the security findings for a pentest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFindingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIntegratedResources

        internal virtual ListIntegratedResourcesResponse ListIntegratedResources(ListIntegratedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegratedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegratedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListIntegratedResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the integrated resources for an agent space, optionally filtered by integration
        /// or resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegratedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegratedResources">REST API Reference for ListIntegratedResources Operation</seealso>
        public virtual Task<ListIntegratedResourcesResponse> ListIntegratedResourcesAsync(ListIntegratedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegratedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegratedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIntegratedResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIntegrations

        internal virtual ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListIntegrationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the integrations in your account, optionally filtered by provider or provider
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        public virtual Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIntegrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMemberships

        internal virtual ListMembershipsResponse ListMemberships(ListMembershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListMembershipsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of membership summaries for the specified agent space within
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual Task<ListMembershipsResponse> ListMembershipsAsync(ListMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMembershipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPentestJobsForPentest

        internal virtual ListPentestJobsForPentestResponse ListPentestJobsForPentest(ListPentestJobsForPentestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPentestJobsForPentestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPentestJobsForPentestResponseUnmarshaller.Instance;

            return Invoke<ListPentestJobsForPentestResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of pentest job summaries for the specified pentest configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobsForPentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentestJobsForPentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobsForPentest">REST API Reference for ListPentestJobsForPentest Operation</seealso>
        public virtual Task<ListPentestJobsForPentestResponse> ListPentestJobsForPentestAsync(ListPentestJobsForPentestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPentestJobsForPentestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPentestJobsForPentestResponseUnmarshaller.Instance;

            return InvokeAsync<ListPentestJobsForPentestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPentestJobTasks

        internal virtual ListPentestJobTasksResponse ListPentestJobTasks(ListPentestJobTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPentestJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPentestJobTasksResponseUnmarshaller.Instance;

            return Invoke<ListPentestJobTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of task summaries for the specified pentest job, optionally
        /// filtered by step name or category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobTasks">REST API Reference for ListPentestJobTasks Operation</seealso>
        public virtual Task<ListPentestJobTasksResponse> ListPentestJobTasksAsync(ListPentestJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPentestJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPentestJobTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListPentestJobTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPentests

        internal virtual ListPentestsResponse ListPentests(ListPentestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPentestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPentestsResponseUnmarshaller.Instance;

            return Invoke<ListPentestsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of pentest summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentests">REST API Reference for ListPentests Operation</seealso>
        public virtual Task<ListPentestsResponse> ListPentestsAsync(ListPentestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPentestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPentestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPentestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPrivateConnections

        internal virtual ListPrivateConnectionsResponse ListPrivateConnections(ListPrivateConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListPrivateConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the private connections in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivateConnections service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPrivateConnections">REST API Reference for ListPrivateConnections Operation</seealso>
        public virtual Task<ListPrivateConnectionsResponse> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPrivateConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPrivateConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPrivateConnectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSecurityRequirementPacks

        internal virtual ListSecurityRequirementPacksResponse ListSecurityRequirementPacks(ListSecurityRequirementPacksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityRequirementPacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityRequirementPacksResponseUnmarshaller.Instance;

            return Invoke<ListSecurityRequirementPacksResponse>(request, options);
        }



        /// <summary>
        /// Lists all security requirement packs in the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityRequirementPacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityRequirementPacks service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListSecurityRequirementPacks">REST API Reference for ListSecurityRequirementPacks Operation</seealso>
        public virtual Task<ListSecurityRequirementPacksResponse> ListSecurityRequirementPacksAsync(ListSecurityRequirementPacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityRequirementPacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityRequirementPacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityRequirementPacksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSecurityRequirements

        internal virtual ListSecurityRequirementsResponse ListSecurityRequirements(ListSecurityRequirementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityRequirementsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityRequirementsResponse>(request, options);
        }



        /// <summary>
        /// Lists security requirements within a pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListSecurityRequirements">REST API Reference for ListSecurityRequirements Operation</seealso>
        public virtual Task<ListSecurityRequirementsResponse> ListSecurityRequirementsAsync(ListSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSecurityRequirementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityRequirementsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityRequirementsResponse>(request, options, cancellationToken);
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
        /// Returns the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTargetDomains

        internal virtual ListTargetDomainsResponse ListTargetDomains(ListTargetDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetDomainsResponseUnmarshaller.Instance;

            return Invoke<ListTargetDomainsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of target domain summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTargetDomains">REST API Reference for ListTargetDomains Operation</seealso>
        public virtual Task<ListTargetDomainsResponse> ListTargetDomainsAsync(ListTargetDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetDomainsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListThreatModelJobs

        internal virtual ListThreatModelJobsResponse ListThreatModelJobs(ListThreatModelJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatModelJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatModelJobsResponseUnmarshaller.Instance;

            return Invoke<ListThreatModelJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of threat model job summaries for the specified threat model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatModelJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreatModelJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreatModelJobs">REST API Reference for ListThreatModelJobs Operation</seealso>
        public virtual Task<ListThreatModelJobsResponse> ListThreatModelJobsAsync(ListThreatModelJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatModelJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatModelJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThreatModelJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListThreatModelJobTasks

        internal virtual ListThreatModelJobTasksResponse ListThreatModelJobTasks(ListThreatModelJobTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatModelJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatModelJobTasksResponseUnmarshaller.Instance;

            return Invoke<ListThreatModelJobTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of task summaries for the specified threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatModelJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreatModelJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreatModelJobTasks">REST API Reference for ListThreatModelJobTasks Operation</seealso>
        public virtual Task<ListThreatModelJobTasksResponse> ListThreatModelJobTasksAsync(ListThreatModelJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatModelJobTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatModelJobTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListThreatModelJobTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListThreatModels

        internal virtual ListThreatModelsResponse ListThreatModels(ListThreatModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatModelsResponseUnmarshaller.Instance;

            return Invoke<ListThreatModelsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of threat model summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreatModels service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreatModels">REST API Reference for ListThreatModels Operation</seealso>
        public virtual Task<ListThreatModelsResponse> ListThreatModelsAsync(ListThreatModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThreatModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListThreats

        internal virtual ListThreatsResponse ListThreats(ListThreatsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatsResponseUnmarshaller.Instance;

            return Invoke<ListThreatsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of threats for a threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreats service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreats">REST API Reference for ListThreats Operation</seealso>
        public virtual Task<ListThreatsResponse> ListThreatsAsync(ListThreatsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThreatsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThreatsResponseUnmarshaller.Instance;

            return InvokeAsync<ListThreatsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartCodeRemediation

        internal virtual StartCodeRemediationResponse StartCodeRemediation(StartCodeRemediationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeRemediationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeRemediationResponseUnmarshaller.Instance;

            return Invoke<StartCodeRemediationResponse>(request, options);
        }



        /// <summary>
        /// Initiates code remediation for one or more security findings. This creates pull requests
        /// in integrated repositories to fix the identified vulnerabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeRemediation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeRemediation service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartCodeRemediation">REST API Reference for StartCodeRemediation Operation</seealso>
        public virtual Task<StartCodeRemediationResponse> StartCodeRemediationAsync(StartCodeRemediationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeRemediationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeRemediationResponseUnmarshaller.Instance;

            return InvokeAsync<StartCodeRemediationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartCodeReviewJob

        internal virtual StartCodeReviewJobResponse StartCodeReviewJob(StartCodeReviewJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeReviewJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeReviewJobResponseUnmarshaller.Instance;

            return Invoke<StartCodeReviewJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a new code review job for a code review configuration. The job executes the
        /// security-focused code analysis defined in the code review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeReviewJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeReviewJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartCodeReviewJob">REST API Reference for StartCodeReviewJob Operation</seealso>
        public virtual Task<StartCodeReviewJobResponse> StartCodeReviewJobAsync(StartCodeReviewJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCodeReviewJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCodeReviewJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartCodeReviewJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartPentestJob

        internal virtual StartPentestJobResponse StartPentestJob(StartPentestJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPentestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPentestJobResponseUnmarshaller.Instance;

            return Invoke<StartPentestJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a new pentest job for a pentest configuration. The job executes the security
        /// tests defined in the pentest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPentestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartPentestJob">REST API Reference for StartPentestJob Operation</seealso>
        public virtual Task<StartPentestJobResponse> StartPentestJobAsync(StartPentestJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPentestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPentestJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartPentestJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartThreatModelJob

        internal virtual StartThreatModelJobResponse StartThreatModelJob(StartThreatModelJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartThreatModelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartThreatModelJobResponseUnmarshaller.Instance;

            return Invoke<StartThreatModelJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a new threat model job for a threat model configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartThreatModelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartThreatModelJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartThreatModelJob">REST API Reference for StartThreatModelJob Operation</seealso>
        public virtual Task<StartThreatModelJobResponse> StartThreatModelJobAsync(StartThreatModelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartThreatModelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartThreatModelJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartThreatModelJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopCodeReviewJob

        internal virtual StopCodeReviewJobResponse StopCodeReviewJob(StopCodeReviewJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCodeReviewJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCodeReviewJobResponseUnmarshaller.Instance;

            return Invoke<StopCodeReviewJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a running code review job. The job transitions to a stopping state and then
        /// to stopped after cleanup completes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCodeReviewJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCodeReviewJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopCodeReviewJob">REST API Reference for StopCodeReviewJob Operation</seealso>
        public virtual Task<StopCodeReviewJobResponse> StopCodeReviewJobAsync(StopCodeReviewJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopCodeReviewJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCodeReviewJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopCodeReviewJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopPentestJob

        internal virtual StopPentestJobResponse StopPentestJob(StopPentestJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopPentestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPentestJobResponseUnmarshaller.Instance;

            return Invoke<StopPentestJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a running pentest job. The job transitions to a stopping state and then to stopped
        /// after cleanup completes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPentestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopPentestJob">REST API Reference for StopPentestJob Operation</seealso>
        public virtual Task<StopPentestJobResponse> StopPentestJobAsync(StopPentestJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopPentestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPentestJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopPentestJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopThreatModelJob

        internal virtual StopThreatModelJobResponse StopThreatModelJob(StopThreatModelJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopThreatModelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopThreatModelJobResponseUnmarshaller.Instance;

            return Invoke<StopThreatModelJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a running threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopThreatModelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopThreatModelJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopThreatModelJob">REST API Reference for StopThreatModelJob Operation</seealso>
        public virtual Task<StopThreatModelJobResponse> StopThreatModelJobAsync(StopThreatModelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopThreatModelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopThreatModelJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopThreatModelJobResponse>(request, options, cancellationToken);
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
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAgentSpace

        internal virtual UpdateAgentSpaceResponse UpdateAgentSpace(UpdateAgentSpaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentSpaceResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentSpaceResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an existing agent space, including its name, description,
        /// AWS resources, target domains, and code review settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        public virtual Task<UpdateAgentSpaceResponse> UpdateAgentSpaceAsync(UpdateAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAgentSpaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentSpaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentSpaceResponse>(request, options, cancellationToken);
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
        /// Updates the configuration of an existing application, including the IAM role and default
        /// KMS key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCodeReview

        internal virtual UpdateCodeReviewResponse UpdateCodeReview(UpdateCodeReviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeReviewResponseUnmarshaller.Instance;

            return Invoke<UpdateCodeReviewResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing code review configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeReview service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateCodeReview">REST API Reference for UpdateCodeReview Operation</seealso>
        public virtual Task<UpdateCodeReviewResponse> UpdateCodeReviewAsync(UpdateCodeReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeReviewResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCodeReviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFinding

        internal virtual UpdateFindingResponse UpdateFinding(UpdateFindingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingResponseUnmarshaller.Instance;

            return Invoke<UpdateFindingResponse>(request, options);
        }



        /// <summary>
        /// Updates the status or risk level of a security finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFinding service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateFinding">REST API Reference for UpdateFinding Operation</seealso>
        public virtual Task<UpdateFindingResponse> UpdateFindingAsync(UpdateFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFindingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFindingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFindingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateIntegratedResources

        internal virtual UpdateIntegratedResourcesResponse UpdateIntegratedResources(UpdateIntegratedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegratedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegratedResourcesResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegratedResourcesResponse>(request, options);
        }



        /// <summary>
        /// Updates the integrated resources for an agent space, including their capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegratedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateIntegratedResources">REST API Reference for UpdateIntegratedResources Operation</seealso>
        public virtual Task<UpdateIntegratedResourcesResponse> UpdateIntegratedResourcesAsync(UpdateIntegratedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegratedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegratedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegratedResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePentest

        internal virtual UpdatePentestResponse UpdatePentest(UpdatePentestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePentestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePentestResponseUnmarshaller.Instance;

            return Invoke<UpdatePentestResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing pentest configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdatePentest">REST API Reference for UpdatePentest Operation</seealso>
        public virtual Task<UpdatePentestResponse> UpdatePentestAsync(UpdatePentestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePentestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePentestResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePentestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePrivateConnectionCertificate

        internal virtual UpdatePrivateConnectionCertificateResponse UpdatePrivateConnectionCertificate(UpdatePrivateConnectionCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePrivateConnectionCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivateConnectionCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdatePrivateConnectionCertificateResponse>(request, options);
        }



        /// <summary>
        /// Updates the certificate associated with a private connection. Certificates can be
        /// added or replaced but not removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateConnectionCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrivateConnectionCertificate service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdatePrivateConnectionCertificate">REST API Reference for UpdatePrivateConnectionCertificate Operation</seealso>
        public virtual Task<UpdatePrivateConnectionCertificateResponse> UpdatePrivateConnectionCertificateAsync(UpdatePrivateConnectionCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePrivateConnectionCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrivateConnectionCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePrivateConnectionCertificateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSecurityRequirementPack

        internal virtual UpdateSecurityRequirementPackResponse UpdateSecurityRequirementPack(UpdateSecurityRequirementPackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityRequirementPackResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityRequirementPackResponse>(request, options);
        }



        /// <summary>
        /// Updates a security requirement pack. For customer managed packs, both metadata and
        /// status can be updated. For AWS managed packs, only status can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateSecurityRequirementPack">REST API Reference for UpdateSecurityRequirementPack Operation</seealso>
        public virtual Task<UpdateSecurityRequirementPackResponse> UpdateSecurityRequirementPackAsync(UpdateSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSecurityRequirementPackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityRequirementPackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityRequirementPackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTargetDomain

        internal virtual UpdateTargetDomainResponse UpdateTargetDomain(UpdateTargetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTargetDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateTargetDomainResponse>(request, options);
        }



        /// <summary>
        /// Updates the verification method for a target domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateTargetDomain">REST API Reference for UpdateTargetDomain Operation</seealso>
        public virtual Task<UpdateTargetDomainResponse> UpdateTargetDomainAsync(UpdateTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTargetDomainResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTargetDomainResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateThreat

        internal virtual UpdateThreatResponse UpdateThreat(UpdateThreatRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThreatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThreatResponseUnmarshaller.Instance;

            return Invoke<UpdateThreatResponse>(request, options);
        }



        /// <summary>
        /// Updates a threat.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThreat service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateThreat">REST API Reference for UpdateThreat Operation</seealso>
        public virtual Task<UpdateThreatResponse> UpdateThreatAsync(UpdateThreatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThreatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThreatResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThreatResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateThreatModel

        internal virtual UpdateThreatModelResponse UpdateThreatModel(UpdateThreatModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThreatModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThreatModelResponseUnmarshaller.Instance;

            return Invoke<UpdateThreatModelResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing threat model configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThreatModel service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateThreatModel">REST API Reference for UpdateThreatModel Operation</seealso>
        public virtual Task<UpdateThreatModelResponse> UpdateThreatModelAsync(UpdateThreatModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateThreatModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateThreatModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateThreatModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  VerifyTargetDomain

        internal virtual VerifyTargetDomainResponse VerifyTargetDomain(VerifyTargetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTargetDomainResponseUnmarshaller.Instance;

            return Invoke<VerifyTargetDomainResponse>(request, options);
        }



        /// <summary>
        /// Initiates verification of a target domain. This checks whether the domain ownership
        /// verification token has been properly configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/VerifyTargetDomain">REST API Reference for VerifyTargetDomain Operation</seealso>
        public virtual Task<VerifyTargetDomainResponse> VerifyTargetDomainAsync(VerifyTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyTargetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTargetDomainResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyTargetDomainResponse>(request, options, cancellationToken);
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