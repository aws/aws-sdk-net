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

using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Implementation for accessing IdentityManagementService
    ///
    /// AWS Identity and Access Management        
    /// <para>
    /// AWS Identity and Access Management (IAM) is a web service that you can use to manage
    /// users and user permissions            under your AWS account. This guide provides descriptions
    /// of the IAM API. For general            information about IAM, see <a href="http://aws.amazon.com/iam/"
    /// target="_blank">AWS Identity                and Access Management (IAM)</a>. For the user guide
    /// for IAM, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/" target="_blank">Using
    /// IAM</a>. 
    /// </para>
    ///         <note>AWS provides SDKs that consist of libraries and sample code for various programming            languages
    /// and platforms (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a convenient            way
    /// to create programmatic access to IAM and AWS. For example, the SDKs take care of tasks            such
    /// as cryptographically signing requests (see below), managing errors, and retrying requests            automatically.
    /// For information about the AWS SDKs, including how to download and install them,            see
    /// the <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a> page.
    /// </note>        
    /// <para>
    ///  Using the IAM Query API, you make direct calls to the IAM web service. IAM supports            GET
    /// and POST requests for all actions. That is, the API does not require you to use GET
    /// for            some actions and POST for others. However, GET requests are subject to the limitation
    /// size of            a URL. Therefore, for operations that require larger sizes, use a POST request.
    /// 
    /// </para>
    ///         
    /// <para>
    /// <b>Signing Requests</b>
    /// </para>
    ///         
    /// <para>
    /// Requests must be signed using an access key ID and a secret        access key. We strongly
    /// recommend that you do not use your AWS account access key ID and        secret access key
    /// for everyday work with IAM. You can use the access key ID and secret access        key for
    /// an IAM user or you can use the AWS Security Token Service to generate temporary security
    /// credentials        and use those to sign requests.        
    /// </para>
    ///         
    /// <para>
    /// To sign requests, we recommend that you use <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>. If            you have an existing application that uses Signature Version 2,
    /// you do not have to update it            to use Signature Version 4. However, some operations
    /// now require Signature Version 4. The            documentation for operations that require version
    /// 4 indicate this requirement. 
    /// </para>
    ///         
    /// <para>
    /// <b>Recording API requests</b>
    /// </para>
    ///         
    /// <para>
    ///             IAM supports AWS CloudTrail, which is a service that records AWS calls for your
    /// AWS account and delivers            log files to an Amazon S3 bucket. By using information
    /// collected by CloudTrail, you can determine what            requests were successfully made
    /// to IAM, who made the request, when it was made, and so on. To learn more about            CloudTrail,
    /// including how to turn it on and find your log files, see the            <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/whatisawscloudtrail.html">AWS
    /// CloudTrail User Guide</a>.        
    /// </para>
    ///         
    /// <para>
    /// <b>Additional Resources</b>
    /// </para>
    ///         
    /// <para>
    /// For more information, see the following:
    /// </para>
    ///         <ul>            <li><a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html"
    /// target="_blank">AWS Security Credentials</a>. This topic provides general information
    /// about the types of                credentials used for accessing AWS.</li>            <li><a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html"
    /// target="_blank">IAM                    Best Practices</a>. This topic presents a list of suggestions
    /// for using the IAM service                to help secure your AWS resources.</li>            <li><a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/"
    /// target="_blank">AWS Security Token Service</a>. This guide                describes how to create
    /// and use temporary security credentials.</li>            <li><a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
    /// target="_blank">Signing AWS API Requests</a>. This set of topics walk you through
    /// the process of signing                a request using an access key ID and secret access key.</li>        </ul>
    /// </summary>
    public partial interface IAmazonIdentityManagementService : IDisposable
    {

        
        #region  AddRoleToInstanceProfile


        /// <summary>
        /// Adds the specified role to the specified instance profile. For more information about
        /// roles,            go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with                Roles</a>. For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the AddRoleToInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddRoleToInstanceProfile
        ///         operation.</returns>
        IAsyncResult BeginAddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToInstanceProfile.</param>
        /// 
        /// <returns>Returns a  AddRoleToInstanceProfileResult from IdentityManagementService.</returns>
        AddRoleToInstanceProfileResponse EndAddRoleToInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  AddUserToGroup


        /// <summary>
        /// Adds the specified user to the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup service method.</param>
        /// 
        /// <returns>The response from the AddUserToGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddUserToGroup
        ///         operation.</returns>
        IAsyncResult BeginAddUserToGroup(AddUserToGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUserToGroup.</param>
        /// 
        /// <returns>Returns a  AddUserToGroupResult from IdentityManagementService.</returns>
        AddUserToGroupResponse EndAddUserToGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ChangePassword


        /// <summary>
        /// Changes the password of the IAM user calling <code>ChangePassword</code>. The root
        /// account            password is not affected by this action. For information about modifying
        /// passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html"
        /// target="_blank">Managing Passwords</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="InvalidUserTypeException">
        /// The request was rejected because the type of user for the transaction was incorrect.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <exception cref="PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed            by the account password policy.
        /// </exception>
        ChangePasswordResponse ChangePassword(ChangePasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangePassword
        ///         operation.</returns>
        IAsyncResult BeginChangePassword(ChangePasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        /// 
        /// <returns>Returns a  ChangePasswordResult from IdentityManagementService.</returns>
        ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessKey

        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified            user.
        /// The default status for new keys is <code>Active</code>.
        /// 
        ///         
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS            access key ID signing the request. Because this action works for access
        /// keys under the AWS            account, you can use this API to manage root credentials even
        /// if the AWS account has no            associated users.
        /// </para>
        ///         
        /// <para>
        /// For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         <important>To ensure the security of your AWS account, the secret access key is
        /// accessible only            during key and user creation. You must save the key (for example,
        /// in a text file) if you want            to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the            associated user and then create new keys.</important>
        /// </summary>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        CreateAccessKeyResponse CreateAccessKey();

        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified            user.
        /// The default status for new keys is <code>Active</code>.
        /// 
        ///         
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS            access key ID signing the request. Because this action works for access
        /// keys under the AWS            account, you can use this API to manage root credentials even
        /// if the AWS account has no            associated users.
        /// </para>
        ///         
        /// <para>
        /// For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         <important>To ensure the security of your AWS account, the secret access key is
        /// accessible only            during key and user creation. You must save the key (for example,
        /// in a text file) if you want            to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the            associated user and then create new keys.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey service method.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessKey
        ///         operation.</returns>
        IAsyncResult BeginCreateAccessKey(CreateAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessKey.</param>
        /// 
        /// <returns>Returns a  CreateAccessKeyResult from IdentityManagementService.</returns>
        CreateAccessKeyResponse EndCreateAccessKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccountAlias


        /// <summary>
        /// This action creates an alias for your AWS account. For information about using an
        /// AWS account            alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html"
        /// target="_blank">Using an Alias for Your AWS Account ID</a> in <i>Using AWS Identity
        /// and Access                Management</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountAlias
        ///         operation.</returns>
        IAsyncResult BeginCreateAccountAlias(CreateAccountAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAlias.</param>
        /// 
        /// <returns>Returns a  CreateAccountAliasResult from IdentityManagementService.</returns>
        CreateAccountAliasResponse EndCreateAccountAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a new group.
        /// 
        ///         
        /// <para>
        /// For information about the number of groups you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from IdentityManagementService.</returns>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstanceProfile


        /// <summary>
        /// Creates a new instance profile. For information about instance profiles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// 
        ///         
        /// <para>
        /// For information about the number of instance profiles you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceProfile
        ///         operation.</returns>
        IAsyncResult BeginCreateInstanceProfile(CreateInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a  CreateInstanceProfileResult from IdentityManagementService.</returns>
        CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoginProfile


        /// <summary>
        /// Creates a password for the specified user, giving the user the ability to access AWS
        /// services            through the AWS Management Console. For more information about managing
        /// passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html"
        /// target="_blank">Managing Passwords</a> in <i>Using IAM</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <exception cref="PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed            by the account password policy.
        /// </exception>
        CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoginProfile
        ///         operation.</returns>
        IAsyncResult BeginCreateLoginProfile(CreateLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoginProfile.</param>
        /// 
        /// <returns>Returns a  CreateLoginProfileResult from IdentityManagementService.</returns>
        CreateLoginProfileResponse EndCreateLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRole


        /// <summary>
        /// Creates a new role for your AWS account. For more information about roles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.            For information about limitations on role names and the number of
        /// roles you can create, go to                <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// 
        ///         
        /// <para>
        /// The example policy grants permission to an EC2 instance to assume the role. The policy
        /// is URL-encoded            according to RFC 3986. For more information about RFC 3986, go to
        /// <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRole service method.</param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        CreateRoleResponse CreateRole(CreateRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRole
        ///         operation.</returns>
        IAsyncResult BeginCreateRole(CreateRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRole.</param>
        /// 
        /// <returns>Returns a  CreateRoleResult from IdentityManagementService.</returns>
        CreateRoleResponse EndCreateRole(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSAMLProvider


        /// <summary>
        /// Creates an IAM entity to describe an identity provider (IdP) that supports SAML 2.0.
        /// 
        ///         
        /// <para>
        /// The SAML provider that you create with this operation can be used as a principal in
        /// a role's            trust policy to establish a trust relationship between AWS and a SAML identity
        /// provider. You            can create an IAM role that supports Web-based single sign-on (SSO)
        /// to the AWS Management Console or one            that supports API access to AWS. 
        /// </para>
        ///         
        /// <para>
        /// When you create the SAML provider, you upload an a SAML metadata document that you
        /// get from            your IdP and that includes the issuer's name, expiration information, and
        /// keys that can be            used to validate the SAML authentication response (assertions)
        /// that are received from the IdP.            You must generate the metadata document using the
        /// identity management software that is used as            your organization's IdP. 
        /// </para>
        ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>        
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSMgmtConsole-SAML.html">Giving
        /// Console Access Using SAML</a> and <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html">Creating                Temporary
        /// Security Credentials for SAML Federation</a> in the <i>Using Temporary                Credentials</i>
        /// guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the CreateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSAMLProvider
        ///         operation.</returns>
        IAsyncResult BeginCreateSAMLProvider(CreateSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  CreateSAMLProviderResult from IdentityManagementService.</returns>
        CreateSAMLProviderResponse EndCreateSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a new user for your AWS account.
        /// 
        ///         
        /// <para>
        /// For information about limitations on the number of users you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from IdentityManagementService.</returns>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVirtualMFADevice


        /// <summary>
        /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
        /// use <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_EnableMFADevice.html"
        /// target="_blank">EnableMFADevice</a> to attach the MFA device to an IAM user. For more
        /// information about            creating and working with virtual MFA devices, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html"
        /// target="_blank">Using a Virtual MFA Device</a> in <i>Using AWS Identity and Access
        /// Management</i>.
        /// 
        ///         
        /// <para>
        /// For information about limits on the number of MFA devices you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         <important>The seed information contained in the QR code and the Base32 string should
        /// be treated            like any other secret access information, such as your AWS access keys
        /// or your passwords.            After you provision your virtual device, you should ensure that
        /// the information is destroyed            following secure procedures.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualMFADevice
        ///         operation.</returns>
        IAsyncResult BeginCreateVirtualMFADevice(CreateVirtualMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  CreateVirtualMFADeviceResult from IdentityManagementService.</returns>
        CreateVirtualMFADeviceResponse EndCreateVirtualMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateMFADevice


        /// <summary>
        /// Deactivates the specified MFA device and removes it from association with the user
        /// name for            which it was originally enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateMFADevice
        ///         operation.</returns>
        IAsyncResult BeginDeactivateMFADevice(DeactivateMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMFADevice.</param>
        /// 
        /// <returns>Returns a  DeactivateMFADeviceResult from IdentityManagementService.</returns>
        DeactivateMFADeviceResponse EndDeactivateMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessKey


        /// <summary>
        /// Deletes the access key associated with the specified user.
        /// 
        ///         
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS            access key ID signing the request. Because this action works for access
        /// keys under the AWS            account, you can use this API to manage root credentials even
        /// if the AWS account has no            associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessKey
        ///         operation.</returns>
        IAsyncResult BeginDeleteAccessKey(DeleteAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessKey.</param>
        /// 
        /// <returns>Returns a  DeleteAccessKeyResult from IdentityManagementService.</returns>
        DeleteAccessKeyResponse EndDeleteAccessKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountAlias


        /// <summary>
        /// Deletes the specified AWS account alias. For information about using an AWS account
        /// alias,            see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html"
        /// target="_blank">Using an                Alias for Your AWS Account ID</a> in <i>Using AWS Identity
        /// and Access Management</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountAlias
        ///         operation.</returns>
        IAsyncResult BeginDeleteAccountAlias(DeleteAccountAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAliasResult from IdentityManagementService.</returns>
        DeleteAccountAliasResponse EndDeleteAccountAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountPasswordPolicy

        /// <summary>
        /// Deletes the password policy for the AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy();

        /// <summary>
        /// Deletes the password policy for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountPasswordPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccountPasswordPolicyResult from IdentityManagementService.</returns>
        DeleteAccountPasswordPolicyResponse EndDeleteAccountPasswordPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes the specified group. The group must not contain any users or have any attached            policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from IdentityManagementService.</returns>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroupPolicy


        /// <summary>
        /// Deletes the specified policy that is associated with the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteGroupPolicy(DeleteGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteGroupPolicyResult from IdentityManagementService.</returns>
        DeleteGroupPolicyResponse EndDeleteGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstanceProfile


        /// <summary>
        /// Deletes the specified instance profile. The instance profile must not have an associated            role.
        /// 
        ///         <important>Make sure you do not have any Amazon EC2 instances running with the instance
        /// profile            you are about to delete. Deleting a role or instance profile that is associated
        /// with a running            instance will break any applications running on the instance.</important>        
        /// <para>
        /// For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceProfile
        ///         operation.</returns>
        IAsyncResult BeginDeleteInstanceProfile(DeleteInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceProfileResult from IdentityManagementService.</returns>
        DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoginProfile


        /// <summary>
        /// Deletes the password for the specified user, which terminates the user's ability to
        /// access            AWS services through the AWS Management Console.
        /// 
        ///         <important>Deleting a user's password does not prevent a user from accessing IAM
        /// through the            command line interface or the API. To prevent all user access you must
        /// also either make the            access key inactive or delete it. For more information about
        /// making keys inactive or deleting            them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
        /// </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoginProfile
        ///         operation.</returns>
        IAsyncResult BeginDeleteLoginProfile(DeleteLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoginProfile.</param>
        /// 
        /// <returns>Returns a  DeleteLoginProfileResult from IdentityManagementService.</returns>
        DeleteLoginProfileResponse EndDeleteLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRole


        /// <summary>
        /// Deletes the specified role. The role must not have any policies attached. For more            information
        /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with            Roles</a>.
        /// 
        ///         <important>Make sure you do not have any Amazon EC2 instances running with the role
        /// you are            about to delete. Deleting a role or instance profile that is associated
        /// with a running            instance will break any applications running on the instance.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole service method.</param>
        /// 
        /// <returns>The response from the DeleteRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteRoleResponse DeleteRole(DeleteRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRole
        ///         operation.</returns>
        IAsyncResult BeginDeleteRole(DeleteRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRole.</param>
        /// 
        /// <returns>Returns a  DeleteRoleResult from IdentityManagementService.</returns>
        DeleteRoleResponse EndDeleteRole(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRolePolicy


        /// <summary>
        /// Deletes the specified policy associated with the specified role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRolePolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteRolePolicy(DeleteRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRolePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRolePolicyResult from IdentityManagementService.</returns>
        DeleteRolePolicyResponse EndDeleteRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSAMLProvider


        /// <summary>
        /// Deletes a SAML provider.
        /// 
        ///         
        /// <para>
        /// Deleting the provider does not update any roles that reference the SAML provider as
        /// a            principal in their trust policies. Any attempt to assume a role that references
        /// a SAML            provider that has been deleted will fail. 
        /// </para>
        ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSAMLProvider
        ///         operation.</returns>
        IAsyncResult BeginDeleteSAMLProvider(DeleteSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSAMLProvider.</param>
        /// 
        /// <returns>Returns a  DeleteSAMLProviderResult from IdentityManagementService.</returns>
        DeleteSAMLProviderResponse EndDeleteSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServerCertificate


        /// <summary>
        /// Deletes the specified server certificate.
        /// 
        ///         <important>If you are using a server certificate with Elastic Load Balancing, deleting
        /// the            certificate could have implications for your application. If Elastic Load Balancing
        /// doesn't            detect the deletion of bound certificates, it may continue to use the certificates.
        /// This could            cause Elastic Load Balancing to stop accepting traffic. We recommend
        /// that you remove the            reference to the certificate from Elastic Load Balancing before
        /// using this command to delete            the certificate. For more information, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html"
        /// target="blank">DeleteLoadBalancerListeners</a> in the <i>Elastic Load Balancing API                Reference</i>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServerCertificate
        ///         operation.</returns>
        IAsyncResult BeginDeleteServerCertificate(DeleteServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteServerCertificateResult from IdentityManagementService.</returns>
        DeleteServerCertificateResponse EndDeleteServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSigningCertificate


        /// <summary>
        /// Deletes the specified signing certificate associated with the specified user.
        /// 
        ///         
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS            access key ID signing the request. Because this action works for access
        /// keys under the AWS            account, you can use this API to manage root credentials even
        /// if the AWS account has no            associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSigningCertificate
        ///         operation.</returns>
        IAsyncResult BeginDeleteSigningCertificate(DeleteSigningCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSigningCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteSigningCertificateResult from IdentityManagementService.</returns>
        DeleteSigningCertificateResponse EndDeleteSigningCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the specified user. The user must not belong to any groups, have any keys
        /// or signing            certificates, or have any attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from IdentityManagementService.</returns>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserPolicy


        /// <summary>
        /// Deletes the specified policy associated with the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteUserPolicy(DeleteUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteUserPolicyResult from IdentityManagementService.</returns>
        DeleteUserPolicyResponse EndDeleteUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVirtualMFADevice


        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        ///         <note>You must deactivate a user's virtual MFA device before you can delete it.
        /// For information            about deactivating MFA devices, see <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualMFADevice
        ///         operation.</returns>
        IAsyncResult BeginDeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualMFADeviceResult from IdentityManagementService.</returns>
        DeleteVirtualMFADeviceResponse EndDeleteVirtualMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableMFADevice


        /// <summary>
        /// Enables the specified MFA device and associates it with the specified user name. When            enabled,
        /// the MFA device is required for every subsequent login by the user name associated            with
        /// the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error            message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableMFADevice
        ///         operation.</returns>
        IAsyncResult BeginEnableMFADevice(EnableMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMFADevice.</param>
        /// 
        /// <returns>Returns a  EnableMFADeviceResult from IdentityManagementService.</returns>
        EnableMFADeviceResponse EndEnableMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountPasswordPolicy

        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a            password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an                IAM Password Policy</a>.
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetAccountPasswordPolicyResponse GetAccountPasswordPolicy();

        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a            password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an                IAM Password Policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountPasswordPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  GetAccountPasswordPolicyResult from IdentityManagementService.</returns>
        GetAccountPasswordPolicyResponse EndGetAccountPasswordPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountSummary

        /// <summary>
        /// Retrieves account level information about account entity usage and IAM quotas.
        /// 
        ///         
        /// <para>
        /// For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        GetAccountSummaryResponse GetAccountSummary();

        /// <summary>
        /// Retrieves account level information about account entity usage and IAM quotas.
        /// 
        ///         
        /// <para>
        /// For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary service method.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSummary
        ///         operation.</returns>
        IAsyncResult BeginGetAccountSummary(GetAccountSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSummary.</param>
        /// 
        /// <returns>Returns a  GetAccountSummaryResult from IdentityManagementService.</returns>
        GetAccountSummaryResponse EndGetAccountSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns a list of users that are in the specified group. You can paginate the results
        /// using            the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from IdentityManagementService.</returns>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupPolicy


        /// <summary>
        /// Retrieves the specified policy document for the specified group. The returned policy
        /// is            URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetGroupPolicy(GetGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetGroupPolicyResult from IdentityManagementService.</returns>
        GetGroupPolicyResponse EndGetGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInstanceProfile


        /// <summary>
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's            path, GUID, ARN, and role. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>. For more information about ARNs, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs">ARNs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceProfile
        ///         operation.</returns>
        IAsyncResult BeginGetInstanceProfile(GetInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceProfile.</param>
        /// 
        /// <returns>Returns a  GetInstanceProfileResult from IdentityManagementService.</returns>
        GetInstanceProfileResponse EndGetInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLoginProfile


        /// <summary>
        /// Retrieves the user name and password-creation date for the specified user. If the
        /// user has            not been assigned a password, the action returns a 404 (<code>NoSuchEntity</code>)
        /// error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile service method.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoginProfile
        ///         operation.</returns>
        IAsyncResult BeginGetLoginProfile(GetLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoginProfile.</param>
        /// 
        /// <returns>Returns a  GetLoginProfileResult from IdentityManagementService.</returns>
        GetLoginProfileResponse EndGetLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRole


        /// <summary>
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the            policy granting permission to assume the role. For more information about
        /// ARNs, go to                <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs">ARNs</a>.
        /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with            Roles</a>.
        /// 
        ///         
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC            3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRole service method.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetRoleResponse GetRole(GetRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRole
        ///         operation.</returns>
        IAsyncResult BeginGetRole(GetRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRole.</param>
        /// 
        /// <returns>Returns a  GetRoleResult from IdentityManagementService.</returns>
        GetRoleResponse EndGetRole(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRolePolicy


        /// <summary>
        /// Retrieves the specified policy document for the specified role. For more information
        /// about            roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with                Roles</a>.
        /// 
        ///         
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC            3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy service method.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRolePolicy
        ///         operation.</returns>
        IAsyncResult BeginGetRolePolicy(GetRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRolePolicy.</param>
        /// 
        /// <returns>Returns a  GetRolePolicyResult from IdentityManagementService.</returns>
        GetRolePolicyResponse EndGetRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSAMLProvider


        /// <summary>
        /// Returns the SAML provider metadocument that was uploaded when the provider was created
        /// or            updated.
        /// 
        ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.        </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSAMLProvider
        ///         operation.</returns>
        IAsyncResult BeginGetSAMLProvider(GetSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSAMLProvider.</param>
        /// 
        /// <returns>Returns a  GetSAMLProviderResult from IdentityManagementService.</returns>
        GetSAMLProviderResponse EndGetSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServerCertificate


        /// <summary>
        /// Retrieves information about the specified server certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate service method.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServerCertificate
        ///         operation.</returns>
        IAsyncResult BeginGetServerCertificate(GetServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerCertificate.</param>
        /// 
        /// <returns>Returns a  GetServerCertificateResult from IdentityManagementService.</returns>
        GetServerCertificateResponse EndGetServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Retrieves information about the specified user, including the user's path, unique
        /// ID, and            ARN.
        /// 
        ///         
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS            access key ID signing the request.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetUserResponse GetUser();

        /// <summary>
        /// Retrieves information about the specified user, including the user's path, unique
        /// ID, and            ARN.
        /// 
        ///         
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS            access key ID signing the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetUserResponse GetUser(GetUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from IdentityManagementService.</returns>
        GetUserResponse EndGetUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserPolicy


        /// <summary>
        /// Retrieves the specified policy document for the specified user. The returned policy
        /// is            URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetUserPolicy(GetUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPolicy.</param>
        /// 
        /// <returns>Returns a  GetUserPolicyResult from IdentityManagementService.</returns>
        GetUserPolicyResponse EndGetUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessKeys

        /// <summary>
        /// Returns information about the access key IDs associated with the specified user. If
        /// there are            none, the action returns an empty list.
        /// 
        ///         
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results            using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///         
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly            based
        /// on the AWS access key ID used to sign the request. Because this action works for access            keys
        /// under the AWS account, this API can be used to manage root credentials even if the
        /// AWS            account has no associated users.
        /// </para>
        ///         <note>To ensure the security of your AWS account, the secret access key is accessible
        /// only            during key and user creation.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListAccessKeysResponse ListAccessKeys();

        /// <summary>
        /// Returns information about the access key IDs associated with the specified user. If
        /// there are            none, the action returns an empty list.
        /// 
        ///         
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results            using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///         
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly            based
        /// on the AWS access key ID used to sign the request. Because this action works for access            keys
        /// under the AWS account, this API can be used to manage root credentials even if the
        /// AWS            account has no associated users.
        /// </para>
        ///         <note>To ensure the security of your AWS account, the secret access key is accessible
        /// only            during key and user creation.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessKeys
        ///         operation.</returns>
        IAsyncResult BeginListAccessKeys(ListAccessKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessKeys.</param>
        /// 
        /// <returns>Returns a  ListAccessKeysResult from IdentityManagementService.</returns>
        ListAccessKeysResponse EndListAccessKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountAliases

        /// <summary>
        /// Lists the account aliases associated with the account. For information about using
        /// an AWS            account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html"
        /// target="_blank">Using an Alias for Your AWS Account ID</a> in <i>Using AWS Identity
        /// and                Access Management</i>.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        ListAccountAliasesResponse ListAccountAliases();

        /// <summary>
        /// Lists the account aliases associated with the account. For information about using
        /// an AWS            account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html"
        /// target="_blank">Using an Alias for Your AWS Account ID</a> in <i>Using AWS Identity
        /// and                Access Management</i>.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases service method.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAliases
        ///         operation.</returns>
        IAsyncResult BeginListAccountAliases(ListAccountAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAliases.</param>
        /// 
        /// <returns>Returns a  ListAccountAliasesResult from IdentityManagementService.</returns>
        ListAccountAliasesResponse EndListAccountAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupPolicies


        /// <summary>
        /// Lists the names of the policies associated with the specified group. If there are
        /// none, the            action returns an empty list.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupPolicies
        ///         operation.</returns>
        IAsyncResult BeginListGroupPolicies(ListGroupPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupPolicies.</param>
        /// 
        /// <returns>Returns a  ListGroupPoliciesResult from IdentityManagementService.</returns>
        ListGroupPoliciesResponse EndListGroupPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Lists the groups that have the specified path prefix.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        ListGroupsResponse ListGroups();

        /// <summary>
        /// Lists the groups that have the specified path prefix.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from IdentityManagementService.</returns>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupsForUser


        /// <summary>
        /// Lists the groups the specified user belongs to.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser service method.</param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupsForUser
        ///         operation.</returns>
        IAsyncResult BeginListGroupsForUser(ListGroupsForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForUser.</param>
        /// 
        /// <returns>Returns a  ListGroupsForUserResult from IdentityManagementService.</returns>
        ListGroupsForUserResponse EndListGroupsForUser(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstanceProfiles

        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the            action returns an empty list. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        ListInstanceProfilesResponse ListInstanceProfiles();

        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the            action returns an empty list. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceProfiles
        ///         operation.</returns>
        IAsyncResult BeginListInstanceProfiles(ListInstanceProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfiles.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesResult from IdentityManagementService.</returns>
        ListInstanceProfilesResponse EndListInstanceProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstanceProfilesForRole


        /// <summary>
        /// Lists the instance profiles that have the specified associated role. If there are
        /// none, the            action returns an empty list. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceProfilesForRole
        ///         operation.</returns>
        IAsyncResult BeginListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfilesForRole.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesForRoleResult from IdentityManagementService.</returns>
        ListInstanceProfilesForRoleResponse EndListInstanceProfilesForRole(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMFADevices

        /// <summary>
        /// Lists the MFA devices. If the request includes the user name, then this action lists
        /// all the            MFA devices associated with the specified user name. If you do not specify
        /// a user name, IAM            determines the user name implicitly based on the AWS access key
        /// ID signing the request.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListMFADevicesResponse ListMFADevices();

        /// <summary>
        /// Lists the MFA devices. If the request includes the user name, then this action lists
        /// all the            MFA devices associated with the specified user name. If you do not specify
        /// a user name, IAM            determines the user name implicitly based on the AWS access key
        /// ID signing the request.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMFADevices
        ///         operation.</returns>
        IAsyncResult BeginListMFADevices(ListMFADevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMFADevices.</param>
        /// 
        /// <returns>Returns a  ListMFADevicesResult from IdentityManagementService.</returns>
        ListMFADevicesResponse EndListMFADevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRolePolicies


        /// <summary>
        /// Lists the names of the policies associated with the specified role. If there are none,
        /// the            action returns an empty list.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRolePolicies
        ///         operation.</returns>
        IAsyncResult BeginListRolePolicies(ListRolePoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRolePolicies.</param>
        /// 
        /// <returns>Returns a  ListRolePoliciesResult from IdentityManagementService.</returns>
        ListRolePoliciesResponse EndListRolePolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoles

        /// <summary>
        /// Lists the roles that have the specified path prefix. If there are none, the action
        /// returns an            empty list. For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with            Roles</a>.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        ///         
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC            3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        ListRolesResponse ListRoles();

        /// <summary>
        /// Lists the roles that have the specified path prefix. If there are none, the action
        /// returns an            empty list. For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with            Roles</a>.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        ///         
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC            3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        ListRolesResponse ListRoles(ListRolesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoles
        ///         operation.</returns>
        IAsyncResult BeginListRoles(ListRolesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoles.</param>
        /// 
        /// <returns>Returns a  ListRolesResult from IdentityManagementService.</returns>
        ListRolesResponse EndListRoles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSAMLProviders

        /// <summary>
        /// Lists the SAML providers in the account.
        /// 
        ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>
        /// </summary>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        ListSAMLProvidersResponse ListSAMLProviders();

        /// <summary>
        /// Lists the SAML providers in the account.
        /// 
        ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSAMLProviders
        ///         operation.</returns>
        IAsyncResult BeginListSAMLProviders(ListSAMLProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSAMLProviders operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSAMLProviders.</param>
        /// 
        /// <returns>Returns a  ListSAMLProvidersResult from IdentityManagementService.</returns>
        ListSAMLProvidersResponse EndListSAMLProviders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServerCertificates

        /// <summary>
        /// Lists the server certificates that have the specified path prefix. If none exist,
        /// the action            returns an empty list.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        ListServerCertificatesResponse ListServerCertificates();

        /// <summary>
        /// Lists the server certificates that have the specified path prefix. If none exist,
        /// the action            returns an empty list.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates service method.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServerCertificates
        ///         operation.</returns>
        IAsyncResult BeginListServerCertificates(ListServerCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerCertificates.</param>
        /// 
        /// <returns>Returns a  ListServerCertificatesResult from IdentityManagementService.</returns>
        ListServerCertificatesResponse EndListServerCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSigningCertificates

        /// <summary>
        /// Returns information about the signing certificates associated with the specified user.
        /// If            there are none, the action returns an empty list.
        /// 
        ///         
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still            paginate
        /// the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///         
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly            based
        /// on the AWS access key ID used to sign the request. Because this action works for access            keys
        /// under the AWS account, this API can be used to manage root credentials even if the
        /// AWS            account has no associated users.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListSigningCertificatesResponse ListSigningCertificates();

        /// <summary>
        /// Returns information about the signing certificates associated with the specified user.
        /// If            there are none, the action returns an empty list.
        /// 
        ///         
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still            paginate
        /// the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///         
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly            based
        /// on the AWS access key ID used to sign the request. Because this action works for access            keys
        /// under the AWS account, this API can be used to manage root credentials even if the
        /// AWS            account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates service method.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningCertificates
        ///         operation.</returns>
        IAsyncResult BeginListSigningCertificates(ListSigningCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningCertificates.</param>
        /// 
        /// <returns>Returns a  ListSigningCertificatesResult from IdentityManagementService.</returns>
        ListSigningCertificatesResponse EndListSigningCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserPolicies


        /// <summary>
        /// Lists the names of the policies associated with the specified user. If there are none,
        /// the            action returns an empty list.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserPolicies
        ///         operation.</returns>
        IAsyncResult BeginListUserPolicies(ListUserPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPolicies.</param>
        /// 
        /// <returns>Returns a  ListUserPoliciesResult from IdentityManagementService.</returns>
        ListUserPoliciesResponse EndListUserPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Lists the users that have the specified path prefix. If there are none, the action
        /// returns an            empty list.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        ListUsersResponse ListUsers();

        /// <summary>
        /// Lists the users that have the specified path prefix. If there are none, the action
        /// returns an            empty list.
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from IdentityManagementService.</returns>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVirtualMFADevices

        /// <summary>
        /// Lists the virtual MFA devices under the AWS account by assignment status. If you
        /// do not            specify an assignment status, the action returns a list of all virtual MFA
        /// devices. Assignment            status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>. 
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        ListVirtualMFADevicesResponse ListVirtualMFADevices();

        /// <summary>
        /// Lists the virtual MFA devices under the AWS account by assignment status. If you
        /// do not            specify an assignment status, the action returns a list of all virtual MFA
        /// devices. Assignment            status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>. 
        /// 
        ///         
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualMFADevices
        ///         operation.</returns>
        IAsyncResult BeginListVirtualMFADevices(ListVirtualMFADevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualMFADevices.</param>
        /// 
        /// <returns>Returns a  ListVirtualMFADevicesResult from IdentityManagementService.</returns>
        ListVirtualMFADevicesResponse EndListVirtualMFADevices(IAsyncResult asyncResult);

        #endregion
        
        #region  PutGroupPolicy


        /// <summary>
        /// Adds (or updates) a policy document associated with the specified group. For information            about
        /// policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html"
        /// target="_blank">Overview of Policies</a> in <i>Using AWS Identity and Access Management</i>.
        /// 
        ///         
        /// <para>
        /// For information about limits on the number of policies you can associate with a group,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling                <code>PutGroupPolicy</code>. For information about setting up signatures
        /// and authorization            through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
        /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
        /// target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGroupPolicy
        ///         operation.</returns>
        IAsyncResult BeginPutGroupPolicy(PutGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupPolicy.</param>
        /// 
        /// <returns>Returns a  PutGroupPolicyResult from IdentityManagementService.</returns>
        PutGroupPolicyResponse EndPutGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRolePolicy


        /// <summary>
        /// Adds (or updates) a policy document associated with the specified role. For information
        /// about            policies, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html"
        /// target="_blank">Overview of Policies</a> in <i>Using AWS Identity and Access Management</i>.
        /// 
        ///         
        /// <para>
        /// For information about limits on the policies you can associate with a role, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling                <code>PutRolePolicy</code>. For information about setting up signatures
        /// and authorization            through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
        /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
        /// target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// 
        /// <returns>The response from the PutRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRolePolicy
        ///         operation.</returns>
        IAsyncResult BeginPutRolePolicy(PutRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRolePolicy.</param>
        /// 
        /// <returns>Returns a  PutRolePolicyResult from IdentityManagementService.</returns>
        PutRolePolicyResponse EndPutRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutUserPolicy


        /// <summary>
        /// Adds (or updates) a policy document associated with the specified user. For information
        /// about            policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html"
        /// target="_blank">Overview of Policies</a> in <i>Using AWS Identity and Access Management</i>.
        /// 
        ///         
        /// <para>
        /// For information about limits on the number of policies you can associate with a user,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling                <code>PutUserPolicy</code>. For information about setting up signatures
        /// and authorization            through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
        /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
        /// target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// 
        /// <returns>The response from the PutUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutUserPolicy
        ///         operation.</returns>
        IAsyncResult BeginPutUserPolicy(PutUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserPolicy.</param>
        /// 
        /// <returns>Returns a  PutUserPolicyResult from IdentityManagementService.</returns>
        PutUserPolicyResponse EndPutUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveRoleFromInstanceProfile


        /// <summary>
        /// Removes the specified role from the specified instance profile.
        /// 
        ///         <important>Make sure you do not have any Amazon EC2 instances running with the role
        /// you are            about to remove from the instance profile. Removing a role from an instance
        /// profile that is            associated with a running instance will break any applications running
        /// on the            instance.</important>        
        /// <para>
        /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.            For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRoleFromInstanceProfile
        ///         operation.</returns>
        IAsyncResult BeginRemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromInstanceProfile.</param>
        /// 
        /// <returns>Returns a  RemoveRoleFromInstanceProfileResult from IdentityManagementService.</returns>
        RemoveRoleFromInstanceProfileResponse EndRemoveRoleFromInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveUserFromGroup


        /// <summary>
        /// Removes the specified user from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveUserFromGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveUserFromGroup
        ///         operation.</returns>
        IAsyncResult BeginRemoveUserFromGroup(RemoveUserFromGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveUserFromGroup.</param>
        /// 
        /// <returns>Returns a  RemoveUserFromGroupResult from IdentityManagementService.</returns>
        RemoveUserFromGroupResponse EndRemoveUserFromGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ResyncMFADevice


        /// <summary>
        /// Synchronizes the specified MFA device with AWS servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice service method.</param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error            message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResyncMFADevice
        ///         operation.</returns>
        IAsyncResult BeginResyncMFADevice(ResyncMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResyncMFADevice.</param>
        /// 
        /// <returns>Returns a  ResyncMFADeviceResult from IdentityManagementService.</returns>
        ResyncMFADeviceResponse EndResyncMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccessKey


        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This            action can be used to disable a user's key as part of a key rotation work flow.
        /// 
        ///         
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly            based
        /// on the AWS access key ID used to sign the request. Because this action works for access            keys
        /// under the AWS account, this API can be used to manage root credentials even if the
        /// AWS            account has no associated users.
        /// </para>
        ///         
        /// <para>
        /// For information about rotating keys, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html"
        /// target="_blank">Managing Keys and Certificates</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessKey
        ///         operation.</returns>
        IAsyncResult BeginUpdateAccessKey(UpdateAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessKey.</param>
        /// 
        /// <returns>Returns a  UpdateAccessKeyResult from IdentityManagementService.</returns>
        UpdateAccessKeyResponse EndUpdateAccessKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountPasswordPolicy

        /// <summary>
        /// Updates the password policy settings for the account. For more information about using
        /// a            password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an                IAM Password Policy</a>.
        /// </summary>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy();

        /// <summary>
        /// Updates the password policy settings for the account. For more information about using
        /// a            password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an                IAM Password Policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountPasswordPolicy
        ///         operation.</returns>
        IAsyncResult BeginUpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAccountPasswordPolicyResult from IdentityManagementService.</returns>
        UpdateAccountPasswordPolicyResponse EndUpdateAccountPasswordPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssumeRolePolicy


        /// <summary>
        /// Updates the policy that grants an entity permission to assume a role. For more information
        /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with            Roles</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAssumeRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssumeRolePolicy
        ///         operation.</returns>
        IAsyncResult BeginUpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssumeRolePolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAssumeRolePolicyResult from IdentityManagementService.</returns>
        UpdateAssumeRolePolicyResponse EndUpdateAssumeRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates the name and/or the path of the specified group.
        /// 
        ///         <important> You should understand the implications of changing a group's path or
        /// name. For more          information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html"
        /// target="_blank">Renaming Users and Groups</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </important>        <note>To change a group name the requester must have appropriate permissions
        /// on both the source            object and the target object. For example, to change Managers
        /// to MGRs, the entity making the            request must have permission on Managers and MGRs,
        /// or must have permission on all (*). For            more information about permissions, see
        /// <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html"
        /// target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from IdentityManagementService.</returns>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLoginProfile


        /// <summary>
        /// Changes the password for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <exception cref="PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed            by the account password policy.
        /// </exception>
        UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoginProfile
        ///         operation.</returns>
        IAsyncResult BeginUpdateLoginProfile(UpdateLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoginProfile.</param>
        /// 
        /// <returns>Returns a  UpdateLoginProfileResult from IdentityManagementService.</returns>
        UpdateLoginProfileResponse EndUpdateLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSAMLProvider


        /// <summary>
        /// Updates the metadata document for an existing SAML provider.
        /// 
        ///         <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSAMLProvider
        ///         operation.</returns>
        IAsyncResult BeginUpdateSAMLProvider(UpdateSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  UpdateSAMLProviderResult from IdentityManagementService.</returns>
        UpdateSAMLProviderResponse EndUpdateSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServerCertificate


        /// <summary>
        /// Updates the name and/or the path of the specified server certificate.
        /// 
        ///         <important> You should understand the implications of changing a server certificate's
        /// path or            name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html"
        /// target="_blank">Managing Server Certificates</a> in <i>Using AWS Identity and Access
        /// Management</i>. </important>        <note>To change a server certificate name the requester
        /// must have appropriate permissions on            both the source object and the target object.
        /// For example, to change the name from            ProductionCert to ProdCert, the entity making
        /// the request must have permission on            ProductionCert and ProdCert, or must have permission
        /// on all (*). For more information about            permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html"
        /// target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServerCertificate
        ///         operation.</returns>
        IAsyncResult BeginUpdateServerCertificate(UpdateServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateServerCertificateResult from IdentityManagementService.</returns>
        UpdateServerCertificateResponse EndUpdateServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSigningCertificate


        /// <summary>
        /// Changes the status of the specified signing certificate from active to disabled, or
        /// vice            versa. This action can be used to disable a user's signing certificate as part
        /// of a            certificate rotation work flow.
        /// 
        ///         
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly            based
        /// on the AWS access key ID used to sign the request. Because this action works for access            keys
        /// under the AWS account, this API can be used to manage root credentials even if the
        /// AWS            account has no associated users.
        /// </para>
        ///         
        /// <para>
        /// For information about rotating certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html"
        /// target="_blank">Managing Keys and Certificates</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSigningCertificate
        ///         operation.</returns>
        IAsyncResult BeginUpdateSigningCertificate(UpdateSigningCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateSigningCertificateResult from IdentityManagementService.</returns>
        UpdateSigningCertificateResponse EndUpdateSigningCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the name and/or the path of the specified user.
        /// 
        ///         <important> You should understand the implications of changing a user's path or
        /// name. For more          information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html"
        /// target="_blank">Renaming Users and Groups</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </important>        <note>To change a user name the requester must have appropriate permissions
        /// on both the source            object and the target object. For example, to change Bob to Robert,
        /// the entity making the            request must have permission on Bob and Robert, or must have
        /// permission on all (*). For more            information about permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html"
        /// target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from IdentityManagementService.</returns>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadServerCertificate


        /// <summary>
        /// Uploads a server certificate entity for the AWS account. The server certificate entity            includes
        /// a public key certificate, a private key, and an optional certificate chain, which            should
        /// all be PEM-encoded.
        /// 
        ///         
        /// <para>
        /// For information about the number of server certificates you can upload, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
        /// target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         <note>Because the body of the public key certificate, private key, and the certificate
        /// chain can            be large, you should use POST rather than GET when calling                <code>UploadServerCertificate</code>.
        /// For information about setting up signatures and            authorization through the API, go
        /// to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
        /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
        /// target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="KeyPairMismatchException">
        /// The request was rejected because the public key certificate and the private key do
        /// not            match.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message            describes the specific error.
        /// </exception>
        UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadServerCertificate
        ///         operation.</returns>
        IAsyncResult BeginUploadServerCertificate(UploadServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadServerCertificate.</param>
        /// 
        /// <returns>Returns a  UploadServerCertificateResult from IdentityManagementService.</returns>
        UploadServerCertificateResponse EndUploadServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadSigningCertificate


        /// <summary>
        /// Uploads an X.509 signing certificate and associates it with the specified user. Some
        /// AWS            services use X.509 signing certificates to validate requests that are signed
        /// with a            corresponding private key. When you upload the certificate, its default status
        /// is                <code>Active</code>.
        /// 
        ///         
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly            based
        /// on the AWS access key ID used to sign the request. Because this action works for access            keys
        /// under the AWS account, this API can be used to manage root credentials even if the
        /// AWS            account has no associated users.
        /// </para>
        ///         <note>Because the body of a X.509 certificate can be large, you should use POST
        /// rather than GET            when calling <code>UploadSigningCertificate</code>. For information
        /// about setting up            signatures and authorization through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
        /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
        /// target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DuplicateCertificateException">
        /// The request was rejected because the same certificate is associated to another user
        /// under the            account.
        /// </exception>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="InvalidCertificateException">
        /// The request was rejected because the certificate is invalid.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message            describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadSigningCertificate
        ///         operation.</returns>
        IAsyncResult BeginUploadSigningCertificate(UploadSigningCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UploadSigningCertificateResult from IdentityManagementService.</returns>
        UploadSigningCertificateResponse EndUploadSigningCertificate(IAsyncResult asyncResult);

        #endregion
        
    }
}