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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    /// We welcome your feedback. Send your comments to <a href="mailto:feedback-awsorganizations@amazon.com">feedback-awsorganizations@amazon.com</a>
    /// or post your feedback and questions in the <a href="http://forums.aws.amazon.com/forum.jspa?forumID=219">AWS
    /// Organizations support forum</a>. For more information about the AWS support forums,
    /// see <a href="http://forums.aws.amazon.com/help.jspa">Forums Help</a>.
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
    /// AWS Organizations and its support for AWS CloudTrail, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_monitoring.html#orgs_cloudtrail-integration">Logging
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
        ///  
        /// <para>
        /// The user who calls the API for an invitation to join must have the <code>organizations:AcceptHandshake</code>
        /// permission. If you enabled all features in the organization, then the user must also
        /// have the <code>iam:CreateServiceLinkedRole</code> permission so that Organizations
        /// can create the required service-linked role named <i>OrgsServiceLinkedRoleName</i>.
        /// For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_integration_services.html#orgs_integration_service-linked-roles">AWS
        /// Organizations and Service-Linked Roles</a> in the <i>AWS Organizations User Guide</i>.
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
        /// <para>
        /// After you accept a handshake, it continues to appear in the results of relevant APIs
        /// for only 30 days. After that it is deleted.
        /// </para>
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
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedForDependencyException">
        /// The operation you attempted requires you to have the <code>iam:CreateServiceLinkedRole</code>
        /// so that Organizations can create the required service-linked role. You do not have
        /// that permission.
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
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. <b>Note</b>: deleted and closed accounts still count
        /// toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get this exception immediately after creating the organization, wait one hour
        /// and try again. If after an hour it continues to fail with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ALREADY_IN_AN_ORGANIZATION: The handshake request is invalid because the invited account
        /// is already a member of an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_ALREADY_HAS_ALL_FEATURES: The handshake request is invalid because the
        /// organization has already enabled all features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES: You cannot issue new invitations to join
        /// an organization while it is in the process of enabling all features. You can resume
        /// inviting accounts after you finalize the process when all accounts have agreed to
        /// the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PAYMENT_INSTRUMENT_REQUIRED: You cannot complete the operation with an account that
        /// does not have a payment instrument, such as a credit card, associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_FROM_DIFFERENT_SELLER_OF_RECORD: The request failed because the account
        /// is from a different marketplace than the accounts in the organization. For example,
        /// accounts with India addresses must be associated with the AISPL marketplace. All accounts
        /// in an organization must be from the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_MEMBERSHIP_CHANGE_RATE_LIMIT_EXCEEDED: You attempted to change the membership
        /// of an account too quickly after its previous change.
        /// </para>
        ///  </li> </ul>
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual AcceptHandshakeResponse AcceptHandshake(AcceptHandshakeRequest request)
        {
            var marshaller = AcceptHandshakeRequestMarshaller.Instance;
            var unmarshaller = AcceptHandshakeResponseUnmarshaller.Instance;

            return Invoke<AcceptHandshakeRequest,AcceptHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AcceptHandshake">REST API Reference for AcceptHandshake Operation</seealso>
        public virtual Task<AcceptHandshakeResponse> AcceptHandshakeAsync(AcceptHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptHandshakeRequestMarshaller.Instance;
            var unmarshaller = AcceptHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptHandshakeRequest,AcceptHandshakeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachPolicy


        /// <summary>
        /// Attaches a policy to a root, an organizational unit (OU), or an individual account.
        /// How the policy affects accounts depends on the type of policy:
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicatePolicyAttachmentException">
        /// The selected policy is already attached to the specified target.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var marshaller = AttachPolicyRequestMarshaller.Instance;
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyRequest,AttachPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachPolicyRequestMarshaller.Instance;
            var unmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPolicyRequest,AttachPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        ///  
        /// <para>
        /// After you cancel a handshake, it continues to appear in the results of relevant APIs
        /// for only 30 days. After that it is deleted.
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual CancelHandshakeResponse CancelHandshake(CancelHandshakeRequest request)
        {
            var marshaller = CancelHandshakeRequestMarshaller.Instance;
            var unmarshaller = CancelHandshakeResponseUnmarshaller.Instance;

            return Invoke<CancelHandshakeRequest,CancelHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CancelHandshake">REST API Reference for CancelHandshake Operation</seealso>
        public virtual Task<CancelHandshakeResponse> CancelHandshakeAsync(CancelHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelHandshakeRequestMarshaller.Instance;
            var unmarshaller = CancelHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<CancelHandshakeRequest,CancelHandshakeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The user who calls the API for an invitation to join must have the <code>organizations:CreateAccount</code>
        /// permission. If you enabled all features in the organization, then the user must also
        /// have the <code>iam:CreateServiceLinkedRole</code> permission so that Organizations
        /// can create the required service-linked role named <i>OrgsServiceLinkedRoleName</i>.
        /// For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_integration_services.html#orgs_integration_service-linked-roles">AWS
        /// Organizations and Service-Linked Roles</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The user in the master account who calls this API must also have the <code>iam:CreateRole</code>
        /// permission because AWS Organizations preconfigures the new member account with a role
        /// (named <code>OrganizationAccountAccessRole</code> by default) that grants users in
        /// the master account administrator permissions in the new member account. Principals
        /// in the master account can assume the role. AWS Organizations clones the company name
        /// and address information for the new account from the organization's master account.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating accounts, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_create.html">Creating
        /// an AWS Account in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// When you create an account in an organization using the AWS Organizations console,
        /// API, or CLI commands, the information required for the account to operate as a standalone
        /// account, such as a payment method and signing the End User Licence Agreement (EULA)
        /// is <i>not</i> automatically collected. If you must remove an account from your organization
        /// later, you can do so only after you provide the missing information. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
        /// To leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you get an exception that indicates that you exceeded your account limits for the
        /// organization or that the operation failed because your organization is still initializing,
        /// wait one hour and then try again. If the error persists after an hour, then contact
        /// <a href="https://console.aws.amazon.com/support/home#/">AWS Customer Support</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Because <code>CreateAccount</code> operates asynchronously, it can return a successful
        /// completion message even though account initialization might still be in progress.
        /// You might need to wait a few minutes before you can successfully access the account.
        /// 
        /// </para>
        ///  </li> </ul> </important> <note> 
        /// <para>
        /// When you create a member account with this operation, you can choose whether to create
        /// the account with the <b>IAM User and Role Access to Billing Information</b> switch
        /// enabled. If you enable it, IAM users and roles that have appropriate permissions can
        /// view billing information for the account. If you disable this, then only the account
        /// root user can access billing information. For information about how to disable this
        /// for an account, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html">Granting
        /// Access to Your Billing Information and Tools</a>.
        /// </para>
        ///  </note>
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.FinalizingOrganizationException">
        /// AWS Organizations could not perform the operation because your organization has not
        /// finished initializing. This can take up to an hour. Try again later. If after one
        /// hour you continue to receive this error, contact <a href="https://console.aws.amazon.com/support/home#/">
        /// AWS Customer Support</a>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var marshaller = CreateAccountRequestMarshaller.Instance;
            var unmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return Invoke<CreateAccountRequest,CreateAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public virtual Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAccountRequestMarshaller.Instance;
            var unmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountRequest,CreateAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedForDependencyException">
        /// The operation you attempted requires you to have the <code>iam:CreateServiceLinkedRole</code>
        /// so that Organizations can create the required service-linked role. You do not have
        /// that permission.
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest request)
        {
            var marshaller = CreateOrganizationRequestMarshaller.Instance;
            var unmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateOrganizationRequest,CreateOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        public virtual Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateOrganizationRequestMarshaller.Instance;
            var unmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrganizationRequest,CreateOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to removing the last SCP from an OU or root, inviting or creating too many
        /// accounts to the organization, or attaching too many policies to an account, OU, or
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateOrganizationalUnitException">
        /// An organizational unit (OU) with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual CreateOrganizationalUnitResponse CreateOrganizationalUnit(CreateOrganizationalUnitRequest request)
        {
            var marshaller = CreateOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = CreateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<CreateOrganizationalUnitRequest,CreateOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganizationalUnit">REST API Reference for CreateOrganizationalUnit Operation</seealso>
        public virtual Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsync(CreateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = CreateOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrganizationalUnitRequest,CreateOrganizationalUnitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicatePolicyException">
        /// A policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var marshaller = CreatePolicyRequestMarshaller.Instance;
            var unmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyRequest,CreatePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePolicyRequestMarshaller.Instance;
            var unmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyRequest,CreatePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        ///  
        /// <para>
        /// After you decline a handshake, it continues to appear in the results of relevant APIs
        /// for only 30 days. After that it is deleted.
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DeclineHandshakeResponse DeclineHandshake(DeclineHandshakeRequest request)
        {
            var marshaller = DeclineHandshakeRequestMarshaller.Instance;
            var unmarshaller = DeclineHandshakeResponseUnmarshaller.Instance;

            return Invoke<DeclineHandshakeRequest,DeclineHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeclineHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeclineHandshake">REST API Reference for DeclineHandshake Operation</seealso>
        public virtual Task<DeclineHandshakeResponse> DeclineHandshakeAsync(DeclineHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeclineHandshakeRequestMarshaller.Instance;
            var unmarshaller = DeclineHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<DeclineHandshakeRequest,DeclineHandshakeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteOrganization


        /// <summary>
        /// Deletes the organization. You can delete an organization only by using credentials
        /// from the master account. The organization must be empty of member accounts, organizational
        /// units (OUs), and policies.
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest request)
        {
            var marshaller = DeleteOrganizationRequestMarshaller.Instance;
            var unmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationRequest,DeleteOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        public virtual Task<DeleteOrganizationResponse> DeleteOrganizationAsync(DeleteOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteOrganizationRequestMarshaller.Instance;
            var unmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOrganizationRequest,DeleteOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteOrganizationalUnit


        /// <summary>
        /// Deletes an organizational unit (OU) from a root or another OU. You must first remove
        /// all accounts and child OUs from the OU that you want to delete.
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DeleteOrganizationalUnitResponse DeleteOrganizationalUnit(DeleteOrganizationalUnitRequest request)
        {
            var marshaller = DeleteOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = DeleteOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationalUnitRequest,DeleteOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganizationalUnit">REST API Reference for DeleteOrganizationalUnit Operation</seealso>
        public virtual Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsync(DeleteOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = DeleteOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOrganizationalUnitRequest,DeleteOrganizationalUnitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified policy from your organization. Before you perform this operation,
        /// you must first detach the policy from all organizational units (OUs), roots, and accounts.
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePolicyRequestMarshaller.Instance;
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DescribeAccountResponse DescribeAccount(DescribeAccountRequest request)
        {
            var marshaller = DescribeAccountRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountRequest,DescribeAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual Task<DescribeAccountResponse> DescribeAccountAsync(DescribeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAccountRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountRequest,DescribeAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DescribeCreateAccountStatusResponse DescribeCreateAccountStatus(DescribeCreateAccountStatusRequest request)
        {
            var marshaller = DescribeCreateAccountStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeCreateAccountStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCreateAccountStatusRequest,DescribeCreateAccountStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCreateAccountStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeCreateAccountStatus">REST API Reference for DescribeCreateAccountStatus Operation</seealso>
        public virtual Task<DescribeCreateAccountStatusResponse> DescribeCreateAccountStatusAsync(DescribeCreateAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCreateAccountStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeCreateAccountStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCreateAccountStatusRequest,DescribeCreateAccountStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// You can access handshakes that are ACCEPTED, DECLINED, or CANCELED for only 30 days
        /// after they change to that state. They are then deleted and no longer accessible.
        /// </para>
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeNotFoundException">
        /// We can't find a handshake with the HandshakeId that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DescribeHandshakeResponse DescribeHandshake(DescribeHandshakeRequest request)
        {
            var marshaller = DescribeHandshakeRequestMarshaller.Instance;
            var unmarshaller = DescribeHandshakeResponseUnmarshaller.Instance;

            return Invoke<DescribeHandshakeRequest,DescribeHandshakeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeHandshake">REST API Reference for DescribeHandshake Operation</seealso>
        public virtual Task<DescribeHandshakeResponse> DescribeHandshakeAsync(DescribeHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeHandshakeRequestMarshaller.Instance;
            var unmarshaller = DescribeHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHandshakeRequest,DescribeHandshakeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        ///  <note> 
        /// <para>
        /// Even if a policy type is shown as available in the organization, it can be disabled
        /// separately at the root level with <a>DisablePolicyType</a>. Use <a>ListRoots</a> to
        /// see the status of policy types for a specified root.
        /// </para>
        ///  </note>
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
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
        public virtual DescribeOrganizationResponse DescribeOrganization(DescribeOrganizationRequest request)
        {
            var marshaller = DescribeOrganizationRequestMarshaller.Instance;
            var unmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationRequest,DescribeOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public virtual Task<DescribeOrganizationResponse> DescribeOrganizationAsync(DescribeOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeOrganizationRequestMarshaller.Instance;
            var unmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationRequest,DescribeOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DescribeOrganizationalUnitResponse DescribeOrganizationalUnit(DescribeOrganizationalUnitRequest request)
        {
            var marshaller = DescribeOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = DescribeOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationalUnitRequest,DescribeOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganizationalUnit">REST API Reference for DescribeOrganizationalUnit Operation</seealso>
        public virtual Task<DescribeOrganizationalUnitResponse> DescribeOrganizationalUnitAsync(DescribeOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = DescribeOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationalUnitRequest,DescribeOrganizationalUnitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DescribePolicyResponse DescribePolicy(DescribePolicyRequest request)
        {
            var marshaller = DescribePolicyRequestMarshaller.Instance;
            var unmarshaller = DescribePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribePolicyRequest,DescribePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribePolicy">REST API Reference for DescribePolicy Operation</seealso>
        public virtual Task<DescribePolicyResponse> DescribePolicyAsync(DescribePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePolicyRequestMarshaller.Instance;
            var unmarshaller = DescribePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePolicyRequest,DescribePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachPolicy


        /// <summary>
        /// Detaches a policy from a target root, organizational unit (OU), or account. If the
        /// policy being detached is a service control policy (SCP), the changes to permissions
        /// for IAM users and roles in affected accounts are immediate.
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var marshaller = DetachPolicyRequestMarshaller.Instance;
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyRequest,DetachPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachPolicyRequestMarshaller.Instance;
            var unmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPolicyRequest,DetachPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableAWSServiceAccess


        /// <summary>
        /// Disables the integration of an AWS service (the service that is specified by <code>ServicePrincipal</code>)
        /// with AWS Organizations. When you disable integration, the specified service no longer
        /// can create a <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
        /// role</a> in <i>new</i> accounts in your organization. This means the service can't
        /// perform operations on your behalf on any new accounts in your organization. The service
        /// can still perform operations in older accounts until the service completes its clean-up
        /// from AWS Organizations.
        /// 
        ///   <important> 
        /// <para>
        /// We recommend that you disable integration between AWS Organizations and the specified
        /// AWS service by using the console or commands that are provided by the specified service.
        /// Doing so ensures that the other service is aware that it can clean up any resources
        /// that are required only for the integration. How the service cleans up its resources
        /// in the organization's accounts depends on that service. For more information, see
        /// the documentation for the other AWS service.
        /// </para>
        ///  </important> 
        /// <para>
        /// After you perform the <code>DisableAWSServiceAccess</code> operation, the specified
        /// service can no longer perform operations in your organization's accounts unless the
        /// operations are explicitly permitted by the IAM policies that are attached to your
        /// roles. 
        /// </para>
        ///  
        /// <para>
        /// For more information about integrating other services with AWS Organizations, including
        /// the list of services that work with Organizations, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Integrating
        /// AWS Organizations with Other AWS Services</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSServiceAccess service method.</param>
        /// 
        /// <returns>The response from the DisableAWSServiceAccess service method, as returned by Organizations.</returns>
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisableAWSServiceAccess">REST API Reference for DisableAWSServiceAccess Operation</seealso>
        public virtual DisableAWSServiceAccessResponse DisableAWSServiceAccess(DisableAWSServiceAccessRequest request)
        {
            var marshaller = DisableAWSServiceAccessRequestMarshaller.Instance;
            var unmarshaller = DisableAWSServiceAccessResponseUnmarshaller.Instance;

            return Invoke<DisableAWSServiceAccessRequest,DisableAWSServiceAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAWSServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSServiceAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisableAWSServiceAccess">REST API Reference for DisableAWSServiceAccess Operation</seealso>
        public virtual Task<DisableAWSServiceAccessResponse> DisableAWSServiceAccessAsync(DisableAWSServiceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableAWSServiceAccessRequestMarshaller.Instance;
            var unmarshaller = DisableAWSServiceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAWSServiceAccessRequest,DisableAWSServiceAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisablePolicyType


        /// <summary>
        /// Disables an organizational control policy type in a root. A policy of a certain type
        /// can be attached to entities in a root only if that type is enabled in the root. After
        /// you perform this operation, you no longer can attach policies of the specified type
        /// to that root or to any organizational unit (OU) or account in that root. You can undo
        /// this by using the <a>EnablePolicyType</a> operation.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you disable a policy type for a root, it still shows as enabled for the organization
        /// if all features are enabled in that organization. Use <a>ListRoots</a> to see the
        /// status of policy types for a specified root. Use <a>DescribeOrganization</a> to see
        /// the status of policy types in the organization.
        /// </para>
        ///  </note>
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual DisablePolicyTypeResponse DisablePolicyType(DisablePolicyTypeRequest request)
        {
            var marshaller = DisablePolicyTypeRequestMarshaller.Instance;
            var unmarshaller = DisablePolicyTypeResponseUnmarshaller.Instance;

            return Invoke<DisablePolicyTypeRequest,DisablePolicyTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisablePolicyType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisablePolicyType">REST API Reference for DisablePolicyType Operation</seealso>
        public virtual Task<DisablePolicyTypeResponse> DisablePolicyTypeAsync(DisablePolicyTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisablePolicyTypeRequestMarshaller.Instance;
            var unmarshaller = DisablePolicyTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DisablePolicyTypeRequest,DisablePolicyTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// only the consolidated billing features enabled. Calling this operation sends a handshake
        /// to every invited account in the organization. The feature set change can be finalized
        /// and the additional features enabled only after all administrators in the invited accounts
        /// approve the change by accepting the handshake.
        /// </para>
        ///  </important> 
        /// <para>
        /// After you enable all features, you can separately enable or disable individual policy
        /// types in a root using <a>EnablePolicyType</a> and <a>DisablePolicyType</a>. To see
        /// the status of policy types in a root, use <a>ListRoots</a>.
        /// </para>
        ///  
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeConstraintViolationException">
        /// The requested operation would violate the constraint identified in the reason code.
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. <b>Note</b>: deleted and closed accounts still count
        /// toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get this exception immediately after creating the organization, wait one hour
        /// and try again. If after an hour it continues to fail with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ALREADY_IN_AN_ORGANIZATION: The handshake request is invalid because the invited account
        /// is already a member of an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_ALREADY_HAS_ALL_FEATURES: The handshake request is invalid because the
        /// organization has already enabled all features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES: You cannot issue new invitations to join
        /// an organization while it is in the process of enabling all features. You can resume
        /// inviting accounts after you finalize the process when all accounts have agreed to
        /// the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PAYMENT_INSTRUMENT_REQUIRED: You cannot complete the operation with an account that
        /// does not have a payment instrument, such as a credit card, associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_FROM_DIFFERENT_SELLER_OF_RECORD: The request failed because the account
        /// is from a different marketplace than the accounts in the organization. For example,
        /// accounts with India addresses must be associated with the AISPL marketplace. All accounts
        /// in an organization must be from the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_MEMBERSHIP_CHANGE_RATE_LIMIT_EXCEEDED: You attempted to change the membership
        /// of an account too quickly after its previous change.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual EnableAllFeaturesResponse EnableAllFeatures(EnableAllFeaturesRequest request)
        {
            var marshaller = EnableAllFeaturesRequestMarshaller.Instance;
            var unmarshaller = EnableAllFeaturesResponseUnmarshaller.Instance;

            return Invoke<EnableAllFeaturesRequest,EnableAllFeaturesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAllFeatures operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAllFeatures operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAllFeatures">REST API Reference for EnableAllFeatures Operation</seealso>
        public virtual Task<EnableAllFeaturesResponse> EnableAllFeaturesAsync(EnableAllFeaturesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableAllFeaturesRequestMarshaller.Instance;
            var unmarshaller = EnableAllFeaturesResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAllFeaturesRequest,EnableAllFeaturesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableAWSServiceAccess


        /// <summary>
        /// Enables the integration of an AWS service (the service that is specified by <code>ServicePrincipal</code>)
        /// with AWS Organizations. When you enable integration, you allow the specified service
        /// to create a <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
        /// role</a> in all the accounts in your organization. This allows the service to perform
        /// operations on your behalf in your organization and its accounts.
        /// 
        ///  <important> 
        /// <para>
        /// We recommend that you enable integration between AWS Organizations and the specified
        /// AWS service by using the console or commands that are provided by the specified service.
        /// Doing so ensures that the service is aware that it can create the resources that are
        /// required for the integration. How the service creates those resources in the organization's
        /// accounts depends on that service. For more information, see the documentation for
        /// the other AWS service.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about enabling services to integrate with AWS Organizations,
        /// see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Integrating
        /// AWS Organizations with Other AWS Services</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account and only
        /// if the organization has <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">enabled
        /// all features</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSServiceAccess service method.</param>
        /// 
        /// <returns>The response from the EnableAWSServiceAccess service method, as returned by Organizations.</returns>
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAWSServiceAccess">REST API Reference for EnableAWSServiceAccess Operation</seealso>
        public virtual EnableAWSServiceAccessResponse EnableAWSServiceAccess(EnableAWSServiceAccessRequest request)
        {
            var marshaller = EnableAWSServiceAccessRequestMarshaller.Instance;
            var unmarshaller = EnableAWSServiceAccessResponseUnmarshaller.Instance;

            return Invoke<EnableAWSServiceAccessRequest,EnableAWSServiceAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAWSServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSServiceAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAWSServiceAccess">REST API Reference for EnableAWSServiceAccess Operation</seealso>
        public virtual Task<EnableAWSServiceAccessResponse> EnableAWSServiceAccessAsync(EnableAWSServiceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableAWSServiceAccessRequestMarshaller.Instance;
            var unmarshaller = EnableAWSServiceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAWSServiceAccessRequest,EnableAWSServiceAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnablePolicyType


        /// <summary>
        /// Enables a policy type in a root. After you enable a policy type in a root, you can
        /// attach policies of that type to the root, any organizational unit (OU), or account
        /// in that root. You can undo this by using the <a>DisablePolicyType</a> operation.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        ///  
        /// <para>
        /// You can enable a policy type in a root only if that policy type is available in the
        /// organization. Use <a>DescribeOrganization</a> to view the status of available policy
        /// types in the organization.
        /// </para>
        ///  
        /// <para>
        /// To view the status of policy type in a root, use <a>ListRoots</a>.
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual EnablePolicyTypeResponse EnablePolicyType(EnablePolicyTypeRequest request)
        {
            var marshaller = EnablePolicyTypeRequestMarshaller.Instance;
            var unmarshaller = EnablePolicyTypeResponseUnmarshaller.Instance;

            return Invoke<EnablePolicyTypeRequest,EnablePolicyTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnablePolicyType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnablePolicyType">REST API Reference for EnablePolicyType Operation</seealso>
        public virtual Task<EnablePolicyTypeResponse> EnablePolicyTypeAsync(EnablePolicyTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnablePolicyTypeRequestMarshaller.Instance;
            var unmarshaller = EnablePolicyTypeResponseUnmarshaller.Instance;

            return InvokeAsync<EnablePolicyTypeRequest,EnablePolicyTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InviteAccountToOrganization


        /// <summary>
        /// Sends an invitation to another account to join your organization as a member account.
        /// Organizations sends email on your behalf to the email address that is associated with
        /// the other account's owner. The invitation is implemented as a <a>Handshake</a> whose
        /// details are in the response.
        /// 
        ///  <important> <ul> <li> 
        /// <para>
        /// You can invite AWS accounts only from the same seller as the master account. For example,
        /// if your organization's master account was created by Amazon Internet Services Pvt.
        /// Ltd (AISPL), an AWS seller in India, then you can only invite other AISPL accounts
        /// to your organization. You can't combine accounts from AISPL and AWS, or any other
        /// AWS seller. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/useconsolidatedbilliing-India.html">Consolidated
        /// Billing in India</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you receive an exception that indicates that you exceeded your account limits for
        /// the organization or that the operation failed because your organization is still initializing,
        /// wait one hour and then try again. If the error persists after an hour, then contact
        /// <a href="https://console.aws.amazon.com/support/home#/">AWS Customer Support</a>.
        /// </para>
        ///  </li> </ul> </important> 
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateHandshakeException">
        /// A handshake with the same action and target already exists. For example, if you invited
        /// an account to join your organization, the invited account might already have a pending
        /// invitation from this organization. If you intend to resend an invitation to an account,
        /// ensure that existing handshakes that might be considered duplicates are canceled or
        /// declined.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.FinalizingOrganizationException">
        /// AWS Organizations could not perform the operation because your organization has not
        /// finished initializing. This can take up to an hour. Try again later. If after one
        /// hour you continue to receive this error, contact <a href="https://console.aws.amazon.com/support/home#/">
        /// AWS Customer Support</a>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeConstraintViolationException">
        /// The requested operation would violate the constraint identified in the reason code.
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. <b>Note</b>: deleted and closed accounts still count
        /// toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get this exception immediately after creating the organization, wait one hour
        /// and try again. If after an hour it continues to fail with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ALREADY_IN_AN_ORGANIZATION: The handshake request is invalid because the invited account
        /// is already a member of an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_ALREADY_HAS_ALL_FEATURES: The handshake request is invalid because the
        /// organization has already enabled all features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES: You cannot issue new invitations to join
        /// an organization while it is in the process of enabling all features. You can resume
        /// inviting accounts after you finalize the process when all accounts have agreed to
        /// the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PAYMENT_INSTRUMENT_REQUIRED: You cannot complete the operation with an account that
        /// does not have a payment instrument, such as a credit card, associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_FROM_DIFFERENT_SELLER_OF_RECORD: The request failed because the account
        /// is from a different marketplace than the accounts in the organization. For example,
        /// accounts with India addresses must be associated with the AISPL marketplace. All accounts
        /// in an organization must be from the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_MEMBERSHIP_CHANGE_RATE_LIMIT_EXCEEDED: You attempted to change the membership
        /// of an account too quickly after its previous change.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual InviteAccountToOrganizationResponse InviteAccountToOrganization(InviteAccountToOrganizationRequest request)
        {
            var marshaller = InviteAccountToOrganizationRequestMarshaller.Instance;
            var unmarshaller = InviteAccountToOrganizationResponseUnmarshaller.Instance;

            return Invoke<InviteAccountToOrganizationRequest,InviteAccountToOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InviteAccountToOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteAccountToOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/InviteAccountToOrganization">REST API Reference for InviteAccountToOrganization Operation</seealso>
        public virtual Task<InviteAccountToOrganizationResponse> InviteAccountToOrganizationAsync(InviteAccountToOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = InviteAccountToOrganizationRequestMarshaller.Instance;
            var unmarshaller = InviteAccountToOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<InviteAccountToOrganizationRequest,InviteAccountToOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        ///  <important> <ul> <li> 
        /// <para>
        /// The master account in an organization with all features enabled can set service control
        /// policies (SCPs) that can restrict what administrators of member accounts can do, including
        /// preventing them from successfully calling <code>LeaveOrganization</code> and leaving
        /// the organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can leave an organization as a member account only if the account is configured
        /// with the information required to operate as a standalone account. When you create
        /// an account in an organization using the AWS Organizations console, API, or CLI commands,
        /// the information required of standalone accounts is <i>not</i> automatically collected.
        /// For each account that you want to make standalone, you must accept the End User License
        /// Agreement (EULA), choose a support plan, provide and verify the required contact information,
        /// and provide a current payment method. AWS uses the payment method to charge for any
        /// billable (not free tier) AWS activity that occurs while the account is not attached
        /// to an organization. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
        /// To leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can leave an organization only after you enable IAM user access to billing in
        /// your account. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate">Activating
        /// Access to the Billing and Cost Management Console</a> in the <i>AWS Billing and Cost
        /// Management User Guide</i>.
        /// </para>
        ///  </li> </ul> </important>
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual LeaveOrganizationResponse LeaveOrganization(LeaveOrganizationRequest request)
        {
            var marshaller = LeaveOrganizationRequestMarshaller.Instance;
            var unmarshaller = LeaveOrganizationResponseUnmarshaller.Instance;

            return Invoke<LeaveOrganizationRequest,LeaveOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the LeaveOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LeaveOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/LeaveOrganization">REST API Reference for LeaveOrganization Operation</seealso>
        public virtual Task<LeaveOrganizationResponse> LeaveOrganizationAsync(LeaveOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = LeaveOrganizationRequestMarshaller.Instance;
            var unmarshaller = LeaveOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<LeaveOrganizationRequest,LeaveOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAccounts


        /// <summary>
        /// Lists all the accounts in the organization. To request only the accounts in a specified
        /// root or organizational unit (OU), use the <a>ListAccountsForParent</a> operation instead.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            var marshaller = ListAccountsRequestMarshaller.Instance;
            var unmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAccountsRequest,ListAccountsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAccountsRequestMarshaller.Instance;
            var unmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountsRequest,ListAccountsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAccountsForParent


        /// <summary>
        /// Lists the accounts in an organization that are contained by the specified target root
        /// or organizational unit (OU). If you specify the root, you get a list of all the accounts
        /// that are not in any OU. If you specify an OU, you get a list of all the accounts in
        /// only that OU, and not in any child OUs. To get a list of all accounts in the organization,
        /// use the <a>ListAccounts</a> operation.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListAccountsForParentResponse ListAccountsForParent(ListAccountsForParentRequest request)
        {
            var marshaller = ListAccountsForParentRequestMarshaller.Instance;
            var unmarshaller = ListAccountsForParentResponseUnmarshaller.Instance;

            return Invoke<ListAccountsForParentRequest,ListAccountsForParentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountsForParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForParent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccountsForParent">REST API Reference for ListAccountsForParent Operation</seealso>
        public virtual Task<ListAccountsForParentResponse> ListAccountsForParentAsync(ListAccountsForParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAccountsForParentRequestMarshaller.Instance;
            var unmarshaller = ListAccountsForParentResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountsForParentRequest,ListAccountsForParentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAWSServiceAccessForOrganization


        /// <summary>
        /// Returns a list of the AWS services that you enabled to integrate with your organization.
        /// After a service on this list creates the resources that it requires for the integration,
        /// it can perform operations on your organization and its accounts.
        /// 
        ///  
        /// <para>
        /// For more information about integrating other services with AWS Organizations, including
        /// the list of services that currently work with Organizations, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Integrating
        /// AWS Organizations with Other AWS Services</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSServiceAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListAWSServiceAccessForOrganization service method, as returned by Organizations.</returns>
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// AWS Organizations can't complete your request because of an internal service error.
        /// Try again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You've sent too many requests in too short a period of time. The limit helps protect
        /// against denial-of-service attacks. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAWSServiceAccessForOrganization">REST API Reference for ListAWSServiceAccessForOrganization Operation</seealso>
        public virtual ListAWSServiceAccessForOrganizationResponse ListAWSServiceAccessForOrganization(ListAWSServiceAccessForOrganizationRequest request)
        {
            var marshaller = ListAWSServiceAccessForOrganizationRequestMarshaller.Instance;
            var unmarshaller = ListAWSServiceAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListAWSServiceAccessForOrganizationRequest,ListAWSServiceAccessForOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAWSServiceAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAWSServiceAccessForOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAWSServiceAccessForOrganization">REST API Reference for ListAWSServiceAccessForOrganization Operation</seealso>
        public virtual Task<ListAWSServiceAccessForOrganizationResponse> ListAWSServiceAccessForOrganizationAsync(ListAWSServiceAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAWSServiceAccessForOrganizationRequestMarshaller.Instance;
            var unmarshaller = ListAWSServiceAccessForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<ListAWSServiceAccessForOrganizationRequest,ListAWSServiceAccessForOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChildren


        /// <summary>
        /// Lists all of the organizational units (OUs) or accounts that are contained in the
        /// specified parent OU or root. This operation, along with <a>ListParents</a> enables
        /// you to traverse the tree structure that makes up this root.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListChildrenResponse ListChildren(ListChildrenRequest request)
        {
            var marshaller = ListChildrenRequestMarshaller.Instance;
            var unmarshaller = ListChildrenResponseUnmarshaller.Instance;

            return Invoke<ListChildrenRequest,ListChildrenResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChildren operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChildren operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListChildren">REST API Reference for ListChildren Operation</seealso>
        public virtual Task<ListChildrenResponse> ListChildrenAsync(ListChildrenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListChildrenRequestMarshaller.Instance;
            var unmarshaller = ListChildrenResponseUnmarshaller.Instance;

            return InvokeAsync<ListChildrenRequest,ListChildrenResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCreateAccountStatus


        /// <summary>
        /// Lists the account creation requests that match the specified status that is currently
        /// being tracked for the organization.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListCreateAccountStatusResponse ListCreateAccountStatus(ListCreateAccountStatusRequest request)
        {
            var marshaller = ListCreateAccountStatusRequestMarshaller.Instance;
            var unmarshaller = ListCreateAccountStatusResponseUnmarshaller.Instance;

            return Invoke<ListCreateAccountStatusRequest,ListCreateAccountStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCreateAccountStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListCreateAccountStatus">REST API Reference for ListCreateAccountStatus Operation</seealso>
        public virtual Task<ListCreateAccountStatusResponse> ListCreateAccountStatusAsync(ListCreateAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListCreateAccountStatusRequestMarshaller.Instance;
            var unmarshaller = ListCreateAccountStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListCreateAccountStatusRequest,ListCreateAccountStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHandshakesForAccount


        /// <summary>
        /// Lists the current handshakes that are associated with the account of the requesting
        /// user.
        /// 
        ///  
        /// <para>
        /// Handshakes that are ACCEPTED, DECLINED, or CANCELED appear in the results of this
        /// API for only 30 days after changing to that state. After that they are deleted and
        /// no longer accessible.
        /// </para>
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListHandshakesForAccountResponse ListHandshakesForAccount(ListHandshakesForAccountRequest request)
        {
            var marshaller = ListHandshakesForAccountRequestMarshaller.Instance;
            var unmarshaller = ListHandshakesForAccountResponseUnmarshaller.Instance;

            return Invoke<ListHandshakesForAccountRequest,ListHandshakesForAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHandshakesForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForAccount">REST API Reference for ListHandshakesForAccount Operation</seealso>
        public virtual Task<ListHandshakesForAccountResponse> ListHandshakesForAccountAsync(ListHandshakesForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListHandshakesForAccountRequestMarshaller.Instance;
            var unmarshaller = ListHandshakesForAccountResponseUnmarshaller.Instance;

            return InvokeAsync<ListHandshakesForAccountRequest,ListHandshakesForAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// Handshakes that are ACCEPTED, DECLINED, or CANCELED appear in the results of this
        /// API for only 30 days after changing to that state. After that they are deleted and
        /// no longer accessible.
        /// </para>
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListHandshakesForOrganizationResponse ListHandshakesForOrganization(ListHandshakesForOrganizationRequest request)
        {
            var marshaller = ListHandshakesForOrganizationRequestMarshaller.Instance;
            var unmarshaller = ListHandshakesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListHandshakesForOrganizationRequest,ListHandshakesForOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHandshakesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForOrganization">REST API Reference for ListHandshakesForOrganization Operation</seealso>
        public virtual Task<ListHandshakesForOrganizationResponse> ListHandshakesForOrganizationAsync(ListHandshakesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListHandshakesForOrganizationRequestMarshaller.Instance;
            var unmarshaller = ListHandshakesForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<ListHandshakesForOrganizationRequest,ListHandshakesForOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationalUnitsForParent


        /// <summary>
        /// Lists the organizational units (OUs) in a parent organizational unit or root.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListOrganizationalUnitsForParentResponse ListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request)
        {
            var marshaller = ListOrganizationalUnitsForParentRequestMarshaller.Instance;
            var unmarshaller = ListOrganizationalUnitsForParentResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationalUnitsForParentRequest,ListOrganizationalUnitsForParentResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationalUnitsForParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnitsForParent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListOrganizationalUnitsForParent">REST API Reference for ListOrganizationalUnitsForParent Operation</seealso>
        public virtual Task<ListOrganizationalUnitsForParentResponse> ListOrganizationalUnitsForParentAsync(ListOrganizationalUnitsForParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListOrganizationalUnitsForParentRequestMarshaller.Instance;
            var unmarshaller = ListOrganizationalUnitsForParentResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationalUnitsForParentRequest,ListOrganizationalUnitsForParentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListParents


        /// <summary>
        /// Lists the root or organizational units (OUs) that serve as the immediate parent of
        /// the specified child OU or account. This operation, along with <a>ListChildren</a>
        /// enables you to traverse the tree structure that makes up this root.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListParentsResponse ListParents(ListParentsRequest request)
        {
            var marshaller = ListParentsRequestMarshaller.Instance;
            var unmarshaller = ListParentsResponseUnmarshaller.Instance;

            return Invoke<ListParentsRequest,ListParentsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListParents">REST API Reference for ListParents Operation</seealso>
        public virtual Task<ListParentsResponse> ListParentsAsync(ListParentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListParentsRequestMarshaller.Instance;
            var unmarshaller = ListParentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListParentsRequest,ListParentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Retrieves the list of all policies in an organization of a specified type.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPoliciesRequestMarshaller.Instance;
            var unmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesRequest,ListPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPoliciesForTarget


        /// <summary>
        /// Lists the policies that are directly attached to the specified target root, organizational
        /// unit (OU), or account. You must specify the policy type that you want included in
        /// the returned list.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListPoliciesForTargetResponse ListPoliciesForTarget(ListPoliciesForTargetRequest request)
        {
            var marshaller = ListPoliciesForTargetRequestMarshaller.Instance;
            var unmarshaller = ListPoliciesForTargetResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesForTargetRequest,ListPoliciesForTargetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPoliciesForTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesForTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPoliciesForTarget">REST API Reference for ListPoliciesForTarget Operation</seealso>
        public virtual Task<ListPoliciesForTargetResponse> ListPoliciesForTargetAsync(ListPoliciesForTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPoliciesForTargetRequestMarshaller.Instance;
            var unmarshaller = ListPoliciesForTargetResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesForTargetRequest,ListPoliciesForTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRoots


        /// <summary>
        /// Lists the roots that are defined in the current organization.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation can be called only from the organization's master account.
        /// </para>
        ///  <note> 
        /// <para>
        /// Policy types can be enabled and disabled in roots. This is distinct from whether they
        /// are available in the organization. When you enable all features, you make policy types
        /// available for use in that organization. Individual policy types can then be enabled
        /// and disabled in a root. To see the availability of a policy type in an organization,
        /// use <a>DescribeOrganization</a>.
        /// </para>
        ///  </note>
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListRootsResponse ListRoots(ListRootsRequest request)
        {
            var marshaller = ListRootsRequestMarshaller.Instance;
            var unmarshaller = ListRootsResponseUnmarshaller.Instance;

            return Invoke<ListRootsRequest,ListRootsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListRoots">REST API Reference for ListRoots Operation</seealso>
        public virtual Task<ListRootsResponse> ListRootsAsync(ListRootsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRootsRequestMarshaller.Instance;
            var unmarshaller = ListRootsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRootsRequest,ListRootsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTargetsForPolicy


        /// <summary>
        /// Lists all the roots, organizaitonal units (OUs), and accounts to which the specified
        /// policy is attached.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter for a <code>null</code>
        /// value when calling a <code>List*</code> operation. These operations can occasionally
        /// return an empty set of results even when there are more results available. The <code>NextToken</code>
        /// response parameter value is <code>null</code> <i>only</i> when there are no more results
        /// to display.
        /// </para>
        ///  </note> 
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual ListTargetsForPolicyResponse ListTargetsForPolicy(ListTargetsForPolicyRequest request)
        {
            var marshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            var unmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTargetsForPolicyRequest,ListTargetsForPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        public virtual Task<ListTargetsForPolicyResponse> ListTargetsForPolicyAsync(ListTargetsForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            var unmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetsForPolicyRequest,ListTargetsForPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  MoveAccount


        /// <summary>
        /// Moves an account from its current source parent root or organizational unit (OU) to
        /// the specified destination parent root or OU.
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual MoveAccountResponse MoveAccount(MoveAccountRequest request)
        {
            var marshaller = MoveAccountRequestMarshaller.Instance;
            var unmarshaller = MoveAccountResponseUnmarshaller.Instance;

            return Invoke<MoveAccountRequest,MoveAccountResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MoveAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/MoveAccount">REST API Reference for MoveAccount Operation</seealso>
        public virtual Task<MoveAccountResponse> MoveAccountAsync(MoveAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = MoveAccountRequestMarshaller.Instance;
            var unmarshaller = MoveAccountResponseUnmarshaller.Instance;

            return InvokeAsync<MoveAccountRequest,MoveAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// You can remove an account from your organization only if the account is configured
        /// with the information required to operate as a standalone account. When you create
        /// an account in an organization using the AWS Organizations console, API, or CLI commands,
        /// the information required of standalone accounts is <i>not</i> automatically collected.
        /// For an account that you want to make standalone, you must accept the End User License
        /// Agreement (EULA), choose a support plan, provide and verify the required contact information,
        /// and provide a current payment method. AWS uses the payment method to charge for any
        /// billable (not free tier) AWS activity that occurs while the account is not attached
        /// to an organization. To remove an account that does not yet have this information,
        /// you must sign in as the member account and follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
        /// To leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual RemoveAccountFromOrganizationResponse RemoveAccountFromOrganization(RemoveAccountFromOrganizationRequest request)
        {
            var marshaller = RemoveAccountFromOrganizationRequestMarshaller.Instance;
            var unmarshaller = RemoveAccountFromOrganizationResponseUnmarshaller.Instance;

            return Invoke<RemoveAccountFromOrganizationRequest,RemoveAccountFromOrganizationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAccountFromOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAccountFromOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/RemoveAccountFromOrganization">REST API Reference for RemoveAccountFromOrganization Operation</seealso>
        public virtual Task<RemoveAccountFromOrganizationResponse> RemoveAccountFromOrganizationAsync(RemoveAccountFromOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveAccountFromOrganizationRequestMarshaller.Instance;
            var unmarshaller = RemoveAccountFromOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAccountFromOrganizationRequest,RemoveAccountFromOrganizationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual UpdateOrganizationalUnitResponse UpdateOrganizationalUnit(UpdateOrganizationalUnitRequest request)
        {
            var marshaller = UpdateOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = UpdateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationalUnitRequest,UpdateOrganizationalUnitResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdateOrganizationalUnit">REST API Reference for UpdateOrganizationalUnit Operation</seealso>
        public virtual Task<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitAsync(UpdateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateOrganizationalUnitRequestMarshaller.Instance;
            var unmarshaller = UpdateOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOrganizationalUnitRequest,UpdateOrganizationalUnitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// root. This exception includes a reason that contains additional information about
        /// the violated limit:
        /// 
        ///   
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact AWS Support to request
        /// an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or, The number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations, or contact AWS Support
        /// to request an increase in the number of accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: deleted and closed accounts still count toward your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get receive this exception when running a command immediately after creating
        /// the organization, wait one hour and try again. If after an hour it continues to fail
        /// with this error, contact <a href="https://console.aws.amazon.com/support/home#/">AWS
        /// Customer Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes you
        /// can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of organizational units
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an organizational unit tree that
        /// is too many levels deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports consolidated billing features only cannot perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED. You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_EULA: You attempted to remove an account from the organization
        /// that does not yet have enough information to exist as a stand-alone account. This
        /// account requires you to first agree to the AWS Customer Agreement. Follow the steps
        /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that does not yet have enough information to exist as a stand-alone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this account,
        /// you first must associate a payment instrument, such as a credit card, with the account.
        /// Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a payment instrument, such as a credit card, with
        /// the account. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's master account to the marketplace that corresponds
        /// to the master account's address. For example, accounts with India addresses must be
        /// associated with the AISPL marketplace. All accounts in an organization must be associated
        /// with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// contact a valid address and phone number for the master account. Then try the operation
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicatePolicyException">
        /// A policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation:
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by AWS and cannot be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified a value that is not valid for that parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_FULL_NAME_TARGET: You specified a full name that contains invalid characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_LIST_MEMBER: You provided a list to a parameter that contains at least one
        /// invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAGINATION_TOKEN: Get the value for the NextToken parameter from the response
        /// to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN: You provided a value that doesn't match the required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PATTERN_TARGET_ID: You specified a policy target ID that doesn't match the
        /// required pattern.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ROLE_NAME: You provided a role name that is not valid. A role name can’t begin
        /// with the reserved prefix 'AWSServiceRoleFor'.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid ARN for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_FILTER_LIMIT_EXCEEDED: You can specify only one filter parameter for the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_LENGTH_EXCEEDED: You provided a string parameter that is longer than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_VALUE_EXCEEDED: You provided a numeric parameter that has a larger value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_LENGTH_EXCEEDED: You provided a string parameter that is shorter than allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_VALUE_EXCEEDED: You provided a numeric parameter that has a smaller value than
        /// allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MOVING_ACCOUNT_BETWEEN_DIFFERENT_ROOTS: You can move an account only between entities
        /// in the same root.
        /// </para>
        ///  </li> </ul>
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
        public virtual UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            var marshaller = UpdatePolicyRequestMarshaller.Instance;
            var unmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyRequest,UpdatePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public virtual Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdatePolicyRequestMarshaller.Instance;
            var unmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePolicyRequest,UpdatePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}