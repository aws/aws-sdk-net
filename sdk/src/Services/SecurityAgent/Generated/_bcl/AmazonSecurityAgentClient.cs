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

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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


        /// <summary>
        /// Uploads an artifact to an agent space. Artifacts provide additional context for security
        /// testing, such as architecture diagrams, API specifications, or configuration files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddArtifact service method.</param>
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
        public virtual AddArtifactResponse AddArtifact(AddArtifactRequest request)
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
        
        #region  BatchDeletePentests


        /// <summary>
        /// Deletes one or more pentests from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePentests service method.</param>
        /// 
        /// <returns>The response from the BatchDeletePentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeletePentests">REST API Reference for BatchDeletePentests Operation</seealso>
        public virtual BatchDeletePentestsResponse BatchDeletePentests(BatchDeletePentestsRequest request)
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
        
        #region  BatchGetAgentSpaces


        /// <summary>
        /// Retrieves information about one or more agent spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAgentSpaces service method.</param>
        /// 
        /// <returns>The response from the BatchGetAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetAgentSpaces">REST API Reference for BatchGetAgentSpaces Operation</seealso>
        public virtual BatchGetAgentSpacesResponse BatchGetAgentSpaces(BatchGetAgentSpacesRequest request)
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


        /// <summary>
        /// Retrieves metadata for one or more artifacts in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetArtifactMetadata service method.</param>
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
        public virtual BatchGetArtifactMetadataResponse BatchGetArtifactMetadata(BatchGetArtifactMetadataRequest request)
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
        
        #region  BatchGetFindings


        /// <summary>
        /// Retrieves information about one or more security findings in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings service method.</param>
        /// 
        /// <returns>The response from the BatchGetFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        public virtual BatchGetFindingsResponse BatchGetFindings(BatchGetFindingsRequest request)
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


        /// <summary>
        /// Retrieves information about one or more pentest jobs in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobs service method.</param>
        /// 
        /// <returns>The response from the BatchGetPentestJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobs">REST API Reference for BatchGetPentestJobs Operation</seealso>
        public virtual BatchGetPentestJobsResponse BatchGetPentestJobs(BatchGetPentestJobsRequest request)
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


        /// <summary>
        /// Retrieves information about one or more tasks within a pentest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobTasks service method.</param>
        /// 
        /// <returns>The response from the BatchGetPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobTasks">REST API Reference for BatchGetPentestJobTasks Operation</seealso>
        public virtual BatchGetPentestJobTasksResponse BatchGetPentestJobTasks(BatchGetPentestJobTasksRequest request)
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


        /// <summary>
        /// Retrieves information about one or more pentests in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentests service method.</param>
        /// 
        /// <returns>The response from the BatchGetPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentests">REST API Reference for BatchGetPentests Operation</seealso>
        public virtual BatchGetPentestsResponse BatchGetPentests(BatchGetPentestsRequest request)
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
        
        #region  BatchGetTargetDomains


        /// <summary>
        /// Retrieves information about one or more target domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTargetDomains service method.</param>
        /// 
        /// <returns>The response from the BatchGetTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetTargetDomains">REST API Reference for BatchGetTargetDomains Operation</seealso>
        public virtual BatchGetTargetDomainsResponse BatchGetTargetDomains(BatchGetTargetDomainsRequest request)
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
        
        #region  CreateAgentSpace


        /// <summary>
        /// Creates a new agent space. An agent space is a dedicated workspace for securing a
        /// specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        public virtual CreateAgentSpaceResponse CreateAgentSpace(CreateAgentSpaceRequest request)
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


        /// <summary>
        /// Creates a new application. An application is the top-level organizational unit that
        /// supports IAM Identity Center integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
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
        
        #region  CreateIntegration


        /// <summary>
        /// Creates a new integration with a third-party provider, such as GitHub, for code review
        /// and remediation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
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
        public virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
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


        /// <summary>
        /// Creates a new membership, granting a user access to an agent space within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        public virtual CreateMembershipResponse CreateMembership(CreateMembershipRequest request)
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


        /// <summary>
        /// Creates a new pentest configuration in an agent space. A pentest defines the security
        /// test parameters, including target assets, risk type exclusions, and logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePentest service method.</param>
        /// 
        /// <returns>The response from the CreatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreatePentest">REST API Reference for CreatePentest Operation</seealso>
        public virtual CreatePentestResponse CreatePentest(CreatePentestRequest request)
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
        
        #region  CreateTargetDomain


        /// <summary>
        /// Creates a new target domain for penetration testing. A target domain is a web domain
        /// that must be registered and verified before it can be tested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetDomain service method.</param>
        /// 
        /// <returns>The response from the CreateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateTargetDomain">REST API Reference for CreateTargetDomain Operation</seealso>
        public virtual CreateTargetDomainResponse CreateTargetDomain(CreateTargetDomainRequest request)
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
        
        #region  DeleteAgentSpace


        /// <summary>
        /// Deletes an agent space and all of its associated resources, including pentests, findings,
        /// and artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        public virtual DeleteAgentSpaceResponse DeleteAgentSpace(DeleteAgentSpaceRequest request)
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


        /// <summary>
        /// Deletes an application and its associated configuration, including IAM Identity Center
        /// settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
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


        /// <summary>
        /// Deletes an artifact from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
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
        public virtual DeleteArtifactResponse DeleteArtifact(DeleteArtifactRequest request)
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


        /// <summary>
        /// Deletes an integration with a third-party provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
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
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
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


        /// <summary>
        /// Deletes a membership, revoking a user's access to an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        public virtual DeleteMembershipResponse DeleteMembership(DeleteMembershipRequest request)
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
        
        #region  DeleteTargetDomain


        /// <summary>
        /// Deletes a target domain registration. After deletion, the domain can no longer be
        /// used for penetration testing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteTargetDomain">REST API Reference for DeleteTargetDomain Operation</seealso>
        public virtual DeleteTargetDomainResponse DeleteTargetDomain(DeleteTargetDomainRequest request)
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
        
        #region  GetApplication


        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
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


        /// <summary>
        /// Retrieves an artifact from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifact service method.</param>
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
        public virtual GetArtifactResponse GetArtifact(GetArtifactRequest request)
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


        /// <summary>
        /// Retrieves information about an integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
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
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
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
        
        #region  InitiateProviderRegistration


        /// <summary>
        /// Initiates the OAuth registration flow with a third-party provider. Returns a redirect
        /// URL and CSRF state token for completing the authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateProviderRegistration service method.</param>
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
        public virtual InitiateProviderRegistrationResponse InitiateProviderRegistration(InitiateProviderRegistrationRequest request)
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


        /// <summary>
        /// Returns a paginated list of agent space summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        public virtual ListAgentSpacesResponse ListAgentSpaces(ListAgentSpacesRequest request)
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


        /// <summary>
        /// Returns a paginated list of application summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
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


        /// <summary>
        /// Returns a paginated list of artifact summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
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
        public virtual ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
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
        
        #region  ListDiscoveredEndpoints


        /// <summary>
        /// Returns a paginated list of endpoints discovered during a pentest job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredEndpoints service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListDiscoveredEndpoints">REST API Reference for ListDiscoveredEndpoints Operation</seealso>
        public virtual ListDiscoveredEndpointsResponse ListDiscoveredEndpoints(ListDiscoveredEndpointsRequest request)
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


        /// <summary>
        /// Lists the security findings for a pentest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListFindings">REST API Reference for ListFindings Operation</seealso>
        public virtual ListFindingsResponse ListFindings(ListFindingsRequest request)
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


        /// <summary>
        /// Lists the integrated resources for an agent space, optionally filtered by integration
        /// or resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegratedResources service method.</param>
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
        public virtual ListIntegratedResourcesResponse ListIntegratedResources(ListIntegratedResourcesRequest request)
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


        /// <summary>
        /// Lists the integrations in your account, optionally filtered by provider or provider
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
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
        public virtual ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request)
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


        /// <summary>
        /// Returns a paginated list of membership summaries for the specified agent space within
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        public virtual ListMembershipsResponse ListMemberships(ListMembershipsRequest request)
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


        /// <summary>
        /// Returns a paginated list of pentest job summaries for the specified pentest configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobsForPentest service method.</param>
        /// 
        /// <returns>The response from the ListPentestJobsForPentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobsForPentest">REST API Reference for ListPentestJobsForPentest Operation</seealso>
        public virtual ListPentestJobsForPentestResponse ListPentestJobsForPentest(ListPentestJobsForPentestRequest request)
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


        /// <summary>
        /// Returns a paginated list of task summaries for the specified pentest job, optionally
        /// filtered by step name or category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobTasks service method.</param>
        /// 
        /// <returns>The response from the ListPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobTasks">REST API Reference for ListPentestJobTasks Operation</seealso>
        public virtual ListPentestJobTasksResponse ListPentestJobTasks(ListPentestJobTasksRequest request)
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


        /// <summary>
        /// Returns a paginated list of pentest summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentests service method.</param>
        /// 
        /// <returns>The response from the ListPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentests">REST API Reference for ListPentests Operation</seealso>
        public virtual ListPentestsResponse ListPentests(ListPentestsRequest request)
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
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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


        /// <summary>
        /// Returns a paginated list of target domain summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetDomains service method.</param>
        /// 
        /// <returns>The response from the ListTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTargetDomains">REST API Reference for ListTargetDomains Operation</seealso>
        public virtual ListTargetDomainsResponse ListTargetDomains(ListTargetDomainsRequest request)
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
        
        #region  StartCodeRemediation


        /// <summary>
        /// Initiates code remediation for one or more security findings. This creates pull requests
        /// in integrated repositories to fix the identified vulnerabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeRemediation service method.</param>
        /// 
        /// <returns>The response from the StartCodeRemediation service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartCodeRemediation">REST API Reference for StartCodeRemediation Operation</seealso>
        public virtual StartCodeRemediationResponse StartCodeRemediation(StartCodeRemediationRequest request)
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
        
        #region  StartPentestJob


        /// <summary>
        /// Starts a new pentest job for a pentest configuration. The job executes the security
        /// tests defined in the pentest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPentestJob service method.</param>
        /// 
        /// <returns>The response from the StartPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartPentestJob">REST API Reference for StartPentestJob Operation</seealso>
        public virtual StartPentestJobResponse StartPentestJob(StartPentestJobRequest request)
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
        
        #region  StopPentestJob


        /// <summary>
        /// Stops a running pentest job. The job transitions to a stopping state and then to stopped
        /// after cleanup completes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPentestJob service method.</param>
        /// 
        /// <returns>The response from the StopPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopPentestJob">REST API Reference for StopPentestJob Operation</seealso>
        public virtual StopPentestJobResponse StopPentestJob(StopPentestJobRequest request)
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
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
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


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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


        /// <summary>
        /// Updates the configuration of an existing agent space, including its name, description,
        /// AWS resources, target domains, and code review settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        public virtual UpdateAgentSpaceResponse UpdateAgentSpace(UpdateAgentSpaceRequest request)
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


        /// <summary>
        /// Updates the configuration of an existing application, including the IAM role and default
        /// KMS key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
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
        
        #region  UpdateFinding


        /// <summary>
        /// Updates the status or risk level of a security finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFinding service method.</param>
        /// 
        /// <returns>The response from the UpdateFinding service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateFinding">REST API Reference for UpdateFinding Operation</seealso>
        public virtual UpdateFindingResponse UpdateFinding(UpdateFindingRequest request)
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


        /// <summary>
        /// Updates the integrated resources for an agent space, including their capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegratedResources service method.</param>
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
        public virtual UpdateIntegratedResourcesResponse UpdateIntegratedResources(UpdateIntegratedResourcesRequest request)
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


        /// <summary>
        /// Updates an existing pentest configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePentest service method.</param>
        /// 
        /// <returns>The response from the UpdatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdatePentest">REST API Reference for UpdatePentest Operation</seealso>
        public virtual UpdatePentestResponse UpdatePentest(UpdatePentestRequest request)
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
        
        #region  UpdateTargetDomain


        /// <summary>
        /// Updates the verification method for a target domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateTargetDomain">REST API Reference for UpdateTargetDomain Operation</seealso>
        public virtual UpdateTargetDomainResponse UpdateTargetDomain(UpdateTargetDomainRequest request)
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
        
        #region  VerifyTargetDomain


        /// <summary>
        /// Initiates verification of a target domain. This checks whether the domain ownership
        /// verification token has been properly configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyTargetDomain service method.</param>
        /// 
        /// <returns>The response from the VerifyTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/VerifyTargetDomain">REST API Reference for VerifyTargetDomain Operation</seealso>
        public virtual VerifyTargetDomainResponse VerifyTargetDomain(VerifyTargetDomainRequest request)
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