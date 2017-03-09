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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Organizations.Model;
using Amazon.Organizations.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Organizations
{
    /// <summary>
    /// Implementation for accessing Organizations
    ///
    /// AWS Organizations API Reference 
    /// <para>
    /// AWS Organizations is a web service that enables you to consolidate your multiple AWS
    /// accounts into an <i>organization</i> and centrally manage your accounts and their
    /// resources.
    /// </para>
    ///  
    /// <para>
    /// This guide provides descriptions of the Organizations API. For more information about
    /// using this service, see the <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">AWS
    /// Organizations User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Version</b> 
    /// </para>
    ///  
    /// <para>
    /// This version of the Organizations API Reference documents the Organizations API version
    /// 2016-11-28.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to using the API directly, you can use one of the AWS SDKs, which
    /// consist of libraries and sample code for various programming languages and platforms
    /// (Java, Ruby, .NET, iOS, Android, and more). The SDKs provide a convenient way to create
    /// programmatic access to AWS Organizations. For example, the SDKs take care of cryptographically
    /// signing requests, managing errors, and retrying requests automatically. For more information
    /// about the AWS SDKs, including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to Organizations.
    /// However, you also can use the Organizations Query API to make direct calls to the
    /// Organizations web service. To learn more about the Organizations Query API, see <a
    /// href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_query-requests.html">Making
    /// Query Requests</a> in the <i>AWS Organizations User Guide</i>. Organizations supports
    /// GET and POST requests for all actions. That is, the API does not require you to use
    /// GET for some actions and POST for others. However, GET requests are subject to the
    /// limitation size of a URL. Therefore, for operations that require larger sizes, use
    /// a POST request.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// When you send HTTP requests to AWS, you must sign the requests so that AWS can identify
    /// who sent them. You sign requests with your AWS access key, which consists of an access
    /// key ID and a secret access key. We strongly recommend that you do not create an access
    /// key for your root account. Anyone who has the access key for your root account has
    /// unrestricted access to all the resources in your account. Instead, create an access
    /// key for an IAM user account that has administrative privileges. As another option,
    /// use AWS Security Token Service to generate temporary security credentials, and use
    /// those credentials to sign requests. 
    /// </para>
    ///  
    /// <para>
    /// To sign requests, we recommend that you use <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>. If you have an existing application that uses Signature Version 2,
    /// you do not have to update it to use Signature Version 4. However, some operations
    /// now require Signature Version 4. The documentation for operations that require version
    /// 4 indicate this requirement. 
    /// </para>
    ///  
    /// <para>
    /// When you use the AWS Command Line Interface (AWS CLI) or one of the AWS SDKs to make
    /// requests to AWS, these tools automatically sign the requests for you with the access
    /// key that you specify when you configure the tools.
    /// </para>
    ///  
    /// <para>
    /// In this release, each organization can have only one root. In a future release, a
    /// single organization will support multiple roots.
    /// </para>
    ///  
    /// <para>
    ///  <b>Support and Feedback for AWS Organizations</b> 
    /// </para>
    ///  
    /// <para>
    /// We welcome your feedback. Send your comments to <a href="mailto:aws-organizations-feedback@amazon.com">aws-organizations-feedback@amazon.com</a>
    /// or post your feedback and questions in our private <a href="http://forums.aws.amazon.com/forum.jspa?forumID=219">AWS
    /// Organizations support forum</a>. If you don't have access to the forum, send a request
    /// for access to the email address, along with your forum user ID. For more information
    /// about the AWS support forums, see <a href="http://forums.aws.amazon.com/help.jspa">Forums
    /// Help</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoint to Call When Using the CLI or the AWS API</b> 
    /// </para>
    ///  
    /// <para>
    /// For the current release of Organizations, you must specify the <code>us-east-1</code>
    /// region for all AWS API and CLI calls. You can do this in the CLI by using these parameters
    /// and commands:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the following parameter with each command to specify both the endpoint and its
    /// region:
    /// </para>
    ///  
    /// <para>
    ///  <code>--endpoint-url https://organizations.us-east-1.amazonaws.com</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the default endpoint, but configure your default region with this command:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws configure set default.region us-east-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the following parameter with each command to specify the endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <code>--region us-east-1</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the various SDKs used to call the APIs, see the documentation for the SDK of interest
    /// to learn how to direct the requests to a specific endpoint. For more information,
    /// see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sts_region">Regions
    /// and Endpoints</a> in the <i>AWS General Reference</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>How examples are presented</b> 
    /// </para>
    ///  
    /// <para>
    /// The JSON returned by the AWS Organizations service as response to your requests is
    /// returned as a single long string without line breaks or formatting whitespace. Both
    /// line breaks and whitespace are included in the examples in this guide to improve readability.
    /// When example input parameters also would result in long strings that would extend
    /// beyond the screen, we insert line breaks to enhance readability. You should always
    /// submit the input as a single JSON text string.
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS Organizations supports AWS CloudTrail, a service that records AWS API calls for
    /// your AWS account and delivers log files to an Amazon S3 bucket. By using information
    /// collected by AWS CloudTrail, you can determine which requests were successfully made
    /// to Organizations, who made the request, when it was made, and so on. For more about
    /// AWS Organizations and its support for AWS CloudTrail, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_cloudtrail-integration.html">Logging
    /// AWS Organizations Events with AWS CloudTrail</a> in the <i>AWS Organizations User
    /// Guide</i>. To learn more about CloudTrail, including how to turn it on and find your
    /// log files, see the <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">AWS
    /// CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonOrganizationsClient : AmazonServiceClient, IAmazonOrganizations
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonOrganizationsClient with the credentials loaded from the application's
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
        public AmazonOrganizationsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOrganizationsConfig()) { }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with the credentials loaded from the application's
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
        public AmazonOrganizationsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOrganizationsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOrganizationsClient Configuration Object</param>
        public AmazonOrganizationsClient(AmazonOrganizationsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOrganizationsClient(AWSCredentials credentials)
            : this(credentials, new AmazonOrganizationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOrganizationsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOrganizationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Credentials and an
        /// AmazonOrganizationsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOrganizationsClient Configuration Object</param>
        public AmazonOrganizationsClient(AWSCredentials credentials, AmazonOrganizationsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOrganizationsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOrganizationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOrganizationsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOrganizationsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOrganizationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOrganizationsClient Configuration Object</param>
        public AmazonOrganizationsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOrganizationsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOrganizationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOrganizationsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOrganizationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOrganizationsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOrganizationsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOrganizationsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOrganizationsClient Configuration Object</param>
        public AmazonOrganizationsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOrganizationsConfig clientConfig)
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

        
        #region  AcceptHandshake

        /// <summary>
        /// Sends a response to the originator of a handshake agreeing to the action proposed
        /// by the handshake request. 
        /// 
        ///  
        /// <para>
        /// This operation can be called only by the following principals when they also have
        /// the relevant IAM permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Invitation to join</b> or <b>Approve all features request</b> handshakes: only
        /// a principal from the member account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Enable all features final confirmation</b> handshake: only a principal from the
        /// master account.
        /// </para>
        ///  
        /// <para>
        /// For more information about invitations, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_invites.html">Inviting
        /// an AWS Account to Join Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// For more information about requests to enable all features in the organization, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptHandshake service method.</param>
        /// 
        /// <returns>The response from the AcceptHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeAlreadyInStateException">
        /// The specified handshake is already in the requested state. For example, you can't
        /// accept a handshake that was already accepted.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeConstraintViolationException">
        /// The requested operation would violate the constraint identified in the reason code.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeNotFoundException">
        /// We can't find a handshake with the HandshakeId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidHandshakeTransitionException">
        /// You can't perform the operation on the handshake in its current state. For example,
        /// you can't cancel a handshake that was already accepted, or accept a handshake that
        /// was already declined.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AcceptHandshake">REST API Reference for AcceptHandshake Operation</seealso>
        public AcceptHandshakeResponse AcceptHandshake(AcceptHandshakeRequest request)
        {
            var marshaller = new AcceptHandshakeRequestMarshaller();
            var unmarshaller = AcceptHandshakeResponseUnmarshaller.Instance;

            return Invoke<AcceptHandshakeRequest,AcceptHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptHandshake operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AcceptHandshake">REST API Reference for AcceptHandshake Operation</seealso>
        public IAsyncResult BeginAcceptHandshake(AcceptHandshakeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AcceptHandshakeRequestMarshaller();
            var unmarshaller = AcceptHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke<AcceptHandshakeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptHandshake.</param>
        /// 
        /// <returns>Returns a  AcceptHandshakeResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AcceptHandshake">REST API Reference for AcceptHandshake Operation</seealso>
        public  AcceptHandshakeResponse EndAcceptHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachPolicy

        /// <summary>
        /// Attaches a policy to a root, an organizational unit, or an individual account. How
        /// the policy affects accounts depends on the type of policy:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Service control policy (SCP)</b> - An SCP specifies what permissions can be delegated
        /// to users in affected member accounts. The scope of influence for a policy depends
        /// on what you attach the policy to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you attach an SCP to a root, it affects all accounts in the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you attach an SCP to an OU, it affects all accounts in that OU and in any child
        /// OUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you attach the policy directly to an account, then it affects only that account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// SCPs essentially are permission "filters". When you attach one SCP to a higher level
        /// root or OU, and you also attach a different SCP to a child OU or to an account, the
        /// child policy can further restrict only the permissions that pass through the parent
        /// filter and are available to the child. An SCP that is attached to a child cannot grant
        /// a permission that is not already granted by the parent. For example, imagine that
        /// the parent SCP allows permissions A, B, C, D, and E. The child SCP allows C, D, E,
        /// F, and G. The result is that the accounts affected by the child SCP are allowed to
        /// use only C, D, and E. They cannot use A or B because they were filtered out by the
        /// child OU. They also cannot use F and G because they were filtered out by the parent
        /// OU. They cannot be granted back by the child SCP; child SCPs can only filter the permissions
        /// they receive from the parent SCP.
        /// </para>
        ///  
        /// <para>
        /// AWS Organizations attaches a default SCP named <code>"FullAWSAccess</code> to every
        /// root, OU, and account. This default SCP allows all services and actions, enabling
        /// any new child OU or account to inherit the permissions of the parent root or OU. If
        /// you detach the default policy, you must replace it with a policy that specifies the
        /// permissions that you want to allow in that OU or account.
        /// </para>
        ///  
        /// <para>
        /// For more information about how Organizations policies permissions work, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scp.html">Using
        /// Service Control Policies</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachPolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicatePolicyAttachmentException">
        /// The selected policy is already attached to the specified target.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the PolicyId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotEnabledException">
        /// The specified policy type is not currently enabled in this root. You cannot attach
        /// policies of the specified type to entities in a root until you enable that type in
        /// the root. For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, or account with the TargetId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var marshaller = new AttachPolicyRequestMarshaller();
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyRequest,AttachPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public IAsyncResult BeginAttachPolicy(AttachPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachPolicyRequestMarshaller();
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<AttachPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachPolicy.</param>
        /// 
        /// <returns>Returns a  AttachPolicyResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public  AttachPolicyResponse EndAttachPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelHandshake

        /// <summary>
        /// Cancels a handshake. Canceling a handshake sets the handshake state to <code>CANCELED</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the account that originated the handshake.
        /// The recipient of the handshake can't cancel it, but can use <a>DeclineHandshake</a>
        /// instead. After a handshake is canceled, the recipient can no longer respond to that
        /// handshake. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelHandshake service method.</param>
        /// 
        /// <returns>The response from the CancelHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeAlreadyInStateException">
        /// The specified handshake is already in the requested state. For example, you can't
        /// accept a handshake that was already accepted.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeNotFoundException">
        /// We can't find a handshake with the HandshakeId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidHandshakeTransitionException">
        /// You can't perform the operation on the handshake in its current state. For example,
        /// you can't cancel a handshake that was already accepted, or accept a handshake that
        /// was already declined.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CancelHandshake">REST API Reference for CancelHandshake Operation</seealso>
        public CancelHandshakeResponse CancelHandshake(CancelHandshakeRequest request)
        {
            var marshaller = new CancelHandshakeRequestMarshaller();
            var unmarshaller = CancelHandshakeResponseUnmarshaller.Instance;

            return Invoke<CancelHandshakeRequest,CancelHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelHandshake operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CancelHandshake">REST API Reference for CancelHandshake Operation</seealso>
        public IAsyncResult BeginCancelHandshake(CancelHandshakeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelHandshakeRequestMarshaller();
            var unmarshaller = CancelHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke<CancelHandshakeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelHandshake.</param>
        /// 
        /// <returns>Returns a  CancelHandshakeResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CancelHandshake">REST API Reference for CancelHandshake Operation</seealso>
        public  CancelHandshakeResponse EndCancelHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccount

        /// <summary>
        /// Creates an AWS account that is automatically a member of the organization whose credentials
        /// made the request. This is an asynchronous request that AWS performs in the background.
        /// If you want to check the status of the request later, you need the <code>OperationId</code>
        /// response element from this operation to provide as a parameter to the <a>DescribeCreateAccountStatus</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// AWS Organizations preconfigures the new member account with a role (named <code>OrganizationAccountAccessRole</code>
        /// by default) that grants administrator permissions to the new account. Principals in
        /// the master account can assume the role. AWS Organizations clones the company name
        /// and address information for the new account from the organization's master account.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating accounts, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_create.html">Creating
        /// an AWS Account in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You cannot remove accounts that are created with this operation from an organization.
        /// That also means that you cannot delete an organization that contains an account that
        /// is created with this operation.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// When you create a member account with this operation, the account is created with
        /// the <b>IAM User and Role Access to Billing Information</b> switch enabled. This allows
        /// IAM users and roles that are granted appropriate permissions to view billing information.
        /// If this is disabled, then only the account root user can access billing information.
        /// For information about how to disable this for an account, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html">Granting
        /// Access to Your Billing Information and Tools</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount service method.</param>
        /// 
        /// <returns>The response from the CreateAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.FinalizingOrganizationException">
        /// AWS Organizations could not finalize the creation of your organization. Try again
        /// later. If this persists, contact AWS customer support.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var marshaller = new CreateAccountRequestMarshaller();
            var unmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return Invoke<CreateAccountRequest,CreateAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public IAsyncResult BeginCreateAccount(CreateAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAccountRequestMarshaller();
            var unmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccount.</param>
        /// 
        /// <returns>Returns a  CreateAccountResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public  CreateAccountResponse EndCreateAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOrganization

        /// <summary>
        /// Creates an AWS organization. The account whose user is calling the CreateOrganization
        /// operation automatically becomes the <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/orgs_getting-started_concepts.html#account">master
        /// account</a> of the new organization.
        /// 
        ///  
        /// <para>
        /// This operation must be called using credentials from the account that is to become
        /// the new organization's master account. The principal must also have the relevant IAM
        /// permissions.
        /// </para>
        ///  
        /// <para>
        /// By default (or if you set the <code>FeatureSet</code> parameter to <code>ALL</code>),
        /// the new organization is created with all features enabled and service control policies
        /// automatically enabled in the root. If you instead choose to create the organization
        /// supporting only the consolidated billing features by setting the <code>FeatureSet</code>
        /// parameter to <code>CONSOLIDATED_BILLING"</code>, then no policy types are enabled
        /// by default and you cannot use organization policies.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AlreadyInOrganizationException">
        /// This account is already a member of an organization. An account can belong to only
        /// one organization at a time.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        public CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest request)
        {
            var marshaller = new CreateOrganizationRequestMarshaller();
            var unmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateOrganizationRequest,CreateOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        public IAsyncResult BeginCreateOrganization(CreateOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateOrganizationRequestMarshaller();
            var unmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrganization.</param>
        /// 
        /// <returns>Returns a  CreateOrganizationResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        public  CreateOrganizationResponse EndCreateOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOrganizationalUnit

        /// <summary>
        /// Creates an organizational unit (OU) within a root or parent OU. An OU is a container
        /// for accounts that enables you to organize your accounts to apply policies according
        /// to your business requirements. The number of levels deep that you can nest OUs is
        /// dependent upon the policy types enabled for that root. For service control policies,
        /// the limit is five. 
        /// 
        ///  
        /// <para>
        /// For more information about OUs, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_ous.html">Managing
        /// Organizational Units</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganizationalUnit service method.</param>
        /// 
        /// <returns>The response from the CreateOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateOrganizationalUnitException">
        /// An organizational unit (OU) with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or organizational unit (OU) with the ParentId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganizationalUnit">REST API Reference for CreateOrganizationalUnit Operation</seealso>
        public CreateOrganizationalUnitResponse CreateOrganizationalUnit(CreateOrganizationalUnitRequest request)
        {
            var marshaller = new CreateOrganizationalUnitRequestMarshaller();
            var unmarshaller = CreateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<CreateOrganizationalUnitRequest,CreateOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganizationalUnit operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOrganizationalUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganizationalUnit">REST API Reference for CreateOrganizationalUnit Operation</seealso>
        public IAsyncResult BeginCreateOrganizationalUnit(CreateOrganizationalUnitRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateOrganizationalUnitRequestMarshaller();
            var unmarshaller = CreateOrganizationalUnitResponseUnmarshaller.Instance;

            return BeginInvoke<CreateOrganizationalUnitRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrganizationalUnit.</param>
        /// 
        /// <returns>Returns a  CreateOrganizationalUnitResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganizationalUnit">REST API Reference for CreateOrganizationalUnit Operation</seealso>
        public  CreateOrganizationalUnitResponse EndCreateOrganizationalUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOrganizationalUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePolicy

        /// <summary>
        /// Creates a policy of a specified type that you can attach to a root, an organizational
        /// unit (OU), or an individual AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about policies and their use, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html">Managing
        /// Organization Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicatePolicyException">
        /// A policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MalformedPolicyDocumentException">
        /// The provided policy document does not meet the requirements of the specified policy
        /// type. For example, the syntax might be incorrect. For details about service control
        /// policy syntax, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_scp-syntax.html">Service
        /// Control Policy Syntax</a> in the <i>AWS Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotAvailableForOrganizationException">
        /// You can't use the specified policy type with the feature set currently enabled for
        /// this organization. For example, you can enable service control policies (SCPs) only
        /// after you enable all features in the organization. For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html#enable_policies_on_root">Enabling
        /// and Disabling a Policy Type on a Root</a> in the <i>AWS Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var marshaller = new CreatePolicyRequestMarshaller();
            var unmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyRequest,CreatePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public IAsyncResult BeginCreatePolicy(CreatePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePolicyRequestMarshaller();
            var unmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicy.</param>
        /// 
        /// <returns>Returns a  CreatePolicyResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public  CreatePolicyResponse EndCreatePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeclineHandshake

        /// <summary>
        /// Declines a handshake request. This sets the handshake state to <code>DECLINED</code>
        /// and effectively deactivates the request.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the account that received the handshake. The
        /// originator of the handshake can use <a>CancelHandshake</a> instead. The originator
        /// can't reactivate a declined request, but can re-initiate the process with a new handshake
        /// request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineHandshake service method.</param>
        /// 
        /// <returns>The response from the DeclineHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeAlreadyInStateException">
        /// The specified handshake is already in the requested state. For example, you can't
        /// accept a handshake that was already accepted.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeNotFoundException">
        /// We can't find a handshake with the HandshakeId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidHandshakeTransitionException">
        /// You can't perform the operation on the handshake in its current state. For example,
        /// you can't cancel a handshake that was already accepted, or accept a handshake that
        /// was already declined.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeclineHandshake">REST API Reference for DeclineHandshake Operation</seealso>
        public DeclineHandshakeResponse DeclineHandshake(DeclineHandshakeRequest request)
        {
            var marshaller = new DeclineHandshakeRequestMarshaller();
            var unmarshaller = DeclineHandshakeResponseUnmarshaller.Instance;

            return Invoke<DeclineHandshakeRequest,DeclineHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeclineHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineHandshake operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeclineHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeclineHandshake">REST API Reference for DeclineHandshake Operation</seealso>
        public IAsyncResult BeginDeclineHandshake(DeclineHandshakeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeclineHandshakeRequestMarshaller();
            var unmarshaller = DeclineHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke<DeclineHandshakeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeclineHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeclineHandshake.</param>
        /// 
        /// <returns>Returns a  DeclineHandshakeResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeclineHandshake">REST API Reference for DeclineHandshake Operation</seealso>
        public  DeclineHandshakeResponse EndDeclineHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<DeclineHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOrganization

        /// <summary>
        /// Deletes the organization. You can delete an organization only by using credentials
        /// from the master account. The organization must be empty of member accounts, OUs, and
        /// policies.
        /// 
        ///  <important> 
        /// <para>
        /// If you create any accounts using Organizations operations or the Organizations console,
        /// you can't remove those accounts from the organization, which means that you can't
        /// delete the organization.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationNotEmptyException">
        /// The organization isn't empty. To delete an organization, you must first remove all
        /// accounts except the master account, delete all organizational units (OUs), and delete
        /// all policies.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        public DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest request)
        {
            var marshaller = new DeleteOrganizationRequestMarshaller();
            var unmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationRequest,DeleteOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        public IAsyncResult BeginDeleteOrganization(DeleteOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteOrganizationRequestMarshaller();
            var unmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOrganization.</param>
        /// 
        /// <returns>Returns a  DeleteOrganizationResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        public  DeleteOrganizationResponse EndDeleteOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOrganizationalUnit

        /// <summary>
        /// Deletes an organizational unit from a root or another OU. You must first remove all
        /// accounts and child OUs from the OU that you want to delete.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationalUnit service method.</param>
        /// 
        /// <returns>The response from the DeleteOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotEmptyException">
        /// The specified organizational unit (OU) is not empty. Move all accounts to another
        /// root or to other OUs, remove all child OUs, and then try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotFoundException">
        /// We can't find an organizational unit (OU) with the OrganizationalUnitId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganizationalUnit">REST API Reference for DeleteOrganizationalUnit Operation</seealso>
        public DeleteOrganizationalUnitResponse DeleteOrganizationalUnit(DeleteOrganizationalUnitRequest request)
        {
            var marshaller = new DeleteOrganizationalUnitRequestMarshaller();
            var unmarshaller = DeleteOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationalUnitRequest,DeleteOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationalUnit operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOrganizationalUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganizationalUnit">REST API Reference for DeleteOrganizationalUnit Operation</seealso>
        public IAsyncResult BeginDeleteOrganizationalUnit(DeleteOrganizationalUnitRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteOrganizationalUnitRequestMarshaller();
            var unmarshaller = DeleteOrganizationalUnitResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteOrganizationalUnitRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOrganizationalUnit.</param>
        /// 
        /// <returns>Returns a  DeleteOrganizationalUnitResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganizationalUnit">REST API Reference for DeleteOrganizationalUnit Operation</seealso>
        public  DeleteOrganizationalUnitResponse EndDeleteOrganizationalUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOrganizationalUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePolicy

        /// <summary>
        /// Deletes the specified policy from your organization. Before you perform this operation,
        /// you must first detach the policy from all OUs, roots, and accounts.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyInUseException">
        /// The policy is attached to one or more entities. You must detach it from all roots,
        /// organizational units (OUs), and accounts before performing this operation.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the PolicyId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeletePolicyRequestMarshaller();
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
        /// <returns>Returns a  DeletePolicyResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public  DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccount

        /// <summary>
        /// Retrieves Organizations-related information about the specified account.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount service method.</param>
        /// 
        /// <returns>The response from the DescribeAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an AWS account with the AccountId that you specified, or the account
        /// whose credentials you used to make this request is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public DescribeAccountResponse DescribeAccount(DescribeAccountRequest request)
        {
            var marshaller = new DescribeAccountRequestMarshaller();
            var unmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountRequest,DescribeAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public IAsyncResult BeginDescribeAccount(DescribeAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAccountRequestMarshaller();
            var unmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccount.</param>
        /// 
        /// <returns>Returns a  DescribeAccountResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public  DescribeAccountResponse EndDescribeAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCreateAccountStatus

        /// <summary>
        /// Retrieves the current status of an asynchronous request to create an account.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCreateAccountStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeCreateAccountStatus service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.CreateAccountStatusNotFoundException">
        /// We can't find an create account request with the CreateAccountRequestId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeCreateAccountStatus">REST API Reference for DescribeCreateAccountStatus Operation</seealso>
        public DescribeCreateAccountStatusResponse DescribeCreateAccountStatus(DescribeCreateAccountStatusRequest request)
        {
            var marshaller = new DescribeCreateAccountStatusRequestMarshaller();
            var unmarshaller = DescribeCreateAccountStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCreateAccountStatusRequest,DescribeCreateAccountStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCreateAccountStatus operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCreateAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeCreateAccountStatus">REST API Reference for DescribeCreateAccountStatus Operation</seealso>
        public IAsyncResult BeginDescribeCreateAccountStatus(DescribeCreateAccountStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeCreateAccountStatusRequestMarshaller();
            var unmarshaller = DescribeCreateAccountStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCreateAccountStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCreateAccountStatus.</param>
        /// 
        /// <returns>Returns a  DescribeCreateAccountStatusResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeCreateAccountStatus">REST API Reference for DescribeCreateAccountStatus Operation</seealso>
        public  DescribeCreateAccountStatusResponse EndDescribeCreateAccountStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCreateAccountStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHandshake

        /// <summary>
        /// Retrieves information about a previously requested handshake. The handshake ID comes
        /// from the response to the original <a>InviteAccountToOrganization</a> operation that
        /// generated the handshake.
        /// 
        ///  
        /// <para>
        /// This operation can be called from any account in the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHandshake service method.</param>
        /// 
        /// <returns>The response from the DescribeHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeNotFoundException">
        /// We can't find a handshake with the HandshakeId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeHandshake">REST API Reference for DescribeHandshake Operation</seealso>
        public DescribeHandshakeResponse DescribeHandshake(DescribeHandshakeRequest request)
        {
            var marshaller = new DescribeHandshakeRequestMarshaller();
            var unmarshaller = DescribeHandshakeResponseUnmarshaller.Instance;

            return Invoke<DescribeHandshakeRequest,DescribeHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHandshake operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHandshake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeHandshake">REST API Reference for DescribeHandshake Operation</seealso>
        public IAsyncResult BeginDescribeHandshake(DescribeHandshakeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeHandshakeRequestMarshaller();
            var unmarshaller = DescribeHandshakeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHandshakeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHandshake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHandshake.</param>
        /// 
        /// <returns>Returns a  DescribeHandshakeResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeHandshake">REST API Reference for DescribeHandshake Operation</seealso>
        public  DescribeHandshakeResponse EndDescribeHandshake(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHandshakeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrganization

        /// <summary>
        /// Retrieves information about the organization that the user's account belongs to.
        /// 
        ///  
        /// <para>
        /// This operation can be called from any account in the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public DescribeOrganizationResponse DescribeOrganization(DescribeOrganizationRequest request)
        {
            var marshaller = new DescribeOrganizationRequestMarshaller();
            var unmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationRequest,DescribeOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public IAsyncResult BeginDescribeOrganization(DescribeOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeOrganizationRequestMarshaller();
            var unmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public  DescribeOrganizationResponse EndDescribeOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrganizationalUnit

        /// <summary>
        /// Retrieves information about an organizational unit (OU).
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationalUnit service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotFoundException">
        /// We can't find an organizational unit (OU) with the OrganizationalUnitId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganizationalUnit">REST API Reference for DescribeOrganizationalUnit Operation</seealso>
        public DescribeOrganizationalUnitResponse DescribeOrganizationalUnit(DescribeOrganizationalUnitRequest request)
        {
            var marshaller = new DescribeOrganizationalUnitRequestMarshaller();
            var unmarshaller = DescribeOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationalUnitRequest,DescribeOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationalUnit operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationalUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganizationalUnit">REST API Reference for DescribeOrganizationalUnit Operation</seealso>
        public IAsyncResult BeginDescribeOrganizationalUnit(DescribeOrganizationalUnitRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeOrganizationalUnitRequestMarshaller();
            var unmarshaller = DescribeOrganizationalUnitResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeOrganizationalUnitRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationalUnit.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationalUnitResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganizationalUnit">REST API Reference for DescribeOrganizationalUnit Operation</seealso>
        public  DescribeOrganizationalUnitResponse EndDescribeOrganizationalUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrganizationalUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePolicy

        /// <summary>
        /// Retrieves information about a policy.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicy service method.</param>
        /// 
        /// <returns>The response from the DescribePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the PolicyId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribePolicy">REST API Reference for DescribePolicy Operation</seealso>
        public DescribePolicyResponse DescribePolicy(DescribePolicyRequest request)
        {
            var marshaller = new DescribePolicyRequestMarshaller();
            var unmarshaller = DescribePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribePolicyRequest,DescribePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicy operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribePolicy">REST API Reference for DescribePolicy Operation</seealso>
        public IAsyncResult BeginDescribePolicy(DescribePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePolicyRequestMarshaller();
            var unmarshaller = DescribePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePolicy.</param>
        /// 
        /// <returns>Returns a  DescribePolicyResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribePolicy">REST API Reference for DescribePolicy Operation</seealso>
        public  DescribePolicyResponse EndDescribePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachPolicy

        /// <summary>
        /// Detaches a policy from a target root, organizational unit, or account. If the policy
        /// being detached is a service control policy (SCP), the changes to permissions for IAM
        /// users and roles in affected accounts are immediate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> Every root, OU, and account must have at least one SCP attached. If
        /// you want to replace the default <code>FullAWSAccess</code> policy with one that limits
        /// the permissions that can be delegated, then you must attach the replacement policy
        /// before you can remove the default one. This is the authorization strategy of <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_about-scps.html#orgs_policies_whitelist">whitelisting</a>.
        /// If you instead attach a second SCP and leave the <code>FullAWSAccess</code> SCP still
        /// attached, and specify <code>"Effect": "Deny"</code> in the second SCP to override
        /// the <code>"Effect": "Allow"</code> in the <code>FullAWSAccess</code> policy (or any
        /// other attached SCP), then you are using the authorization strategy of <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_about-scps.html#orgs_policies_blacklist">blacklisting</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachPolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotAttachedException">
        /// The policy isn't attached to the specified target in the specified root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the PolicyId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, or account with the TargetId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var marshaller = new DetachPolicyRequestMarshaller();
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyRequest,DetachPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public IAsyncResult BeginDetachPolicy(DetachPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachPolicyRequestMarshaller();
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DetachPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachPolicy.</param>
        /// 
        /// <returns>Returns a  DetachPolicyResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public  DetachPolicyResponse EndDetachPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DisablePolicyType

        /// <summary>
        /// Disables an organizational control policy type in a root. A poicy of a certain type
        /// can be attached to entities in a root only if that type is enabled in the root. After
        /// you perform this operation, you no longer can attach policies of the specified type
        /// to that root or to any OU or account in that root. You can undo this by using the
        /// <a>EnablePolicyType</a> operation.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisablePolicyType service method.</param>
        /// 
        /// <returns>The response from the DisablePolicyType service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotEnabledException">
        /// The specified policy type is not currently enabled in this root. You cannot attach
        /// policies of the specified type to entities in a root until you enable that type in
        /// the root. For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.RootNotFoundException">
        /// We can't find a root with the RootId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisablePolicyType">REST API Reference for DisablePolicyType Operation</seealso>
        public DisablePolicyTypeResponse DisablePolicyType(DisablePolicyTypeRequest request)
        {
            var marshaller = new DisablePolicyTypeRequestMarshaller();
            var unmarshaller = DisablePolicyTypeResponseUnmarshaller.Instance;

            return Invoke<DisablePolicyTypeRequest,DisablePolicyTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisablePolicyType operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisablePolicyType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisablePolicyType">REST API Reference for DisablePolicyType Operation</seealso>
        public IAsyncResult BeginDisablePolicyType(DisablePolicyTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisablePolicyTypeRequestMarshaller();
            var unmarshaller = DisablePolicyTypeResponseUnmarshaller.Instance;

            return BeginInvoke<DisablePolicyTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisablePolicyType.</param>
        /// 
        /// <returns>Returns a  DisablePolicyTypeResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisablePolicyType">REST API Reference for DisablePolicyType Operation</seealso>
        public  DisablePolicyTypeResponse EndDisablePolicyType(IAsyncResult asyncResult)
        {
            return EndInvoke<DisablePolicyTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableAllFeatures

        /// <summary>
        /// Enables all features in an organization. This enables the use of organization policies
        /// that can restrict the services and actions that can be called in each account. Until
        /// you enable all features, you have access only to consolidated billing, and you can't
        /// use any of the advanced account administration features that AWS Organizations supports.
        /// For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// This operation is required only for organizations that were created explicitly with
        /// only the consolidated billing features enabled, or that were migrated from a Consolidated
        /// Billing account family to Organizations. Calling this operation sends a handshake
        /// to every invited account in the organization. The feature set change can be finalized
        /// and the additional features enabled only after all administrators in the invited accounts
        /// approve the change by accepting the handshake.
        /// </para>
        ///  </important> 
        /// <para>
        /// After all invited member accounts accept the handshake, you finalize the feature set
        /// change by accepting the handshake that contains <code>"Action": "ENABLE_ALL_FEATURES"</code>.
        /// This completes the change.
        /// </para>
        ///  
        /// <para>
        /// After you enable all features in your organization, the master account in the organization
        /// can apply policies on all member accounts. These policies can restrict what users
        /// and even administrators in those accounts can do. The master account can apply policies
        /// that prevent accounts from leaving the organization. Ensure that your account administrators
        /// are aware of this.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAllFeatures service method.</param>
        /// 
        /// <returns>The response from the EnableAllFeatures service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeConstraintViolationException">
        /// The requested operation would violate the constraint identified in the reason code.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAllFeatures">REST API Reference for EnableAllFeatures Operation</seealso>
        public EnableAllFeaturesResponse EnableAllFeatures(EnableAllFeaturesRequest request)
        {
            var marshaller = new EnableAllFeaturesRequestMarshaller();
            var unmarshaller = EnableAllFeaturesResponseUnmarshaller.Instance;

            return Invoke<EnableAllFeaturesRequest,EnableAllFeaturesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAllFeatures operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAllFeatures operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAllFeatures
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAllFeatures">REST API Reference for EnableAllFeatures Operation</seealso>
        public IAsyncResult BeginEnableAllFeatures(EnableAllFeaturesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableAllFeaturesRequestMarshaller();
            var unmarshaller = EnableAllFeaturesResponseUnmarshaller.Instance;

            return BeginInvoke<EnableAllFeaturesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAllFeatures operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAllFeatures.</param>
        /// 
        /// <returns>Returns a  EnableAllFeaturesResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAllFeatures">REST API Reference for EnableAllFeatures Operation</seealso>
        public  EnableAllFeaturesResponse EndEnableAllFeatures(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableAllFeaturesResponse>(asyncResult);
        }

        #endregion
        
        #region  EnablePolicyType

        /// <summary>
        /// Enables a policy type in a root. After you enable a policy type in a root, you can
        /// attach policies of that type to the root, any OU, or account in that root. You can
        /// undo this by using the <a>DisablePolicyType</a> operation.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnablePolicyType service method.</param>
        /// 
        /// <returns>The response from the EnablePolicyType service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeAlreadyEnabledException">
        /// The specified policy type is already enabled in the specified root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotAvailableForOrganizationException">
        /// You can't use the specified policy type with the feature set currently enabled for
        /// this organization. For example, you can enable service control policies (SCPs) only
        /// after you enable all features in the organization. For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html#enable_policies_on_root">Enabling
        /// and Disabling a Policy Type on a Root</a> in the <i>AWS Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.RootNotFoundException">
        /// We can't find a root with the RootId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnablePolicyType">REST API Reference for EnablePolicyType Operation</seealso>
        public EnablePolicyTypeResponse EnablePolicyType(EnablePolicyTypeRequest request)
        {
            var marshaller = new EnablePolicyTypeRequestMarshaller();
            var unmarshaller = EnablePolicyTypeResponseUnmarshaller.Instance;

            return Invoke<EnablePolicyTypeRequest,EnablePolicyTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnablePolicyType operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnablePolicyType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnablePolicyType">REST API Reference for EnablePolicyType Operation</seealso>
        public IAsyncResult BeginEnablePolicyType(EnablePolicyTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnablePolicyTypeRequestMarshaller();
            var unmarshaller = EnablePolicyTypeResponseUnmarshaller.Instance;

            return BeginInvoke<EnablePolicyTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnablePolicyType.</param>
        /// 
        /// <returns>Returns a  EnablePolicyTypeResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnablePolicyType">REST API Reference for EnablePolicyType Operation</seealso>
        public  EnablePolicyTypeResponse EndEnablePolicyType(IAsyncResult asyncResult)
        {
            return EndInvoke<EnablePolicyTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  InviteAccountToOrganization

        /// <summary>
        /// Sends an invitation to another account to join your organization as a member account.
        /// Organizations sends email on your behalf to the email address that is associated with
        /// the other account's owner. The invitation is implemented as a <a>Handshake</a> whose
        /// details are in the response.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteAccountToOrganization service method.</param>
        /// 
        /// <returns>The response from the InviteAccountToOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateHandshakeException">
        /// A handshake with the same action and target already exists. For example, if you invited
        /// an account to join your organization, the invited account might already have a pending
        /// invitation from this organization. If you intend to resend an invitation to an account,
        /// ensure that existing handshakes that might be considered duplicates are canceled or
        /// declined.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.FinalizingOrganizationException">
        /// AWS Organizations could not finalize the creation of your organization. Try again
        /// later. If this persists, contact AWS customer support.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeConstraintViolationException">
        /// The requested operation would violate the constraint identified in the reason code.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/InviteAccountToOrganization">REST API Reference for InviteAccountToOrganization Operation</seealso>
        public InviteAccountToOrganizationResponse InviteAccountToOrganization(InviteAccountToOrganizationRequest request)
        {
            var marshaller = new InviteAccountToOrganizationRequestMarshaller();
            var unmarshaller = InviteAccountToOrganizationResponseUnmarshaller.Instance;

            return Invoke<InviteAccountToOrganizationRequest,InviteAccountToOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InviteAccountToOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteAccountToOrganization operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInviteAccountToOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/InviteAccountToOrganization">REST API Reference for InviteAccountToOrganization Operation</seealso>
        public IAsyncResult BeginInviteAccountToOrganization(InviteAccountToOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new InviteAccountToOrganizationRequestMarshaller();
            var unmarshaller = InviteAccountToOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<InviteAccountToOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InviteAccountToOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInviteAccountToOrganization.</param>
        /// 
        /// <returns>Returns a  InviteAccountToOrganizationResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/InviteAccountToOrganization">REST API Reference for InviteAccountToOrganization Operation</seealso>
        public  InviteAccountToOrganizationResponse EndInviteAccountToOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<InviteAccountToOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  LeaveOrganization

        /// <summary>
        /// Removes a member account from its parent organization. This version of the operation
        /// is performed by the account that wants to leave. To remove a member account as a user
        /// in the master account, use <a>RemoveAccountFromOrganization</a> instead.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from a member account in the organization.
        /// </para>
        ///  <important> 
        /// <para>
        /// The master account in an organization with all features enabled can set service control
        /// policies (SCPs) that can restrict what administrators of member accounts can do, including
        /// preventing them from successfully calling <code>LeaveOrganization</code> and leaving
        /// the organization. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LeaveOrganization service method.</param>
        /// 
        /// <returns>The response from the LeaveOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an AWS account with the AccountId that you specified, or the account
        /// whose credentials you used to make this request is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MasterCannotLeaveOrganizationException">
        /// You can't remove a master account from an organization. If you want the master account
        /// to become a member account in another organization, you must first delete the current
        /// organization of the master account.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/LeaveOrganization">REST API Reference for LeaveOrganization Operation</seealso>
        public LeaveOrganizationResponse LeaveOrganization(LeaveOrganizationRequest request)
        {
            var marshaller = new LeaveOrganizationRequestMarshaller();
            var unmarshaller = LeaveOrganizationResponseUnmarshaller.Instance;

            return Invoke<LeaveOrganizationRequest,LeaveOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the LeaveOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LeaveOrganization operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLeaveOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/LeaveOrganization">REST API Reference for LeaveOrganization Operation</seealso>
        public IAsyncResult BeginLeaveOrganization(LeaveOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new LeaveOrganizationRequestMarshaller();
            var unmarshaller = LeaveOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<LeaveOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  LeaveOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLeaveOrganization.</param>
        /// 
        /// <returns>Returns a  LeaveOrganizationResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/LeaveOrganization">REST API Reference for LeaveOrganization Operation</seealso>
        public  LeaveOrganizationResponse EndLeaveOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<LeaveOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccounts

        /// <summary>
        /// Lists all the accounts in the organization. To request only the accounts in a root
        /// or OU, use the <a>ListAccountsForParent</a> operation instead.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            var marshaller = new ListAccountsRequestMarshaller();
            var unmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAccountsRequest,ListAccountsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public IAsyncResult BeginListAccounts(ListAccountsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAccountsRequestMarshaller();
            var unmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return BeginInvoke<ListAccountsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccounts.</param>
        /// 
        /// <returns>Returns a  ListAccountsResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public  ListAccountsResponse EndListAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountsForParent

        /// <summary>
        /// Lists the accounts in an organization that are contained by the specified target root
        /// or organizational unit (OU). If you specify the root, you get a list of all the accounts
        /// that are not in any OU. If you specify an OU, you get a list of all the accounts in
        /// only that OU, and not in any child OUs. To get a list of all accounts in the organization,
        /// use the <a>ListAccounts</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForParent service method.</param>
        /// 
        /// <returns>The response from the ListAccountsForParent service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or organizational unit (OU) with the ParentId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccountsForParent">REST API Reference for ListAccountsForParent Operation</seealso>
        public ListAccountsForParentResponse ListAccountsForParent(ListAccountsForParentRequest request)
        {
            var marshaller = new ListAccountsForParentRequestMarshaller();
            var unmarshaller = ListAccountsForParentResponseUnmarshaller.Instance;

            return Invoke<ListAccountsForParentRequest,ListAccountsForParentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountsForParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForParent operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountsForParent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccountsForParent">REST API Reference for ListAccountsForParent Operation</seealso>
        public IAsyncResult BeginListAccountsForParent(ListAccountsForParentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAccountsForParentRequestMarshaller();
            var unmarshaller = ListAccountsForParentResponseUnmarshaller.Instance;

            return BeginInvoke<ListAccountsForParentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountsForParent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountsForParent.</param>
        /// 
        /// <returns>Returns a  ListAccountsForParentResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccountsForParent">REST API Reference for ListAccountsForParent Operation</seealso>
        public  ListAccountsForParentResponse EndListAccountsForParent(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountsForParentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChildren

        /// <summary>
        /// Lists all of the OUs or accounts that are contained in the specified parent OU or
        /// root. This operation, along with <a>ListParents</a> enables you to traverse the tree
        /// structure that makes up this root.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChildren service method.</param>
        /// 
        /// <returns>The response from the ListChildren service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or organizational unit (OU) with the ParentId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListChildren">REST API Reference for ListChildren Operation</seealso>
        public ListChildrenResponse ListChildren(ListChildrenRequest request)
        {
            var marshaller = new ListChildrenRequestMarshaller();
            var unmarshaller = ListChildrenResponseUnmarshaller.Instance;

            return Invoke<ListChildrenRequest,ListChildrenResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChildren operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChildren operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChildren
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListChildren">REST API Reference for ListChildren Operation</seealso>
        public IAsyncResult BeginListChildren(ListChildrenRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListChildrenRequestMarshaller();
            var unmarshaller = ListChildrenResponseUnmarshaller.Instance;

            return BeginInvoke<ListChildrenRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChildren operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChildren.</param>
        /// 
        /// <returns>Returns a  ListChildrenResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListChildren">REST API Reference for ListChildren Operation</seealso>
        public  ListChildrenResponse EndListChildren(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChildrenResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCreateAccountStatus

        /// <summary>
        /// Lists the account creation requests that match the specified status that is currently
        /// being tracked for the organization.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCreateAccountStatus service method.</param>
        /// 
        /// <returns>The response from the ListCreateAccountStatus service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListCreateAccountStatus">REST API Reference for ListCreateAccountStatus Operation</seealso>
        public ListCreateAccountStatusResponse ListCreateAccountStatus(ListCreateAccountStatusRequest request)
        {
            var marshaller = new ListCreateAccountStatusRequestMarshaller();
            var unmarshaller = ListCreateAccountStatusResponseUnmarshaller.Instance;

            return Invoke<ListCreateAccountStatusRequest,ListCreateAccountStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCreateAccountStatus operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCreateAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListCreateAccountStatus">REST API Reference for ListCreateAccountStatus Operation</seealso>
        public IAsyncResult BeginListCreateAccountStatus(ListCreateAccountStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCreateAccountStatusRequestMarshaller();
            var unmarshaller = ListCreateAccountStatusResponseUnmarshaller.Instance;

            return BeginInvoke<ListCreateAccountStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCreateAccountStatus.</param>
        /// 
        /// <returns>Returns a  ListCreateAccountStatusResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListCreateAccountStatus">REST API Reference for ListCreateAccountStatus Operation</seealso>
        public  ListCreateAccountStatusResponse EndListCreateAccountStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCreateAccountStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHandshakesForAccount

        /// <summary>
        /// Lists the current handshakes that are associated with the account of the requesting
        /// user.
        /// 
        ///  
        /// <para>
        /// This operation can be called from any account in the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForAccount service method.</param>
        /// 
        /// <returns>The response from the ListHandshakesForAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForAccount">REST API Reference for ListHandshakesForAccount Operation</seealso>
        public ListHandshakesForAccountResponse ListHandshakesForAccount(ListHandshakesForAccountRequest request)
        {
            var marshaller = new ListHandshakesForAccountRequestMarshaller();
            var unmarshaller = ListHandshakesForAccountResponseUnmarshaller.Instance;

            return Invoke<ListHandshakesForAccountRequest,ListHandshakesForAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHandshakesForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForAccount operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHandshakesForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForAccount">REST API Reference for ListHandshakesForAccount Operation</seealso>
        public IAsyncResult BeginListHandshakesForAccount(ListHandshakesForAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListHandshakesForAccountRequestMarshaller();
            var unmarshaller = ListHandshakesForAccountResponseUnmarshaller.Instance;

            return BeginInvoke<ListHandshakesForAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHandshakesForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHandshakesForAccount.</param>
        /// 
        /// <returns>Returns a  ListHandshakesForAccountResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForAccount">REST API Reference for ListHandshakesForAccount Operation</seealso>
        public  ListHandshakesForAccountResponse EndListHandshakesForAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHandshakesForAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHandshakesForOrganization

        /// <summary>
        /// Lists the handshakes that are associated with the organization that the requesting
        /// user is part of. The <code>ListHandshakesForOrganization</code> operation returns
        /// a list of handshake structures. Each structure contains details and status about a
        /// handshake.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListHandshakesForOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForOrganization">REST API Reference for ListHandshakesForOrganization Operation</seealso>
        public ListHandshakesForOrganizationResponse ListHandshakesForOrganization(ListHandshakesForOrganizationRequest request)
        {
            var marshaller = new ListHandshakesForOrganizationRequestMarshaller();
            var unmarshaller = ListHandshakesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListHandshakesForOrganizationRequest,ListHandshakesForOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHandshakesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForOrganization operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHandshakesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForOrganization">REST API Reference for ListHandshakesForOrganization Operation</seealso>
        public IAsyncResult BeginListHandshakesForOrganization(ListHandshakesForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListHandshakesForOrganizationRequestMarshaller();
            var unmarshaller = ListHandshakesForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<ListHandshakesForOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHandshakesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHandshakesForOrganization.</param>
        /// 
        /// <returns>Returns a  ListHandshakesForOrganizationResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForOrganization">REST API Reference for ListHandshakesForOrganization Operation</seealso>
        public  ListHandshakesForOrganizationResponse EndListHandshakesForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHandshakesForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOrganizationalUnitsForParent

        /// <summary>
        /// Lists the organizational units (OUs) in a parent organizational unit or root.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnitsForParent service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationalUnitsForParent service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or organizational unit (OU) with the ParentId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListOrganizationalUnitsForParent">REST API Reference for ListOrganizationalUnitsForParent Operation</seealso>
        public ListOrganizationalUnitsForParentResponse ListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request)
        {
            var marshaller = new ListOrganizationalUnitsForParentRequestMarshaller();
            var unmarshaller = ListOrganizationalUnitsForParentResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationalUnitsForParentRequest,ListOrganizationalUnitsForParentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationalUnitsForParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnitsForParent operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationalUnitsForParent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListOrganizationalUnitsForParent">REST API Reference for ListOrganizationalUnitsForParent Operation</seealso>
        public IAsyncResult BeginListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListOrganizationalUnitsForParentRequestMarshaller();
            var unmarshaller = ListOrganizationalUnitsForParentResponseUnmarshaller.Instance;

            return BeginInvoke<ListOrganizationalUnitsForParentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationalUnitsForParent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationalUnitsForParent.</param>
        /// 
        /// <returns>Returns a  ListOrganizationalUnitsForParentResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListOrganizationalUnitsForParent">REST API Reference for ListOrganizationalUnitsForParent Operation</seealso>
        public  ListOrganizationalUnitsForParentResponse EndListOrganizationalUnitsForParent(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationalUnitsForParentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListParents

        /// <summary>
        /// Lists the root or organizational units (OUs) that serve as the immediate parent of
        /// the specified child OU or account. This operation, along with <a>ListChildren</a>
        /// enables you to traverse the tree structure that makes up this root.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the current release, a child can have only a single parent. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParents service method.</param>
        /// 
        /// <returns>The response from the ListParents service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ChildNotFoundException">
        /// We can't find an organizational unit (OU) or AWS account with the ChildId that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListParents">REST API Reference for ListParents Operation</seealso>
        public ListParentsResponse ListParents(ListParentsRequest request)
        {
            var marshaller = new ListParentsRequestMarshaller();
            var unmarshaller = ListParentsResponseUnmarshaller.Instance;

            return Invoke<ListParentsRequest,ListParentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParents operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListParents">REST API Reference for ListParents Operation</seealso>
        public IAsyncResult BeginListParents(ListParentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListParentsRequestMarshaller();
            var unmarshaller = ListParentsResponseUnmarshaller.Instance;

            return BeginInvoke<ListParentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListParents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParents.</param>
        /// 
        /// <returns>Returns a  ListParentsResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListParents">REST API Reference for ListParents Operation</seealso>
        public  ListParentsResponse EndListParents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListParentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicies

        /// <summary>
        /// Retrieves the list of all policies in an organization of a specified type.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var marshaller = new ListPoliciesRequestMarshaller();
            var unmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesRequest,ListPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public IAsyncResult BeginListPolicies(ListPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPoliciesRequestMarshaller();
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
        /// <returns>Returns a  ListPoliciesResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public  ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPoliciesForTarget

        /// <summary>
        /// Lists the policies that are directly attached to the specified target root, organizational
        /// unit (OU), or account. You must specify the policy type that you want included in
        /// the returned list.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesForTarget service method.</param>
        /// 
        /// <returns>The response from the ListPoliciesForTarget service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, or account with the TargetId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPoliciesForTarget">REST API Reference for ListPoliciesForTarget Operation</seealso>
        public ListPoliciesForTargetResponse ListPoliciesForTarget(ListPoliciesForTargetRequest request)
        {
            var marshaller = new ListPoliciesForTargetRequestMarshaller();
            var unmarshaller = ListPoliciesForTargetResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesForTargetRequest,ListPoliciesForTargetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPoliciesForTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesForTarget operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPoliciesForTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPoliciesForTarget">REST API Reference for ListPoliciesForTarget Operation</seealso>
        public IAsyncResult BeginListPoliciesForTarget(ListPoliciesForTargetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPoliciesForTargetRequestMarshaller();
            var unmarshaller = ListPoliciesForTargetResponseUnmarshaller.Instance;

            return BeginInvoke<ListPoliciesForTargetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPoliciesForTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPoliciesForTarget.</param>
        /// 
        /// <returns>Returns a  ListPoliciesForTargetResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPoliciesForTarget">REST API Reference for ListPoliciesForTarget Operation</seealso>
        public  ListPoliciesForTargetResponse EndListPoliciesForTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPoliciesForTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoots

        /// <summary>
        /// Lists the roots that are defined in the current organization.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoots service method.</param>
        /// 
        /// <returns>The response from the ListRoots service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListRoots">REST API Reference for ListRoots Operation</seealso>
        public ListRootsResponse ListRoots(ListRootsRequest request)
        {
            var marshaller = new ListRootsRequestMarshaller();
            var unmarshaller = ListRootsResponseUnmarshaller.Instance;

            return Invoke<ListRootsRequest,ListRootsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoots operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListRoots">REST API Reference for ListRoots Operation</seealso>
        public IAsyncResult BeginListRoots(ListRootsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListRootsRequestMarshaller();
            var unmarshaller = ListRootsResponseUnmarshaller.Instance;

            return BeginInvoke<ListRootsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoots.</param>
        /// 
        /// <returns>Returns a  ListRootsResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListRoots">REST API Reference for ListRoots Operation</seealso>
        public  ListRootsResponse EndListRoots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRootsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTargetsForPolicy

        /// <summary>
        /// Lists all the roots, OUs, and accounts to which the specified policy is attached.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy service method.</param>
        /// 
        /// <returns>The response from the ListTargetsForPolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the PolicyId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        public ListTargetsForPolicyResponse ListTargetsForPolicy(ListTargetsForPolicyRequest request)
        {
            var marshaller = new ListTargetsForPolicyRequestMarshaller();
            var unmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTargetsForPolicyRequest,ListTargetsForPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetsForPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        public IAsyncResult BeginListTargetsForPolicy(ListTargetsForPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTargetsForPolicyRequestMarshaller();
            var unmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<ListTargetsForPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetsForPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetsForPolicy.</param>
        /// 
        /// <returns>Returns a  ListTargetsForPolicyResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        public  ListTargetsForPolicyResponse EndListTargetsForPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTargetsForPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  MoveAccount

        /// <summary>
        /// Moves an account from its current source parent root or OU to the specified destination
        /// parent root or OU.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveAccount service method.</param>
        /// 
        /// <returns>The response from the MoveAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an AWS account with the AccountId that you specified, or the account
        /// whose credentials you used to make this request is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DestinationParentNotFoundException">
        /// We can't find the destination container (a root or OU) with the ParentId that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateAccountException">
        /// That account is already present in the specified destination.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.SourceParentNotFoundException">
        /// We can't find a source root or OU with the ParentId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/MoveAccount">REST API Reference for MoveAccount Operation</seealso>
        public MoveAccountResponse MoveAccount(MoveAccountRequest request)
        {
            var marshaller = new MoveAccountRequestMarshaller();
            var unmarshaller = MoveAccountResponseUnmarshaller.Instance;

            return Invoke<MoveAccountRequest,MoveAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MoveAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveAccount operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMoveAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/MoveAccount">REST API Reference for MoveAccount Operation</seealso>
        public IAsyncResult BeginMoveAccount(MoveAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new MoveAccountRequestMarshaller();
            var unmarshaller = MoveAccountResponseUnmarshaller.Instance;

            return BeginInvoke<MoveAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MoveAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMoveAccount.</param>
        /// 
        /// <returns>Returns a  MoveAccountResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/MoveAccount">REST API Reference for MoveAccount Operation</seealso>
        public  MoveAccountResponse EndMoveAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<MoveAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAccountFromOrganization

        /// <summary>
        /// Removes the specified account from the organization.
        /// 
        ///  
        /// <para>
        /// The removed account becomes a stand-alone account that is not a member of any organization.
        /// It is no longer subject to any policies and is responsible for its own bill payments.
        /// The organization's master account is no longer charged for any expenses accrued by
        /// the member account after it is removed from the organization.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account. Member accounts
        /// can remove themselves with <a>LeaveOrganization</a> instead.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can remove only existing accounts that were invited to join the organization.
        /// You cannot remove accounts that were created by AWS Organizations.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAccountFromOrganization service method.</param>
        /// 
        /// <returns>The response from the RemoveAccountFromOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an AWS account with the AccountId that you specified, or the account
        /// whose credentials you used to make this request is not a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MasterCannotLeaveOrganizationException">
        /// You can't remove a master account from an organization. If you want the master account
        /// to become a member account in another organization, you must first delete the current
        /// organization of the master account.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/RemoveAccountFromOrganization">REST API Reference for RemoveAccountFromOrganization Operation</seealso>
        public RemoveAccountFromOrganizationResponse RemoveAccountFromOrganization(RemoveAccountFromOrganizationRequest request)
        {
            var marshaller = new RemoveAccountFromOrganizationRequestMarshaller();
            var unmarshaller = RemoveAccountFromOrganizationResponseUnmarshaller.Instance;

            return Invoke<RemoveAccountFromOrganizationRequest,RemoveAccountFromOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAccountFromOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAccountFromOrganization operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAccountFromOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/RemoveAccountFromOrganization">REST API Reference for RemoveAccountFromOrganization Operation</seealso>
        public IAsyncResult BeginRemoveAccountFromOrganization(RemoveAccountFromOrganizationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveAccountFromOrganizationRequestMarshaller();
            var unmarshaller = RemoveAccountFromOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveAccountFromOrganizationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAccountFromOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAccountFromOrganization.</param>
        /// 
        /// <returns>Returns a  RemoveAccountFromOrganizationResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/RemoveAccountFromOrganization">REST API Reference for RemoveAccountFromOrganization Operation</seealso>
        public  RemoveAccountFromOrganizationResponse EndRemoveAccountFromOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAccountFromOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOrganizationalUnit

        /// <summary>
        /// Renames the specified organizational unit (OU). The ID and ARN do not change. The
        /// child OUs and accounts remain in place, and any attached policies of the OU remain
        /// attached. 
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationalUnit service method.</param>
        /// 
        /// <returns>The response from the UpdateOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateOrganizationalUnitException">
        /// An organizational unit (OU) with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotFoundException">
        /// We can't find an organizational unit (OU) with the OrganizationalUnitId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdateOrganizationalUnit">REST API Reference for UpdateOrganizationalUnit Operation</seealso>
        public UpdateOrganizationalUnitResponse UpdateOrganizationalUnit(UpdateOrganizationalUnitRequest request)
        {
            var marshaller = new UpdateOrganizationalUnitRequestMarshaller();
            var unmarshaller = UpdateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationalUnitRequest,UpdateOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationalUnit operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOrganizationalUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdateOrganizationalUnit">REST API Reference for UpdateOrganizationalUnit Operation</seealso>
        public IAsyncResult BeginUpdateOrganizationalUnit(UpdateOrganizationalUnitRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateOrganizationalUnitRequestMarshaller();
            var unmarshaller = UpdateOrganizationalUnitResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateOrganizationalUnitRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOrganizationalUnit.</param>
        /// 
        /// <returns>Returns a  UpdateOrganizationalUnitResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdateOrganizationalUnit">REST API Reference for UpdateOrganizationalUnit Operation</seealso>
        public  UpdateOrganizationalUnitResponse EndUpdateOrganizationalUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOrganizationalUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePolicy

        /// <summary>
        /// Updates an existing policy with a new name, description, or content. If any parameter
        /// is not supplied, that value remains unchanged. Note that you cannot change a policy's
        /// type.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account is not a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicatePolicyException">
        /// A policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// You provided invalid values for one or more of the request parameters.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MalformedPolicyDocumentException">
        /// The provided policy document does not meet the requirements of the specified policy
        /// type. For example, the syntax might be incorrect. For details about service control
        /// policy syntax, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_scp-syntax.html">Service
        /// Control Policy Syntax</a> in the <i>AWS Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the PolicyId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            var marshaller = new UpdatePolicyRequestMarshaller();
            var unmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyRequest,UpdatePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy operation on AmazonOrganizationsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public IAsyncResult BeginUpdatePolicy(UpdatePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdatePolicyRequestMarshaller();
            var unmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdatePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePolicy.</param>
        /// 
        /// <returns>Returns a  UpdatePolicyResult from Organizations.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public  UpdatePolicyResponse EndUpdatePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePolicyResponse>(asyncResult);
        }

        #endregion
        
    }
}