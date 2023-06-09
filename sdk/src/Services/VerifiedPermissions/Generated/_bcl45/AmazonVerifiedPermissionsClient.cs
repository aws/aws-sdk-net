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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.VerifiedPermissions.Model;
using Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations;
using Amazon.VerifiedPermissions.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.VerifiedPermissions
{
    /// <summary>
    /// Implementation for accessing VerifiedPermissions
    ///
    /// Amazon Verified Permissions is a permissions management service from Amazon Web Services.
    /// You can use Verified Permissions to manage permissions for your application, and authorize
    /// user access based on those permissions. Using Verified Permissions, application developers
    /// can grant access based on information about the users, resources, and requested actions.
    /// You can also evaluate additional information like group membership, attributes of
    /// the resources, and session context, such as time of request and IP addresses. Verified
    /// Permissions manages these permissions by letting you create and store authorization
    /// policies for your applications, such as consumer-facing web sites and enterprise business
    /// systems.
    /// 
    ///  
    /// <para>
    /// Verified Permissions uses Cedar as the policy language to express your permission
    /// requirements. Cedar supports both role-based access control (RBAC) and attribute-based
    /// access control (ABAC) authorization models.
    /// </para>
    ///  
    /// <para>
    /// For more information about configuring, administering, and using Amazon Verified Permissions
    /// in your applications, see the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/userguide/">Amazon
    /// Verified Permissions User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about the Cedar policy language, see the <a href="https://docs.cedarpolicy.com/">Cedar
    /// Policy Language Guide</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// When you write Cedar policies that reference principals, resources and actions, you
    /// can define the unique identifiers used for each of those elements. We strongly recommend
    /// that you follow these best practices:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Use values like universally unique identifiers (UUIDs) for all principal and resource
    /// identifiers.</b> 
    /// </para>
    ///  
    /// <para>
    /// For example, if user <code>jane</code> leaves the company, and you later let someone
    /// else use the name <code>jane</code>, then that new user automatically gets access
    /// to everything granted by policies that still reference <code>User::"jane"</code>.
    /// Cedar can’t distinguish between the new user and the old. This applies to both principal
    /// and resource identifiers. Always use identifiers that are guaranteed unique and never
    /// reused to ensure that you don’t unintentionally grant access because of the presence
    /// of an old identifier in a policy.
    /// </para>
    ///  
    /// <para>
    /// Where you use a UUID for an entity, we recommend that you follow it with the // comment
    /// specifier and the ‘friendly’ name of your entity. This helps to make your policies
    /// easier to understand. For example: principal == User::"a1b2c3d4-e5f6-a1b2-c3d4-EXAMPLE11111",
    /// // alice
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Do not include personally identifying, confidential, or sensitive information
    /// as part of the unique identifier for your principals or resources.</b> These identifiers
    /// are included in log entries shared in CloudTrail trails.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// Several operations return structures that appear similar, but have different purposes.
    /// As new functionality is added to the product, the structure used in a parameter of
    /// one operation might need to change in a way that wouldn't make sense for the same
    /// parameter in a different operation. To help you understand the purpose of each, the
    /// following naming convention is used for the structures:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Parameter type structures that end in <code>Detail</code> are used in <code>Get</code>
    /// operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Parameter type structures that end in <code>Item</code> are used in <code>List</code>
    /// operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Parameter type structures that use neither suffix are used in the mutating (create
    /// and update) operations.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonVerifiedPermissionsClient : AmazonServiceClient, IAmazonVerifiedPermissions
    {
        private static IServiceMetadata serviceMetadata = new AmazonVerifiedPermissionsMetadata();
        private IVerifiedPermissionsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IVerifiedPermissionsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new VerifiedPermissionsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with the credentials loaded from the application's
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
        public AmazonVerifiedPermissionsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonVerifiedPermissionsConfig()) { }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with the credentials loaded from the application's
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
        public AmazonVerifiedPermissionsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonVerifiedPermissionsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonVerifiedPermissionsClient Configuration Object</param>
        public AmazonVerifiedPermissionsClient(AmazonVerifiedPermissionsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonVerifiedPermissionsClient(AWSCredentials credentials)
            : this(credentials, new AmazonVerifiedPermissionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVerifiedPermissionsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonVerifiedPermissionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Credentials and an
        /// AmazonVerifiedPermissionsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonVerifiedPermissionsClient Configuration Object</param>
        public AmazonVerifiedPermissionsClient(AWSCredentials credentials, AmazonVerifiedPermissionsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonVerifiedPermissionsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonVerifiedPermissionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVerifiedPermissionsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonVerifiedPermissionsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonVerifiedPermissionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonVerifiedPermissionsClient Configuration Object</param>
        public AmazonVerifiedPermissionsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonVerifiedPermissionsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonVerifiedPermissionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonVerifiedPermissionsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonVerifiedPermissionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonVerifiedPermissionsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonVerifiedPermissionsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonVerifiedPermissionsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonVerifiedPermissionsClient Configuration Object</param>
        public AmazonVerifiedPermissionsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonVerifiedPermissionsConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonVerifiedPermissionsEndpointResolver());
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


        #region  CreateIdentitySource


        /// <summary>
        /// Creates a reference to an Amazon Cognito user pool as an external identity provider
        /// (IdP). 
        /// 
        ///  
        /// <para>
        /// After you create an identity source, you can use the identities provided by the IdP
        /// as proxies for the principal in authorization queries that use the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
        /// operation. These identities take the form of tokens that contain claims about the
        /// user, such as IDs, attributes and group memberships. Amazon Cognito provides both
        /// identity tokens and access tokens, and Verified Permissions can use either or both.
        /// Any combination of identity and access tokens results in the same Cedar principal.
        /// Verified Permissions automatically translates the information about the identities
        /// into the standard Cedar attributes that can be evaluated by your policies. Because
        /// the Amazon Cognito identity and access tokens can contain different information, the
        /// tokens you choose to use determine which principal attributes are available to access
        /// when evaluating Cedar policies.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you delete a Amazon Cognito user pool or user, tokens from that deleted pool or
        /// that deleted user continue to be usable until they expire.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// To reference a user from this identity source in your Cedar policies, use the following
        /// syntax.
        /// </para>
        ///  
        /// <para>
        ///  <i>IdentityType::"&lt;CognitoUserPoolIdentifier&gt;|&lt;CognitoClientId&gt;</i> 
        /// </para>
        ///  
        /// <para>
        /// Where <code>IdentityType</code> is the string that you provide to the <code>PrincipalEntityType</code>
        /// parameter for this operation. The <code>CognitoUserPoolId</code> and <code>CognitoClientId</code>
        /// are defined by the Amazon Cognito user pool.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentitySource service method.</param>
        /// 
        /// <returns>The response from the CreateIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        public virtual CreateIdentitySourceResponse CreateIdentitySource(CreateIdentitySourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<CreateIdentitySourceResponse>(request, options);
        }


        /// <summary>
        /// Creates a reference to an Amazon Cognito user pool as an external identity provider
        /// (IdP). 
        /// 
        ///  
        /// <para>
        /// After you create an identity source, you can use the identities provided by the IdP
        /// as proxies for the principal in authorization queries that use the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
        /// operation. These identities take the form of tokens that contain claims about the
        /// user, such as IDs, attributes and group memberships. Amazon Cognito provides both
        /// identity tokens and access tokens, and Verified Permissions can use either or both.
        /// Any combination of identity and access tokens results in the same Cedar principal.
        /// Verified Permissions automatically translates the information about the identities
        /// into the standard Cedar attributes that can be evaluated by your policies. Because
        /// the Amazon Cognito identity and access tokens can contain different information, the
        /// tokens you choose to use determine which principal attributes are available to access
        /// when evaluating Cedar policies.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you delete a Amazon Cognito user pool or user, tokens from that deleted pool or
        /// that deleted user continue to be usable until they expire.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// To reference a user from this identity source in your Cedar policies, use the following
        /// syntax.
        /// </para>
        ///  
        /// <para>
        ///  <i>IdentityType::"&lt;CognitoUserPoolIdentifier&gt;|&lt;CognitoClientId&gt;</i> 
        /// </para>
        ///  
        /// <para>
        /// Where <code>IdentityType</code> is the string that you provide to the <code>PrincipalEntityType</code>
        /// parameter for this operation. The <code>CognitoUserPoolId</code> and <code>CognitoClientId</code>
        /// are defined by the Amazon Cognito user pool.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        public virtual Task<CreateIdentitySourceResponse> CreateIdentitySourceAsync(CreateIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentitySourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIdentitySourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates a Cedar policy and saves it in the specified policy store. You can create
        /// either a static policy or a policy linked to a policy template.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To create a static policy, provide the Cedar policy text in the <code>StaticPolicy</code>
        /// section of the <code>PolicyDefinition</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a policy that is dynamically linked to a policy template, specify the policy
        /// template ID and the principal and resource to associate with this policy in the <code>templateLinked</code>
        /// section of the <code>PolicyDefinition</code>. If the policy template is ever updated,
        /// any policies linked to the policy template automatically use the updated template.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Creating a policy causes it to be validated against the schema in the policy store.
        /// If the policy doesn't pass validation, the operation fails and the policy isn't stored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates a Cedar policy and saves it in the specified policy store. You can create
        /// either a static policy or a policy linked to a policy template.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To create a static policy, provide the Cedar policy text in the <code>StaticPolicy</code>
        /// section of the <code>PolicyDefinition</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a policy that is dynamically linked to a policy template, specify the policy
        /// template ID and the principal and resource to associate with this policy in the <code>templateLinked</code>
        /// section of the <code>PolicyDefinition</code>. If the policy template is ever updated,
        /// any policies linked to the policy template automatically use the updated template.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Creating a policy causes it to be validated against the schema in the policy store.
        /// If the policy doesn't pass validation, the operation fails and the policy isn't stored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicyStore


        /// <summary>
        /// Creates a policy store. A policy store is a container for policy resources.
        /// 
        ///  <note> 
        /// <para>
        /// Although <a href="https://docs.cedarpolicy.com/schema.html#namespace">Cedar supports
        /// multiple namespaces</a>, Verified Permissions currently supports only one namespace
        /// per policy store.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyStore service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyStore">REST API Reference for CreatePolicyStore Operation</seealso>
        public virtual CreatePolicyStoreResponse CreatePolicyStore(CreatePolicyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyStoreResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyStoreResponse>(request, options);
        }


        /// <summary>
        /// Creates a policy store. A policy store is a container for policy resources.
        /// 
        ///  <note> 
        /// <para>
        /// Although <a href="https://docs.cedarpolicy.com/schema.html#namespace">Cedar supports
        /// multiple namespaces</a>, Verified Permissions currently supports only one namespace
        /// per policy store.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyStore">REST API Reference for CreatePolicyStore Operation</seealso>
        public virtual Task<CreatePolicyStoreResponse> CreatePolicyStoreAsync(CreatePolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePolicyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePolicyTemplate


        /// <summary>
        /// Creates a policy template. A template can use placeholders for the principal and resource.
        /// A template must be instantiated into a policy by associating it with specific principals
        /// and resources to use for the placeholders. That instantiated policy can then be considered
        /// in authorization decisions. The instantiated policy works identically to any other
        /// policy, except that it is dynamically linked to the template. If the template changes,
        /// then any policies that are linked to that template are immediately updated as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyTemplate service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyTemplate">REST API Reference for CreatePolicyTemplate Operation</seealso>
        public virtual CreatePolicyTemplateResponse CreatePolicyTemplate(CreatePolicyTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyTemplateResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyTemplateResponse>(request, options);
        }


        /// <summary>
        /// Creates a policy template. A template can use placeholders for the principal and resource.
        /// A template must be instantiated into a policy by associating it with specific principals
        /// and resources to use for the placeholders. That instantiated policy can then be considered
        /// in authorization decisions. The instantiated policy works identically to any other
        /// policy, except that it is dynamically linked to the template. If the template changes,
        /// then any policies that are linked to that template are immediately updated as well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyTemplate">REST API Reference for CreatePolicyTemplate Operation</seealso>
        public virtual Task<CreatePolicyTemplateResponse> CreatePolicyTemplateAsync(CreatePolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePolicyTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePolicyTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentitySource


        /// <summary>
        /// Deletes an identity source that references an identity provider (IdP) such as Amazon
        /// Cognito. After you delete the identity source, you can no longer use tokens for identities
        /// from that identity source to represent principals in authorization queries made using
        /// <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>.
        /// operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentitySource service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        public virtual DeleteIdentitySourceResponse DeleteIdentitySource(DeleteIdentitySourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentitySourceResponse>(request, options);
        }


        /// <summary>
        /// Deletes an identity source that references an identity provider (IdP) such as Amazon
        /// Cognito. After you delete the identity source, you can no longer use tokens for identities
        /// from that identity source to represent principals in authorization queries made using
        /// <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>.
        /// operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        public virtual Task<DeleteIdentitySourceResponse> DeleteIdentitySourceAsync(DeleteIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitySourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIdentitySourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified policy from the policy store.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; if you specify a policy that doesn't exist, the request
        /// response returns a successful <code>HTTP 200</code> status code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified policy from the policy store.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; if you specify a policy that doesn't exist, the request
        /// response returns a successful <code>HTTP 200</code> status code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicyStore


        /// <summary>
        /// Deletes the specified policy store.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. If you specify a policy store that does not exist, the
        /// request response will still return a successful HTTP 200 status code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStore service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyStore">REST API Reference for DeletePolicyStore Operation</seealso>
        public virtual DeletePolicyStoreResponse DeletePolicyStore(DeletePolicyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyStoreResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyStoreResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified policy store.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. If you specify a policy store that does not exist, the
        /// request response will still return a successful HTTP 200 status code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyStore">REST API Reference for DeletePolicyStore Operation</seealso>
        public virtual Task<DeletePolicyStoreResponse> DeletePolicyStoreAsync(DeletePolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePolicyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicyTemplate


        /// <summary>
        /// Deletes the specified policy template from the policy store.
        /// 
        ///  <important> 
        /// <para>
        /// This operation also deletes any policies that were created from the specified policy
        /// template. Those policies are immediately removed from all future API responses, and
        /// are asynchronously deleted from the policy store.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyTemplate service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyTemplate">REST API Reference for DeletePolicyTemplate Operation</seealso>
        public virtual DeletePolicyTemplateResponse DeletePolicyTemplate(DeletePolicyTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyTemplateResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyTemplateResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified policy template from the policy store.
        /// 
        ///  <important> 
        /// <para>
        /// This operation also deletes any policies that were created from the specified policy
        /// template. Those policies are immediately removed from all future API responses, and
        /// are asynchronously deleted from the policy store.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyTemplate">REST API Reference for DeletePolicyTemplate Operation</seealso>
        public virtual Task<DeletePolicyTemplateResponse> DeletePolicyTemplateAsync(DeletePolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePolicyTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentitySource


        /// <summary>
        /// Retrieves the details about the specified identity source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentitySource service method.</param>
        /// 
        /// <returns>The response from the GetIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        public virtual GetIdentitySourceResponse GetIdentitySource(GetIdentitySourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<GetIdentitySourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details about the specified identity source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        public virtual Task<GetIdentitySourceResponse> GetIdentitySourceAsync(GetIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentitySourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIdentitySourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves information about the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicyStore


        /// <summary>
        /// Retrieves details about a policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyStore service method.</param>
        /// 
        /// <returns>The response from the GetPolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyStore">REST API Reference for GetPolicyStore Operation</seealso>
        public virtual GetPolicyStoreResponse GetPolicyStore(GetPolicyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyStoreResponseUnmarshaller.Instance;

            return Invoke<GetPolicyStoreResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyStore">REST API Reference for GetPolicyStore Operation</seealso>
        public virtual Task<GetPolicyStoreResponse> GetPolicyStoreAsync(GetPolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPolicyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPolicyTemplate


        /// <summary>
        /// Retrieve the details for the specified policy template in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyTemplate service method.</param>
        /// 
        /// <returns>The response from the GetPolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyTemplate">REST API Reference for GetPolicyTemplate Operation</seealso>
        public virtual GetPolicyTemplateResponse GetPolicyTemplate(GetPolicyTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyTemplateResponseUnmarshaller.Instance;

            return Invoke<GetPolicyTemplateResponse>(request, options);
        }


        /// <summary>
        /// Retrieve the details for the specified policy template in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyTemplate">REST API Reference for GetPolicyTemplate Operation</seealso>
        public virtual Task<GetPolicyTemplateResponse> GetPolicyTemplateAsync(GetPolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPolicyTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSchema


        /// <summary>
        /// Retrieve the details for the specified schema in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual GetSchemaResponse GetSchema(GetSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;

            return Invoke<GetSchemaResponse>(request, options);
        }


        /// <summary>
        /// Retrieve the details for the specified schema in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetSchema">REST API Reference for GetSchema Operation</seealso>
        public virtual Task<GetSchemaResponse> GetSchemaAsync(GetSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSchemaResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IsAuthorized


        /// <summary>
        /// Makes an authorization decision about a service request described in the parameters.
        /// The information in the parameters can also define additional context that Verified
        /// Permissions can include in the evaluation. The request is evaluated against all matching
        /// policies in the specified policy store. The result of the decision is either <code>Allow</code>
        /// or <code>Deny</code>, along with a list of the policies that resulted in the decision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsAuthorized service method.</param>
        /// 
        /// <returns>The response from the IsAuthorized service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorized">REST API Reference for IsAuthorized Operation</seealso>
        public virtual IsAuthorizedResponse IsAuthorized(IsAuthorizedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsAuthorizedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsAuthorizedResponseUnmarshaller.Instance;

            return Invoke<IsAuthorizedResponse>(request, options);
        }


        /// <summary>
        /// Makes an authorization decision about a service request described in the parameters.
        /// The information in the parameters can also define additional context that Verified
        /// Permissions can include in the evaluation. The request is evaluated against all matching
        /// policies in the specified policy store. The result of the decision is either <code>Allow</code>
        /// or <code>Deny</code>, along with a list of the policies that resulted in the decision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsAuthorized service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IsAuthorized service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorized">REST API Reference for IsAuthorized Operation</seealso>
        public virtual Task<IsAuthorizedResponse> IsAuthorizedAsync(IsAuthorizedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsAuthorizedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsAuthorizedResponseUnmarshaller.Instance;
            
            return InvokeAsync<IsAuthorizedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IsAuthorizedWithToken


        /// <summary>
        /// Makes an authorization decision about a service request described in the parameters.
        /// The principal in this request comes from an external identity source. The information
        /// in the parameters can also define additional context that Verified Permissions can
        /// include in the evaluation. The request is evaluated against all matching policies
        /// in the specified policy store. The result of the decision is either <code>Allow</code>
        /// or <code>Deny</code>, along with a list of the policies that resulted in the decision.
        /// 
        ///  <important> 
        /// <para>
        /// If you delete a Amazon Cognito user pool or user, tokens from that deleted pool or
        /// that deleted user continue to be usable until they expire.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsAuthorizedWithToken service method.</param>
        /// 
        /// <returns>The response from the IsAuthorizedWithToken service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorizedWithToken">REST API Reference for IsAuthorizedWithToken Operation</seealso>
        public virtual IsAuthorizedWithTokenResponse IsAuthorizedWithToken(IsAuthorizedWithTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsAuthorizedWithTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsAuthorizedWithTokenResponseUnmarshaller.Instance;

            return Invoke<IsAuthorizedWithTokenResponse>(request, options);
        }


        /// <summary>
        /// Makes an authorization decision about a service request described in the parameters.
        /// The principal in this request comes from an external identity source. The information
        /// in the parameters can also define additional context that Verified Permissions can
        /// include in the evaluation. The request is evaluated against all matching policies
        /// in the specified policy store. The result of the decision is either <code>Allow</code>
        /// or <code>Deny</code>, along with a list of the policies that resulted in the decision.
        /// 
        ///  <important> 
        /// <para>
        /// If you delete a Amazon Cognito user pool or user, tokens from that deleted pool or
        /// that deleted user continue to be usable until they expire.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsAuthorizedWithToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IsAuthorizedWithToken service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorizedWithToken">REST API Reference for IsAuthorizedWithToken Operation</seealso>
        public virtual Task<IsAuthorizedWithTokenResponse> IsAuthorizedWithTokenAsync(IsAuthorizedWithTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsAuthorizedWithTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsAuthorizedWithTokenResponseUnmarshaller.Instance;
            
            return InvokeAsync<IsAuthorizedWithTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentitySources


        /// <summary>
        /// Returns a paginated list of all of the identity sources defined in the specified policy
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentitySources service method.</param>
        /// 
        /// <returns>The response from the ListIdentitySources service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        public virtual ListIdentitySourcesResponse ListIdentitySources(ListIdentitySourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitySourcesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitySourcesResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of all of the identity sources defined in the specified policy
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentitySources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentitySources service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        public virtual Task<ListIdentitySourcesResponse> ListIdentitySourcesAsync(ListIdentitySourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitySourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListIdentitySourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Returns a paginated list of all policies stored in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of all policies stored in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyStores


        /// <summary>
        /// Returns a paginated list of all policy stores in the calling Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyStores service method.</param>
        /// 
        /// <returns>The response from the ListPolicyStores service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyStores">REST API Reference for ListPolicyStores Operation</seealso>
        public virtual ListPolicyStoresResponse ListPolicyStores(ListPolicyStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyStoresResponseUnmarshaller.Instance;

            return Invoke<ListPolicyStoresResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of all policy stores in the calling Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyStores service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyStores">REST API Reference for ListPolicyStores Operation</seealso>
        public virtual Task<ListPolicyStoresResponse> ListPolicyStoresAsync(ListPolicyStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyStoresResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPolicyStoresResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPolicyTemplates


        /// <summary>
        /// Returns a paginated list of all policy templates in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyTemplates service method.</param>
        /// 
        /// <returns>The response from the ListPolicyTemplates service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyTemplates">REST API Reference for ListPolicyTemplates Operation</seealso>
        public virtual ListPolicyTemplatesResponse ListPolicyTemplates(ListPolicyTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListPolicyTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of all policy templates in the specified policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyTemplates service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyTemplates">REST API Reference for ListPolicyTemplates Operation</seealso>
        public virtual Task<ListPolicyTemplatesResponse> ListPolicyTemplatesAsync(ListPolicyTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPolicyTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPolicyTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSchema


        /// <summary>
        /// Creates or updates the policy schema in the specified policy store. The schema is
        /// used to validate any Cedar policies and policy templates submitted to the policy store.
        /// Any changes to the schema validate only policies and templates submitted after the
        /// schema change. Existing policies and templates are not re-evaluated against the changed
        /// schema. If you later update a policy, then it is evaluated against the new schema
        /// at that time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchema service method.</param>
        /// 
        /// <returns>The response from the PutSchema service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/PutSchema">REST API Reference for PutSchema Operation</seealso>
        public virtual PutSchemaResponse PutSchema(PutSchemaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaResponseUnmarshaller.Instance;

            return Invoke<PutSchemaResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates the policy schema in the specified policy store. The schema is
        /// used to validate any Cedar policies and policy templates submitted to the policy store.
        /// Any changes to the schema validate only policies and templates submitted after the
        /// schema change. Existing policies and templates are not re-evaluated against the changed
        /// schema. If you later update a policy, then it is evaluated against the new schema
        /// at that time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSchema service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSchema service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/PutSchema">REST API Reference for PutSchema Operation</seealso>
        public virtual Task<PutSchemaResponse> PutSchemaAsync(PutSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSchemaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSchemaResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutSchemaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIdentitySource


        /// <summary>
        /// Updates the specified identity source to use a new identity provider (IdP) source,
        /// or to change the mapping of identities from the IdP to a different principal entity
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentitySource service method.</param>
        /// 
        /// <returns>The response from the UpdateIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdateIdentitySource">REST API Reference for UpdateIdentitySource Operation</seealso>
        public virtual UpdateIdentitySourceResponse UpdateIdentitySource(UpdateIdentitySourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentitySourceResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified identity source to use a new identity provider (IdP) source,
        /// or to change the mapping of identities from the IdP to a different principal entity
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIdentitySource service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdateIdentitySource">REST API Reference for UpdateIdentitySource Operation</seealso>
        public virtual Task<UpdateIdentitySourceResponse> UpdateIdentitySourceAsync(UpdateIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentitySourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIdentitySourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePolicy


        /// <summary>
        /// Modifies a Cedar static policy in the specified policy store. You can change only
        /// certain elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyInput.html#amazonverifiedpermissions-UpdatePolicy-request-UpdatePolicyDefinition">UpdatePolicyDefinition</a>
        /// parameter. You can directly update only static policies. To change a template-linked
        /// policy, you must update the template instead, using <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html">UpdatePolicyTemplate</a>.
        /// 
        ///  <note> 
        /// <para>
        /// If policy validation is enabled in the policy store, then updating a static policy
        /// causes Verified Permissions to validate the policy against the schema in the policy
        /// store. If the updated static policy doesn't pass validation, the operation fails and
        /// the update isn't stored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public virtual UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyResponse>(request, options);
        }


        /// <summary>
        /// Modifies a Cedar static policy in the specified policy store. You can change only
        /// certain elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyInput.html#amazonverifiedpermissions-UpdatePolicy-request-UpdatePolicyDefinition">UpdatePolicyDefinition</a>
        /// parameter. You can directly update only static policies. To change a template-linked
        /// policy, you must update the template instead, using <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html">UpdatePolicyTemplate</a>.
        /// 
        ///  <note> 
        /// <para>
        /// If policy validation is enabled in the policy store, then updating a static policy
        /// causes Verified Permissions to validate the policy against the schema in the policy
        /// store. If the updated static policy doesn't pass validation, the operation fails and
        /// the update isn't stored.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ServiceQuotaExceededException">
        /// The request failed because it would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        public virtual Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePolicyStore


        /// <summary>
        /// Modifies the validation setting for a policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyStore service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyStore">REST API Reference for UpdatePolicyStore Operation</seealso>
        public virtual UpdatePolicyStoreResponse UpdatePolicyStore(UpdatePolicyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyStoreResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyStoreResponse>(request, options);
        }


        /// <summary>
        /// Modifies the validation setting for a policy store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicyStore service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyStore">REST API Reference for UpdatePolicyStore Operation</seealso>
        public virtual Task<UpdatePolicyStoreResponse> UpdatePolicyStoreAsync(UpdatePolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePolicyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePolicyTemplate


        /// <summary>
        /// Updates the specified policy template. You can update only the description and the
        /// some elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html#amazonverifiedpermissions-UpdatePolicyTemplate-request-policyBody">policyBody</a>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// Changes you make to the policy template content are immediately reflected in authorization
        /// decisions that involve all template-linked policies instantiated from this template.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyTemplate">REST API Reference for UpdatePolicyTemplate Operation</seealso>
        public virtual UpdatePolicyTemplateResponse UpdatePolicyTemplate(UpdatePolicyTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdatePolicyTemplateResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified policy template. You can update only the description and the
        /// some elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html#amazonverifiedpermissions-UpdatePolicyTemplate-request-policyBody">policyBody</a>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// Changes you make to the policy template content are immediately reflected in authorization
        /// decisions that involve all template-linked policies instantiated from this template.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicyTemplate service method, as returned by VerifiedPermissions.</returns>
        /// <exception cref="Amazon.VerifiedPermissions.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.InternalServerException">
        /// The request failed because of an internal error. Try your request again later
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ResourceNotFoundException">
        /// The request failed because it references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ThrottlingException">
        /// The request failed because it exceeded a throttling quota.
        /// </exception>
        /// <exception cref="Amazon.VerifiedPermissions.Model.ValidationException">
        /// The request failed because one or more input parameters don't satisfy their constraint
        /// requirements. The output is provided as a list of fields and a reason for each field
        /// that isn't valid.
        /// 
        ///  
        /// <para>
        /// The possible reasons include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UnrecognizedEntityType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an entity type that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnrecognizedActionId</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action id that isn't found in the schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>InvalidActionApplication</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy includes an action that, according to the schema, doesn't support the specified
        /// principal and resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnexpectedType</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy included an operand that isn't a valid type for the specified operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IncompatibleTypes</b> 
        /// </para>
        ///  
        /// <para>
        /// The types of elements included in a <code>set</code>, or the types of expressions
        /// used in an <code>if...then...else</code> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UnsafeOptionalAttributeAccess</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that is optional and isn't
        /// guaranteed to be present. Test for the existence of the attribute first before attempting
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/syntax-operators.html#has-presence-of-attribute-test">has
        /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ImpossiblePolicy</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar has determined that a policy condition always evaluates to false. If the policy
        /// is always false, it can never apply to any query, and so it can never affect an authorization
        /// decision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WrongNumberArguments</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy references an extension type with the wrong number of arguments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FunctionArgumentValidationError</b> 
        /// </para>
        ///  
        /// <para>
        /// Cedar couldn't parse the argument passed to an extension type. For example, a string
        /// that is to be parsed as an IPv4 address can contain only digits and the period character.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyTemplate">REST API Reference for UpdatePolicyTemplate Operation</seealso>
        public virtual Task<UpdatePolicyTemplateResponse> UpdatePolicyTemplateAsync(UpdatePolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePolicyTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePolicyTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePolicyTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}