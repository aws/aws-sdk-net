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

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Interface for accessing AmazonIdentityManagementService.
    ///  
    ///  AWS Identity and Access Management <para>AWS Identity and Access Management (IAM) is a web service that you can use to manage users and user
    /// permissions under your AWS account. This guide provides descriptions of the IAM API. For general information about IAM, see <a
    /// href="http://aws.amazon.com/iam/" >AWS Identity and Access Management (IAM)</a> . For the user guide for IAM, see <a
    /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/" >Using IAM</a> . </para> <para><b>NOTE:</b> AWS provides SDKs that consist of
    /// libraries and sample code for various programming languages and platforms (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to IAM and AWS. For example, the SDKs take care of tasks such as cryptographically signing
    /// requests (see below), managing errors, and retrying requests automatically. For information about the AWS SDKs, including how to download
    /// and install them, see the Tools for Amazon Web Services page. </para> <para> Using the IAM Query API, you make direct calls to the IAM web
    /// service. IAM supports GET and POST requests for all actions. That is, the API does not require you to use GET for some actions and POST for
    /// others. However, GET requests are subject to the limitation size of a URL; although this limit is browser dependent, a typical limit is 2048
    /// bytes. Therefore, for operations that require larger sizes, you must use a POST request. </para> <para> <b>Signing Requests</b> Requests
    /// must be signed using an access key ID and a secret access key. We strongly recommend that you do not use your AWS account access key ID and
    /// secret access key for everyday work with IAM. You can use the access key ID and secret access key for an IAM user or you can use the AWS
    /// Security Token Service to generate temporary security credentials and use those to sign requests.</para> <para>To sign requests, we
    /// recommend that you use <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html" >Signature Version 4</a> . If you
    /// have an existing application that uses Signature Version 2, you do not have to update it to use Signature Version 4. However, some
    /// operations now require Signature Version 4. The documentation for operations that require version 4 indicate this requirement. </para>
    /// <para> <b>Additional Resources</b> For more information, see the following:</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html" >AWS Security Credentials</a> . This topic
    /// provides general information about the types of credentials used for accessing AWS.</li>
    /// <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html" >IAM Best Practices</a> . This topic presents a list
    /// of suggestions for using the IAM service to help secure your AWS resources.</li>
    /// <li> <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/" >AWS Security Token Service</a> . This guide describes how to create and use
    /// temporary security credentials.</li>
    /// <li> <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" >Signing AWS API Requests</a> . This set of
    /// topics walk you through the process of signing a request using an access key ID and secret access key.</li>
    /// 
    /// </ul>
    /// </summary>
    public partial interface IAmazonIdentityManagementService : IDisposable
    {


        #region AddRoleToInstanceProfile

        /// <summary>
        /// <para>Adds the specified role to the specified instance profile. For more information about roles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> . For more information about instance
        /// profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html" >About Instance Profiles</a> .</para>
        /// </summary>
        /// 
        /// <param name="addRoleToInstanceProfileRequest">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest addRoleToInstanceProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.AddRoleToInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="addRoleToInstanceProfileRequest">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAddRoleToInstanceProfile(AddRoleToInstanceProfileRequest addRoleToInstanceProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.AddRoleToInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToInstanceProfile.</param>
        AddRoleToInstanceProfileResponse EndAddRoleToInstanceProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AddUserToGroup

        /// <summary>
        /// <para>Adds the specified user to the specified group.</para>
        /// </summary>
        /// 
        /// <param name="addUserToGroupRequest">Container for the necessary parameters to execute the AddUserToGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest addUserToGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.AddUserToGroup"/>
        /// </summary>
        /// 
        /// <param name="addUserToGroupRequest">Container for the necessary parameters to execute the AddUserToGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAddUserToGroup(AddUserToGroupRequest addUserToGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.AddUserToGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUserToGroup.</param>
        AddUserToGroupResponse EndAddUserToGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ChangePassword

        /// <summary>
        /// <para>Changes the password of the IAM user calling <c>ChangePassword</c> . The root account password is not affected by this action. For
        /// information about modifying passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html" >Managing
        /// Passwords</a> .</para>
        /// </summary>
        /// 
        /// <param name="changePasswordRequest">Container for the necessary parameters to execute the ChangePassword service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InvalidUserTypeException"/>
        ChangePasswordResponse ChangePassword(ChangePasswordRequest changePasswordRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ChangePassword"/>
        /// </summary>
        /// 
        /// <param name="changePasswordRequest">Container for the necessary parameters to execute the ChangePassword operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginChangePassword(ChangePasswordRequest changePasswordRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ChangePassword"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateAccessKey

        /// <summary>
        /// <para>Creates a new AWS secret access key and corresponding AWS access key ID for the specified user. The default status for new keys is
        /// <c>Active</c> .</para> <para>If you do not specify a user name, IAM determines the user name implicitly based on the AWS access key ID
        /// signing the request. Because this action works for access keys under the AWS account, you can use this API to manage root credentials even
        /// if the AWS account has no associated users.</para> <para>For information about limits on the number of keys you can create, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>To ensure the security of your AWS account, the secret access key is
        /// accessible only during key and user creation. You must save the key (for example, in a text file) if you want to be able to access it again.
        /// If a secret key is lost, you can delete the access keys for the associated user and then create new keys.</para>
        /// </summary>
        /// 
        /// <param name="createAccessKeyRequest">Container for the necessary parameters to execute the CreateAccessKey service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest createAccessKeyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="createAccessKeyRequest">Container for the necessary parameters to execute the CreateAccessKey operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessKey
        ///         operation.</returns>
        IAsyncResult BeginCreateAccessKey(CreateAccessKeyRequest createAccessKeyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessKey.</param>
        /// 
        /// <returns>Returns a CreateAccessKeyResult from AmazonIdentityManagementService.</returns>
        CreateAccessKeyResponse EndCreateAccessKey(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Creates a new AWS secret access key and corresponding AWS access key ID for the specified user. The default status for new keys is
        /// <c>Active</c> .</para> <para>If you do not specify a user name, IAM determines the user name implicitly based on the AWS access key ID
        /// signing the request. Because this action works for access keys under the AWS account, you can use this API to manage root credentials even
        /// if the AWS account has no associated users.</para> <para>For information about limits on the number of keys you can create, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>To ensure the security of your AWS account, the secret access key is
        /// accessible only during key and user creation. You must save the key (for example, in a text file) if you want to be able to access it again.
        /// If a secret key is lost, you can delete the access keys for the associated user and then create new keys.</para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        CreateAccessKeyResponse CreateAccessKey();
        
        #endregion
        
    

        #region CreateAccountAlias

        /// <summary>
        /// <para>This action creates an alias for your AWS account. For information about using an AWS account alias, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html" >Using an Alias for Your AWS Account ID</a> in <i>Using AWS
        /// Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createAccountAliasRequest">Container for the necessary parameters to execute the CreateAccountAlias service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest createAccountAliasRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="createAccountAliasRequest">Container for the necessary parameters to execute the CreateAccountAlias operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateAccountAlias(CreateAccountAliasRequest createAccountAliasRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAlias.</param>
        CreateAccountAliasResponse EndCreateAccountAlias(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateGroup

        /// <summary>
        /// <para>Creates a new group.</para> <para>For information about the number of groups you can create, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createGroupRequest">Container for the necessary parameters to execute the CreateGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateGroupResponse CreateGroup(CreateGroupRequest createGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateGroup"/>
        /// </summary>
        /// 
        /// <param name="createGroupRequest">Container for the necessary parameters to execute the CreateGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateGroup(CreateGroupRequest createGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a CreateGroupResult from AmazonIdentityManagementService.</returns>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateInstanceProfile

        /// <summary>
        /// <para>Creates a new instance profile. For information about instance profiles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html" >About Instance Profiles</a> .</para> <para>For
        /// information about the number of instance profiles you can create, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createInstanceProfileRequest">Container for the necessary parameters to execute the CreateInstanceProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest createInstanceProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="createInstanceProfileRequest">Container for the necessary parameters to execute the CreateInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInstanceProfile operation.</returns>
        IAsyncResult BeginCreateInstanceProfile(CreateInstanceProfileRequest createInstanceProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a CreateInstanceProfileResult from AmazonIdentityManagementService.</returns>
        CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateLoginProfile

        /// <summary>
        /// <para>Creates a password for the specified user, giving the user the ability to access AWS services through the AWS Management Console. For
        /// more information about managing passwords, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_ManagingLogins.html" >Managing Passwords</a> in <i>Using IAM</i>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="createLoginProfileRequest">Container for the necessary parameters to execute the CreateLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="PasswordPolicyViolationException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest createLoginProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="createLoginProfileRequest">Container for the necessary parameters to execute the CreateLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateLoginProfile operation.</returns>
        IAsyncResult BeginCreateLoginProfile(CreateLoginProfileRequest createLoginProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoginProfile.</param>
        /// 
        /// <returns>Returns a CreateLoginProfileResult from AmazonIdentityManagementService.</returns>
        CreateLoginProfileResponse EndCreateLoginProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateRole

        /// <summary>
        /// <para>Creates a new role for your AWS account. For more information about roles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .
        /// For information about limitations on role names and the number of roles you can create, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para> <para>The policy grants permission to an EC2 instance to assume the role. The policy is
        /// URL-encoded according to RFC 3986. For more information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html"
        /// >http://www.faqs.org/rfcs/rfc3986.html</a> .
        /// Currently, only EC2 instances can assume roles.</para>
        /// </summary>
        /// 
        /// <param name="createRoleRequest">Container for the necessary parameters to execute the CreateRole service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateRoleResponse CreateRole(CreateRoleRequest createRoleRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateRole"/>
        /// </summary>
        /// 
        /// <param name="createRoleRequest">Container for the necessary parameters to execute the CreateRole operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRole
        ///         operation.</returns>
        IAsyncResult BeginCreateRole(CreateRoleRequest createRoleRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRole.</param>
        /// 
        /// <returns>Returns a CreateRoleResult from AmazonIdentityManagementService.</returns>
        CreateRoleResponse EndCreateRole(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateSAMLProvider

        /// <summary>
        /// <para>Creates an IAM entity to describe an identity provider (IdP) that supports SAML 2.0.</para> <para>The SAML provider that you create
        /// with this operation can be used as a principal in a role's trust policy to establish a trust relationship between AWS and a SAML identity
        /// provider. You can create an IAM role that supports Web-based single sign-on (SSO) to the AWS Management Console or one that supports API
        /// access to AWS. </para> <para>When you create the SAML provider, you upload an a SAML metadata document that you get from your IdP and that
        /// includes the issuer's name, expiration information, and keys that can be used to validate the SAML authentication response (assertions) that
        /// are received from the IdP. You must generate the metadata document using the identity management software that is used as your
        /// organization's IdP. </para> <para><b>NOTE:</b>This operation requires Signature Version 4.</para> <para>For more information, see <a
        /// href="http://aws-docs-alpha.integ.amazon.com/STS/latest/UsingSTS/STSMgmtConsole-SAML.html" >Giving Console Access Using SAML</a> and <a
        /// href="http://aws-docs-alpha.integ.amazon.com/STS/latest/UsingSTS/CreatingSAML.html" >Creating Temporary Security Credentials for SAML
        /// Federation</a> in the <i>Using Temporary Credentials</i> guide. </para>
        /// </summary>
        /// 
        /// <param name="createSAMLProviderRequest">Container for the necessary parameters to execute the CreateSAMLProvider service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateSAMLProvider service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest createSAMLProviderRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="createSAMLProviderRequest">Container for the necessary parameters to execute the CreateSAMLProvider operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateSAMLProvider operation.</returns>
        IAsyncResult BeginCreateSAMLProvider(CreateSAMLProviderRequest createSAMLProviderRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSAMLProvider.</param>
        /// 
        /// <returns>Returns a CreateSAMLProviderResult from AmazonIdentityManagementService.</returns>
        CreateSAMLProviderResponse EndCreateSAMLProvider(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateUser

        /// <summary>
        /// <para>Creates a new user for your AWS account.</para> <para>For information about limitations on the number of users you can create, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="createUserRequest">Container for the necessary parameters to execute the CreateUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateUserResponse CreateUser(CreateUserRequest createUserRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateUser"/>
        /// </summary>
        /// 
        /// <param name="createUserRequest">Container for the necessary parameters to execute the CreateUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        IAsyncResult BeginCreateUser(CreateUserRequest createUserRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a CreateUserResult from AmazonIdentityManagementService.</returns>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateVirtualMFADevice

        /// <summary>
        /// <para>Creates a new virtual MFA device for the AWS account. After creating the virtual MFA, use <a
        /// href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_EnableMFADevice.html" >EnableMFADevice</a> to attach the MFA device to an IAM
        /// user. For more information about creating and working with virtual MFA devices, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_VirtualMFA.html" >Using a Virtual MFA Device</a> in <i>Using AWS
        /// Identity and Access Management</i> .</para> <para>For information about limits on the number of MFA devices you can create, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on Entities</a> in <i>Using AWS
        /// Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>The seed information contained in the QR code and the Base32 string
        /// should be treated like any other secret access information, such as your AWS access keys or your passwords. After you provision your virtual
        /// device, you should ensure that the information is destroyed following secure procedures.</para>
        /// </summary>
        /// 
        /// <param name="createVirtualMFADeviceRequest">Container for the necessary parameters to execute the CreateVirtualMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="createVirtualMFADeviceRequest">Container for the necessary parameters to execute the CreateVirtualMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateVirtualMFADevice operation.</returns>
        IAsyncResult BeginCreateVirtualMFADevice(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.CreateVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a CreateVirtualMFADeviceResult from AmazonIdentityManagementService.</returns>
        CreateVirtualMFADeviceResponse EndCreateVirtualMFADevice(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeactivateMFADevice

        /// <summary>
        /// <para>Deactivates the specified MFA device and removes it from association with the user name for which it was originally enabled.</para>
        /// </summary>
        /// 
        /// <param name="deactivateMFADeviceRequest">Container for the necessary parameters to execute the DeactivateMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest deactivateMFADeviceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeactivateMFADevice"/>
        /// </summary>
        /// 
        /// <param name="deactivateMFADeviceRequest">Container for the necessary parameters to execute the DeactivateMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeactivateMFADevice(DeactivateMFADeviceRequest deactivateMFADeviceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeactivateMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMFADevice.</param>
        DeactivateMFADeviceResponse EndDeactivateMFADevice(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteAccessKey

        /// <summary>
        /// <para>Deletes the access key associated with the specified user.</para> <para>If you do not specify a user name, IAM determines the user
        /// name implicitly based on the AWS access key ID signing the request. Because this action works for access keys under the AWS account, you can
        /// use this API to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="deleteAccessKeyRequest">Container for the necessary parameters to execute the DeleteAccessKey service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccessKey"/>
        /// </summary>
        /// 
        /// <param name="deleteAccessKeyRequest">Container for the necessary parameters to execute the DeleteAccessKey operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteAccessKey(DeleteAccessKeyRequest deleteAccessKeyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccessKey"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessKey.</param>
        DeleteAccessKeyResponse EndDeleteAccessKey(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteAccountAlias

        /// <summary>
        /// <para>Deletes the specified AWS account alias. For information about using an AWS account alias, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html" >Using an Alias for Your AWS Account ID</a> in <i>Using AWS
        /// Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteAccountAliasRequest">Container for the necessary parameters to execute the DeleteAccountAlias service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest deleteAccountAliasRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="deleteAccountAliasRequest">Container for the necessary parameters to execute the DeleteAccountAlias operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteAccountAlias(DeleteAccountAliasRequest deleteAccountAliasRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccountAlias"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAlias.</param>
        DeleteAccountAliasResponse EndDeleteAccountAlias(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteAccountPasswordPolicy

        /// <summary>
        /// <para>Deletes the password policy for the AWS account.</para>
        /// </summary>
        /// 
        /// <param name="deleteAccountPasswordPolicyRequest">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service
        ///          method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest deleteAccountPasswordPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteAccountPasswordPolicyRequest">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation
        ///          on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest deleteAccountPasswordPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPasswordPolicy.</param>
        DeleteAccountPasswordPolicyResponse EndDeleteAccountPasswordPolicy(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Deletes the password policy for the AWS account.</para>
        /// </summary>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy();
        
        #endregion
        
    

        #region DeleteGroup

        /// <summary>
        /// <para>Deletes the specified group. The group must not contain any users or have any attached policies.</para>
        /// </summary>
        /// 
        /// <param name="deleteGroupRequest">Container for the necessary parameters to execute the DeleteGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest deleteGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteGroupRequest">Container for the necessary parameters to execute the DeleteGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest deleteGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteGroupPolicy

        /// <summary>
        /// <para>Deletes the specified policy that is associated with the specified group.</para>
        /// </summary>
        /// 
        /// <param name="deleteGroupPolicyRequest">Container for the necessary parameters to execute the DeleteGroupPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest deleteGroupPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteGroupPolicyRequest">Container for the necessary parameters to execute the DeleteGroupPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteGroupPolicy(DeleteGroupPolicyRequest deleteGroupPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupPolicy.</param>
        DeleteGroupPolicyResponse EndDeleteGroupPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteInstanceProfile

        /// <summary>
        /// <para>Deletes the specified instance profile. The instance profile must not have an associated role.</para> <para><b>IMPORTANT:</b>Make sure
        /// you do not have any Amazon EC2 instances running with the instance profile you are about to delete. Deleting a role or instance profile that
        /// is associated with a running instance will break any applications running on the instance.</para> <para>For more information about instance
        /// profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html" >About Instance Profiles</a> .</para>
        /// </summary>
        /// 
        /// <param name="deleteInstanceProfileRequest">Container for the necessary parameters to execute the DeleteInstanceProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest deleteInstanceProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="deleteInstanceProfileRequest">Container for the necessary parameters to execute the DeleteInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteInstanceProfile(DeleteInstanceProfileRequest deleteInstanceProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteLoginProfile

        /// <summary>
        /// <para>Deletes the password for the specified user, which terminates the user's ability to access AWS services through the AWS Management
        /// Console.</para> <para><b>IMPORTANT:</b>Deleting a user's password does not prevent a user from accessing IAM through the command line
        /// interface or the API. To prevent all user access you must also either make the access key inactive or delete it. For more information about
        /// making keys inactive or deleting them, see UpdateAccessKey and DeleteAccessKey. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoginProfileRequest">Container for the necessary parameters to execute the DeleteLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest deleteLoginProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="deleteLoginProfileRequest">Container for the necessary parameters to execute the DeleteLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteLoginProfile(DeleteLoginProfileRequest deleteLoginProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoginProfile.</param>
        DeleteLoginProfileResponse EndDeleteLoginProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteRole

        /// <summary>
        /// <para>Deletes the specified role. The role must not have any policies attached. For more information about roles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .</para> <para><b>IMPORTANT:</b>Make
        /// sure you do not have any Amazon EC2 instances running with the role you are about to delete. Deleting a role or instance profile that is
        /// associated with a running instance will break any applications running on the instance.</para>
        /// </summary>
        /// 
        /// <param name="deleteRoleRequest">Container for the necessary parameters to execute the DeleteRole service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteRoleResponse DeleteRole(DeleteRoleRequest deleteRoleRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteRole"/>
        /// </summary>
        /// 
        /// <param name="deleteRoleRequest">Container for the necessary parameters to execute the DeleteRole operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteRole(DeleteRoleRequest deleteRoleRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRole.</param>
        DeleteRoleResponse EndDeleteRole(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteRolePolicy

        /// <summary>
        /// <para>Deletes the specified policy associated with the specified role.</para>
        /// </summary>
        /// 
        /// <param name="deleteRolePolicyRequest">Container for the necessary parameters to execute the DeleteRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest deleteRolePolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteRolePolicyRequest">Container for the necessary parameters to execute the DeleteRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteRolePolicy(DeleteRolePolicyRequest deleteRolePolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRolePolicy.</param>
        DeleteRolePolicyResponse EndDeleteRolePolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteSAMLProvider

        /// <summary>
        /// <para>Deletes a SAML provider.</para> <para>Deleting the provider does not update any roles that reference the SAML provider as a principal
        /// in their trust policies. Any attempt to assume a role that references a SAML provider that has been deleted will fail. </para>
        /// <para><b>NOTE:</b>This operation requires Signature Version 4.</para>
        /// </summary>
        /// 
        /// <param name="deleteSAMLProviderRequest">Container for the necessary parameters to execute the DeleteSAMLProvider service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="InvalidInputException"/>
        DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest deleteSAMLProviderRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="deleteSAMLProviderRequest">Container for the necessary parameters to execute the DeleteSAMLProvider operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteSAMLProvider(DeleteSAMLProviderRequest deleteSAMLProviderRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSAMLProvider.</param>
        DeleteSAMLProviderResponse EndDeleteSAMLProvider(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteServerCertificate

        /// <summary>
        /// <para>Deletes the specified server certificate.</para> <para><b>IMPORTANT:</b>If you are using a server certificate with Elastic Load
        /// Balancing, deleting the certificate could have implications for your application. If Elastic Load Balancing doesn't detect the deletion of
        /// bound certificates, it may continue to use the certificates. This could cause Elastic Load Balancing to stop accepting traffic. We recommend
        /// that you remove the reference to the certificate from Elastic Load Balancing before using this command to delete the certificate. For more
        /// information, go to DeleteLoadBalancerListeners in the Elastic Load Balancing API Reference.</para>
        /// </summary>
        /// 
        /// <param name="deleteServerCertificateRequest">Container for the necessary parameters to execute the DeleteServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest deleteServerCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="deleteServerCertificateRequest">Container for the necessary parameters to execute the DeleteServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteServerCertificate(DeleteServerCertificateRequest deleteServerCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCertificate.</param>
        DeleteServerCertificateResponse EndDeleteServerCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteSigningCertificate

        /// <summary>
        /// <para>Deletes the specified signing certificate associated with the specified user.</para> <para>If you do not specify a user name, IAM
        /// determines the user name implicitly based on the AWS access key ID signing the request. Because this action works for access keys under the
        /// AWS account, you can use this API to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="deleteSigningCertificateRequest">Container for the necessary parameters to execute the DeleteSigningCertificate service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest deleteSigningCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="deleteSigningCertificateRequest">Container for the necessary parameters to execute the DeleteSigningCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteSigningCertificate(DeleteSigningCertificateRequest deleteSigningCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSigningCertificate.</param>
        DeleteSigningCertificateResponse EndDeleteSigningCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteUser

        /// <summary>
        /// <para>Deletes the specified user. The user must not belong to any groups, have any keys or signing certificates, or have any attached
        /// policies.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserRequest">Container for the necessary parameters to execute the DeleteUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteUserResponse DeleteUser(DeleteUserRequest deleteUserRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteUser"/>
        /// </summary>
        /// 
        /// <param name="deleteUserRequest">Container for the necessary parameters to execute the DeleteUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteUser(DeleteUserRequest deleteUserRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteUserPolicy

        /// <summary>
        /// <para>Deletes the specified policy associated with the specified user.</para>
        /// </summary>
        /// 
        /// <param name="deleteUserPolicyRequest">Container for the necessary parameters to execute the DeleteUserPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest deleteUserPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteUserPolicyRequest">Container for the necessary parameters to execute the DeleteUserPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteUserPolicy(DeleteUserPolicyRequest deleteUserPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPolicy.</param>
        DeleteUserPolicyResponse EndDeleteUserPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteVirtualMFADevice

        /// <summary>
        /// <para>Deletes a virtual MFA device.</para> <para><b>NOTE:</b>You must deactivate a user's virtual MFA device before you can delete it. For
        /// information about deactivating MFA devices, see DeactivateMFADevice.</para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualMFADeviceRequest">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="DeleteConflictException"/>
        /// <exception cref="LimitExceededException"/>
        DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest deleteVirtualMFADeviceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="deleteVirtualMFADeviceRequest">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest deleteVirtualMFADeviceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.DeleteVirtualMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualMFADevice.</param>
        DeleteVirtualMFADeviceResponse EndDeleteVirtualMFADevice(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EnableMFADevice

        /// <summary>
        /// <para>Enables the specified MFA device and associates it with the specified user name. When enabled, the MFA device is required for every
        /// subsequent login by the user name associated with the device.</para>
        /// </summary>
        /// 
        /// <param name="enableMFADeviceRequest">Container for the necessary parameters to execute the EnableMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="InvalidAuthenticationCodeException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest enableMFADeviceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.EnableMFADevice"/>
        /// </summary>
        /// 
        /// <param name="enableMFADeviceRequest">Container for the necessary parameters to execute the EnableMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginEnableMFADevice(EnableMFADeviceRequest enableMFADeviceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.EnableMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMFADevice.</param>
        EnableMFADeviceResponse EndEnableMFADevice(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetAccountPasswordPolicy

        /// <summary>
        /// <para>Retrieves the password policy for the AWS account. For more information about using a password policy, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html" >Managing an IAM Password Policy</a> .</para>
        /// </summary>
        /// 
        /// <param name="getAccountPasswordPolicyRequest">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest getAccountPasswordPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="getAccountPasswordPolicyRequest">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetAccountPasswordPolicy operation.</returns>
        IAsyncResult BeginGetAccountPasswordPolicy(GetAccountPasswordPolicyRequest getAccountPasswordPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a GetAccountPasswordPolicyResult from AmazonIdentityManagementService.</returns>
        GetAccountPasswordPolicyResponse EndGetAccountPasswordPolicy(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Retrieves the password policy for the AWS account. For more information about using a password policy, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html" >Managing an IAM Password Policy</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetAccountPasswordPolicyResponse GetAccountPasswordPolicy();
        
        #endregion
        
    

        #region GetAccountSummary

        /// <summary>
        /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
        /// entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM
        /// Entities</a> in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="getAccountSummaryRequest">Container for the necessary parameters to execute the GetAccountSummary service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest getAccountSummaryRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetAccountSummary"/>
        /// </summary>
        /// 
        /// <param name="getAccountSummaryRequest">Container for the necessary parameters to execute the GetAccountSummary operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSummary
        ///         operation.</returns>
        IAsyncResult BeginGetAccountSummary(GetAccountSummaryRequest getAccountSummaryRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetAccountSummary"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSummary.</param>
        /// 
        /// <returns>Returns a GetAccountSummaryResult from AmazonIdentityManagementService.</returns>
        GetAccountSummaryResponse EndGetAccountSummary(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Retrieves account level information about account entity usage and IAM quotas.</para> <para>For information about limitations on IAM
        /// entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM
        /// Entities</a> in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        GetAccountSummaryResponse GetAccountSummary();
        
        #endregion
        
    

        #region GetGroup

        /// <summary>
        /// <para>Returns a list of users that are in the specified group. You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="getGroupRequest">Container for the necessary parameters to execute the GetGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetGroupResponse GetGroup(GetGroupRequest getGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetGroup"/>
        /// </summary>
        /// 
        /// <param name="getGroupRequest">Container for the necessary parameters to execute the GetGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        IAsyncResult BeginGetGroup(GetGroupRequest getGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a GetGroupResult from AmazonIdentityManagementService.</returns>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetGroupPolicy

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified group. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html" >http://www.faqs.org/rfcs/rfc3986.html</a> .</para>
        /// </summary>
        /// 
        /// <param name="getGroupPolicyRequest">Container for the necessary parameters to execute the GetGroupPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest getGroupPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="getGroupPolicyRequest">Container for the necessary parameters to execute the GetGroupPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetGroupPolicy(GetGroupPolicyRequest getGroupPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupPolicy.</param>
        /// 
        /// <returns>Returns a GetGroupPolicyResult from AmazonIdentityManagementService.</returns>
        GetGroupPolicyResponse EndGetGroupPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetInstanceProfile

        /// <summary>
        /// <para>Retrieves information about the specified instance profile, including the instance profile's path, GUID, ARN, and role. For more
        /// information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html" >About
        /// Instance Profiles</a> . For more information about ARNs, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs" >ARNs</a> .</para>
        /// </summary>
        /// 
        /// <param name="getInstanceProfileRequest">Container for the necessary parameters to execute the GetInstanceProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest getInstanceProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="getInstanceProfileRequest">Container for the necessary parameters to execute the GetInstanceProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetInstanceProfile operation.</returns>
        IAsyncResult BeginGetInstanceProfile(GetInstanceProfileRequest getInstanceProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceProfile.</param>
        /// 
        /// <returns>Returns a GetInstanceProfileResult from AmazonIdentityManagementService.</returns>
        GetInstanceProfileResponse EndGetInstanceProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetLoginProfile

        /// <summary>
        /// <para>Retrieves the user name and password-creation date for the specified user. If the user has not been assigned a password, the action
        /// returns a 404 ( <c>NoSuchEntity</c> ) error. </para>
        /// </summary>
        /// 
        /// <param name="getLoginProfileRequest">Container for the necessary parameters to execute the GetLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest getLoginProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="getLoginProfileRequest">Container for the necessary parameters to execute the GetLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoginProfile
        ///         operation.</returns>
        IAsyncResult BeginGetLoginProfile(GetLoginProfileRequest getLoginProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoginProfile.</param>
        /// 
        /// <returns>Returns a GetLoginProfileResult from AmazonIdentityManagementService.</returns>
        GetLoginProfileResponse EndGetLoginProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetRole

        /// <summary>
        /// <para>Retrieves information about the specified role, including the role's path, GUID, ARN, and the policy granting permission to EC2 to
        /// assume the role. For more information about ARNs, go to <a href="
        /// http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs" >ARNs</a> . For more information about roles, go to
        /// <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .</para> <para>The returned policy
        /// is URL-encoded according to RFC 3986. For more information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html"
        /// >http://www.faqs.org/rfcs/rfc3986.html</a> .</para>
        /// </summary>
        /// 
        /// <param name="getRoleRequest">Container for the necessary parameters to execute the GetRole service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetRoleResponse GetRole(GetRoleRequest getRoleRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetRole"/>
        /// </summary>
        /// 
        /// <param name="getRoleRequest">Container for the necessary parameters to execute the GetRole operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRole
        ///         operation.</returns>
        IAsyncResult BeginGetRole(GetRoleRequest getRoleRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRole.</param>
        /// 
        /// <returns>Returns a GetRoleResult from AmazonIdentityManagementService.</returns>
        GetRoleResponse EndGetRole(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetRolePolicy

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified role. For more information about roles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .</para> <para>The returned policy is
        /// URL-encoded according to RFC 3986. For more information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html"
        /// >http://www.faqs.org/rfcs/rfc3986.html</a> .</para>
        /// </summary>
        /// 
        /// <param name="getRolePolicyRequest">Container for the necessary parameters to execute the GetRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest getRolePolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="getRolePolicyRequest">Container for the necessary parameters to execute the GetRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRolePolicy
        ///         operation.</returns>
        IAsyncResult BeginGetRolePolicy(GetRolePolicyRequest getRolePolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRolePolicy.</param>
        /// 
        /// <returns>Returns a GetRolePolicyResult from AmazonIdentityManagementService.</returns>
        GetRolePolicyResponse EndGetRolePolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetSAMLProvider

        /// <summary>
        /// <para>Returns the SAML provider metadocument that was uploaded when the provider was created or updated.</para> <para><b>NOTE:</b>This
        /// operation requires Signature Version 4.</para>
        /// </summary>
        /// 
        /// <param name="getSAMLProviderRequest">Container for the necessary parameters to execute the GetSAMLProvider service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchEntityException"/>
        GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest getSAMLProviderRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="getSAMLProviderRequest">Container for the necessary parameters to execute the GetSAMLProvider operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSAMLProvider
        ///         operation.</returns>
        IAsyncResult BeginGetSAMLProvider(GetSAMLProviderRequest getSAMLProviderRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSAMLProvider.</param>
        /// 
        /// <returns>Returns a GetSAMLProviderResult from AmazonIdentityManagementService.</returns>
        GetSAMLProviderResponse EndGetSAMLProvider(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetServerCertificate

        /// <summary>
        /// <para>Retrieves information about the specified server certificate.</para>
        /// </summary>
        /// 
        /// <param name="getServerCertificateRequest">Container for the necessary parameters to execute the GetServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest getServerCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="getServerCertificateRequest">Container for the necessary parameters to execute the GetServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetServerCertificate operation.</returns>
        IAsyncResult BeginGetServerCertificate(GetServerCertificateRequest getServerCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerCertificate.</param>
        /// 
        /// <returns>Returns a GetServerCertificateResult from AmazonIdentityManagementService.</returns>
        GetServerCertificateResponse EndGetServerCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetUser

        /// <summary>
        /// <para>Retrieves information about the specified user, including the user's path, unique ID, and ARN.</para> <para>If you do not specify a
        /// user name, IAM determines the user name implicitly based on the AWS access key ID signing the request.</para>
        /// </summary>
        /// 
        /// <param name="getUserRequest">Container for the necessary parameters to execute the GetUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetUserResponse GetUser(GetUserRequest getUserRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetUser"/>
        /// </summary>
        /// 
        /// <param name="getUserRequest">Container for the necessary parameters to execute the GetUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        IAsyncResult BeginGetUser(GetUserRequest getUserRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a GetUserResult from AmazonIdentityManagementService.</returns>
        GetUserResponse EndGetUser(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Retrieves information about the specified user, including the user's path, unique ID, and ARN.</para> <para>If you do not specify a
        /// user name, IAM determines the user name implicitly based on the AWS access key ID signing the request.</para>
        /// </summary>
        /// 
        /// <returns>The response from the GetUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetUserResponse GetUser();
        
        #endregion
        
    

        #region GetUserPolicy

        /// <summary>
        /// <para>Retrieves the specified policy document for the specified user. The returned policy is URL-encoded according to RFC 3986. For more
        /// information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html" >http://www.faqs.org/rfcs/rfc3986.html</a> .</para>
        /// </summary>
        /// 
        /// <param name="getUserPolicyRequest">Container for the necessary parameters to execute the GetUserPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest getUserPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="getUserPolicyRequest">Container for the necessary parameters to execute the GetUserPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetUserPolicy(GetUserPolicyRequest getUserPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.GetUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPolicy.</param>
        /// 
        /// <returns>Returns a GetUserPolicyResult from AmazonIdentityManagementService.</returns>
        GetUserPolicyResponse EndGetUserPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListAccessKeys

        /// <summary>
        /// <para>Returns information about the access key IDs associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of keys, you can still paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based on the AWS
        /// access key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root
        /// credentials even if the AWS account has no associated users.</para> <para><b>NOTE:</b>To ensure the security of your AWS account, the secret
        /// access key is accessible only during key and user creation.</para>
        /// </summary>
        /// 
        /// <param name="listAccessKeysRequest">Container for the necessary parameters to execute the ListAccessKeys service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest listAccessKeysRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListAccessKeys"/>
        /// </summary>
        /// 
        /// <param name="listAccessKeysRequest">Container for the necessary parameters to execute the ListAccessKeys operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessKeys
        ///         operation.</returns>
        IAsyncResult BeginListAccessKeys(ListAccessKeysRequest listAccessKeysRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListAccessKeys"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessKeys.</param>
        /// 
        /// <returns>Returns a ListAccessKeysResult from AmazonIdentityManagementService.</returns>
        ListAccessKeysResponse EndListAccessKeys(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns information about the access key IDs associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of keys, you can still paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based on the AWS
        /// access key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root
        /// credentials even if the AWS account has no associated users.</para> <para><b>NOTE:</b>To ensure the security of your AWS account, the secret
        /// access key is accessible only during key and user creation.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListAccessKeysResponse ListAccessKeys();
        
        #endregion
        
    

        #region ListAccountAliases

        /// <summary>
        /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html" >Using an Alias for Your AWS Account ID</a> in <i>Using AWS
        /// Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="listAccountAliasesRequest">Container for the necessary parameters to execute the ListAccountAliases service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest listAccountAliasesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListAccountAliases"/>
        /// </summary>
        /// 
        /// <param name="listAccountAliasesRequest">Container for the necessary parameters to execute the ListAccountAliases operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListAccountAliases operation.</returns>
        IAsyncResult BeginListAccountAliases(ListAccountAliasesRequest listAccountAliasesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListAccountAliases"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAliases.</param>
        /// 
        /// <returns>Returns a ListAccountAliasesResult from AmazonIdentityManagementService.</returns>
        ListAccountAliasesResponse EndListAccountAliases(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the account aliases associated with the account. For information about using an AWS account alias, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html" >Using an Alias for Your AWS Account ID</a> in <i>Using AWS
        /// Identity and Access Management</i> .</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListAccountAliasesResponse ListAccountAliases();
        
        #endregion
        
    

        #region ListGroupPolicies

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified group. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupPoliciesRequest">Container for the necessary parameters to execute the ListGroupPolicies service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest listGroupPoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroupPolicies"/>
        /// </summary>
        /// 
        /// <param name="listGroupPoliciesRequest">Container for the necessary parameters to execute the ListGroupPolicies operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupPolicies
        ///         operation.</returns>
        IAsyncResult BeginListGroupPolicies(ListGroupPoliciesRequest listGroupPoliciesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroupPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupPolicies.</param>
        /// 
        /// <returns>Returns a ListGroupPoliciesResult from AmazonIdentityManagementService.</returns>
        ListGroupPoliciesResponse EndListGroupPolicies(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListGroups

        /// <summary>
        /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupsRequest">Container for the necessary parameters to execute the ListGroups service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListGroupsResponse ListGroups(ListGroupsRequest listGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroups"/>
        /// </summary>
        /// 
        /// <param name="listGroupsRequest">Container for the necessary parameters to execute the ListGroups operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        IAsyncResult BeginListGroups(ListGroupsRequest listGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a ListGroupsResult from AmazonIdentityManagementService.</returns>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the groups that have the specified path prefix.</para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListGroupsResponse ListGroups();
        
        #endregion
        
    

        #region ListGroupsForUser

        /// <summary>
        /// <para>Lists the groups the specified user belongs to.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
        /// parameters.</para>
        /// </summary>
        /// 
        /// <param name="listGroupsForUserRequest">Container for the necessary parameters to execute the ListGroupsForUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest listGroupsForUserRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroupsForUser"/>
        /// </summary>
        /// 
        /// <param name="listGroupsForUserRequest">Container for the necessary parameters to execute the ListGroupsForUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupsForUser
        ///         operation.</returns>
        IAsyncResult BeginListGroupsForUser(ListGroupsForUserRequest listGroupsForUserRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListGroupsForUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForUser.</param>
        /// 
        /// <returns>Returns a ListGroupsForUserResult from AmazonIdentityManagementService.</returns>
        ListGroupsForUserResponse EndListGroupsForUser(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListInstanceProfiles

        /// <summary>
        /// <para>Lists the instance profiles that have the specified path prefix. If there are none, the action returns an empty list. For more
        /// information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html" >About
        /// Instance Profiles</a> .</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesRequest">Container for the necessary parameters to execute the ListInstanceProfiles service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest listInstanceProfilesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListInstanceProfiles"/>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesRequest">Container for the necessary parameters to execute the ListInstanceProfiles operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListInstanceProfiles operation.</returns>
        IAsyncResult BeginListInstanceProfiles(ListInstanceProfilesRequest listInstanceProfilesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListInstanceProfiles"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfiles.</param>
        /// 
        /// <returns>Returns a ListInstanceProfilesResult from AmazonIdentityManagementService.</returns>
        ListInstanceProfilesResponse EndListInstanceProfiles(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the instance profiles that have the specified path prefix. If there are none, the action returns an empty list. For more
        /// information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html" >About
        /// Instance Profiles</a> .</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListInstanceProfilesResponse ListInstanceProfiles();
        
        #endregion
        
    

        #region ListInstanceProfilesForRole

        /// <summary>
        /// <para>Lists the instance profiles that have the specified associated role. If there are none, the action returns an empty list. For more
        /// information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html" >About
        /// Instance Profiles</a> .</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesForRoleRequest">Container for the necessary parameters to execute the ListInstanceProfilesForRole service
        ///          method on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest listInstanceProfilesForRoleRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListInstanceProfilesForRole"/>
        /// </summary>
        /// 
        /// <param name="listInstanceProfilesForRoleRequest">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation
        ///          on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListInstanceProfilesForRole operation.</returns>
        IAsyncResult BeginListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest listInstanceProfilesForRoleRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListInstanceProfilesForRole"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfilesForRole.</param>
        /// 
        /// <returns>Returns a ListInstanceProfilesForRoleResult from AmazonIdentityManagementService.</returns>
        ListInstanceProfilesForRoleResponse EndListInstanceProfilesForRole(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListMFADevices

        /// <summary>
        /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
        /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS access key ID signing the
        /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listMFADevicesRequest">Container for the necessary parameters to execute the ListMFADevices service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest listMFADevicesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListMFADevices"/>
        /// </summary>
        /// 
        /// <param name="listMFADevicesRequest">Container for the necessary parameters to execute the ListMFADevices operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMFADevices
        ///         operation.</returns>
        IAsyncResult BeginListMFADevices(ListMFADevicesRequest listMFADevicesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListMFADevices"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMFADevices.</param>
        /// 
        /// <returns>Returns a ListMFADevicesResult from AmazonIdentityManagementService.</returns>
        ListMFADevicesResponse EndListMFADevices(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the MFA devices. If the request includes the user name, then this action lists all the MFA devices associated with the specified
        /// user name. If you do not specify a user name, IAM determines the user name implicitly based on the AWS access key ID signing the
        /// request.</para> <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListMFADevicesResponse ListMFADevices();
        
        #endregion
        
    

        #region ListRolePolicies

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified role. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listRolePoliciesRequest">Container for the necessary parameters to execute the ListRolePolicies service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest listRolePoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListRolePolicies"/>
        /// </summary>
        /// 
        /// <param name="listRolePoliciesRequest">Container for the necessary parameters to execute the ListRolePolicies operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRolePolicies
        ///         operation.</returns>
        IAsyncResult BeginListRolePolicies(ListRolePoliciesRequest listRolePoliciesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListRolePolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRolePolicies.</param>
        /// 
        /// <returns>Returns a ListRolePoliciesResult from AmazonIdentityManagementService.</returns>
        ListRolePoliciesResponse EndListRolePolicies(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListRoles

        /// <summary>
        /// <para>Lists the roles that have the specified path prefix. If there are none, the action returns an empty list. For more information about
        /// roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>The returned policy is URL-encoded according to
        /// RFC 3986. For more information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html"
        /// >http://www.faqs.org/rfcs/rfc3986.html</a> .</para>
        /// </summary>
        /// 
        /// <param name="listRolesRequest">Container for the necessary parameters to execute the ListRoles service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListRolesResponse ListRoles(ListRolesRequest listRolesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListRoles"/>
        /// </summary>
        /// 
        /// <param name="listRolesRequest">Container for the necessary parameters to execute the ListRoles operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoles
        ///         operation.</returns>
        IAsyncResult BeginListRoles(ListRolesRequest listRolesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListRoles"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoles.</param>
        /// 
        /// <returns>Returns a ListRolesResult from AmazonIdentityManagementService.</returns>
        ListRolesResponse EndListRoles(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the roles that have the specified path prefix. If there are none, the action returns an empty list. For more information about
        /// roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>The returned policy is URL-encoded according to
        /// RFC 3986. For more information about RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html"
        /// >http://www.faqs.org/rfcs/rfc3986.html</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListRolesResponse ListRoles();
        
        #endregion
        
    

        #region ListSAMLProviders

        /// <summary>
        /// <para>Lists the SAML providers in the account.</para> <para><b>NOTE:</b>This operation requires Signature Version 4.</para>
        /// </summary>
        /// 
        /// <param name="listSAMLProvidersRequest">Container for the necessary parameters to execute the ListSAMLProviders service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest listSAMLProvidersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListSAMLProviders"/>
        /// </summary>
        /// 
        /// <param name="listSAMLProvidersRequest">Container for the necessary parameters to execute the ListSAMLProviders operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSAMLProviders
        ///         operation.</returns>
        IAsyncResult BeginListSAMLProviders(ListSAMLProvidersRequest listSAMLProvidersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListSAMLProviders operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListSAMLProviders"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSAMLProviders.</param>
        /// 
        /// <returns>Returns a ListSAMLProvidersResult from AmazonIdentityManagementService.</returns>
        ListSAMLProvidersResponse EndListSAMLProviders(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the SAML providers in the account.</para> <para><b>NOTE:</b>This operation requires Signature Version 4.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListSAMLProvidersResponse ListSAMLProviders();
        
        #endregion
        
    

        #region ListServerCertificates

        /// <summary>
        /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listServerCertificatesRequest">Container for the necessary parameters to execute the ListServerCertificates service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest listServerCertificatesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListServerCertificates"/>
        /// </summary>
        /// 
        /// <param name="listServerCertificatesRequest">Container for the necessary parameters to execute the ListServerCertificates operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListServerCertificates operation.</returns>
        IAsyncResult BeginListServerCertificates(ListServerCertificatesRequest listServerCertificatesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListServerCertificates"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerCertificates.</param>
        /// 
        /// <returns>Returns a ListServerCertificatesResult from AmazonIdentityManagementService.</returns>
        ListServerCertificatesResponse EndListServerCertificates(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the server certificates that have the specified path prefix. If none exist, the action returns an empty list.</para> <para>You
        /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListServerCertificatesResponse ListServerCertificates();
        
        #endregion
        
    

        #region ListSigningCertificates

        /// <summary>
        /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
        /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
        /// implicitly based on the AWS access key ID used to sign the request. Because this action works for access keys under the AWS account, this
        /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <param name="listSigningCertificatesRequest">Container for the necessary parameters to execute the ListSigningCertificates service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest listSigningCertificatesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListSigningCertificates"/>
        /// </summary>
        /// 
        /// <param name="listSigningCertificatesRequest">Container for the necessary parameters to execute the ListSigningCertificates operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListSigningCertificates operation.</returns>
        IAsyncResult BeginListSigningCertificates(ListSigningCertificatesRequest listSigningCertificatesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListSigningCertificates"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningCertificates.</param>
        /// 
        /// <returns>Returns a ListSigningCertificatesResult from AmazonIdentityManagementService.</returns>
        ListSigningCertificatesResponse EndListSigningCertificates(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns information about the signing certificates associated with the specified user. If there are none, the action returns an empty
        /// list.</para> <para>Although each user is limited to a small number of signing certificates, you can still paginate the results using the
        /// <c>MaxItems</c> and <c>Marker</c> parameters.</para> <para>If the <c>UserName</c> field is not specified, the user name is determined
        /// implicitly based on the AWS access key ID used to sign the request. Because this action works for access keys under the AWS account, this
        /// API can be used to manage root credentials even if the AWS account has no associated users.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListSigningCertificatesResponse ListSigningCertificates();
        
        #endregion
        
    

        #region ListUserPolicies

        /// <summary>
        /// <para>Lists the names of the policies associated with the specified user. If there are none, the action returns an empty list.</para>
        /// <para>You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listUserPoliciesRequest">Container for the necessary parameters to execute the ListUserPolicies service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest listUserPoliciesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListUserPolicies"/>
        /// </summary>
        /// 
        /// <param name="listUserPoliciesRequest">Container for the necessary parameters to execute the ListUserPolicies operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserPolicies
        ///         operation.</returns>
        IAsyncResult BeginListUserPolicies(ListUserPoliciesRequest listUserPoliciesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListUserPolicies"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPolicies.</param>
        /// 
        /// <returns>Returns a ListUserPoliciesResult from AmazonIdentityManagementService.</returns>
        ListUserPoliciesResponse EndListUserPolicies(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListUsers

        /// <summary>
        /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listUsersRequest">Container for the necessary parameters to execute the ListUsers service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListUsersResponse ListUsers(ListUsersRequest listUsersRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListUsers"/>
        /// </summary>
        /// 
        /// <param name="listUsersRequest">Container for the necessary parameters to execute the ListUsers operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        IAsyncResult BeginListUsers(ListUsersRequest listUsersRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListUsers"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a ListUsersResult from AmazonIdentityManagementService.</returns>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Lists the users that have the specified path prefix. If there are none, the action returns an empty list.</para> <para>You can
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListUsersResponse ListUsers();
        
        #endregion
        
    

        #region ListVirtualMFADevices

        /// <summary>
        /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
        /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
        /// <c>Unassigned</c> , or <c>Any</c> . </para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <param name="listVirtualMFADevicesRequest">Container for the necessary parameters to execute the ListVirtualMFADevices service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListVirtualMFADevices"/>
        /// </summary>
        /// 
        /// <param name="listVirtualMFADevicesRequest">Container for the necessary parameters to execute the ListVirtualMFADevices operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListVirtualMFADevices operation.</returns>
        IAsyncResult BeginListVirtualMFADevices(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ListVirtualMFADevices"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualMFADevices.</param>
        /// 
        /// <returns>Returns a ListVirtualMFADevicesResult from AmazonIdentityManagementService.</returns>
        ListVirtualMFADevicesResponse EndListVirtualMFADevices(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
        /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
        /// <c>Unassigned</c> , or <c>Any</c> . </para> <para>You can paginate the results using the <c>MaxItems</c> and
        /// <c>Marker</c> parameters.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        ListVirtualMFADevicesResponse ListVirtualMFADevices();
        
        #endregion
        
    

        #region PutGroupPolicy

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified group. For information about policies, refer to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?PoliciesOverview.html" >Overview of Policies</a> in <i>Using AWS Identity
        /// and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate with a group, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy documents can be large, you should use POST rather than GET
        /// when calling PutGroupPolicy. For information about setting up signatures and authorization through the API, go to Signing AWS API Requests
        /// in the AWS General Reference. For general information about using the Query API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putGroupPolicyRequest">Container for the necessary parameters to execute the PutGroupPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest putGroupPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="putGroupPolicyRequest">Container for the necessary parameters to execute the PutGroupPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutGroupPolicy(PutGroupPolicyRequest putGroupPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutGroupPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupPolicy.</param>
        PutGroupPolicyResponse EndPutGroupPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutRolePolicy

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified role. For information about policies, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?PoliciesOverview.html" >Overview of Policies</a> in <i>Using AWS Identity
        /// and Access Management</i> .</para> <para>For information about limits on the policies you can associate with a role, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy documents can be large, you should use POST rather than GET
        /// when calling PutRolePolicy. For information about setting up signatures and authorization through the API, go to Signing AWS API Requests in
        /// the AWS General Reference. For general information about using the Query API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putRolePolicyRequest">Container for the necessary parameters to execute the PutRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest putRolePolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="putRolePolicyRequest">Container for the necessary parameters to execute the PutRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutRolePolicy(PutRolePolicyRequest putRolePolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRolePolicy.</param>
        PutRolePolicyResponse EndPutRolePolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutUserPolicy

        /// <summary>
        /// <para>Adds (or updates) a policy document associated with the specified user. For information about policies, refer to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?PoliciesOverview.html" >Overview of Policies</a> in <i>Using AWS Identity
        /// and Access Management</i> .</para> <para>For information about limits on the number of policies you can associate with a user, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html" >Limitations on IAM Entities</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because policy documents can be large, you should use POST rather than GET
        /// when calling PutUserPolicy. For information about setting up signatures and authorization through the API, go to Signing AWS API Requests in
        /// the AWS General Reference. For general information about using the Query API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="putUserPolicyRequest">Container for the necessary parameters to execute the PutUserPolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest putUserPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="putUserPolicyRequest">Container for the necessary parameters to execute the PutUserPolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutUserPolicy(PutUserPolicyRequest putUserPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.PutUserPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserPolicy.</param>
        PutUserPolicyResponse EndPutUserPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RemoveRoleFromInstanceProfile

        /// <summary>
        /// <para>Removes the specified role from the specified instance profile.</para> <para><b>IMPORTANT:</b>Make sure you do not have any Amazon EC2
        /// instances running with the role you are about to remove from the instance profile. Removing a role from an instance profile that is
        /// associated with a running instance will break any applications running on the instance.</para> <para>For more information about roles, go to
        /// <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a> .
        /// For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html"
        /// >About Instance Profiles</a> .</para>
        /// </summary>
        /// 
        /// <param name="removeRoleFromInstanceProfileRequest">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile
        ///          service method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest removeRoleFromInstanceProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.RemoveRoleFromInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="removeRoleFromInstanceProfileRequest">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile
        ///          operation on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest removeRoleFromInstanceProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.RemoveRoleFromInstanceProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromInstanceProfile.</param>
        RemoveRoleFromInstanceProfileResponse EndRemoveRoleFromInstanceProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RemoveUserFromGroup

        /// <summary>
        /// <para>Removes the specified user from the specified group.</para>
        /// </summary>
        /// 
        /// <param name="removeUserFromGroupRequest">Container for the necessary parameters to execute the RemoveUserFromGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest removeUserFromGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.RemoveUserFromGroup"/>
        /// </summary>
        /// 
        /// <param name="removeUserFromGroupRequest">Container for the necessary parameters to execute the RemoveUserFromGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRemoveUserFromGroup(RemoveUserFromGroupRequest removeUserFromGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.RemoveUserFromGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveUserFromGroup.</param>
        RemoveUserFromGroupResponse EndRemoveUserFromGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResyncMFADevice

        /// <summary>
        /// <para>Synchronizes the specified MFA device with AWS servers.</para>
        /// </summary>
        /// 
        /// <param name="resyncMFADeviceRequest">Container for the necessary parameters to execute the ResyncMFADevice service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="InvalidAuthenticationCodeException"/>
        /// <exception cref="LimitExceededException"/>
        ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest resyncMFADeviceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ResyncMFADevice"/>
        /// </summary>
        /// 
        /// <param name="resyncMFADeviceRequest">Container for the necessary parameters to execute the ResyncMFADevice operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginResyncMFADevice(ResyncMFADeviceRequest resyncMFADeviceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.ResyncMFADevice"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResyncMFADevice.</param>
        ResyncMFADeviceResponse EndResyncMFADevice(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateAccessKey

        /// <summary>
        /// <para>Changes the status of the specified access key from Active to Inactive, or vice versa. This action can be used to disable a user's key
        /// as part of a key rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the UserName is determined implicitly based
        /// on the AWS access key ID used to sign the request. Because this action works for access keys under the AWS account, this API can be used to
        /// manage root credentials even if the AWS account has no associated users.</para> <para>For information about rotating keys, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?ManagingCredentials.html" >Managing Keys and Certificates</a> in <i>Using
        /// AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateAccessKeyRequest">Container for the necessary parameters to execute the UpdateAccessKey service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest updateAccessKeyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="updateAccessKeyRequest">Container for the necessary parameters to execute the UpdateAccessKey operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateAccessKey(UpdateAccessKeyRequest updateAccessKeyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAccessKey"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessKey.</param>
        UpdateAccessKeyResponse EndUpdateAccessKey(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateAccountPasswordPolicy

        /// <summary>
        /// <para>Updates the password policy settings for the account. For more information about using a password policy, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html" >Managing an IAM Password Policy</a> .</para>
        /// </summary>
        /// 
        /// <param name="updateAccountPasswordPolicyRequest">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service
        ///          method on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest updateAccountPasswordPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="updateAccountPasswordPolicyRequest">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation
        ///          on AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest updateAccountPasswordPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAccountPasswordPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPasswordPolicy.</param>
        UpdateAccountPasswordPolicyResponse EndUpdateAccountPasswordPolicy(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Updates the password policy settings for the account. For more information about using a password policy, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html" >Managing an IAM Password Policy</a> .</para>
        /// </summary>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy();
        
        #endregion
        
    

        #region UpdateAssumeRolePolicy

        /// <summary>
        /// <para>Updates the policy that grants an entity permission to assume a role. Currently, only an Amazon EC2 instance can assume a role. For
        /// more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html" >Working with Roles</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="updateAssumeRolePolicyRequest">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="MalformedPolicyDocumentException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest updateAssumeRolePolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAssumeRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="updateAssumeRolePolicyRequest">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest updateAssumeRolePolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateAssumeRolePolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssumeRolePolicy.</param>
        UpdateAssumeRolePolicyResponse EndUpdateAssumeRolePolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateGroup

        /// <summary>
        /// <para>Updates the name and/or the path of the specified group.</para> <para><b>IMPORTANT:</b> You should understand the implications of
        /// changing a group's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
        /// <para><b>NOTE:</b>To change a group name the requester must have appropriate permissions on both the source object and the target object.
        /// For example, to change Managers to MGRs, the entity making the request must have permission on Managers and MGRs, or must have permission on
        /// all (*). For more information about permissions, see Permissions and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateGroupRequest">Container for the necessary parameters to execute the UpdateGroup service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest updateGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateGroup"/>
        /// </summary>
        /// 
        /// <param name="updateGroupRequest">Container for the necessary parameters to execute the UpdateGroup operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest updateGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateLoginProfile

        /// <summary>
        /// <para>Changes the password for the specified user.</para>
        /// </summary>
        /// 
        /// <param name="updateLoginProfileRequest">Container for the necessary parameters to execute the UpdateLoginProfile service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="PasswordPolicyViolationException"/>
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest updateLoginProfileRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="updateLoginProfileRequest">Container for the necessary parameters to execute the UpdateLoginProfile operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateLoginProfile(UpdateLoginProfileRequest updateLoginProfileRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateLoginProfile"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoginProfile.</param>
        UpdateLoginProfileResponse EndUpdateLoginProfile(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateSAMLProvider

        /// <summary>
        /// <para>Updates the metadata document for an existing SAML provider.</para> <para><b>NOTE:</b>This operation requires Signature Version
        /// 4.</para>
        /// </summary>
        /// 
        /// <param name="updateSAMLProviderRequest">Container for the necessary parameters to execute the UpdateSAMLProvider service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="InvalidInputException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest updateSAMLProviderRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="updateSAMLProviderRequest">Container for the necessary parameters to execute the UpdateSAMLProvider operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUpdateSAMLProvider operation.</returns>
        IAsyncResult BeginUpdateSAMLProvider(UpdateSAMLProviderRequest updateSAMLProviderRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateSAMLProvider"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSAMLProvider.</param>
        /// 
        /// <returns>Returns a UpdateSAMLProviderResult from AmazonIdentityManagementService.</returns>
        UpdateSAMLProviderResponse EndUpdateSAMLProvider(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateServerCertificate

        /// <summary>
        /// <para>Updates the name and/or the path of the specified server certificate.</para> <para><b>IMPORTANT:</b> You should understand the
        /// implications of changing a server certificate's path or name. For more information, see Managing Server Certificates in Using AWS Identity
        /// and Access Management. </para> <para><b>NOTE:</b>To change a server certificate name the requester must have appropriate permissions on both
        /// the source object and the target object. For example, to change the name from ProductionCert to ProdCert, the entity making the request must
        /// have permission on ProductionCert and ProdCert, or must have permission on all (*). For more information about permissions, see Permissions
        /// and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateServerCertificateRequest">Container for the necessary parameters to execute the UpdateServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest updateServerCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="updateServerCertificateRequest">Container for the necessary parameters to execute the UpdateServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateServerCertificate(UpdateServerCertificateRequest updateServerCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerCertificate.</param>
        UpdateServerCertificateResponse EndUpdateServerCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateSigningCertificate

        /// <summary>
        /// <para>Changes the status of the specified signing certificate from active to disabled, or vice versa. This action can be used to disable a
        /// user's signing certificate as part of a certificate rotation work flow.</para> <para>If the <c>UserName</c> field is not specified, the
        /// UserName is determined implicitly based on the AWS access key ID used to sign the request. Because this action works for access keys under
        /// the AWS account, this API can be used to manage root credentials even if the AWS account has no associated users.</para> <para>For
        /// information about rotating certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?ManagingCredentials.html"
        /// >Managing Keys and Certificates</a> in <i>Using AWS Identity and Access Management</i> .</para>
        /// </summary>
        /// 
        /// <param name="updateSigningCertificateRequest">Container for the necessary parameters to execute the UpdateSigningCertificate service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest updateSigningCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="updateSigningCertificateRequest">Container for the necessary parameters to execute the UpdateSigningCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateSigningCertificate(UpdateSigningCertificateRequest updateSigningCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSigningCertificate.</param>
        UpdateSigningCertificateResponse EndUpdateSigningCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateUser

        /// <summary>
        /// <para>Updates the name and/or the path of the specified user.</para> <para><b>IMPORTANT:</b> You should understand the implications of
        /// changing a user's path or name. For more information, see Renaming Users and Groups in Using AWS Identity and Access Management. </para>
        /// <para><b>NOTE:</b>To change a user name the requester must have appropriate permissions on both the source object and the target object. For
        /// example, to change Bob to Robert, the entity making the request must have permission on Bob and Robert, or must have permission on all (*).
        /// For more information about permissions, see Permissions and Policies. </para>
        /// </summary>
        /// 
        /// <param name="updateUserRequest">Container for the necessary parameters to execute the UpdateUser service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <exception cref="EntityTemporarilyUnmodifiableException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        UpdateUserResponse UpdateUser(UpdateUserRequest updateUserRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateUser"/>
        /// </summary>
        /// 
        /// <param name="updateUserRequest">Container for the necessary parameters to execute the UpdateUser operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUpdateUser(UpdateUserRequest updateUserRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UpdateUser"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UploadServerCertificate

        /// <summary>
        /// <para>Uploads a server certificate entity for the AWS account. The server certificate entity includes a public key certificate, a private
        /// key, and an optional certificate chain, which should all be PEM-encoded.</para> <para>For information about the number of server
        /// certificates you can upload, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html"
        /// >Limitations on IAM Entities</a> in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because the body of the
        /// public key certificate, private key, and the certificate chain can be large, you should use POST rather than GET when calling
        /// UploadServerCertificate. For information about setting up signatures and authorization through the API, go to Signing AWS API Requests in
        /// the AWS General Reference. For general information about using the Query API with IAM, go to Making Query Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="uploadServerCertificateRequest">Container for the necessary parameters to execute the UploadServerCertificate service method on
        ///          AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="KeyPairMismatchException"/>
        /// <exception cref="MalformedCertificateException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest uploadServerCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UploadServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="uploadServerCertificateRequest">Container for the necessary parameters to execute the UploadServerCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUploadServerCertificate operation.</returns>
        IAsyncResult BeginUploadServerCertificate(UploadServerCertificateRequest uploadServerCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UploadServerCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadServerCertificate.</param>
        /// 
        /// <returns>Returns a UploadServerCertificateResult from AmazonIdentityManagementService.</returns>
        UploadServerCertificateResponse EndUploadServerCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UploadSigningCertificate

        /// <summary>
        /// <para>Uploads an X.509 signing certificate and associates it with the specified user. Some AWS services use X.509 signing certificates to
        /// validate requests that are signed with a corresponding private key. When you upload the certificate, its default status is <c>Active</c>
        /// .</para> <para>If the <c>UserName</c> field is not specified, the user name is determined implicitly based on the AWS access key ID used to
        /// sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root credentials even if
        /// the AWS account has no associated users.</para> <para><b>NOTE:</b>Because the body of a X.509 certificate can be large, you should use POST
        /// rather than GET when calling UploadSigningCertificate. For information about setting up signatures and authorization through the API, go to
        /// Signing AWS API Requests in the AWS General Reference. For general information about using the Query API with IAM, go to Making Query
        /// Requests in Using IAM.</para>
        /// </summary>
        /// 
        /// <param name="uploadSigningCertificateRequest">Container for the necessary parameters to execute the UploadSigningCertificate service method
        ///          on AmazonIdentityManagementService.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by AmazonIdentityManagementService.</returns>
        /// 
        /// <exception cref="DuplicateCertificateException"/>
        /// <exception cref="InvalidCertificateException"/>
        /// <exception cref="MalformedCertificateException"/>
        /// <exception cref="NoSuchEntityException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="EntityAlreadyExistsException"/>
        UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest uploadSigningCertificateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UploadSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="uploadSigningCertificateRequest">Container for the necessary parameters to execute the UploadSigningCertificate operation on
        ///          AmazonIdentityManagementService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUploadSigningCertificate operation.</returns>
        IAsyncResult BeginUploadSigningCertificate(UploadSigningCertificateRequest uploadSigningCertificateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService.UploadSigningCertificate"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSigningCertificate.</param>
        /// 
        /// <returns>Returns a UploadSigningCertificateResult from AmazonIdentityManagementService.</returns>
        UploadSigningCertificateResponse EndUploadSigningCertificate(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
