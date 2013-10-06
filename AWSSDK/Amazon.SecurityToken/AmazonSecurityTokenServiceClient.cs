/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.SecurityToken
{
    /// <summary>
    /// Implementation for accessing AmazonSecurityTokenService.
    ///  
    /// AWS Security Token Service <para> The AWS Security Token Service is a web service that enables you to request temporary, limited-privilege
    /// credentials for AWS Identity and Access Management (IAM) users or for users that you authenticate (federated users). This guide provides
    /// descriptions of the AWS Security Token Service API. </para> <para> For more detailed information about using this service, go to Using
    /// Temporary Security Credentials. </para> <para> For information about setting up signatures and authorization through the API, go to Signing
    /// AWS API Requests in the <i>AWS General Reference</i> . For general information about the Query API, go to Making Query Requests in <i>Using
    /// IAM</i> . For information about using security tokens with other AWS products, go to Using Temporary Security Credentials to Access AWS in
    /// <i>Using Temporary Security Credentials</i> .
    /// </para> <para> If you're new to AWS and need additional technical information about a specific AWS product, you can find the product's
    /// technical documentation at http://aws.amazon.com/documentation/. </para> <para> We will refer to Amazon Identity and Access Management using
    /// the abbreviated form IAM. All copyrights and legal protections still apply. </para>
    /// </summary>
    public class AmazonSecurityTokenServiceClient : AmazonWebServiceClient, AmazonSecurityTokenService
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSecurityTokenServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSecurityTokenService Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityTokenServiceConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials and an
        /// AmazonSecurityTokenServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
   
        #region GetSessionToken

        /// <summary>
        /// <para> Returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an access key ID, a secret access
        /// key, and a security token. Typically, you use <c>GetSessionToken</c> if you want use MFA to protect programmatic calls to specific AWS APIs
        /// like Amazon EC2 <c>StopInstances</c> . MFA-enabled IAM users would need to call <c>GetSessionToken</c> and submit an MFA code that is
        /// associated with their MFA device. Using the temporary security credentials that are returned from the call, IAM users can then make
        /// programmatic calls to APIs that require MFA authentication. </para> <para> The <c>GetSessionToken</c> action must be called by using the
        /// long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are valid for the duration
        /// that you specify, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using account credentials
        /// have a maximum duration of 3600 seconds (1 hour). </para> <para> The permissions that are granted to the federated user are the intersection
        /// of the policy that is passed with the <c>GetSessionToken</c> request and policies that are associated with of the entity making the
        /// <c>GetSessionToken</c> call. </para> <para> For more information about using <c>GetSessionToken</c> to create temporary credentials, go to
        /// Creating Temporary Credentials to Enable Access for IAM Users in <i>Using IAM</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getSessionTokenRequest">Container for the necessary parameters to execute the GetSessionToken service method on
        ///          AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        public GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest getSessionTokenRequest)
        {
            IAsyncResult asyncResult = invokeGetSessionToken(getSessionTokenRequest, null, null, true);
            return EndGetSessionToken(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetSessionToken"/>
        /// </summary>
        /// 
        /// <param name="getSessionTokenRequest">Container for the necessary parameters to execute the GetSessionToken operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionToken
        ///         operation.</returns>
        public IAsyncResult BeginGetSessionToken(GetSessionTokenRequest getSessionTokenRequest, AsyncCallback callback, object state)
        {
            return invokeGetSessionToken(getSessionTokenRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetSessionToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetSessionToken"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionToken.</param>
        /// 
        /// <returns>Returns a GetSessionTokenResult from AmazonSecurityTokenService.</returns>
        public GetSessionTokenResponse EndGetSessionToken(IAsyncResult asyncResult)
        {
            return endOperation<GetSessionTokenResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetSessionToken(GetSessionTokenRequest getSessionTokenRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetSessionTokenRequestMarshaller().Marshall(getSessionTokenRequest);
            var unmarshaller = GetSessionTokenResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an access key ID, a secret access
        /// key, and a security token. Typically, you use <c>GetSessionToken</c> if you want use MFA to protect programmatic calls to specific AWS APIs
        /// like Amazon EC2 <c>StopInstances</c> . MFA-enabled IAM users would need to call <c>GetSessionToken</c> and submit an MFA code that is
        /// associated with their MFA device. Using the temporary security credentials that are returned from the call, IAM users can then make
        /// programmatic calls to APIs that require MFA authentication. </para> <para> The <c>GetSessionToken</c> action must be called by using the
        /// long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are valid for the duration
        /// that you specify, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using account credentials
        /// have a maximum duration of 3600 seconds (1 hour). </para> <para> The permissions that are granted to the federated user are the intersection
        /// of the policy that is passed with the <c>GetSessionToken</c> request and policies that are associated with of the entity making the
        /// <c>GetSessionToken</c> call. </para> <para> For more information about using <c>GetSessionToken</c> to create temporary credentials, go to
        /// Creating Temporary Credentials to Enable Access for IAM Users in <i>Using IAM</i> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        public GetSessionTokenResponse GetSessionToken()
        {
            return GetSessionToken(new GetSessionTokenRequest());
        }
        

        #endregion
    
        #region DecodeAuthorizationMessage

        /// <summary>
        /// <para> Decodes additional information about the authorization status of a request from an encoded message returned in response to an AWS
        /// request. </para> <para> For example, if a user is not authorized to perform an action that he or she has requested, the request returns a
        /// <c>Client.UnauthorizedOperation</c> response (an HTTP 403 response). Some AWS actions additionally return an encoded message that can
        /// provide details about this authorization failure. </para> <para><b>NOTE:</b> Only certain AWS actions return an encoded authorization
        /// message. The documentation for an individual action indicates whether that action returns an encoded message in addition to returning an
        /// HTTP code. </para> <para>The message is encoded because the details of the authorization status can constitute privileged information that
        /// the user who requested the action should not see. To decode an authorization status message, a user must be granted permissions via an IAM
        /// policy to request the <c>DecodeAuthorizationMessage</c> (
        /// <c>sts:DecodeAuthorizationMessage</c> ) action. </para> <para> The decoded message includes the following type of
        /// information: </para>
        /// <ul>
        /// <li>Whether the request was denied due to an explicit deny or due to the absence of an explicit allow. For more information, see
        /// Determining Whether a Request is Allowed or Denied in <i>Using IAM</i> .
        /// </li>
        /// <li>The principal who made the request.</li>
        /// <li>The requested action.</li>
        /// <li>The requested resource.</li>
        /// <li>The values of condition keys in the context of the user's request.</li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="decodeAuthorizationMessageRequest">Container for the necessary parameters to execute the DecodeAuthorizationMessage service
        ///          method on AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the DecodeAuthorizationMessage service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="InvalidAuthorizationMessageException"/>
        public DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest)
        {
            IAsyncResult asyncResult = invokeDecodeAuthorizationMessage(decodeAuthorizationMessageRequest, null, null, true);
            return EndDecodeAuthorizationMessage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DecodeAuthorizationMessage operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.DecodeAuthorizationMessage"/>
        /// </summary>
        /// 
        /// <param name="decodeAuthorizationMessageRequest">Container for the necessary parameters to execute the DecodeAuthorizationMessage operation
        ///          on AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDecodeAuthorizationMessage operation.</returns>
        public IAsyncResult BeginDecodeAuthorizationMessage(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest, AsyncCallback callback, object state)
        {
            return invokeDecodeAuthorizationMessage(decodeAuthorizationMessageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DecodeAuthorizationMessage operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.DecodeAuthorizationMessage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecodeAuthorizationMessage.</param>
        /// 
        /// <returns>Returns a DecodeAuthorizationMessageResult from AmazonSecurityTokenService.</returns>
        public DecodeAuthorizationMessageResponse EndDecodeAuthorizationMessage(IAsyncResult asyncResult)
        {
            return endOperation<DecodeAuthorizationMessageResponse>(asyncResult);
        }
        
        IAsyncResult invokeDecodeAuthorizationMessage(DecodeAuthorizationMessageRequest decodeAuthorizationMessageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DecodeAuthorizationMessageRequestMarshaller().Marshall(decodeAuthorizationMessageRequest);
            var unmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AssumeRoleWithWebIdentity

        /// <summary>
        /// <para> Returns a set of temporary security credentials for users who have been authenticated in a mobile or web application with a web
        /// identity provider, such as Login with Amazon, Facebook, or Google. <c>AssumeRoleWithWebIdentity</c> is an API call that does not require the
        /// use of AWS security credentials. Therefore, you can distribute an application (for example, on mobile devices) that requests temporary
        /// security credentials without including long-term AWS credentials in the application or by deploying server-based proxy services that use
        /// long-term AWS credentials. For more information, see Creating a Mobile Application with Third-Party Sign-In in <i>AWS Security Token
        /// Service</i> .
        /// </para> <para> The temporary security credentials consist of an access key ID, a secret access key, and a security token. Applications
        /// can use these temporary security credentials to sign calls to AWS service APIs. The credentials are valid for the duration that you
        /// specified when calling <c>AssumeRoleWithWebIdentity</c> , which can be from 900 seconds (15 minutes) to 3600 seconds (1 hour). By default,
        /// the temporary security credentials are valid for 1 hour. </para> <para> The temporary security credentials that are returned from the
        /// <c>AssumeRoleWithWebIdentity</c> response have the permissions that are associated with the access policy of the role being assumed. You can
        /// further restrict the permissions of the temporary security credentials by passing a policy in the request. The resulting permissions are an
        /// intersection of the role's access policy and the policy that you passed. These policies and any applicable resource-based policies are
        /// evaluated when calls to AWS service APIs are made using the temporary security credentials. </para> <para> Before your application can call
        /// <c>AssumeRoleWithWebIdentity</c> , you must have an identity token from a supported identity provider and create a role that the application
        /// can assume. The role that your application assumes must trust the identity provider that is associated with the identity token. In other
        /// words, the identity provider must be specified in the role's trust policy. For more information, see Creating Temporary Security Credentials
        /// for Mobile Apps Using Third-Party Identity Providers .
        /// </para>
        /// </summary>
        /// 
        /// <param name="assumeRoleWithWebIdentityRequest">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity service
        ///          method on AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithWebIdentity service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="PackedPolicyTooLargeException"/>
        /// <exception cref="IDPRejectedClaimException"/>
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="InvalidIdentityTokenException"/>
        /// <exception cref="ExpiredTokenException"/>
        /// <exception cref="IDPCommunicationErrorException"/>
        public AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest assumeRoleWithWebIdentityRequest)
        {
            IAsyncResult asyncResult = invokeAssumeRoleWithWebIdentity(assumeRoleWithWebIdentityRequest, null, null, true);
            return EndAssumeRoleWithWebIdentity(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.AssumeRoleWithWebIdentity"/>
        /// </summary>
        /// 
        /// <param name="assumeRoleWithWebIdentityRequest">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAssumeRoleWithWebIdentity operation.</returns>
        public IAsyncResult BeginAssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest assumeRoleWithWebIdentityRequest, AsyncCallback callback, object state)
        {
            return invokeAssumeRoleWithWebIdentity(assumeRoleWithWebIdentityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.AssumeRoleWithWebIdentity"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRoleWithWebIdentity.</param>
        /// 
        /// <returns>Returns a AssumeRoleWithWebIdentityResult from AmazonSecurityTokenService.</returns>
        public AssumeRoleWithWebIdentityResponse EndAssumeRoleWithWebIdentity(IAsyncResult asyncResult)
        {
            return endOperation<AssumeRoleWithWebIdentityResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest assumeRoleWithWebIdentityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssumeRoleWithWebIdentityRequestMarshaller().Marshall(assumeRoleWithWebIdentityRequest);
            var unmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetFederationToken

        /// <summary>
        /// <para> Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) for a
        /// federated user. A typical use is in a proxy application that is getting temporary security credentials on behalf of distributed applications
        /// inside a corporate network. Because you must call the <c>GetFederationToken</c> action using the long-term security credentials of an IAM
        /// user, this call is appropriate in contexts where those credentials can be safely stored, usually in a server-based application. </para>
        /// <para> <b>Note:</b> Do not use this call in mobile applications or client-based web applications that directly get temporary security
        /// credentials. For those types of applications, use <c>AssumeRoleWithWebIdentity</c> .
        /// </para> <para> The <c>GetFederationToken</c> action must be called by using the long-term AWS security credentials of the AWS account or
        /// an IAM user. Credentials that are created by IAM users are valid for the specified duration, between 900 seconds (15 minutes) and 129600
        /// seconds (36 hours); credentials that are created by using account credentials have a maximum duration of 3600 seconds (1 hour). </para>
        /// <para> The permissions that are granted to the federated user are the intersection of the policy that is passed with the
        /// <c>GetFederationToken</c> request and policies that are associated with of the entity making the <c>GetFederationToken</c> call. </para>
        /// <para> For more information about how permissions work, see Controlling Permissions in Temporary Credentials in <i>Using Temporary Security
        /// Credentials</i> . For information about using <c>GetFederationToken</c> to create temporary security credentials, see Creating Temporary
        /// Credentials to Enable Access for Federated Users in <i>Using Temporary Security Credentials</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getFederationTokenRequest">Container for the necessary parameters to execute the GetFederationToken service method on
        ///          AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="PackedPolicyTooLargeException"/>
        /// <exception cref="MalformedPolicyDocumentException"/>
        public GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest getFederationTokenRequest)
        {
            IAsyncResult asyncResult = invokeGetFederationToken(getFederationTokenRequest, null, null, true);
            return EndGetFederationToken(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetFederationToken"/>
        /// </summary>
        /// 
        /// <param name="getFederationTokenRequest">Container for the necessary parameters to execute the GetFederationToken operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetFederationToken operation.</returns>
        public IAsyncResult BeginGetFederationToken(GetFederationTokenRequest getFederationTokenRequest, AsyncCallback callback, object state)
        {
            return invokeGetFederationToken(getFederationTokenRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetFederationToken operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetFederationToken"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFederationToken.</param>
        /// 
        /// <returns>Returns a GetFederationTokenResult from AmazonSecurityTokenService.</returns>
        public GetFederationTokenResponse EndGetFederationToken(IAsyncResult asyncResult)
        {
            return endOperation<GetFederationTokenResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetFederationToken(GetFederationTokenRequest getFederationTokenRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetFederationTokenRequestMarshaller().Marshall(getFederationTokenRequest);
            var unmarshaller = GetFederationTokenResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AssumeRole

        /// <summary>
        /// <para> Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) that you
        /// can use to access AWS resources that you might not normally have access to. Typically, you use <c>AssumeRole</c> for cross-account access or
        /// federation. </para> <para> For cross-account access, imagine that you own multiple accounts and need to access resources in each account.
        /// You could create long-term credentials in each account to access those resources. However, managing all those credentials and remembering
        /// which one can access which account can be time consuming. Instead, you can create one set of long-term credentials in one account and then
        /// use temporary security credentials to access all the other accounts by assuming roles in those accounts. For more information about roles,
        /// see Roles in <i>Using IAM</i> .
        /// </para> <para> For federation, you can, for example, grant single sign-on access to the AWS Management Console. If you already have an
        /// identity and authentication system in your corporate network, you don't have to recreate user identities in AWS in order to grant those user
        /// identities access to AWS. Instead, after a user has been authenticated, you call <c>AssumeRole</c> (and specify the role with the
        /// appropriate permissions) to get temporary security credentials for that user. With those temporary security credentials, you construct a
        /// sign-in URL that users can use to access the console. For more information, see Scenarios for Granting Temporary Access in <i>AWS Security
        /// Token Service</i> .
        /// </para> <para> The temporary security credentials are valid for the duration that you specified when calling <c>AssumeRole</c> , which
        /// can be from 900 seconds (15 minutes) to 3600 seconds (1 hour). The default is 1 hour. </para> <para> The temporary security credentials that
        /// are returned from the <c>AssumeRoleWithWebIdentity</c> response have the permissions that are associated with the access policy of the role
        /// being assumed and any policies that are associated with the AWS resource being accessed. You can further restrict the permissions of the
        /// temporary security credentials by passing a policy in the request. The resulting permissions are an intersection of the role's access policy
        /// and the policy that you passed. These policies and any applicable resource-based policies are evaluated when calls to AWS service APIs are
        /// made using the temporary security credentials. </para> <para> To assume a role, your AWS account must be trusted by the role. The trust
        /// relationship is defined in the role's trust policy when the IAM role is created. You must also have a policy that allows you to call
        /// <c>sts:AssumeRole</c> .
        /// </para> <para> <b>Important:</b> You cannot call <c>Assumerole</c> by using AWS account credentials; access will be denied. You must use
        /// IAM user credentials or temporary security credentials to call <c>AssumeRole</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="assumeRoleRequest">Container for the necessary parameters to execute the AssumeRole service method on
        ///          AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the AssumeRole service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="PackedPolicyTooLargeException"/>
        /// <exception cref="MalformedPolicyDocumentException"/>
        public AssumeRoleResponse AssumeRole(AssumeRoleRequest assumeRoleRequest)
        {
            IAsyncResult asyncResult = invokeAssumeRole(assumeRoleRequest, null, null, true);
            return EndAssumeRole(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.AssumeRole"/>
        /// </summary>
        /// 
        /// <param name="assumeRoleRequest">Container for the necessary parameters to execute the AssumeRole operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRole
        ///         operation.</returns>
        public IAsyncResult BeginAssumeRole(AssumeRoleRequest assumeRoleRequest, AsyncCallback callback, object state)
        {
            return invokeAssumeRole(assumeRoleRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssumeRole operation.
        /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.AssumeRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRole.</param>
        /// 
        /// <returns>Returns a AssumeRoleResult from AmazonSecurityTokenService.</returns>
        public AssumeRoleResponse EndAssumeRole(IAsyncResult asyncResult)
        {
            return endOperation<AssumeRoleResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssumeRole(AssumeRoleRequest assumeRoleRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssumeRoleRequestMarshaller().Marshall(assumeRoleRequest);
            var unmarshaller = AssumeRoleResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
