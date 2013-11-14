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
    /// AWS Security Token Service <para> The AWS Security Token Service (AWS STS) is a web service that enables you to request temporary,
    /// limited-privilege credentials for AWS Identity and Access Management (AWS IAM) users or for users that you authenticate (federated users).
    /// This guide provides descriptions of the AWS STS API. For more detailed information about using this service, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UsingSTS/Welcome.html" >Using Temporary Security Credentials</a> . </para> <para><b>NOTE:</b> As
    /// an alternative to using the API, you can use one of the AWS SDKs, which consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a convenient way to create programmatic access to AWS STS.
    /// For example, the SDKs take care of cryptographically signing requests, managing errors, and retrying requests automatically. For information
    /// about the AWS SDKs, including how to download and install them, see the Tools for Amazon Web Services page. </para> <para> For information
    /// about setting up signatures and authorization through the API, go to <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" >Signing AWS API Requests</a> in the <i>AWS General
    /// Reference</i> . For general information about the Query API, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html" >Making Query Requests</a> in <i>Using IAM</i> . For
    /// information about using security tokens with other AWS products, go to <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UsingSTS/UsingTokens.html" >Using Temporary Security Credentials to Access AWS</a> in <i>Using
    /// Temporary Security Credentials</i> . </para> <para> If you're new to AWS and need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at <a href="http://aws.amazon.com/documentation/"
    /// >http://aws.amazon.com/documentation/</a> . </para> <para> <b>Endpoints</b> </para> <para>For information about AWS STS endpoints, see <a
    /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sts_region" >Regions and Endpoints</a> in the <i>AWS General Reference</i>
    /// .</para>
    /// </summary>
    public partial class AmazonSecurityTokenServiceClient : AmazonWebServiceClient, IAmazonSecurityTokenService
    {
    AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials and an
        /// AmazonSecurityTokenServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// AmazonSecurityTokenServiceClient Configuration object. 
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. 
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


        #region AssumeRole

        /// <summary>
        /// <para> Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) that you
        /// can use to access AWS resources that you might not normally have access to. Typically, you use <c>AssumeRole</c> for cross-account access or
        /// federation. </para> <para> For cross-account access, imagine that you own multiple accounts and need to access resources in each account.
        /// You could create long-term credentials in each account to access those resources. However, managing all those credentials and remembering
        /// which one can access which account can be time consuming. Instead, you can create one set of long-term credentials in one account and then
        /// use temporary security credentials to access all the other accounts by assuming roles in those accounts. For more information about roles,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Roles</a> in <i>Using IAM</i> . </para> <para> For
        /// federation, you can, for example, grant single sign-on access to the AWS Management Console. If you already have an identity and
        /// authentication system in your corporate network, you don't have to recreate user identities in AWS in order to grant those user identities
        /// access to AWS. Instead, after a user has been authenticated, you call <c>AssumeRole</c> (and specify the role with the appropriate
        /// permissions) to get temporary security credentials for that user. With those temporary security credentials, you construct a sign-in URL
        /// that users can use to access the console. For more information, see <a
        /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSUseCases.html" >Scenarios for Granting Temporary Access</a> in <i>AWS Security Token
        /// Service</i> . </para> <para> The temporary security credentials are valid for the duration that you specified when calling <c>AssumeRole</c>
        /// , which can be from 900 seconds (15 minutes) to 3600 seconds (1 hour). The default is 1 hour. </para> <para>Optionally, you can pass an AWS
        /// IAM access policy to this operation. The temporary security credentials that are returned by the operation have the permissions that are
        /// associated with the access policy of the role that is being assumed, except for any permissions explicitly denied by the policy you pass.
        /// This gives you a way to further restrict the permissions for the federated user. These policies and any applicable resource-based policies
        /// are evaluated when calls to AWS are made using the temporary security credentials. </para> <para> To assume a role, your AWS account must be
        /// trusted by the role. The trust relationship is defined in the role's trust policy when the IAM role is created. You must also have a policy
        /// that allows you to call <c>sts:AssumeRole</c> . </para> <para> <b>Important:</b> You cannot call <c>AssumeRole</c> by using AWS account
        /// credentials; access will be denied. You must use IAM user credentials or temporary security credentials to call <c>AssumeRole</c> . </para>
        /// 
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRole"/>
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRole"/>
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
    
        #region AssumeRoleWithSAML

        /// <summary>
        /// <para> Returns a set of temporary security credentials for users who have been authenticated via a SAML authentication response. This
        /// operation provides a mechanism for tying an enterprise identity store or directory to role-based AWS access without user-specific
        /// credentials or configuration. </para> <para> The temporary security credentials returned by this operation consist of an access key ID, a
        /// secret access key, and a security token. Applications can use these temporary security credentials to sign calls to AWS services. The
        /// credentials are valid for the duration that you specified when calling <c>AssumeRoleWithSAML</c> , which can be up to 3600 seconds (1 hour)
        /// or until the time specified in the SAML authentication response's <c>NotOnOrAfter</c> value, whichever is shorter.</para>
        /// <para><b>NOTE:</b>The maximum duration for a session is 1 hour, and the minimum duration is 15 minutes, even if values outside this range
        /// are specified. </para> <para>Optionally, you can pass an AWS IAM access policy to this operation. The temporary security credentials that
        /// are returned by the operation have the permissions that are associated with the access policy of the role being assumed, except for any
        /// permissions explicitly denied by the policy you pass. This gives you a way to further restrict the permissions for the federated user. These
        /// policies and any applicable resource-based policies are evaluated when calls to AWS are made using the temporary security credentials.
        /// </para> <para> Before your application can call <c>AssumeRoleWithSAML</c> , you must configure your SAML identity provider (IdP) to issue
        /// the claims required by AWS. Additionally, you must use AWS Identity and Access Management (AWS IAM) to create a SAML provider entity in your
        /// AWS account that represents your identity provider, and create an AWS IAM role that specifies this SAML provider in its trust policy.
        /// </para> <para> Calling <c>AssumeRoleWithSAML</c> does not require the use of AWS security credentials. The identity of the caller is
        /// validated by using keys in the metadata document that is uploaded for the SAML provider entity for your identity provider. </para> <para>For
        /// more information, see the following resources:</para>
        /// <ul>
        /// <li> <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html" >Creating Temporary Security Credentials for SAML
        /// Federation</a> in the <i>Using Temporary Security Credentials</i> guide. </li>
        /// <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/idp-managing-identityproviders.html" >SAML Providers</a> in the <i>Using
        /// IAM</i> guide. </li>
        /// <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html" >Configuring a Relying Party and Claims in
        /// the Using IAM guide. </a> </li>
        /// <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml.html" >Creating a Role for SAML-Based Federation</a> in the
        /// <i>Using IAM</i> guide. </li>
        /// 
        /// </ul>
        /// 
        /// </summary>
        /// 
        /// <param name="assumeRoleWithSAMLRequest">Container for the necessary parameters to execute the AssumeRoleWithSAML service method on
        ///          AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithSAML service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="PackedPolicyTooLargeException"/>
        /// <exception cref="IDPRejectedClaimException"/>
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="InvalidIdentityTokenException"/>
        /// <exception cref="ExpiredTokenException"/>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest assumeRoleWithSAMLRequest)
        {
            IAsyncResult asyncResult = invokeAssumeRoleWithSAML(assumeRoleWithSAMLRequest, null, null, true);
            return EndAssumeRoleWithSAML(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithSAML operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRoleWithSAML"/>
        /// </summary>
        /// 
        /// <param name="assumeRoleWithSAMLRequest">Container for the necessary parameters to execute the AssumeRoleWithSAML operation on
        ///          AmazonSecurityTokenService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAssumeRoleWithSAML operation.</returns>
        public IAsyncResult BeginAssumeRoleWithSAML(AssumeRoleWithSAMLRequest assumeRoleWithSAMLRequest, AsyncCallback callback, object state)
        {
            return invokeAssumeRoleWithSAML(assumeRoleWithSAMLRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssumeRoleWithSAML operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRoleWithSAML"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRoleWithSAML.</param>
        /// 
        /// <returns>Returns a AssumeRoleWithSAMLResult from AmazonSecurityTokenService.</returns>
        public AssumeRoleWithSAMLResponse EndAssumeRoleWithSAML(IAsyncResult asyncResult)
        {
            return endOperation<AssumeRoleWithSAMLResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssumeRoleWithSAML(AssumeRoleWithSAMLRequest assumeRoleWithSAMLRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssumeRoleWithSAMLRequestMarshaller().Marshall(assumeRoleWithSAMLRequest);
            var unmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.GetInstance();
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
        /// long-term AWS credentials. </para> <para> The temporary security credentials consist of an access key ID, a secret access key, and a
        /// security token. Applications can use these temporary security credentials to sign calls to AWS service APIs. The credentials are valid for
        /// the duration that you specified when calling <c>AssumeRoleWithWebIdentity</c> , which can be from 900 seconds (15 minutes) to 3600 seconds
        /// (1 hour). By default, the temporary security credentials are valid for 1 hour. </para> <para>Optionally, you can pass an AWS IAM access
        /// policy to this operation. The temporary security credentials that are returned by the operation have the permissions that are associated
        /// with the access policy of the role being assumed, except for any permissions explicitly denied by the policy you pass. This gives you a way
        /// to further restrict the permissions for the federated user. These policies and any applicable resource-based policies are evaluated when
        /// calls to AWS are made using the temporary security credentials. </para> <para> Before your application can call
        /// <c>AssumeRoleWithWebIdentity</c> , you must have an identity token from a supported identity provider and create a role that the application
        /// can assume. The role that your application assumes must trust the identity provider that is associated with the identity token. In other
        /// words, the identity provider must be specified in the role's trust policy. </para> <para> For more information about how to use web identity
        /// federation and the <c>AssumeRoleWithWebIdentity</c> , see the following resources: </para>
        /// <ul>
        /// <li> <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSUseCases.html#MobileApplication-KnownProvider" > Creating a Mobile
        /// Application with Third-Party Sign-In</a> and <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingWIF.html" > Creating Temporary
        /// Security Credentials for Mobile Apps Using Third-Party Identity Providers</a> in <i>Using Temporary Security Credentials</i> . </li>
        /// <li> <a href="https://web-identity-federation-playground.s3.amazonaws.com/index.html" > Web Identity Federation Playground</a> . This
        /// interactive website lets you walk through the process of authenticating via Login with Amazon, Facebook, or Google, getting temporary
        /// security credentials, and then using those credentials to make a request to AWS. </li>
        /// <li> <a href="http://aws.amazon.com/sdkforios/" >AWS SDK for iOS</a> and <a href="http://aws.amazon.com/sdkforandroid/" >AWS SDK for
        /// Android</a> . These toolkits contain sample apps that show how to invoke the identity providers, and then how to use the information from
        /// these providers to get and use temporary security credentials. </li>
        /// <li> <a href="http://aws.amazon.com/articles/4617974389850313" >Web Identity Federation with Mobile Applications</a> . This article
        /// discusses web identity federation and shows an example of how to use web identity federation to get access to content in Amazon S3. </li>
        /// 
        /// </ul>
        /// 
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRoleWithWebIdentity"/>
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRoleWithWebIdentity"/>
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
    
        #region DecodeAuthorizationMessage

        /// <summary>
        /// <para> Decodes additional information about the authorization status of a request from an encoded message returned in response to an AWS
        /// request. </para> <para> For example, if a user is not authorized to perform an action that he or she has requested, the request returns a
        /// <c>Client.UnauthorizedOperation</c> response (an HTTP 403 response). Some AWS actions additionally return an encoded message that can
        /// provide details about this authorization failure. </para> <para><b>NOTE:</b> Only certain AWS actions return an encoded authorization
        /// message. The documentation for an individual action indicates whether that action returns an encoded message in addition to returning an
        /// HTTP code. </para> <para>The message is encoded because the details of the authorization status can constitute privileged information that
        /// the user who requested the action should not see. To decode an authorization status message, a user must be granted permissions via an AWS
        /// IAM policy to request the <c>DecodeAuthorizationMessage</c> (
        /// <c>sts:DecodeAuthorizationMessage</c> ) action. </para> <para> The decoded message includes the following type of
        /// information: </para>
        /// <ul>
        /// <li>Whether the request was denied due to an explicit deny or due to the absence of an explicit allow. For more information, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccessPolicyLanguage_EvaluationLogic.html#policy-eval-denyallow" >Determining Whether
        /// a Request is Allowed or Denied</a> in <i>Using AWS IAM</i> . </li>
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.DecodeAuthorizationMessage"/>
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.DecodeAuthorizationMessage"/>
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
    
        #region GetFederationToken

        /// <summary>
        /// <para> Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) for a
        /// federated user. A typical use is in a proxy application that is getting temporary security credentials on behalf of distributed applications
        /// inside a corporate network. Because you must call the <c>GetFederationToken</c> action using the long-term security credentials of an IAM
        /// user, this call is appropriate in contexts where those credentials can be safely stored, usually in a server-based application. </para>
        /// <para> <b>Note:</b> Do not use this call in mobile applications or client-based web applications that directly get temporary security
        /// credentials. For those types of applications, use <c>AssumeRoleWithWebIdentity</c> . </para> <para>The <c>GetFederationToken</c> action must
        /// be called by using the long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are
        /// valid for the specified duration, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using
        /// account credentials have a maximum duration of 3600 seconds (1 hour). </para> <para>Optionally, you can pass an AWS IAM access policy to
        /// this operation. The temporary security credentials that are returned by the operation have the permissions that are associated with the
        /// entity that is making the <c>GetFederationToken</c> call, except for any permissions explicitly denied by the policy you pass. This gives
        /// you a way to further restrict the permissions for the federated user. These policies and any applicable resource-based policies are
        /// evaluated when calls to AWS are made using the temporary security credentials. </para> <para> For more information about how permissions
        /// work, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/TokenPermissions.html" >Controlling Permissions in Temporary
        /// Credentials</a> in <i>Using Temporary Security Credentials</i> . For information about using <c>GetFederationToken</c> to create temporary
        /// security credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingFedTokens.html" >Creating Temporary Credentials
        /// to Enable Access for Federated Users</a> in <i>Using Temporary Security Credentials</i> . </para>
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.GetFederationToken"/>
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.GetFederationToken"/>
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
    
        #region GetSessionToken

        /// <summary>
        /// <para> Returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an access key ID, a secret access
        /// key, and a security token. Typically, you use <c>GetSessionToken</c> if you want use MFA to protect programmatic calls to specific AWS APIs
        /// like Amazon EC2 <c>StopInstances</c> . MFA-enabled IAM users would need to call <c>GetSessionToken</c> and submit an MFA code that is
        /// associated with their MFA device. Using the temporary security credentials that are returned from the call, IAM users can then make
        /// programmatic calls to APIs that require MFA authentication. </para> <para> The <c>GetSessionToken</c> action must be called by using the
        /// long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are valid for the duration
        /// that you specify, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using account credentials
        /// have a maximum duration of 3600 seconds (1 hour). </para> <para>Optionally, you can pass an AWS IAM access policy to this operation. The
        /// temporary security credentials that are returned by the operation have the permissions that are associated with the entity that is making
        /// the <c>GetSessionToken</c> call, except for any permissions explicitly denied by the policy you pass. This gives you a way to further
        /// restrict the permissions for the federated user. These policies and any applicable resource-based policies are evaluated when calls to AWS
        /// are made using the temporary security credentials. </para> <para>For more information about using <c>GetSessionToken</c> to create temporary
        /// credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingSessionTokens.html" > Creating Temporary Credentials to
        /// Enable Access for IAM Users </a> in <i>Using IAM</i> .
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.GetSessionToken"/>
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
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.GetSessionToken"/>
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
        /// have a maximum duration of 3600 seconds (1 hour). </para> <para>Optionally, you can pass an AWS IAM access policy to this operation. The
        /// temporary security credentials that are returned by the operation have the permissions that are associated with the entity that is making
        /// the <c>GetSessionToken</c> call, except for any permissions explicitly denied by the policy you pass. This gives you a way to further
        /// restrict the permissions for the federated user. These policies and any applicable resource-based policies are evaluated when calls to AWS
        /// are made using the temporary security credentials. </para> <para>For more information about using <c>GetSessionToken</c> to create temporary
        /// credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingSessionTokens.html" > Creating Temporary Credentials to
        /// Enable Access for IAM Users </a> in <i>Using IAM</i> .
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
    
    }
}
    
