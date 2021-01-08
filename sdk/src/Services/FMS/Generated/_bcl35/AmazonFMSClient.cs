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

namespace Amazon.FMS
{
    /// <summary>
    /// Implementation for accessing FMS
    ///
    /// AWS Firewall Manager 
    /// <para>
    /// This is the <i>AWS Firewall Manager API Reference</i>. This guide is for developers
    /// who need detailed information about the AWS Firewall Manager API actions, data types,
    /// and errors. For detailed information about AWS Firewall Manager features, see the
    /// <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-chapter.html">AWS
    /// Firewall Manager Developer Guide</a>.
    /// </para>
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


        #region  AssociateAdminAccount

        /// <summary>
        /// Sets the AWS Firewall Manager administrator account. AWS Firewall Manager must be
        /// associated with the master account of your AWS organization or associated with a member
        /// account that has the appropriate permissions. If the account ID that you submit is
        /// not an AWS Organizations master account, AWS Firewall Manager will set the appropriate
        /// permissions for the given member account.
        /// 
        ///  
        /// <para>
        /// The account that you associate with AWS Firewall Manager is called the AWS Firewall
        /// Manager administrator account. 
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        public virtual AssociateAdminAccountResponse AssociateAdminAccount(AssociateAdminAccountRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  DeleteAppsList

        /// <summary>
        /// Permanently deletes an AWS Firewall Manager applications list.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteAppsList">REST API Reference for DeleteAppsList Operation</seealso>
        public virtual DeleteAppsListResponse DeleteAppsList(DeleteAppsListRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Deletes an AWS Firewall Manager association with the IAM role and the Amazon Simple
        /// Notification Service (SNS) topic that is used to record AWS Firewall Manager SNS logs.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        public virtual DeleteNotificationChannelResponse DeleteNotificationChannel(DeleteNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Permanently deletes an AWS Firewall Manager policy.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Permanently deletes an AWS Firewall Manager protocols list.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteProtocolsList">REST API Reference for DeleteProtocolsList Operation</seealso>
        public virtual DeleteProtocolsListResponse DeleteProtocolsList(DeleteProtocolsListRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  DisassociateAdminAccount

        /// <summary>
        /// Disassociates the account that has been set as the AWS Firewall Manager administrator
        /// account. To set a different account as the administrator account, you must submit
        /// an <code>AssociateAdminAccount</code> request.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        public virtual DisassociateAdminAccountResponse DisassociateAdminAccount(DisassociateAdminAccountRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  GetAdminAccount

        /// <summary>
        /// Returns the AWS Organizations master account that is associated with AWS Firewall
        /// Manager as the AWS Firewall Manager administrator.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  GetAppsList

        /// <summary>
        /// Returns information about the specified AWS Firewall Manager applications list.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAppsList">REST API Reference for GetAppsList Operation</seealso>
        public virtual GetAppsListResponse GetAppsList(GetAppsListRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// include resources that are in and out of compliance with the specified policy. Resources
        /// are considered noncompliant for AWS WAF and Shield Advanced policies if the specified
        /// policy has not been applied to them. Resources are considered noncompliant for security
        /// group policies if they are in scope of the policy, they violate one or more of the
        /// policy rules, and remediation is disabled or not possible. Resources are considered
        /// noncompliant for Network Firewall policies if a firewall is missing in the VPC, if
        /// the firewall endpoint isn't set up in an expected Availability Zone and subnet, if
        /// a subnet created by the Firewall Manager doesn't have the expected route table, and
        /// for modifications to a firewall policy that violate the Firewall Manager policy's
        /// rules.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        public virtual GetComplianceDetailResponse GetComplianceDetail(GetComplianceDetailRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// to record AWS Firewall Manager SNS logs.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        public virtual GetNotificationChannelResponse GetNotificationChannel(GetNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Returns information about the specified AWS Firewall Manager policy.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <code>Type</code> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Returns information about the specified AWS Firewall Manager protocols list.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetProtocolsList">REST API Reference for GetProtocolsList Operation</seealso>
        public virtual GetProtocolsListResponse GetProtocolsList(GetProtocolsListRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  GetViolationDetails

        /// <summary>
        /// Retrieves violations for a resource based on the specified AWS Firewall Manager policy
        /// and AWS account.
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
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  ListAppsLists

        /// <summary>
        /// Returns an array of <code>AppsListDataSummary</code> objects.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListAppsLists">REST API Reference for ListAppsLists Operation</seealso>
        public virtual ListAppsListsResponse ListAppsLists(ListAppsListsRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Returns an array of <code>PolicyComplianceStatus</code> objects. Use <code>PolicyComplianceStatus</code>
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
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  ListMemberAccounts

        /// <summary>
        /// Returns a <code>MemberAccounts</code> object that lists the member accounts in the
        /// administrator's AWS organization.
        /// 
        ///  
        /// <para>
        /// The <code>ListMemberAccounts</code> must be submitted by the account that is set as
        /// the AWS Firewall Manager administrator.
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
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Returns an array of <code>PolicySummary</code> objects.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Returns an array of <code>ProtocolsListDataSummary</code> objects.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListProtocolsLists">REST API Reference for ListProtocolsLists Operation</seealso>
        public virtual ListProtocolsListsResponse ListProtocolsLists(ListProtocolsListsRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the list of tags for the specified AWS resource.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  PutAppsList

        /// <summary>
        /// Creates an AWS Firewall Manager applications list.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutAppsList">REST API Reference for PutAppsList Operation</seealso>
        public virtual PutAppsListResponse PutAppsList(PutAppsListRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Designates the IAM role and Amazon Simple Notification Service (SNS) topic that AWS
        /// Firewall Manager uses to record SNS logs.
        /// 
        ///  
        /// <para>
        /// To perform this action outside of the console, you must configure the SNS topic to
        /// allow the Firewall Manager role <code>AWSServiceRoleForFMS</code> to publish SNS logs.
        /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-api-permissions-ref.html">Firewall
        /// Manager required permissions for API actions</a> in the <i>AWS Firewall Manager Developer
        /// Guide</i>.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        public virtual PutNotificationChannelResponse PutNotificationChannel(PutNotificationChannelRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Creates an AWS Firewall Manager policy.
        /// 
        ///  
        /// <para>
        /// Firewall Manager provides the following types of policies: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An AWS WAF policy (type WAFV2), which defines rule groups to run first in the corresponding
        /// AWS WAF web ACL and rule groups to run last in the web ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An AWS WAF Classic policy (type WAF), which defines a rule group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Shield Advanced policy, which applies Shield Advanced protection to specified accounts
        /// and resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A security group policy, which manages VPC security groups across your AWS organization.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An AWS Network Firewall policy, which provides firewall rules to filter network traffic
        /// in specified Amazon VPCs.
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
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidTypeException">
        /// The value of the <code>Type</code> parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Creates an AWS Firewall Manager protocols list.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutProtocolsList">REST API Reference for PutProtocolsList Operation</seealso>
        public virtual PutProtocolsListResponse PutProtocolsList(PutProtocolsListRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to an AWS resource.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        /// Removes one or more tags from an AWS resource.
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
        /// For example, you might have submitted an <code>AssociateAdminAccount</code> request
        /// for an account ID that was already set as the AWS Firewall Manager administrator.
        /// Or you might have tried to access a Region that's disabled by default, and that you
        /// need to enable for the Firewall Manager administrator account and for AWS Organizations
        /// before you can access it.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
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
            var options = new InvokeOptions();
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
        
    }
}