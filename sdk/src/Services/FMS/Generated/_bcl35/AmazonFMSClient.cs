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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.FMS.Model;
using Amazon.FMS.Model.Internal.MarshallTransformations;
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
    /// <a href="http://docs.aws.amazon.com/waf/latest/developerguide/fms-chapter.html">AWS
    /// Firewall Manager Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonFMSClient : AmazonServiceClient, IAmazonFMS
    {
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
        /// associated with a master account in AWS Organizations or associated with a member
        /// account that has the appropriate permissions. If the account ID that you submit is
        /// not an AWS Organizations master account, AWS Firewall Manager will set the appropriate
        /// permissions for the given member account.
        /// 
        ///  
        /// <para>
        /// The account that you associate with AWS Firewall Manager is called the AWS Firewall
        /// manager administrator account. 
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
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/AssociateAdminAccount">REST API Reference for AssociateAdminAccount Operation</seealso>
        public virtual AssociateAdminAccountResponse AssociateAdminAccount(AssociateAdminAccountRequest request)
        {
            var marshaller = AssociateAdminAccountRequestMarshaller.Instance;
            var unmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateAdminAccountRequest,AssociateAdminAccountResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AssociateAdminAccountRequestMarshaller.Instance;
            var unmarshaller = AssociateAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateAdminAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeleteNotificationChannel">REST API Reference for DeleteNotificationChannel Operation</seealso>
        public virtual DeleteNotificationChannelResponse DeleteNotificationChannel(DeleteNotificationChannelRequest request)
        {
            var marshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationChannelRequest,DeleteNotificationChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteNotificationChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNotificationChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var marshaller = DeletePolicyRequestMarshaller.Instance;
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeletePolicyRequestMarshaller.Instance;
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  DisassociateAdminAccount

        /// <summary>
        /// Disassociates the account that has been set as the AWS Firewall Manager administrator
        /// account. You will need to submit an <code>AssociateAdminAccount</code> request to
        /// set a new account as the AWS Firewall administrator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAdminAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateAdminAccount service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/DisassociateAdminAccount">REST API Reference for DisassociateAdminAccount Operation</seealso>
        public virtual DisassociateAdminAccountResponse DisassociateAdminAccount(DisassociateAdminAccountRequest request)
        {
            var marshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateAdminAccountRequest,DisassociateAdminAccountResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DisassociateAdminAccountRequestMarshaller.Instance;
            var unmarshaller = DisassociateAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateAdminAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetAdminAccount">REST API Reference for GetAdminAccount Operation</seealso>
        public virtual GetAdminAccountResponse GetAdminAccount(GetAdminAccountRequest request)
        {
            var marshaller = GetAdminAccountRequestMarshaller.Instance;
            var unmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return Invoke<GetAdminAccountRequest,GetAdminAccountResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetAdminAccountRequestMarshaller.Instance;
            var unmarshaller = GetAdminAccountResponseUnmarshaller.Instance;

            return BeginInvoke<GetAdminAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  GetComplianceDetail

        /// <summary>
        /// Returns detailed compliance information about the specified member account. Details
        /// include resources that are in and out of compliance with the specified policy. Resources
        /// are considered non-compliant if the specified policy has not been applied to them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetail service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetail service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetComplianceDetail">REST API Reference for GetComplianceDetail Operation</seealso>
        public virtual GetComplianceDetailResponse GetComplianceDetail(GetComplianceDetailRequest request)
        {
            var marshaller = GetComplianceDetailRequestMarshaller.Instance;
            var unmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailRequest,GetComplianceDetailResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetComplianceDetailRequestMarshaller.Instance;
            var unmarshaller = GetComplianceDetailResponseUnmarshaller.Instance;

            return BeginInvoke<GetComplianceDetailRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Returns information about the Amazon Simple Notification Service (SNS) topic that
        /// is used to record AWS Firewall Manager SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the GetNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetNotificationChannel">REST API Reference for GetNotificationChannel Operation</seealso>
        public virtual GetNotificationChannelResponse GetNotificationChannel(GetNotificationChannelRequest request)
        {
            var marshaller = GetNotificationChannelRequestMarshaller.Instance;
            var unmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<GetNotificationChannelRequest,GetNotificationChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetNotificationChannelRequestMarshaller.Instance;
            var unmarshaller = GetNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke<GetNotificationChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var marshaller = GetPolicyRequestMarshaller.Instance;
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyRequest,GetPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetPolicyRequestMarshaller.Instance;
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  ListComplianceStatus

        /// <summary>
        /// Returns an array of <code>PolicyComplianceStatus</code> objects in the response. Use
        /// <code>PolicyComplianceStatus</code> to get a summary of which member accounts are
        /// protected by the specified policy.
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
            var marshaller = ListComplianceStatusRequestMarshaller.Instance;
            var unmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return Invoke<ListComplianceStatusRequest,ListComplianceStatusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListComplianceStatusRequestMarshaller.Instance;
            var unmarshaller = ListComplianceStatusResponseUnmarshaller.Instance;

            return BeginInvoke<ListComplianceStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  ListPolicies

        /// <summary>
        /// Returns an array of <code>PolicySummary</code> objects in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.LimitExceededException">
        /// The operation exceeds a resource limit, for example, the maximum number of <code>policy</code>
        /// objects that you can create for an AWS account. For more information, see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/fms-limits.html">Firewall
        /// Manager Limits</a> in the <i>AWS WAF Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var marshaller = ListPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesRequest,ListPoliciesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  PutNotificationChannel

        /// <summary>
        /// Designates the IAM role and Amazon Simple Notification Service (SNS) topic that AWS
        /// Firewall Manager uses to record SNS logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationChannel service method.</param>
        /// 
        /// <returns>The response from the PutNotificationChannel service method, as returned by FMS.</returns>
        /// <exception cref="Amazon.FMS.Model.InternalErrorException">
        /// The operation failed because of a system problem, even though the request was valid.
        /// Retry your request.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.InvalidOperationException">
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutNotificationChannel">REST API Reference for PutNotificationChannel Operation</seealso>
        public virtual PutNotificationChannelResponse PutNotificationChannel(PutNotificationChannelRequest request)
        {
            var marshaller = PutNotificationChannelRequestMarshaller.Instance;
            var unmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return Invoke<PutNotificationChannelRequest,PutNotificationChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutNotificationChannelRequestMarshaller.Instance;
            var unmarshaller = PutNotificationChannelResponseUnmarshaller.Instance;

            return BeginInvoke<PutNotificationChannelRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The operation failed because there was nothing to do. For example, you might have
        /// submitted an <code>AssociateAdminAccount</code> request, but the account ID that you
        /// submitted was already set as the AWS Firewall Manager administrator.
        /// </exception>
        /// <exception cref="Amazon.FMS.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fms-2018-01-01/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        public virtual PutPolicyResponse PutPolicy(PutPolicyRequest request)
        {
            var marshaller = PutPolicyRequestMarshaller.Instance;
            var unmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPolicyRequest,PutPolicyResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutPolicyRequestMarshaller.Instance;
            var unmarshaller = PutPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
    }
}