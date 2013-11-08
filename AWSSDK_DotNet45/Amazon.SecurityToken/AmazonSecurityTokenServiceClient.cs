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
using System.Threading.Tasks;

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
    /// AWS Security Token Service <para>The AWS Security Token Service is a web service that enables you to request temporary, limited-privilege
    /// credentials for AWS Identity and Access Management (IAM) users or for users that you authenticate (federated users). This guide provides
    /// descriptions of the AWS Security Token Service API.</para> <para> For more detailed information about using this service, go to <a href="http://docs.aws.amazon.com/IAM/latest/UsingSTS/Welcome.html">Using Temporary Security Credentials</a> .
    /// </para> <para> For information about setting up signatures and authorization through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing AWS API Requests</a> in the <i>AWS General
    /// Reference</i> . For general information about the Query API, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making Query Requests</a> in <i>Using IAM</i> . For
    /// information about using security tokens with other AWS products, go to <a href="http://docs.aws.amazon.com/IAM/latest/UsingSTS/UsingTokens.html">Using Temporary Security Credentials to Access AWS</a> in <i>Using
    /// Temporary Security Credentials</i> .
    /// </para> <para> If you're new to AWS and need additional technical information about a specific AWS product, you can find the product's
    /// technical documentation at <a href="http://aws.amazon.com/documentation/">http://aws.amazon.com/documentation/</a> .
    /// </para> <para> We will refer to Amazon Identity and Access Management using the abbreviated form IAM. All copyrights and legal
    /// protections still apply. </para>
    /// </summary>
	public partial class AmazonSecurityTokenServiceClient : AmazonWebServiceClient, Amazon.SecurityToken.IAmazonSecurityTokenService
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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

 
        /// <summary>
        /// <para> Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) that you
        /// can use to access AWS resources that you might not normally have access to. Typically, you use <c>AssumeRole</c> for cross-account access or
        /// federation. </para> <para> For cross-account access, imagine that you own multiple accounts and need to access resources in each account.
        /// You could create long-term credentials in each account to access those resources. However, managing all those credentials and remembering
        /// which one can access which account can be time consuming. Instead, you can create one set of long-term credentials in one account and then
        /// use temporary security credentials to access all the other accounts by assuming roles in those accounts. For more information about roles,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Roles</a> in <i>Using IAM</i> .
        /// </para> <para> For federation, you can, for example, grant single sign-on access to the AWS Management Console. If you already have an
        /// identity and authentication system in your corporate network, you don't have to recreate user identities in AWS in order to grant those user
        /// identities access to AWS. Instead, after a user has been authenticated, you call <c>AssumeRole</c> (and specify the role with the
        /// appropriate permissions) to get temporary security credentials for that user. With those temporary security credentials, you construct a
        /// sign-in URL that users can use to access the console. For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSUseCases.html">Scenarios for Granting Temporary Access</a> in <i>AWS Security Token
        /// Service</i> .
        /// </para> <para> The temporary security credentials are valid for the duration that you specified when calling <c>AssumeRole</c> , which can
        /// be from 900 seconds (15 minutes) to 3600 seconds (1 hour). The default is 1 hour. </para> <para> The temporary security credentials that are
        /// returned from the <c>AssumeRoleWithWebIdentity</c> response have the permissions that are associated with the access policy of the role
        /// being assumed and any policies that are associated with the AWS resource being accessed. You can further restrict the permissions of the
        /// temporary security credentials by passing a policy in the request. The resulting permissions are an intersection of the role's access policy
        /// and the policy that you passed. These policies and any applicable resource-based policies are evaluated when calls to AWS service APIs are
        /// made using the temporary security credentials. </para> <para> To assume a role, your AWS account must be trusted by the role. The trust
        /// relationship is defined in the role's trust policy when the IAM role is created. You must also have a policy that allows you to call
        /// <c>sts:AssumeRole</c> .
        /// </para> <para> <b>Important:</b> You cannot call <c>Assumerole</c> by using AWS account credentials; access will be denied. You must use
        /// IAM user credentials to call <c>AssumeRole</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole service method on
        /// AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the AssumeRole service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="T:Amazon.SecurityToken.Model.PackedPolicyTooLargeException" />
        /// <exception cref="T:Amazon.SecurityToken.Model.MalformedPolicyDocumentException" />
		public AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
        {
            var task = AssumeRoleAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRole"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssumeRoleRequestMarshaller();
            var unmarshaller = AssumeRoleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AssumeRoleRequest, AssumeRoleResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a set of temporary security credentials for users who have been authenticated in a mobile or web application with a web
        /// identity provider, such as Login with Amazon, Facebook, or Google. <c>AssumeRoleWithWebIdentity</c> is an API call that does not require the
        /// use of AWS security credentials. Therefore, you can distribute an application (for example, on mobile devices) that requests temporary
        /// security credentials without including long-term AWS credentials in the application or by deploying server-based proxy services that use
        /// long-term AWS credentials. For more information, see <a href="http://aws-docs-alpha.integ.amazon.com/STS/latest/UsingSTS/STSUseCases.html#MobileApplication-KnownProvider">Creating a Mobile
        /// Application with Third-Party Sign-In</a> in <i>AWS Security Token Service</i> .
        /// </para> <para> The temporary security credentials consist of an access key ID, a secret access key, and a security token. Applications can
        /// use these temporary security credentials to sign calls to AWS service APIs. The credentials are valid for the duration that you specified
        /// when calling <c>AssumeRoleWithWebIdentity</c> , which can be from 900 seconds (15 minutes) to 3600 seconds (1 hour). By default, the
        /// temporary security credentials are valid for 1 hour. </para> <para> The temporary security credentials that are returned from the
        /// <c>AssumeRoleWithWebIdentity</c> response have the permissions that are associated with the access policy of the role being assumed. You can
        /// further restrict the permissions of the temporary security credentials by passing a policy in the request. The resulting permissions are an
        /// intersection of the role's access policy and the policy that you passed. These policies and any applicable resource-based policies are
        /// evaluated when calls to AWS service APIs are made using the temporary security credentials. </para> <para> Before your application can call
        /// <c>AssumeRoleWithWebIdentity</c> , you must have an identity token from a supported identity provider and create a role that the application
        /// can assume. The role that your application assumes must trust the identity provider that is associated with the identity token. In other
        /// words, the identity provider must be specified in the role's trust policy. For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingWIF.html"> Creating Temporary Security Credentials for Mobile Apps Using
        /// Third-Party Identity Providers</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity service
        /// method on AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithWebIdentity service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="T:Amazon.SecurityToken.Model.PackedPolicyTooLargeException" />
        /// <exception cref="T:Amazon.SecurityToken.Model.IDPRejectedClaimException" />
        /// <exception cref="T:Amazon.SecurityToken.Model.MalformedPolicyDocumentException" />
        /// <exception cref="T:Amazon.SecurityToken.Model.InvalidIdentityTokenException" />
        /// <exception cref="T:Amazon.SecurityToken.Model.ExpiredTokenException" />
        /// <exception cref="T:Amazon.SecurityToken.Model.IDPCommunicationErrorException" />
		public AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
        {
            var task = AssumeRoleWithWebIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.AssumeRoleWithWebIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssumeRoleWithWebIdentityRequestMarshaller();
            var unmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AssumeRoleWithWebIdentityRequest, AssumeRoleWithWebIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns a set of temporary security credentials (consisting of an access key ID, a secret access key, and a security token) for a
        /// federated user. A typical use is in a proxy application that is getting temporary security credentials on behalf of distributed applications
        /// inside a corporate network. Because you must call the <c>GetFederationToken</c> action using the long-term security credentials of an IAM
        /// user, this call is appropriate in contexts where those credentials can be safely stored, usually in a server-based application. </para>
        /// <para> <b>Note:</b> Do not use this call in mobile applications or client-based web applications that directly get temporary security
        /// credentials. For those types of applications, use <c>AssumeRoleWithWebIdentity</c> .
        /// </para> <para> The <c>GetFederationToken</c> action must be called by using the long-term AWS security credentials of the AWS account or an
        /// IAM user. Credentials that are created by IAM users are valid for the specified duration, between 900 seconds (15 minutes) and 129600
        /// seconds (36 hours); credentials that are created by using account credentials have a maximum duration of 3600 seconds (1 hour).</para>
        /// <para> The permissions that are granted to the federated user are the intersection of the policy that is passed with the
        /// <c>GetFederationToken</c> request and policies that are associated with of the entity making the <c>GetFederationToken</c> call. </para>
        /// <para> For more information about how permissions work, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/TokenPermissions.html">Controlling Permissions in Temporary Credentials</a> in <i>Using Temporary Security Credentials</i> . For information about using
        /// <c>GetFederationToken</c> to create temporary security credentials, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingFedTokens.html">Creating Temporary Credentials to Enable Access for Federated
        /// Users</a> in <i>Using Temporary Security Credentials</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method on
        /// AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by AmazonSecurityTokenService.</returns>
        /// 
        /// <exception cref="T:Amazon.SecurityToken.Model.PackedPolicyTooLargeException" />
        /// <exception cref="T:Amazon.SecurityToken.Model.MalformedPolicyDocumentException" />
		public GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
        {
            var task = GetFederationTokenAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.GetFederationToken"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetFederationTokenRequestMarshaller();
            var unmarshaller = GetFederationTokenResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetFederationTokenRequest, GetFederationTokenResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an access key ID, a secret access
        /// key, and a security token. Typically, you use <c>GetSessionToken</c> if you want use MFA to protect programmatic calls to specific AWS APIs
        /// like Amazon EC2 <c>StopInstances</c> . MFA-enabled IAM users would need to call <c>GetSessionToken</c> and submit an MFA code that is
        /// associated with their MFA device. Using the temporary security credentials that are returned from the call, IAM users can then make
        /// programmatic calls to APIs that require MFA authentication. </para> <para> The <c>GetSessionToken</c> action must be called by using the
        /// long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are valid for the duration
        /// that you specify, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using account credentials
        /// have a maximum duration of 3600 seconds (1 hour).</para> <para> The permissions that are granted to the federated user are the intersection
        /// of the policy that is passed with the <c>GetSessionToken</c> request and policies that are associated with of the entity making the
        /// <c>GetSessionToken</c> call. </para> <para>For more information about using <c>GetSessionToken</c> to create temporary credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingSessionTokens.html">Creating Temporary Credentials to Enable Access for IAM
        /// Users</a> in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken service method on
        /// AmazonSecurityTokenService.</param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
		public GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
        {
            var task = GetSessionTokenAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService.GetSessionToken"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSessionTokenRequestMarshaller();
            var unmarshaller = GetSessionTokenResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetSessionTokenRequest, GetSessionTokenResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Returns a set of temporary credentials for an AWS account or IAM user. The credentials consist of an access key ID, a secret access
        /// key, and a security token. Typically, you use <c>GetSessionToken</c> if you want use MFA to protect programmatic calls to specific AWS APIs
        /// like Amazon EC2 <c>StopInstances</c> . MFA-enabled IAM users would need to call <c>GetSessionToken</c> and submit an MFA code that is
        /// associated with their MFA device. Using the temporary security credentials that are returned from the call, IAM users can then make
        /// programmatic calls to APIs that require MFA authentication. </para> <para> The <c>GetSessionToken</c> action must be called by using the
        /// long-term AWS security credentials of the AWS account or an IAM user. Credentials that are created by IAM users are valid for the duration
        /// that you specify, between 900 seconds (15 minutes) and 129600 seconds (36 hours); credentials that are created by using account credentials
        /// have a maximum duration of 3600 seconds (1 hour).</para> <para> The permissions that are granted to the federated user are the intersection
        /// of the policy that is passed with the <c>GetSessionToken</c> request and policies that are associated with of the entity making the
        /// <c>GetSessionToken</c> call. </para> <para>For more information about using <c>GetSessionToken</c> to create temporary credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingSessionTokens.html">Creating Temporary Credentials to Enable Access for IAM
        /// Users</a> in <i>Using IAM</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by AmazonSecurityTokenService.</returns>
		public GetSessionTokenResponse GetSessionToken()
        {
            return this.GetSessionToken(new GetSessionTokenRequest());
        }
    }
}
