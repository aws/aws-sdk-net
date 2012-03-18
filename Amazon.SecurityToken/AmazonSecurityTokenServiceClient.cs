/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// AWS Security Token Service <para>This is the <i>AWS Security Token Service API Reference</i> . The AWS Security Token Service is a web
    /// service that enables you to request temporary, limited-privilege credentials for AWS Identity and Access Management (IAM) users or for users
    /// that you authenticate (federated users). This guide provides descriptions of the AWS Security Token Service API as well as links to related
    /// content in Using IAM.</para> <para>For more detailed information about using this service, go to Granting Temporary Access to Your AWS
    /// Resources in <i>Using IAM</i> .</para> <para>For specific information about setting up signatures and authorization through the API, go to
    /// Making Query Requests in <i>Using IAM</i> .</para> <para>If you're new to AWS and need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at http://aws.amazon.com/documentation/.</para> <para>We will refer to Amazon
    /// Identity and Access Management using the abbreviated form IAM. All copyrights and legal protections still apply.</para>
    /// </summary>
    public class AmazonSecurityTokenServiceClient : AmazonWebServiceClient, AmazonSecurityTokenService
    {
    
        AbstractAWSSigner signer = new QueryStringSigner();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials defined in the App.config.
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
            : base(new EnvironmentAWSCredentials(), new AmazonSecurityTokenServiceConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials defined in the App.config.
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
            : base(new EnvironmentAWSCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials and an
        /// AmazonSecurityTokenServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User)
        {
        }
        

        #endregion
   
        #region GetSessionToken

        /// <summary>
        /// <para>The GetSessionToken action returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an Access
        /// Key ID, a Secret Access Key, and a security token. These credentials are valid for the specified duration only. The session duration for IAM
        /// users can be between one and 36 hours, with a default of 12 hours. The session duration for AWS account owners is restricted to one
        /// hour.</para> <para>For more information about using GetSessionToken to create temporary credentials, go to Creating Temporary Credentials to
        /// Enable Access for IAM Users in <i>Using IAM</i> .</para>
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
        /// <para>The GetSessionToken action returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an Access
        /// Key ID, a Secret Access Key, and a security token. These credentials are valid for the specified duration only. The session duration for IAM
        /// users can be between one and 36 hours, with a default of 12 hours. The session duration for AWS account owners is restricted to one
        /// hour.</para> <para>For more information about using GetSessionToken to create temporary credentials, go to Creating Temporary Credentials to
        /// Enable Access for IAM Users in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        public GetSessionTokenResponse GetSessionToken()
        {
            return GetSessionToken(new GetSessionTokenRequest());
        }
        

        #endregion
    
        #region GetFederationToken

        /// <summary>
        /// <para>The GetFederationToken action returns a set of temporary credentials for a federated user with the user name and policy specified in
        /// the request. The credentials consist of an Access Key ID, a Secret Access Key, and a security token. The credentials are valid for the
        /// specified duration, between one and 36 hours.</para> <para>The federated user who holds these credentials has any permissions allowed by the
        /// intersection of the specified policy and any resource or user policies that apply to the caller of the GetFederationToken API, and any
        /// resource policies that apply to the federated user's Amazon Resource Name (ARN). For more information about how token permissions work, see
        /// Controlling Permissions in Temporary Credentials in <i>Using AWS Identity and Access Management</i> . For information about using
        /// GetFederationToken to create temporary credentials, see Creating Temporary Credentials to Enable Access for Federated Users in <i>Using AWS
        /// Identity and Access Management</i> .</para>
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
    
    }
}
    
