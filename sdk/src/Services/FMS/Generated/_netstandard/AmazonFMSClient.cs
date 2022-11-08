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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.FMS.Model;
using Amazon.FMS.Model.Internal.MarshallTransformations;
using Amazon.FMS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.FMS
{
    /// <summary>
    /// Implementation for accessing FMS
    ///
    /// This is the <i>Firewall Manager API Reference</i>. This guide is for developers who
    /// need detailed information about the Firewall Manager API actions, data types, and
    /// errors. For detailed information about Firewall Manager features, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-chapter.html">Firewall
    /// Manager Developer Guide</a>.
    /// 
    ///  
    /// <para>
    /// Some API actions require explicit resource permissions. For information, see the developer
    /// guide topic <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-api-permissions-ref.html">Firewall
    /// Manager required permissions for API actions</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonFMSClient : AmazonServiceClient, IAmazonFMS
    {
        private static IServiceMetadata serviceMetadata = new AmazonFMSMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonFMSClient with the credentials loaded from the application's
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
        public AmazonFMSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFMSConfig()) { }

        /// <summary>
        /// Constructs AmazonFMSClient with the credentials loaded from the application's
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
        public AmazonFMSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFMSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFMSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(AmazonFMSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonFMSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFMSClient(AWSCredentials credentials)
            : this(credentials, new AmazonFMSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFMSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFMSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Credentials and an
        /// AmazonFMSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(AWSCredentials credentials, AmazonFMSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFMSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFMSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFMSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFMSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFMSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFMSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFMSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFMSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFMSClient Configuration Object</param>
        public AmazonFMSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFMSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IFMSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFMSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FMSPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFMSEndpointResolver());
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


        #region  AssociateAdminAccount

        internal virtual AssociateAdminAccountResponse AssociateAdminAccount(AssociateAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Sets the Firewall Manager administrator account. The account must be a member of the
        /// organization in Organizations whose resources you want to protect. Firewall Manager
        /// sets the permissions that allow the account to administer your Firewall Manager policies.
        /// 
        ///  
        /// <para>
        /// The account that you associate with Firewall Manager is called the Firewall Manager
        /// administrator account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        public virtual Task<AssociateAdminAccountResponse> AssociateAdminAccountAsync(AssociateAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateThirdPartyFirewall

        internal virtual AssociateThirdPartyFirewallResponse AssociateThirdPartyFirewall(AssociateThirdPartyFirewallRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return Invoke<AssociateThirdPartyFirewallResponse>(request, options);
        }



        /// <summary>
        /// Sets the Firewall Manager policy administrator as a tenant administrator of a third-party
        /// firewall service. A tenant is an instance of the third-party firewall service that's
        /// associated with your Amazon Web Services customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateThirdPartyFirewall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateThirdPartyFirewall service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateThirdPartyFirewall">REST API Reference for AssociateThirdPartyFirewall Operation</seealso>
        public virtual Task<AssociateThirdPartyFirewallResponse> AssociateThirdPartyFirewallAsync(AssociateThirdPartyFirewallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateThirdPartyFirewallResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchAssociateResource

        internal virtual BatchAssociateResourceResponse BatchAssociateResource(BatchAssociateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateResourceResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateResourceResponse>(request, options);
        }



        /// <summary>
        /// Associate resources to a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchAssociateResource">REST API Reference for BatchAssociateResource Operation</seealso>
        public virtual Task<BatchAssociateResourceResponse> BatchAssociateResourceAsync(BatchAssociateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<BatchAssociateResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisassociateResource

        internal virtual BatchDisassociateResourceResponse BatchDisassociateResource(BatchDisassociateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateResourceResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateResourceResponse>(request, options);
        }



        /// <summary>
        /// Disassociates resources from a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchDisassociateResource">REST API Reference for BatchDisassociateResource Operation</seealso>
        public virtual Task<BatchDisassociateResourceResponse> BatchDisassociateResourceAsync(BatchDisassociateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisassociateResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppsList

        internal virtual DeleteAppsListResponse DeleteAppsList(DeleteAppsListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppsListResponseUnmarshaller.Instance;

            return Invoke<DeleteAppsListResponse>(request, options);
        }



        /// <summary>
        /// Permanently deletes an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteAppsList">REST API Reference for DeleteAppsList Operation</seealso>
        public virtual Task<DeleteAppsListResponse> DeleteAppsListAsync(DeleteAppsListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppsListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppsListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationChannel

        internal virtual DeleteNotificationChannelResponse DeleteNotificationChannel(DeleteNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationChannelResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Firewall Manager association with the IAM role and the Amazon Simple Notification
        /// Service (SNS) topic that is used to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        public virtual Task<DeleteNotificationChannelResponse> DeleteNotificationChannelAsync(DeleteNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }



        /// <summary>
        /// Permanently deletes an Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteProtocolsList

        internal virtual DeleteProtocolsListResponse DeleteProtocolsList(DeleteProtocolsListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtocolsListResponseUnmarshaller.Instance;

            return Invoke<DeleteProtocolsListResponse>(request, options);
        }



        /// <summary>
        /// Permanently deletes an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtocolsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteProtocolsList">REST API Reference for DeleteProtocolsList Operation</seealso>
        public virtual Task<DeleteProtocolsListResponse> DeleteProtocolsListAsync(DeleteProtocolsListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtocolsListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProtocolsListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourceSet

        internal virtual DeleteResourceSetResponse DeleteResourceSet(DeleteResourceSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSetResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified <a>ResourceSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        public virtual Task<DeleteResourceSetResponse> DeleteResourceSetAsync(DeleteResourceSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAdminAccount

        internal virtual DisassociateAdminAccountResponse DisassociateAdminAccount(DisassociateAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Disassociates the account that has been set as the Firewall Manager administrator
        /// account. To set a different account as the administrator account, you must submit
        /// an <code>AssociateAdminAccount</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        public virtual Task<DisassociateAdminAccountResponse> DisassociateAdminAccountAsync(DisassociateAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateThirdPartyFirewall

        internal virtual DisassociateThirdPartyFirewallResponse DisassociateThirdPartyFirewall(DisassociateThirdPartyFirewallRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return Invoke<DisassociateThirdPartyFirewallResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a Firewall Manager policy administrator from a third-party firewall
        /// tenant. When you call <code>DisassociateThirdPartyFirewall</code>, the third-party
        /// firewall vendor deletes all of the firewalls that are associated with the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateThirdPartyFirewall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateThirdPartyFirewall service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateThirdPartyFirewall">REST API Reference for DisassociateThirdPartyFirewall Operation</seealso>
        public virtual Task<DisassociateThirdPartyFirewallResponse> DisassociateThirdPartyFirewallAsync(DisassociateThirdPartyFirewallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateThirdPartyFirewallResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAdminAccount

        internal virtual GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetAdminAccountResponse>(request, options);
        }



        /// <summary>
        /// Returns the Organizations account that is associated with Firewall Manager as the
        /// Firewall Manager administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual Task<GetAdminAccountResponse> GetAdminAccountAsync(GetAdminAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAdminAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAppsList

        internal virtual GetAppsListResponse GetAppsList(GetAppsListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsListResponseUnmarshaller.Instance;

            return Invoke<GetAppsListResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAppsList">REST API Reference for GetAppsList Operation</seealso>
        public virtual Task<GetAppsListResponse> GetAppsListAsync(GetAppsListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsListResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppsListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComplianceDetail

        internal virtual GetComplianceDetailResponse GetComplianceDetail(GetComplianceDetailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailResponse>(request, options);
        }



        /// <summary>
        /// Returns detailed compliance information about the specified member account. Details
        /// include resources that are in and out of compliance with the specified policy. 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Resources are considered noncompliant for WAF and Shield Advanced policies if the
        /// specified policy has not been applied to them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resources are considered noncompliant for security group policies if they are in scope
        /// of the policy, they violate one or more of the policy rules, and remediation is disabled
        /// or not possible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resources are considered noncompliant for Network Firewall policies if a firewall
        /// is missing in the VPC, if the firewall endpoint isn't set up in an expected Availability
        /// Zone and subnet, if a subnet created by the Firewall Manager doesn't have the expected
        /// route table, and for modifications to a firewall policy that violate the Firewall
        /// Manager policy's rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resources are considered noncompliant for DNS Firewall policies if a DNS Firewall
        /// rule group is missing from the rule group associations for the VPC. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComplianceDetail service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        public virtual Task<GetComplianceDetailResponse> GetComplianceDetailAsync(GetComplianceDetailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return InvokeAsync<GetComplianceDetailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNotificationChannel

        internal virtual GetNotificationChannelResponse GetNotificationChannel(GetNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<GetNotificationChannelResponse>(request, options);
        }



        /// <summary>
        /// Information about the Amazon Simple Notification Service (SNS) topic that is used
        /// to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        public virtual Task<GetNotificationChannelResponse> GetNotificationChannelAsync(GetNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy

        internal virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <code>Type</code> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProtectionStatus

        internal virtual GetProtectionStatusResponse GetProtectionStatus(GetProtectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectionStatusResponseUnmarshaller.Instance;

            return Invoke<GetProtectionStatusResponse>(request, options);
        }



        /// <summary>
        /// If you created a Shield Advanced policy, returns policy-level attack summary information
        /// in the event of a potential DDoS attack. Other policy types are currently unsupported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtectionStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtectionStatus">REST API Reference for GetProtectionStatus Operation</seealso>
        public virtual Task<GetProtectionStatusResponse> GetProtectionStatusAsync(GetProtectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetProtectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetProtocolsList

        internal virtual GetProtocolsListResponse GetProtocolsList(GetProtocolsListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtocolsListResponseUnmarshaller.Instance;

            return Invoke<GetProtocolsListResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtocolsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtocolsList">REST API Reference for GetProtocolsList Operation</seealso>
        public virtual Task<GetProtocolsListResponse> GetProtocolsListAsync(GetProtocolsListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtocolsListResponseUnmarshaller.Instance;

            return InvokeAsync<GetProtocolsListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceSet

        internal virtual GetResourceSetResponse GetResourceSet(GetResourceSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSetResponseUnmarshaller.Instance;

            return Invoke<GetResourceSetResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specific resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        public virtual Task<GetResourceSetResponse> GetResourceSetAsync(GetResourceSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetThirdPartyFirewallAssociationStatus

        internal virtual GetThirdPartyFirewallAssociationStatusResponse GetThirdPartyFirewallAssociationStatus(GetThirdPartyFirewallAssociationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThirdPartyFirewallAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyFirewallAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<GetThirdPartyFirewallAssociationStatusResponse>(request, options);
        }



        /// <summary>
        /// The onboarding status of a Firewall Manager admin account to third-party firewall
        /// vendor tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyFirewallAssociationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThirdPartyFirewallAssociationStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetThirdPartyFirewallAssociationStatus">REST API Reference for GetThirdPartyFirewallAssociationStatus Operation</seealso>
        public virtual Task<GetThirdPartyFirewallAssociationStatusResponse> GetThirdPartyFirewallAssociationStatusAsync(GetThirdPartyFirewallAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetThirdPartyFirewallAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyFirewallAssociationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetThirdPartyFirewallAssociationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetViolationDetails

        internal virtual GetViolationDetailsResponse GetViolationDetails(GetViolationDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetViolationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViolationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetViolationDetailsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves violations for a resource based on the specified Firewall Manager policy
        /// and Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetViolationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetViolationDetails service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetViolationDetails">REST API Reference for GetViolationDetails Operation</seealso>
        public virtual Task<GetViolationDetailsResponse> GetViolationDetailsAsync(GetViolationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetViolationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViolationDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetViolationDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppsLists

        internal virtual ListAppsListsResponse ListAppsLists(ListAppsListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsListsResponseUnmarshaller.Instance;

            return Invoke<ListAppsListsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>AppsListDataSummary</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppsLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAppsLists">REST API Reference for ListAppsLists Operation</seealso>
        public virtual Task<ListAppsListsResponse> ListAppsListsAsync(ListAppsListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppsListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComplianceStatus

        internal virtual ListComplianceStatusResponse ListComplianceStatus(ListComplianceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return Invoke<ListComplianceStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>PolicyComplianceStatus</code> objects. Use <code>PolicyComplianceStatus</code>
        /// to get a summary of which member accounts are protected by the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComplianceStatus service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListComplianceStatus">REST API Reference for ListComplianceStatus Operation</seealso>
        public virtual Task<ListComplianceStatusResponse> ListComplianceStatusAsync(ListComplianceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComplianceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListComplianceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDiscoveredResources

        internal virtual ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredResourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of resources in the organization's accounts that are available to
        /// be associated with a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoveredResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMemberAccounts

        internal virtual ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return Invoke<ListMemberAccountsResponse>(request, options);
        }



        /// <summary>
        /// Returns a <code>MemberAccounts</code> object that lists the member accounts in the
        /// administrator's Amazon Web Services organization.
        /// 
        ///  
        /// <para>
        /// The <code>ListMemberAccounts</code> must be submitted by the account that is set as
        /// the Firewall Manager administrator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual Task<ListMemberAccountsResponse> ListMemberAccountsAsync(ListMemberAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMemberAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies

        internal virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>PolicySummary</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListProtocolsLists

        internal virtual ListProtocolsListsResponse ListProtocolsLists(ListProtocolsListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtocolsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtocolsListsResponseUnmarshaller.Instance;

            return Invoke<ListProtocolsListsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>ProtocolsListDataSummary</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtocolsLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtocolsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListProtocolsLists">REST API Reference for ListProtocolsLists Operation</seealso>
        public virtual Task<ListProtocolsListsResponse> ListProtocolsListsAsync(ListProtocolsListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProtocolsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtocolsListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProtocolsListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceSetResources

        internal virtual ListResourceSetResourcesResponse ListResourceSetResources(ListResourceSetResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourceSetResourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of resources that are currently associated to a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSetResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSetResources service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSetResources">REST API Reference for ListResourceSetResources Operation</seealso>
        public virtual Task<ListResourceSetResourcesResponse> ListResourceSetResourcesAsync(ListResourceSetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceSetResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceSets

        internal virtual ListResourceSetsResponse ListResourceSets(ListResourceSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceSetsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>ResourceSetSummary</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSets service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        public virtual Task<ListResourceSetsResponse> ListResourceSetsAsync(ListResourceSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceSetsResponse>(request, options, cancellationToken);
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
        /// Retrieves the list of tags for the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListThirdPartyFirewallFirewallPolicies

        internal virtual ListThirdPartyFirewallFirewallPoliciesResponse ListThirdPartyFirewallFirewallPolicies(ListThirdPartyFirewallFirewallPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThirdPartyFirewallFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThirdPartyFirewallFirewallPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListThirdPartyFirewallFirewallPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all of the third-party firewall policies that are associated with
        /// the third-party firewall administrator's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThirdPartyFirewallFirewallPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThirdPartyFirewallFirewallPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListThirdPartyFirewallFirewallPolicies">REST API Reference for ListThirdPartyFirewallFirewallPolicies Operation</seealso>
        public virtual Task<ListThirdPartyFirewallFirewallPoliciesResponse> ListThirdPartyFirewallFirewallPoliciesAsync(ListThirdPartyFirewallFirewallPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListThirdPartyFirewallFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThirdPartyFirewallFirewallPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListThirdPartyFirewallFirewallPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAppsList

        internal virtual PutAppsListResponse PutAppsList(PutAppsListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppsListResponseUnmarshaller.Instance;

            return Invoke<PutAppsListResponse>(request, options);
        }



        /// <summary>
        /// Creates an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAppsList">REST API Reference for PutAppsList Operation</seealso>
        public virtual Task<PutAppsListResponse> PutAppsListAsync(PutAppsListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppsListResponseUnmarshaller.Instance;

            return InvokeAsync<PutAppsListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutNotificationChannel

        internal virtual PutNotificationChannelResponse PutNotificationChannel(PutNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<PutNotificationChannelResponse>(request, options);
        }



        /// <summary>
        /// Designates the IAM role and Amazon Simple Notification Service (SNS) topic that Firewall
        /// Manager uses to record SNS logs.
        /// 
        ///  
        /// <para>
        /// To perform this action outside of the console, you must configure the SNS topic to
        /// allow the Firewall Manager role <code>AWSServiceRoleForFMS</code> to publish SNS logs.
        /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-api-permissions-ref.html">Firewall
        /// Manager required permissions for API actions</a> in the <i>Firewall Manager Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        public virtual Task<PutNotificationChannelResponse> PutNotificationChannelAsync(PutNotificationChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return InvokeAsync<PutNotificationChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPolicy

        internal virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates an Firewall Manager policy.
        /// 
        ///  
        /// <para>
        /// Firewall Manager provides the following types of policies: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An WAF policy (type WAFV2), which defines rule groups to run first in the corresponding
        /// WAF web ACL and rule groups to run last in the web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An WAF Classic policy (type WAF), which defines a rule group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Shield Advanced policy, which applies Shield Advanced protection to specified accounts
        /// and resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A security group policy, which manages VPC security groups across your Amazon Web
        /// Services organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Network Firewall policy, which provides firewall rules to filter network traffic
        /// in specified Amazon VPCs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A DNS Firewall policy, which provides Route 53 Resolver DNS Firewall rules to filter
        /// DNS queries for specified VPCs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each policy is specific to one of the types. If you want to enforce more than one
        /// policy type across accounts, create multiple policies. You can create multiple policies
        /// for each type.
        /// </para>
        ///  
        /// <para>
        /// You must be subscribed to Shield Advanced to create a Shield Advanced policy. For
        /// more information about subscribing to Shield Advanced, see <a href="https://docs.aws.amazon.com/waf/latest/DDOSAPIReference/API_CreateSubscription.html">CreateSubscription</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <code>Type</code> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutProtocolsList

        internal virtual PutProtocolsListResponse PutProtocolsList(PutProtocolsListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProtocolsListResponseUnmarshaller.Instance;

            return Invoke<PutProtocolsListResponse>(request, options);
        }



        /// <summary>
        /// Creates an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProtocolsList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutProtocolsList">REST API Reference for PutProtocolsList Operation</seealso>
        public virtual Task<PutProtocolsListResponse> PutProtocolsListAsync(PutProtocolsListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProtocolsListResponseUnmarshaller.Instance;

            return InvokeAsync<PutProtocolsListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourceSet

        internal virtual PutResourceSetResponse PutResourceSet(PutResourceSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceSetResponseUnmarshaller.Instance;

            return Invoke<PutResourceSetResponse>(request, options);
        }



        /// <summary>
        /// Creates the resource set.
        /// 
        ///  
        /// <para>
        /// An Firewall Manager resource set defines the resources to import into an Firewall
        /// Manager policy from another Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourceSet service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutResourceSet">REST API Reference for PutResourceSet Operation</seealso>
        public virtual Task<PutResourceSetResponse> PutResourceSetAsync(PutResourceSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceSetResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourceSetResponse>(request, options, cancellationToken);
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
        /// Adds one or more tags to an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the Firewall Manager administrator. Or you
        /// might have tried to access a Region that's disabled by default, and that you need
        /// to enable for the Firewall Manager administrator account and for Organizations before
        /// you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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