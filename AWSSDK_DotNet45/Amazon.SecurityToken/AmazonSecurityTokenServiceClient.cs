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


using System;
using System.Runtime.ExceptionServices;
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
    /// Implementation for accessing SecurityTokenService
    ///
    /// AWS Security Token Service    
    /// <para>
    /// The AWS Security Token Service (STS) is a web service that enables you to request
    /// temporary,      limited-privilege credentials for AWS Identity and Access Management
    /// (IAM) users or for users that you authenticate      (federated users). This guide
    /// provides descriptions of the STS API. For more detailed      information about using
    /// this service, go to <a href="http://docs.aws.amazon.com/IAM/latest/UsingSTS/Welcome.html"
    /// target="_blank">Using        Temporary Security Credentials</a>. 
    /// </para>
    ///     <note> As an alternative to using the API, you can use one of the AWS SDKs, which
    /// consist of      libraries and sample code for various programming languages and platforms
    /// (Java, Ruby, .NET,      iOS, Android, etc.). The SDKs provide a convenient way to
    /// create programmatic access to      STS. For example, the SDKs take care of cryptographically
    /// signing requests, managing      errors, and retrying requests automatically. For information
    /// about the AWS SDKs, including how      to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon        Web Services page</a>. </note>    
    /// <para>
    /// For information about setting up signatures and authorization through the API, go
    /// to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
    /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
    /// For      general information about the Query API, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
    /// target="_blank">Making Query Requests</a> in <i>Using IAM</i>. For information about
    /// using      security tokens with other AWS products, go to <a href="http://docs.aws.amazon.com/IAM/latest/UsingSTS/UsingTokens.html">Using
    /// Temporary        Security Credentials to Access AWS</a> in <i>Using Temporary Security
    /// Credentials</i>. 
    /// </para>
    ///     
    /// <para>
    /// If you're new to AWS and need additional technical information about a specific AWS
    /// product,      you can find the product's technical documentation at <a href="http://aws.amazon.com/documentation/"
    /// target="_blank">http://aws.amazon.com/documentation/</a>. 
    /// </para>
    ///     
    /// <para>
    ///       <b>Endpoints</b>    
    /// </para>
    ///     
    /// <para>
    /// For information about STS endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sts_region"
    /// target="_blank">Regions and Endpoints</a> in the <i>AWS General Reference</i>.
    /// </para>
    ///     
    /// <para>
    ///       <b>Recording API requests</b>    
    /// </para>
    ///     
    /// <para>
    /// STS supports AWS CloudTrail, which is a service that records AWS calls for your AWS
    ///      account and delivers log files to an Amazon S3 bucket. By using information collected
    /// by      CloudTrail, you can determine what requests were successfully made to STS,
    /// who made the      request, when it was made, and so on. To learn more about CloudTrail,
    /// including how to turn it      on and find your log files, see the <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/whatisawscloudtrail.html">AWS
    ///        CloudTrail User Guide</a>.
    /// </para>
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSecurityTokenServiceClient Configuration Object</param>
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

        
        #region  AssumeRole


        /// <summary>
        /// Returns a set of temporary security credentials (consisting of an access key ID, a
        /// secret      access key, and a security token) that you can use to access AWS resources
        /// that you might not      normally have access to. Typically, you use <code>AssumeRole</code>
        /// for cross-account access      or federation. 
        /// 
        ///     
        /// <para>
        /// <b>Important:</b> You cannot call <code>AssumeRole</code> by using AWS account credentials;
        ///      access will be denied. You must use IAM user credentials or temporary security
        /// credentials      to call <code>AssumeRole</code>. 
        /// </para>
        ///     
        /// <para>
        /// For cross-account access, imagine that you own multiple accounts and need to access
        /// resources      in each account. You could create long-term credentials in each account
        /// to access those      resources. However, managing all those credentials and remembering
        /// which one can access which      account can be time consuming. Instead, you can create
        /// one set of long-term credentials in one      account and then use temporary security
        /// credentials to access all the other accounts by      assuming roles in those accounts.
        /// For more information about roles, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Roles</a>
        /// in        <i>Using IAM</i>. 
        /// </para>
        ///     
        /// <para>
        /// For federation, you can, for example, grant single sign-on access to the AWS Management
        ///      Console. If you already have an identity and authentication system in your corporate
        /// network,      you don't have to recreate user identities in AWS in order to grant
        /// those user identities      access to AWS. Instead, after a user has been authenticated,
        /// you call <code>AssumeRole</code>      (and specify the role with the appropriate permissions)
        /// to get temporary security credentials      for that user. With those temporary security
        /// credentials, you construct a sign-in URL that      users can use to access the console.
        /// For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSUseCases.html">Scenarios
        /// for        Granting Temporary Access</a> in <i>Using Temporary Security Credentials</i>.
        /// 
        /// </para>
        ///     
        /// <para>
        /// The temporary security credentials are valid for the duration that you specified when
        /// calling        <code>AssumeRole</code>, which can be from 900 seconds (15 minutes)
        /// to 3600 seconds (1      hour). The default is 1 hour. 
        /// </para>
        ///     
        /// <para>
        /// Optionally, you can pass an IAM access policy to this operation. If you choose not
        /// to pass      a policy, the temporary security credentials that are returned by the
        /// operation have the      permissions that are defined in the access policy of the role
        /// that is being assumed. If you      pass a policy to this operation, the temporary
        /// security credentials that are returned by the      operation have the permissions
        /// that are allowed by both the access policy of the role that is      being assumed,
        /// <i><b>and</b></i> the policy that you pass. This gives you a way to further      restrict
        /// the permissions for the resulting temporary security credentials. You cannot use the
        ///      passed policy to grant permissions that are in excess of those allowed by the
        /// access policy of      the role that is being assumed. For more information, see <a
        /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/permissions-assume-role.html">Permissions
        /// for        AssumeRole</a> in <i>Using Temporary Security Credentials</i>.
        /// </para>
        ///     
        /// <para>
        /// To assume a role, your AWS account must be trusted by the role. The trust relationship
        /// is      defined in the role's trust policy when the role is created. You must also
        /// have a policy that      allows you to call <code>sts:AssumeRole</code>. 
        /// </para>
        ///     
        /// <para>
        ///       <b>Using MFA with AssumeRole</b>    
        /// </para>
        ///     
        /// <para>
        /// You can optionally include multi-factor authentication (MFA) information when you
        /// call        <code>AssumeRole</code>. This is useful for cross-account scenarios in
        /// which you want to      make sure that the user who is assuming the role has been authenticated
        /// using an AWS MFA      device. In that scenario, the trust policy of the role being
        /// assumed includes a condition that      tests for MFA authentication; if the caller
        /// does not include valid MFA information, the      request to assume the role is denied.
        /// The condition in a trust policy that tests for MFA      authentication might look
        /// like the following example.
        /// </para>
        ///     
        /// <para>
        ///       <code>"Condition": {"Null": {"aws:MultiFactorAuthAge": false}}</code>    
        /// </para>
        ///     
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/MFAProtectedAPI.html">Configuring
        ///        MFA-Protected API Access</a> in the <i>Using IAM</i> guide. 
        /// </para>
        ///     
        /// <para>
        /// To use MFA with <code>AssumeRole</code>, you pass values for the <code>SerialNumber</code>
        ///      and <code>TokenCode</code> parameters. The <code>SerialNumber</code> value identifies
        /// the      user's hardware or virtual MFA device. The <code>TokenCode</code> is the
        /// time-based one-time      password (TOTP) that the MFA devices produces. 
        /// </para>
        ///     <member name="RoleArn" target="arnType"></member>    <member name="RoleSessionName"
        /// target="userNameType"></member>    <member name="Policy" target="sessionPolicyDocumentType"></member>
        ///    <member name="DurationSeconds" target="roleDurationSecondsType"></member>    <member
        /// name="ExternalId" target="externalIdType"></member>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole service method.</param>
        /// 
        /// <returns>The response from the AssumeRole service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        ///      describes the specific error.
        /// </exception>
        /// <exception cref="PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        ///      describes how big the policy document is, in packed form, as a percentage of
        /// what the API      allows.
        /// </exception>
        public AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
        {
            var task = AssumeRoleAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssumeRoleRequestMarshaller();
            var unmarshaller = AssumeRoleResponseUnmarshaller.Instance;
            return Invoke<IRequest, AssumeRoleRequest, AssumeRoleResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  AssumeRoleWithSAML


        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// via a      SAML authentication response. This operation provides a mechanism for tying
        /// an enterprise      identity store or directory to role-based AWS access without user-specific
        /// credentials or      configuration. 
        /// 
        ///     
        /// <para>
        /// The temporary security credentials returned by this operation consist of an access
        /// key ID, a      secret access key, and a security token. Applications can use these
        /// temporary security      credentials to sign calls to AWS services. The credentials
        /// are valid for the duration that you      specified when calling <code>AssumeRoleWithSAML</code>,
        /// which can be up to 3600 seconds (1      hour) or until the time specified in the SAML
        /// authentication response's        <code>NotOnOrAfter</code> value, whichever is shorter.
        /// </para>
        ///     <note>The maximum duration for a session is 1 hour, and the minimum duration is
        /// 15 minutes, even      if values outside this range are specified. </note>
        /// <para>
        /// Optionally, you can pass an IAM access policy to this operation. If you choose not
        /// to pass a      policy, the temporary security credentials that are returned by the
        /// operation have the      permissions that are defined in the access policy of the role
        /// that is being assumed. If you      pass a policy to this operation, the temporary
        /// security credentials that are returned by the      operation have the permissions
        /// that are allowed by both the access policy of the role that is      being assumed,
        /// <i><b>and</b></i> the policy that you pass. This gives you a way to further      restrict
        /// the permissions for the resulting temporary security credentials. You cannot use the
        ///      passed policy to grant permissions that are in excess of those allowed by the
        /// access policy of      the role that is being assumed. For more information, see <a
        /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/permissions-assume-role.html">Permissions
        /// for        AssumeRoleWithSAML</a> in <i>Using Temporary Security Credentials</i>.
        /// </para>
        ///     
        /// <para>
        /// Before your application can call <code>AssumeRoleWithSAML</code>, you must configure
        /// your      SAML identity provider (IdP) to issue the claims required by AWS. Additionally,
        /// you must use      AWS Identity and Access Management (IAM) to create a SAML provider
        /// entity in your AWS account that represents your      identity provider, and create
        /// an IAM role that specifies this SAML provider in its trust      policy. 
        /// </para>
        ///     
        /// <para>
        /// Calling <code>AssumeRoleWithSAML</code> does not require the use of AWS security 
        ///     credentials. The identity of the caller is validated by using keys in the metadata
        /// document      that is uploaded for the SAML provider entity for your identity provider.
        /// 
        /// </para>
        ///     
        /// <para>
        /// For more information, see the following resources:
        /// </para>
        ///     <ul>      <li><a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html">Creating
        /// Temporary Security Credentials for SAML          Federation</a> in <i>Using Temporary
        /// Security Credentials</i>. </li>      <li>        <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/idp-managing-identityproviders.html">SAML
        /// Providers</a> in          <i>Using IAM</i>. </li>      <li>        <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml-IdP-tasks.html">Configuring
        /// a Relying Party and          Claims</a> in <i>Using IAM</i>. </li>      <li>     
        ///   <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/create-role-saml.html">Creating
        /// a Role for SAML-Based Federation</a>        in <i>Using IAM</i>. </li>    </ul>  
        ///  <member name="RoleArn" target="arnType"></member>    <member name="SAMLAssertion"
        /// target="SAMLAssertionType"></member>    <member name="Policy" target="sessionPolicyDocumentType"></member>
        ///    <member name="DurationSeconds" target="roleDurationSecondsType"></member>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML service method.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithSAML service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token      from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the      claim is invalid.
        /// 
        ///     
        /// <para>
        /// If this error is returned for the <code>AssumeRoleWithWebIdentity</code> operation,
        /// it can      also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by AWS. Get a new identity
        ///      token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        ///      describes the specific error.
        /// </exception>
        /// <exception cref="PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        ///      describes how big the policy document is, in packed form, as a percentage of
        /// what the API      allows.
        /// </exception>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
        {
            var task = AssumeRoleWithSAMLAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithSAML operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssumeRoleWithSAMLRequestMarshaller();
            var unmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.Instance;
            return Invoke<IRequest, AssumeRoleWithSAMLRequest, AssumeRoleWithSAMLResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  AssumeRoleWithWebIdentity


        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// in a      mobile or web application with a web identity provider, such as Login with
        /// Amazon, Facebook,      or Google. 
        /// 
        ///     
        /// <para>
        /// Calling <code>AssumeRoleWithWebIdentity</code> does not require the use of AWS security
        ///      credentials. Therefore, you can distribute an application (for example, on mobile
        /// devices)      that requests temporary security credentials without including long-term
        /// AWS credentials in      the application, and without deploying server-based proxy
        /// services that use long-term AWS      credentials. Instead, the identity of the caller
        /// is validated by using a token from the web      identity provider. 
        /// </para>
        ///     
        /// <para>
        /// The temporary security credentials returned by this API consist of an access key ID,
        /// a      secret access key, and a security token. Applications can use these temporary
        /// security      credentials to sign calls to AWS service APIs. The credentials are valid
        /// for the duration that      you specified when calling <code>AssumeRoleWithWebIdentity</code>,
        /// which can be from 900      seconds (15 minutes) to 3600 seconds (1 hour). By default,
        /// the temporary security credentials      are valid for 1 hour. 
        /// </para>
        ///     
        /// <para>
        /// Optionally, you can pass an IAM access policy to this operation. If you choose not
        /// to pass      a policy, the temporary security credentials that are returned by the
        /// operation have the      permissions that are defined in the access policy of the role
        /// that is being assumed. If you      pass a policy to this operation, the temporary
        /// security credentials that are returned by the      operation have the permissions
        /// that are allowed by both the access policy of the role that is      being assumed,
        /// <i><b>and</b></i> the policy that you pass. This gives you a way to further      restrict
        /// the permissions for the resulting temporary security credentials. You cannot use the
        ///      passed policy to grant permissions that are in excess of those allowed by the
        /// access policy of      the role that is being assumed. For more information, see <a
        /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/permissions-assume-role.html">Permissions
        /// for        AssumeRoleWithWebIdentity</a> in <i>Using Temporary Security Credentials</i>.
        /// </para>
        ///     
        /// <para>
        /// Before your application can call <code>AssumeRoleWithWebIdentity</code>, you must
        /// have an      identity token from a supported identity provider and create a role that
        /// the application can      assume. The role that your application assumes must trust
        /// the identity provider that is      associated with the identity token. In other words,
        /// the identity provider must be specified in      the role's trust policy. 
        /// </para>
        ///     
        /// <para>
        /// For more information about how to use web identity federation and the        <code>AssumeRoleWithWebIdentity</code>,
        /// see the following resources: 
        /// </para>
        ///     <ul>      <li>        <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSUseCases.html#MobileApplication-KnownProvider"
        /// target="_blank"> Creating a Mobile Application with Third-Party Sign-In</a> and <a
        /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingWIF.html" target="_blank">
        ///          Creating Temporary Security Credentials for Mobile Apps Using Third-Party
        /// Identity          Providers</a> in <i>Using Temporary Security Credentials</i>. </li>
        ///      <li><a href="https://web-identity-federation-playground.s3.amazonaws.com/index.html"
        /// target="_blank"> Web Identity Federation Playground</a>. This interactive website
        /// lets you        walk through the process of authenticating via Login with Amazon,
        /// Facebook, or Google,        getting temporary security credentials, and then using
        /// those credentials to make a request        to AWS. </li>      <li><a href="http://aws.amazon.com/sdkforios/">AWS
        /// SDK for iOS</a> and <a href="http://aws.amazon.com/sdkforandroid/" target="_blank">AWS
        /// SDK for Android</a>. These        toolkits contain sample apps that show how to invoke
        /// the identity providers, and then how to        use the information from these providers
        /// to get and use temporary security credentials. </li>      <li><a href="http://aws.amazon.com/articles/4617974389850313"
        /// target="_blank">Web Identity          Federation with Mobile Applications</a>. This
        /// article discusses web identity federation        and shows an example of how to use
        /// web identity federation to get access to content in        Amazon S3. </li>    </ul>
        ///    <member name="RoleArn" target="arnType"></member>    <member name="RoleSessionName"
        /// target="userNameType"></member>    <member name="WebIdentityToken" target="clientTokenType"></member>
        ///    <member name="ProviderId" target="urlType"></member>    <member name="Policy" target="sessionPolicyDocumentType"></member>
        ///    <member name="DurationSeconds" target="roleDurationSecondsType"></member>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity service method.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithWebIdentity service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token      from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="IDPCommunicationErrorException">
        /// The request could not be fulfilled because the non-AWS identity provider (IDP) that
        /// was asked      to verify the incoming identity token could not be reached. This is
        /// often a transient error      caused by network conditions. Retry the request a limited
        /// number of times so that you don't      exceed the request rate. If the error persists,
        /// the non-AWS identity provider might be down or      not responding.
        /// </exception>
        /// <exception cref="IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the      claim is invalid.
        /// 
        ///     
        /// <para>
        /// If this error is returned for the <code>AssumeRoleWithWebIdentity</code> operation,
        /// it can      also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by AWS. Get a new identity
        ///      token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        ///      describes the specific error.
        /// </exception>
        /// <exception cref="PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        ///      describes how big the policy document is, in packed form, as a percentage of
        /// what the API      allows.
        /// </exception>
        public AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
        {
            var task = AssumeRoleWithWebIdentityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssumeRoleWithWebIdentityRequestMarshaller();
            var unmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance;
            return Invoke<IRequest, AssumeRoleWithWebIdentityRequest, AssumeRoleWithWebIdentityResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DecodeAuthorizationMessage


        /// <summary>
        /// Decodes additional information about the authorization status of a request from an
        /// encoded      message returned in response to an AWS request. 
        /// 
        ///     
        /// <para>
        /// For example, if a user is not authorized to perform an action that he or she has requested,
        ///      the request returns a <code>Client.UnauthorizedOperation</code> response (an
        /// HTTP 403      response). Some AWS actions additionally return an encoded message that
        /// can provide details      about this authorization failure. 
        /// </para>
        ///     <note> Only certain AWS actions return an encoded authorization message. The documentation
        /// for      an individual action indicates whether that action returns an encoded message
        /// in addition to      returning an HTTP code. </note>    
        /// <para>
        /// The message is encoded because the details of the authorization status can constitute
        ///      privileged information that the user who requested the action should not see.
        /// To decode an      authorization status message, a user must be granted permissions
        /// via an IAM policy to      request the <code>DecodeAuthorizationMessage</code>    
        ///    (<code>sts:DecodeAuthorizationMessage</code>) action. 
        /// </para>
        ///     
        /// <para>
        /// The decoded message includes the following type of information: 
        /// </para>
        ///     <ul>      <li>Whether the request was denied due to an explicit deny or due to
        /// the absence of an        explicit allow. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccessPolicyLanguage_EvaluationLogic.html#policy-eval-denyallow">Determining
        /// Whether a Request is Allowed or Denied</a> in <i>Using IAM</i>. </li>      <li>The
        /// principal who made the request.</li>      <li>The requested action.</li>      <li>The
        /// requested resource.</li>      <li>The values of condition keys in the context of the
        /// user's request.</li>    </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage service method.</param>
        /// 
        /// <returns>The response from the DecodeAuthorizationMessage service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="InvalidAuthorizationMessageException">
        /// The error returned if the message passed to <code>DecodeAuthorizationMessage</code>
        /// was      invalid. This can happen if the token contains invalid characters, such as
        /// linebreaks.
        /// </exception>
        public DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request)
        {
            var task = DecodeAuthorizationMessageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DecodeAuthorizationMessage operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DecodeAuthorizationMessageRequestMarshaller();
            var unmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.Instance;
            return Invoke<IRequest, DecodeAuthorizationMessageRequest, DecodeAuthorizationMessageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetFederationToken


        /// <summary>
        /// Returns a set of temporary security credentials (consisting of an access key ID, a
        /// secret      access key, and a security token) for a federated user. A typical use
        /// is in a proxy      application that gets temporary security credentials on behalf
        /// of distributed applications      inside a corporate network. Because you must call
        /// the <code>GetFederationToken</code> action      using the long-term security credentials
        /// of an IAM user, this call is appropriate in      contexts where those credentials
        /// can be safely stored, usually in a server-based      application.
        /// 
        ///     
        /// <para>
        ///       <b>Note:</b> Do not use this call in mobile applications or client-based web
        /// applications that      directly get temporary security credentials. For those types
        /// of applications, use        <code>AssumeRoleWithWebIdentity</code>.
        /// </para>
        ///     
        /// <para>
        /// The <code>GetFederationToken</code> action must be called by using the long-term AWS
        /// security      credentials of an IAM user. You can also call <code>GetFederationToken</code>
        /// using the      security credentials of an AWS account (root), but this is not recommended.
        /// Instead, we      recommend that you create an IAM user for the purpose of the proxy
        /// application and then      attach a policy to the IAM user that limits federated users
        /// to only the actions and      resources they need access to. For more information,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html">IAM
        /// Best Practices</a> in        <i>Using IAM</i>. 
        /// </para>
        ///     
        /// <para>
        /// The temporary security credentials that are obtained by using the long-term credentials
        /// of an      IAM user are valid for the specified duration, between 900 seconds (15
        /// minutes) and 129600      seconds (36 hours). Temporary credentials that are obtained
        /// by using AWS account (root)      credentials have a maximum duration of 3600 seconds
        /// (1 hour)
        /// </para>
        ///     
        /// <para>
        ///       <b>Permissions</b>    
        /// </para>
        ///         
        /// <para>
        /// The permissions for the temporary security credentials returned by        <code>GetFederationToken</code>
        /// are determined by a combination of the following: 
        /// </para>
        ///             <ul>        <li>The policy or policies that are attached to the IAM user
        /// whose credentials are used to        call <code>GetFederationToken</code>.</li>  
        ///      <li>The policy that is passed as a parameter in the call.</li>       </ul>  
        ///  
        /// <para>
        /// The passed policy is attached to the temporary security credentials that result from
        /// the        <code>GetFederationToken</code> API call--that is, to the <i>federated
        /// user</i>. When the      federated user makes an AWS request, AWS evaluates the policy
        /// attached to the federated user      in combination with the policy or policies attached
        /// to the IAM user whose credentials were      used to call <code>GetFederationToken</code>.
        /// AWS allows the federated user's request only      when both the federated user <i><b>and</b></i>
        /// the IAM user are explicitly allowed to      perform the requested action. The passed
        /// policy cannot grant more permissions than those that      are defined in the IAM user
        /// policy.
        /// </para>
        ///     
        /// <para>
        /// A typical use case is that the permissions of the IAM user whose credentials are used
        /// to      call <code>GetFederationToken</code> are designed to allow access to all the
        /// actions and      resources that any federated user will need. Then, for individual
        /// users, you pass a policy to      the operation that scopes down the permissions to
        /// a level that's appropriate to that      individual user, using a policy that allows
        /// only a subset of permissions that are granted to      the IAM user. 
        /// </para>
        ///     
        /// <para>
        /// If you do not pass a policy, the resulting temporary security credentials have no
        /// effective      permissions. The only exception is when the temporary security credentials
        /// are used to access      a resource that has a resource-based policy that specifically
        /// allows the federated user to      access the resource. 
        /// </para>
        ///     
        /// <para>
        /// For more information about how permissions work, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/permissions-get-federation-token.html">Permissions
        /// for GetFederationToken</a> in <i>Using Temporary Security Credentials</i>. For information
        ///      about using <code>GetFederationToken</code> to create temporary security credentials,
        /// see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingFedTokens.html">Creating
        /// Temporary Credentials        to Enable Access for Federated Users</a> in <i>Using
        /// Temporary Security Credentials</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        ///      describes the specific error.
        /// </exception>
        /// <exception cref="PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        ///      describes how big the policy document is, in packed form, as a percentage of
        /// what the API      allows.
        /// </exception>
        public GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
        {
            var task = GetFederationTokenAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetFederationTokenRequestMarshaller();
            var unmarshaller = GetFederationTokenResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetFederationTokenRequest, GetFederationTokenResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  GetSessionToken

        /// <summary>
        /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
        ///      consist of an access key ID, a secret access key, and a security token. Typically,
        /// you use        <code>GetSessionToken</code> if you want to use MFA to protect programmatic
        /// calls to      specific AWS APIs like Amazon EC2 <code>StopInstances</code>. MFA-enabled
        /// IAM users would      need to call <code>GetSessionToken</code> and submit an MFA code
        /// that is associated with their      MFA device. Using the temporary security credentials
        /// that are returned from the call, IAM      users can then make programmatic calls to
        /// APIs that require MFA authentication. 
        /// 
        ///     
        /// <para>
        /// The <code>GetSessionToken</code> action must be called by using the long-term AWS
        /// security      credentials of the AWS account or an IAM user. Credentials that are
        /// created by IAM users      are valid for the duration that you specify, between 900
        /// seconds (15 minutes) and 129600      seconds (36 hours); credentials that are created
        /// by using account credentials have a maximum      duration of 3600 seconds (1 hour).
        /// 
        /// </para>
        ///         <note>      
        /// <para>
        /// We recommend that you do not call <code>GetSessionToken</code> with root account credentials.
        /// Instead, follow our <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html#create-iam-users">best
        /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
        /// and using IAM users for everyday interaction with AWS. 
        /// </para>
        ///     </note>        
        /// <para>
        /// The permissions associated with the temporary security credentials returned by   
        ///     <code>GetSessionToken</code> are based on the permissions associated with account
        /// or IAM      user whose credentials are used to call the action. If <code>GetSessionToken</code>
        /// is called      using root account credentials, the temporary credentials have root
        /// account permissions.      Similarly, if <code>GetSessionToken</code> is called using
        /// the credentials of an IAM user,      the temporary credentials have the same permissions
        /// as the IAM user. 
        /// </para>
        ///     
        /// <para>
        /// For more information about using <code>GetSessionToken</code> to create temporary
        ///      credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingSessionTokens.html"
        /// target="_blank"> Creating Temporary Credentials to Enable Access for IAM Users</a>
        /// in        <i>Using Temporary Security Credentials</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        public GetSessionTokenResponse GetSessionToken()
        {
            return GetSessionToken(new GetSessionTokenRequest());
        }

        /// <summary>
        /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
        ///      consist of an access key ID, a secret access key, and a security token. Typically,
        /// you use        <code>GetSessionToken</code> if you want to use MFA to protect programmatic
        /// calls to      specific AWS APIs like Amazon EC2 <code>StopInstances</code>. MFA-enabled
        /// IAM users would      need to call <code>GetSessionToken</code> and submit an MFA code
        /// that is associated with their      MFA device. Using the temporary security credentials
        /// that are returned from the call, IAM      users can then make programmatic calls to
        /// APIs that require MFA authentication. 
        /// 
        ///     
        /// <para>
        /// The <code>GetSessionToken</code> action must be called by using the long-term AWS
        /// security      credentials of the AWS account or an IAM user. Credentials that are
        /// created by IAM users      are valid for the duration that you specify, between 900
        /// seconds (15 minutes) and 129600      seconds (36 hours); credentials that are created
        /// by using account credentials have a maximum      duration of 3600 seconds (1 hour).
        /// 
        /// </para>
        ///         <note>      
        /// <para>
        /// We recommend that you do not call <code>GetSessionToken</code> with root account credentials.
        /// Instead, follow our <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html#create-iam-users">best
        /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
        /// and using IAM users for everyday interaction with AWS. 
        /// </para>
        ///     </note>        
        /// <para>
        /// The permissions associated with the temporary security credentials returned by   
        ///     <code>GetSessionToken</code> are based on the permissions associated with account
        /// or IAM      user whose credentials are used to call the action. If <code>GetSessionToken</code>
        /// is called      using root account credentials, the temporary credentials have root
        /// account permissions.      Similarly, if <code>GetSessionToken</code> is called using
        /// the credentials of an IAM user,      the temporary credentials have the same permissions
        /// as the IAM user. 
        /// </para>
        ///     
        /// <para>
        /// For more information about using <code>GetSessionToken</code> to create temporary
        ///      credentials, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/CreatingSessionTokens.html"
        /// target="_blank"> Creating Temporary Credentials to Enable Access for IAM Users</a>
        /// in        <i>Using Temporary Security Credentials</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken service method.</param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        public GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
        {
            var task = GetSessionTokenAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// <seealso cref="Amazon.SecurityToken.IAmazonSecurityTokenService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSessionTokenRequestMarshaller();
            var unmarshaller = GetSessionTokenResponseUnmarshaller.Instance;
            return Invoke<IRequest, GetSessionTokenRequest, GetSessionTokenResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
    }
}