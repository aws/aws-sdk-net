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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Chime.Model;
using Amazon.Chime.Model.Internal.MarshallTransformations;
using Amazon.Chime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Chime
{
    /// <summary>
    /// Implementation for accessing Chime
    ///
    /// The Amazon Chime API (application programming interface) is designed for developers
    /// to perform key tasks, such as creating and managing Amazon Chime accounts, users,
    /// and Voice Connectors. This guide provides detailed information about the Amazon Chime
    /// API, including operations, types, inputs and outputs, and error codes. It also includes
    /// some server-side API actions to use with the Amazon Chime SDK. For more information
    /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
    /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can use an AWS SDK, the AWS Command Line Interface (AWS CLI), or the REST API
    /// to make API calls. We recommend using an AWS SDK or the AWS CLI. Each API operation
    /// includes links to information about using it with a language-specific AWS SDK or the
    /// AWS CLI.
    /// </para>
    ///  <dl> <dt>Using an AWS SDK</dt> <dd> 
    /// <para>
    /// You don't need to write code to calculate a signature for request authentication.
    /// The SDK clients authenticate your requests by using access keys that you provide.
    /// For more information about AWS SDKs, see the <a href="http://aws.amazon.com/developer/">AWS
    /// Developer Center</a>.
    /// </para>
    ///  </dd> <dt>Using the AWS CLI</dt> <dd> 
    /// <para>
    /// Use your access keys with the AWS CLI to make API calls. For information about setting
    /// up the AWS CLI, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/installing.html">Installing
    /// the AWS Command Line Interface</a> in the <i>AWS Command Line Interface User Guide</i>.
    /// For a list of available Amazon Chime commands, see the <a href="https://docs.aws.amazon.com/cli/latest/reference/chime/index.html">Amazon
    /// Chime commands</a> in the <i>AWS CLI Command Reference</i>.
    /// </para>
    ///  </dd> <dt>Using REST</dt> <dd> 
    /// <para>
    /// If you use REST to make API calls, you must authenticate your request by providing
    /// a signature. Amazon Chime supports Signature Version 4. For more information, see
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// When making REST API calls, use the service name <code>chime</code> and REST endpoint
    /// <code>https://service.chime.aws.amazon.com</code>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// Administrative permissions are controlled using AWS Identity and Access Management
    /// (IAM). For more information, see <a href="https://docs.aws.amazon.com/chime/latest/ag/security-iam.html">Identity
    /// and Access Management for Amazon Chime</a> in the <i>Amazon Chime Administration Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonChimeClient : AmazonServiceClient, IAmazonChime
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeClient with the credentials loaded from the application's
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
        public AmazonChimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeClient with the credentials loaded from the application's
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
        public AmazonChimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(AmazonChimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Credentials and an
        /// AmazonChimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(AWSCredentials credentials, AmazonChimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeClient Configuration Object</param>
        public AmazonChimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeConfig clientConfig)
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


        #region  AssociatePhoneNumbersWithVoiceConnector

        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorResponse AssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumbersWithVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnector(AssociatePhoneNumbersWithVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnector.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnector">REST API Reference for AssociatePhoneNumbersWithVoiceConnector Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorResponse EndAssociatePhoneNumbersWithVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePhoneNumbersWithVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociatePhoneNumbersWithVoiceConnectorGroup

        /// <summary>
        /// Associates phone numbers with the specified Amazon Chime Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the AssociatePhoneNumbersWithVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorGroupResponse AssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumbersWithVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumbersWithVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumbersWithVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginAssociatePhoneNumbersWithVoiceConnectorGroup(AssociatePhoneNumbersWithVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumbersWithVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumbersWithVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumbersWithVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumbersWithVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumbersWithVoiceConnectorGroup">REST API Reference for AssociatePhoneNumbersWithVoiceConnectorGroup Operation</seealso>
        public virtual AssociatePhoneNumbersWithVoiceConnectorGroupResponse EndAssociatePhoneNumbersWithVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePhoneNumbersWithVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociatePhoneNumberWithUser

        /// <summary>
        /// Associates a phone number with the specified Amazon Chime user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberWithUser service method.</param>
        /// 
        /// <returns>The response from the AssociatePhoneNumberWithUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumberWithUser">REST API Reference for AssociatePhoneNumberWithUser Operation</seealso>
        public virtual AssociatePhoneNumberWithUserResponse AssociatePhoneNumberWithUser(AssociatePhoneNumberWithUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumberWithUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumberWithUserResponseUnmarshaller.Instance;

            return Invoke<AssociatePhoneNumberWithUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePhoneNumberWithUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePhoneNumberWithUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePhoneNumberWithUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumberWithUser">REST API Reference for AssociatePhoneNumberWithUser Operation</seealso>
        public virtual IAsyncResult BeginAssociatePhoneNumberWithUser(AssociatePhoneNumberWithUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociatePhoneNumberWithUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePhoneNumberWithUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePhoneNumberWithUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePhoneNumberWithUser.</param>
        /// 
        /// <returns>Returns a  AssociatePhoneNumberWithUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociatePhoneNumberWithUser">REST API Reference for AssociatePhoneNumberWithUser Operation</seealso>
        public virtual AssociatePhoneNumberWithUserResponse EndAssociatePhoneNumberWithUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePhoneNumberWithUserResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSigninDelegateGroupsWithAccount

        /// <summary>
        /// Associates the specified sign-in delegate groups with the specified Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSigninDelegateGroupsWithAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateSigninDelegateGroupsWithAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociateSigninDelegateGroupsWithAccount">REST API Reference for AssociateSigninDelegateGroupsWithAccount Operation</seealso>
        public virtual AssociateSigninDelegateGroupsWithAccountResponse AssociateSigninDelegateGroupsWithAccount(AssociateSigninDelegateGroupsWithAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSigninDelegateGroupsWithAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSigninDelegateGroupsWithAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateSigninDelegateGroupsWithAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSigninDelegateGroupsWithAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSigninDelegateGroupsWithAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSigninDelegateGroupsWithAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociateSigninDelegateGroupsWithAccount">REST API Reference for AssociateSigninDelegateGroupsWithAccount Operation</seealso>
        public virtual IAsyncResult BeginAssociateSigninDelegateGroupsWithAccount(AssociateSigninDelegateGroupsWithAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSigninDelegateGroupsWithAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSigninDelegateGroupsWithAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSigninDelegateGroupsWithAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSigninDelegateGroupsWithAccount.</param>
        /// 
        /// <returns>Returns a  AssociateSigninDelegateGroupsWithAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/AssociateSigninDelegateGroupsWithAccount">REST API Reference for AssociateSigninDelegateGroupsWithAccount Operation</seealso>
        public virtual AssociateSigninDelegateGroupsWithAccountResponse EndAssociateSigninDelegateGroupsWithAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSigninDelegateGroupsWithAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateAttendee

        /// <summary>
        /// Creates up to 100 new attendees for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateAttendee service method.</param>
        /// 
        /// <returns>The response from the BatchCreateAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        public virtual BatchCreateAttendeeResponse BatchCreateAttendee(BatchCreateAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateAttendeeResponseUnmarshaller.Instance;

            return Invoke<BatchCreateAttendeeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateAttendee(BatchCreateAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateAttendee.</param>
        /// 
        /// <returns>Returns a  BatchCreateAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateAttendee">REST API Reference for BatchCreateAttendee Operation</seealso>
        public virtual BatchCreateAttendeeResponse EndBatchCreateAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateAttendeeResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchCreateRoomMembership

        /// <summary>
        /// Adds up to 50 members to a chat room in an Amazon Chime Enterprise account. Members
        /// can be either users or bots. The member role designates whether the member is a chat
        /// room administrator or a general chat room member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRoomMembership service method.</param>
        /// 
        /// <returns>The response from the BatchCreateRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateRoomMembership">REST API Reference for BatchCreateRoomMembership Operation</seealso>
        public virtual BatchCreateRoomMembershipResponse BatchCreateRoomMembership(BatchCreateRoomMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateRoomMembershipResponseUnmarshaller.Instance;

            return Invoke<BatchCreateRoomMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateRoomMembership">REST API Reference for BatchCreateRoomMembership Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateRoomMembership(BatchCreateRoomMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateRoomMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateRoomMembership.</param>
        /// 
        /// <returns>Returns a  BatchCreateRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchCreateRoomMembership">REST API Reference for BatchCreateRoomMembership Operation</seealso>
        public virtual BatchCreateRoomMembershipResponse EndBatchCreateRoomMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateRoomMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDeletePhoneNumber

        /// <summary>
        /// Moves phone numbers into the <b>Deletion queue</b>. Phone numbers must be disassociated
        /// from any users or Amazon Chime Voice Connectors before they can be deleted.
        /// 
        ///  
        /// <para>
        /// Phone numbers remain in the <b>Deletion queue</b> for 7 days before they are deleted
        /// permanently.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the BatchDeletePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        public virtual BatchDeletePhoneNumberResponse BatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<BatchDeletePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginBatchDeletePhoneNumber(BatchDeletePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeletePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchDeletePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchDeletePhoneNumber">REST API Reference for BatchDeletePhoneNumber Operation</seealso>
        public virtual BatchDeletePhoneNumberResponse EndBatchDeletePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeletePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchSuspendUser

        /// <summary>
        /// Suspends up to 50 users from a <code>Team</code> or <code>EnterpriseLWA</code> Amazon
        /// Chime account. For more information about different account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// 
        ///  
        /// <para>
        /// Users suspended from a <code>Team</code> account are disassociated from the account,
        /// but they can continue to use Amazon Chime as free users. To remove the suspension
        /// from suspended <code>Team</code> account users, invite them to the <code>Team</code>
        /// account again. You can use the <a>InviteUsers</a> action to do so.
        /// </para>
        ///  
        /// <para>
        /// Users suspended from an <code>EnterpriseLWA</code> account are immediately signed
        /// out of Amazon Chime and can no longer sign in. To remove the suspension from suspended
        /// <code>EnterpriseLWA</code> account users, use the <a>BatchUnsuspendUser</a> action.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To sign out users without suspending them, use the <a>LogoutUser</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchSuspendUser service method.</param>
        /// 
        /// <returns>The response from the BatchSuspendUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        public virtual BatchSuspendUserResponse BatchSuspendUser(BatchSuspendUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchSuspendUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchSuspendUserResponseUnmarshaller.Instance;

            return Invoke<BatchSuspendUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchSuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchSuspendUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchSuspendUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        public virtual IAsyncResult BeginBatchSuspendUser(BatchSuspendUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchSuspendUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchSuspendUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchSuspendUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchSuspendUser.</param>
        /// 
        /// <returns>Returns a  BatchSuspendUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchSuspendUser">REST API Reference for BatchSuspendUser Operation</seealso>
        public virtual BatchSuspendUserResponse EndBatchSuspendUser(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchSuspendUserResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUnsuspendUser

        /// <summary>
        /// Removes the suspension from up to 50 previously suspended users for the specified
        /// Amazon Chime <code>EnterpriseLWA</code> account. Only users on <code>EnterpriseLWA</code>
        /// accounts can be unsuspended using this action. For more information about different
        /// account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// 
        ///  
        /// <para>
        /// Previously suspended users who are unsuspended using this action are returned to <code>Registered</code>
        /// status. Users who are not previously suspended are ignored.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUnsuspendUser service method.</param>
        /// 
        /// <returns>The response from the BatchUnsuspendUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        public virtual BatchUnsuspendUserResponse BatchUnsuspendUser(BatchUnsuspendUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUnsuspendUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUnsuspendUserResponseUnmarshaller.Instance;

            return Invoke<BatchUnsuspendUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUnsuspendUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUnsuspendUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUnsuspendUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        public virtual IAsyncResult BeginBatchUnsuspendUser(BatchUnsuspendUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUnsuspendUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUnsuspendUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUnsuspendUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUnsuspendUser.</param>
        /// 
        /// <returns>Returns a  BatchUnsuspendUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUnsuspendUser">REST API Reference for BatchUnsuspendUser Operation</seealso>
        public virtual BatchUnsuspendUserResponse EndBatchUnsuspendUser(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUnsuspendUserResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdatePhoneNumber

        /// <summary>
        /// Updates phone number product types or calling names. You can update one attribute
        /// at a time for each <code>UpdatePhoneNumberRequestItem</code>. For example, you can
        /// update either the product type or the calling name.
        /// 
        ///  
        /// <para>
        /// For product types, choose from Amazon Chime Business Calling and Amazon Chime Voice
        /// Connector. For toll-free numbers, you must use the Amazon Chime Voice Connector product
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Updates to outbound calling names can take up to 72 hours to complete. Pending updates
        /// to outbound calling names must be complete before you can request another update.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the BatchUpdatePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        public virtual BatchUpdatePhoneNumberResponse BatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<BatchUpdatePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdatePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdatePhoneNumber(BatchUpdatePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdatePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  BatchUpdatePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdatePhoneNumber">REST API Reference for BatchUpdatePhoneNumber Operation</seealso>
        public virtual BatchUpdatePhoneNumberResponse EndBatchUpdatePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdatePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateUser

        /// <summary>
        /// Updates user details within the <a>UpdateUserRequestItem</a> object for up to 20 users
        /// for the specified Amazon Chime account. Currently, only <code>LicenseType</code> updates
        /// are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateUser service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        public virtual BatchUpdateUserResponse BatchUpdateUser(BatchUpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateUserResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateUser(BatchUpdateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchUpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateUser.</param>
        /// 
        /// <returns>Returns a  BatchUpdateUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/BatchUpdateUser">REST API Reference for BatchUpdateUser Operation</seealso>
        public virtual BatchUpdateUserResponse EndBatchUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccount

        /// <summary>
        /// Creates an Amazon Chime account under the administrator's AWS account. Only <code>Team</code>
        /// account types are currently supported for this action. For more information about
        /// different account types, see <a href="https://docs.aws.amazon.com/chime/latest/ag/manage-chime-account.html">Managing
        /// Your Amazon Chime Accounts</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount service method.</param>
        /// 
        /// <returns>The response from the CreateAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public virtual CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return Invoke<CreateAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public virtual IAsyncResult BeginCreateAccount(CreateAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccount.</param>
        /// 
        /// <returns>Returns a  CreateAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public virtual CreateAccountResponse EndCreateAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAppInstance

        /// <summary>
        /// Creates an Amazon Chime Messaging SDK <code>AppInstance</code> under an AWS Account.
        /// Only Messaging SDK customers use this API. <code>CreateAppInstance</code> supports
        /// <code>idempotency</code> behavior as described in the AWS API Standard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        public virtual CreateAppInstanceResponse CreateAppInstance(CreateAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateAppInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateAppInstance(CreateAppInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstance.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstance">REST API Reference for CreateAppInstance Operation</seealso>
        public virtual CreateAppInstanceResponse EndCreateAppInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAppInstanceAdmin

        /// <summary>
        /// Promotes an <code>AppInstanceUser</code> to an <code>AppInstanceAdmin</code>. The
        /// promoted user can perform the following actions. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChannelModerator</code> actions across all channels in the app instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DeleteChannelMessage</code> actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only an <code>AppInstanceUser</code> can be promoted to an <code>AppInstanceAdmin</code>
        /// role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceAdmin service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        public virtual CreateAppInstanceAdminResponse CreateAppInstanceAdmin(CreateAppInstanceAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceAdminResponseUnmarshaller.Instance;

            return Invoke<CreateAppInstanceAdminResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceAdmin operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        public virtual IAsyncResult BeginCreateAppInstanceAdmin(CreateAppInstanceAdminRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceAdminResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceAdminResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceAdmin">REST API Reference for CreateAppInstanceAdmin Operation</seealso>
        public virtual CreateAppInstanceAdminResponse EndCreateAppInstanceAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppInstanceAdminResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAppInstanceUser

        /// <summary>
        /// Creates a user under an Amazon Chime <code>AppInstance</code>. The request consists
        /// of a unique <code>appInstanceUserId</code> and <code>Name</code> for that user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the CreateAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        public virtual CreateAppInstanceUserResponse CreateAppInstanceUser(CreateAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<CreateAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginCreateAppInstanceUser(CreateAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  CreateAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAppInstanceUser">REST API Reference for CreateAppInstanceUser Operation</seealso>
        public virtual CreateAppInstanceUserResponse EndCreateAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAttendee

        /// <summary>
        /// Creates a new attendee for an active Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAttendee service method.</param>
        /// 
        /// <returns>The response from the CreateAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        public virtual CreateAttendeeResponse CreateAttendee(CreateAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAttendeeResponseUnmarshaller.Instance;

            return Invoke<CreateAttendeeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        public virtual IAsyncResult BeginCreateAttendee(CreateAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAttendee.</param>
        /// 
        /// <returns>Returns a  CreateAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateAttendee">REST API Reference for CreateAttendee Operation</seealso>
        public virtual CreateAttendeeResponse EndCreateAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAttendeeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBot

        /// <summary>
        /// Creates a bot for an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// 
        /// <returns>The response from the CreateBot service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        public virtual CreateBotResponse CreateBot(CreateBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotResponseUnmarshaller.Instance;

            return Invoke<CreateBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBot operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        public virtual IAsyncResult BeginCreateBot(CreateBotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBot.</param>
        /// 
        /// <returns>Returns a  CreateBotResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        public virtual CreateBotResponse EndCreateBot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannel

        /// <summary>
        /// Creates a channel to which you can add users and send messages.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelBan

        /// <summary>
        /// Permanently bans a member from a channel. Moderators can't add banned members to a
        /// channel. To undo a ban, you first have to <code>DeleteChannelBan</code>, and then
        /// <code>CreateChannelMembership</code>. Bans are cleaned up when you delete users or
        /// channels. 
        /// 
        ///  
        /// <para>
        /// If you ban a user who is already part of a channel, that user is automatically kicked
        /// from the channel.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelBan service method.</param>
        /// 
        /// <returns>The response from the CreateChannelBan service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        public virtual CreateChannelBanResponse CreateChannelBan(CreateChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelBanResponseUnmarshaller.Instance;

            return Invoke<CreateChannelBanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelBan operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelBan(CreateChannelBanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelBanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelBan.</param>
        /// 
        /// <returns>Returns a  CreateChannelBanResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        public virtual CreateChannelBanResponse EndCreateChannelBan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelBanResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelMembership

        /// <summary>
        /// Adds a user to a channel. The <code>InvitedBy</code> response field is derived from
        /// the request header. A channel member can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// List messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Send messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Receive messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Edit their own messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leave the channel
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Privacy settings impact this action as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Public Channels: You do not need to be a member to list messages, but you must be
        /// a member to send messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Private Channels: You must be a member to list or send messages.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelMembership service method.</param>
        /// 
        /// <returns>The response from the CreateChannelMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        public virtual CreateChannelMembershipResponse CreateChannelMembership(CreateChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateChannelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelMembership(CreateChannelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelMembership.</param>
        /// 
        /// <returns>Returns a  CreateChannelMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        public virtual CreateChannelMembershipResponse EndCreateChannelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannelModerator

        /// <summary>
        /// Creates a new <code>ChannelModerator</code>. A channel moderator can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add and remove other members of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove other moderators of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove user bans for the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redact messages in the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// List messages in the channel.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelModerator service method.</param>
        /// 
        /// <returns>The response from the CreateChannelModerator service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        public virtual CreateChannelModeratorResponse CreateChannelModerator(CreateChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<CreateChannelModeratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelModerator operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        public virtual IAsyncResult BeginCreateChannelModerator(CreateChannelModeratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelModeratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelModerator.</param>
        /// 
        /// <returns>Returns a  CreateChannelModeratorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        public virtual CreateChannelModeratorResponse EndCreateChannelModerator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelModeratorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMeeting

        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region with no initial
        /// attendees. For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime Developer Guide</i>. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeeting service method.</param>
        /// 
        /// <returns>The response from the CreateMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        public virtual CreateMeetingResponse CreateMeeting(CreateMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingResponseUnmarshaller.Instance;

            return Invoke<CreateMeetingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        public virtual IAsyncResult BeginCreateMeeting(CreateMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeeting.</param>
        /// 
        /// <returns>Returns a  CreateMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeeting">REST API Reference for CreateMeeting Operation</seealso>
        public virtual CreateMeetingResponse EndCreateMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMeetingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMeetingDialOut

        /// <summary>
        /// Uses the join token and call metadata in a meeting request (From number, To number,
        /// and so forth) to initiate an outbound call to a public switched telephone network
        /// (PSTN) and joins them into Chime meeting. Also ensures that the From number belongs
        /// to the customer.
        /// 
        ///  
        /// <para>
        /// To play welcome audio or implement an interactive voice response (IVR), use the <code>CreateSipMediaApplicationCall</code>
        /// API with the corresponding SIP media application ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingDialOut service method.</param>
        /// 
        /// <returns>The response from the CreateMeetingDialOut service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingDialOut">REST API Reference for CreateMeetingDialOut Operation</seealso>
        public virtual CreateMeetingDialOutResponse CreateMeetingDialOut(CreateMeetingDialOutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingDialOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingDialOutResponseUnmarshaller.Instance;

            return Invoke<CreateMeetingDialOutResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeetingDialOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingDialOut operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeetingDialOut
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingDialOut">REST API Reference for CreateMeetingDialOut Operation</seealso>
        public virtual IAsyncResult BeginCreateMeetingDialOut(CreateMeetingDialOutRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingDialOutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingDialOutResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeetingDialOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeetingDialOut.</param>
        /// 
        /// <returns>Returns a  CreateMeetingDialOutResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingDialOut">REST API Reference for CreateMeetingDialOut Operation</seealso>
        public virtual CreateMeetingDialOutResponse EndCreateMeetingDialOut(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMeetingDialOutResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMeetingWithAttendees

        /// <summary>
        /// Creates a new Amazon Chime SDK meeting in the specified media Region, with attendees.
        /// For more information about specifying media Regions, see <a href="https://docs.aws.amazon.com/chime/latest/dg/chime-sdk-meetings-regions.html">Amazon
        /// Chime SDK Media Regions</a> in the <i>Amazon Chime Developer Guide</i>. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingWithAttendees service method.</param>
        /// 
        /// <returns>The response from the CreateMeetingWithAttendees service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        public virtual CreateMeetingWithAttendeesResponse CreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingWithAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingWithAttendeesResponseUnmarshaller.Instance;

            return Invoke<CreateMeetingWithAttendeesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMeetingWithAttendees operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMeetingWithAttendees operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMeetingWithAttendees
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        public virtual IAsyncResult BeginCreateMeetingWithAttendees(CreateMeetingWithAttendeesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMeetingWithAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMeetingWithAttendeesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMeetingWithAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMeetingWithAttendees.</param>
        /// 
        /// <returns>Returns a  CreateMeetingWithAttendeesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateMeetingWithAttendees">REST API Reference for CreateMeetingWithAttendees Operation</seealso>
        public virtual CreateMeetingWithAttendeesResponse EndCreateMeetingWithAttendees(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMeetingWithAttendeesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePhoneNumberOrder

        /// <summary>
        /// Creates an order for phone numbers to be provisioned. Choose from Amazon Chime Business
        /// Calling and Amazon Chime Voice Connector product types. For toll-free numbers, you
        /// must use the Amazon Chime Voice Connector product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder service method.</param>
        /// 
        /// <returns>The response from the CreatePhoneNumberOrder service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        public virtual CreatePhoneNumberOrderResponse CreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePhoneNumberOrderResponseUnmarshaller.Instance;

            return Invoke<CreatePhoneNumberOrderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePhoneNumberOrder operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        public virtual IAsyncResult BeginCreatePhoneNumberOrder(CreatePhoneNumberOrderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePhoneNumberOrderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  CreatePhoneNumberOrderResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreatePhoneNumberOrder">REST API Reference for CreatePhoneNumberOrder Operation</seealso>
        public virtual CreatePhoneNumberOrderResponse EndCreatePhoneNumberOrder(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePhoneNumberOrderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProxySession

        /// <summary>
        /// Creates a proxy session on the specified Amazon Chime Voice Connector for the specified
        /// participant phone numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession service method.</param>
        /// 
        /// <returns>The response from the CreateProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        public virtual CreateProxySessionResponse CreateProxySession(CreateProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxySessionResponseUnmarshaller.Instance;

            return Invoke<CreateProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        public virtual IAsyncResult BeginCreateProxySession(CreateProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxySession.</param>
        /// 
        /// <returns>Returns a  CreateProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateProxySession">REST API Reference for CreateProxySession Operation</seealso>
        public virtual CreateProxySessionResponse EndCreateProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoom

        /// <summary>
        /// Creates a chat room for the specified Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom service method.</param>
        /// 
        /// <returns>The response from the CreateRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual CreateRoomResponse CreateRoom(CreateRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return Invoke<CreateRoomResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual IAsyncResult BeginCreateRoom(CreateRoomRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoom.</param>
        /// 
        /// <returns>Returns a  CreateRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoom">REST API Reference for CreateRoom Operation</seealso>
        public virtual CreateRoomResponse EndCreateRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoomMembership

        /// <summary>
        /// Adds a member to a chat room in an Amazon Chime Enterprise account. A member can be
        /// either a user or a bot. The member role designates whether the member is a chat room
        /// administrator or a general chat room member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoomMembership service method.</param>
        /// 
        /// <returns>The response from the CreateRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoomMembership">REST API Reference for CreateRoomMembership Operation</seealso>
        public virtual CreateRoomMembershipResponse CreateRoomMembership(CreateRoomMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateRoomMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoomMembership">REST API Reference for CreateRoomMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateRoomMembership(CreateRoomMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoomMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoomMembership.</param>
        /// 
        /// <returns>Returns a  CreateRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateRoomMembership">REST API Reference for CreateRoomMembership Operation</seealso>
        public virtual CreateRoomMembershipResponse EndCreateRoomMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRoomMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSipMediaApplication

        /// <summary>
        /// Creates a SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the CreateSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        public virtual CreateSipMediaApplicationResponse CreateSipMediaApplication(CreateSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginCreateSipMediaApplication(CreateSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplication">REST API Reference for CreateSipMediaApplication Operation</seealso>
        public virtual CreateSipMediaApplicationResponse EndCreateSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSipMediaApplicationCall

        /// <summary>
        /// Creates an outbound call to a phone number from the phone number specified in the
        /// request, and it invokes the endpoint of the specified <code>sipMediaApplicationId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall service method.</param>
        /// 
        /// <returns>The response from the CreateSipMediaApplicationCall service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        public virtual CreateSipMediaApplicationCallResponse CreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return Invoke<CreateSipMediaApplicationCallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipMediaApplicationCall operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipMediaApplicationCall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        public virtual IAsyncResult BeginCreateSipMediaApplicationCall(CreateSipMediaApplicationCallRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipMediaApplicationCallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipMediaApplicationCallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipMediaApplicationCall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipMediaApplicationCall.</param>
        /// 
        /// <returns>Returns a  CreateSipMediaApplicationCallResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipMediaApplicationCall">REST API Reference for CreateSipMediaApplicationCall Operation</seealso>
        public virtual CreateSipMediaApplicationCallResponse EndCreateSipMediaApplicationCall(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSipMediaApplicationCallResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSipRule

        /// <summary>
        /// Creates a SIP rule which can be used to run a SIP media application as a target for
        /// a specific trigger type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule service method.</param>
        /// 
        /// <returns>The response from the CreateSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        public virtual CreateSipRuleResponse CreateSipRule(CreateSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        public virtual IAsyncResult BeginCreateSipRule(CreateSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSipRule.</param>
        /// 
        /// <returns>Returns a  CreateSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateSipRule">REST API Reference for CreateSipRule Operation</seealso>
        public virtual CreateSipRuleResponse EndCreateSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a user under the specified Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVoiceConnector

        /// <summary>
        /// Creates an Amazon Chime Voice Connector under the administrator's AWS account. You
        /// can choose to create an Amazon Chime Voice Connector in a specific AWS Region.
        /// 
        ///  
        /// <para>
        /// Enabling <a>CreateVoiceConnectorRequest$RequireEncryption</a> configures your Amazon
        /// Chime Voice Connector to use TLS transport for SIP signaling and Secure RTP (SRTP)
        /// for media. Inbound calls use TLS transport, and unencrypted outbound calls are blocked.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        public virtual CreateVoiceConnectorResponse CreateVoiceConnector(CreateVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginCreateVoiceConnector(CreateVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnector">REST API Reference for CreateVoiceConnector Operation</seealso>
        public virtual CreateVoiceConnectorResponse EndCreateVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVoiceConnectorGroup

        /// <summary>
        /// Creates an Amazon Chime Voice Connector group under the administrator's AWS account.
        /// You can associate Amazon Chime Voice Connectors with the Amazon Chime Voice Connector
        /// group by including <code>VoiceConnectorItems</code> in the request.
        /// 
        ///  
        /// <para>
        /// You can include Amazon Chime Voice Connectors from different AWS Regions in your group.
        /// This creates a fault tolerant mechanism for fallback in case of availability events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        public virtual CreateVoiceConnectorGroupResponse CreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateVoiceConnectorGroup(CreateVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  CreateVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/CreateVoiceConnectorGroup">REST API Reference for CreateVoiceConnectorGroup Operation</seealso>
        public virtual CreateVoiceConnectorGroupResponse EndCreateVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccount

        /// <summary>
        /// Deletes the specified Amazon Chime account. You must suspend all users before deleting
        /// a <code>Team</code> account. You can use the <a>BatchSuspendUser</a> action to do
        /// so.
        /// 
        ///  
        /// <para>
        /// For <code>EnterpriseLWA</code> and <code>EnterpriseAD</code> accounts, you must release
        /// the claimed domains for your Amazon Chime account before deletion. As soon as you
        /// release the domain, all users under that account are suspended.
        /// </para>
        ///  
        /// <para>
        /// Deleted accounts appear in your <code>Disabled</code> accounts list for 90 days. To
        /// restore a deleted account from your <code>Disabled</code> accounts list, you must
        /// contact AWS Support.
        /// </para>
        ///  
        /// <para>
        /// After 90 days, deleted accounts are permanently removed from your <code>Disabled</code>
        /// accounts list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccount service method.</param>
        /// 
        /// <returns>The response from the DeleteAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnprocessableEntityException">
        /// The request was well-formed but was unable to be followed due to semantic errors.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        public virtual DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccount(DeleteAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccount.</param>
        /// 
        /// <returns>Returns a  DeleteAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAccount">REST API Reference for DeleteAccount Operation</seealso>
        public virtual DeleteAccountResponse EndDeleteAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppInstance

        /// <summary>
        /// Deletes an <code>AppInstance</code> and all associated data asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        public virtual DeleteAppInstanceResponse DeleteAppInstance(DeleteAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppInstance(DeleteAppInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstance.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstance">REST API Reference for DeleteAppInstance Operation</seealso>
        public virtual DeleteAppInstanceResponse EndDeleteAppInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppInstanceAdmin

        /// <summary>
        /// Demotes an <code>AppInstanceAdmin</code> to an <code>AppInstanceUser</code>. This
        /// action does not delete the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceAdmin service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        public virtual DeleteAppInstanceAdminResponse DeleteAppInstanceAdmin(DeleteAppInstanceAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceAdminResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceAdminResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceAdmin operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppInstanceAdmin(DeleteAppInstanceAdminRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceAdminResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceAdminResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceAdmin">REST API Reference for DeleteAppInstanceAdmin Operation</seealso>
        public virtual DeleteAppInstanceAdminResponse EndDeleteAppInstanceAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppInstanceAdminResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppInstanceStreamingConfigurations

        /// <summary>
        /// Deletes the streaming configurations of an app instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceStreamingConfigurations service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceStreamingConfigurations service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceStreamingConfigurations">REST API Reference for DeleteAppInstanceStreamingConfigurations Operation</seealso>
        public virtual DeleteAppInstanceStreamingConfigurationsResponse DeleteAppInstanceStreamingConfigurations(DeleteAppInstanceStreamingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceStreamingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceStreamingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceStreamingConfigurations operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceStreamingConfigurations">REST API Reference for DeleteAppInstanceStreamingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppInstanceStreamingConfigurations(DeleteAppInstanceStreamingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceStreamingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceStreamingConfigurationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceStreamingConfigurations">REST API Reference for DeleteAppInstanceStreamingConfigurations Operation</seealso>
        public virtual DeleteAppInstanceStreamingConfigurationsResponse EndDeleteAppInstanceStreamingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppInstanceStreamingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAppInstanceUser

        /// <summary>
        /// Deletes an <code>AppInstanceUser</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DeleteAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        public virtual DeleteAppInstanceUserResponse DeleteAppInstanceUser(DeleteAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DeleteAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteAppInstanceUser(DeleteAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DeleteAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAppInstanceUser">REST API Reference for DeleteAppInstanceUser Operation</seealso>
        public virtual DeleteAppInstanceUserResponse EndDeleteAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAttendee

        /// <summary>
        /// Deletes an attendee from the specified Amazon Chime SDK meeting and deletes their
        /// <code>JoinToken</code>. Attendees are automatically deleted when a Amazon Chime SDK
        /// meeting is deleted. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttendee service method.</param>
        /// 
        /// <returns>The response from the DeleteAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        public virtual DeleteAttendeeResponse DeleteAttendee(DeleteAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttendeeResponseUnmarshaller.Instance;

            return Invoke<DeleteAttendeeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        public virtual IAsyncResult BeginDeleteAttendee(DeleteAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttendee.</param>
        /// 
        /// <returns>Returns a  DeleteAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteAttendee">REST API Reference for DeleteAttendee Operation</seealso>
        public virtual DeleteAttendeeResponse EndDeleteAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAttendeeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannel

        /// <summary>
        /// Immediately makes a channel and its memberships inaccessible and marks them for deletion.
        /// This is an irreversible process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelBan

        /// <summary>
        /// Removes a user from a channel's ban list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelBan service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelBan service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        public virtual DeleteChannelBanResponse DeleteChannelBan(DeleteChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelBanResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelBanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelBan operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelBan(DeleteChannelBanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelBanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelBan.</param>
        /// 
        /// <returns>Returns a  DeleteChannelBanResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        public virtual DeleteChannelBanResponse EndDeleteChannelBan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelBanResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelMembership

        /// <summary>
        /// Removes a member from a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        public virtual DeleteChannelMembershipResponse DeleteChannelMembership(DeleteChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelMembership(DeleteChannelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelMembership.</param>
        /// 
        /// <returns>Returns a  DeleteChannelMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        public virtual DeleteChannelMembershipResponse EndDeleteChannelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelMessage

        /// <summary>
        /// Deletes a channel message. Only admins can perform this action. Deletion makes messages
        /// inaccessible immediately. A background process deletes any revisions created by <code>UpdateChannelMessage</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMessage service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        public virtual DeleteChannelMessageResponse DeleteChannelMessage(DeleteChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMessageResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelMessage(DeleteChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelMessage.</param>
        /// 
        /// <returns>Returns a  DeleteChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        public virtual DeleteChannelMessageResponse EndDeleteChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannelModerator

        /// <summary>
        /// Deletes a channel moderator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelModerator service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelModerator service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        public virtual DeleteChannelModeratorResponse DeleteChannelModerator(DeleteChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelModeratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelModerator operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannelModerator(DeleteChannelModeratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelModeratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelModerator.</param>
        /// 
        /// <returns>Returns a  DeleteChannelModeratorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        public virtual DeleteChannelModeratorResponse EndDeleteChannelModerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelModeratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventsConfiguration

        /// <summary>
        /// Deletes the events configuration that allows a bot to receive outgoing events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEventsConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteEventsConfiguration">REST API Reference for DeleteEventsConfiguration Operation</seealso>
        public virtual DeleteEventsConfigurationResponse DeleteEventsConfiguration(DeleteEventsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEventsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteEventsConfiguration">REST API Reference for DeleteEventsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventsConfiguration(DeleteEventsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEventsConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteEventsConfiguration">REST API Reference for DeleteEventsConfiguration Operation</seealso>
        public virtual DeleteEventsConfigurationResponse EndDeleteEventsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMeeting

        /// <summary>
        /// Deletes the specified Amazon Chime SDK meeting. When a meeting is deleted, its attendees
        /// are also deleted and clients can no longer join it. For more information about the
        /// Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeeting service method.</param>
        /// 
        /// <returns>The response from the DeleteMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        public virtual DeleteMeetingResponse DeleteMeeting(DeleteMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeetingResponseUnmarshaller.Instance;

            return Invoke<DeleteMeetingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        public virtual IAsyncResult BeginDeleteMeeting(DeleteMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMeeting.</param>
        /// 
        /// <returns>Returns a  DeleteMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteMeeting">REST API Reference for DeleteMeeting Operation</seealso>
        public virtual DeleteMeetingResponse EndDeleteMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMeetingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePhoneNumber

        /// <summary>
        /// Moves the specified phone number into the <b>Deletion queue</b>. A phone number must
        /// be disassociated from any users or Amazon Chime Voice Connectors before it can be
        /// deleted.
        /// 
        ///  
        /// <para>
        /// Deleted phone numbers remain in the <b>Deletion queue</b> for 7 days before they are
        /// deleted permanently.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the DeletePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        public virtual DeletePhoneNumberResponse DeletePhoneNumber(DeletePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<DeletePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginDeletePhoneNumber(DeletePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePhoneNumber.</param>
        /// 
        /// <returns>Returns a  DeletePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeletePhoneNumber">REST API Reference for DeletePhoneNumber Operation</seealso>
        public virtual DeletePhoneNumberResponse EndDeletePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProxySession

        /// <summary>
        /// Deletes the specified proxy session from the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession service method.</param>
        /// 
        /// <returns>The response from the DeleteProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        public virtual DeleteProxySessionResponse DeleteProxySession(DeleteProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxySessionResponseUnmarshaller.Instance;

            return Invoke<DeleteProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        public virtual IAsyncResult BeginDeleteProxySession(DeleteProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxySession.</param>
        /// 
        /// <returns>Returns a  DeleteProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteProxySession">REST API Reference for DeleteProxySession Operation</seealso>
        public virtual DeleteProxySessionResponse EndDeleteProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoom

        /// <summary>
        /// Deletes a chat room in an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom service method.</param>
        /// 
        /// <returns>The response from the DeleteRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual DeleteRoomResponse DeleteRoom(DeleteRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoom(DeleteRoomRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoom.</param>
        /// 
        /// <returns>Returns a  DeleteRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoom">REST API Reference for DeleteRoom Operation</seealso>
        public virtual DeleteRoomResponse EndDeleteRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoomMembership

        /// <summary>
        /// Removes a member from a chat room in an Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoomMembership">REST API Reference for DeleteRoomMembership Operation</seealso>
        public virtual DeleteRoomMembershipResponse DeleteRoomMembership(DeleteRoomMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteRoomMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoomMembership">REST API Reference for DeleteRoomMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoomMembership(DeleteRoomMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoomMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoomMembership.</param>
        /// 
        /// <returns>Returns a  DeleteRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteRoomMembership">REST API Reference for DeleteRoomMembership Operation</seealso>
        public virtual DeleteRoomMembershipResponse EndDeleteRoomMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRoomMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSipMediaApplication

        /// <summary>
        /// Deletes a SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        public virtual DeleteSipMediaApplicationResponse DeleteSipMediaApplication(DeleteSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginDeleteSipMediaApplication(DeleteSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  DeleteSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipMediaApplication">REST API Reference for DeleteSipMediaApplication Operation</seealso>
        public virtual DeleteSipMediaApplicationResponse EndDeleteSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSipRule

        /// <summary>
        /// Deletes a SIP rule. You must disable a SIP rule before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule service method.</param>
        /// 
        /// <returns>The response from the DeleteSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        public virtual DeleteSipRuleResponse DeleteSipRule(DeleteSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteSipRule(DeleteSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSipRule.</param>
        /// 
        /// <returns>Returns a  DeleteSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteSipRule">REST API Reference for DeleteSipRule Operation</seealso>
        public virtual DeleteSipRuleResponse EndDeleteSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnector

        /// <summary>
        /// Deletes the specified Amazon Chime Voice Connector. Any phone numbers associated with
        /// the Amazon Chime Voice Connector must be disassociated from it before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        public virtual DeleteVoiceConnectorResponse DeleteVoiceConnector(DeleteVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnector(DeleteVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnector">REST API Reference for DeleteVoiceConnector Operation</seealso>
        public virtual DeleteVoiceConnectorResponse EndDeleteVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorEmergencyCallingConfiguration

        /// <summary>
        /// Deletes the emergency calling configuration details from the specified Amazon Chime
        /// Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorEmergencyCallingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorEmergencyCallingConfigurationResponse DeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorEmergencyCallingConfiguration(DeleteVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorEmergencyCallingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorEmergencyCallingConfiguration">REST API Reference for DeleteVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorEmergencyCallingConfigurationResponse EndDeleteVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorEmergencyCallingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorGroup

        /// <summary>
        /// Deletes the specified Amazon Chime Voice Connector group. Any <code>VoiceConnectorItems</code>
        /// and phone numbers associated with the group must be removed before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        public virtual DeleteVoiceConnectorGroupResponse DeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorGroup(DeleteVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorGroup">REST API Reference for DeleteVoiceConnectorGroup Operation</seealso>
        public virtual DeleteVoiceConnectorGroupResponse EndDeleteVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorOrigination

        /// <summary>
        /// Deletes the origination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to deleting the origination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorOrigination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        public virtual DeleteVoiceConnectorOriginationResponse DeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorOriginationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorOrigination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorOrigination(DeleteVoiceConnectorOriginationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorOriginationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorOrigination">REST API Reference for DeleteVoiceConnectorOrigination Operation</seealso>
        public virtual DeleteVoiceConnectorOriginationResponse EndDeleteVoiceConnectorOrigination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorOriginationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorProxy

        /// <summary>
        /// Deletes the proxy configuration from the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorProxy service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        public virtual DeleteVoiceConnectorProxyResponse DeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorProxy operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorProxy(DeleteVoiceConnectorProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorProxyResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorProxy">REST API Reference for DeleteVoiceConnectorProxy Operation</seealso>
        public virtual DeleteVoiceConnectorProxyResponse EndDeleteVoiceConnectorProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorStreamingConfiguration

        /// <summary>
        /// Deletes the streaming configuration for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorStreamingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorStreamingConfigurationResponse DeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorStreamingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorStreamingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorStreamingConfiguration(DeleteVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorStreamingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorStreamingConfiguration">REST API Reference for DeleteVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual DeleteVoiceConnectorStreamingConfigurationResponse EndDeleteVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorStreamingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorTermination

        /// <summary>
        /// Deletes the termination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to deleting the termination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTermination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationResponse DeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorTerminationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTermination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorTermination(DeleteVoiceConnectorTerminationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTermination">REST API Reference for DeleteVoiceConnectorTermination Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationResponse EndDeleteVoiceConnectorTermination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorTerminationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceConnectorTerminationCredentials

        /// <summary>
        /// Deletes the specified SIP credentials used by your equipment to authenticate during
        /// call termination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceConnectorTerminationCredentials service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationCredentialsResponse DeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceConnectorTerminationCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceConnectorTerminationCredentials operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceConnectorTerminationCredentials(DeleteVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceConnectorTerminationCredentialsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DeleteVoiceConnectorTerminationCredentials">REST API Reference for DeleteVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual DeleteVoiceConnectorTerminationCredentialsResponse EndDeleteVoiceConnectorTerminationCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceConnectorTerminationCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppInstance

        /// <summary>
        /// Returns the full details of an <code>AppInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        public virtual DescribeAppInstanceResponse DescribeAppInstance(DescribeAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppInstance(DescribeAppInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstance.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstance">REST API Reference for DescribeAppInstance Operation</seealso>
        public virtual DescribeAppInstanceResponse EndDescribeAppInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppInstanceAdmin

        /// <summary>
        /// Returns the full details of an <code>AppInstanceAdmin</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceAdmin service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        public virtual DescribeAppInstanceAdminResponse DescribeAppInstanceAdmin(DescribeAppInstanceAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceAdminResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceAdminResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceAdmin operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceAdmin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppInstanceAdmin(DescribeAppInstanceAdminRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceAdminResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceAdmin.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceAdminResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceAdmin">REST API Reference for DescribeAppInstanceAdmin Operation</seealso>
        public virtual DescribeAppInstanceAdminResponse EndDescribeAppInstanceAdmin(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppInstanceAdminResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAppInstanceUser

        /// <summary>
        /// Returns the full details of an <code>AppInstanceUser</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DescribeAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        public virtual DescribeAppInstanceUserResponse DescribeAppInstanceUser(DescribeAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeAppInstanceUser(DescribeAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeAppInstanceUser">REST API Reference for DescribeAppInstanceUser Operation</seealso>
        public virtual DescribeAppInstanceUserResponse EndDescribeAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannel

        /// <summary>
        /// Returns the full details of a channel in an Amazon Chime app instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelBan

        /// <summary>
        /// Returns the full details of a channel ban.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelBan service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelBan service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        public virtual DescribeChannelBanResponse DescribeChannelBan(DescribeChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelBanResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelBanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelBan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelBan operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelBan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelBan(DescribeChannelBanRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelBanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelBan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelBan.</param>
        /// 
        /// <returns>Returns a  DescribeChannelBanResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        public virtual DescribeChannelBanResponse EndDescribeChannelBan(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelBanResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelMembership

        /// <summary>
        /// Returns the full details of a user's channel membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembership service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        public virtual DescribeChannelMembershipResponse DescribeChannelMembership(DescribeChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelMembership(DescribeChannelMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelMembership.</param>
        /// 
        /// <returns>Returns a  DescribeChannelMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        public virtual DescribeChannelMembershipResponse EndDescribeChannelMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelMembershipForAppInstanceUser

        /// <summary>
        /// Returns the details of a channel based on the membership of the <code>AppInstanceUser</code>
        /// specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembershipForAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelMembershipForAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        public virtual DescribeChannelMembershipForAppInstanceUserResponse DescribeChannelMembershipForAppInstanceUser(DescribeChannelMembershipForAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipForAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelMembershipForAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelMembershipForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembershipForAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelMembershipForAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelMembershipForAppInstanceUser(DescribeChannelMembershipForAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipForAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelMembershipForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelMembershipForAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeChannelMembershipForAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        public virtual DescribeChannelMembershipForAppInstanceUserResponse EndDescribeChannelMembershipForAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelMembershipForAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelModeratedByAppInstanceUser

        /// <summary>
        /// Returns the full details of a channel moderated by the specified <code>AppInstanceUser</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModeratedByAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelModeratedByAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        public virtual DescribeChannelModeratedByAppInstanceUserResponse DescribeChannelModeratedByAppInstanceUser(DescribeChannelModeratedByAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelModeratedByAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModeratedByAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelModeratedByAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelModeratedByAppInstanceUser(DescribeChannelModeratedByAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelModeratedByAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  DescribeChannelModeratedByAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        public virtual DescribeChannelModeratedByAppInstanceUserResponse EndDescribeChannelModeratedByAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelModeratedByAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeChannelModerator

        /// <summary>
        /// Returns the full details of a single ChannelModerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModerator service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelModerator service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        public virtual DescribeChannelModeratorResponse DescribeChannelModerator(DescribeChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelModeratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModerator operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelModerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannelModerator(DescribeChannelModeratorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelModerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelModerator.</param>
        /// 
        /// <returns>Returns a  DescribeChannelModeratorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        public virtual DescribeChannelModeratorResponse EndDescribeChannelModerator(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelModeratorResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePhoneNumberFromUser

        /// <summary>
        /// Disassociates the primary provisioned phone number from the specified Amazon Chime
        /// user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberFromUser service method.</param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumberFromUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumberFromUser">REST API Reference for DisassociatePhoneNumberFromUser Operation</seealso>
        public virtual DisassociatePhoneNumberFromUserResponse DisassociatePhoneNumberFromUser(DisassociatePhoneNumberFromUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumberFromUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumberFromUserResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumberFromUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumberFromUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumberFromUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumberFromUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumberFromUser">REST API Reference for DisassociatePhoneNumberFromUser Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePhoneNumberFromUser(DisassociatePhoneNumberFromUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumberFromUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumberFromUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumberFromUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumberFromUser.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumberFromUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumberFromUser">REST API Reference for DisassociatePhoneNumberFromUser Operation</seealso>
        public virtual DisassociatePhoneNumberFromUserResponse EndDisassociatePhoneNumberFromUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePhoneNumberFromUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnector

        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorResponse DisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumbersFromVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnector(DisassociatePhoneNumbersFromVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnector.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnector">REST API Reference for DisassociatePhoneNumbersFromVoiceConnector Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorResponse EndDisassociatePhoneNumbersFromVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePhoneNumbersFromVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociatePhoneNumbersFromVoiceConnectorGroup

        /// <summary>
        /// Disassociates the specified phone numbers from the specified Amazon Chime Voice Connector
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociatePhoneNumbersFromVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorGroupResponse DisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePhoneNumbersFromVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePhoneNumbersFromVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginDisassociatePhoneNumbersFromVoiceConnectorGroup(DisassociatePhoneNumbersFromVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePhoneNumbersFromVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePhoneNumbersFromVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePhoneNumbersFromVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  DisassociatePhoneNumbersFromVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociatePhoneNumbersFromVoiceConnectorGroup">REST API Reference for DisassociatePhoneNumbersFromVoiceConnectorGroup Operation</seealso>
        public virtual DisassociatePhoneNumbersFromVoiceConnectorGroupResponse EndDisassociatePhoneNumbersFromVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePhoneNumbersFromVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSigninDelegateGroupsFromAccount

        /// <summary>
        /// Disassociates the specified sign-in delegate groups from the specified Amazon Chime
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSigninDelegateGroupsFromAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateSigninDelegateGroupsFromAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociateSigninDelegateGroupsFromAccount">REST API Reference for DisassociateSigninDelegateGroupsFromAccount Operation</seealso>
        public virtual DisassociateSigninDelegateGroupsFromAccountResponse DisassociateSigninDelegateGroupsFromAccount(DisassociateSigninDelegateGroupsFromAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSigninDelegateGroupsFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSigninDelegateGroupsFromAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateSigninDelegateGroupsFromAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSigninDelegateGroupsFromAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSigninDelegateGroupsFromAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSigninDelegateGroupsFromAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociateSigninDelegateGroupsFromAccount">REST API Reference for DisassociateSigninDelegateGroupsFromAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateSigninDelegateGroupsFromAccount(DisassociateSigninDelegateGroupsFromAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSigninDelegateGroupsFromAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSigninDelegateGroupsFromAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSigninDelegateGroupsFromAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSigninDelegateGroupsFromAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateSigninDelegateGroupsFromAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/DisassociateSigninDelegateGroupsFromAccount">REST API Reference for DisassociateSigninDelegateGroupsFromAccount Operation</seealso>
        public virtual DisassociateSigninDelegateGroupsFromAccountResponse EndDisassociateSigninDelegateGroupsFromAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSigninDelegateGroupsFromAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccount

        /// <summary>
        /// Retrieves details for the specified Amazon Chime account, such as account type and
        /// supported licenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual GetAccountResponse EndGetAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Retrieves account settings for the specified Amazon Chime account ID, such as remote
        /// control and dial out settings. For more information about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
        /// the Policies Page</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAppInstanceRetentionSettings

        /// <summary>
        /// Gets the retention settings for an app instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the GetAppInstanceRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        public virtual GetAppInstanceRetentionSettingsResponse GetAppInstanceRetentionSettings(GetAppInstanceRetentionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppInstanceRetentionSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAppInstanceRetentionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppInstanceRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAppInstanceRetentionSettings(GetAppInstanceRetentionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppInstanceRetentionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppInstanceRetentionSettings.</param>
        /// 
        /// <returns>Returns a  GetAppInstanceRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceRetentionSettings">REST API Reference for GetAppInstanceRetentionSettings Operation</seealso>
        public virtual GetAppInstanceRetentionSettingsResponse EndGetAppInstanceRetentionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppInstanceRetentionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAppInstanceStreamingConfigurations

        /// <summary>
        /// Gets the streaming settings for an app instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceStreamingConfigurations service method.</param>
        /// 
        /// <returns>The response from the GetAppInstanceStreamingConfigurations service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceStreamingConfigurations">REST API Reference for GetAppInstanceStreamingConfigurations Operation</seealso>
        public virtual GetAppInstanceStreamingConfigurationsResponse GetAppInstanceStreamingConfigurations(GetAppInstanceStreamingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppInstanceStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppInstanceStreamingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<GetAppInstanceStreamingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppInstanceStreamingConfigurations operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAppInstanceStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceStreamingConfigurations">REST API Reference for GetAppInstanceStreamingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginGetAppInstanceStreamingConfigurations(GetAppInstanceStreamingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppInstanceStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppInstanceStreamingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAppInstanceStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  GetAppInstanceStreamingConfigurationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAppInstanceStreamingConfigurations">REST API Reference for GetAppInstanceStreamingConfigurations Operation</seealso>
        public virtual GetAppInstanceStreamingConfigurationsResponse EndGetAppInstanceStreamingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppInstanceStreamingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAttendee

        /// <summary>
        /// Gets the Amazon Chime SDK attendee details for a specified meeting ID and attendee
        /// ID. For more information about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttendee service method.</param>
        /// 
        /// <returns>The response from the GetAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        public virtual GetAttendeeResponse GetAttendee(GetAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttendeeResponseUnmarshaller.Instance;

            return Invoke<GetAttendeeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        public virtual IAsyncResult BeginGetAttendee(GetAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttendee.</param>
        /// 
        /// <returns>Returns a  GetAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetAttendee">REST API Reference for GetAttendee Operation</seealso>
        public virtual GetAttendeeResponse EndGetAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAttendeeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBot

        /// <summary>
        /// Retrieves details for the specified bot, such as bot email address, bot type, status,
        /// and display name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// 
        /// <returns>The response from the GetBot service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual GetBotResponse GetBot(GetBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return Invoke<GetBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBot operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual IAsyncResult BeginGetBot(GetBotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBot.</param>
        /// 
        /// <returns>Returns a  GetBotResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetBot">REST API Reference for GetBot Operation</seealso>
        public virtual GetBotResponse EndGetBot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannelMessage

        /// <summary>
        /// Gets the full details of a channel message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessage service method.</param>
        /// 
        /// <returns>The response from the GetChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        public virtual GetChannelMessageResponse GetChannelMessage(GetChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageResponseUnmarshaller.Instance;

            return Invoke<GetChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginGetChannelMessage(GetChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannelMessage.</param>
        /// 
        /// <returns>Returns a  GetChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        public virtual GetChannelMessageResponse EndGetChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventsConfiguration

        /// <summary>
        /// Gets details for an events configuration that allows a bot to receive outgoing events,
        /// such as an HTTPS endpoint or Lambda function ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventsConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEventsConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetEventsConfiguration">REST API Reference for GetEventsConfiguration Operation</seealso>
        public virtual GetEventsConfigurationResponse GetEventsConfiguration(GetEventsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEventsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventsConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetEventsConfiguration">REST API Reference for GetEventsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetEventsConfiguration(GetEventsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventsConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEventsConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetEventsConfiguration">REST API Reference for GetEventsConfiguration Operation</seealso>
        public virtual GetEventsConfigurationResponse EndGetEventsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGlobalSettings

        /// <summary>
        /// Retrieves global settings for the administrator's AWS account, such as Amazon Chime
        /// Business Calling and Amazon Chime Voice Connector settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
        /// 
        /// <returns>The response from the GetGlobalSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        public virtual GetGlobalSettingsResponse GetGlobalSettings(GetGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<GetGlobalSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        public virtual IAsyncResult BeginGetGlobalSettings(GetGlobalSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlobalSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlobalSettings.</param>
        /// 
        /// <returns>Returns a  GetGlobalSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        public virtual GetGlobalSettingsResponse EndGetGlobalSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGlobalSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMeeting

        /// <summary>
        /// Gets the Amazon Chime SDK meeting details for the specified meeting ID. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMeeting service method.</param>
        /// 
        /// <returns>The response from the GetMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        public virtual GetMeetingResponse GetMeeting(GetMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMeetingResponseUnmarshaller.Instance;

            return Invoke<GetMeetingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        public virtual IAsyncResult BeginGetMeeting(GetMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMeeting.</param>
        /// 
        /// <returns>Returns a  GetMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMeeting">REST API Reference for GetMeeting Operation</seealso>
        public virtual GetMeetingResponse EndGetMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMeetingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMessagingSessionEndpoint

        /// <summary>
        /// The endpoint for the messaging session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingSessionEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetMessagingSessionEndpoint service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        public virtual GetMessagingSessionEndpointResponse GetMessagingSessionEndpoint(GetMessagingSessionEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingSessionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingSessionEndpointResponseUnmarshaller.Instance;

            return Invoke<GetMessagingSessionEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMessagingSessionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingSessionEndpoint operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMessagingSessionEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetMessagingSessionEndpoint(GetMessagingSessionEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingSessionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingSessionEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMessagingSessionEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMessagingSessionEndpoint.</param>
        /// 
        /// <returns>Returns a  GetMessagingSessionEndpointResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        public virtual GetMessagingSessionEndpointResponse EndGetMessagingSessionEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMessagingSessionEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPhoneNumber

        /// <summary>
        /// Retrieves details for the specified phone number ID, such as associations, capabilities,
        /// and product type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the GetPhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        public virtual GetPhoneNumberResponse GetPhoneNumber(GetPhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginGetPhoneNumber(GetPhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumber.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumber">REST API Reference for GetPhoneNumber Operation</seealso>
        public virtual GetPhoneNumberResponse EndGetPhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPhoneNumberOrder

        /// <summary>
        /// Retrieves details for the specified phone number order, such as order creation timestamp,
        /// phone numbers in E.164 format, product type, and order status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder service method.</param>
        /// 
        /// <returns>The response from the GetPhoneNumberOrder service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        public virtual GetPhoneNumberOrderResponse GetPhoneNumberOrder(GetPhoneNumberOrderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberOrderResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberOrderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberOrder operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberOrder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        public virtual IAsyncResult BeginGetPhoneNumberOrder(GetPhoneNumberOrderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberOrderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberOrderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberOrder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberOrder.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberOrderResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberOrder">REST API Reference for GetPhoneNumberOrder Operation</seealso>
        public virtual GetPhoneNumberOrderResponse EndGetPhoneNumberOrder(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPhoneNumberOrderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPhoneNumberSettings

        /// <summary>
        /// Retrieves the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings service method.</param>
        /// 
        /// <returns>The response from the GetPhoneNumberSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        public virtual GetPhoneNumberSettingsResponse GetPhoneNumberSettings(GetPhoneNumberSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberSettingsResponseUnmarshaller.Instance;

            return Invoke<GetPhoneNumberSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPhoneNumberSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        public virtual IAsyncResult BeginGetPhoneNumberSettings(GetPhoneNumberSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPhoneNumberSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  GetPhoneNumberSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetPhoneNumberSettings">REST API Reference for GetPhoneNumberSettings Operation</seealso>
        public virtual GetPhoneNumberSettingsResponse EndGetPhoneNumberSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPhoneNumberSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProxySession

        /// <summary>
        /// Gets the specified proxy session details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession service method.</param>
        /// 
        /// <returns>The response from the GetProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        public virtual GetProxySessionResponse GetProxySession(GetProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxySessionResponseUnmarshaller.Instance;

            return Invoke<GetProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        public virtual IAsyncResult BeginGetProxySession(GetProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProxySession.</param>
        /// 
        /// <returns>Returns a  GetProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetProxySession">REST API Reference for GetProxySession Operation</seealso>
        public virtual GetProxySessionResponse EndGetProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRetentionSettings

        /// <summary>
        /// Gets the retention settings for the specified Amazon Chime Enterprise account. For
        /// more information about retention settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/chat-retention.html">Managing
        /// Chat Retention Policies</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the GetRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRetentionSettings">REST API Reference for GetRetentionSettings Operation</seealso>
        public virtual GetRetentionSettingsResponse GetRetentionSettings(GetRetentionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetentionSettingsResponseUnmarshaller.Instance;

            return Invoke<GetRetentionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRetentionSettings">REST API Reference for GetRetentionSettings Operation</seealso>
        public virtual IAsyncResult BeginGetRetentionSettings(GetRetentionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRetentionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRetentionSettings.</param>
        /// 
        /// <returns>Returns a  GetRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRetentionSettings">REST API Reference for GetRetentionSettings Operation</seealso>
        public virtual GetRetentionSettingsResponse EndGetRetentionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRetentionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRoom

        /// <summary>
        /// Retrieves room details, such as the room name, for a room in an Amazon Chime Enterprise
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoom service method.</param>
        /// 
        /// <returns>The response from the GetRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual GetRoomResponse GetRoom(GetRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomResponseUnmarshaller.Instance;

            return Invoke<GetRoomResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual IAsyncResult BeginGetRoom(GetRoomRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoomResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRoom.</param>
        /// 
        /// <returns>Returns a  GetRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetRoom">REST API Reference for GetRoom Operation</seealso>
        public virtual GetRoomResponse EndGetRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSipMediaApplication

        /// <summary>
        /// Retrieves the information for a SIP media application, including name, AWS Region,
        /// and endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the GetSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        public virtual GetSipMediaApplicationResponse GetSipMediaApplication(GetSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginGetSipMediaApplication(GetSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplication">REST API Reference for GetSipMediaApplication Operation</seealso>
        public virtual GetSipMediaApplicationResponse EndGetSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSipMediaApplicationLoggingConfiguration

        /// <summary>
        /// Returns the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetSipMediaApplicationLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual GetSipMediaApplicationLoggingConfigurationResponse GetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetSipMediaApplicationLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipMediaApplicationLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetSipMediaApplicationLoggingConfiguration(GetSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetSipMediaApplicationLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipMediaApplicationLoggingConfiguration">REST API Reference for GetSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual GetSipMediaApplicationLoggingConfigurationResponse EndGetSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSipMediaApplicationLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSipRule

        /// <summary>
        /// Retrieves the details of a SIP rule, such as the rule ID, name, triggers, and target
        /// endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule service method.</param>
        /// 
        /// <returns>The response from the GetSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        public virtual GetSipRuleResponse GetSipRule(GetSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipRuleResponseUnmarshaller.Instance;

            return Invoke<GetSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        public virtual IAsyncResult BeginGetSipRule(GetSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSipRule.</param>
        /// 
        /// <returns>Returns a  GetSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetSipRule">REST API Reference for GetSipRule Operation</seealso>
        public virtual GetSipRuleResponse EndGetSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Retrieves details for the specified user ID, such as primary email address, license
        /// type, and personal meeting PIN.
        /// 
        ///  
        /// <para>
        /// To retrieve user details with an email address instead of a user ID, use the <a>ListUsers</a>
        /// action, and then filter by email address.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual GetUserResponse GetUser(GetUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserSettings

        /// <summary>
        /// Retrieves settings for the specified user ID, such as any associated phone number
        /// settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings service method.</param>
        /// 
        /// <returns>The response from the GetUserSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        public virtual GetUserSettingsResponse GetUserSettings(GetUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserSettingsResponseUnmarshaller.Instance;

            return Invoke<GetUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        public virtual IAsyncResult BeginGetUserSettings(GetUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserSettings.</param>
        /// 
        /// <returns>Returns a  GetUserSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetUserSettings">REST API Reference for GetUserSettings Operation</seealso>
        public virtual GetUserSettingsResponse EndGetUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnector

        /// <summary>
        /// Retrieves details for the specified Amazon Chime Voice Connector, such as timestamps,
        /// name, outbound host, and encryption requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        public virtual GetVoiceConnectorResponse GetVoiceConnector(GetVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnector(GetVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnector.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnector">REST API Reference for GetVoiceConnector Operation</seealso>
        public virtual GetVoiceConnectorResponse EndGetVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorEmergencyCallingConfiguration

        /// <summary>
        /// Gets the emergency calling configuration details for the specified Amazon Chime Voice
        /// Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorEmergencyCallingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorEmergencyCallingConfigurationResponse GetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorEmergencyCallingConfiguration(GetVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorEmergencyCallingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorEmergencyCallingConfiguration">REST API Reference for GetVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorEmergencyCallingConfigurationResponse EndGetVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorEmergencyCallingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorGroup

        /// <summary>
        /// Retrieves details for the specified Amazon Chime Voice Connector group, such as timestamps,
        /// name, and associated <code>VoiceConnectorItems</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        public virtual GetVoiceConnectorGroupResponse GetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorGroup(GetVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorGroup">REST API Reference for GetVoiceConnectorGroup Operation</seealso>
        public virtual GetVoiceConnectorGroupResponse EndGetVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorLoggingConfiguration

        /// <summary>
        /// Retrieves the logging configuration details for the specified Amazon Chime Voice Connector.
        /// Shows whether SIP message logs are enabled for sending to Amazon CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorLoggingConfigurationResponse GetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorLoggingConfiguration(GetVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorLoggingConfiguration">REST API Reference for GetVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorLoggingConfigurationResponse EndGetVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorOrigination

        /// <summary>
        /// Retrieves origination setting details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorOrigination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        public virtual GetVoiceConnectorOriginationResponse GetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorOriginationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorOrigination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorOrigination(GetVoiceConnectorOriginationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorOriginationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorOrigination">REST API Reference for GetVoiceConnectorOrigination Operation</seealso>
        public virtual GetVoiceConnectorOriginationResponse EndGetVoiceConnectorOrigination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorOriginationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorProxy

        /// <summary>
        /// Gets the proxy configuration details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorProxy service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        public virtual GetVoiceConnectorProxyResponse GetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorProxy operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorProxy(GetVoiceConnectorProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorProxyResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorProxy">REST API Reference for GetVoiceConnectorProxy Operation</seealso>
        public virtual GetVoiceConnectorProxyResponse EndGetVoiceConnectorProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorStreamingConfiguration

        /// <summary>
        /// Retrieves the streaming configuration details for the specified Amazon Chime Voice
        /// Connector. Shows whether media streaming is enabled for sending to Amazon Kinesis.
        /// It also shows the retention period, in hours, for the Amazon Kinesis data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorStreamingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorStreamingConfigurationResponse GetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorStreamingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorStreamingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorStreamingConfiguration(GetVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorStreamingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorStreamingConfiguration">REST API Reference for GetVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual GetVoiceConnectorStreamingConfigurationResponse EndGetVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorStreamingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorTermination

        /// <summary>
        /// Retrieves termination setting details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTermination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        public virtual GetVoiceConnectorTerminationResponse GetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorTerminationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTermination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorTermination(GetVoiceConnectorTerminationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTermination">REST API Reference for GetVoiceConnectorTermination Operation</seealso>
        public virtual GetVoiceConnectorTerminationResponse EndGetVoiceConnectorTermination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorTerminationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceConnectorTerminationHealth

        /// <summary>
        /// Retrieves information about the last time a SIP <code>OPTIONS</code> ping was received
        /// from your SIP infrastructure for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth service method.</param>
        /// 
        /// <returns>The response from the GetVoiceConnectorTerminationHealth service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        public virtual GetVoiceConnectorTerminationHealthResponse GetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationHealthResponseUnmarshaller.Instance;

            return Invoke<GetVoiceConnectorTerminationHealthResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceConnectorTerminationHealth operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceConnectorTerminationHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceConnectorTerminationHealth(GetVoiceConnectorTerminationHealthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVoiceConnectorTerminationHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceConnectorTerminationHealthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceConnectorTerminationHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceConnectorTerminationHealth.</param>
        /// 
        /// <returns>Returns a  GetVoiceConnectorTerminationHealthResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/GetVoiceConnectorTerminationHealth">REST API Reference for GetVoiceConnectorTerminationHealth Operation</seealso>
        public virtual GetVoiceConnectorTerminationHealthResponse EndGetVoiceConnectorTerminationHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceConnectorTerminationHealthResponse>(asyncResult);
        }

        #endregion
        
        #region  InviteUsers

        /// <summary>
        /// Sends email to a maximum of 50 users, inviting them to the specified Amazon Chime
        /// <code>Team</code> account. Only <code>Team</code> account types are currently supported
        /// for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteUsers service method.</param>
        /// 
        /// <returns>The response from the InviteUsers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        public virtual InviteUsersResponse InviteUsers(InviteUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteUsersResponseUnmarshaller.Instance;

            return Invoke<InviteUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InviteUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteUsers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInviteUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        public virtual IAsyncResult BeginInviteUsers(InviteUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InviteUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInviteUsers.</param>
        /// 
        /// <returns>Returns a  InviteUsersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/InviteUsers">REST API Reference for InviteUsers Operation</seealso>
        public virtual InviteUsersResponse EndInviteUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<InviteUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccounts

        /// <summary>
        /// Lists the Amazon Chime accounts under the administrator's AWS account. You can filter
        /// accounts by account name prefix. To find out which Amazon Chime account a user belongs
        /// to, you can filter by the user's email address, which returns one account result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual IAsyncResult BeginListAccounts(ListAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccounts.</param>
        /// 
        /// <returns>Returns a  ListAccountsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual ListAccountsResponse EndListAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppInstanceAdmins

        /// <summary>
        /// Returns a list of the administrators in the app instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceAdmins service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        public virtual ListAppInstanceAdminsResponse ListAppInstanceAdmins(ListAppInstanceAdminsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceAdminsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceAdminsResponseUnmarshaller.Instance;

            return Invoke<ListAppInstanceAdminsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceAdmins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceAdmins operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceAdmins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        public virtual IAsyncResult BeginListAppInstanceAdmins(ListAppInstanceAdminsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceAdminsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceAdminsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceAdmins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceAdmins.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceAdminsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceAdmins">REST API Reference for ListAppInstanceAdmins Operation</seealso>
        public virtual ListAppInstanceAdminsResponse EndListAppInstanceAdmins(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppInstanceAdminsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppInstances

        /// <summary>
        /// Lists all Amazon Chime app instances created under a single AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances service method.</param>
        /// 
        /// <returns>The response from the ListAppInstances service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        public virtual ListAppInstancesResponse ListAppInstances(ListAppInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstancesResponseUnmarshaller.Instance;

            return Invoke<ListAppInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstances operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        public virtual IAsyncResult BeginListAppInstances(ListAppInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstances.</param>
        /// 
        /// <returns>Returns a  ListAppInstancesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstances">REST API Reference for ListAppInstances Operation</seealso>
        public virtual ListAppInstancesResponse EndListAppInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAppInstanceUsers

        /// <summary>
        /// List all <code>AppInstanceUsers</code> created under a single app instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers service method.</param>
        /// 
        /// <returns>The response from the ListAppInstanceUsers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        public virtual ListAppInstanceUsersResponse ListAppInstanceUsers(ListAppInstanceUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceUsersResponseUnmarshaller.Instance;

            return Invoke<ListAppInstanceUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppInstanceUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppInstanceUsers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppInstanceUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        public virtual IAsyncResult BeginListAppInstanceUsers(ListAppInstanceUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppInstanceUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppInstanceUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppInstanceUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppInstanceUsers.</param>
        /// 
        /// <returns>Returns a  ListAppInstanceUsersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAppInstanceUsers">REST API Reference for ListAppInstanceUsers Operation</seealso>
        public virtual ListAppInstanceUsersResponse EndListAppInstanceUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAppInstanceUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttendees

        /// <summary>
        /// Lists the attendees for the specified Amazon Chime SDK meeting. For more information
        /// about the Amazon Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttendees service method.</param>
        /// 
        /// <returns>The response from the ListAttendees service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        public virtual ListAttendeesResponse ListAttendees(ListAttendeesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttendeesResponseUnmarshaller.Instance;

            return Invoke<ListAttendeesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttendees operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttendees operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttendees
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        public virtual IAsyncResult BeginListAttendees(ListAttendeesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttendeesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttendeesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttendees operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttendees.</param>
        /// 
        /// <returns>Returns a  ListAttendeesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendees">REST API Reference for ListAttendees Operation</seealso>
        public virtual ListAttendeesResponse EndListAttendees(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttendeesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttendeeTags

        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK attendee resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttendeeTags service method.</param>
        /// 
        /// <returns>The response from the ListAttendeeTags service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendeeTags">REST API Reference for ListAttendeeTags Operation</seealso>
        public virtual ListAttendeeTagsResponse ListAttendeeTags(ListAttendeeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttendeeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttendeeTagsResponseUnmarshaller.Instance;

            return Invoke<ListAttendeeTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttendeeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttendeeTags operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttendeeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendeeTags">REST API Reference for ListAttendeeTags Operation</seealso>
        public virtual IAsyncResult BeginListAttendeeTags(ListAttendeeTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttendeeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttendeeTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttendeeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttendeeTags.</param>
        /// 
        /// <returns>Returns a  ListAttendeeTagsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListAttendeeTags">REST API Reference for ListAttendeeTags Operation</seealso>
        public virtual ListAttendeeTagsResponse EndListAttendeeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttendeeTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListBots

        /// <summary>
        /// Lists the bots associated with the administrator's Amazon Chime Enterprise account
        /// ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual ListBotsResponse ListBots(ListBotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBotsResponseUnmarshaller.Instance;

            return Invoke<ListBotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListBots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBots operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual IAsyncResult BeginListBots(ListBotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBots.</param>
        /// 
        /// <returns>Returns a  ListBotsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListBots">REST API Reference for ListBots Operation</seealso>
        public virtual ListBotsResponse EndListBots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelBans

        /// <summary>
        /// Lists all the users banned from a particular channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelBans service method.</param>
        /// 
        /// <returns>The response from the ListChannelBans service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        public virtual ListChannelBansResponse ListChannelBans(ListChannelBansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelBansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelBansResponseUnmarshaller.Instance;

            return Invoke<ListChannelBansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelBans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelBans operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelBans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        public virtual IAsyncResult BeginListChannelBans(ListChannelBansRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelBansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelBansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelBans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelBans.</param>
        /// 
        /// <returns>Returns a  ListChannelBansResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        public virtual ListChannelBansResponse EndListChannelBans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelBansResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelMemberships

        /// <summary>
        /// Lists all channel memberships in a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMemberships service method.</param>
        /// 
        /// <returns>The response from the ListChannelMemberships service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        public virtual ListChannelMembershipsResponse ListChannelMemberships(ListChannelMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListChannelMembershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMemberships operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        public virtual IAsyncResult BeginListChannelMemberships(ListChannelMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMemberships.</param>
        /// 
        /// <returns>Returns a  ListChannelMembershipsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        public virtual ListChannelMembershipsResponse EndListChannelMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelMembershipsForAppInstanceUser

        /// <summary>
        /// Lists all channels that a particular <code>AppInstanceUser</code> is a part of. Only
        /// an <code>AppInstanceAdmin</code> can call the API with a user ARN that is not their
        /// own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMembershipsForAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the ListChannelMembershipsForAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        public virtual ListChannelMembershipsForAppInstanceUserResponse ListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsForAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<ListChannelMembershipsForAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMembershipsForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMembershipsForAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMembershipsForAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsForAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMembershipsForAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMembershipsForAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  ListChannelMembershipsForAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        public virtual ListChannelMembershipsForAppInstanceUserResponse EndListChannelMembershipsForAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelMembershipsForAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelMessages

        /// <summary>
        /// List all the messages in a channel. Returns a paginated list of <code>ChannelMessages</code>.
        /// Sorted in descending order by default, based on the creation timestamp.
        /// 
        ///  <note> 
        /// <para>
        /// Redacted messages appear in the results as empty, since they are only redacted, not
        /// deleted. Deleted messages do not appear in the results. This action always returns
        /// the latest version of an edited message.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMessages service method.</param>
        /// 
        /// <returns>The response from the ListChannelMessages service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        public virtual ListChannelMessagesResponse ListChannelMessages(ListChannelMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMessagesResponseUnmarshaller.Instance;

            return Invoke<ListChannelMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMessages operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        public virtual IAsyncResult BeginListChannelMessages(ListChannelMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelMessages.</param>
        /// 
        /// <returns>Returns a  ListChannelMessagesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        public virtual ListChannelMessagesResponse EndListChannelMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelModerators

        /// <summary>
        /// Lists all the moderators for a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelModerators service method.</param>
        /// 
        /// <returns>The response from the ListChannelModerators service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        public virtual ListChannelModeratorsResponse ListChannelModerators(ListChannelModeratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelModeratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelModeratorsResponseUnmarshaller.Instance;

            return Invoke<ListChannelModeratorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelModerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelModerators operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelModerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        public virtual IAsyncResult BeginListChannelModerators(ListChannelModeratorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelModeratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelModeratorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelModerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelModerators.</param>
        /// 
        /// <returns>Returns a  ListChannelModeratorsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        public virtual ListChannelModeratorsResponse EndListChannelModerators(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelModeratorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannels

        /// <summary>
        /// Lists all Channels created under a single Chime App as a paginated list. You can specify
        /// filters to narrow results.
        /// 
        ///  <p class="title"> <b>Functionality &amp; restrictions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use privacy = <code>PUBLIC</code> to retrieve all public channels in the account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only an <code>AppInstanceAdmin</code> can set privacy = <code>PRIVATE</code> to list
        /// the private channels in an account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannelsModeratedByAppInstanceUser

        /// <summary>
        /// A list of the channels moderated by an app instance user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsModeratedByAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the ListChannelsModeratedByAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        public virtual ListChannelsModeratedByAppInstanceUserResponse ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<ListChannelsModeratedByAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelsModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsModeratedByAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelsModeratedByAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelsModeratedByAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelsModeratedByAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  ListChannelsModeratedByAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        public virtual ListChannelsModeratedByAppInstanceUserResponse EndListChannelsModeratedByAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsModeratedByAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMeetings

        /// <summary>
        /// Lists up to 100 active Amazon Chime SDK meetings. For more information about the Amazon
        /// Chime SDK, see <a href="https://docs.aws.amazon.com/chime/latest/dg/meetings-sdk.html">Using
        /// the Amazon Chime SDK</a> in the <i>Amazon Chime Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeetings service method.</param>
        /// 
        /// <returns>The response from the ListMeetings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetings">REST API Reference for ListMeetings Operation</seealso>
        public virtual ListMeetingsResponse ListMeetings(ListMeetingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMeetingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeetingsResponseUnmarshaller.Instance;

            return Invoke<ListMeetingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeetings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeetings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeetings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetings">REST API Reference for ListMeetings Operation</seealso>
        public virtual IAsyncResult BeginListMeetings(ListMeetingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMeetingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeetingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeetings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeetings.</param>
        /// 
        /// <returns>Returns a  ListMeetingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetings">REST API Reference for ListMeetings Operation</seealso>
        public virtual ListMeetingsResponse EndListMeetings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMeetingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMeetingTags

        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeetingTags service method.</param>
        /// 
        /// <returns>The response from the ListMeetingTags service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetingTags">REST API Reference for ListMeetingTags Operation</seealso>
        public virtual ListMeetingTagsResponse ListMeetingTags(ListMeetingTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMeetingTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeetingTagsResponseUnmarshaller.Instance;

            return Invoke<ListMeetingTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeetingTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeetingTags operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeetingTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetingTags">REST API Reference for ListMeetingTags Operation</seealso>
        public virtual IAsyncResult BeginListMeetingTags(ListMeetingTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMeetingTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeetingTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeetingTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeetingTags.</param>
        /// 
        /// <returns>Returns a  ListMeetingTagsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListMeetingTags">REST API Reference for ListMeetingTags Operation</seealso>
        public virtual ListMeetingTagsResponse EndListMeetingTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMeetingTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPhoneNumberOrders

        /// <summary>
        /// Lists the phone number orders for the administrator's Amazon Chime account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumberOrders service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        public virtual ListPhoneNumberOrdersResponse ListPhoneNumberOrders(ListPhoneNumberOrdersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumberOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumberOrdersResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumberOrdersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumberOrders operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumberOrders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        public virtual IAsyncResult BeginListPhoneNumberOrders(ListPhoneNumberOrdersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumberOrdersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumberOrdersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumberOrders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumberOrders.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumberOrdersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumberOrders">REST API Reference for ListPhoneNumberOrders Operation</seealso>
        public virtual ListPhoneNumberOrdersResponse EndListPhoneNumberOrders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPhoneNumberOrdersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPhoneNumbers

        /// <summary>
        /// Lists the phone numbers for the specified Amazon Chime account, Amazon Chime user,
        /// Amazon Chime Voice Connector, or Amazon Chime Voice Connector group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumbers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual ListPhoneNumbersResponse ListPhoneNumbers(ListPhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<ListPhoneNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual IAsyncResult BeginListPhoneNumbers(ListPhoneNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPhoneNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumbers.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumbersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListPhoneNumbers">REST API Reference for ListPhoneNumbers Operation</seealso>
        public virtual ListPhoneNumbersResponse EndListPhoneNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPhoneNumbersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProxySessions

        /// <summary>
        /// Lists the proxy sessions for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions service method.</param>
        /// 
        /// <returns>The response from the ListProxySessions service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        public virtual ListProxySessionsResponse ListProxySessions(ListProxySessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProxySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxySessionsResponseUnmarshaller.Instance;

            return Invoke<ListProxySessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProxySessions operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProxySessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        public virtual IAsyncResult BeginListProxySessions(ListProxySessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProxySessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxySessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProxySessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProxySessions.</param>
        /// 
        /// <returns>Returns a  ListProxySessionsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListProxySessions">REST API Reference for ListProxySessions Operation</seealso>
        public virtual ListProxySessionsResponse EndListProxySessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProxySessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoomMemberships

        /// <summary>
        /// Lists the membership details for the specified room in an Amazon Chime Enterprise
        /// account, such as the members' IDs, email addresses, and names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoomMemberships service method.</param>
        /// 
        /// <returns>The response from the ListRoomMemberships service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRoomMemberships">REST API Reference for ListRoomMemberships Operation</seealso>
        public virtual ListRoomMembershipsResponse ListRoomMemberships(ListRoomMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoomMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoomMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListRoomMembershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoomMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoomMemberships operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoomMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRoomMemberships">REST API Reference for ListRoomMemberships Operation</seealso>
        public virtual IAsyncResult BeginListRoomMemberships(ListRoomMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoomMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoomMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoomMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoomMemberships.</param>
        /// 
        /// <returns>Returns a  ListRoomMembershipsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRoomMemberships">REST API Reference for ListRoomMemberships Operation</seealso>
        public virtual ListRoomMembershipsResponse EndListRoomMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoomMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRooms

        /// <summary>
        /// Lists the room details for the specified Amazon Chime Enterprise account. Optionally,
        /// filter the results by a member ID (user ID or bot ID) to see a list of rooms that
        /// the member belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRooms service method.</param>
        /// 
        /// <returns>The response from the ListRooms service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRooms">REST API Reference for ListRooms Operation</seealso>
        public virtual ListRoomsResponse ListRooms(ListRoomsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoomsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoomsResponseUnmarshaller.Instance;

            return Invoke<ListRoomsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRooms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRooms operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRooms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRooms">REST API Reference for ListRooms Operation</seealso>
        public virtual IAsyncResult BeginListRooms(ListRoomsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoomsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoomsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRooms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRooms.</param>
        /// 
        /// <returns>Returns a  ListRoomsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListRooms">REST API Reference for ListRooms Operation</seealso>
        public virtual ListRoomsResponse EndListRooms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoomsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSipMediaApplications

        /// <summary>
        /// Lists the SIP media applications under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications service method.</param>
        /// 
        /// <returns>The response from the ListSipMediaApplications service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        public virtual ListSipMediaApplicationsResponse ListSipMediaApplications(ListSipMediaApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipMediaApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipMediaApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListSipMediaApplicationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipMediaApplications operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipMediaApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        public virtual IAsyncResult BeginListSipMediaApplications(ListSipMediaApplicationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipMediaApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipMediaApplicationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipMediaApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipMediaApplications.</param>
        /// 
        /// <returns>Returns a  ListSipMediaApplicationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipMediaApplications">REST API Reference for ListSipMediaApplications Operation</seealso>
        public virtual ListSipMediaApplicationsResponse EndListSipMediaApplications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSipMediaApplicationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSipRules

        /// <summary>
        /// Lists the SIP rules under the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules service method.</param>
        /// 
        /// <returns>The response from the ListSipRules service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        public virtual ListSipRulesResponse ListSipRules(ListSipRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipRulesResponseUnmarshaller.Instance;

            return Invoke<ListSipRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSipRules operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSipRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        public virtual IAsyncResult BeginListSipRules(ListSipRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSipRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSipRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSipRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSipRules.</param>
        /// 
        /// <returns>Returns a  ListSipRulesResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListSipRules">REST API Reference for ListSipRules Operation</seealso>
        public virtual ListSipRulesResponse EndListSipRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSipRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Lists the users that belong to the specified Amazon Chime account. You can specify
        /// an email address to list only the user that the email address belongs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceConnectorGroups

        /// <summary>
        /// Lists the Amazon Chime Voice Connector groups for the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups service method.</param>
        /// 
        /// <returns>The response from the ListVoiceConnectorGroups service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        public virtual ListVoiceConnectorGroupsResponse ListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorGroupsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorGroups operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        public virtual IAsyncResult BeginListVoiceConnectorGroups(ListVoiceConnectorGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorGroups.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorGroupsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorGroups">REST API Reference for ListVoiceConnectorGroups Operation</seealso>
        public virtual ListVoiceConnectorGroupsResponse EndListVoiceConnectorGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceConnectorGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceConnectors

        /// <summary>
        /// Lists the Amazon Chime Voice Connectors for the administrator's AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors service method.</param>
        /// 
        /// <returns>The response from the ListVoiceConnectors service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        public virtual ListVoiceConnectorsResponse ListVoiceConnectors(ListVoiceConnectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectors operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        public virtual IAsyncResult BeginListVoiceConnectors(ListVoiceConnectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectors.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectors">REST API Reference for ListVoiceConnectors Operation</seealso>
        public virtual ListVoiceConnectorsResponse EndListVoiceConnectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceConnectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVoiceConnectorTerminationCredentials

        /// <summary>
        /// Lists the SIP credentials for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials service method.</param>
        /// 
        /// <returns>The response from the ListVoiceConnectorTerminationCredentials service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual ListVoiceConnectorTerminationCredentialsResponse ListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<ListVoiceConnectorTerminationCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVoiceConnectorTerminationCredentials operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual IAsyncResult BeginListVoiceConnectorTerminationCredentials(ListVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  ListVoiceConnectorTerminationCredentialsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ListVoiceConnectorTerminationCredentials">REST API Reference for ListVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual ListVoiceConnectorTerminationCredentialsResponse EndListVoiceConnectorTerminationCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVoiceConnectorTerminationCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  LogoutUser

        /// <summary>
        /// Logs out the specified user from all of the devices they are currently logged into.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LogoutUser service method.</param>
        /// 
        /// <returns>The response from the LogoutUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        public virtual LogoutUserResponse LogoutUser(LogoutUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LogoutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LogoutUserResponseUnmarshaller.Instance;

            return Invoke<LogoutUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the LogoutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LogoutUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLogoutUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        public virtual IAsyncResult BeginLogoutUser(LogoutUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LogoutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LogoutUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LogoutUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLogoutUser.</param>
        /// 
        /// <returns>Returns a  LogoutUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/LogoutUser">REST API Reference for LogoutUser Operation</seealso>
        public virtual LogoutUserResponse EndLogoutUser(IAsyncResult asyncResult)
        {
            return EndInvoke<LogoutUserResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAppInstanceRetentionSettings

        /// <summary>
        /// Sets the amount of time in days that a given app instance retains data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the PutAppInstanceRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        public virtual PutAppInstanceRetentionSettingsResponse PutAppInstanceRetentionSettings(PutAppInstanceRetentionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceRetentionSettingsResponseUnmarshaller.Instance;

            return Invoke<PutAppInstanceRetentionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppInstanceRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        public virtual IAsyncResult BeginPutAppInstanceRetentionSettings(PutAppInstanceRetentionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceRetentionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppInstanceRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppInstanceRetentionSettings.</param>
        /// 
        /// <returns>Returns a  PutAppInstanceRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceRetentionSettings">REST API Reference for PutAppInstanceRetentionSettings Operation</seealso>
        public virtual PutAppInstanceRetentionSettingsResponse EndPutAppInstanceRetentionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAppInstanceRetentionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAppInstanceStreamingConfigurations

        /// <summary>
        /// The data streaming configurations of an app instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceStreamingConfigurations service method.</param>
        /// 
        /// <returns>The response from the PutAppInstanceStreamingConfigurations service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceStreamingConfigurations">REST API Reference for PutAppInstanceStreamingConfigurations Operation</seealso>
        public virtual PutAppInstanceStreamingConfigurationsResponse PutAppInstanceStreamingConfigurations(PutAppInstanceStreamingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceStreamingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<PutAppInstanceStreamingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppInstanceStreamingConfigurations operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAppInstanceStreamingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceStreamingConfigurations">REST API Reference for PutAppInstanceStreamingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginPutAppInstanceStreamingConfigurations(PutAppInstanceStreamingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAppInstanceStreamingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAppInstanceStreamingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAppInstanceStreamingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAppInstanceStreamingConfigurations.</param>
        /// 
        /// <returns>Returns a  PutAppInstanceStreamingConfigurationsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutAppInstanceStreamingConfigurations">REST API Reference for PutAppInstanceStreamingConfigurations Operation</seealso>
        public virtual PutAppInstanceStreamingConfigurationsResponse EndPutAppInstanceStreamingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAppInstanceStreamingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEventsConfiguration

        /// <summary>
        /// Creates an events configuration that allows a bot to receive outgoing events sent
        /// by Amazon Chime. Choose either an HTTPS endpoint or a Lambda function ARN. For more
        /// information, see <a>Bot</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventsConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutEventsConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutEventsConfiguration">REST API Reference for PutEventsConfiguration Operation</seealso>
        public virtual PutEventsConfigurationResponse PutEventsConfiguration(PutEventsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutEventsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventsConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutEventsConfiguration">REST API Reference for PutEventsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutEventsConfiguration(PutEventsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventsConfiguration.</param>
        /// 
        /// <returns>Returns a  PutEventsConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutEventsConfiguration">REST API Reference for PutEventsConfiguration Operation</seealso>
        public virtual PutEventsConfigurationResponse EndPutEventsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRetentionSettings

        /// <summary>
        /// Puts retention settings for the specified Amazon Chime Enterprise account. We recommend
        /// using AWS CloudTrail to monitor usage of this API for your account. For more information,
        /// see <a href="https://docs.aws.amazon.com/chime/latest/ag/cloudtrail.html">Logging
        /// Amazon Chime API Calls with AWS CloudTrail</a> in the <i>Amazon Chime Administration
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// To turn off existing retention settings, remove the number of days from the corresponding
        /// <b>RetentionDays</b> field in the <b>RetentionSettings</b> object. For more information
        /// about retention settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/chat-retention.html">Managing
        /// Chat Retention Policies</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionSettings service method.</param>
        /// 
        /// <returns>The response from the PutRetentionSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutRetentionSettings">REST API Reference for PutRetentionSettings Operation</seealso>
        public virtual PutRetentionSettingsResponse PutRetentionSettings(PutRetentionSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionSettingsResponseUnmarshaller.Instance;

            return Invoke<PutRetentionSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRetentionSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutRetentionSettings">REST API Reference for PutRetentionSettings Operation</seealso>
        public virtual IAsyncResult BeginPutRetentionSettings(PutRetentionSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRetentionSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRetentionSettings.</param>
        /// 
        /// <returns>Returns a  PutRetentionSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutRetentionSettings">REST API Reference for PutRetentionSettings Operation</seealso>
        public virtual PutRetentionSettingsResponse EndPutRetentionSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRetentionSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSipMediaApplicationLoggingConfiguration

        /// <summary>
        /// Updates the logging configuration for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutSipMediaApplicationLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual PutSipMediaApplicationLoggingConfigurationResponse PutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutSipMediaApplicationLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSipMediaApplicationLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSipMediaApplicationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutSipMediaApplicationLoggingConfiguration(PutSipMediaApplicationLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSipMediaApplicationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSipMediaApplicationLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSipMediaApplicationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSipMediaApplicationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutSipMediaApplicationLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutSipMediaApplicationLoggingConfiguration">REST API Reference for PutSipMediaApplicationLoggingConfiguration Operation</seealso>
        public virtual PutSipMediaApplicationLoggingConfigurationResponse EndPutSipMediaApplicationLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSipMediaApplicationLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorEmergencyCallingConfiguration

        /// <summary>
        /// Puts emergency calling configuration details to the specified Amazon Chime Voice Connector,
        /// such as emergency phone numbers and calling countries. Origination and termination
        /// settings must be enabled for the Amazon Chime Voice Connector before emergency calling
        /// can be configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorEmergencyCallingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorEmergencyCallingConfigurationResponse PutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorEmergencyCallingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorEmergencyCallingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorEmergencyCallingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorEmergencyCallingConfiguration(PutVoiceConnectorEmergencyCallingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorEmergencyCallingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorEmergencyCallingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorEmergencyCallingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorEmergencyCallingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorEmergencyCallingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorEmergencyCallingConfiguration">REST API Reference for PutVoiceConnectorEmergencyCallingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorEmergencyCallingConfigurationResponse EndPutVoiceConnectorEmergencyCallingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorEmergencyCallingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorLoggingConfiguration

        /// <summary>
        /// Adds a logging configuration for the specified Amazon Chime Voice Connector. The logging
        /// configuration specifies whether SIP message logs are enabled for sending to Amazon
        /// CloudWatch Logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorLoggingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorLoggingConfigurationResponse PutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorLoggingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorLoggingConfiguration(PutVoiceConnectorLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorLoggingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorLoggingConfiguration">REST API Reference for PutVoiceConnectorLoggingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorLoggingConfigurationResponse EndPutVoiceConnectorLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorOrigination

        /// <summary>
        /// Adds origination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to turning off origination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorOrigination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        public virtual PutVoiceConnectorOriginationResponse PutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorOriginationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorOrigination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorOrigination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorOrigination(PutVoiceConnectorOriginationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorOriginationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorOriginationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorOrigination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorOrigination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorOriginationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorOrigination">REST API Reference for PutVoiceConnectorOrigination Operation</seealso>
        public virtual PutVoiceConnectorOriginationResponse EndPutVoiceConnectorOrigination(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorOriginationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorProxy

        /// <summary>
        /// Puts the specified proxy configuration to the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorProxy service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        public virtual PutVoiceConnectorProxyResponse PutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorProxyResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorProxy operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorProxy(PutVoiceConnectorProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorProxy.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorProxyResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorProxy">REST API Reference for PutVoiceConnectorProxy Operation</seealso>
        public virtual PutVoiceConnectorProxyResponse EndPutVoiceConnectorProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorStreamingConfiguration

        /// <summary>
        /// Adds a streaming configuration for the specified Amazon Chime Voice Connector. The
        /// streaming configuration specifies whether media streaming is enabled for sending to
        /// Amazon Kinesis. It also sets the retention period, in hours, for the Amazon Kinesis
        /// data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorStreamingConfiguration service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorStreamingConfigurationResponse PutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorStreamingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorStreamingConfiguration operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorStreamingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorStreamingConfiguration(PutVoiceConnectorStreamingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorStreamingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorStreamingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorStreamingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorStreamingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorStreamingConfigurationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorStreamingConfiguration">REST API Reference for PutVoiceConnectorStreamingConfiguration Operation</seealso>
        public virtual PutVoiceConnectorStreamingConfigurationResponse EndPutVoiceConnectorStreamingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorStreamingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorTermination

        /// <summary>
        /// Adds termination settings for the specified Amazon Chime Voice Connector.
        /// 
        ///  <note> 
        /// <para>
        /// If emergency calling is configured for the Amazon Chime Voice Connector, it must be
        /// deleted prior to turning off termination settings.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTermination service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        public virtual PutVoiceConnectorTerminationResponse PutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorTerminationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTermination operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTermination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorTermination(PutVoiceConnectorTerminationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTermination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTermination.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTermination">REST API Reference for PutVoiceConnectorTermination Operation</seealso>
        public virtual PutVoiceConnectorTerminationResponse EndPutVoiceConnectorTermination(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorTerminationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutVoiceConnectorTerminationCredentials

        /// <summary>
        /// Adds termination SIP credentials for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials service method.</param>
        /// 
        /// <returns>The response from the PutVoiceConnectorTerminationCredentials service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual PutVoiceConnectorTerminationCredentialsResponse PutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return Invoke<PutVoiceConnectorTerminationCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVoiceConnectorTerminationCredentials operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVoiceConnectorTerminationCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual IAsyncResult BeginPutVoiceConnectorTerminationCredentials(PutVoiceConnectorTerminationCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutVoiceConnectorTerminationCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutVoiceConnectorTerminationCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutVoiceConnectorTerminationCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVoiceConnectorTerminationCredentials.</param>
        /// 
        /// <returns>Returns a  PutVoiceConnectorTerminationCredentialsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/PutVoiceConnectorTerminationCredentials">REST API Reference for PutVoiceConnectorTerminationCredentials Operation</seealso>
        public virtual PutVoiceConnectorTerminationCredentialsResponse EndPutVoiceConnectorTerminationCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<PutVoiceConnectorTerminationCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  RedactChannelMessage

        /// <summary>
        /// Redacts message content, but not metadata. The message exists in the back end, but
        /// the action returns null content, and the state shows as redacted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactChannelMessage service method.</param>
        /// 
        /// <returns>The response from the RedactChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        public virtual RedactChannelMessageResponse RedactChannelMessage(RedactChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactChannelMessageResponseUnmarshaller.Instance;

            return Invoke<RedactChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RedactChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RedactChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRedactChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginRedactChannelMessage(RedactChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RedactChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRedactChannelMessage.</param>
        /// 
        /// <returns>Returns a  RedactChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        public virtual RedactChannelMessageResponse EndRedactChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<RedactChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  RedactConversationMessage

        /// <summary>
        /// Redacts the specified message from the specified Amazon Chime conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactConversationMessage service method.</param>
        /// 
        /// <returns>The response from the RedactConversationMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactConversationMessage">REST API Reference for RedactConversationMessage Operation</seealso>
        public virtual RedactConversationMessageResponse RedactConversationMessage(RedactConversationMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactConversationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactConversationMessageResponseUnmarshaller.Instance;

            return Invoke<RedactConversationMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RedactConversationMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RedactConversationMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRedactConversationMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactConversationMessage">REST API Reference for RedactConversationMessage Operation</seealso>
        public virtual IAsyncResult BeginRedactConversationMessage(RedactConversationMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactConversationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactConversationMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RedactConversationMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRedactConversationMessage.</param>
        /// 
        /// <returns>Returns a  RedactConversationMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactConversationMessage">REST API Reference for RedactConversationMessage Operation</seealso>
        public virtual RedactConversationMessageResponse EndRedactConversationMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<RedactConversationMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  RedactRoomMessage

        /// <summary>
        /// Redacts the specified message from the specified Amazon Chime channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactRoomMessage service method.</param>
        /// 
        /// <returns>The response from the RedactRoomMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactRoomMessage">REST API Reference for RedactRoomMessage Operation</seealso>
        public virtual RedactRoomMessageResponse RedactRoomMessage(RedactRoomMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactRoomMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactRoomMessageResponseUnmarshaller.Instance;

            return Invoke<RedactRoomMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RedactRoomMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RedactRoomMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRedactRoomMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactRoomMessage">REST API Reference for RedactRoomMessage Operation</seealso>
        public virtual IAsyncResult BeginRedactRoomMessage(RedactRoomMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactRoomMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactRoomMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RedactRoomMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRedactRoomMessage.</param>
        /// 
        /// <returns>Returns a  RedactRoomMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RedactRoomMessage">REST API Reference for RedactRoomMessage Operation</seealso>
        public virtual RedactRoomMessageResponse EndRedactRoomMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<RedactRoomMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  RegenerateSecurityToken

        /// <summary>
        /// Regenerates the security token for a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegenerateSecurityToken service method.</param>
        /// 
        /// <returns>The response from the RegenerateSecurityToken service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RegenerateSecurityToken">REST API Reference for RegenerateSecurityToken Operation</seealso>
        public virtual RegenerateSecurityTokenResponse RegenerateSecurityToken(RegenerateSecurityTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegenerateSecurityTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegenerateSecurityTokenResponseUnmarshaller.Instance;

            return Invoke<RegenerateSecurityTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegenerateSecurityToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegenerateSecurityToken operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegenerateSecurityToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RegenerateSecurityToken">REST API Reference for RegenerateSecurityToken Operation</seealso>
        public virtual IAsyncResult BeginRegenerateSecurityToken(RegenerateSecurityTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegenerateSecurityTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegenerateSecurityTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegenerateSecurityToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegenerateSecurityToken.</param>
        /// 
        /// <returns>Returns a  RegenerateSecurityTokenResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RegenerateSecurityToken">REST API Reference for RegenerateSecurityToken Operation</seealso>
        public virtual RegenerateSecurityTokenResponse EndRegenerateSecurityToken(IAsyncResult asyncResult)
        {
            return EndInvoke<RegenerateSecurityTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetPersonalPIN

        /// <summary>
        /// Resets the personal meeting PIN for the specified user on an Amazon Chime account.
        /// Returns the <a>User</a> object with the updated personal meeting PIN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetPersonalPIN service method.</param>
        /// 
        /// <returns>The response from the ResetPersonalPIN service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        public virtual ResetPersonalPINResponse ResetPersonalPIN(ResetPersonalPINRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetPersonalPINRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetPersonalPINResponseUnmarshaller.Instance;

            return Invoke<ResetPersonalPINResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetPersonalPIN operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPersonalPIN operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetPersonalPIN
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        public virtual IAsyncResult BeginResetPersonalPIN(ResetPersonalPINRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetPersonalPINRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetPersonalPINResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetPersonalPIN operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetPersonalPIN.</param>
        /// 
        /// <returns>Returns a  ResetPersonalPINResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/ResetPersonalPIN">REST API Reference for ResetPersonalPIN Operation</seealso>
        public virtual ResetPersonalPINResponse EndResetPersonalPIN(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetPersonalPINResponse>(asyncResult);
        }

        #endregion
        
        #region  RestorePhoneNumber

        /// <summary>
        /// Moves a phone number from the <b>Deletion queue</b> back into the phone number <b>Inventory</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the RestorePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        public virtual RestorePhoneNumberResponse RestorePhoneNumber(RestorePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestorePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestorePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<RestorePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestorePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestorePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginRestorePhoneNumber(RestorePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestorePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestorePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestorePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestorePhoneNumber.</param>
        /// 
        /// <returns>Returns a  RestorePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/RestorePhoneNumber">REST API Reference for RestorePhoneNumber Operation</seealso>
        public virtual RestorePhoneNumberResponse EndRestorePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<RestorePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchAvailablePhoneNumbers

        /// <summary>
        /// Searches phone numbers that can be ordered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the SearchAvailablePhoneNumbers service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual SearchAvailablePhoneNumbersResponse SearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<SearchAvailablePhoneNumbersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchAvailablePhoneNumbers operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchAvailablePhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual IAsyncResult BeginSearchAvailablePhoneNumbers(SearchAvailablePhoneNumbersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchAvailablePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAvailablePhoneNumbersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchAvailablePhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchAvailablePhoneNumbers.</param>
        /// 
        /// <returns>Returns a  SearchAvailablePhoneNumbersResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SearchAvailablePhoneNumbers">REST API Reference for SearchAvailablePhoneNumbers Operation</seealso>
        public virtual SearchAvailablePhoneNumbersResponse EndSearchAvailablePhoneNumbers(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchAvailablePhoneNumbersResponse>(asyncResult);
        }

        #endregion
        
        #region  SendChannelMessage

        /// <summary>
        /// Sends a message to a particular channel that the member is a part of.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>STANDARD</code> messages can contain 4KB of data and the 1KB of metadata. <code>CONTROL</code>
        /// messages can contain 30 bytes of data and no metadata.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendChannelMessage service method.</param>
        /// 
        /// <returns>The response from the SendChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        public virtual SendChannelMessageResponse SendChannelMessage(SendChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendChannelMessageResponseUnmarshaller.Instance;

            return Invoke<SendChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginSendChannelMessage(SendChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendChannelMessage.</param>
        /// 
        /// <returns>Returns a  SendChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        public virtual SendChannelMessageResponse EndSendChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<SendChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  TagAttendee

        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK attendee.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagAttendee service method.</param>
        /// 
        /// <returns>The response from the TagAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagAttendee">REST API Reference for TagAttendee Operation</seealso>
        public virtual TagAttendeeResponse TagAttendee(TagAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagAttendeeResponseUnmarshaller.Instance;

            return Invoke<TagAttendeeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagAttendee">REST API Reference for TagAttendee Operation</seealso>
        public virtual IAsyncResult BeginTagAttendee(TagAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagAttendee.</param>
        /// 
        /// <returns>Returns a  TagAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagAttendee">REST API Reference for TagAttendee Operation</seealso>
        public virtual TagAttendeeResponse EndTagAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<TagAttendeeResponse>(asyncResult);
        }

        #endregion
        
        #region  TagMeeting

        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK meeting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagMeeting service method.</param>
        /// 
        /// <returns>The response from the TagMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagMeeting">REST API Reference for TagMeeting Operation</seealso>
        public virtual TagMeetingResponse TagMeeting(TagMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagMeetingResponseUnmarshaller.Instance;

            return Invoke<TagMeetingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagMeeting">REST API Reference for TagMeeting Operation</seealso>
        public virtual IAsyncResult BeginTagMeeting(TagMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagMeeting.</param>
        /// 
        /// <returns>Returns a  TagMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagMeeting">REST API Reference for TagMeeting Operation</seealso>
        public virtual TagMeetingResponse EndTagMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<TagMeetingResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagAttendee

        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK attendee.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagAttendee service method.</param>
        /// 
        /// <returns>The response from the UntagAttendee service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagAttendee">REST API Reference for UntagAttendee Operation</seealso>
        public virtual UntagAttendeeResponse UntagAttendee(UntagAttendeeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagAttendeeResponseUnmarshaller.Instance;

            return Invoke<UntagAttendeeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagAttendee operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagAttendee operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagAttendee
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagAttendee">REST API Reference for UntagAttendee Operation</seealso>
        public virtual IAsyncResult BeginUntagAttendee(UntagAttendeeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagAttendeeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagAttendeeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagAttendee operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagAttendee.</param>
        /// 
        /// <returns>Returns a  UntagAttendeeResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagAttendee">REST API Reference for UntagAttendee Operation</seealso>
        public virtual UntagAttendeeResponse EndUntagAttendee(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagAttendeeResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagMeeting

        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK meeting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagMeeting service method.</param>
        /// 
        /// <returns>The response from the UntagMeeting service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagMeeting">REST API Reference for UntagMeeting Operation</seealso>
        public virtual UntagMeetingResponse UntagMeeting(UntagMeetingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagMeetingResponseUnmarshaller.Instance;

            return Invoke<UntagMeetingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagMeeting operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagMeeting operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagMeeting
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagMeeting">REST API Reference for UntagMeeting Operation</seealso>
        public virtual IAsyncResult BeginUntagMeeting(UntagMeetingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagMeetingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagMeetingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagMeeting operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagMeeting.</param>
        /// 
        /// <returns>Returns a  UntagMeetingResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagMeeting">REST API Reference for UntagMeeting Operation</seealso>
        public virtual UntagMeetingResponse EndUntagMeeting(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagMeetingResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Untags the specified tags from the specified Amazon Chime SDK meeting resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccount

        /// <summary>
        /// Updates account details for the specified Amazon Chime account. Currently, only account
        /// name updates are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        public virtual UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccount(UpdateAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccount.</param>
        /// 
        /// <returns>Returns a  UpdateAccountResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        public virtual UpdateAccountResponse EndUpdateAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountSettings

        /// <summary>
        /// Updates the settings for the specified Amazon Chime account. You can update settings
        /// for remote control of shared screens, or for the dial-out option. For more information
        /// about these settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use
        /// the Policies Page</a> in the <i>Amazon Chime Administration Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountSettings.</param>
        /// 
        /// <returns>Returns a  UpdateAccountSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse EndUpdateAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAppInstance

        /// <summary>
        /// Updates <code>AppInstance</code> metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstance service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        public virtual UpdateAppInstanceResponse UpdateAppInstance(UpdateAppInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateAppInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstance operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateAppInstance(UpdateAppInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstance.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstance">REST API Reference for UpdateAppInstance Operation</seealso>
        public virtual UpdateAppInstanceResponse EndUpdateAppInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAppInstanceUser

        /// <summary>
        /// Updates the details for an <code>AppInstanceUser</code>. You can update names and
        /// metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser service method.</param>
        /// 
        /// <returns>The response from the UpdateAppInstanceUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        public virtual UpdateAppInstanceUserResponse UpdateAppInstanceUser(UpdateAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<UpdateAppInstanceUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppInstanceUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAppInstanceUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateAppInstanceUser(UpdateAppInstanceUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppInstanceUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAppInstanceUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAppInstanceUser.</param>
        /// 
        /// <returns>Returns a  UpdateAppInstanceUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateAppInstanceUser">REST API Reference for UpdateAppInstanceUser Operation</seealso>
        public virtual UpdateAppInstanceUserResponse EndUpdateAppInstanceUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAppInstanceUserResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBot

        /// <summary>
        /// Updates the status of the specified bot, such as starting or stopping the bot from
        /// running in your Amazon Chime Enterprise account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// 
        /// <returns>The response from the UpdateBot service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        public virtual UpdateBotResponse UpdateBot(UpdateBotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBotResponseUnmarshaller.Instance;

            return Invoke<UpdateBotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        public virtual IAsyncResult BeginUpdateBot(UpdateBotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBot.</param>
        /// 
        /// <returns>Returns a  UpdateBotResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        public virtual UpdateBotResponse EndUpdateBot(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBotResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Update a channel's attributes.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannelMessage

        /// <summary>
        /// Updates the content of a message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelMessage service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelMessage service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        public virtual UpdateChannelMessageResponse UpdateChannelMessage(UpdateChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelMessageResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelMessage operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannelMessage(UpdateChannelMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelMessage.</param>
        /// 
        /// <returns>Returns a  UpdateChannelMessageResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        public virtual UpdateChannelMessageResponse EndUpdateChannelMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannelReadMarker

        /// <summary>
        /// Sets the timestamp to the point when a user last read messages in a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelReadMarker service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelReadMarker service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        public virtual UpdateChannelReadMarkerResponse UpdateChannelReadMarker(UpdateChannelReadMarkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelReadMarkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelReadMarkerResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelReadMarkerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelReadMarker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelReadMarker operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelReadMarker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannelReadMarker(UpdateChannelReadMarkerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelReadMarkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelReadMarkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelReadMarker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelReadMarker.</param>
        /// 
        /// <returns>Returns a  UpdateChannelReadMarkerResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        public virtual UpdateChannelReadMarkerResponse EndUpdateChannelReadMarker(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelReadMarkerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGlobalSettings

        /// <summary>
        /// Updates global settings for the administrator's AWS account, such as Amazon Chime
        /// Business Calling and Amazon Chime Voice Connector settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateGlobalSettings(UpdateGlobalSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalSettings.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        public virtual UpdateGlobalSettingsResponse EndUpdateGlobalSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGlobalSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePhoneNumber

        /// <summary>
        /// Updates phone number details, such as product type or calling name, for the specified
        /// phone number ID. You can update one phone number detail at a time. For example, you
        /// can update either the product type or the calling name in one action.
        /// 
        ///  
        /// <para>
        /// For toll-free numbers, you must use the Amazon Chime Voice Connector product type.
        /// </para>
        ///  
        /// <para>
        /// Updates to outbound calling names can take up to 72 hours to complete. Pending updates
        /// to outbound calling names must be complete before you can request another update.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual IAsyncResult BeginUpdatePhoneNumber(UpdatePhoneNumberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumber.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual UpdatePhoneNumberResponse EndUpdatePhoneNumber(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePhoneNumberResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePhoneNumberSettings

        /// <summary>
        /// Updates the phone number settings for the administrator's AWS account, such as the
        /// default outbound calling name. You can update the default outbound calling name once
        /// every seven days. Outbound calling names can take up to 72 hours to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings service method.</param>
        /// 
        /// <returns>The response from the UpdatePhoneNumberSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        public virtual UpdatePhoneNumberSettingsResponse UpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumberSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePhoneNumberSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdatePhoneNumberSettings(UpdatePhoneNumberSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePhoneNumberSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePhoneNumberSettings.</param>
        /// 
        /// <returns>Returns a  UpdatePhoneNumberSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdatePhoneNumberSettings">REST API Reference for UpdatePhoneNumberSettings Operation</seealso>
        public virtual UpdatePhoneNumberSettingsResponse EndUpdatePhoneNumberSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePhoneNumberSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProxySession

        /// <summary>
        /// Updates the specified proxy session details, such as voice or SMS capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession service method.</param>
        /// 
        /// <returns>The response from the UpdateProxySession service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        public virtual UpdateProxySessionResponse UpdateProxySession(UpdateProxySessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxySessionResponseUnmarshaller.Instance;

            return Invoke<UpdateProxySessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxySession operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxySession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        public virtual IAsyncResult BeginUpdateProxySession(UpdateProxySessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProxySessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxySessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxySession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxySession.</param>
        /// 
        /// <returns>Returns a  UpdateProxySessionResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateProxySession">REST API Reference for UpdateProxySession Operation</seealso>
        public virtual UpdateProxySessionResponse EndUpdateProxySession(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProxySessionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoom

        /// <summary>
        /// Updates room details, such as the room name, for a room in an Amazon Chime Enterprise
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom service method.</param>
        /// 
        /// <returns>The response from the UpdateRoom service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual UpdateRoomResponse UpdateRoom(UpdateRoomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return Invoke<UpdateRoomResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoom operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoom
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoom(UpdateRoomRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoom.</param>
        /// 
        /// <returns>Returns a  UpdateRoomResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoom">REST API Reference for UpdateRoom Operation</seealso>
        public virtual UpdateRoomResponse EndUpdateRoom(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoomResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoomMembership

        /// <summary>
        /// Updates room membership details, such as the member role, for a room in an Amazon
        /// Chime Enterprise account. The member role designates whether the member is a chat
        /// room administrator or a general chat room member. The member role can be updated only
        /// for user IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoomMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateRoomMembership service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoomMembership">REST API Reference for UpdateRoomMembership Operation</seealso>
        public virtual UpdateRoomMembershipResponse UpdateRoomMembership(UpdateRoomMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomMembershipResponseUnmarshaller.Instance;

            return Invoke<UpdateRoomMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoomMembership operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoomMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoomMembership">REST API Reference for UpdateRoomMembership Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoomMembership(UpdateRoomMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoomMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoomMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoomMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoomMembership.</param>
        /// 
        /// <returns>Returns a  UpdateRoomMembershipResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateRoomMembership">REST API Reference for UpdateRoomMembership Operation</seealso>
        public virtual UpdateRoomMembershipResponse EndUpdateRoomMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoomMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSipMediaApplication

        /// <summary>
        /// Updates the details for the specified SIP media application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateSipMediaApplication service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        public virtual UpdateSipMediaApplicationResponse UpdateSipMediaApplication(UpdateSipMediaApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateSipMediaApplicationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipMediaApplication operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipMediaApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        public virtual IAsyncResult BeginUpdateSipMediaApplication(UpdateSipMediaApplicationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipMediaApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipMediaApplicationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipMediaApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipMediaApplication.</param>
        /// 
        /// <returns>Returns a  UpdateSipMediaApplicationResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipMediaApplication">REST API Reference for UpdateSipMediaApplication Operation</seealso>
        public virtual UpdateSipMediaApplicationResponse EndUpdateSipMediaApplication(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSipMediaApplicationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSipRule

        /// <summary>
        /// Updates the details for the specified SIP rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule service method.</param>
        /// 
        /// <returns>The response from the UpdateSipRule service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        public virtual UpdateSipRuleResponse UpdateSipRule(UpdateSipRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSipRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSipRule operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSipRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateSipRule(UpdateSipRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSipRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSipRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSipRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSipRule.</param>
        /// 
        /// <returns>Returns a  UpdateSipRuleResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateSipRule">REST API Reference for UpdateSipRule Operation</seealso>
        public virtual UpdateSipRuleResponse EndUpdateSipRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSipRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Updates user details for a specified user ID. Currently, only <code>LicenseType</code>
        /// updates are supported for this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserSettings

        /// <summary>
        /// Updates the settings for the specified user, such as phone number settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateUserSettings service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        public virtual UpdateUserSettingsResponse UpdateUserSettings(UpdateUserSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateUserSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserSettings operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserSettings(UpdateUserSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserSettings.</param>
        /// 
        /// <returns>Returns a  UpdateUserSettingsResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateUserSettings">REST API Reference for UpdateUserSettings Operation</seealso>
        public virtual UpdateUserSettingsResponse EndUpdateUserSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceConnector

        /// <summary>
        /// Updates details for the specified Amazon Chime Voice Connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceConnector service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        public virtual UpdateVoiceConnectorResponse UpdateVoiceConnector(UpdateVoiceConnectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceConnectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnector operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceConnector(UpdateVoiceConnectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnector.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnector">REST API Reference for UpdateVoiceConnector Operation</seealso>
        public virtual UpdateVoiceConnectorResponse EndUpdateVoiceConnector(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceConnectorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceConnectorGroup

        /// <summary>
        /// Updates details for the specified Amazon Chime Voice Connector group, such as the
        /// name and Amazon Chime Voice Connector priority ranking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceConnectorGroup service method, as returned by Chime.</returns>
        /// <exception cref="Amazon.Chime.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.Chime.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        public virtual UpdateVoiceConnectorGroupResponse UpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceConnectorGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceConnectorGroup operation on AmazonChimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceConnectorGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceConnectorGroup(UpdateVoiceConnectorGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVoiceConnectorGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceConnectorGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceConnectorGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceConnectorGroup.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceConnectorGroupResult from Chime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-2018-05-01/UpdateVoiceConnectorGroup">REST API Reference for UpdateVoiceConnectorGroup Operation</seealso>
        public virtual UpdateVoiceConnectorGroupResponse EndUpdateVoiceConnectorGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceConnectorGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}