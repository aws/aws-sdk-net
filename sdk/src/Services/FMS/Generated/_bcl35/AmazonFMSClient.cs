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
using System.Collections.Generic;
using System.Net;

using Amazon.FMS.Model;
using Amazon.FMS.Model.Internal.MarshallTransformations;
using Amazon.FMS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.FMS
{
    /// <summary>
    /// <para>Implementation for accessing FMS</para>
    ///
    /// This is the <i>Firewall Manager API Reference</i>. This guide is for developers who
    /// need detailed information about the Firewall Manager API actions, data types, and
    /// errors. For detailed information about Firewall Manager features, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-chapter.html">Firewall
    /// Manager Developer Guide</a>.
    /// 
    ///  
    /// <para>
    /// Some API actions require explicit resource permissions. For information, see the developer
    /// guide topic <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-security_iam_service-with-iam.html#fms-security_iam_service-with-iam-roles-service">Service
    /// roles for Firewall Manager</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonFMSClient : AmazonServiceClient, IAmazonFMS
    {
        private static IServiceMetadata serviceMetadata = new AmazonFMSMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Sets a Firewall Manager default administrator account. The Firewall Manager default
        /// administrator account can manage third-party firewalls and has full administrative
        /// scope that allows administration of all policy types, accounts, organizational units,
        /// and Regions. This account must be a member account of the organization in Organizations
        /// whose resources you want to protect.
        /// 
        ///  
        /// <para>
        /// For information about working with Firewall Manager administrator accounts, see <a
        /// href="https://docs.aws.amazon.com/organizations/latest/userguide/fms-administrators.html">Managing
        /// Firewall Manager administrators</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAdminAccount service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        public virtual AssociateAdminAccountResponse AssociateAdminAccount(AssociateAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateAdminAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAdminAccount operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginAssociateAdminAccount(AssociateAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAdminAccount.</param>
        /// 
        /// <returns>Returns a  AssociateAdminAccountResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        public virtual AssociateAdminAccountResponse EndAssociateAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateThirdPartyFirewall

        /// <summary>
        /// Sets the Firewall Manager policy administrator as a tenant administrator of a third-party
        /// firewall service. A tenant is an instance of the third-party firewall service that's
        /// associated with your Amazon Web Services customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateThirdPartyFirewall service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateThirdPartyFirewall">REST API Reference for AssociateThirdPartyFirewall Operation</seealso>
        public virtual AssociateThirdPartyFirewallResponse AssociateThirdPartyFirewall(AssociateThirdPartyFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return Invoke<AssociateThirdPartyFirewallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateThirdPartyFirewall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateThirdPartyFirewall operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateThirdPartyFirewall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateThirdPartyFirewall">REST API Reference for AssociateThirdPartyFirewall Operation</seealso>
        public virtual IAsyncResult BeginAssociateThirdPartyFirewall(AssociateThirdPartyFirewallRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateThirdPartyFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateThirdPartyFirewall.</param>
        /// 
        /// <returns>Returns a  AssociateThirdPartyFirewallResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateThirdPartyFirewall">REST API Reference for AssociateThirdPartyFirewall Operation</seealso>
        public virtual AssociateThirdPartyFirewallResponse EndAssociateThirdPartyFirewall(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateThirdPartyFirewallResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchAssociateResource

        /// <summary>
        /// Associate resources to a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResource service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchAssociateResource">REST API Reference for BatchAssociateResource Operation</seealso>
        public virtual BatchAssociateResourceResponse BatchAssociateResource(BatchAssociateResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateResourceResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResource operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchAssociateResource">REST API Reference for BatchAssociateResource Operation</seealso>
        public virtual IAsyncResult BeginBatchAssociateResource(BatchAssociateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateResource.</param>
        /// 
        /// <returns>Returns a  BatchAssociateResourceResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchAssociateResource">REST API Reference for BatchAssociateResource Operation</seealso>
        public virtual BatchAssociateResourceResponse EndBatchAssociateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisassociateResource

        /// <summary>
        /// Disassociates resources from a Firewall Manager resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResource service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchDisassociateResource">REST API Reference for BatchDisassociateResource Operation</seealso>
        public virtual BatchDisassociateResourceResponse BatchDisassociateResource(BatchDisassociateResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateResourceResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResource operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchDisassociateResource">REST API Reference for BatchDisassociateResource Operation</seealso>
        public virtual IAsyncResult BeginBatchDisassociateResource(BatchDisassociateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateResource.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateResourceResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/BatchDisassociateResource">REST API Reference for BatchDisassociateResource Operation</seealso>
        public virtual BatchDisassociateResourceResponse EndBatchDisassociateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppsList

        /// <summary>
        /// Permanently deletes an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppsList service method.</param>
        /// 
        /// <returns>The response from the DeleteAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteAppsList">REST API Reference for DeleteAppsList Operation</seealso>
        public virtual DeleteAppsListResponse DeleteAppsList(DeleteAppsListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppsListResponseUnmarshaller.Instance;

            return Invoke<DeleteAppsListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppsList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppsList operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppsList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteAppsList">REST API Reference for DeleteAppsList Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppsList(DeleteAppsListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppsListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppsList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppsList.</param>
        /// 
        /// <returns>Returns a  DeleteAppsListResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteAppsList">REST API Reference for DeleteAppsList Operation</seealso>
        public virtual DeleteAppsListResponse EndDeleteAppsList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppsListResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNotificationChannel

        /// <summary>
        /// Deletes an Firewall Manager association with the IAM role and the Amazon Simple Notification
        /// Service (SNS) topic that is used to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        public virtual DeleteNotificationChannelResponse DeleteNotificationChannel(DeleteNotificationChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationChannel operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotificationChannel(DeleteNotificationChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationChannel.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationChannelResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        public virtual DeleteNotificationChannelResponse EndDeleteNotificationChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePolicy

        /// <summary>
        /// Permanently deletes an Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProtocolsList

        /// <summary>
        /// Permanently deletes an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtocolsList service method.</param>
        /// 
        /// <returns>The response from the DeleteProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteProtocolsList">REST API Reference for DeleteProtocolsList Operation</seealso>
        public virtual DeleteProtocolsListResponse DeleteProtocolsList(DeleteProtocolsListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtocolsListResponseUnmarshaller.Instance;

            return Invoke<DeleteProtocolsListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProtocolsList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtocolsList operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProtocolsList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteProtocolsList">REST API Reference for DeleteProtocolsList Operation</seealso>
        public virtual IAsyncResult BeginDeleteProtocolsList(DeleteProtocolsListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtocolsListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProtocolsList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProtocolsList.</param>
        /// 
        /// <returns>Returns a  DeleteProtocolsListResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteProtocolsList">REST API Reference for DeleteProtocolsList Operation</seealso>
        public virtual DeleteProtocolsListResponse EndDeleteProtocolsList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProtocolsListResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourceSet

        /// <summary>
        /// Deletes the specified <a>ResourceSet</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        public virtual DeleteResourceSetResponse DeleteResourceSet(DeleteResourceSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSetResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourceSet(DeleteResourceSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceSet.</param>
        /// 
        /// <returns>Returns a  DeleteResourceSetResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        public virtual DeleteResourceSetResponse EndDeleteResourceSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAdminAccount

        /// <summary>
        /// Disassociates an Firewall Manager administrator account. To set a different account
        /// as an Firewall Manager administrator, submit a <a>PutAdminAccount</a> request. To
        /// set an account as a default administrator account, you must submit an <a>AssociateAdminAccount</a>
        /// request.
        /// 
        ///  
        /// <para>
        /// Disassociation of the default administrator account follows the first in, last out
        /// principle. If you are the default administrator, all Firewall Manager administrators
        /// within the organization must first disassociate their accounts before you can disassociate
        /// your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        public virtual DisassociateAdminAccountResponse DisassociateAdminAccount(DisassociateAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateAdminAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAdminAccount operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAdminAccount(DisassociateAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAdminAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateAdminAccountResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        public virtual DisassociateAdminAccountResponse EndDisassociateAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateThirdPartyFirewall

        /// <summary>
        /// Disassociates a Firewall Manager policy administrator from a third-party firewall
        /// tenant. When you call <c>DisassociateThirdPartyFirewall</c>, the third-party firewall
        /// vendor deletes all of the firewalls that are associated with the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateThirdPartyFirewall service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateThirdPartyFirewall">REST API Reference for DisassociateThirdPartyFirewall Operation</seealso>
        public virtual DisassociateThirdPartyFirewallResponse DisassociateThirdPartyFirewall(DisassociateThirdPartyFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return Invoke<DisassociateThirdPartyFirewallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateThirdPartyFirewall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateThirdPartyFirewall operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateThirdPartyFirewall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateThirdPartyFirewall">REST API Reference for DisassociateThirdPartyFirewall Operation</seealso>
        public virtual IAsyncResult BeginDisassociateThirdPartyFirewall(DisassociateThirdPartyFirewallRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateThirdPartyFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateThirdPartyFirewallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateThirdPartyFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateThirdPartyFirewall.</param>
        /// 
        /// <returns>Returns a  DisassociateThirdPartyFirewallResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateThirdPartyFirewall">REST API Reference for DisassociateThirdPartyFirewall Operation</seealso>
        public virtual DisassociateThirdPartyFirewallResponse EndDisassociateThirdPartyFirewall(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateThirdPartyFirewallResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAdminAccount

        /// <summary>
        /// Returns the Organizations account that is associated with Firewall Manager as the
        /// Firewall Manager default administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount service method.</param>
        /// 
        /// <returns>The response from the GetAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetAdminAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdminAccount operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginGetAdminAccount(GetAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdminAccount.</param>
        /// 
        /// <returns>Returns a  GetAdminAccountResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual GetAdminAccountResponse EndGetAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAdminScope

        /// <summary>
        /// Returns information about the specified account's administrative scope. The administrative
        /// scope defines the resources that an Firewall Manager administrator can manage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdminScope service method.</param>
        /// 
        /// <returns>The response from the GetAdminScope service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminScope">REST API Reference for GetAdminScope Operation</seealso>
        public virtual GetAdminScopeResponse GetAdminScope(GetAdminScopeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdminScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminScopeResponseUnmarshaller.Instance;

            return Invoke<GetAdminScopeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAdminScope operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdminScope operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdminScope
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminScope">REST API Reference for GetAdminScope Operation</seealso>
        public virtual IAsyncResult BeginGetAdminScope(GetAdminScopeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdminScopeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdminScopeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdminScope operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdminScope.</param>
        /// 
        /// <returns>Returns a  GetAdminScopeResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminScope">REST API Reference for GetAdminScope Operation</seealso>
        public virtual GetAdminScopeResponse EndGetAdminScope(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAdminScopeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAppsList

        /// <summary>
        /// Returns information about the specified Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppsList service method.</param>
        /// 
        /// <returns>The response from the GetAppsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAppsList">REST API Reference for GetAppsList Operation</seealso>
        public virtual GetAppsListResponse GetAppsList(GetAppsListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsListResponseUnmarshaller.Instance;

            return Invoke<GetAppsListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppsList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppsList operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppsList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAppsList">REST API Reference for GetAppsList Operation</seealso>
        public virtual IAsyncResult BeginGetAppsList(GetAppsListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppsList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppsList.</param>
        /// 
        /// <returns>Returns a  GetAppsListResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAppsList">REST API Reference for GetAppsList Operation</seealso>
        public virtual GetAppsListResponse EndGetAppsList(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppsListResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceDetail

        /// <summary>
        /// Returns detailed compliance information about the specified member account. Details
        /// include resources that are in and out of compliance with the specified policy. 
        /// 
        ///  
        /// <para>
        /// The reasons for resources being considered compliant depend on the Firewall Manager
        /// policy type. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetail service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        public virtual GetComplianceDetailResponse GetComplianceDetail(GetComplianceDetailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetail operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceDetail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        public virtual IAsyncResult BeginGetComplianceDetail(GetComplianceDetailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceDetail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceDetail.</param>
        /// 
        /// <returns>Returns a  GetComplianceDetailResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        public virtual GetComplianceDetailResponse EndGetComplianceDetail(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceDetailResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNotificationChannel

        /// <summary>
        /// Information about the Amazon Simple Notification Service (SNS) topic that is used
        /// to record Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the GetNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        public virtual GetNotificationChannelResponse GetNotificationChannel(GetNotificationChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<GetNotificationChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationChannel operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNotificationChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        public virtual IAsyncResult BeginGetNotificationChannel(GetNotificationChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationChannel.</param>
        /// 
        /// <returns>Returns a  GetNotificationChannelResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        public virtual GetNotificationChannelResponse EndGetNotificationChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNotificationChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Returns information about the specified Firewall Manager policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <c>Type</c> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProtectionStatus

        /// <summary>
        /// If you created a Shield Advanced policy, returns policy-level attack summary information
        /// in the event of a potential DDoS attack. Other policy types are currently unsupported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectionStatus service method.</param>
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
        public virtual GetProtectionStatusResponse GetProtectionStatus(GetProtectionStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectionStatusResponseUnmarshaller.Instance;

            return Invoke<GetProtectionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProtectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProtectionStatus operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProtectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtectionStatus">REST API Reference for GetProtectionStatus Operation</seealso>
        public virtual IAsyncResult BeginGetProtectionStatus(GetProtectionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProtectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProtectionStatus.</param>
        /// 
        /// <returns>Returns a  GetProtectionStatusResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtectionStatus">REST API Reference for GetProtectionStatus Operation</seealso>
        public virtual GetProtectionStatusResponse EndGetProtectionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProtectionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProtocolsList

        /// <summary>
        /// Returns information about the specified Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtocolsList service method.</param>
        /// 
        /// <returns>The response from the GetProtocolsList service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtocolsList">REST API Reference for GetProtocolsList Operation</seealso>
        public virtual GetProtocolsListResponse GetProtocolsList(GetProtocolsListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtocolsListResponseUnmarshaller.Instance;

            return Invoke<GetProtocolsListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProtocolsList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProtocolsList operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProtocolsList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtocolsList">REST API Reference for GetProtocolsList Operation</seealso>
        public virtual IAsyncResult BeginGetProtocolsList(GetProtocolsListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtocolsListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProtocolsList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProtocolsList.</param>
        /// 
        /// <returns>Returns a  GetProtocolsListResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtocolsList">REST API Reference for GetProtocolsList Operation</seealso>
        public virtual GetProtocolsListResponse EndGetProtocolsList(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProtocolsListResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceSet

        /// <summary>
        /// Gets information about a specific resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        public virtual GetResourceSetResponse GetResourceSet(GetResourceSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSetResponseUnmarshaller.Instance;

            return Invoke<GetResourceSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        public virtual IAsyncResult BeginGetResourceSet(GetResourceSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceSet.</param>
        /// 
        /// <returns>Returns a  GetResourceSetResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        public virtual GetResourceSetResponse EndGetResourceSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetThirdPartyFirewallAssociationStatus

        /// <summary>
        /// The onboarding status of a Firewall Manager admin account to third-party firewall
        /// vendor tenant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyFirewallAssociationStatus service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetThirdPartyFirewallAssociationStatus">REST API Reference for GetThirdPartyFirewallAssociationStatus Operation</seealso>
        public virtual GetThirdPartyFirewallAssociationStatusResponse GetThirdPartyFirewallAssociationStatus(GetThirdPartyFirewallAssociationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetThirdPartyFirewallAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyFirewallAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<GetThirdPartyFirewallAssociationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetThirdPartyFirewallAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThirdPartyFirewallAssociationStatus operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetThirdPartyFirewallAssociationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetThirdPartyFirewallAssociationStatus">REST API Reference for GetThirdPartyFirewallAssociationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetThirdPartyFirewallAssociationStatus(GetThirdPartyFirewallAssociationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetThirdPartyFirewallAssociationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetThirdPartyFirewallAssociationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetThirdPartyFirewallAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetThirdPartyFirewallAssociationStatus.</param>
        /// 
        /// <returns>Returns a  GetThirdPartyFirewallAssociationStatusResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetThirdPartyFirewallAssociationStatus">REST API Reference for GetThirdPartyFirewallAssociationStatus Operation</seealso>
        public virtual GetThirdPartyFirewallAssociationStatusResponse EndGetThirdPartyFirewallAssociationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetThirdPartyFirewallAssociationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetViolationDetails

        /// <summary>
        /// Retrieves violations for a resource based on the specified Firewall Manager policy
        /// and Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetViolationDetails service method.</param>
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
        public virtual GetViolationDetailsResponse GetViolationDetails(GetViolationDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetViolationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViolationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetViolationDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetViolationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetViolationDetails operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetViolationDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetViolationDetails">REST API Reference for GetViolationDetails Operation</seealso>
        public virtual IAsyncResult BeginGetViolationDetails(GetViolationDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetViolationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetViolationDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetViolationDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetViolationDetails.</param>
        /// 
        /// <returns>Returns a  GetViolationDetailsResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetViolationDetails">REST API Reference for GetViolationDetails Operation</seealso>
        public virtual GetViolationDetailsResponse EndGetViolationDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetViolationDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAdminAccountsForOrganization

        /// <summary>
        /// Returns a <c>AdminAccounts</c> object that lists the Firewall Manager administrators
        /// within the organization that are onboarded to Firewall Manager by <a>AssociateAdminAccount</a>.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminAccountsForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListAdminAccountsForOrganization service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminAccountsForOrganization">REST API Reference for ListAdminAccountsForOrganization Operation</seealso>
        public virtual ListAdminAccountsForOrganizationResponse ListAdminAccountsForOrganization(ListAdminAccountsForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdminAccountsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdminAccountsForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListAdminAccountsForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAdminAccountsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAdminAccountsForOrganization operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAdminAccountsForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminAccountsForOrganization">REST API Reference for ListAdminAccountsForOrganization Operation</seealso>
        public virtual IAsyncResult BeginListAdminAccountsForOrganization(ListAdminAccountsForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdminAccountsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdminAccountsForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAdminAccountsForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAdminAccountsForOrganization.</param>
        /// 
        /// <returns>Returns a  ListAdminAccountsForOrganizationResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminAccountsForOrganization">REST API Reference for ListAdminAccountsForOrganization Operation</seealso>
        public virtual ListAdminAccountsForOrganizationResponse EndListAdminAccountsForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAdminAccountsForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAdminsManagingAccount

        /// <summary>
        /// Lists the accounts that are managing the specified Organizations member account. This
        /// is useful for any member account so that they can view the accounts who are managing
        /// their account. This operation only returns the managing administrators that have the
        /// requested account within their <a>AdminScope</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAdminsManagingAccount service method.</param>
        /// 
        /// <returns>The response from the ListAdminsManagingAccount service method, as returned by FMS.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminsManagingAccount">REST API Reference for ListAdminsManagingAccount Operation</seealso>
        public virtual ListAdminsManagingAccountResponse ListAdminsManagingAccount(ListAdminsManagingAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdminsManagingAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdminsManagingAccountResponseUnmarshaller.Instance;

            return Invoke<ListAdminsManagingAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAdminsManagingAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAdminsManagingAccount operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAdminsManagingAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminsManagingAccount">REST API Reference for ListAdminsManagingAccount Operation</seealso>
        public virtual IAsyncResult BeginListAdminsManagingAccount(ListAdminsManagingAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAdminsManagingAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAdminsManagingAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAdminsManagingAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAdminsManagingAccount.</param>
        /// 
        /// <returns>Returns a  ListAdminsManagingAccountResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAdminsManagingAccount">REST API Reference for ListAdminsManagingAccount Operation</seealso>
        public virtual ListAdminsManagingAccountResponse EndListAdminsManagingAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAdminsManagingAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppsLists

        /// <summary>
        /// Returns an array of <c>AppsListDataSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppsLists service method.</param>
        /// 
        /// <returns>The response from the ListAppsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAppsLists">REST API Reference for ListAppsLists Operation</seealso>
        public virtual ListAppsListsResponse ListAppsLists(ListAppsListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsListsResponseUnmarshaller.Instance;

            return Invoke<ListAppsListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppsLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppsLists operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppsLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAppsLists">REST API Reference for ListAppsLists Operation</seealso>
        public virtual IAsyncResult BeginListAppsLists(ListAppsListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAppsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppsLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppsLists.</param>
        /// 
        /// <returns>Returns a  ListAppsListsResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAppsLists">REST API Reference for ListAppsLists Operation</seealso>
        public virtual ListAppsListsResponse EndListAppsLists(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppsListsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComplianceStatus

        /// <summary>
        /// Returns an array of <c>PolicyComplianceStatus</c> objects. Use <c>PolicyComplianceStatus</c>
        /// to get a summary of which member accounts are protected by the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceStatus service method.</param>
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
        public virtual ListComplianceStatusResponse ListComplianceStatus(ListComplianceStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComplianceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return Invoke<ListComplianceStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComplianceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComplianceStatus operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComplianceStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListComplianceStatus">REST API Reference for ListComplianceStatus Operation</seealso>
        public virtual IAsyncResult BeginListComplianceStatus(ListComplianceStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComplianceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComplianceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComplianceStatus.</param>
        /// 
        /// <returns>Returns a  ListComplianceStatusResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListComplianceStatus">REST API Reference for ListComplianceStatus Operation</seealso>
        public virtual ListComplianceStatusResponse EndListComplianceStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComplianceStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDiscoveredResources

        /// <summary>
        /// Returns an array of resources in the organization's accounts that are available to
        /// be associated with a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoveredResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual IAsyncResult BeginListDiscoveredResources(ListDiscoveredResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoveredResources.</param>
        /// 
        /// <returns>Returns a  ListDiscoveredResourcesResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual ListDiscoveredResourcesResponse EndListDiscoveredResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDiscoveredResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMemberAccounts

        /// <summary>
        /// Returns a <c>MemberAccounts</c> object that lists the member accounts in the administrator's
        /// Amazon Web Services organization.
        /// 
        ///  
        /// <para>
        /// Either an Firewall Manager administrator or the organization's management account
        /// can make this request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
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
        public virtual ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return Invoke<ListMemberAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual IAsyncResult BeginListMemberAccounts(ListMemberAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMemberAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMemberAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberAccounts.</param>
        /// 
        /// <returns>Returns a  ListMemberAccountsResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        public virtual ListMemberAccountsResponse EndListMemberAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMemberAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicies

        /// <summary>
        /// Returns an array of <c>PolicySummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual IAsyncResult BeginListPolicies(ListPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicies.</param>
        /// 
        /// <returns>Returns a  ListPoliciesResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProtocolsLists

        /// <summary>
        /// Returns an array of <c>ProtocolsListDataSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtocolsLists service method.</param>
        /// 
        /// <returns>The response from the ListProtocolsLists service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListProtocolsLists">REST API Reference for ListProtocolsLists Operation</seealso>
        public virtual ListProtocolsListsResponse ListProtocolsLists(ListProtocolsListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtocolsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtocolsListsResponseUnmarshaller.Instance;

            return Invoke<ListProtocolsListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtocolsLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtocolsLists operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtocolsLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListProtocolsLists">REST API Reference for ListProtocolsLists Operation</seealso>
        public virtual IAsyncResult BeginListProtocolsLists(ListProtocolsListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtocolsListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtocolsListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtocolsLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtocolsLists.</param>
        /// 
        /// <returns>Returns a  ListProtocolsListsResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListProtocolsLists">REST API Reference for ListProtocolsLists Operation</seealso>
        public virtual ListProtocolsListsResponse EndListProtocolsLists(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProtocolsListsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceSetResources

        /// <summary>
        /// Returns an array of resources that are currently associated to a resource set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSetResources service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSetResources">REST API Reference for ListResourceSetResources Operation</seealso>
        public virtual ListResourceSetResourcesResponse ListResourceSetResources(ListResourceSetResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetResourcesResponseUnmarshaller.Instance;

            return Invoke<ListResourceSetResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceSetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSetResources operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceSetResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSetResources">REST API Reference for ListResourceSetResources Operation</seealso>
        public virtual IAsyncResult BeginListResourceSetResources(ListResourceSetResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceSetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceSetResources.</param>
        /// 
        /// <returns>Returns a  ListResourceSetResourcesResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSetResources">REST API Reference for ListResourceSetResources Operation</seealso>
        public virtual ListResourceSetResourcesResponse EndListResourceSetResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceSetResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceSets

        /// <summary>
        /// Returns an array of <c>ResourceSetSummary</c> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        public virtual ListResourceSetsResponse ListResourceSets(ListResourceSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetsResponseUnmarshaller.Instance;

            return Invoke<ListResourceSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        public virtual IAsyncResult BeginListResourceSets(ListResourceSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceSets.</param>
        /// 
        /// <returns>Returns a  ListResourceSetsResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        public virtual ListResourceSetsResponse EndListResourceSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the list of tags for the specified Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListThirdPartyFirewallFirewallPolicies

        /// <summary>
        /// Retrieves a list of all of the third-party firewall policies that are associated with
        /// the third-party firewall administrator's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThirdPartyFirewallFirewallPolicies service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListThirdPartyFirewallFirewallPolicies">REST API Reference for ListThirdPartyFirewallFirewallPolicies Operation</seealso>
        public virtual ListThirdPartyFirewallFirewallPoliciesResponse ListThirdPartyFirewallFirewallPolicies(ListThirdPartyFirewallFirewallPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThirdPartyFirewallFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThirdPartyFirewallFirewallPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListThirdPartyFirewallFirewallPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListThirdPartyFirewallFirewallPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThirdPartyFirewallFirewallPolicies operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThirdPartyFirewallFirewallPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListThirdPartyFirewallFirewallPolicies">REST API Reference for ListThirdPartyFirewallFirewallPolicies Operation</seealso>
        public virtual IAsyncResult BeginListThirdPartyFirewallFirewallPolicies(ListThirdPartyFirewallFirewallPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListThirdPartyFirewallFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListThirdPartyFirewallFirewallPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListThirdPartyFirewallFirewallPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThirdPartyFirewallFirewallPolicies.</param>
        /// 
        /// <returns>Returns a  ListThirdPartyFirewallFirewallPoliciesResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListThirdPartyFirewallFirewallPolicies">REST API Reference for ListThirdPartyFirewallFirewallPolicies Operation</seealso>
        public virtual ListThirdPartyFirewallFirewallPoliciesResponse EndListThirdPartyFirewallFirewallPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListThirdPartyFirewallFirewallPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAdminAccount

        /// <summary>
        /// Creates or updates an Firewall Manager administrator account. The account must be
        /// a member of the organization that was onboarded to Firewall Manager by <a>AssociateAdminAccount</a>.
        /// Only the organization's management account can create an Firewall Manager administrator
        /// account. When you create an Firewall Manager administrator account, the service checks
        /// to see if the account is already a delegated administrator within Organizations. If
        /// the account isn't a delegated administrator, Firewall Manager calls Organizations
        /// to delegate the account within Organizations. For more information about administrator
        /// accounts within Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts.html">Managing
        /// the Amazon Web Services Accounts in Your Organization</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAdminAccount service method.</param>
        /// 
        /// <returns>The response from the PutAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidInputException">
        /// The parameters of the request were invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        public virtual PutAdminAccountResponse PutAdminAccount(PutAdminAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAdminAccountResponseUnmarshaller.Instance;

            return Invoke<PutAdminAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAdminAccount operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAdminAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        public virtual IAsyncResult BeginPutAdminAccount(PutAdminAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAdminAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAdminAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAdminAccount.</param>
        /// 
        /// <returns>Returns a  PutAdminAccountResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAdminAccount">REST API Reference for PutAdminAccount Operation</seealso>
        public virtual PutAdminAccountResponse EndPutAdminAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAdminAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAppsList

        /// <summary>
        /// Creates an Firewall Manager applications list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppsList service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAppsList">REST API Reference for PutAppsList Operation</seealso>
        public virtual PutAppsListResponse PutAppsList(PutAppsListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppsListResponseUnmarshaller.Instance;

            return Invoke<PutAppsListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppsList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppsList operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppsList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAppsList">REST API Reference for PutAppsList Operation</seealso>
        public virtual IAsyncResult BeginPutAppsList(PutAppsListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAppsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppsListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppsList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppsList.</param>
        /// 
        /// <returns>Returns a  PutAppsListResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAppsList">REST API Reference for PutAppsList Operation</seealso>
        public virtual PutAppsListResponse EndPutAppsList(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAppsListResponse>(asyncResult);
        }

        #endregion
        
        #region  PutNotificationChannel

        /// <summary>
        /// Designates the IAM role and Amazon Simple Notification Service (SNS) topic that Firewall
        /// Manager uses to record SNS logs.
        /// 
        ///  
        /// <para>
        /// To perform this action outside of the console, you must first configure the SNS topic's
        /// access policy to allow the <c>SnsRoleName</c> to publish SNS logs. If the <c>SnsRoleName</c>
        /// provided is a role other than the <c>AWSServiceRoleForFMS</c> service-linked role,
        /// this role must have a trust relationship configured to allow the Firewall Manager
        /// service principal <c>fms.amazonaws.com</c> to assume this role. For information about
        /// configuring an SNS access policy, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-security_iam_service-with-iam.html#fms-security_iam_service-with-iam-roles-service">Service
        /// roles for Firewall Manager</a> in the <i>Firewall Manager Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the PutNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do or the operation wasn't possible.
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        public virtual PutNotificationChannelResponse PutNotificationChannel(PutNotificationChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<PutNotificationChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationChannel operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutNotificationChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        public virtual IAsyncResult BeginPutNotificationChannel(PutNotificationChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutNotificationChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutNotificationChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutNotificationChannel.</param>
        /// 
        /// <returns>Returns a  PutNotificationChannelResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        public virtual PutNotificationChannelResponse EndPutNotificationChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutNotificationChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPolicy

        /// <summary>
        /// Creates an Firewall Manager policy.
        /// 
        ///  
        /// <para>
        /// A Firewall Manager policy is specific to the individual policy type. If you want to
        /// enforce multiple policy types across accounts, you can create multiple policies. You
        /// can create more than one policy for each type. 
        /// </para>
        ///  
        /// <para>
        /// If you add a new account to an organization that you created with Organizations, Firewall
        /// Manager automatically applies the policy to the resources in that account that are
        /// within scope of the policy. 
        /// </para>
        ///  
        /// <para>
        /// Firewall Manager provides the following types of policies: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>WAF policy</b> - This policy applies WAF web ACL protections to specified accounts
        /// and resources. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Shield Advanced policy</b> - This policy applies Shield Advanced protection to
        /// specified accounts and resources. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Security Groups policy</b> - This type of policy gives you control over security
        /// groups that are in use throughout your organization in Organizations and lets you
        /// enforce a baseline set of rules across your organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Network ACL policy</b> - This type of policy gives you control over the network
        /// ACLs that are in use throughout your organization in Organizations and lets you enforce
        /// a baseline set of first and last network ACL rules across your organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Network Firewall policy</b> - This policy applies Network Firewall protection
        /// to your organization's VPCs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DNS Firewall policy</b> - This policy applies Amazon Route 53 Resolver DNS Firewall
        /// protections to your organization's VPCs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Third-party firewall policy</b> - This policy applies third-party firewall protections.
        /// Third-party firewalls are available by subscription through the Amazon Web Services
        /// Marketplace console at <a href="http://aws.amazon.com/marketplace">Amazon Web Services
        /// Marketplace</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Palo Alto Networks Cloud NGFW policy</b> - This policy applies Palo Alto Networks
        /// Cloud Next Generation Firewall (NGFW) protections and Palo Alto Networks Cloud NGFW
        /// rulestacks to your organization's VPCs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Fortigate CNF policy</b> - This policy applies Fortigate Cloud Native Firewall
        /// (CNF) protections. Fortigate CNF is a cloud-centered solution that blocks Zero-Day
        /// threats and secures cloud infrastructures with industry-leading advanced threat prevention,
        /// smart web application firewalls (WAF), and API protection.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <c>Type</c> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutPolicy(PutPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPolicy.</param>
        /// 
        /// <returns>Returns a  PutPolicyResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual PutPolicyResponse EndPutPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutProtocolsList

        /// <summary>
        /// Creates an Firewall Manager protocols list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProtocolsList service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutProtocolsList">REST API Reference for PutProtocolsList Operation</seealso>
        public virtual PutProtocolsListResponse PutProtocolsList(PutProtocolsListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProtocolsListResponseUnmarshaller.Instance;

            return Invoke<PutProtocolsListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutProtocolsList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProtocolsList operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProtocolsList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutProtocolsList">REST API Reference for PutProtocolsList Operation</seealso>
        public virtual IAsyncResult BeginPutProtocolsList(PutProtocolsListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProtocolsListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProtocolsListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutProtocolsList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProtocolsList.</param>
        /// 
        /// <returns>Returns a  PutProtocolsListResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutProtocolsList">REST API Reference for PutProtocolsList Operation</seealso>
        public virtual PutProtocolsListResponse EndPutProtocolsList(IAsyncResult asyncResult)
        {
            return EndInvoke<PutProtocolsListResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourceSet

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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutResourceSet">REST API Reference for PutResourceSet Operation</seealso>
        public virtual PutResourceSetResponse PutResourceSet(PutResourceSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceSetResponseUnmarshaller.Instance;

            return Invoke<PutResourceSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourceSet operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutResourceSet">REST API Reference for PutResourceSet Operation</seealso>
        public virtual IAsyncResult BeginPutResourceSet(PutResourceSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourceSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourceSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourceSet.</param>
        /// 
        /// <returns>Returns a  PutResourceSetResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutResourceSet">REST API Reference for PutResourceSet Operation</seealso>
        public virtual PutResourceSetResponse EndPutResourceSet(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourceSetResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <c>policy</c>
        /// objects that you can create for an Amazon Web Services account. For more information,
        /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// For example, you might have submitted an <c>AssociateAdminAccount</c> request for
        /// an account ID that was already set as the Firewall Manager administrator. Or you might
        /// have tried to access a Region that's disabled by default, and that you need to enable
        /// for the Firewall Manager administrator account and for Organizations before you can
        /// access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFMSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from FMS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonFMSEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}