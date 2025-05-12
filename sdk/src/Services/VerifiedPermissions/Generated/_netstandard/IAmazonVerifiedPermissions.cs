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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.VerifiedPermissions.Model;

#pragma warning disable CS1570
namespace Amazon.VerifiedPermissions
{
    /// <summary>
    /// <para>Interface for accessing VerifiedPermissions</para>
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
    /// For example, if user <c>jane</c> leaves the company, and you later let someone else
    /// use the name <c>jane</c>, then that new user automatically gets access to everything
    /// granted by policies that still reference <c>User::"jane"</c>. Cedar can’t distinguish
    /// between the new user and the old. This applies to both principal and resource identifiers.
    /// Always use identifiers that are guaranteed unique and never reused to ensure that
    /// you don’t unintentionally grant access because of the presence of an old identifier
    /// in a policy.
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
    /// Parameter type structures that end in <c>Detail</c> are used in <c>Get</c> operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Parameter type structures that end in <c>Item</c> are used in <c>List</c> operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Parameter type structures that use neither suffix are used in the mutating (create
    /// and update) operations.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonVerifiedPermissions : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IVerifiedPermissionsPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetPolicy



        /// <summary>
        /// Retrieves information about a group (batch) of policies.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchGetPolicy</c> operation doesn't have its own IAM permission. To authorize
        /// this operation for Amazon Web Services principals, include the permission <c>verifiedpermissions:GetPolicy</c>
        /// in their IAM policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPolicy service method, as returned by VerifiedPermissions.</returns>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/BatchGetPolicy">REST API Reference for BatchGetPolicy Operation</seealso>
        Task<BatchGetPolicyResponse> BatchGetPolicyAsync(BatchGetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchIsAuthorized



        /// <summary>
        /// Makes a series of decisions about multiple authorization requests for one principal
        /// or resource. Each request contains the equivalent content of an <c>IsAuthorized</c>
        /// request: principal, action, resource, and context. Either the <c>principal</c> or
        /// the <c>resource</c> parameter must be identical across all requests. For example,
        /// Verified Permissions won't evaluate a pair of requests where <c>bob</c> views <c>photo1</c>
        /// and <c>alice</c> views <c>photo2</c>. Authorization of <c>bob</c> to view <c>photo1</c>
        /// and <c>photo2</c>, or <c>bob</c> and <c>alice</c> to view <c>photo1</c>, are valid
        /// batches. 
        /// 
        ///  
        /// <para>
        /// The request is evaluated against all policies in the specified policy store that match
        /// the entities that you declare. The result of the decisions is a series of <c>Allow</c>
        /// or <c>Deny</c> responses, along with the IDs of the policies that produced each decision.
        /// </para>
        ///  
        /// <para>
        /// The <c>entities</c> of a <c>BatchIsAuthorized</c> API request can contain up to 100
        /// principals and up to 100 resources. The <c>requests</c> of a <c>BatchIsAuthorized</c>
        /// API request can contain up to 30 requests.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>BatchIsAuthorized</c> operation doesn't have its own IAM permission. To authorize
        /// this operation for Amazon Web Services principals, include the permission <c>verifiedpermissions:IsAuthorized</c>
        /// in their IAM policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchIsAuthorized service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchIsAuthorized service method, as returned by VerifiedPermissions.</returns>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/BatchIsAuthorized">REST API Reference for BatchIsAuthorized Operation</seealso>
        Task<BatchIsAuthorizedResponse> BatchIsAuthorizedAsync(BatchIsAuthorizedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchIsAuthorizedWithToken



        /// <summary>
        /// Makes a series of decisions about multiple authorization requests for one token. The
        /// principal in this request comes from an external identity source in the form of an
        /// identity or access token, formatted as a <a href="https://wikipedia.org/wiki/JSON_Web_Token">JSON
        /// web token (JWT)</a>. The information in the parameters can also define additional
        /// context that Verified Permissions can include in the evaluations.
        /// 
        ///  
        /// <para>
        /// The request is evaluated against all policies in the specified policy store that match
        /// the entities that you provide in the entities declaration and in the token. The result
        /// of the decisions is a series of <c>Allow</c> or <c>Deny</c> responses, along with
        /// the IDs of the policies that produced each decision.
        /// </para>
        ///  
        /// <para>
        /// The <c>entities</c> of a <c>BatchIsAuthorizedWithToken</c> API request can contain
        /// up to 100 resources and up to 99 user groups. The <c>requests</c> of a <c>BatchIsAuthorizedWithToken</c>
        /// API request can contain up to 30 requests.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>BatchIsAuthorizedWithToken</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>verifiedpermissions:IsAuthorizedWithToken</c> in their IAM policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchIsAuthorizedWithToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchIsAuthorizedWithToken service method, as returned by VerifiedPermissions.</returns>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/BatchIsAuthorizedWithToken">REST API Reference for BatchIsAuthorizedWithToken Operation</seealso>
        Task<BatchIsAuthorizedWithTokenResponse> BatchIsAuthorizedWithTokenAsync(BatchIsAuthorizedWithTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIdentitySource



        /// <summary>
        /// Adds an identity source to a policy store–an Amazon Cognito user pool or OpenID Connect
        /// (OIDC) identity provider (IdP). 
        /// 
        ///  
        /// <para>
        /// After you create an identity source, you can use the identities provided by the IdP
        /// as proxies for the principal in authorization queries that use the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
        /// or <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_BatchIsAuthorizedWithToken.html">BatchIsAuthorizedWithToken</a>
        /// API operations. These identities take the form of tokens that contain claims about
        /// the user, such as IDs, attributes and group memberships. Identity sources provide
        /// identity (ID) tokens and access tokens. Verified Permissions derives information about
        /// your user and session from token claims. Access tokens provide action <c>context</c>
        /// to your policies, and ID tokens provide principal <c>Attributes</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens from an identity source user continue to be usable until they expire. Token
        /// revocation and resource deletion have no effect on the validity of a token in your
        /// policy store
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// To reference a user from this identity source in your Cedar policies, refer to the
        /// following syntax examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Cognito user pool: <c>Namespace::[Entity type]::[User pool ID]|[user principal
        /// attribute]</c>, for example <c>MyCorp::User::us-east-1_EXAMPLE|a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OpenID Connect (OIDC) provider: <c>Namespace::[Entity type]::[entityIdPrefix]|[user
        /// principal attribute]</c>, for example <c>MyCorp::User::MyOIDCProvider|a1b2c3d4-5678-90ab-cdef-EXAMPLE22222</c>.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<CreateIdentitySourceResponse> CreateIdentitySourceAsync(CreateIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePolicy



        /// <summary>
        /// Creates a Cedar policy and saves it in the specified policy store. You can create
        /// either a static policy or a policy linked to a policy template.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To create a static policy, provide the Cedar policy text in the <c>StaticPolicy</c>
        /// section of the <c>PolicyDefinition</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a policy that is dynamically linked to a policy template, specify the policy
        /// template ID and the principal and resource to associate with this policy in the <c>templateLinked</c>
        /// section of the <c>PolicyDefinition</c>. If the policy template is ever updated, any
        /// policies linked to the policy template automatically use the updated template.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Creating a policy causes it to be validated against the schema in the policy store.
        /// If the policy doesn't pass validation, the operation fails and the policy isn't stored.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePolicyStore



        /// <summary>
        /// Creates a policy store. A policy store is a container for policy resources.
        /// 
        ///  <note> 
        /// <para>
        /// Although <a href="https://docs.cedarpolicy.com/schema/schema.html#namespace">Cedar
        /// supports multiple namespaces</a>, Verified Permissions currently supports only one
        /// namespace per policy store.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
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
        /// <exception cref="Amazon.VerifiedPermissions.Model.ConflictException">
        /// The request failed because another request to modify a resource occurred at the same.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<CreatePolicyStoreResponse> CreatePolicyStoreAsync(CreatePolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePolicyTemplate



        /// <summary>
        /// Creates a policy template. A template can use placeholders for the principal and resource.
        /// A template must be instantiated into a policy by associating it with specific principals
        /// and resources to use for the placeholders. That instantiated policy can then be considered
        /// in authorization decisions. The instantiated policy works identically to any other
        /// policy, except that it is dynamically linked to the template. If the template changes,
        /// then any policies that are linked to that template are immediately updated as well.
        /// 
        ///  <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
        /// </para>
        ///  </note>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<CreatePolicyTemplateResponse> CreatePolicyTemplateAsync(CreatePolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<DeleteIdentitySourceResponse> DeleteIdentitySourceAsync(DeleteIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePolicy



        /// <summary>
        /// Deletes the specified policy from the policy store.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; if you specify a policy that doesn't exist, the request
        /// response returns a successful <c>HTTP 200</c> status code.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.VerifiedPermissions.Model.InvalidStateException">
        /// The policy store can't be deleted because deletion protection is enabled. To delete
        /// this policy store, disable deletion protection.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<DeletePolicyStoreResponse> DeletePolicyStoreAsync(DeletePolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<DeletePolicyTemplateResponse> DeletePolicyTemplateAsync(DeletePolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIdentitySource



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<GetIdentitySourceResponse> GetIdentitySourceAsync(GetIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicy



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicyStore



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<GetPolicyStoreResponse> GetPolicyStoreAsync(GetPolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicyTemplate



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<GetPolicyTemplateResponse> GetPolicyTemplateAsync(GetPolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSchema



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<GetSchemaResponse> GetSchemaAsync(GetSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  IsAuthorized



        /// <summary>
        /// Makes an authorization decision about a service request described in the parameters.
        /// The information in the parameters can also define additional context that Verified
        /// Permissions can include in the evaluation. The request is evaluated against all matching
        /// policies in the specified policy store. The result of the decision is either <c>Allow</c>
        /// or <c>Deny</c>, along with a list of the policies that resulted in the decision.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<IsAuthorizedResponse> IsAuthorizedAsync(IsAuthorizedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  IsAuthorizedWithToken



        /// <summary>
        /// Makes an authorization decision about a service request described in the parameters.
        /// The principal in this request comes from an external identity source in the form of
        /// an identity token formatted as a <a href="https://wikipedia.org/wiki/JSON_Web_Token">JSON
        /// web token (JWT)</a>. The information in the parameters can also define additional
        /// context that Verified Permissions can include in the evaluation. The request is evaluated
        /// against all matching policies in the specified policy store. The result of the decision
        /// is either <c>Allow</c> or <c>Deny</c>, along with a list of the policies that resulted
        /// in the decision.
        /// 
        ///  
        /// <para>
        /// Verified Permissions validates each token that is specified in a request by checking
        /// its expiration date and its signature.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens from an identity source user continue to be usable until they expire. Token
        /// revocation and resource deletion have no effect on the validity of a token in your
        /// policy store
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<IsAuthorizedWithTokenResponse> IsAuthorizedWithTokenAsync(IsAuthorizedWithTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdentitySources



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<ListIdentitySourcesResponse> ListIdentitySourcesAsync(ListIdentitySourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicies



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicyStores



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<ListPolicyStoresResponse> ListPolicyStoresAsync(ListPolicyStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicyTemplates



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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<ListPolicyTemplatesResponse> ListPolicyTemplatesAsync(ListPolicyTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns the tags associated with the specified Amazon Verified Permissions resource.
        /// In Verified Permissions, policy stores can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by VerifiedPermissions.</returns>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutSchema



        /// <summary>
        /// Creates or updates the policy schema in the specified policy store. The schema is
        /// used to validate any Cedar policies and policy templates submitted to the policy store.
        /// Any changes to the schema validate only policies and templates submitted after the
        /// schema change. Existing policies and templates are not re-evaluated against the changed
        /// schema. If you later update a policy, then it is evaluated against the new schema
        /// at that time.
        /// 
        ///  <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
        /// </para>
        ///  </note>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<PutSchemaResponse> PutSchemaAsync(PutSchemaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Amazon Verified Permissions
        /// resource. Tags can help you organize and categorize your resources. You can also use
        /// them to scope user permissions by granting a user permission to access or change only
        /// resources with certain tag values. In Verified Permissions, policy stores can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the TagResource action with a resource that already has tags. If you specify
        /// a new tag key, this tag is appended to the list of tags associated with the resource.
        /// If you specify a tag key that is already associated with the resource, the new tag
        /// value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by VerifiedPermissions.</returns>
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
        /// <exception cref="Amazon.VerifiedPermissions.Model.TooManyTagsException">
        /// No more tags be added because the limit (50) has been reached. To add new tags, use
        /// <c>UntagResource</c> to remove existing tags.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from the specified Amazon Verified Permissions resource.
        /// In Verified Permissions, policy stores can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by VerifiedPermissions.</returns>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIdentitySource



        /// <summary>
        /// Updates the specified identity source to use a new identity provider (IdP), or to
        /// change the mapping of identities from the IdP to a different principal entity type.
        /// 
        ///  <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
        /// </para>
        ///  </note>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<UpdateIdentitySourceResponse> UpdateIdentitySourceAsync(UpdateIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePolicy



        /// <summary>
        /// Modifies a Cedar static policy in the specified policy store. You can change only
        /// certain elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyInput.html#amazonverifiedpermissions-UpdatePolicy-request-UpdatePolicyDefinition">UpdatePolicyDefinition</a>
        /// parameter. You can directly update only static policies. To change a template-linked
        /// policy, you must update the template instead, using <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html">UpdatePolicyTemplate</a>.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// If policy validation is enabled in the policy store, then updating a static policy
        /// causes Verified Permissions to validate the policy against the schema in the policy
        /// store. If the updated static policy doesn't pass validation, the operation fails and
        /// the update isn't stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you edit a static policy, you can change only certain elements of a static policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The action referenced by the policy. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A condition clause, such as when and unless. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't change these elements of a static policy: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changing a policy from a static policy to a template-linked policy. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Changing the effect of a static policy from permit or forbid. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The principal referenced by a static policy. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resource referenced by a static policy. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// To update a template-linked policy, you must update the template instead. 
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePolicyStore



        /// <summary>
        /// Modifies the validation setting for a policy store.
        /// 
        ///  <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
        /// </para>
        ///  </note>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<UpdatePolicyStoreResponse> UpdatePolicyStoreAsync(UpdatePolicyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePolicyTemplate



        /// <summary>
        /// Updates the specified policy template. You can update only the description and the
        /// some elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html#amazonverifiedpermissions-UpdatePolicyTemplate-request-policyBody">policyBody</a>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// Changes you make to the policy template content are immediately (within the constraints
        /// of eventual consistency) reflected in authorization decisions that involve all template-linked
        /// policies instantiated from this template.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
        /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
        /// through the service and be visible in the results of other Verified Permissions operations.
        /// </para>
        ///  </note>
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
        /// The types of elements included in a <c>set</c>, or the types of expressions used in
        /// an <c>if...then...else</c> clause aren't compatible in this context.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MissingAttribute</b> 
        /// </para>
        ///  
        /// <para>
        /// The policy attempts to access a record or entity attribute that isn't specified in
        /// the schema. Test for the existence of the attribute first before attempting to access
        /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
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
        Task<UpdatePolicyTemplateResponse> UpdatePolicyTemplateAsync(UpdatePolicyTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonVerifiedPermissionsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonVerifiedPermissionsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonVerifiedPermissionsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonVerifiedPermissionsConfig to create AmazonVerifiedPermissionsClient");
            }

            return awsCredentials == null ? 
                    new AmazonVerifiedPermissionsClient(serviceClientConfig) :
                    new AmazonVerifiedPermissionsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}