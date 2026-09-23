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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NetworkSecurityManager.Model;
using Amazon.NetworkSecurityManager.Model.Internal.MarshallTransformations;
using Amazon.NetworkSecurityManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.NetworkSecurityManager
{
    /// <summary>
    /// <para>Implementation for accessing NetworkSecurityManager</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Network Security Manager helps you centrally configure and deploy network security
    /// protections across your organization. Supported protections include AWS WAF and AWS
    /// Shield Advanced. This centralized approach reduces the overhead of managing protections
    /// individually across accounts and ensures consistent security at scale.
    /// 
    ///  
    /// <para>
    /// You define reusable <i>rules</i> and <i>templates</i>, then combine them into <i>policies</i>.
    /// Next, you select the accounts and resources to protect with <i>scopes</i> and roll
    /// the protections out with <i>deployments</i>. For example, you can define a set of
    /// AWS WAF rules and group them into a policy. Then deploy that policy across all accounts
    /// in your organization with a single deployment.
    /// </para>
    ///  
    /// <para>
    /// This API reference describes the operations and data types for AWS Network Security
    /// Manager.
    /// </para>
    ///  
    /// <para>
    /// For conceptual information, tutorials, and guidance on writing rule configurations,
    /// see the <a href="https://docs.aws.amazon.com/network-security-manager/latest/devguide/what-is.html">AWS
    /// Network Security Manager Developer Guide</a>. For the default quotas that apply to
    /// your account, see <a href="https://docs.aws.amazon.com/network-security-manager/latest/devguide/quotas.html">Quotas</a>.
    /// For the service endpoints available in each Region, see <a href="https://docs.aws.amazon.com/general/latest/gr/network-security-manager.html">AWS
    /// Network Security Manager endpoints and quotas</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial class AmazonNetworkSecurityManagerClient : AmazonServiceClient, IAmazonNetworkSecurityManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonNetworkSecurityManagerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with the credentials loaded from the application's
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
        public AmazonNetworkSecurityManagerClient()
            : base(new AmazonNetworkSecurityManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with the credentials loaded from the application's
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
        public AmazonNetworkSecurityManagerClient(RegionEndpoint region)
            : base(new AmazonNetworkSecurityManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNetworkSecurityManagerClient Configuration Object</param>
        public AmazonNetworkSecurityManagerClient(AmazonNetworkSecurityManagerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNetworkSecurityManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonNetworkSecurityManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkSecurityManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNetworkSecurityManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Credentials and an
        /// AmazonNetworkSecurityManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNetworkSecurityManagerClient Configuration Object</param>
        public AmazonNetworkSecurityManagerClient(AWSCredentials credentials, AmazonNetworkSecurityManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNetworkSecurityManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkSecurityManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkSecurityManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkSecurityManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkSecurityManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNetworkSecurityManagerClient Configuration Object</param>
        public AmazonNetworkSecurityManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNetworkSecurityManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNetworkSecurityManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkSecurityManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkSecurityManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkSecurityManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkSecurityManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkSecurityManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNetworkSecurityManagerClient Configuration Object</param>
        public AmazonNetworkSecurityManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNetworkSecurityManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private INetworkSecurityManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INetworkSecurityManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NetworkSecurityManagerPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkSecurityManagerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkSecurityManagerAuthSchemeHandler());
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


        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Creates a deployment. A deployment applies one or more policies to the accounts and
        /// resources selected by a scope. Use <c>isPublished</c> to create the deployment in
        /// published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state. The response includes coverage
        /// information and any warnings about the deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDeploymentSnapshot

        internal virtual CreateDeploymentSnapshotResponse CreateDeploymentSnapshot(CreateDeploymentSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the current published version of the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateDeploymentSnapshot">REST API Reference for CreateDeploymentSnapshot Operation</seealso>
        public virtual Task<CreateDeploymentSnapshotResponse> CreateDeploymentSnapshotAsync(CreateDeploymentSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePolicy

        internal virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a policy. A policy combines templates and rules with enforcement settings
        /// for a firewall type, such as AWS WAF or AWS Shield Advanced. Use <c>isPublished</c>
        /// to create the policy in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePolicySnapshot

        internal virtual CreatePolicySnapshotResponse CreatePolicySnapshot(CreatePolicySnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePolicySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicySnapshotResponseUnmarshaller.Instance;

            return Invoke<CreatePolicySnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the current published version of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicySnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicySnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreatePolicySnapshot">REST API Reference for CreatePolicySnapshot Operation</seealso>
        public virtual Task<CreatePolicySnapshotResponse> CreatePolicySnapshotAsync(CreatePolicySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePolicySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicySnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRule

        internal virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a rule. A rule defines a network security configuration to enforce, such as
        /// an AWS WAF rule group or configuration data. Use <c>isPublished</c> to create the
        /// rule in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRuleSnapshot

        internal virtual CreateRuleSnapshotResponse CreateRuleSnapshot(CreateRuleSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateRuleSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the current published version of the specified rule. A snapshot
        /// is an immutable, versioned copy that other resources can reference.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateRuleSnapshot">REST API Reference for CreateRuleSnapshot Operation</seealso>
        public virtual Task<CreateRuleSnapshotResponse> CreateRuleSnapshotAsync(CreateRuleSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateScope

        internal virtual CreateScopeResponse CreateScope(CreateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeResponseUnmarshaller.Instance;

            return Invoke<CreateScopeResponse>(request, options);
        }



        /// <summary>
        /// Creates a scope. A scope selects the accounts and resources that a deployment applies
        /// to. Use <c>isPublished</c> to create the scope in published (<c>ACTIVE</c>) or draft
        /// (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateScope">REST API Reference for CreateScope Operation</seealso>
        public virtual Task<CreateScopeResponse> CreateScopeAsync(CreateScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScopeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateScopeSnapshot

        internal virtual CreateScopeSnapshotResponse CreateScopeSnapshot(CreateScopeSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateScopeSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the current published version of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScopeSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScopeSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateScopeSnapshot">REST API Reference for CreateScopeSnapshot Operation</seealso>
        public virtual Task<CreateScopeSnapshotResponse> CreateScopeSnapshotAsync(CreateScopeSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScopeSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScopeSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScopeSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTemplate

        internal virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a template. A template groups one or more rules to simplify reuse across policies.
        /// You can also associate rules with a policy directly, without a template. Use <c>isPublished</c>
        /// to create the template in published (<c>ACTIVE</c>) or draft (<c>DRAFT</c>) state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTemplateSnapshot

        internal virtual CreateTemplateSnapshotResponse CreateTemplateSnapshot(CreateTemplateSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the current published version of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplateSnapshot service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/CreateTemplateSnapshot">REST API Reference for CreateTemplateSnapshot Operation</seealso>
        public virtual Task<CreateTemplateSnapshotResponse> CreateTemplateSnapshotAsync(CreateTemplateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTemplateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateSnapshotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAdminAccount

        internal virtual DeleteAdminAccountResponse DeleteAdminAccount(DeleteAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DeleteAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified AWS Network Security Manager administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteAdminAccount">REST API Reference for DeleteAdminAccount Operation</seealso>
        public virtual Task<DeleteAdminAccountResponse> DeleteAdminAccountAsync(DeleteAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAdminAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDeployment

        internal virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePolicy

        internal virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRule

        internal virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteScope

        internal virtual DeleteScopeResponse DeleteScope(DeleteScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScopeResponseUnmarshaller.Instance;

            return Invoke<DeleteScopeResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteScope">REST API Reference for DeleteScope Operation</seealso>
        public virtual Task<DeleteScopeResponse> DeleteScopeAsync(DeleteScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScopeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScopeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTemplate

        internal virtual DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        public virtual Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateRuleConfiguration

        internal virtual GenerateRuleConfigurationResponse GenerateRuleConfiguration(GenerateRuleConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateRuleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRuleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GenerateRuleConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Generates a rule configuration from a natural-language description. Provide a prompt
        /// along with the rule's firewall type and rule type. The service returns a configuration
        /// that you can use when you create or update a rule. If you also provide an existing
        /// configuration, the service edits that configuration instead of generating a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRuleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRuleConfiguration service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GenerateRuleConfiguration">REST API Reference for GenerateRuleConfiguration Operation</seealso>
        public virtual Task<GenerateRuleConfigurationResponse> GenerateRuleConfigurationAsync(GenerateRuleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateRuleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRuleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateRuleConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAdminAccount

        internal virtual GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of the specified AWS Network Security Manager administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual Task<GetAdminAccountResponse> GetAdminAccountAsync(GetAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdminAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDeployment

        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of the specified deployment, including coverage information
        /// and any warnings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPolicy

        internal virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRule

        internal virtual GetRuleResponse GetRule(GetRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return Invoke<GetRuleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetScope

        internal virtual GetScopeResponse GetScope(GetScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScopeResponseUnmarshaller.Instance;

            return Invoke<GetScopeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetScope">REST API Reference for GetScope Operation</seealso>
        public virtual Task<GetScopeResponse> GetScopeAsync(GetScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScopeResponseUnmarshaller.Instance;

            return InvokeAsync<GetScopeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTemplate

        internal virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAdminAccounts

        internal virtual ListAdminAccountsResponse ListAdminAccounts(ListAdminAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdminAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAdminAccountsResponse>(request, options);
        }



        /// <summary>
        /// Lists the AWS Network Security Manager administrator accounts in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAdminAccounts service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListAdminAccounts">REST API Reference for ListAdminAccounts Operation</seealso>
        public virtual Task<ListAdminAccountsResponse> ListAdminAccountsAsync(ListAdminAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdminAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdminAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAdminAccountsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAggregateResourceSynchronizationStatuses

        internal virtual ListAggregateResourceSynchronizationStatusesResponse ListAggregateResourceSynchronizationStatuses(ListAggregateResourceSynchronizationStatusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAggregateResourceSynchronizationStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregateResourceSynchronizationStatusesResponseUnmarshaller.Instance;

            return Invoke<ListAggregateResourceSynchronizationStatusesResponse>(request, options);
        }



        /// <summary>
        /// Lists the aggregated synchronization statuses of resources across the deployments
        /// in your administrator account. You can filter the results by synchronization status
        /// and page through them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateResourceSynchronizationStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAggregateResourceSynchronizationStatuses service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListAggregateResourceSynchronizationStatuses">REST API Reference for ListAggregateResourceSynchronizationStatuses Operation</seealso>
        public virtual Task<ListAggregateResourceSynchronizationStatusesResponse> ListAggregateResourceSynchronizationStatusesAsync(ListAggregateResourceSynchronizationStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAggregateResourceSynchronizationStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregateResourceSynchronizationStatusesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAggregateResourceSynchronizationStatusesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeployments

        internal virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the deployments in the account. You can filter the results by status and page
        /// through them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeploymentSnapshots

        internal virtual ListDeploymentSnapshotsResponse ListDeploymentSnapshots(ListDeploymentSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Lists the snapshots of the specified deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListDeploymentSnapshots">REST API Reference for ListDeploymentSnapshots Operation</seealso>
        public virtual Task<ListDeploymentSnapshotsResponse> ListDeploymentSnapshotsAsync(ListDeploymentSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPolicies

        internal virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Lists the policies in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPolicySnapshots

        internal virtual ListPolicySnapshotsResponse ListPolicySnapshots(ListPolicySnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicySnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicySnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListPolicySnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Lists the snapshots of the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicySnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicySnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListPolicySnapshots">REST API Reference for ListPolicySnapshots Operation</seealso>
        public virtual Task<ListPolicySnapshotsResponse> ListPolicySnapshotsAsync(ListPolicySnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicySnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicySnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicySnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceAssociations

        internal virtual ListResourceAssociationsResponse ListResourceAssociations(ListResourceAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListResourceAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the resources associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceAssociations service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListResourceAssociations">REST API Reference for ListResourceAssociations Operation</seealso>
        public virtual Task<ListResourceAssociationsResponse> ListResourceAssociationsAsync(ListResourceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourceSynchronizationStatuses

        internal virtual ListResourceSynchronizationStatusesResponse ListResourceSynchronizationStatuses(ListResourceSynchronizationStatusesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSynchronizationStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSynchronizationStatusesResponseUnmarshaller.Instance;

            return Invoke<ListResourceSynchronizationStatusesResponse>(request, options);
        }



        /// <summary>
        /// Lists the synchronization statuses of the resources covered by the specified deployment.
        /// You can filter the results by synchronization status and page through them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSynchronizationStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSynchronizationStatuses service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListResourceSynchronizationStatuses">REST API Reference for ListResourceSynchronizationStatuses Operation</seealso>
        public virtual Task<ListResourceSynchronizationStatusesResponse> ListResourceSynchronizationStatusesAsync(ListResourceSynchronizationStatusesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSynchronizationStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSynchronizationStatusesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceSynchronizationStatusesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRules

        internal virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }



        /// <summary>
        /// Lists the rules in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRulesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRuleSnapshots

        internal virtual ListRuleSnapshotsResponse ListRuleSnapshots(ListRuleSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListRuleSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Lists the snapshots of the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListRuleSnapshots">REST API Reference for ListRuleSnapshots Operation</seealso>
        public virtual Task<ListRuleSnapshotsResponse> ListRuleSnapshotsAsync(ListRuleSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListScopes

        internal virtual ListScopesResponse ListScopes(ListScopesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopesResponseUnmarshaller.Instance;

            return Invoke<ListScopesResponse>(request, options);
        }



        /// <summary>
        /// Lists the scopes in the account. You can filter the results by status and page through
        /// them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScopes service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListScopes">REST API Reference for ListScopes Operation</seealso>
        public virtual Task<ListScopesResponse> ListScopesAsync(ListScopesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopesResponseUnmarshaller.Instance;

            return InvokeAsync<ListScopesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListScopeSnapshots

        internal virtual ListScopeSnapshotsResponse ListScopeSnapshots(ListScopeSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListScopeSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Lists the snapshots of the specified scope.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScopeSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScopeSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListScopeSnapshots">REST API Reference for ListScopeSnapshots Operation</seealso>
        public virtual Task<ListScopeSnapshotsResponse> ListScopeSnapshotsAsync(ListScopeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScopeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScopeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScopeSnapshotsResponse>(request, options, cancellationToken);
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
        /// Lists the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplates

        internal virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the templates in the account. You can filter the results by status and page
        /// through them using <c>maxResults</c> and <c>nextToken</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTemplateSnapshots

        internal virtual ListTemplateSnapshotsResponse ListTemplateSnapshots(ListTemplateSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Lists the snapshots of the specified template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateSnapshots service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/ListTemplateSnapshots">REST API Reference for ListTemplateSnapshots Operation</seealso>
        public virtual Task<ListTemplateSnapshotsResponse> ListTemplateSnapshotsAsync(ListTemplateSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTemplateSnapshotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAdminAccount

        internal virtual PutAdminAccountResponse PutAdminAccount(PutAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAdminAccountResponseUnmarshaller.Instance;

            return Invoke<PutAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Sets the AWS account that serves as an AWS Network Security Manager administrator
        /// account, and optionally configures the scope of resources that the administrator can
        /// manage.
        /// 
        ///  
        /// <para>
        /// You can't set an administrator account again immediately after you remove it, or while
        /// the service creates its service-linked role. Retry the request after a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAdminAccount service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable. This is a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        public virtual Task<PutAdminAccountResponse> PutAdminAccountAsync(PutAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<PutAdminAccountResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites the specified tags on the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the specified tags from the given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.TagPolicyViolationException">
        /// The request violates a tag policy that is in effect for the account or organization.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDeployment

        internal virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified deployment. To prevent conflicting concurrent updates, provide
        /// the current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep
        /// the deployment as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePolicy

        internal virtual UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified policy. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// policy as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public virtual Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRule

        internal virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified rule. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// rule as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateScope

        internal virtual UpdateScopeResponse UpdateScope(UpdateScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScopeResponseUnmarshaller.Instance;

            return Invoke<UpdateScopeResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified scope. To prevent conflicting concurrent updates, provide the
        /// current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep the
        /// scope as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScope service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateScope">REST API Reference for UpdateScope Operation</seealso>
        public virtual Task<UpdateScopeResponse> UpdateScopeAsync(UpdateScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScopeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScopeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTemplate

        internal virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified template. To prevent conflicting concurrent updates, provide
        /// the current <c>updateToken</c>. Use <c>isPublished</c> to publish the update or keep
        /// the template as a draft.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by NetworkSecurityManager.</returns>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// was modified concurrently, or it is in a state that does not allow the requested operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.InternalServerException">
        /// The request processing failed because of an internal error in the service. This is
        /// a retryable error.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists, then try your request again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ThrottlingException">
        /// The request was denied because of request throttling. Reduce your request rate and
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.NetworkSecurityManager.Model.ValidationException">
        /// The request failed validation. For details, see the <c>reason</c> and <c>fieldList</c>
        /// members of the response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-security-manager-2025-10-30/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplateResponse>(request, options, cancellationToken);
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