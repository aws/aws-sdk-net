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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.VerifiedPermissions.Model;

namespace Amazon.VerifiedPermissions
{
    /// <summary>
    /// Interface for accessing VerifiedPermissions
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
    public partial interface IAmazonVerifiedPermissions : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IVerifiedPermissionsPaginatorFactory Paginators { get; }
#endif


        
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
        CreateIdentitySourceResponse CreateIdentitySource(CreateIdentitySourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentitySource operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdentitySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        IAsyncResult BeginCreateIdentitySource(CreateIdentitySourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentitySource.</param>
        /// 
        /// <returns>Returns a  CreateIdentitySourceResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        CreateIdentitySourceResponse EndCreateIdentitySource(IAsyncResult asyncResult);

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
        CreatePolicyResponse CreatePolicy(CreatePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        IAsyncResult BeginCreatePolicy(CreatePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicy.</param>
        /// 
        /// <returns>Returns a  CreatePolicyResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse EndCreatePolicy(IAsyncResult asyncResult);

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
        CreatePolicyStoreResponse CreatePolicyStore(CreatePolicyStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyStore operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicyStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyStore">REST API Reference for CreatePolicyStore Operation</seealso>
        IAsyncResult BeginCreatePolicyStore(CreatePolicyStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicyStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicyStore.</param>
        /// 
        /// <returns>Returns a  CreatePolicyStoreResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyStore">REST API Reference for CreatePolicyStore Operation</seealso>
        CreatePolicyStoreResponse EndCreatePolicyStore(IAsyncResult asyncResult);

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
        CreatePolicyTemplateResponse CreatePolicyTemplate(CreatePolicyTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyTemplate operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicyTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyTemplate">REST API Reference for CreatePolicyTemplate Operation</seealso>
        IAsyncResult BeginCreatePolicyTemplate(CreatePolicyTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicyTemplate.</param>
        /// 
        /// <returns>Returns a  CreatePolicyTemplateResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/CreatePolicyTemplate">REST API Reference for CreatePolicyTemplate Operation</seealso>
        CreatePolicyTemplateResponse EndCreatePolicyTemplate(IAsyncResult asyncResult);

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
        DeleteIdentitySourceResponse DeleteIdentitySource(DeleteIdentitySourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentitySource operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentitySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        IAsyncResult BeginDeleteIdentitySource(DeleteIdentitySourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentitySource.</param>
        /// 
        /// <returns>Returns a  DeleteIdentitySourceResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        DeleteIdentitySourceResponse EndDeleteIdentitySource(IAsyncResult asyncResult);

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
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult);

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
        DeletePolicyStoreResponse DeletePolicyStore(DeletePolicyStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStore operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyStore">REST API Reference for DeletePolicyStore Operation</seealso>
        IAsyncResult BeginDeletePolicyStore(DeletePolicyStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyStore.</param>
        /// 
        /// <returns>Returns a  DeletePolicyStoreResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyStore">REST API Reference for DeletePolicyStore Operation</seealso>
        DeletePolicyStoreResponse EndDeletePolicyStore(IAsyncResult asyncResult);

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
        DeletePolicyTemplateResponse DeletePolicyTemplate(DeletePolicyTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyTemplate operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyTemplate">REST API Reference for DeletePolicyTemplate Operation</seealso>
        IAsyncResult BeginDeletePolicyTemplate(DeletePolicyTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyTemplate.</param>
        /// 
        /// <returns>Returns a  DeletePolicyTemplateResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/DeletePolicyTemplate">REST API Reference for DeletePolicyTemplate Operation</seealso>
        DeletePolicyTemplateResponse EndDeletePolicyTemplate(IAsyncResult asyncResult);

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
        GetIdentitySourceResponse GetIdentitySource(GetIdentitySourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentitySource operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentitySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        IAsyncResult BeginGetIdentitySource(GetIdentitySourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentitySource.</param>
        /// 
        /// <returns>Returns a  GetIdentitySourceResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        GetIdentitySourceResponse EndGetIdentitySource(IAsyncResult asyncResult);

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
        GetPolicyResponse GetPolicy(GetPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult);

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
        GetPolicyStoreResponse GetPolicyStore(GetPolicyStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyStore operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyStore">REST API Reference for GetPolicyStore Operation</seealso>
        IAsyncResult BeginGetPolicyStore(GetPolicyStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyStore.</param>
        /// 
        /// <returns>Returns a  GetPolicyStoreResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyStore">REST API Reference for GetPolicyStore Operation</seealso>
        GetPolicyStoreResponse EndGetPolicyStore(IAsyncResult asyncResult);

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
        GetPolicyTemplateResponse GetPolicyTemplate(GetPolicyTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyTemplate operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyTemplate">REST API Reference for GetPolicyTemplate Operation</seealso>
        IAsyncResult BeginGetPolicyTemplate(GetPolicyTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyTemplate.</param>
        /// 
        /// <returns>Returns a  GetPolicyTemplateResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetPolicyTemplate">REST API Reference for GetPolicyTemplate Operation</seealso>
        GetPolicyTemplateResponse EndGetPolicyTemplate(IAsyncResult asyncResult);

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
        GetSchemaResponse GetSchema(GetSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchema operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetSchema">REST API Reference for GetSchema Operation</seealso>
        IAsyncResult BeginGetSchema(GetSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchema.</param>
        /// 
        /// <returns>Returns a  GetSchemaResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/GetSchema">REST API Reference for GetSchema Operation</seealso>
        GetSchemaResponse EndGetSchema(IAsyncResult asyncResult);

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
        IsAuthorizedResponse IsAuthorized(IsAuthorizedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IsAuthorized operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsAuthorized operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIsAuthorized
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorized">REST API Reference for IsAuthorized Operation</seealso>
        IAsyncResult BeginIsAuthorized(IsAuthorizedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IsAuthorized operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIsAuthorized.</param>
        /// 
        /// <returns>Returns a  IsAuthorizedResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorized">REST API Reference for IsAuthorized Operation</seealso>
        IsAuthorizedResponse EndIsAuthorized(IAsyncResult asyncResult);

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
        IsAuthorizedWithTokenResponse IsAuthorizedWithToken(IsAuthorizedWithTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IsAuthorizedWithToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsAuthorizedWithToken operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIsAuthorizedWithToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorizedWithToken">REST API Reference for IsAuthorizedWithToken Operation</seealso>
        IAsyncResult BeginIsAuthorizedWithToken(IsAuthorizedWithTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IsAuthorizedWithToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIsAuthorizedWithToken.</param>
        /// 
        /// <returns>Returns a  IsAuthorizedWithTokenResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/IsAuthorizedWithToken">REST API Reference for IsAuthorizedWithToken Operation</seealso>
        IsAuthorizedWithTokenResponse EndIsAuthorizedWithToken(IAsyncResult asyncResult);

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
        ListIdentitySourcesResponse ListIdentitySources(ListIdentitySourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentitySources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentitySources operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentitySources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        IAsyncResult BeginListIdentitySources(ListIdentitySourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentitySources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentitySources.</param>
        /// 
        /// <returns>Returns a  ListIdentitySourcesResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        ListIdentitySourcesResponse EndListIdentitySources(IAsyncResult asyncResult);

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
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        IAsyncResult BeginListPolicies(ListPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicies.</param>
        /// 
        /// <returns>Returns a  ListPoliciesResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult);

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
        ListPolicyStoresResponse ListPolicyStores(ListPolicyStoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyStores operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyStores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyStores">REST API Reference for ListPolicyStores Operation</seealso>
        IAsyncResult BeginListPolicyStores(ListPolicyStoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyStores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyStores.</param>
        /// 
        /// <returns>Returns a  ListPolicyStoresResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyStores">REST API Reference for ListPolicyStores Operation</seealso>
        ListPolicyStoresResponse EndListPolicyStores(IAsyncResult asyncResult);

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
        ListPolicyTemplatesResponse ListPolicyTemplates(ListPolicyTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyTemplates operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyTemplates">REST API Reference for ListPolicyTemplates Operation</seealso>
        IAsyncResult BeginListPolicyTemplates(ListPolicyTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyTemplates.</param>
        /// 
        /// <returns>Returns a  ListPolicyTemplatesResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/ListPolicyTemplates">REST API Reference for ListPolicyTemplates Operation</seealso>
        ListPolicyTemplatesResponse EndListPolicyTemplates(IAsyncResult asyncResult);

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
        PutSchemaResponse PutSchema(PutSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSchema operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/PutSchema">REST API Reference for PutSchema Operation</seealso>
        IAsyncResult BeginPutSchema(PutSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSchema.</param>
        /// 
        /// <returns>Returns a  PutSchemaResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/PutSchema">REST API Reference for PutSchema Operation</seealso>
        PutSchemaResponse EndPutSchema(IAsyncResult asyncResult);

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
        UpdateIdentitySourceResponse UpdateIdentitySource(UpdateIdentitySourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentitySource operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdentitySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdateIdentitySource">REST API Reference for UpdateIdentitySource Operation</seealso>
        IAsyncResult BeginUpdateIdentitySource(UpdateIdentitySourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdentitySource.</param>
        /// 
        /// <returns>Returns a  UpdateIdentitySourceResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdateIdentitySource">REST API Reference for UpdateIdentitySource Operation</seealso>
        UpdateIdentitySourceResponse EndUpdateIdentitySource(IAsyncResult asyncResult);

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
        UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        IAsyncResult BeginUpdatePolicy(UpdatePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePolicy.</param>
        /// 
        /// <returns>Returns a  UpdatePolicyResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        UpdatePolicyResponse EndUpdatePolicy(IAsyncResult asyncResult);

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
        UpdatePolicyStoreResponse UpdatePolicyStore(UpdatePolicyStoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyStore operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePolicyStore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyStore">REST API Reference for UpdatePolicyStore Operation</seealso>
        IAsyncResult BeginUpdatePolicyStore(UpdatePolicyStoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePolicyStore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePolicyStore.</param>
        /// 
        /// <returns>Returns a  UpdatePolicyStoreResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyStore">REST API Reference for UpdatePolicyStore Operation</seealso>
        UpdatePolicyStoreResponse EndUpdatePolicyStore(IAsyncResult asyncResult);

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
        UpdatePolicyTemplateResponse UpdatePolicyTemplate(UpdatePolicyTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicyTemplate operation on AmazonVerifiedPermissionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePolicyTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyTemplate">REST API Reference for UpdatePolicyTemplate Operation</seealso>
        IAsyncResult BeginUpdatePolicyTemplate(UpdatePolicyTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePolicyTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePolicyTemplate.</param>
        /// 
        /// <returns>Returns a  UpdatePolicyTemplateResult from VerifiedPermissions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/verifiedpermissions-2021-12-01/UpdatePolicyTemplate">REST API Reference for UpdatePolicyTemplate Operation</seealso>
        UpdatePolicyTemplateResponse EndUpdatePolicyTemplate(IAsyncResult asyncResult);

        #endregion
        
    }
}