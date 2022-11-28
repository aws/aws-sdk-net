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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Organizations.Model;
using Amazon.Organizations.Model.Internal.MarshallTransformations;
using Amazon.Organizations.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Organizations
{
    /// <summary>
    /// Implementation for accessing Organizations
    ///
    /// Organizations is a web service that enables you to consolidate your multiple Amazon
    /// Web Services accounts into an <i>organization</i> and centrally manage your accounts
    /// and their resources.
    /// 
    ///  
    /// <para>
    /// This guide provides descriptions of the Organizations operations. For more information
    /// about using this service, see the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">Organizations
    /// User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Support and feedback for Organizations</b> 
    /// </para>
    ///  
    /// <para>
    /// We welcome your feedback. Send your comments to <a href="mailto:feedback-awsorganizations@amazon.com">feedback-awsorganizations@amazon.com</a>
    /// or post your feedback and questions in the <a href="http://forums.aws.amazon.com/forum.jspa?forumID=219">Organizations
    /// support forum</a>. For more information about the Amazon Web Services support forums,
    /// see <a href="http://forums.aws.amazon.com/help.jspa">Forums Help</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoint to call When using the CLI or the Amazon Web Services SDK</b> 
    /// </para>
    ///  
    /// <para>
    /// For the current release of Organizations, specify the <code>us-east-1</code> region
    /// for all Amazon Web Services API and CLI calls made from the commercial Amazon Web
    /// Services Regions outside of China. If calling from one of the Amazon Web Services
    /// Regions in China, then specify <code>cn-northwest-1</code>. You can do this in the
    /// CLI by using these parameters and commands:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the following parameter with each command to specify both the endpoint and its
    /// region:
    /// </para>
    ///  
    /// <para>
    ///  <code>--endpoint-url https://organizations.us-east-1.amazonaws.com</code> <i>(from
    /// commercial Amazon Web Services Regions outside of China)</i> 
    /// </para>
    ///  
    /// <para>
    /// or
    /// </para>
    ///  
    /// <para>
    ///  <code>--endpoint-url https://organizations.cn-northwest-1.amazonaws.com.cn</code>
    /// <i>(from Amazon Web Services Regions in China)</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the default endpoint, but configure your default region with this command:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws configure set default.region us-east-1</code> <i>(from commercial Amazon
    /// Web Services Regions outside of China)</i> 
    /// </para>
    ///  
    /// <para>
    /// or
    /// </para>
    ///  
    /// <para>
    ///  <code>aws configure set default.region cn-northwest-1</code> <i>(from Amazon Web
    /// Services Regions in China)</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the following parameter with each command to specify the endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <code>--region us-east-1</code> <i>(from commercial Amazon Web Services Regions outside
    /// of China)</i> 
    /// </para>
    ///  
    /// <para>
    /// or
    /// </para>
    ///  
    /// <para>
    ///  <code>--region cn-northwest-1</code> <i>(from Amazon Web Services Regions in China)</i>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Organizations supports CloudTrail, a service that records Amazon Web Services API
    /// calls for your Amazon Web Services account and delivers log files to an Amazon S3
    /// bucket. By using information collected by CloudTrail, you can determine which requests
    /// the Organizations service received, who made the request and when, and so on. For
    /// more about Organizations and its support for CloudTrail, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_incident-response.html#orgs_cloudtrail-integration">Logging
    /// Organizations Events with CloudTrail</a> in the <i>Organizations User Guide</i>. To
    /// learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">CloudTrail
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonOrganizationsClient : AmazonServiceClient, IAmazonOrganizations
    {
        private static IServiceMetadata serviceMetadata = new AmazonOrganizationsMetadata();
        
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
#if AWS_ASYNC_ENUMERABLES_API
        private IOrganizationsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOrganizationsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OrganizationsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOrganizationsEndpointResolver());
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


        #region  AcceptHandshake

        internal virtual AcceptHandshakeResponse AcceptHandshake(AcceptHandshakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptHandshakeResponseUnmarshaller.Instance;

            return Invoke<AcceptHandshakeResponse>(request, options);
        }



        /// <summary>
        /// Sends a response to the originator of a handshake agreeing to the action proposed
        /// by the handshake request.
        /// 
        ///  
        /// <para>
        /// You can only call this operation by the following principals when they also have the
        /// relevant IAM permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Invitation to join</b> or <b>Approve all features request</b> handshakes: only
        /// a principal from the member account.
        /// </para>
        ///  
        /// <para>
        /// The user who calls the API for an invitation to join must have the <code>organizations:AcceptHandshake</code>
        /// permission. If you enabled all features in the organization, the user must also have
        /// the <code>iam:CreateServiceLinkedRole</code> permission so that Organizations can
        /// create the required service-linked role named <code>AWSServiceRoleForOrganizations</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integration_services.html#orgs_integration_service-linked-roles">Organizations
        /// and Service-Linked Roles</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Enable all features final confirmation</b> handshake: only a principal from the
        /// management account.
        /// </para>
        ///  
        /// <para>
        /// For more information about invitations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_invites.html">Inviting
        /// an Amazon Web Services account to join your organization</a> in the <i>Organizations
        /// User Guide.</i> For more information about requests to enable all features in the
        /// organization, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// all features in your organization</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you accept a handshake, it continues to appear in the results of relevant APIs
        /// for only 30 days. After that, it's deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedForDependencyException">
        /// The operation that you attempted requires you to have the <code>iam:CreateServiceLinkedRole</code>
        /// for <code>organizations.amazonaws.com</code> permission so that Organizations can
        /// create the required service-linked role. You don't have that permission.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// accounts in an organization. Note that deleted and closed accounts still count toward
        /// your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get this exception immediately after creating the organization, wait one hour
        /// and try again. If after an hour it continues to fail with this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// ALREADY_IN_AN_ORGANIZATION: The handshake request is invalid because the invited account
        /// is already a member of an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES: You can't issue new invitations to join
        /// an organization while it's in the process of enabling all features. You can resume
        /// inviting accounts after you finalize the process when all accounts have agreed to
        /// the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_ALREADY_HAS_ALL_FEATURES: The handshake request is invalid because the
        /// organization has already enabled all features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_IS_ALREADY_PENDING_ALL_FEATURES_MIGRATION: The handshake request is invalid
        /// because the organization has already started the process to enable all features.
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
        ///  </li> <li> 
        /// <para>
        /// PAYMENT_INSTRUMENT_REQUIRED: You can't complete the operation with an account that
        /// doesn't have a payment instrument, such as a credit card, associated with it.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeNotFoundException">
        /// We can't find a handshake with the <code>HandshakeId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidHandshakeTransitionException">
        /// You can't perform the operation on the handshake in its current state. For example,
        /// you can't cancel a handshake that was already accepted or accept a handshake that
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AcceptHandshake">REST API Reference for AcceptHandshake Operation</seealso>
        public virtual Task<AcceptHandshakeResponse> AcceptHandshakeAsync(AcceptHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptHandshakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachPolicy

        internal virtual AttachPolicyResponse AttachPolicy(AttachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachPolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches a policy to a root, an organizational unit (OU), or an individual account.
        /// How the policy affects accounts depends on the type of policy. Refer to the <i>Organizations
        /// User Guide</i> for information about each policy type:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_ai-opt-out.html">AISERVICES_OPT_OUT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_backup.html">BACKUP_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scp.html">SERVICE_CONTROL_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">TAG_POLICY</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachPolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyChangesInProgressException">
        /// Changes to the effective policy are in progress, and its contents can't be returned.
        /// Try the operation again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the <code>PolicyId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotEnabledException">
        /// The specified policy type isn't currently enabled in this root. You can't attach policies
        /// of the specified type to entities in a root until you enable that type in the root.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>Organizations User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, account, or policy with the <code>TargetId</code> that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        public virtual Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AttachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelHandshake

        internal virtual CancelHandshakeResponse CancelHandshake(CancelHandshakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelHandshakeResponseUnmarshaller.Instance;

            return Invoke<CancelHandshakeResponse>(request, options);
        }



        /// <summary>
        /// Cancels a handshake. Canceling a handshake sets the handshake state to <code>CANCELED</code>.
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
        /// for only 30 days. After that, it's deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
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
        /// We can't find a handshake with the <code>HandshakeId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidHandshakeTransitionException">
        /// You can't perform the operation on the handshake in its current state. For example,
        /// you can't cancel a handshake that was already accepted or accept a handshake that
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CancelHandshake">REST API Reference for CancelHandshake Operation</seealso>
        public virtual Task<CancelHandshakeResponse> CancelHandshakeAsync(CancelHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<CancelHandshakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CloseAccount

        internal virtual CloseAccountResponse CloseAccount(CloseAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloseAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseAccountResponseUnmarshaller.Instance;

            return Invoke<CloseAccountResponse>(request, options);
        }



        /// <summary>
        /// Closes an Amazon Web Services member account within an organization. You can't close
        /// the management account with this API. This is an asynchronous request that Amazon
        /// Web Services performs in the background. Because <code>CloseAccount</code> operates
        /// asynchronously, it can return a successful completion message even though account
        /// closure might still be in progress. You need to wait a few minutes before the account
        /// is fully closed. To check the status of the request, do one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>AccountId</code> that you sent in the <code>CloseAccount</code> request
        /// to provide as a parameter to the <a>DescribeAccount</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// While the close account request is in progress, Account status will indicate PENDING_CLOSURE.
        /// When the close account request completes, the status will change to SUSPENDED. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Check the CloudTrail log for the <code>CloseAccountResult</code> event that gets published
        /// after the account closes successfully. For information on using CloudTrail with Organizations,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_security_incident-response.html#orgs_cloudtrail-integration">Logging
        /// and monitoring in Organizations</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// You can only close 10% of active member accounts within a rolling 30 day period. This
        /// quota is not bound by a calendar month, but starts when you close an account. Within
        /// 30 days of that initial account closure, you can't exceed the 10% account closure
        /// limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To reinstate a closed account, contact Amazon Web Services Support within the 90-day
        /// grace period while the account is in SUSPENDED status. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the Amazon Web Services account you attempt to close is linked to an Amazon Web
        /// Services GovCloud (US) account, the <code>CloseAccount</code> request will close both
        /// accounts. To learn important pre-closure details, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/Closing-govcloud-account.html">
        /// Closing an Amazon Web Services GovCloud (US) account</a> in the <i> Amazon Web Services
        /// GovCloud User Guide</i>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about closing accounts, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_close.html">Closing
        /// an Amazon Web Services account</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloseAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountAlreadyClosedException">
        /// You attempted to close an account that is already closed.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConflictException">
        /// The request failed because it conflicts with the current state of the specified resource.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CloseAccount">REST API Reference for CloseAccount Operation</seealso>
        public virtual Task<CloseAccountResponse> CloseAccountAsync(CloseAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CloseAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CloseAccountResponseUnmarshaller.Instance;

            return InvokeAsync<CloseAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccount

        internal virtual CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return Invoke<CreateAccountResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Web Services account that is automatically a member of the organization
        /// whose credentials made the request. This is an asynchronous request that Amazon Web
        /// Services performs in the background. Because <code>CreateAccount</code> operates asynchronously,
        /// it can return a successful completion message even though account initialization might
        /// still be in progress. You might need to wait a few minutes before you can successfully
        /// access the account. To check the status of the request, do one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>Id</code> value of the <code>CreateAccountStatus</code> response element
        /// from this operation to provide as a parameter to the <a>DescribeCreateAccountStatus</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Check the CloudTrail log for the <code>CreateAccountResult</code> event. For information
        /// on using CloudTrail with Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_security_incident-response.html#orgs_cloudtrail-integration">Logging
        /// and monitoring in Organizations</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The user who calls the API to create an account must have the <code>organizations:CreateAccount</code>
        /// permission. If you enabled all features in the organization, Organizations creates
        /// the required service-linked role named <code>AWSServiceRoleForOrganizations</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_integrate_services-using_slrs">Organizations
        /// and Service-Linked Roles</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// Organizations preconfigures the new member account with a role (named <code>OrganizationAccountAccessRole</code>
        /// by default) that grants users in the management account administrator permissions
        /// in the new member account. Principals in the management account can assume the role.
        /// Organizations clones the company name and address information for the new account
        /// from the organization's management account.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating accounts, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_create.html">Creating
        /// an Amazon Web Services account in Your Organization</a> in the <i>Organizations User
        /// Guide.</i> 
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// When you create an account in an organization using the Organizations console, API,
        /// or CLI commands, the information required for the account to operate as a standalone
        /// account, such as a payment method and signing the end user license agreement (EULA)
        /// is <i>not</i> automatically collected. If you must remove an account from your organization
        /// later, you can do so only after you provide the missing information. Follow the steps
        /// at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
        /// To leave an organization as a member account</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you get an exception that indicates that you exceeded your account limits for the
        /// organization, contact <a href="https://console.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you get an exception that indicates that the operation failed because your organization
        /// is still initializing, wait one hour and then try again. If the error persists, contact
        /// <a href="https://console.aws.amazon.com/support/home#/">Amazon Web Services Support</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Using <code>CreateAccount</code> to create multiple temporary accounts isn't recommended.
        /// You can only close an account from the Billing and Cost Management console, and you
        /// must be signed in as the root user. For information on the requirements and process
        /// for closing an account, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_close.html">Closing
        /// an Amazon Web Services account</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul> </important> <note> 
        /// <para>
        /// When you create a member account with this operation, you can choose whether to create
        /// the account with the <b>IAM User and Role Access to Billing Information</b> switch
        /// enabled. If you enable it, IAM users and roles that have appropriate permissions can
        /// view billing information for the account. If you disable it, only the account root
        /// user can access billing information. For information about how to disable this switch
        /// for an account, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html">Granting
        /// Access to Your Billing Information and Tools</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.FinalizingOrganizationException">
        /// Organizations couldn't perform the operation because your organization hasn't finished
        /// initializing. This can take up to an hour. Try again later. If after one hour you
        /// continue to receive this error, contact <a href="https://console.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        public virtual Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGovCloudAccount

        internal virtual CreateGovCloudAccountResponse CreateGovCloudAccount(CreateGovCloudAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGovCloudAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGovCloudAccountResponseUnmarshaller.Instance;

            return Invoke<CreateGovCloudAccountResponse>(request, options);
        }



        /// <summary>
        /// This action is available if all of the following are true:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You're authorized to create accounts in the Amazon Web Services GovCloud (US) Region.
        /// For more information on the Amazon Web Services GovCloud (US) Region, see the <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/welcome.html">
        /// <i>Amazon Web Services GovCloud User Guide</i>.</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You already have an account in the Amazon Web Services GovCloud (US) Region that is
        /// paired with a management account of an organization in the commercial Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You call this action from the management account of your organization in the commercial
        /// Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You have the <code>organizations:CreateGovCloudAccount</code> permission. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Organizations automatically creates the required service-linked role named <code>AWSServiceRoleForOrganizations</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html#orgs_integrate_services-using_slrs">Organizations
        /// and Service-Linked Roles</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services automatically enables CloudTrail for Amazon Web Services GovCloud
        /// (US) accounts, but you should also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Verify that CloudTrail is enabled to store logs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create an Amazon S3 bucket for CloudTrail log storage.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/verifying-cloudtrail.html">Verifying
        /// CloudTrail Is Enabled</a> in the <i>Amazon Web Services GovCloud User Guide</i>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
        /// permission. The tags are attached to the commercial account associated with the GovCloud
        /// account, rather than the GovCloud account itself. To add tags to the GovCloud account,
        /// call the <a>TagResource</a> operation in the GovCloud Region after the new GovCloud
        /// account exists.
        /// </para>
        ///  
        /// <para>
        /// You call this action from the management account of your organization in the commercial
        /// Region to create a standalone Amazon Web Services account in the Amazon Web Services
        /// GovCloud (US) Region. After the account is created, the management account of an organization
        /// in the Amazon Web Services GovCloud (US) Region can invite it to that organization.
        /// For more information on inviting standalone accounts in the Amazon Web Services GovCloud
        /// (US) to join an organization, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Calling <code>CreateGovCloudAccount</code> is an asynchronous request that Amazon
        /// Web Services performs in the background. Because <code>CreateGovCloudAccount</code>
        /// operates asynchronously, it can return a successful completion message even though
        /// account initialization might still be in progress. You might need to wait a few minutes
        /// before you can successfully access the account. To check the status of the request,
        /// do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>OperationId</code> response element from this operation to provide as
        /// a parameter to the <a>DescribeCreateAccountStatus</a> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Check the CloudTrail log for the <code>CreateAccountResult</code> event. For information
        /// on using CloudTrail with Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_monitoring.html">Monitoring
        /// the Activity in Your Organization</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> </ul>  
        /// <para>
        /// When you call the <code>CreateGovCloudAccount</code> action, you create two accounts:
        /// a standalone account in the Amazon Web Services GovCloud (US) Region and an associated
        /// account in the commercial Region for billing and support purposes. The account in
        /// the commercial Region is automatically a member of the organization whose credentials
        /// made the request. Both accounts are associated with the same email address.
        /// </para>
        ///  
        /// <para>
        /// A role is created in the new account in the commercial Region that allows the management
        /// account in the organization in the commercial Region to assume it. An Amazon Web Services
        /// GovCloud (US) account is then created and associated with the commercial account that
        /// you just created. A role is also created in the new Amazon Web Services GovCloud (US)
        /// account that can be assumed by the Amazon Web Services GovCloud (US) account that
        /// is associated with the management account of the commercial organization. For more
        /// information and to view a diagram that explains how account access works, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// For more information about creating accounts, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_create.html">Creating
        /// an Amazon Web Services account in Your Organization</a> in the <i>Organizations User
        /// Guide.</i> 
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// When you create an account in an organization using the Organizations console, API,
        /// or CLI commands, the information required for the account to operate as a standalone
        /// account is <i>not</i> automatically collected. This includes a payment method and
        /// signing the end user license agreement (EULA). If you must remove an account from
        /// your organization later, you can do so only after you provide the missing information.
        /// Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
        /// To leave an organization as a member account</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you get an exception that indicates that you exceeded your account limits for the
        /// organization, contact <a href="https://console.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you get an exception that indicates that the operation failed because your organization
        /// is still initializing, wait one hour and then try again. If the error persists, contact
        /// <a href="https://console.aws.amazon.com/support/home#/">Amazon Web Services Support</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Using <code>CreateGovCloudAccount</code> to create multiple temporary accounts isn't
        /// recommended. You can only close an account from the Amazon Web Services Billing and
        /// Cost Management console, and you must be signed in as the root user. For information
        /// on the requirements and process for closing an account, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_close.html">Closing
        /// an Amazon Web Services account</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul> </important> <note> 
        /// <para>
        /// When you create a member account with this operation, you can choose whether to create
        /// the account with the <b>IAM User and Role Access to Billing Information</b> switch
        /// enabled. If you enable it, IAM users and roles that have appropriate permissions can
        /// view billing information for the account. If you disable it, only the account root
        /// user can access billing information. For information about how to disable this switch
        /// for an account, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html">Granting
        /// Access to Your Billing Information and Tools</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGovCloudAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGovCloudAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.FinalizingOrganizationException">
        /// Organizations couldn't perform the operation because your organization hasn't finished
        /// initializing. This can take up to an hour. Try again later. If after one hour you
        /// continue to receive this error, contact <a href="https://console.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateGovCloudAccount">REST API Reference for CreateGovCloudAccount Operation</seealso>
        public virtual Task<CreateGovCloudAccountResponse> CreateGovCloudAccountAsync(CreateGovCloudAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGovCloudAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGovCloudAccountResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGovCloudAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOrganization

        internal virtual CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Web Services organization. The account whose user is calling the
        /// <code>CreateOrganization</code> operation automatically becomes the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#account">management
        /// account</a> of the new organization.
        /// 
        ///  
        /// <para>
        /// This operation must be called using credentials from the account that is to become
        /// the new organization's management account. The principal must also have the relevant
        /// IAM permissions.
        /// </para>
        ///  
        /// <para>
        /// By default (or if you set the <code>FeatureSet</code> parameter to <code>ALL</code>),
        /// the new organization is created with all features enabled and service control policies
        /// automatically enabled in the root. If you instead choose to create the organization
        /// supporting only the consolidated billing features by setting the <code>FeatureSet</code>
        /// parameter to <code>CONSOLIDATED_BILLING"</code>, no policy types are enabled by default,
        /// and you can't use organization policies
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedForDependencyException">
        /// The operation that you attempted requires you to have the <code>iam:CreateServiceLinkedRole</code>
        /// for <code>organizations.amazonaws.com</code> permission so that Organizations can
        /// create the required service-linked role. You don't have that permission.
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
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        public virtual Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOrganizationalUnit

        internal virtual CreateOrganizationalUnitResponse CreateOrganizationalUnit(CreateOrganizationalUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<CreateOrganizationalUnitResponse>(request, options);
        }



        /// <summary>
        /// Creates an organizational unit (OU) within a root or parent OU. An OU is a container
        /// for accounts that enables you to organize your accounts to apply policies according
        /// to your business requirements. The number of levels deep that you can nest OUs is
        /// dependent upon the policy types enabled for that root. For service control policies,
        /// the limit is five.
        /// 
        ///  
        /// <para>
        /// For more information about OUs, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_ous.html">Managing
        /// Organizational Units</a> in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateOrganizationalUnitException">
        /// An OU with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or OU with the <code>ParentId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganizationalUnit">REST API Reference for CreateOrganizationalUnit Operation</seealso>
        public virtual Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsync(CreateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrganizationalUnitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicy

        internal virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a policy of a specified type that you can attach to a root, an organizational
        /// unit (OU), or an individual Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For more information about policies and their use, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html">Managing
        /// Organization Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MalformedPolicyDocumentException">
        /// The provided policy document doesn't meet the requirements of the specified policy
        /// type. For example, the syntax might be incorrect. For details about service control
        /// policy syntax, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_scp-syntax.html">Service
        /// Control Policy Syntax</a> in the <i>Organizations User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotAvailableForOrganizationException">
        /// You can't use the specified policy type with the feature set currently enabled for
        /// this organization. For example, you can enable SCPs only after you enable all features
        /// in the organization. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html#enable_policies_on_root">Managing
        /// Organizations Policies</a>in the <i>Organizations User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeclineHandshake

        internal virtual DeclineHandshakeResponse DeclineHandshake(DeclineHandshakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineHandshakeResponseUnmarshaller.Instance;

            return Invoke<DeclineHandshakeResponse>(request, options);
        }



        /// <summary>
        /// Declines a handshake request. This sets the handshake state to <code>DECLINED</code>
        /// and effectively deactivates the request.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the account that received the handshake. The
        /// originator of the handshake can use <a>CancelHandshake</a> instead. The originator
        /// can't reactivate a declined request, but can reinitiate the process with a new handshake
        /// request.
        /// </para>
        ///  
        /// <para>
        /// After you decline a handshake, it continues to appear in the results of relevant APIs
        /// for only 30 days. After that, it's deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeclineHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
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
        /// We can't find a handshake with the <code>HandshakeId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidHandshakeTransitionException">
        /// You can't perform the operation on the handshake in its current state. For example,
        /// you can't cancel a handshake that was already accepted or accept a handshake that
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeclineHandshake">REST API Reference for DeclineHandshake Operation</seealso>
        public virtual Task<DeclineHandshakeResponse> DeclineHandshakeAsync(DeclineHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeclineHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeclineHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<DeclineHandshakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOrganization

        internal virtual DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the organization. You can delete an organization only by using credentials
        /// from the management account. The organization must be empty of member accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationNotEmptyException">
        /// The organization isn't empty. To delete an organization, you must first remove all
        /// accounts except the management account, delete all OUs, and delete all policies.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        public virtual Task<DeleteOrganizationResponse> DeleteOrganizationAsync(DeleteOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOrganizationalUnit

        internal virtual DeleteOrganizationalUnitResponse DeleteOrganizationalUnit(DeleteOrganizationalUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationalUnitResponse>(request, options);
        }



        /// <summary>
        /// Deletes an organizational unit (OU) from a root or another OU. You must first remove
        /// all accounts and child OUs from the OU that you want to delete.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotEmptyException">
        /// The specified OU is not empty. Move all accounts to another root or to other OUs,
        /// remove all child OUs, and try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotFoundException">
        /// We can't find an OU with the <code>OrganizationalUnitId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganizationalUnit">REST API Reference for DeleteOrganizationalUnit Operation</seealso>
        public virtual Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsync(DeleteOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOrganizationalUnitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified policy from your organization. Before you perform this operation,
        /// you must first detach the policy from all organizational units (OUs), roots, and accounts.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyInUseException">
        /// The policy is attached to one or more entities. You must detach it from all roots,
        /// OUs, and accounts before performing this operation.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the <code>PolicyId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the resource policy from your organization.
        /// 
        ///  
        /// <para>
        /// You can only call this operation from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ResourcePolicyNotFoundException">
        /// We can't find a resource policy request with the parameter that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterDelegatedAdministrator

        internal virtual DeregisterDelegatedAdministratorResponse DeregisterDelegatedAdministrator(DeregisterDelegatedAdministratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDelegatedAdministratorResponseUnmarshaller.Instance;

            return Invoke<DeregisterDelegatedAdministratorResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified member Amazon Web Services account as a delegated administrator
        /// for the specified Amazon Web Services service.
        /// 
        ///  <important> 
        /// <para>
        /// Deregistering a delegated administrator can have unintended impacts on the functionality
        /// of the enabled Amazon Web Services service. See the documentation for the enabled
        /// service before you deregister a delegated administrator so that you understand any
        /// potential impacts.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can run this action only for Amazon Web Services services that support this feature.
        /// For a current list of services that support it, see the column <i>Supports Delegated
        /// Administrator</i> in the table at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services_list.html">Amazon
        /// Web Services Services that you can use with Organizations</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDelegatedAdministrator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterDelegatedAdministrator service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotRegisteredException">
        /// The specified account is not a delegated administrator for this Amazon Web Services
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeregisterDelegatedAdministrator">REST API Reference for DeregisterDelegatedAdministrator Operation</seealso>
        public virtual Task<DeregisterDelegatedAdministratorResponse> DeregisterDelegatedAdministratorAsync(DeregisterDelegatedAdministratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDelegatedAdministratorResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterDelegatedAdministratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccount

        internal virtual DescribeAccountResponse DescribeAccount(DescribeAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountResponse>(request, options);
        }



        /// <summary>
        /// Retrieves Organizations-related information about the specified account.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual Task<DescribeAccountResponse> DescribeAccountAsync(DescribeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCreateAccountStatus

        internal virtual DescribeCreateAccountStatusResponse DescribeCreateAccountStatus(DescribeCreateAccountStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCreateAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCreateAccountStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeCreateAccountStatusResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current status of an asynchronous request to create an account.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCreateAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCreateAccountStatus service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.CreateAccountStatusNotFoundException">
        /// We can't find an create account request with the <code>CreateAccountRequestId</code>
        /// that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeCreateAccountStatus">REST API Reference for DescribeCreateAccountStatus Operation</seealso>
        public virtual Task<DescribeCreateAccountStatusResponse> DescribeCreateAccountStatusAsync(DescribeCreateAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCreateAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCreateAccountStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCreateAccountStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEffectivePolicy

        internal virtual DescribeEffectivePolicyResponse DescribeEffectivePolicy(DescribeEffectivePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectivePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectivePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeEffectivePolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the contents of the effective policy for specified policy type and account.
        /// The effective policy is the aggregation of any policies of the specified type that
        /// the account inherits, plus any policy of that type that is directly attached to the
        /// account.
        /// 
        ///  
        /// <para>
        /// This operation applies only to policy types <i>other</i> than service control policies
        /// (SCPs).
        /// </para>
        ///  
        /// <para>
        /// For more information about policy inheritance, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies-inheritance.html">How
        /// Policy Inheritance Works</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEffectivePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEffectivePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.EffectivePolicyNotFoundException">
        /// If you ran this action on the management account, this policy type is not enabled.
        /// If you ran the action on a member account, the account doesn't have an effective policy
        /// of this type. Contact the administrator of your organization about attaching a policy
        /// of this type to the account.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, account, or policy with the <code>TargetId</code> that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeEffectivePolicy">REST API Reference for DescribeEffectivePolicy Operation</seealso>
        public virtual Task<DescribeEffectivePolicyResponse> DescribeEffectivePolicyAsync(DescribeEffectivePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEffectivePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEffectivePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEffectivePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHandshake

        internal virtual DescribeHandshakeResponse DescribeHandshake(DescribeHandshakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHandshakeResponseUnmarshaller.Instance;

            return Invoke<DescribeHandshakeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a previously requested handshake. The handshake ID comes
        /// from the response to the original <a>InviteAccountToOrganization</a> operation that
        /// generated the handshake.
        /// 
        ///  
        /// <para>
        /// You can access handshakes that are <code>ACCEPTED</code>, <code>DECLINED</code>, or
        /// <code>CANCELED</code> for only 30 days after they change to that state. They're then
        /// deleted and no longer accessible.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called from any account in the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHandshake service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.HandshakeNotFoundException">
        /// We can't find a handshake with the <code>HandshakeId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeHandshake">REST API Reference for DescribeHandshake Operation</seealso>
        public virtual Task<DescribeHandshakeResponse> DescribeHandshakeAsync(DescribeHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHandshakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHandshakeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHandshakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganization

        internal virtual DescribeOrganizationResponse DescribeOrganization(DescribeOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the organization that the user's account belongs to.
        /// 
        ///  
        /// <para>
        /// This operation can be called from any account in the organization.
        /// </para>
        ///  <note> 
        /// <para>
        /// Even if a policy type is shown as available in the organization, you can disable it
        /// separately at the root level with <a>DisablePolicyType</a>. Use <a>ListRoots</a> to
        /// see the status of policy types for a specified root.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        public virtual Task<DescribeOrganizationResponse> DescribeOrganizationAsync(DescribeOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrganizationalUnit

        internal virtual DescribeOrganizationalUnitResponse DescribeOrganizationalUnit(DescribeOrganizationalUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationalUnitResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an organizational unit (OU).
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotFoundException">
        /// We can't find an OU with the <code>OrganizationalUnitId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganizationalUnit">REST API Reference for DescribeOrganizationalUnit Operation</seealso>
        public virtual Task<DescribeOrganizationalUnitResponse> DescribeOrganizationalUnitAsync(DescribeOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrganizationalUnitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePolicy

        internal virtual DescribePolicyResponse DescribePolicy(DescribePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribePolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a policy.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the <code>PolicyId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribePolicy">REST API Reference for DescribePolicy Operation</seealso>
        public virtual Task<DescribePolicyResponse> DescribePolicyAsync(DescribePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourcePolicy

        internal virtual DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a resource policy.
        /// 
        ///  
        /// <para>
        /// You can only call this operation from the organization's management account or by
        /// a member account that is a delegated administrator for an AWS service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourcePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ResourcePolicyNotFoundException">
        /// We can't find a resource policy request with the parameter that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual Task<DescribeResourcePolicyResponse> DescribeResourcePolicyAsync(DescribeResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachPolicy

        internal virtual DetachPolicyResponse DetachPolicy(DetachPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachPolicyResponse>(request, options);
        }



        /// <summary>
        /// Detaches a policy from a target root, organizational unit (OU), or account.
        /// 
        ///  <important> 
        /// <para>
        /// If the policy being detached is a service control policy (SCP), the changes to permissions
        /// for Identity and Access Management (IAM) users and roles in affected accounts are
        /// immediate.
        /// </para>
        ///  </important> 
        /// <para>
        /// Every root, OU, and account must have at least one SCP attached. If you want to replace
        /// the default <code>FullAWSAccess</code> policy with an SCP that limits the permissions
        /// that can be delegated, you must attach the replacement SCP before you can remove the
        /// default SCP. This is the authorization strategy of an "<a href="https://docs.aws.amazon.com/organizations/latest/userguide/SCP_strategies.html#orgs_policies_allowlist">allow
        /// list</a>". If you instead attach a second SCP and leave the <code>FullAWSAccess</code>
        /// SCP still attached, and specify <code>"Effect": "Deny"</code> in the second SCP to
        /// override the <code>"Effect": "Allow"</code> in the <code>FullAWSAccess</code> policy
        /// (or any other attached SCP), you're using the authorization strategy of a "<a href="https://docs.aws.amazon.com/organizations/latest/userguide/SCP_strategies.html#orgs_policies_denylist">deny
        /// list</a>".
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachPolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyChangesInProgressException">
        /// Changes to the effective policy are in progress, and its contents can't be returned.
        /// Try the operation again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotAttachedException">
        /// The policy isn't attached to the specified target in the specified root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the <code>PolicyId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, account, or policy with the <code>TargetId</code> that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        public virtual Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DetachPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableAWSServiceAccess

        internal virtual DisableAWSServiceAccessResponse DisableAWSServiceAccess(DisableAWSServiceAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSServiceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSServiceAccessResponseUnmarshaller.Instance;

            return Invoke<DisableAWSServiceAccessResponse>(request, options);
        }



        /// <summary>
        /// Disables the integration of an Amazon Web Services service (the service that is specified
        /// by <code>ServicePrincipal</code>) with Organizations. When you disable integration,
        /// the specified service no longer can create a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
        /// role</a> in <i>new</i> accounts in your organization. This means the service can't
        /// perform operations on your behalf on any new accounts in your organization. The service
        /// can still perform operations in older accounts until the service completes its clean-up
        /// from Organizations.
        /// 
        ///  <important> 
        /// <para>
        /// We <b> <i>strongly recommend</i> </b> that you don't use this command to disable integration
        /// between Organizations and the specified Amazon Web Services service. Instead, use
        /// the console or commands that are provided by the specified service. This lets the
        /// trusted service perform any required initialization when enabling trusted access,
        /// such as creating any required resources and any required clean up of resources when
        /// disabling trusted access. 
        /// </para>
        ///  
        /// <para>
        /// For information about how to disable trusted service access to your organization using
        /// the trusted service, see the <b>Learn more</b> link under the <b>Supports Trusted
        /// Access</b> column at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services_list.html">Amazon
        /// Web Services services that you can use with Organizations</a>. on this page.
        /// </para>
        ///  
        /// <para>
        /// If you disable access by using this command, it causes the following actions to occur:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The service can no longer create a service-linked role in the accounts in your organization.
        /// This means that the service can't perform operations on your behalf on any new accounts
        /// in your organization. The service can still perform operations in older accounts until
        /// the service completes its clean-up from Organizations. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The service can no longer perform tasks in the member accounts in the organization,
        /// unless those operations are explicitly permitted by the IAM policies that are attached
        /// to your roles. This includes any data aggregation from the member accounts to the
        /// management account, or to a delegated administrator account, where relevant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Some services detect this and clean up any remaining data or resources related to
        /// the integration, while other services stop accessing the organization but leave any
        /// historical data and configuration in place to support a possible re-enabling of the
        /// integration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Using the other service's console or commands to disable the integration ensures that
        /// the other service is aware that it can clean up any resources that are required only
        /// for the integration. How the service cleans up its resources in the organization's
        /// accounts depends on that service. For more information, see the documentation for
        /// the other Amazon Web Services service. 
        /// </para>
        ///  </important> 
        /// <para>
        /// After you perform the <code>DisableAWSServiceAccess</code> operation, the specified
        /// service can no longer perform operations in your organization's accounts 
        /// </para>
        ///  
        /// <para>
        /// For more information about integrating other services with Organizations, including
        /// the list of services that work with Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Integrating
        /// Organizations with Other Amazon Web Services Services</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSServiceAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableAWSServiceAccess service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisableAWSServiceAccess">REST API Reference for DisableAWSServiceAccess Operation</seealso>
        public virtual Task<DisableAWSServiceAccessResponse> DisableAWSServiceAccessAsync(DisableAWSServiceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAWSServiceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAWSServiceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAWSServiceAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisablePolicyType

        internal virtual DisablePolicyTypeResponse DisablePolicyType(DisablePolicyTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisablePolicyTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisablePolicyTypeResponseUnmarshaller.Instance;

            return Invoke<DisablePolicyTypeResponse>(request, options);
        }



        /// <summary>
        /// Disables an organizational policy type in a root. A policy of a certain type can be
        /// attached to entities in a root only if that type is enabled in the root. After you
        /// perform this operation, you no longer can attach policies of the specified type to
        /// that root or to any organizational unit (OU) or account in that root. You can undo
        /// this by using the <a>EnablePolicyType</a> operation.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous request that Amazon Web Services performs in the background.
        /// If you disable a policy type for a root, it still appears enabled for the organization
        /// if <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">all
        /// features</a> are enabled for the organization. Amazon Web Services recommends that
        /// you first use <a>ListRoots</a> to see the status of policy types for a specified root,
        /// and then use this operation.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        ///  
        /// <para>
        ///  To view the status of available policy types in the organization, use <a>DescribeOrganization</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisablePolicyType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisablePolicyType service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyChangesInProgressException">
        /// Changes to the effective policy are in progress, and its contents can't be returned.
        /// Try the operation again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotEnabledException">
        /// The specified policy type isn't currently enabled in this root. You can't attach policies
        /// of the specified type to entities in a root until you enable that type in the root.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>Organizations User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.RootNotFoundException">
        /// We can't find a root with the <code>RootId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisablePolicyType">REST API Reference for DisablePolicyType Operation</seealso>
        public virtual Task<DisablePolicyTypeResponse> DisablePolicyTypeAsync(DisablePolicyTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisablePolicyTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisablePolicyTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DisablePolicyTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableAllFeatures

        internal virtual EnableAllFeaturesResponse EnableAllFeatures(EnableAllFeaturesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAllFeaturesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAllFeaturesResponseUnmarshaller.Instance;

            return Invoke<EnableAllFeaturesResponse>(request, options);
        }



        /// <summary>
        /// Enables all features in an organization. This enables the use of organization policies
        /// that can restrict the services and actions that can be called in each account. Until
        /// you enable all features, you have access only to consolidated billing, and you can't
        /// use any of the advanced account administration features that Organizations supports.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
        /// All Features in Your Organization</a> in the <i>Organizations User Guide.</i> 
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
        /// After you enable all features in your organization, the management account in the
        /// organization can apply policies on all member accounts. These policies can restrict
        /// what users and even administrators in those accounts can do. The management account
        /// can apply policies that prevent accounts from leaving the organization. Ensure that
        /// your account administrators are aware of this.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAllFeatures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableAllFeatures service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// accounts in an organization. Note that deleted and closed accounts still count toward
        /// your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get this exception immediately after creating the organization, wait one hour
        /// and try again. If after an hour it continues to fail with this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// ALREADY_IN_AN_ORGANIZATION: The handshake request is invalid because the invited account
        /// is already a member of an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES: You can't issue new invitations to join
        /// an organization while it's in the process of enabling all features. You can resume
        /// inviting accounts after you finalize the process when all accounts have agreed to
        /// the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_ALREADY_HAS_ALL_FEATURES: The handshake request is invalid because the
        /// organization has already enabled all features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_IS_ALREADY_PENDING_ALL_FEATURES_MIGRATION: The handshake request is invalid
        /// because the organization has already started the process to enable all features.
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
        ///  </li> <li> 
        /// <para>
        /// PAYMENT_INSTRUMENT_REQUIRED: You can't complete the operation with an account that
        /// doesn't have a payment instrument, such as a credit card, associated with it.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAllFeatures">REST API Reference for EnableAllFeatures Operation</seealso>
        public virtual Task<EnableAllFeaturesResponse> EnableAllFeaturesAsync(EnableAllFeaturesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAllFeaturesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAllFeaturesResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAllFeaturesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableAWSServiceAccess

        internal virtual EnableAWSServiceAccessResponse EnableAWSServiceAccess(EnableAWSServiceAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAWSServiceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAWSServiceAccessResponseUnmarshaller.Instance;

            return Invoke<EnableAWSServiceAccessResponse>(request, options);
        }



        /// <summary>
        /// Enables the integration of an Amazon Web Services service (the service that is specified
        /// by <code>ServicePrincipal</code>) with Organizations. When you enable integration,
        /// you allow the specified service to create a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
        /// role</a> in all the accounts in your organization. This allows the service to perform
        /// operations on your behalf in your organization and its accounts.
        /// 
        ///  <important> 
        /// <para>
        /// We recommend that you enable integration between Organizations and the specified Amazon
        /// Web Services service by using the console or commands that are provided by the specified
        /// service. Doing so ensures that the service is aware that it can create the resources
        /// that are required for the integration. How the service creates those resources in
        /// the organization's accounts depends on that service. For more information, see the
        /// documentation for the other Amazon Web Services service.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about enabling services to integrate with Organizations, see
        /// <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Integrating
        /// Organizations with Other Amazon Web Services Services</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// You can only call this operation from the organization's management account and only
        /// if the organization has <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">enabled
        /// all features</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSServiceAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableAWSServiceAccess service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAWSServiceAccess">REST API Reference for EnableAWSServiceAccess Operation</seealso>
        public virtual Task<EnableAWSServiceAccessResponse> EnableAWSServiceAccessAsync(EnableAWSServiceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAWSServiceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAWSServiceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAWSServiceAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnablePolicyType

        internal virtual EnablePolicyTypeResponse EnablePolicyType(EnablePolicyTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnablePolicyTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnablePolicyTypeResponseUnmarshaller.Instance;

            return Invoke<EnablePolicyTypeResponse>(request, options);
        }



        /// <summary>
        /// Enables a policy type in a root. After you enable a policy type in a root, you can
        /// attach policies of that type to the root, any organizational unit (OU), or account
        /// in that root. You can undo this by using the <a>DisablePolicyType</a> operation.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous request that Amazon Web Services performs in the background.
        /// Amazon Web Services recommends that you first use <a>ListRoots</a> to see the status
        /// of policy types for a specified root, and then use this operation.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        ///  
        /// <para>
        /// You can enable a policy type in a root only if that policy type is available in the
        /// organization. To view the status of available policy types in the organization, use
        /// <a>DescribeOrganization</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnablePolicyType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnablePolicyType service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyChangesInProgressException">
        /// Changes to the effective policy are in progress, and its contents can't be returned.
        /// Try the operation again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeAlreadyEnabledException">
        /// The specified policy type is already enabled in the specified root.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyTypeNotAvailableForOrganizationException">
        /// You can't use the specified policy type with the feature set currently enabled for
        /// this organization. For example, you can enable SCPs only after you enable all features
        /// in the organization. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies.html#enable_policies_on_root">Managing
        /// Organizations Policies</a>in the <i>Organizations User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.RootNotFoundException">
        /// We can't find a root with the <code>RootId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnablePolicyType">REST API Reference for EnablePolicyType Operation</seealso>
        public virtual Task<EnablePolicyTypeResponse> EnablePolicyTypeAsync(EnablePolicyTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnablePolicyTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnablePolicyTypeResponseUnmarshaller.Instance;

            return InvokeAsync<EnablePolicyTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InviteAccountToOrganization

        internal virtual InviteAccountToOrganizationResponse InviteAccountToOrganization(InviteAccountToOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteAccountToOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteAccountToOrganizationResponseUnmarshaller.Instance;

            return Invoke<InviteAccountToOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Sends an invitation to another account to join your organization as a member account.
        /// Organizations sends email on your behalf to the email address that is associated with
        /// the other account's owner. The invitation is implemented as a <a>Handshake</a> whose
        /// details are in the response.
        /// 
        ///  <important> <ul> <li> 
        /// <para>
        /// You can invite Amazon Web Services accounts only from the same seller as the management
        /// account. For example, if your organization's management account was created by Amazon
        /// Internet Services Pvt. Ltd (AISPL), an Amazon Web Services seller in India, you can
        /// invite only other AISPL accounts to your organization. You can't combine accounts
        /// from AISPL and Amazon Web Services or from any other Amazon Web Services seller. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/useconsolidatedbilliing-India.html">Consolidated
        /// Billing in India</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you receive an exception that indicates that you exceeded your account limits for
        /// the organization or that the operation failed because your organization is still initializing,
        /// wait one hour and then try again. If the error persists after an hour, contact <a
        /// href="https://console.aws.amazon.com/support/home#/">Amazon Web Services Support</a>.
        /// </para>
        ///  </li> </ul> </important> 
        /// <para>
        /// If the request includes tags, then the requester must have the <code>organizations:TagResource</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteAccountToOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InviteAccountToOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountOwnerNotVerifiedException">
        /// You can't invite an existing account to your organization until you verify that you
        /// own the email address associated with the management account. For more information,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_create.html#about-email-verification">Email
        /// Address Verification</a> in the <i>Organizations User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateHandshakeException">
        /// A handshake with the same action and target already exists. For example, if you invited
        /// an account to join your organization, the invited account might already have a pending
        /// invitation from this organization. If you intend to resend an invitation to an account,
        /// ensure that existing handshakes that might be considered duplicates are canceled or
        /// declined.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.FinalizingOrganizationException">
        /// Organizations couldn't perform the operation because your organization hasn't finished
        /// initializing. This can take up to an hour. Try again later. If after one hour you
        /// continue to receive this error, contact <a href="https://console.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
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
        /// accounts in an organization. Note that deleted and closed accounts still count toward
        /// your limit.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you get this exception immediately after creating the organization, wait one hour
        /// and try again. If after an hour it continues to fail with this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// ALREADY_IN_AN_ORGANIZATION: The handshake request is invalid because the invited account
        /// is already a member of an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVITE_DISABLED_DURING_ENABLE_ALL_FEATURES: You can't issue new invitations to join
        /// an organization while it's in the process of enabling all features. You can resume
        /// inviting accounts after you finalize the process when all accounts have agreed to
        /// the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_ALREADY_HAS_ALL_FEATURES: The handshake request is invalid because the
        /// organization has already enabled all features.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_IS_ALREADY_PENDING_ALL_FEATURES_MIGRATION: The handshake request is invalid
        /// because the organization has already started the process to enable all features.
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
        ///  </li> <li> 
        /// <para>
        /// PAYMENT_INSTRUMENT_REQUIRED: You can't complete the operation with an account that
        /// doesn't have a payment instrument, such as a credit card, associated with it.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/InviteAccountToOrganization">REST API Reference for InviteAccountToOrganization Operation</seealso>
        public virtual Task<InviteAccountToOrganizationResponse> InviteAccountToOrganizationAsync(InviteAccountToOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InviteAccountToOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InviteAccountToOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<InviteAccountToOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  LeaveOrganization

        internal virtual LeaveOrganizationResponse LeaveOrganization(LeaveOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LeaveOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LeaveOrganizationResponseUnmarshaller.Instance;

            return Invoke<LeaveOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Removes a member account from its parent organization. This version of the operation
        /// is performed by the account that wants to leave. To remove a member account as a user
        /// in the management account, use <a>RemoveAccountFromOrganization</a> instead.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from a member account in the organization.
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// The management account in an organization with all features enabled can set service
        /// control policies (SCPs) that can restrict what administrators of member accounts can
        /// do. This includes preventing them from successfully calling <code>LeaveOrganization</code>
        /// and leaving the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can leave an organization as a member account only if the account is configured
        /// with the information required to operate as a standalone account. When you create
        /// an account in an organization using the Organizations console, API, or CLI commands,
        /// the information required of standalone accounts is <i>not</i> automatically collected.
        /// For each account that you want to make standalone, you must perform the following
        /// steps. If any of the steps are already completed for this account, that step doesn't
        /// appear.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Choose a support plan
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide and verify the required contact information
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide a current payment method
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services uses the payment method to charge for any billable (not free tier)
        /// Amazon Web Services activity that occurs while the account isn't attached to an organization.
        /// Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
        /// To leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The account that you want to leave must not be a delegated administrator account for
        /// any Amazon Web Services service enabled for your organization. If the account is a
        /// delegated administrator, you must first change the delegated administrator account
        /// to another account that is remaining in the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can leave an organization only after you enable IAM user access to billing in
        /// your account. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate">Activating
        /// Access to the Billing and Cost Management Console</a> in the <i>Amazon Web Services
        /// Billing and Cost Management User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After the account leaves the organization, all tags that were attached to the account
        /// object in the organization are deleted. Amazon Web Services accounts outside of an
        /// organization do not support tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A newly created account has a waiting period before it can be removed from its organization.
        /// If you get an error that indicates that a wait period is required, then try again
        /// in a few days.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LeaveOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LeaveOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MasterCannotLeaveOrganizationException">
        /// You can't remove a management account from an organization. If you want the management
        /// account to become a member account in another organization, you must first delete
        /// the current organization of the management account.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/LeaveOrganization">REST API Reference for LeaveOrganization Operation</seealso>
        public virtual Task<LeaveOrganizationResponse> LeaveOrganizationAsync(LeaveOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LeaveOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LeaveOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<LeaveOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccounts

        internal virtual ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return Invoke<ListAccountsResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        public virtual Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccountsForParent

        internal virtual ListAccountsForParentResponse ListAccountsForParent(ListAccountsForParentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsForParentResponseUnmarshaller.Instance;

            return Invoke<ListAccountsForParentResponse>(request, options);
        }



        /// <summary>
        /// Lists the accounts in an organization that are contained by the specified target root
        /// or organizational unit (OU). If you specify the root, you get a list of all the accounts
        /// that aren't in any OU. If you specify an OU, you get a list of all the accounts in
        /// only that OU and not in any child OUs. To get a list of all accounts in the organization,
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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForParent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountsForParent service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or OU with the <code>ParentId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccountsForParent">REST API Reference for ListAccountsForParent Operation</seealso>
        public virtual Task<ListAccountsForParentResponse> ListAccountsForParentAsync(ListAccountsForParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccountsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsForParentResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccountsForParentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAWSServiceAccessForOrganization

        internal virtual ListAWSServiceAccessForOrganizationResponse ListAWSServiceAccessForOrganization(ListAWSServiceAccessForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAWSServiceAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAWSServiceAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListAWSServiceAccessForOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the Amazon Web Services services that you enabled to integrate with
        /// your organization. After a service on this list creates the resources that it requires
        /// for the integration, it can perform operations on your organization and its accounts.
        /// 
        ///  
        /// <para>
        /// For more information about integrating other services with Organizations, including
        /// the list of services that currently work with Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services.html">Integrating
        /// Organizations with Other Amazon Web Services Services</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAWSServiceAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAWSServiceAccessForOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAWSServiceAccessForOrganization">REST API Reference for ListAWSServiceAccessForOrganization Operation</seealso>
        public virtual Task<ListAWSServiceAccessForOrganizationResponse> ListAWSServiceAccessForOrganizationAsync(ListAWSServiceAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAWSServiceAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAWSServiceAccessForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<ListAWSServiceAccessForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChildren

        internal virtual ListChildrenResponse ListChildren(ListChildrenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChildrenResponseUnmarshaller.Instance;

            return Invoke<ListChildrenResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChildren service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChildren service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or OU with the <code>ParentId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListChildren">REST API Reference for ListChildren Operation</seealso>
        public virtual Task<ListChildrenResponse> ListChildrenAsync(ListChildrenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChildrenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChildrenResponseUnmarshaller.Instance;

            return InvokeAsync<ListChildrenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCreateAccountStatus

        internal virtual ListCreateAccountStatusResponse ListCreateAccountStatus(ListCreateAccountStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCreateAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCreateAccountStatusResponseUnmarshaller.Instance;

            return Invoke<ListCreateAccountStatusResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCreateAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCreateAccountStatus service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListCreateAccountStatus">REST API Reference for ListCreateAccountStatus Operation</seealso>
        public virtual Task<ListCreateAccountStatusResponse> ListCreateAccountStatusAsync(ListCreateAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCreateAccountStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCreateAccountStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListCreateAccountStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDelegatedAdministrators

        internal virtual ListDelegatedAdministratorsResponse ListDelegatedAdministrators(ListDelegatedAdministratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDelegatedAdministratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDelegatedAdministratorsResponseUnmarshaller.Instance;

            return Invoke<ListDelegatedAdministratorsResponse>(request, options);
        }



        /// <summary>
        /// Lists the Amazon Web Services accounts that are designated as delegated administrators
        /// in this organization.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedAdministrators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDelegatedAdministrators service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListDelegatedAdministrators">REST API Reference for ListDelegatedAdministrators Operation</seealso>
        public virtual Task<ListDelegatedAdministratorsResponse> ListDelegatedAdministratorsAsync(ListDelegatedAdministratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDelegatedAdministratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDelegatedAdministratorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDelegatedAdministratorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDelegatedServicesForAccount

        internal virtual ListDelegatedServicesForAccountResponse ListDelegatedServicesForAccount(ListDelegatedServicesForAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDelegatedServicesForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDelegatedServicesForAccountResponseUnmarshaller.Instance;

            return Invoke<ListDelegatedServicesForAccountResponse>(request, options);
        }



        /// <summary>
        /// List the Amazon Web Services services for which the specified account is a delegated
        /// administrator.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDelegatedServicesForAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDelegatedServicesForAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotRegisteredException">
        /// The specified account is not a delegated administrator for this Amazon Web Services
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListDelegatedServicesForAccount">REST API Reference for ListDelegatedServicesForAccount Operation</seealso>
        public virtual Task<ListDelegatedServicesForAccountResponse> ListDelegatedServicesForAccountAsync(ListDelegatedServicesForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDelegatedServicesForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDelegatedServicesForAccountResponseUnmarshaller.Instance;

            return InvokeAsync<ListDelegatedServicesForAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHandshakesForAccount

        internal virtual ListHandshakesForAccountResponse ListHandshakesForAccount(ListHandshakesForAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHandshakesForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHandshakesForAccountResponseUnmarshaller.Instance;

            return Invoke<ListHandshakesForAccountResponse>(request, options);
        }



        /// <summary>
        /// Lists the current handshakes that are associated with the account of the requesting
        /// user.
        /// 
        ///  
        /// <para>
        /// Handshakes that are <code>ACCEPTED</code>, <code>DECLINED</code>, <code>CANCELED</code>,
        /// or <code>EXPIRED</code> appear in the results of this API for only 30 days after changing
        /// to that state. After that, they're deleted and no longer accessible.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHandshakesForAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForAccount">REST API Reference for ListHandshakesForAccount Operation</seealso>
        public virtual Task<ListHandshakesForAccountResponse> ListHandshakesForAccountAsync(ListHandshakesForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHandshakesForAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHandshakesForAccountResponseUnmarshaller.Instance;

            return InvokeAsync<ListHandshakesForAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHandshakesForOrganization

        internal virtual ListHandshakesForOrganizationResponse ListHandshakesForOrganization(ListHandshakesForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHandshakesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHandshakesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListHandshakesForOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Lists the handshakes that are associated with the organization that the requesting
        /// user is part of. The <code>ListHandshakesForOrganization</code> operation returns
        /// a list of handshake structures. Each structure contains details and status about a
        /// handshake.
        /// 
        ///  
        /// <para>
        /// Handshakes that are <code>ACCEPTED</code>, <code>DECLINED</code>, <code>CANCELED</code>,
        /// or <code>EXPIRED</code> appear in the results of this API for only 30 days after changing
        /// to that state. After that, they're deleted and no longer accessible.
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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHandshakesForOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForOrganization">REST API Reference for ListHandshakesForOrganization Operation</seealso>
        public virtual Task<ListHandshakesForOrganizationResponse> ListHandshakesForOrganizationAsync(ListHandshakesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHandshakesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHandshakesForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<ListHandshakesForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationalUnitsForParent

        internal virtual ListOrganizationalUnitsForParentResponse ListOrganizationalUnitsForParent(ListOrganizationalUnitsForParentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationalUnitsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationalUnitsForParentResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationalUnitsForParentResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnitsForParent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationalUnitsForParent service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ParentNotFoundException">
        /// We can't find a root or OU with the <code>ParentId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListOrganizationalUnitsForParent">REST API Reference for ListOrganizationalUnitsForParent Operation</seealso>
        public virtual Task<ListOrganizationalUnitsForParentResponse> ListOrganizationalUnitsForParentAsync(ListOrganizationalUnitsForParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationalUnitsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationalUnitsForParentResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationalUnitsForParentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParents

        internal virtual ListParentsResponse ListParents(ListParentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParentsResponseUnmarshaller.Instance;

            return Invoke<ListParentsResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the current release, a child can have only a single parent.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParents service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ChildNotFoundException">
        /// We can't find an organizational unit (OU) or Amazon Web Services account with the
        /// <code>ChildId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListParents">REST API Reference for ListParents Operation</seealso>
        public virtual Task<ListParentsResponse> ListParentsAsync(ListParentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListParentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies

        internal virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPoliciesForTarget

        internal virtual ListPoliciesForTargetResponse ListPoliciesForTarget(ListPoliciesForTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesForTargetResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesForTargetResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesForTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPoliciesForTarget service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, account, or policy with the <code>TargetId</code> that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPoliciesForTarget">REST API Reference for ListPoliciesForTarget Operation</seealso>
        public virtual Task<ListPoliciesForTargetResponse> ListPoliciesForTargetAsync(ListPoliciesForTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesForTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesForTargetResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesForTargetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRoots

        internal virtual ListRootsResponse ListRoots(ListRootsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRootsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRootsResponseUnmarshaller.Instance;

            return Invoke<ListRootsResponse>(request, options);
        }



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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        ///  <note> 
        /// <para>
        /// Policy types can be enabled and disabled in roots. This is distinct from whether they're
        /// available in the organization. When you enable all features, you make policy types
        /// available for use in that organization. Individual policy types can then be enabled
        /// and disabled in a root. To see the availability of a policy type in an organization,
        /// use <a>DescribeOrganization</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoots service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListRoots">REST API Reference for ListRoots Operation</seealso>
        public virtual Task<ListRootsResponse> ListRootsAsync(ListRootsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRootsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRootsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRootsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists tags that are attached to the specified resource.
        /// 
        ///  
        /// <para>
        /// You can attach tags to the following resources in Organizations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organization root
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit (OU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy (any type)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, account, or policy with the <code>TargetId</code> that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetsForPolicy

        internal virtual ListTargetsForPolicyResponse ListTargetsForPolicy(ListTargetsForPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListTargetsForPolicyResponse>(request, options);
        }



        /// <summary>
        /// Lists all the roots, organizational units (OUs), and accounts that the specified policy
        /// is attached to.
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
        /// This operation can be called only from the organization's management account or by
        /// a member account that is a delegated administrator for an Amazon Web Services service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetsForPolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the <code>PolicyId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        public virtual Task<ListTargetsForPolicyResponse> ListTargetsForPolicyAsync(ListTargetsForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetsForPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetsForPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetsForPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MoveAccount

        internal virtual MoveAccountResponse MoveAccount(MoveAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveAccountResponseUnmarshaller.Instance;

            return Invoke<MoveAccountResponse>(request, options);
        }



        /// <summary>
        /// Moves an account from its current source parent root or organizational unit (OU) to
        /// the specified destination parent root or OU.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MoveAccount service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DestinationParentNotFoundException">
        /// We can't find the destination container (a root or OU) with the <code>ParentId</code>
        /// that you specified.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.SourceParentNotFoundException">
        /// We can't find a source root or OU with the <code>ParentId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/MoveAccount">REST API Reference for MoveAccount Operation</seealso>
        public virtual Task<MoveAccountResponse> MoveAccountAsync(MoveAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveAccountResponseUnmarshaller.Instance;

            return InvokeAsync<MoveAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a resource policy.
        /// 
        ///  
        /// <para>
        /// You can only call this operation from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDelegatedAdministrator

        internal virtual RegisterDelegatedAdministratorResponse RegisterDelegatedAdministrator(RegisterDelegatedAdministratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDelegatedAdministratorResponseUnmarshaller.Instance;

            return Invoke<RegisterDelegatedAdministratorResponse>(request, options);
        }



        /// <summary>
        /// Enables the specified member account to administer the Organizations features of the
        /// specified Amazon Web Services service. It grants read-only access to Organizations
        /// service data. The account still requires IAM permissions to access and administer
        /// the Amazon Web Services service.
        /// 
        ///  
        /// <para>
        /// You can run this action only for Amazon Web Services services that support this feature.
        /// For a current list of services that support it, see the column <i>Supports Delegated
        /// Administrator</i> in the table at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_integrate_services_list.html">Amazon
        /// Web Services Services that you can use with Organizations</a> in the <i>Organizations
        /// User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDelegatedAdministrator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDelegatedAdministrator service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountAlreadyRegisteredException">
        /// The specified account is already a delegated administrator for this Amazon Web Services
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/RegisterDelegatedAdministrator">REST API Reference for RegisterDelegatedAdministrator Operation</seealso>
        public virtual Task<RegisterDelegatedAdministratorResponse> RegisterDelegatedAdministratorAsync(RegisterDelegatedAdministratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDelegatedAdministratorResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDelegatedAdministratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveAccountFromOrganization

        internal virtual RemoveAccountFromOrganizationResponse RemoveAccountFromOrganization(RemoveAccountFromOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAccountFromOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAccountFromOrganizationResponseUnmarshaller.Instance;

            return Invoke<RemoveAccountFromOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified account from the organization.
        /// 
        ///  
        /// <para>
        /// The removed account becomes a standalone account that isn't a member of any organization.
        /// It's no longer subject to any policies and is responsible for its own bill payments.
        /// The organization's management account is no longer charged for any expenses accrued
        /// by the member account after it's removed from the organization.
        /// </para>
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account. Member
        /// accounts can remove themselves with <a>LeaveOrganization</a> instead.
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// You can remove an account from your organization only if the account is configured
        /// with the information required to operate as a standalone account. When you create
        /// an account in an organization using the Organizations console, API, or CLI commands,
        /// the information required of standalone accounts is <i>not</i> automatically collected.
        /// For an account that you want to make standalone, you must choose a support plan, provide
        /// and verify the required contact information, and provide a current payment method.
        /// Amazon Web Services uses the payment method to charge for any billable (not free tier)
        /// Amazon Web Services activity that occurs while the account isn't attached to an organization.
        /// To remove an account that doesn't yet have this information, you must sign in as the
        /// member account and follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
        /// To leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The account that you want to leave must not be a delegated administrator account for
        /// any Amazon Web Services service enabled for your organization. If the account is a
        /// delegated administrator, you must first change the delegated administrator account
        /// to another account that is remaining in the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After the account leaves the organization, all tags that were attached to the account
        /// object in the organization are deleted. Amazon Web Services accounts outside of an
        /// organization do not support tags.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAccountFromOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAccountFromOrganization service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AccountNotFoundException">
        /// We can't find an Amazon Web Services account with the <code>AccountId</code> that
        /// you specified, or the account whose credentials you used to make this request isn't
        /// a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MasterCannotLeaveOrganizationException">
        /// You can't remove a management account from an organization. If you want the management
        /// account to become a member account in another organization, you must first delete
        /// the current organization of the management account.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/RemoveAccountFromOrganization">REST API Reference for RemoveAccountFromOrganization Operation</seealso>
        public virtual Task<RemoveAccountFromOrganizationResponse> RemoveAccountFromOrganizationAsync(RemoveAccountFromOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAccountFromOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAccountFromOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAccountFromOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// 
        ///  
        /// <para>
        /// Currently, you can attach tags to the following resources in Organizations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organization root
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit (OU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy (any type)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, account, or policy with the <code>TargetId</code> that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes any tags with the specified keys from the specified resource.
        /// 
        ///  
        /// <para>
        /// You can attach tags to the following resources in Organizations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organization root
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit (OU)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy (any type)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TargetNotFoundException">
        /// We can't find a root, OU, account, or policy with the <code>TargetId</code> that you
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOrganizationalUnit

        internal virtual UpdateOrganizationalUnitResponse UpdateOrganizationalUnit(UpdateOrganizationalUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationalUnitResponseUnmarshaller.Instance;

            return Invoke<UpdateOrganizationalUnitResponse>(request, options);
        }



        /// <summary>
        /// Renames the specified organizational unit (OU). The ID and ARN don't change. The child
        /// OUs and accounts remain in place, and any attached policies of the OU remain attached.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationalUnit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOrganizationalUnit service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.DuplicateOrganizationalUnitException">
        /// An OU with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.InvalidInputException">
        /// The requested operation failed because you provided invalid values for one or more
        /// of the request parameters. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.OrganizationalUnitNotFoundException">
        /// We can't find an OU with the <code>OrganizationalUnitId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdateOrganizationalUnit">REST API Reference for UpdateOrganizationalUnit Operation</seealso>
        public virtual Task<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitAsync(UpdateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOrganizationalUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOrganizationalUnitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOrganizationalUnitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePolicy

        internal virtual UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing policy with a new name, description, or content. If you don't
        /// supply any parameter, that value remains unchanged. You can't change a policy's type.
        /// 
        ///  
        /// <para>
        /// This operation can be called only from the organization's management account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by Organizations.</returns>
        /// <exception cref="Amazon.Organizations.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// Management</a> in the <i>IAM User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.AWSOrganizationsNotInUseException">
        /// Your account isn't a member of an organization. To make this request, you must use
        /// the credentials of an account that belongs to an organization.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConcurrentModificationException">
        /// The target of the operation is currently being modified by a different request. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ConstraintViolationException">
        /// Performing this operation violates a minimum or maximum value limit. For example,
        /// attempting to remove the last service control policy (SCP) from an OU or root, inviting
        /// or creating too many accounts to the organization, or attaching too many policies
        /// to an account, OU, or root. This exception includes a reason that contains additional
        /// information about the violated limit:
        /// 
        ///  <note> 
        /// <para>
        /// Some of the reasons in the following list might not be applicable to this specific
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_ORGANIZATION: You attempted to remove the management account
        /// from the organization. You can't remove the management account. Instead, after you
        /// remove all member accounts, delete the organization itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CANNOT_LEAVE_WITHOUT_PHONE_VERIFICATION: You attempted to remove an account
        /// from the organization that doesn't yet have enough information to exist as a standalone
        /// account. This account requires you to first complete phone verification. Follow the
        /// steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#orgs_manage_accounts_remove-from-master">Removing
        /// a member account from your organization</a> in the <i>Organizations User Guide.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_CREATION_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can create in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the limit on the number of
        /// accounts in an organization. If you need more accounts, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support</a> to request an increase in your limit. 
        /// </para>
        ///  
        /// <para>
        /// Or the number of invitations that you tried to send would cause you to exceed the
        /// limit of accounts in your organization. Send fewer invitations or contact Amazon Web
        /// Services Support to request an increase in the number of accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleted and closed accounts still count toward your limit.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you get this exception when running a command immediately after creating the organization,
        /// wait one hour and try again. After an hour, if the command continues to fail with
        /// this error, contact <a href="https://docs.aws.amazon.com/support/home#/">Amazon Web
        /// Services Support</a>.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// CANNOT_REGISTER_MASTER_AS_DELEGATED_ADMINISTRATOR: You attempted to register the management
        /// account of the organization as a delegated administrator for an Amazon Web Services
        /// service integrated with Organizations. You can designate only a member account as
        /// a delegated administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_CLOSE_MANAGEMENT_ACCOUNT: You attempted to close the management account. To
        /// close the management account for the organization, you must first either remove or
        /// close all member accounts in the organization. Follow standard account closure process
        /// using root credentials.​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANNOT_REMOVE_DELEGATED_ADMINISTRATOR_FROM_ORG: You attempted to remove an account
        /// that is registered as a delegated administrator for a service integrated with your
        /// organization. To complete this operation, you must first deregister this account as
        /// a delegated administrator. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_QUOTA_EXCEEDED: You have exceeded close account quota for the past 30
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSE_ACCOUNT_REQUESTS_LIMIT_EXCEEDED: You attempted to exceed the number of accounts
        /// that you can close at a time. ​ 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_ORGANIZATION_IN_BILLING_MODE_UNSUPPORTED_REGION: To create an organization
        /// in the specified region, you must enable all features mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELEGATED_ADMINISTRATOR_EXISTS_FOR_THIS_SERVICE: You attempted to register an Amazon
        /// Web Services account as a delegated administrator for an Amazon Web Services service
        /// that already has a delegated administrator. To complete this operation, you must first
        /// deregister any existing delegated administrators for this service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EMAIL_VERIFICATION_CODE_EXPIRED: The email verification code is only valid for a limited
        /// period of time. You must resubmit the request and generate a new verfication code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HANDSHAKE_RATE_LIMIT_EXCEEDED: You attempted to exceed the number of handshakes that
        /// you can send in one day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PAYMENT_INSTRUMENT: You cannot remove an account because no supported payment
        /// method is associated with the account. Amazon Web Services does not support cards
        /// issued by financial institutions in Russia or Belarus. For more information, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/manage-general.html">Managing
        /// your Amazon Web Services payments</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_ADDRESS_DOES_NOT_MATCH_MARKETPLACE: To create an account in this organization,
        /// you first must migrate the organization's management account to the marketplace that
        /// corresponds to the management account's address. For example, accounts with India
        /// addresses must be associated with the AISPL marketplace. All accounts in an organization
        /// must be associated with the same marketplace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_BUSINESS_LICENSE: Applies only to the Amazon Web Services /&gt;
        /// Regions in China. To create an organization, the master must have a valid business
        /// license. For more information, contact customer support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_MISSING_CONTACT_INFO: To complete this operation, you must first provide
        /// a valid contact address and phone number for the management account. Then try the
        /// operation again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_NOT_GOVCLOUD_ENABLED: To complete this operation, the management account
        /// must have an associated account in the Amazon Web Services GovCloud (US-West) Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/govcloud-us/latest/UserGuide/govcloud-organizations.html">Organizations</a>
        /// in the <i>Amazon Web Services GovCloud User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MASTER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To create an organization with this management
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_DELEGATED_ADMINISTRATORS_FOR_SERVICE_LIMIT_EXCEEDED: You attempted to register
        /// more delegated administrators than allowed for the service principal. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to exceed the number of policies
        /// of a certain type that can be attached to an entity at one time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MAX_TAG_LIMIT_EXCEEDED: You have exceeded the number of tags allowed on this resource.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEMBER_ACCOUNT_PAYMENT_INSTRUMENT_REQUIRED: To complete this operation with this member
        /// account, you first must associate a valid payment instrument, such as a credit card,
        /// with the account. Follow the steps at <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">To
        /// leave an organization when all required account information has not yet been provided</a>
        /// in the <i>Organizations User Guide.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIN_POLICY_TYPE_ATTACHMENT_LIMIT_EXCEEDED: You attempted to detach a policy from an
        /// entity that would cause the entity to have fewer than the minimum number of policies
        /// of a certain type required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ORGANIZATION_NOT_IN_ALL_FEATURES_MODE: You attempted to perform an operation that
        /// requires the organization to be configured to support all features. An organization
        /// that supports only consolidated billing features can't perform this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_DEPTH_LIMIT_EXCEEDED: You attempted to create an OU tree that is too many levels
        /// deep.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OU_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of OUs that you can have
        /// in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_CONTENT_LIMIT_EXCEEDED: You attempted to create a policy that is larger than
        /// the maximum size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POLICY_NUMBER_LIMIT_EXCEEDED: You attempted to exceed the number of policies that
        /// you can have in an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE_ACCESS_NOT_ENABLED: You attempted to register a delegated administrator before
        /// you enabled service access. Call the <code>EnableAWSServiceAccess</code> API first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG_POLICY_VIOLATION: You attempted to create or update a resource with tags that
        /// are not compliant with the tag policy requirements for this account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WAIT_PERIOD_ACTIVE: After you create an Amazon Web Services account, there is a waiting
        /// period before you can remove it from the organization. If you get an error that indicates
        /// that a wait period is required, try again in a few days.
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
        /// API or operation.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// DUPLICATE_TAG_KEY: Tag keys must be unique among the tags attached to the same entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IMMUTABLE_POLICY: You specified a policy that is managed by Amazon Web Services and
        /// can't be modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INPUT_REQUIRED: You must include a value for all required parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_EMAIL_ADDRESS_TARGET: You specified an invalid email address for the invited
        /// account owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM: You specified an invalid value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_ENUM_POLICY_TYPE: You specified an invalid policy type string.
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
        /// INVALID_PAGINATION_TOKEN: Get the value for the <code>NextToken</code> parameter from
        /// the response to a previous call of the operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_PARTY_TYPE_TARGET: You specified the wrong type of entity (account, organization,
        /// or email) as a party.
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
        /// INVALID_ROLE_NAME: You provided a role name that isn't valid. A role name can't begin
        /// with the reserved prefix <code>AWSServiceRoleFor</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_ORGANIZATION_ARN: You specified an invalid Amazon Resource Name (ARN)
        /// for the organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYNTAX_POLICY_ID: You specified an invalid policy ID. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID_SYSTEM_TAGS_PARAMETER: You specified a tag key that is a system tag. You can’t
        /// add, edit, or delete system tag keys because they're reserved for Amazon Web Services
        /// use. System tags don’t count against your tags per resource limit.
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
        ///  </li> <li> 
        /// <para>
        /// TARGET_NOT_SUPPORTED: You can't perform the specified operation on that target entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNRECOGNIZED_SERVICE_PRINCIPAL: You specified a service principal that isn't recognized.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.MalformedPolicyDocumentException">
        /// The provided policy document doesn't meet the requirements of the specified policy
        /// type. For example, the syntax might be incorrect. For details about service control
        /// policy syntax, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_scp-syntax.html">Service
        /// Control Policy Syntax</a> in the <i>Organizations User Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyChangesInProgressException">
        /// Changes to the effective policy are in progress, and its contents can't be returned.
        /// Try the operation again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.PolicyNotFoundException">
        /// We can't find a policy with the <code>PolicyId</code> that you specified.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.ServiceException">
        /// Organizations can't complete your request because of an internal service error. Try
        /// again later.
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.TooManyRequestsException">
        /// You have sent too many requests in too short a period of time. The quota helps protect
        /// against denial-of-service attacks. Try again later.
        /// 
        ///  
        /// <para>
        /// For information about quotas that affect Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_reference_limits.html">Quotas
        /// for Organizations</a>in the <i>Organizations User Guide.</i> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Organizations.Model.UnsupportedAPIEndpointException">
        /// This action isn't available in the current Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public virtual Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}