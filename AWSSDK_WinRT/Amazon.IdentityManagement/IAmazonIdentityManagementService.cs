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
    /// of the IAM API. For general            information about IAM, see <a href="http://aws.amazon.com/iam/" target="_blank">AWS Identity                and Access Management (IAM)</a>. For the user guide
    /// for IAM, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/" target="_blank">Using
    /// IAM</a>.
    /// </para>
    /// <note>AWS provides SDKs that consist of libraries and sample code for various programming            languages
    /// and platforms (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a convenient            way
    /// to create programmatic access to IAM and AWS. For example, the SDKs take care of tasks            such
    /// as cryptographically signing requests (see below), managing errors, and retrying requests            automatically.
    /// For information about the AWS SDKs, including how to download and install them,            see
    /// the <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a> page.
    /// </note>
    /// <para>
    /// Using the IAM Query API, you make direct calls to the IAM web service. IAM supports            GET
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
    /// IAM supports AWS CloudTrail, which is a service that records AWS calls for your
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
    /// <ul>            <li><a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html" target="_blank">AWS Security Credentials</a>. This topic provides general information
    /// about the types of                credentials used for accessing AWS.</li>            <li><a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html" target="_blank">IAM                    Best Practices</a>. This topic presents a list of suggestions
    /// for using the IAM service                to help secure your AWS resources.</li>            <li><a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/" target="_blank">AWS Security Token Service</a>. This guide                describes how to create
    /// and use temporary security credentials.</li>            <li><a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" target="_blank">Signing AWS API Requests</a>. This set of topics walk you through
    /// the process of signing                a request using an access key ID and secret access key.</li>        </ul>
    /// </summary>
	public partial interface IAmazonIdentityManagementService : IDisposable
    {
 
        /// <summary>
        /// Adds the specified role to the specified instance profile. For more information about
        /// roles,            go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with                Roles</a>. For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the AddRoleToInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AddRoleToInstanceProfileResponse> AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest addRoleToInstanceProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Adds the specified user to the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup service method.</param>
        /// 
        /// <returns>The response from the AddUserToGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest addUserToGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Changes the password of the IAM user calling <code>ChangePassword</code>. The root
        /// account            password is not affected by this action. For information about modifying
        /// passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html" target="_blank">Managing Passwords</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidUserTypeException">
        /// The request was rejected because the type of user for the transaction was incorrect.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed            by the account password policy.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest changePasswordRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// <important>To ensure the security of your AWS account, the secret access key is
        /// accessible only            during key and user creation. You must save the key (for example,
        /// in a text file) if you want            to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the            associated user and then create new keys.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey service method.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest createAccessKeyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// This action creates an alias for your AWS account. For information about using an
        /// AWS account            alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html" target="_blank">Using an Alias for Your AWS Account ID</a> in <i>Using AWS Identity
        /// and Access                Management</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateAccountAliasResponse> CreateAccountAliasAsync(CreateAccountAliasRequest createAccountAliasRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a new group.
        /// 
        /// 
        /// <para>
        /// For information about the number of groups you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest createGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a new instance profile. For information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>.
        /// 
        /// 
        /// <para>
        /// For information about the number of instance profiles you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest createInstanceProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a password for the specified user, giving the user the ability to access AWS
        /// services            through the AWS Management Console. For more information about managing
        /// passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html" target="_blank">Managing Passwords</a> in <i>Using IAM</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed            by the account password policy.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest createLoginProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a new role for your AWS account. For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.            For information about limitations on role names and the number of
        /// roles you can create, go to                <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest createRoleRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateSAMLProviderResponse> CreateSAMLProviderAsync(CreateSAMLProviderRequest createSAMLProviderRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a new user for your AWS account.
        /// 
        /// 
        /// <para>
        /// For information about limitations on the number of users you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
        /// use <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_EnableMFADevice.html" target="_blank">EnableMFADevice</a> to attach the MFA device to an IAM user. For more
        /// information about            creating and working with virtual MFA devices, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html" target="_blank">Using a Virtual MFA Device</a> in <i>Using AWS Identity and Access
        /// Management</i>.
        /// 
        /// 
        /// <para>
        /// For information about limits on the number of MFA devices you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// <important>The seed information contained in the QR code and the Base32 string should
        /// be treated            like any other secret access information, such as your AWS access keys
        /// or your passwords.            After you provision your virtual device, you should ensure that
        /// the information is destroyed            following secure procedures.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest createVirtualMFADeviceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deactivates the specified MFA device and removes it from association with the user
        /// name for            which it was originally enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeactivateMFADeviceResponse> DeactivateMFADeviceAsync(DeactivateMFADeviceRequest deactivateMFADeviceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest deleteAccessKeyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified AWS account alias. For information about using an AWS account
        /// alias,            see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html" target="_blank">Using an                Alias for Your AWS Account ID</a> in <i>Using AWS Identity
        /// and Access Management</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest deleteAccountAliasRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the password policy for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest deleteAccountPasswordPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified group. The group must not contain any users or have any attached            policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest deleteGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified policy that is associated with the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteGroupPolicyResponse> DeleteGroupPolicyAsync(DeleteGroupPolicyRequest deleteGroupPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified instance profile. The instance profile must not have an associated            role.
        /// 
        /// <important>Make sure you do not have any Amazon EC2 instances running with the instance
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest deleteInstanceProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the password for the specified user, which terminates the user's ability to
        /// access            AWS services through the AWS Management Console.
        /// 
        /// <important>Deleting a user's password does not prevent a user from accessing IAM
        /// through the            command line interface or the API. To prevent all user access you must
        /// also either make the            access key inactive or delete it. For more information about
        /// making keys inactive or deleting            them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
        /// </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest deleteLoginProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified role. The role must not have any policies attached. For more            information
        /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with            Roles</a>.
        /// 
        /// <important>Make sure you do not have any Amazon EC2 instances running with the role
        /// you are            about to delete. Deleting a role or instance profile that is associated
        /// with a running            instance will break any applications running on the instance.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole service method.</param>
        /// 
        /// <returns>The response from the DeleteRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest deleteRoleRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified policy associated with the specified role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteRolePolicyResponse> DeleteRolePolicyAsync(DeleteRolePolicyRequest deleteRolePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes a SAML provider.
        /// 
        /// 
        /// <para>
        /// Deleting the provider does not update any roles that reference the SAML provider as
        /// a            principal in their trust policies. Any attempt to assume a role that references
        /// a SAML            provider that has been deleted will fail.
        /// </para>
        /// <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteSAMLProviderResponse> DeleteSAMLProviderAsync(DeleteSAMLProviderRequest deleteSAMLProviderRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified server certificate.
        /// 
        /// <important>If you are using a server certificate with Elastic Load Balancing, deleting
        /// the            certificate could have implications for your application. If Elastic Load Balancing
        /// doesn't            detect the deletion of bound certificates, it may continue to use the certificates.
        /// This could            cause Elastic Load Balancing to stop accepting traffic. We recommend
        /// that you remove the            reference to the certificate from Elastic Load Balancing before
        /// using this command to delete            the certificate. For more information, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html" target="blank">DeleteLoadBalancerListeners</a> in the <i>Elastic Load Balancing API                Reference</i>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest deleteServerCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteSigningCertificateResponse> DeleteSigningCertificateAsync(DeleteSigningCertificateRequest deleteSigningCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified user. The user must not belong to any groups, have any keys
        /// or signing            certificates, or have any attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest deleteUserRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified policy associated with the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteUserPolicyResponse> DeleteUserPolicyAsync(DeleteUserPolicyRequest deleteUserPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        /// <note>You must deactivate a user's virtual MFA device before you can delete it.
        /// For information            about deactivating MFA devices, see <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached            subordinate
        /// entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest deleteVirtualMFADeviceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Enables the specified MFA device and associates it with the specified user name. When            enabled,
        /// the MFA device is required for every subsequent login by the user name associated            with
        /// the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error            message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EnableMFADeviceResponse> EnableMFADeviceAsync(EnableMFADeviceRequest enableMFADeviceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a            password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an                IAM Password Policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest getAccountPasswordPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves account level information about account entity usage and IAM quotas.
        /// 
        /// 
        /// <para>
        /// For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary service method.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetAccountSummaryResponse> GetAccountSummaryAsync(GetAccountSummaryRequest getAccountSummaryRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list of users that are in the specified group. You can paginate the results
        /// using            the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetGroupResponse> GetGroupAsync(GetGroupRequest getGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves the specified policy document for the specified group. The returned policy
        /// is            URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetGroupPolicyResponse> GetGroupPolicyAsync(GetGroupPolicyRequest getGroupPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's            path, GUID, ARN, and role. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance                Profiles</a>. For more information about ARNs, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs">ARNs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetInstanceProfileResponse> GetInstanceProfileAsync(GetInstanceProfileRequest getInstanceProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves the user name and password-creation date for the specified user. If the
        /// user has            not been assigned a password, the action returns a 404 (<code>NoSuchEntity</code>)
        /// error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile service method.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest getLoginProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetRoleResponse> GetRoleAsync(GetRoleRequest getRoleRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetRolePolicyResponse> GetRolePolicyAsync(GetRolePolicyRequest getRolePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns the SAML provider metadocument that was uploaded when the provider was created
        /// or            updated.
        /// 
        /// <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.        </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetSAMLProviderResponse> GetSAMLProviderAsync(GetSAMLProviderRequest getSAMLProviderRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves information about the specified server certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate service method.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetServerCertificateResponse> GetServerCertificateAsync(GetServerCertificateRequest getServerCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetUserResponse> GetUserAsync(GetUserRequest getUserRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Retrieves the specified policy document for the specified user. The returned policy
        /// is            URL-encoded according to RFC 3986. For more information about RFC 3986, go to
        /// <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetUserPolicyResponse> GetUserPolicyAsync(GetUserPolicyRequest getUserPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <note>To ensure the security of your AWS account, the secret access key is accessible
        /// only            during key and user creation.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest listAccessKeysRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Lists the account aliases associated with the account. For information about using
        /// an AWS            account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html" target="_blank">Using an Alias for Your AWS Account ID</a> in <i>Using AWS Identity
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListAccountAliasesResponse> ListAccountAliasesAsync(ListAccountAliasesRequest listAccountAliasesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListGroupPoliciesResponse> ListGroupPoliciesAsync(ListGroupPoliciesRequest listGroupPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest listGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest listGroupsForUserRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(ListInstanceProfilesRequest listInstanceProfilesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListInstanceProfilesForRoleResponse> ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest listInstanceProfilesForRoleRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListMFADevicesResponse> ListMFADevicesAsync(ListMFADevicesRequest listMFADevicesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListRolePoliciesResponse> ListRolePoliciesAsync(ListRolePoliciesRequest listRolePoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListRolesResponse> ListRolesAsync(ListRolesRequest listRolesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Lists the SAML providers in the account.
        /// 
        /// <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(ListSAMLProvidersRequest listSAMLProvidersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListServerCertificatesResponse> ListServerCertificatesAsync(ListServerCertificatesRequest listServerCertificatesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(ListSigningCertificatesRequest listSigningCertificatesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListUserPoliciesResponse> ListUserPoliciesAsync(ListUserPoliciesRequest listUserPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListUsersResponse> ListUsersAsync(ListUsersRequest listUsersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest listVirtualMFADevicesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Adds (or updates) a policy document associated with the specified group. For information            about
        /// policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html" target="_blank">Overview of Policies</a> in <i>Using AWS Identity and Access Management</i>.
        /// 
        /// 
        /// <para>
        /// For information about limits on the number of policies you can associate with a group,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling                <code>PutGroupPolicy</code>. For information about setting up signatures
        /// and authorization            through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html" target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutGroupPolicyResponse> PutGroupPolicyAsync(PutGroupPolicyRequest putGroupPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Adds (or updates) a policy document associated with the specified role. For information
        /// about            policies, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html" target="_blank">Overview of Policies</a> in <i>Using AWS Identity and Access Management</i>.
        /// 
        /// 
        /// <para>
        /// For information about limits on the policies you can associate with a role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling                <code>PutRolePolicy</code>. For information about setting up signatures
        /// and authorization            through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html" target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// 
        /// <returns>The response from the PutRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutRolePolicyResponse> PutRolePolicyAsync(PutRolePolicyRequest putRolePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Adds (or updates) a policy document associated with the specified user. For information
        /// about            policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html" target="_blank">Overview of Policies</a> in <i>Using AWS Identity and Access Management</i>.
        /// 
        /// 
        /// <para>
        /// For information about limits on the number of policies you can associate with a user,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling                <code>PutUserPolicy</code>. For information about setting up signatures
        /// and authorization            through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html" target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// 
        /// <returns>The response from the PutUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutUserPolicyResponse> PutUserPolicyAsync(PutUserPolicyRequest putUserPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Removes the specified role from the specified instance profile.
        /// 
        /// <important>Make sure you do not have any Amazon EC2 instances running with the role
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
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RemoveRoleFromInstanceProfileResponse> RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest removeRoleFromInstanceProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Removes the specified user from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveUserFromGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest removeUserFromGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Synchronizes the specified MFA device with AWS servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice service method.</param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error            message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ResyncMFADeviceResponse> ResyncMFADeviceAsync(ResyncMFADeviceRequest resyncMFADeviceRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// For information about rotating keys, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html" target="_blank">Managing Keys and Certificates</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest updateAccessKeyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the password policy settings for the account. For more information about using
        /// a            password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an                IAM Password Policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest updateAccountPasswordPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the policy that grants an entity permission to assume a role. For more information
        /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with            Roles</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAssumeRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message            describes
        /// the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest updateAssumeRolePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the name and/or the path of the specified group.
        /// 
        /// <important> You should understand the implications of changing a group's path or
        /// name. For more          information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html" target="_blank">Renaming Users and Groups</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </important>        <note>To change a group name the requester must have appropriate permissions
        /// on both the source            object and the target object. For example, to change Managers
        /// to MGRs, the entity making the            request must have permission on Managers and MGRs,
        /// or must have permission on all (*). For            more information about permissions, see
        /// <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html" target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest updateGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Changes the password for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed            by the account password policy.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest updateLoginProfileRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the metadata document for an existing SAML provider.
        /// 
        /// <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version            4</a>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateSAMLProviderResponse> UpdateSAMLProviderAsync(UpdateSAMLProviderRequest updateSAMLProviderRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the name and/or the path of the specified server certificate.
        /// 
        /// <important> You should understand the implications of changing a server certificate's
        /// path or            name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html" target="_blank">Managing Server Certificates</a> in <i>Using AWS Identity and Access
        /// Management</i>. </important>        <note>To change a server certificate name the requester
        /// must have appropriate permissions on            both the source object and the target object.
        /// For example, to change the name from            ProductionCert to ProdCert, the entity making
        /// the request must have permission on            ProductionCert and ProdCert, or must have permission
        /// on all (*). For more information about            permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html" target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateServerCertificateResponse> UpdateServerCertificateAsync(UpdateServerCertificateRequest updateServerCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// For information about rotating certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html" target="_blank">Managing Keys and Certificates</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateSigningCertificateResponse> UpdateSigningCertificateAsync(UpdateSigningCertificateRequest updateSigningCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the name and/or the path of the specified user.
        /// 
        /// <important> You should understand the implications of changing a user's path or
        /// name. For more          information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html" target="_blank">Renaming Users and Groups</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </important>        <note>To change a user name the requester must have appropriate permissions
        /// on both the source            object and the target object. For example, to change Bob to Robert,
        /// the entity making the            request must have permission on Bob and Robert, or must have
        /// permission on all (*). For more            information about permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html" target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,            such
        /// as a user name that was deleted and then recreated. The error indicates that the request            is
        /// likely to succeed if you try again after waiting several minutes. The error message            describes
        /// the entity.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest updateUserRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Uploads a server certificate entity for the AWS account. The server certificate entity            includes
        /// a public key certificate, a private key, and an optional certificate chain, which            should
        /// all be PEM-encoded.
        /// 
        /// 
        /// <para>
        /// For information about the number of server certificates you can upload, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html" target="_blank">Limitations on IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        /// <note>Because the body of the public key certificate, private key, and the certificate
        /// chain can            be large, you should use POST rather than GET when calling                <code>UploadServerCertificate</code>.
        /// For information about setting up signatures and            authorization through the API, go
        /// to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html" target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.KeyPairMismatchException">
        /// The request was rejected because the public key certificate and the private key do
        /// not            match.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message            describes the specific error.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest uploadServerCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
        /// <note>Because the body of a X.509 certificate can be large, you should use POST
        /// rather than GET            when calling <code>UploadSigningCertificate</code>. For information
        /// about setting up            signatures and authorization through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html" target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
        /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html" target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="T:Amazon.IdentityManagement.Model.DuplicateCertificateException">
        /// The request was rejected because the same certificate is associated to another user
        /// under the            account.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.InvalidCertificateException">
        /// The request was rejected because the certificate is invalid.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS            account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message            describes the specific error.
        /// </exception>
        /// <exception cref="T:Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error            message describes the entity.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UploadSigningCertificateResponse> UploadSigningCertificateAsync(UploadSigningCertificateRequest uploadSigningCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
