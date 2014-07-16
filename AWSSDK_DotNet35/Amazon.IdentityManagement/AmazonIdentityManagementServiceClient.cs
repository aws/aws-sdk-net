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
using System.Threading;

using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Implementation for accessing IdentityManagementService
    ///
    /// AWS Identity and Access Management 
    /// <para>
    /// AWS Identity and Access Management (IAM) is a web service that you can use to manage
    /// users and user permissions under your AWS account. This guide provides descriptions
    /// of the IAM API. For general information about IAM, see <a href="http://aws.amazon.com/iam/">AWS
    /// Identity and Access Management (IAM)</a>. For the user guide for IAM, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/">Using
    /// IAM</a>. 
    /// </para>
    ///  
    /// <para>
    ///  Using the IAM Query API, you make direct calls to the IAM web service. IAM supports
    /// GET and POST requests for all actions. That is, the API does not require you to use
    /// GET for some actions and POST for others. However, GET requests are subject to the
    /// limitation size of a URL. Therefore, for operations that require larger sizes, use
    /// a POST request. 
    /// </para>
    ///  
    /// <para>
    /// <b>Signing Requests</b>
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed using an access key ID and a secret access key. We strongly
    /// recommend that you do not use your AWS account access key ID and secret access key
    /// for everyday work with IAM. You can use the access key ID and secret access key for
    /// an IAM user or you can use the AWS Security Token Service to generate temporary security
    /// credentials and use those to sign requests. 
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
    /// <b>Recording API requests</b>
    /// </para>
    ///  
    /// <para>
    ///  IAM supports AWS CloudTrail, which is a service that records AWS calls for your AWS
    /// account and delivers log files to an Amazon S3 bucket. By using information collected
    /// by CloudTrail, you can determine what requests were successfully made to IAM, who
    /// made the request, when it was made, and so on. To learn more about CloudTrail, including
    /// how to turn it on and find your log files, see the <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/whatisawscloudtrail.html">AWS
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
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a>. This topic provides general information about the types
    /// of credentials used for accessing AWS.</li> <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html">IAM
    /// Best Practices</a>. This topic presents a list of suggestions for using the IAM service
    /// to help secure your AWS resources.</li> <li> <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/">AWS
    /// Security Token Service</a>. This guide describes how to create and use temporary security
    /// credentials.</li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a>. This set of topics walk you through the process of signing a
    /// request using an access key ID and secret access key.</li> </ul>
    /// </summary>
    public partial class AmazonIdentityManagementServiceClient : AmazonWebServiceClient, IAmazonIdentityManagementService
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
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
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
        public AmazonIdentityManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
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
        public AmazonIdentityManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(AmazonIdentityManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIdentityManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials and an
        /// AmazonIdentityManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, AmazonIdentityManagementServiceConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIdentityManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIdentityManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  AddRoleToInstanceProfile


        /// <summary>
        /// Adds the specified role to the specified instance profile. For more information about
        /// roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the AddRoleToInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request)
        {
            IAsyncResult asyncResult = invokeAddRoleToInstanceProfile(request, null, null, true);
            return EndAddRoleToInstanceProfile(asyncResult);
        }

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
        public IAsyncResult BeginAddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeAddRoleToInstanceProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AddRoleToInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToInstanceProfile.</param>
        /// 
        /// <returns>Returns a  AddRoleToInstanceProfileResult from IdentityManagementService.</returns>
        public  AddRoleToInstanceProfileResponse EndAddRoleToInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation< AddRoleToInstanceProfileResponse>(asyncResult);
        }

        IAsyncResult invokeAddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new AddRoleToInstanceProfileRequestMarshaller();
            var unmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request)
        {
            IAsyncResult asyncResult = invokeAddUserToGroup(request, null, null, true);
            return EndAddUserToGroup(asyncResult);
        }

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
        public IAsyncResult BeginAddUserToGroup(AddUserToGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeAddUserToGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AddUserToGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUserToGroup.</param>
        /// 
        /// <returns>Returns a  AddUserToGroupResult from IdentityManagementService.</returns>
        public  AddUserToGroupResponse EndAddUserToGroup(IAsyncResult asyncResult)
        {
            return endOperation< AddUserToGroupResponse>(asyncResult);
        }

        IAsyncResult invokeAddUserToGroup(AddUserToGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new AddUserToGroupRequestMarshaller();
            var unmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ChangePassword


        /// <summary>
        /// Changes the password of the IAM user calling <code>ChangePassword</code>. The root
        /// account password is not affected by this action. For information about modifying passwords,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="InvalidUserTypeException">
        /// The request was rejected because the type of user for the transaction was incorrect.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            IAsyncResult asyncResult = invokeChangePassword(request, null, null, true);
            return EndChangePassword(asyncResult);
        }

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
        public IAsyncResult BeginChangePassword(ChangePasswordRequest request, AsyncCallback callback, object state)
        {
            return invokeChangePassword(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ChangePassword operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        /// 
        /// <returns>Returns a  ChangePasswordResult from IdentityManagementService.</returns>
        public  ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult)
        {
            return endOperation< ChangePasswordResponse>(asyncResult);
        }

        IAsyncResult invokeChangePassword(ChangePasswordRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ChangePasswordRequestMarshaller();
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateAccessKey

        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified
        /// user. The default status for new keys is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. Because this action works for access keys
        /// under the AWS account, you can use this API to manage root credentials even if the
        /// AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        ///  <important>To ensure the security of your AWS account, the secret access key is accessible
        /// only during key and user creation. You must save the key (for example, in a text file)
        /// if you want to be able to access it again. If a secret key is lost, you can delete
        /// the access keys for the associated user and then create new keys.</important>
        /// </summary>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public CreateAccessKeyResponse CreateAccessKey()
        {
            return CreateAccessKey(new CreateAccessKeyRequest());
        }

        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified
        /// user. The default status for new keys is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. Because this action works for access keys
        /// under the AWS account, you can use this API to manage root credentials even if the
        /// AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        ///  <important>To ensure the security of your AWS account, the secret access key is accessible
        /// only during key and user creation. You must save the key (for example, in a text file)
        /// if you want to be able to access it again. If a secret key is lost, you can delete
        /// the access keys for the associated user and then create new keys.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey service method.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request)
        {
            IAsyncResult asyncResult = invokeCreateAccessKey(request, null, null, true);
            return EndCreateAccessKey(asyncResult);
        }

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
        public IAsyncResult BeginCreateAccessKey(CreateAccessKeyRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateAccessKey(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessKey.</param>
        /// 
        /// <returns>Returns a  CreateAccessKeyResult from IdentityManagementService.</returns>
        public  CreateAccessKeyResponse EndCreateAccessKey(IAsyncResult asyncResult)
        {
            return endOperation< CreateAccessKeyResponse>(asyncResult);
        }

        IAsyncResult invokeCreateAccessKey(CreateAccessKeyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateAccessKeyRequestMarshaller();
            var unmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateAccountAlias


        /// <summary>
        /// This action creates an alias for your AWS account. For information about using an
        /// AWS account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        public CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request)
        {
            IAsyncResult asyncResult = invokeCreateAccountAlias(request, null, null, true);
            return EndCreateAccountAlias(asyncResult);
        }

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
        public IAsyncResult BeginCreateAccountAlias(CreateAccountAliasRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateAccountAlias(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAlias.</param>
        /// 
        /// <returns>Returns a  CreateAccountAliasResult from IdentityManagementService.</returns>
        public  CreateAccountAliasResponse EndCreateAccountAlias(IAsyncResult asyncResult)
        {
            return endOperation< CreateAccountAliasResponse>(asyncResult);
        }

        IAsyncResult invokeCreateAccountAlias(CreateAccountAliasRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateAccountAliasRequestMarshaller();
            var unmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a new group.
        /// 
        ///  
        /// <para>
        /// For information about the number of groups you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateGroup(request, null, null, true);
            return EndCreateGroup(asyncResult);
        }

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
        public IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from IdentityManagementService.</returns>
        public  CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateGroupRequestMarshaller();
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateInstanceProfile


        /// <summary>
        /// Creates a new instance profile. For information about instance profiles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// For information about the number of instance profiles you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        public CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            IAsyncResult asyncResult = invokeCreateInstanceProfile(request, null, null, true);
            return EndCreateInstanceProfile(asyncResult);
        }

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
        public IAsyncResult BeginCreateInstanceProfile(CreateInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateInstanceProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a  CreateInstanceProfileResult from IdentityManagementService.</returns>
        public  CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation< CreateInstanceProfileResponse>(asyncResult);
        }

        IAsyncResult invokeCreateInstanceProfile(CreateInstanceProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateInstanceProfileRequestMarshaller();
            var unmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateLoginProfile


        /// <summary>
        /// Creates a password for the specified user, giving the user the ability to access AWS
        /// services through the AWS Management Console. For more information about managing passwords,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        public CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request)
        {
            IAsyncResult asyncResult = invokeCreateLoginProfile(request, null, null, true);
            return EndCreateLoginProfile(asyncResult);
        }

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
        public IAsyncResult BeginCreateLoginProfile(CreateLoginProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateLoginProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoginProfile.</param>
        /// 
        /// <returns>Returns a  CreateLoginProfileResult from IdentityManagementService.</returns>
        public  CreateLoginProfileResponse EndCreateLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation< CreateLoginProfileResponse>(asyncResult);
        }

        IAsyncResult invokeCreateLoginProfile(CreateLoginProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateLoginProfileRequestMarshaller();
            var unmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateRole


        /// <summary>
        /// Creates a new role for your AWS account. For more information about roles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For information about limitations on role names and the number of
        /// roles you can create, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// 
        ///  
        /// <para>
        /// The example policy grants permission to an EC2 instance to assume the role. The policy
        /// is URL-encoded according to RFC 3986. For more information about RFC 3986, go to <a
        /// href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        public CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            IAsyncResult asyncResult = invokeCreateRole(request, null, null, true);
            return EndCreateRole(asyncResult);
        }

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
        public IAsyncResult BeginCreateRole(CreateRoleRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateRole(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRole.</param>
        /// 
        /// <returns>Returns a  CreateRoleResult from IdentityManagementService.</returns>
        public  CreateRoleResponse EndCreateRole(IAsyncResult asyncResult)
        {
            return endOperation< CreateRoleResponse>(asyncResult);
        }

        IAsyncResult invokeCreateRole(CreateRoleRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateRoleRequestMarshaller();
            var unmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateSAMLProvider


        /// <summary>
        /// Creates an IAM entity to describe an identity provider (IdP) that supports SAML 2.0.
        /// 
        ///  
        /// <para>
        /// The SAML provider that you create with this operation can be used as a principal in
        /// a role's trust policy to establish a trust relationship between AWS and a SAML identity
        /// provider. You can create an IAM role that supports Web-based single sign-on (SSO)
        /// to the AWS Management Console or one that supports API access to AWS. 
        /// </para>
        ///  
        /// <para>
        /// When you create the SAML provider, you upload an a SAML metadata document that you
        /// get from your IdP and that includes the issuer's name, expiration information, and
        /// keys that can be used to validate the SAML authentication response (assertions) that
        /// are received from the IdP. You must generate the metadata document using the identity
        /// management software that is used as your organization's IdP. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/STSMgmtConsole-SAML.html">Giving
        /// Console Access Using SAML</a> and <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingSAML.html">Creating
        /// Temporary Security Credentials for SAML Federation</a> in the <i>Using Temporary Credentials</i>
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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        public CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request)
        {
            IAsyncResult asyncResult = invokeCreateSAMLProvider(request, null, null, true);
            return EndCreateSAMLProvider(asyncResult);
        }

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
        public IAsyncResult BeginCreateSAMLProvider(CreateSAMLProviderRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateSAMLProvider(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  CreateSAMLProviderResult from IdentityManagementService.</returns>
        public  CreateSAMLProviderResponse EndCreateSAMLProvider(IAsyncResult asyncResult)
        {
            return endOperation< CreateSAMLProviderResponse>(asyncResult);
        }

        IAsyncResult invokeCreateSAMLProvider(CreateSAMLProviderRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateSAMLProviderRequestMarshaller();
            var unmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a new user for your AWS account.
        /// 
        ///  
        /// <para>
        /// For information about limitations on the number of users you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            IAsyncResult asyncResult = invokeCreateUser(request, null, null, true);
            return EndCreateUser(asyncResult);
        }

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
        public IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateUser(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from IdentityManagementService.</returns>
        public  CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return endOperation< CreateUserResponse>(asyncResult);
        }

        IAsyncResult invokeCreateUser(CreateUserRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateUserRequestMarshaller();
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateVirtualMFADevice


        /// <summary>
        /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
        /// use <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_EnableMFADevice.html">EnableMFADevice</a>
        /// to attach the MFA device to an IAM user. For more information about creating and working
        /// with virtual MFA devices, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a Virtual MFA Device</a> in the <i>Using IAM</i> guide.
        /// 
        ///  
        /// <para>
        /// For information about limits on the number of MFA devices you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        ///  <important>The seed information contained in the QR code and the Base32 string should
        /// be treated like any other secret access information, such as your AWS access keys
        /// or your passwords. After you provision your virtual device, you should ensure that
        /// the information is destroyed following secure procedures.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        public CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request)
        {
            IAsyncResult asyncResult = invokeCreateVirtualMFADevice(request, null, null, true);
            return EndCreateVirtualMFADevice(asyncResult);
        }

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
        public IAsyncResult BeginCreateVirtualMFADevice(CreateVirtualMFADeviceRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateVirtualMFADevice(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  CreateVirtualMFADeviceResult from IdentityManagementService.</returns>
        public  CreateVirtualMFADeviceResponse EndCreateVirtualMFADevice(IAsyncResult asyncResult)
        {
            return endOperation< CreateVirtualMFADeviceResponse>(asyncResult);
        }

        IAsyncResult invokeCreateVirtualMFADevice(CreateVirtualMFADeviceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateVirtualMFADeviceRequestMarshaller();
            var unmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeactivateMFADevice


        /// <summary>
        /// Deactivates the specified MFA device and removes it from association with the user
        /// name for which it was originally enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request)
        {
            IAsyncResult asyncResult = invokeDeactivateMFADevice(request, null, null, true);
            return EndDeactivateMFADevice(asyncResult);
        }

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
        public IAsyncResult BeginDeactivateMFADevice(DeactivateMFADeviceRequest request, AsyncCallback callback, object state)
        {
            return invokeDeactivateMFADevice(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMFADevice.</param>
        /// 
        /// <returns>Returns a  DeactivateMFADeviceResult from IdentityManagementService.</returns>
        public  DeactivateMFADeviceResponse EndDeactivateMFADevice(IAsyncResult asyncResult)
        {
            return endOperation< DeactivateMFADeviceResponse>(asyncResult);
        }

        IAsyncResult invokeDeactivateMFADevice(DeactivateMFADeviceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeactivateMFADeviceRequestMarshaller();
            var unmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteAccessKey


        /// <summary>
        /// Deletes the access key associated with the specified user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. Because this action works for access keys
        /// under the AWS account, you can use this API to manage root credentials even if the
        /// AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteAccessKey(request, null, null, true);
            return EndDeleteAccessKey(asyncResult);
        }

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
        public IAsyncResult BeginDeleteAccessKey(DeleteAccessKeyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteAccessKey(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessKey.</param>
        /// 
        /// <returns>Returns a  DeleteAccessKeyResult from IdentityManagementService.</returns>
        public  DeleteAccessKeyResponse EndDeleteAccessKey(IAsyncResult asyncResult)
        {
            return endOperation< DeleteAccessKeyResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteAccessKey(DeleteAccessKeyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteAccessKeyRequestMarshaller();
            var unmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteAccountAlias


        /// <summary>
        /// Deletes the specified AWS account alias. For information about using an AWS account
        /// alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteAccountAlias(request, null, null, true);
            return EndDeleteAccountAlias(asyncResult);
        }

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
        public IAsyncResult BeginDeleteAccountAlias(DeleteAccountAliasRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteAccountAlias(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAlias operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAliasResult from IdentityManagementService.</returns>
        public  DeleteAccountAliasResponse EndDeleteAccountAlias(IAsyncResult asyncResult)
        {
            return endOperation< DeleteAccountAliasResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteAccountAlias(DeleteAccountAliasRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteAccountAliasRequestMarshaller();
            var unmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteAccountPasswordPolicy

        /// <summary>
        /// Deletes the password policy for the AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy()
        {
            return DeleteAccountPasswordPolicy(new DeleteAccountPasswordPolicyRequest());
        }

        /// <summary>
        /// Deletes the password policy for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteAccountPasswordPolicy(request, null, null, true);
            return EndDeleteAccountPasswordPolicy(asyncResult);
        }

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
        public IAsyncResult BeginDeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteAccountPasswordPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccountPasswordPolicyResult from IdentityManagementService.</returns>
        public  DeleteAccountPasswordPolicyResponse EndDeleteAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return endOperation< DeleteAccountPasswordPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes the specified group. The group must not contain any users or have any attached
        /// policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteGroup(request, null, null, true);
            return EndDeleteGroup(asyncResult);
        }

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
        public IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from IdentityManagementService.</returns>
        public  DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteGroupRequestMarshaller();
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteGroupPolicy(request, null, null, true);
            return EndDeleteGroupPolicy(asyncResult);
        }

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
        public IAsyncResult BeginDeleteGroupPolicy(DeleteGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteGroupPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteGroupPolicyResult from IdentityManagementService.</returns>
        public  DeleteGroupPolicyResponse EndDeleteGroupPolicy(IAsyncResult asyncResult)
        {
            return endOperation< DeleteGroupPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteGroupPolicy(DeleteGroupPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteGroupPolicyRequestMarshaller();
            var unmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteInstanceProfile


        /// <summary>
        /// Deletes the specified instance profile. The instance profile must not have an associated
        /// role.
        /// 
        ///  <important>Make sure you do not have any Amazon EC2 instances running with the instance
        /// profile you are about to delete. Deleting a role or instance profile that is associated
        /// with a running instance will break any applications running on the instance.</important>
        /// 
        /// <para>
        /// For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteInstanceProfile(request, null, null, true);
            return EndDeleteInstanceProfile(asyncResult);
        }

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
        public IAsyncResult BeginDeleteInstanceProfile(DeleteInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteInstanceProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceProfileResult from IdentityManagementService.</returns>
        public  DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation< DeleteInstanceProfileResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteInstanceProfile(DeleteInstanceProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteInstanceProfileRequestMarshaller();
            var unmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteLoginProfile


        /// <summary>
        /// Deletes the password for the specified user, which terminates the user's ability to
        /// access AWS services through the AWS Management Console.
        /// 
        ///  <important>Deleting a user's password does not prevent a user from accessing IAM
        /// through the command line interface or the API. To prevent all user access you must
        /// also either make the access key inactive or delete it. For more information about
        /// making keys inactive or deleting them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
        /// </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteLoginProfile(request, null, null, true);
            return EndDeleteLoginProfile(asyncResult);
        }

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
        public IAsyncResult BeginDeleteLoginProfile(DeleteLoginProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteLoginProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoginProfile.</param>
        /// 
        /// <returns>Returns a  DeleteLoginProfileResult from IdentityManagementService.</returns>
        public  DeleteLoginProfileResponse EndDeleteLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation< DeleteLoginProfileResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteLoginProfile(DeleteLoginProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteLoginProfileRequestMarshaller();
            var unmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteRole


        /// <summary>
        /// Deletes the specified role. The role must not have any policies attached. For more
        /// information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  <important>Make sure you do not have any Amazon EC2 instances running with the role
        /// you are about to delete. Deleting a role or instance profile that is associated with
        /// a running instance will break any applications running on the instance.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole service method.</param>
        /// 
        /// <returns>The response from the DeleteRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteRole(request, null, null, true);
            return EndDeleteRole(asyncResult);
        }

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
        public IAsyncResult BeginDeleteRole(DeleteRoleRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteRole(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRole.</param>
        /// 
        /// <returns>Returns a  DeleteRoleResult from IdentityManagementService.</returns>
        public  DeleteRoleResponse EndDeleteRole(IAsyncResult asyncResult)
        {
            return endOperation< DeleteRoleResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteRole(DeleteRoleRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteRoleRequestMarshaller();
            var unmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteRolePolicy(request, null, null, true);
            return EndDeleteRolePolicy(asyncResult);
        }

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
        public IAsyncResult BeginDeleteRolePolicy(DeleteRolePolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteRolePolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRolePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRolePolicyResult from IdentityManagementService.</returns>
        public  DeleteRolePolicyResponse EndDeleteRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation< DeleteRolePolicyResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteRolePolicy(DeleteRolePolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteRolePolicyRequestMarshaller();
            var unmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteSAMLProvider


        /// <summary>
        /// Deletes a SAML provider.
        /// 
        ///  
        /// <para>
        /// Deleting the provider does not update any roles that reference the SAML provider as
        /// a principal in their trust policies. Any attempt to assume a role that references
        /// a SAML provider that has been deleted will fail. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteSAMLProvider(request, null, null, true);
            return EndDeleteSAMLProvider(asyncResult);
        }

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
        public IAsyncResult BeginDeleteSAMLProvider(DeleteSAMLProviderRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteSAMLProvider(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSAMLProvider.</param>
        /// 
        /// <returns>Returns a  DeleteSAMLProviderResult from IdentityManagementService.</returns>
        public  DeleteSAMLProviderResponse EndDeleteSAMLProvider(IAsyncResult asyncResult)
        {
            return endOperation< DeleteSAMLProviderResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteSAMLProvider(DeleteSAMLProviderRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteSAMLProviderRequestMarshaller();
            var unmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteServerCertificate


        /// <summary>
        /// Deletes the specified server certificate.
        /// 
        ///  <important>If you are using a server certificate with Elastic Load Balancing, deleting
        /// the certificate could have implications for your application. If Elastic Load Balancing
        /// doesn't detect the deletion of bound certificates, it may continue to use the certificates.
        /// This could cause Elastic Load Balancing to stop accepting traffic. We recommend that
        /// you remove the reference to the certificate from Elastic Load Balancing before using
        /// this command to delete the certificate. For more information, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html"
        /// target="blank">DeleteLoadBalancerListeners</a> in the <i>Elastic Load Balancing API
        /// Reference</i>.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteServerCertificate(request, null, null, true);
            return EndDeleteServerCertificate(asyncResult);
        }

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
        public IAsyncResult BeginDeleteServerCertificate(DeleteServerCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteServerCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteServerCertificateResult from IdentityManagementService.</returns>
        public  DeleteServerCertificateResponse EndDeleteServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation< DeleteServerCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteServerCertificate(DeleteServerCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteServerCertificateRequestMarshaller();
            var unmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteSigningCertificate


        /// <summary>
        /// Deletes the specified signing certificate associated with the specified user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. Because this action works for access keys
        /// under the AWS account, you can use this API to manage root credentials even if the
        /// AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteSigningCertificate(request, null, null, true);
            return EndDeleteSigningCertificate(asyncResult);
        }

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
        public IAsyncResult BeginDeleteSigningCertificate(DeleteSigningCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteSigningCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSigningCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteSigningCertificateResult from IdentityManagementService.</returns>
        public  DeleteSigningCertificateResponse EndDeleteSigningCertificate(IAsyncResult asyncResult)
        {
            return endOperation< DeleteSigningCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteSigningCertificate(DeleteSigningCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteSigningCertificateRequestMarshaller();
            var unmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the specified user. The user must not belong to any groups, have any keys
        /// or signing certificates, or have any attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteUser(request, null, null, true);
            return EndDeleteUser(asyncResult);
        }

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
        public IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteUser(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from IdentityManagementService.</returns>
        public  DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return endOperation< DeleteUserResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteUserPolicy(request, null, null, true);
            return EndDeleteUserPolicy(asyncResult);
        }

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
        public IAsyncResult BeginDeleteUserPolicy(DeleteUserPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteUserPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteUserPolicyResult from IdentityManagementService.</returns>
        public  DeleteUserPolicyResponse EndDeleteUserPolicy(IAsyncResult asyncResult)
        {
            return endOperation< DeleteUserPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteUserPolicy(DeleteUserPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteUserPolicyRequestMarshaller();
            var unmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteVirtualMFADevice


        /// <summary>
        /// Deletes a virtual MFA device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteVirtualMFADevice(request, null, null, true);
            return EndDeleteVirtualMFADevice(asyncResult);
        }

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
        public IAsyncResult BeginDeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteVirtualMFADevice(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualMFADeviceResult from IdentityManagementService.</returns>
        public  DeleteVirtualMFADeviceResponse EndDeleteVirtualMFADevice(IAsyncResult asyncResult)
        {
            return endOperation< DeleteVirtualMFADeviceResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteVirtualMFADeviceRequestMarshaller();
            var unmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  EnableMFADevice


        /// <summary>
        /// Enables the specified MFA device and associates it with the specified user name. When
        /// enabled, the MFA device is required for every subsequent login by the user name associated
        /// with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request)
        {
            IAsyncResult asyncResult = invokeEnableMFADevice(request, null, null, true);
            return EndEnableMFADevice(asyncResult);
        }

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
        public IAsyncResult BeginEnableMFADevice(EnableMFADeviceRequest request, AsyncCallback callback, object state)
        {
            return invokeEnableMFADevice(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMFADevice.</param>
        /// 
        /// <returns>Returns a  EnableMFADeviceResult from IdentityManagementService.</returns>
        public  EnableMFADeviceResponse EndEnableMFADevice(IAsyncResult asyncResult)
        {
            return endOperation< EnableMFADeviceResponse>(asyncResult);
        }

        IAsyncResult invokeEnableMFADevice(EnableMFADeviceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new EnableMFADeviceRequestMarshaller();
            var unmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GenerateCredentialReport

        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        public GenerateCredentialReportResponse GenerateCredentialReport()
        {
            return GenerateCredentialReport(new GenerateCredentialReportRequest());
        }

        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        public GenerateCredentialReportResponse GenerateCredentialReport(GenerateCredentialReportRequest request)
        {
            IAsyncResult asyncResult = invokeGenerateCredentialReport(request, null, null, true);
            return EndGenerateCredentialReport(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCredentialReport operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateCredentialReport
        ///         operation.</returns>
        public IAsyncResult BeginGenerateCredentialReport(GenerateCredentialReportRequest request, AsyncCallback callback, object state)
        {
            return invokeGenerateCredentialReport(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateCredentialReport operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateCredentialReport.</param>
        /// 
        /// <returns>Returns a  GenerateCredentialReportResult from IdentityManagementService.</returns>
        public  GenerateCredentialReportResponse EndGenerateCredentialReport(IAsyncResult asyncResult)
        {
            return endOperation< GenerateCredentialReportResponse>(asyncResult);
        }

        IAsyncResult invokeGenerateCredentialReport(GenerateCredentialReportRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GenerateCredentialReportRequestMarshaller();
            var unmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetAccountPasswordPolicy

        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a>.
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetAccountPasswordPolicyResponse GetAccountPasswordPolicy()
        {
            return GetAccountPasswordPolicy(new GetAccountPasswordPolicyRequest());
        }

        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeGetAccountPasswordPolicy(request, null, null, true);
            return EndGetAccountPasswordPolicy(asyncResult);
        }

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
        public IAsyncResult BeginGetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeGetAccountPasswordPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  GetAccountPasswordPolicyResult from IdentityManagementService.</returns>
        public  GetAccountPasswordPolicyResponse EndGetAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return endOperation< GetAccountPasswordPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeGetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetAccountSummary

        /// <summary>
        /// Retrieves account level information about account entity usage and IAM quotas.
        /// 
        ///  
        /// <para>
        /// For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        public GetAccountSummaryResponse GetAccountSummary()
        {
            return GetAccountSummary(new GetAccountSummaryRequest());
        }

        /// <summary>
        /// Retrieves account level information about account entity usage and IAM quotas.
        /// 
        ///  
        /// <para>
        /// For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary service method.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        public GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request)
        {
            IAsyncResult asyncResult = invokeGetAccountSummary(request, null, null, true);
            return EndGetAccountSummary(asyncResult);
        }

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
        public IAsyncResult BeginGetAccountSummary(GetAccountSummaryRequest request, AsyncCallback callback, object state)
        {
            return invokeGetAccountSummary(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSummary operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSummary.</param>
        /// 
        /// <returns>Returns a  GetAccountSummaryResult from IdentityManagementService.</returns>
        public  GetAccountSummaryResponse EndGetAccountSummary(IAsyncResult asyncResult)
        {
            return endOperation< GetAccountSummaryResponse>(asyncResult);
        }

        IAsyncResult invokeGetAccountSummary(GetAccountSummaryRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetAccountSummaryRequestMarshaller();
            var unmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetCredentialReport

        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>Using IAM</i> guide.
        /// </exception>
        /// <exception cref="CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        public GetCredentialReportResponse GetCredentialReport()
        {
            return GetCredentialReport(new GetCredentialReportRequest());
        }

        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>Using IAM</i> guide.
        /// </exception>
        /// <exception cref="CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        public GetCredentialReportResponse GetCredentialReport(GetCredentialReportRequest request)
        {
            IAsyncResult asyncResult = invokeGetCredentialReport(request, null, null, true);
            return EndGetCredentialReport(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialReport operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCredentialReport
        ///         operation.</returns>
        public IAsyncResult BeginGetCredentialReport(GetCredentialReportRequest request, AsyncCallback callback, object state)
        {
            return invokeGetCredentialReport(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentialReport operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentialReport.</param>
        /// 
        /// <returns>Returns a  GetCredentialReportResult from IdentityManagementService.</returns>
        public  GetCredentialReportResponse EndGetCredentialReport(IAsyncResult asyncResult)
        {
            return endOperation< GetCredentialReportResponse>(asyncResult);
        }

        IAsyncResult invokeGetCredentialReport(GetCredentialReportRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetCredentialReportRequestMarshaller();
            var unmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns a list of users that are in the specified group. You can paginate the results
        /// using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetGroupResponse GetGroup(GetGroupRequest request)
        {
            IAsyncResult asyncResult = invokeGetGroup(request, null, null, true);
            return EndGetGroup(asyncResult);
        }

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
        public IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeGetGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from IdentityManagementService.</returns>
        public  GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return endOperation< GetGroupResponse>(asyncResult);
        }

        IAsyncResult invokeGetGroup(GetGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetGroupRequestMarshaller();
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetGroupPolicy


        /// <summary>
        /// Retrieves the specified policy document for the specified group. The returned policy
        /// is URL-encoded according to RFC 3986. For more information about RFC 3986, go to <a
        /// href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeGetGroupPolicy(request, null, null, true);
            return EndGetGroupPolicy(asyncResult);
        }

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
        public IAsyncResult BeginGetGroupPolicy(GetGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeGetGroupPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetGroupPolicyResult from IdentityManagementService.</returns>
        public  GetGroupPolicyResponse EndGetGroupPolicy(IAsyncResult asyncResult)
        {
            return endOperation< GetGroupPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeGetGroupPolicy(GetGroupPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetGroupPolicyRequestMarshaller();
            var unmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetInstanceProfile


        /// <summary>
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's path, GUID, ARN, and role. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>. For more information about ARNs, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs">ARNs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request)
        {
            IAsyncResult asyncResult = invokeGetInstanceProfile(request, null, null, true);
            return EndGetInstanceProfile(asyncResult);
        }

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
        public IAsyncResult BeginGetInstanceProfile(GetInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeGetInstanceProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceProfile.</param>
        /// 
        /// <returns>Returns a  GetInstanceProfileResult from IdentityManagementService.</returns>
        public  GetInstanceProfileResponse EndGetInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation< GetInstanceProfileResponse>(asyncResult);
        }

        IAsyncResult invokeGetInstanceProfile(GetInstanceProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetInstanceProfileRequestMarshaller();
            var unmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetLoginProfile


        /// <summary>
        /// Retrieves the user name and password-creation date for the specified user. If the
        /// user has not been assigned a password, the action returns a 404 (<code>NoSuchEntity</code>)
        /// error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile service method.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request)
        {
            IAsyncResult asyncResult = invokeGetLoginProfile(request, null, null, true);
            return EndGetLoginProfile(asyncResult);
        }

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
        public IAsyncResult BeginGetLoginProfile(GetLoginProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeGetLoginProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoginProfile.</param>
        /// 
        /// <returns>Returns a  GetLoginProfileResult from IdentityManagementService.</returns>
        public  GetLoginProfileResponse EndGetLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation< GetLoginProfileResponse>(asyncResult);
        }

        IAsyncResult invokeGetLoginProfile(GetLoginProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetLoginProfileRequestMarshaller();
            var unmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetRole


        /// <summary>
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the policy granting permission to assume the role. For more information about
        /// ARNs, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs">ARNs</a>.
        /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRole service method.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetRoleResponse GetRole(GetRoleRequest request)
        {
            IAsyncResult asyncResult = invokeGetRole(request, null, null, true);
            return EndGetRole(asyncResult);
        }

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
        public IAsyncResult BeginGetRole(GetRoleRequest request, AsyncCallback callback, object state)
        {
            return invokeGetRole(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRole.</param>
        /// 
        /// <returns>Returns a  GetRoleResult from IdentityManagementService.</returns>
        public  GetRoleResponse EndGetRole(IAsyncResult asyncResult)
        {
            return endOperation< GetRoleResponse>(asyncResult);
        }

        IAsyncResult invokeGetRole(GetRoleRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetRoleRequestMarshaller();
            var unmarshaller = GetRoleResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetRolePolicy


        /// <summary>
        /// Retrieves the specified policy document for the specified role. For more information
        /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy service method.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request)
        {
            IAsyncResult asyncResult = invokeGetRolePolicy(request, null, null, true);
            return EndGetRolePolicy(asyncResult);
        }

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
        public IAsyncResult BeginGetRolePolicy(GetRolePolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeGetRolePolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRolePolicy.</param>
        /// 
        /// <returns>Returns a  GetRolePolicyResult from IdentityManagementService.</returns>
        public  GetRolePolicyResponse EndGetRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation< GetRolePolicyResponse>(asyncResult);
        }

        IAsyncResult invokeGetRolePolicy(GetRolePolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetRolePolicyRequestMarshaller();
            var unmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetSAMLProvider


        /// <summary>
        /// Returns the SAML provider metadocument that was uploaded when the provider was created
        /// or updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request)
        {
            IAsyncResult asyncResult = invokeGetSAMLProvider(request, null, null, true);
            return EndGetSAMLProvider(asyncResult);
        }

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
        public IAsyncResult BeginGetSAMLProvider(GetSAMLProviderRequest request, AsyncCallback callback, object state)
        {
            return invokeGetSAMLProvider(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSAMLProvider.</param>
        /// 
        /// <returns>Returns a  GetSAMLProviderResult from IdentityManagementService.</returns>
        public  GetSAMLProviderResponse EndGetSAMLProvider(IAsyncResult asyncResult)
        {
            return endOperation< GetSAMLProviderResponse>(asyncResult);
        }

        IAsyncResult invokeGetSAMLProvider(GetSAMLProviderRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetSAMLProviderRequestMarshaller();
            var unmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

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
        /// error message describes the entity.
        /// </exception>
        public GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeGetServerCertificate(request, null, null, true);
            return EndGetServerCertificate(asyncResult);
        }

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
        public IAsyncResult BeginGetServerCertificate(GetServerCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeGetServerCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerCertificate.</param>
        /// 
        /// <returns>Returns a  GetServerCertificateResult from IdentityManagementService.</returns>
        public  GetServerCertificateResponse EndGetServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation< GetServerCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeGetServerCertificate(GetServerCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetServerCertificateRequestMarshaller();
            var unmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Retrieves information about the specified user, including the user's path, unique
        /// ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetUserResponse GetUser()
        {
            return GetUser(new GetUserRequest());
        }

        /// <summary>
        /// Retrieves information about the specified user, including the user's path, unique
        /// ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            IAsyncResult asyncResult = invokeGetUser(request, null, null, true);
            return EndGetUser(asyncResult);
        }

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
        public IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state)
        {
            return invokeGetUser(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from IdentityManagementService.</returns>
        public  GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return endOperation< GetUserResponse>(asyncResult);
        }

        IAsyncResult invokeGetUser(GetUserRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetUserRequestMarshaller();
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  GetUserPolicy


        /// <summary>
        /// Retrieves the specified policy document for the specified user. The returned policy
        /// is URL-encoded according to RFC 3986. For more information about RFC 3986, go to <a
        /// href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeGetUserPolicy(request, null, null, true);
            return EndGetUserPolicy(asyncResult);
        }

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
        public IAsyncResult BeginGetUserPolicy(GetUserPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeGetUserPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPolicy.</param>
        /// 
        /// <returns>Returns a  GetUserPolicyResult from IdentityManagementService.</returns>
        public  GetUserPolicyResponse EndGetUserPolicy(IAsyncResult asyncResult)
        {
            return endOperation< GetUserPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeGetUserPolicy(GetUserPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new GetUserPolicyRequestMarshaller();
            var unmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListAccessKeys

        /// <summary>
        /// Returns information about the access key IDs associated with the specified user. If
        /// there are none, the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, this API can be used to manage root credentials
        /// even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListAccessKeysResponse ListAccessKeys()
        {
            return ListAccessKeys(new ListAccessKeysRequest());
        }

        /// <summary>
        /// Returns information about the access key IDs associated with the specified user. If
        /// there are none, the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, this API can be used to manage root credentials
        /// even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request)
        {
            IAsyncResult asyncResult = invokeListAccessKeys(request, null, null, true);
            return EndListAccessKeys(asyncResult);
        }

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
        public IAsyncResult BeginListAccessKeys(ListAccessKeysRequest request, AsyncCallback callback, object state)
        {
            return invokeListAccessKeys(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessKeys operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessKeys.</param>
        /// 
        /// <returns>Returns a  ListAccessKeysResult from IdentityManagementService.</returns>
        public  ListAccessKeysResponse EndListAccessKeys(IAsyncResult asyncResult)
        {
            return endOperation< ListAccessKeysResponse>(asyncResult);
        }

        IAsyncResult invokeListAccessKeys(ListAccessKeysRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListAccessKeysRequestMarshaller();
            var unmarshaller = ListAccessKeysResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListAccountAliases

        /// <summary>
        /// Lists the account aliases associated with the account. For information about using
        /// an AWS account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>Using IAM</i> guide.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        public ListAccountAliasesResponse ListAccountAliases()
        {
            return ListAccountAliases(new ListAccountAliasesRequest());
        }

        /// <summary>
        /// Lists the account aliases associated with the account. For information about using
        /// an AWS account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>Using IAM</i> guide.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases service method.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        public ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request)
        {
            IAsyncResult asyncResult = invokeListAccountAliases(request, null, null, true);
            return EndListAccountAliases(asyncResult);
        }

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
        public IAsyncResult BeginListAccountAliases(ListAccountAliasesRequest request, AsyncCallback callback, object state)
        {
            return invokeListAccountAliases(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAliases operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAliases.</param>
        /// 
        /// <returns>Returns a  ListAccountAliasesResult from IdentityManagementService.</returns>
        public  ListAccountAliasesResponse EndListAccountAliases(IAsyncResult asyncResult)
        {
            return endOperation< ListAccountAliasesResponse>(asyncResult);
        }

        IAsyncResult invokeListAccountAliases(ListAccountAliasesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListAccountAliasesRequestMarshaller();
            var unmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListGroupPolicies


        /// <summary>
        /// Lists the names of the policies associated with the specified group. If there are
        /// none, the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request)
        {
            IAsyncResult asyncResult = invokeListGroupPolicies(request, null, null, true);
            return EndListGroupPolicies(asyncResult);
        }

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
        public IAsyncResult BeginListGroupPolicies(ListGroupPoliciesRequest request, AsyncCallback callback, object state)
        {
            return invokeListGroupPolicies(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupPolicies.</param>
        /// 
        /// <returns>Returns a  ListGroupPoliciesResult from IdentityManagementService.</returns>
        public  ListGroupPoliciesResponse EndListGroupPolicies(IAsyncResult asyncResult)
        {
            return endOperation< ListGroupPoliciesResponse>(asyncResult);
        }

        IAsyncResult invokeListGroupPolicies(ListGroupPoliciesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListGroupPoliciesRequestMarshaller();
            var unmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Lists the groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        public ListGroupsResponse ListGroups()
        {
            return ListGroups(new ListGroupsRequest());
        }

        /// <summary>
        /// Lists the groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeListGroups(request, null, null, true);
            return EndListGroups(asyncResult);
        }

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
        public IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeListGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from IdentityManagementService.</returns>
        public  ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return endOperation< ListGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeListGroups(ListGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListGroupsRequestMarshaller();
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListGroupsForUser


        /// <summary>
        /// Lists the groups the specified user belongs to.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser service method.</param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            IAsyncResult asyncResult = invokeListGroupsForUser(request, null, null, true);
            return EndListGroupsForUser(asyncResult);
        }

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
        public IAsyncResult BeginListGroupsForUser(ListGroupsForUserRequest request, AsyncCallback callback, object state)
        {
            return invokeListGroupsForUser(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupsForUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForUser.</param>
        /// 
        /// <returns>Returns a  ListGroupsForUserResult from IdentityManagementService.</returns>
        public  ListGroupsForUserResponse EndListGroupsForUser(IAsyncResult asyncResult)
        {
            return endOperation< ListGroupsForUserResponse>(asyncResult);
        }

        IAsyncResult invokeListGroupsForUser(ListGroupsForUserRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListGroupsForUserRequestMarshaller();
            var unmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListInstanceProfiles

        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the action returns an empty list. For more information about instance profiles, go
        /// to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        public ListInstanceProfilesResponse ListInstanceProfiles()
        {
            return ListInstanceProfiles(new ListInstanceProfilesRequest());
        }

        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the action returns an empty list. For more information about instance profiles, go
        /// to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        public ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request)
        {
            IAsyncResult asyncResult = invokeListInstanceProfiles(request, null, null, true);
            return EndListInstanceProfiles(asyncResult);
        }

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
        public IAsyncResult BeginListInstanceProfiles(ListInstanceProfilesRequest request, AsyncCallback callback, object state)
        {
            return invokeListInstanceProfiles(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfiles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfiles.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesResult from IdentityManagementService.</returns>
        public  ListInstanceProfilesResponse EndListInstanceProfiles(IAsyncResult asyncResult)
        {
            return endOperation< ListInstanceProfilesResponse>(asyncResult);
        }

        IAsyncResult invokeListInstanceProfiles(ListInstanceProfilesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListInstanceProfilesRequestMarshaller();
            var unmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListInstanceProfilesForRole


        /// <summary>
        /// Lists the instance profiles that have the specified associated role. If there are
        /// none, the action returns an empty list. For more information about instance profiles,
        /// go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request)
        {
            IAsyncResult asyncResult = invokeListInstanceProfilesForRole(request, null, null, true);
            return EndListInstanceProfilesForRole(asyncResult);
        }

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
        public IAsyncResult BeginListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request, AsyncCallback callback, object state)
        {
            return invokeListInstanceProfilesForRole(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfilesForRole operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfilesForRole.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesForRoleResult from IdentityManagementService.</returns>
        public  ListInstanceProfilesForRoleResponse EndListInstanceProfilesForRole(IAsyncResult asyncResult)
        {
            return endOperation< ListInstanceProfilesForRoleResponse>(asyncResult);
        }

        IAsyncResult invokeListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListInstanceProfilesForRoleRequestMarshaller();
            var unmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListMFADevices

        /// <summary>
        /// Lists the MFA devices. If the request includes the user name, then this action lists
        /// all the MFA devices associated with the specified user name. If you do not specify
        /// a user name, IAM determines the user name implicitly based on the AWS access key ID
        /// signing the request.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListMFADevicesResponse ListMFADevices()
        {
            return ListMFADevices(new ListMFADevicesRequest());
        }

        /// <summary>
        /// Lists the MFA devices. If the request includes the user name, then this action lists
        /// all the MFA devices associated with the specified user name. If you do not specify
        /// a user name, IAM determines the user name implicitly based on the AWS access key ID
        /// signing the request.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request)
        {
            IAsyncResult asyncResult = invokeListMFADevices(request, null, null, true);
            return EndListMFADevices(asyncResult);
        }

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
        public IAsyncResult BeginListMFADevices(ListMFADevicesRequest request, AsyncCallback callback, object state)
        {
            return invokeListMFADevices(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMFADevices.</param>
        /// 
        /// <returns>Returns a  ListMFADevicesResult from IdentityManagementService.</returns>
        public  ListMFADevicesResponse EndListMFADevices(IAsyncResult asyncResult)
        {
            return endOperation< ListMFADevicesResponse>(asyncResult);
        }

        IAsyncResult invokeListMFADevices(ListMFADevicesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListMFADevicesRequestMarshaller();
            var unmarshaller = ListMFADevicesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListRolePolicies


        /// <summary>
        /// Lists the names of the policies associated with the specified role. If there are none,
        /// the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request)
        {
            IAsyncResult asyncResult = invokeListRolePolicies(request, null, null, true);
            return EndListRolePolicies(asyncResult);
        }

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
        public IAsyncResult BeginListRolePolicies(ListRolePoliciesRequest request, AsyncCallback callback, object state)
        {
            return invokeListRolePolicies(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRolePolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRolePolicies.</param>
        /// 
        /// <returns>Returns a  ListRolePoliciesResult from IdentityManagementService.</returns>
        public  ListRolePoliciesResponse EndListRolePolicies(IAsyncResult asyncResult)
        {
            return endOperation< ListRolePoliciesResponse>(asyncResult);
        }

        IAsyncResult invokeListRolePolicies(ListRolePoliciesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListRolePoliciesRequestMarshaller();
            var unmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListRoles

        /// <summary>
        /// Lists the roles that have the specified path prefix. If there are none, the action
        /// returns an empty list. For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        public ListRolesResponse ListRoles()
        {
            return ListRoles(new ListRolesRequest());
        }

        /// <summary>
        /// Lists the roles that have the specified path prefix. If there are none, the action
        /// returns an empty list. For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            IAsyncResult asyncResult = invokeListRoles(request, null, null, true);
            return EndListRoles(asyncResult);
        }

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
        public IAsyncResult BeginListRoles(ListRolesRequest request, AsyncCallback callback, object state)
        {
            return invokeListRoles(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoles operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoles.</param>
        /// 
        /// <returns>Returns a  ListRolesResult from IdentityManagementService.</returns>
        public  ListRolesResponse EndListRoles(IAsyncResult asyncResult)
        {
            return endOperation< ListRolesResponse>(asyncResult);
        }

        IAsyncResult invokeListRoles(ListRolesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListRolesRequestMarshaller();
            var unmarshaller = ListRolesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListSAMLProviders

        /// <summary>
        /// Lists the SAML providers in the account.
        /// </summary>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        public ListSAMLProvidersResponse ListSAMLProviders()
        {
            return ListSAMLProviders(new ListSAMLProvidersRequest());
        }

        /// <summary>
        /// Lists the SAML providers in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        public ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request)
        {
            IAsyncResult asyncResult = invokeListSAMLProviders(request, null, null, true);
            return EndListSAMLProviders(asyncResult);
        }

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
        public IAsyncResult BeginListSAMLProviders(ListSAMLProvidersRequest request, AsyncCallback callback, object state)
        {
            return invokeListSAMLProviders(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSAMLProviders operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSAMLProviders.</param>
        /// 
        /// <returns>Returns a  ListSAMLProvidersResult from IdentityManagementService.</returns>
        public  ListSAMLProvidersResponse EndListSAMLProviders(IAsyncResult asyncResult)
        {
            return endOperation< ListSAMLProvidersResponse>(asyncResult);
        }

        IAsyncResult invokeListSAMLProviders(ListSAMLProvidersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListSAMLProvidersRequestMarshaller();
            var unmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListServerCertificates

        /// <summary>
        /// Lists the server certificates that have the specified path prefix. If none exist,
        /// the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        public ListServerCertificatesResponse ListServerCertificates()
        {
            return ListServerCertificates(new ListServerCertificatesRequest());
        }

        /// <summary>
        /// Lists the server certificates that have the specified path prefix. If none exist,
        /// the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates service method.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        public ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request)
        {
            IAsyncResult asyncResult = invokeListServerCertificates(request, null, null, true);
            return EndListServerCertificates(asyncResult);
        }

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
        public IAsyncResult BeginListServerCertificates(ListServerCertificatesRequest request, AsyncCallback callback, object state)
        {
            return invokeListServerCertificates(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServerCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerCertificates.</param>
        /// 
        /// <returns>Returns a  ListServerCertificatesResult from IdentityManagementService.</returns>
        public  ListServerCertificatesResponse EndListServerCertificates(IAsyncResult asyncResult)
        {
            return endOperation< ListServerCertificatesResponse>(asyncResult);
        }

        IAsyncResult invokeListServerCertificates(ListServerCertificatesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListServerCertificatesRequestMarshaller();
            var unmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListSigningCertificates

        /// <summary>
        /// Returns information about the signing certificates associated with the specified user.
        /// If there are none, the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, this API can be used to manage root credentials
        /// even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListSigningCertificatesResponse ListSigningCertificates()
        {
            return ListSigningCertificates(new ListSigningCertificatesRequest());
        }

        /// <summary>
        /// Returns information about the signing certificates associated with the specified user.
        /// If there are none, the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, this API can be used to manage root credentials
        /// even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates service method.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request)
        {
            IAsyncResult asyncResult = invokeListSigningCertificates(request, null, null, true);
            return EndListSigningCertificates(asyncResult);
        }

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
        public IAsyncResult BeginListSigningCertificates(ListSigningCertificatesRequest request, AsyncCallback callback, object state)
        {
            return invokeListSigningCertificates(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningCertificates operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningCertificates.</param>
        /// 
        /// <returns>Returns a  ListSigningCertificatesResult from IdentityManagementService.</returns>
        public  ListSigningCertificatesResponse EndListSigningCertificates(IAsyncResult asyncResult)
        {
            return endOperation< ListSigningCertificatesResponse>(asyncResult);
        }

        IAsyncResult invokeListSigningCertificates(ListSigningCertificatesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListSigningCertificatesRequestMarshaller();
            var unmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListUserPolicies


        /// <summary>
        /// Lists the names of the policies associated with the specified user. If there are none,
        /// the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request)
        {
            IAsyncResult asyncResult = invokeListUserPolicies(request, null, null, true);
            return EndListUserPolicies(asyncResult);
        }

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
        public IAsyncResult BeginListUserPolicies(ListUserPoliciesRequest request, AsyncCallback callback, object state)
        {
            return invokeListUserPolicies(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPolicies operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPolicies.</param>
        /// 
        /// <returns>Returns a  ListUserPoliciesResult from IdentityManagementService.</returns>
        public  ListUserPoliciesResponse EndListUserPolicies(IAsyncResult asyncResult)
        {
            return endOperation< ListUserPoliciesResponse>(asyncResult);
        }

        IAsyncResult invokeListUserPolicies(ListUserPoliciesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListUserPoliciesRequestMarshaller();
            var unmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Lists the users that have the specified path prefix. If there are none, the action
        /// returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        public ListUsersResponse ListUsers()
        {
            return ListUsers(new ListUsersRequest());
        }

        /// <summary>
        /// Lists the users that have the specified path prefix. If there are none, the action
        /// returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            IAsyncResult asyncResult = invokeListUsers(request, null, null, true);
            return EndListUsers(asyncResult);
        }

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
        public IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            return invokeListUsers(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from IdentityManagementService.</returns>
        public  ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return endOperation< ListUsersResponse>(asyncResult);
        }

        IAsyncResult invokeListUsers(ListUsersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListUsersRequestMarshaller();
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ListVirtualMFADevices

        /// <summary>
        /// Lists the virtual MFA devices under the AWS account by assignment status. If you
        /// do not specify an assignment status, the action returns a list of all virtual MFA
        /// devices. Assignment status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>. 
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        public ListVirtualMFADevicesResponse ListVirtualMFADevices()
        {
            return ListVirtualMFADevices(new ListVirtualMFADevicesRequest());
        }

        /// <summary>
        /// Lists the virtual MFA devices under the AWS account by assignment status. If you
        /// do not specify an assignment status, the action returns a list of all virtual MFA
        /// devices. Assignment status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>. 
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        public ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request)
        {
            IAsyncResult asyncResult = invokeListVirtualMFADevices(request, null, null, true);
            return EndListVirtualMFADevices(asyncResult);
        }

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
        public IAsyncResult BeginListVirtualMFADevices(ListVirtualMFADevicesRequest request, AsyncCallback callback, object state)
        {
            return invokeListVirtualMFADevices(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualMFADevices operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualMFADevices.</param>
        /// 
        /// <returns>Returns a  ListVirtualMFADevicesResult from IdentityManagementService.</returns>
        public  ListVirtualMFADevicesResponse EndListVirtualMFADevices(IAsyncResult asyncResult)
        {
            return endOperation< ListVirtualMFADevicesResponse>(asyncResult);
        }

        IAsyncResult invokeListVirtualMFADevices(ListVirtualMFADevicesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ListVirtualMFADevicesRequestMarshaller();
            var unmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  PutGroupPolicy


        /// <summary>
        /// Adds (or updates) a policy document associated with the specified group. For information
        /// about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of Policies</a> in the <i>Using IAM</i> guide.
        /// 
        ///  
        /// <para>
        /// For information about limits on the number of policies you can associate with a group,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request)
        {
            IAsyncResult asyncResult = invokePutGroupPolicy(request, null, null, true);
            return EndPutGroupPolicy(asyncResult);
        }

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
        public IAsyncResult BeginPutGroupPolicy(PutGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokePutGroupPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroupPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupPolicy.</param>
        /// 
        /// <returns>Returns a  PutGroupPolicyResult from IdentityManagementService.</returns>
        public  PutGroupPolicyResponse EndPutGroupPolicy(IAsyncResult asyncResult)
        {
            return endOperation< PutGroupPolicyResponse>(asyncResult);
        }

        IAsyncResult invokePutGroupPolicy(PutGroupPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new PutGroupPolicyRequestMarshaller();
            var unmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  PutRolePolicy


        /// <summary>
        /// Adds (or updates) a policy document associated with the specified role. For information
        /// about policies, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of Policies</a> in the <i>Using IAM</i> guide.
        /// 
        ///  
        /// <para>
        /// For information about limits on the policies you can associate with a role, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// 
        /// <returns>The response from the PutRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request)
        {
            IAsyncResult asyncResult = invokePutRolePolicy(request, null, null, true);
            return EndPutRolePolicy(asyncResult);
        }

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
        public IAsyncResult BeginPutRolePolicy(PutRolePolicyRequest request, AsyncCallback callback, object state)
        {
            return invokePutRolePolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRolePolicy.</param>
        /// 
        /// <returns>Returns a  PutRolePolicyResult from IdentityManagementService.</returns>
        public  PutRolePolicyResponse EndPutRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation< PutRolePolicyResponse>(asyncResult);
        }

        IAsyncResult invokePutRolePolicy(PutRolePolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new PutRolePolicyRequestMarshaller();
            var unmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  PutUserPolicy


        /// <summary>
        /// Adds (or updates) a policy document associated with the specified user. For information
        /// about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of Policies</a> in the <i>Using IAM</i> guide.
        /// 
        ///  
        /// <para>
        /// For information about limits on the number of policies you can associate with a user,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// 
        /// <returns>The response from the PutUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request)
        {
            IAsyncResult asyncResult = invokePutUserPolicy(request, null, null, true);
            return EndPutUserPolicy(asyncResult);
        }

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
        public IAsyncResult BeginPutUserPolicy(PutUserPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokePutUserPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PutUserPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserPolicy.</param>
        /// 
        /// <returns>Returns a  PutUserPolicyResult from IdentityManagementService.</returns>
        public  PutUserPolicyResponse EndPutUserPolicy(IAsyncResult asyncResult)
        {
            return endOperation< PutUserPolicyResponse>(asyncResult);
        }

        IAsyncResult invokePutUserPolicy(PutUserPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new PutUserPolicyRequestMarshaller();
            var unmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RemoveRoleFromInstanceProfile


        /// <summary>
        /// Removes the specified role from the specified instance profile.
        /// 
        ///  <important>Make sure you do not have any Amazon EC2 instances running with the role
        /// you are about to remove from the instance profile. Removing a role from an instance
        /// profile that is associated with a running instance will break any applications running
        /// on the instance.</important> 
        /// <para>
        /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request)
        {
            IAsyncResult asyncResult = invokeRemoveRoleFromInstanceProfile(request, null, null, true);
            return EndRemoveRoleFromInstanceProfile(asyncResult);
        }

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
        public IAsyncResult BeginRemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeRemoveRoleFromInstanceProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRoleFromInstanceProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromInstanceProfile.</param>
        /// 
        /// <returns>Returns a  RemoveRoleFromInstanceProfileResult from IdentityManagementService.</returns>
        public  RemoveRoleFromInstanceProfileResponse EndRemoveRoleFromInstanceProfile(IAsyncResult asyncResult)
        {
            return endOperation< RemoveRoleFromInstanceProfileResponse>(asyncResult);
        }

        IAsyncResult invokeRemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RemoveRoleFromInstanceProfileRequestMarshaller();
            var unmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

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
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            IAsyncResult asyncResult = invokeRemoveUserFromGroup(request, null, null, true);
            return EndRemoveUserFromGroup(asyncResult);
        }

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
        public IAsyncResult BeginRemoveUserFromGroup(RemoveUserFromGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeRemoveUserFromGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveUserFromGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveUserFromGroup.</param>
        /// 
        /// <returns>Returns a  RemoveUserFromGroupResult from IdentityManagementService.</returns>
        public  RemoveUserFromGroupResponse EndRemoveUserFromGroup(IAsyncResult asyncResult)
        {
            return endOperation< RemoveUserFromGroupResponse>(asyncResult);
        }

        IAsyncResult invokeRemoveUserFromGroup(RemoveUserFromGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RemoveUserFromGroupRequestMarshaller();
            var unmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ResyncMFADevice


        /// <summary>
        /// Synchronizes the specified MFA device with AWS servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice service method.</param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request)
        {
            IAsyncResult asyncResult = invokeResyncMFADevice(request, null, null, true);
            return EndResyncMFADevice(asyncResult);
        }

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
        public IAsyncResult BeginResyncMFADevice(ResyncMFADeviceRequest request, AsyncCallback callback, object state)
        {
            return invokeResyncMFADevice(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ResyncMFADevice operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResyncMFADevice.</param>
        /// 
        /// <returns>Returns a  ResyncMFADeviceResult from IdentityManagementService.</returns>
        public  ResyncMFADeviceResponse EndResyncMFADevice(IAsyncResult asyncResult)
        {
            return endOperation< ResyncMFADeviceResponse>(asyncResult);
        }

        IAsyncResult invokeResyncMFADevice(ResyncMFADeviceRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ResyncMFADeviceRequestMarshaller();
            var unmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateAccessKey


        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This action can be used to disable a user's key as part of a key rotation work flow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, this API can be used to manage root credentials
        /// even if the AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about rotating keys, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html">Managing
        /// Keys and Certificates</a> in the <i>Using IAM </i> guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateAccessKey(request, null, null, true);
            return EndUpdateAccessKey(asyncResult);
        }

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
        public IAsyncResult BeginUpdateAccessKey(UpdateAccessKeyRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateAccessKey(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessKey operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessKey.</param>
        /// 
        /// <returns>Returns a  UpdateAccessKeyResult from IdentityManagementService.</returns>
        public  UpdateAccessKeyResponse EndUpdateAccessKey(IAsyncResult asyncResult)
        {
            return endOperation< UpdateAccessKeyResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateAccessKey(UpdateAccessKeyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateAccessKeyRequestMarshaller();
            var unmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateAccountPasswordPolicy

        /// <summary>
        /// Updates the password policy settings for the account. For more information about using
        /// a password policy, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy()
        {
            return UpdateAccountPasswordPolicy(new UpdateAccountPasswordPolicyRequest());
        }

        /// <summary>
        /// Updates the password policy settings for the account. For more information about using
        /// a password policy, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateAccountPasswordPolicy(request, null, null, true);
            return EndUpdateAccountPasswordPolicy(asyncResult);
        }

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
        public IAsyncResult BeginUpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateAccountPasswordPolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountPasswordPolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAccountPasswordPolicyResult from IdentityManagementService.</returns>
        public  UpdateAccountPasswordPolicyResponse EndUpdateAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return endOperation< UpdateAccountPasswordPolicyResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateAssumeRolePolicy


        /// <summary>
        /// Updates the policy that grants an entity permission to assume a role. For more information
        /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAssumeRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateAssumeRolePolicy(request, null, null, true);
            return EndUpdateAssumeRolePolicy(asyncResult);
        }

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
        public IAsyncResult BeginUpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateAssumeRolePolicy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssumeRolePolicy operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssumeRolePolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAssumeRolePolicyResult from IdentityManagementService.</returns>
        public  UpdateAssumeRolePolicyResponse EndUpdateAssumeRolePolicy(IAsyncResult asyncResult)
        {
            return endOperation< UpdateAssumeRolePolicyResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateAssumeRolePolicyRequestMarshaller();
            var unmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates the name and/or the path of the specified group.
        /// 
        ///  <important> You should understand the implications of changing a group's path or
        /// name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
        /// Users and Groups</a> in the <i>Using IAM</i> guide. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateGroup(request, null, null, true);
            return EndUpdateGroup(asyncResult);
        }

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
        public IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from IdentityManagementService.</returns>
        public  UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return endOperation< UpdateGroupResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateGroupRequestMarshaller();
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateLoginProfile


        /// <summary>
        /// Changes the password for the specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        public UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateLoginProfile(request, null, null, true);
            return EndUpdateLoginProfile(asyncResult);
        }

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
        public IAsyncResult BeginUpdateLoginProfile(UpdateLoginProfileRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateLoginProfile(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoginProfile operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoginProfile.</param>
        /// 
        /// <returns>Returns a  UpdateLoginProfileResult from IdentityManagementService.</returns>
        public  UpdateLoginProfileResponse EndUpdateLoginProfile(IAsyncResult asyncResult)
        {
            return endOperation< UpdateLoginProfileResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateLoginProfile(UpdateLoginProfileRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateLoginProfileRequestMarshaller();
            var unmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateSAMLProvider


        /// <summary>
        /// Updates the metadata document for an existing SAML provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="InvalidInputException">
        /// 
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateSAMLProvider(request, null, null, true);
            return EndUpdateSAMLProvider(asyncResult);
        }

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
        public IAsyncResult BeginUpdateSAMLProvider(UpdateSAMLProviderRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateSAMLProvider(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSAMLProvider operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  UpdateSAMLProviderResult from IdentityManagementService.</returns>
        public  UpdateSAMLProviderResponse EndUpdateSAMLProvider(IAsyncResult asyncResult)
        {
            return endOperation< UpdateSAMLProviderResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateSAMLProvider(UpdateSAMLProviderRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateSAMLProviderRequestMarshaller();
            var unmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateServerCertificate


        /// <summary>
        /// Updates the name and/or the path of the specified server certificate.
        /// 
        ///  <important> You should understand the implications of changing a server certificate's
        /// path or name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html">Managing
        /// Server Certificates</a> in the <i>Using IAM</i> guide. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateServerCertificate(request, null, null, true);
            return EndUpdateServerCertificate(asyncResult);
        }

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
        public IAsyncResult BeginUpdateServerCertificate(UpdateServerCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateServerCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateServerCertificateResult from IdentityManagementService.</returns>
        public  UpdateServerCertificateResponse EndUpdateServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation< UpdateServerCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateServerCertificate(UpdateServerCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateServerCertificateRequestMarshaller();
            var unmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateSigningCertificate


        /// <summary>
        /// Changes the status of the specified signing certificate from active to disabled, or
        /// vice versa. This action can be used to disable a user's signing certificate as part
        /// of a certificate rotation work flow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, this API can be used to manage root credentials
        /// even if the AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about rotating certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html">Managing
        /// Keys and Certificates</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateSigningCertificate(request, null, null, true);
            return EndUpdateSigningCertificate(asyncResult);
        }

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
        public IAsyncResult BeginUpdateSigningCertificate(UpdateSigningCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateSigningCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateSigningCertificateResult from IdentityManagementService.</returns>
        public  UpdateSigningCertificateResponse EndUpdateSigningCertificate(IAsyncResult asyncResult)
        {
            return endOperation< UpdateSigningCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateSigningCertificate(UpdateSigningCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateSigningCertificateRequestMarshaller();
            var unmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the name and/or the path of the specified user.
        /// 
        ///  <important> You should understand the implications of changing a user's path or name.
        /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
        /// Users and Groups</a> in the <i>Using IAM</i> guide. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            IAsyncResult asyncResult = invokeUpdateUser(request, null, null, true);
            return EndUpdateUser(asyncResult);
        }

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
        public IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            return invokeUpdateUser(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from IdentityManagementService.</returns>
        public  UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return endOperation< UpdateUserResponse>(asyncResult);
        }

        IAsyncResult invokeUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UpdateUserRequestMarshaller();
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UploadServerCertificate


        /// <summary>
        /// Uploads a server certificate entity for the AWS account. The server certificate entity
        /// includes a public key certificate, a private key, and an optional certificate chain,
        /// which should all be PEM-encoded.
        /// 
        ///  
        /// <para>
        /// For information about the number of server certificates you can upload, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="KeyPairMismatchException">
        /// The request was rejected because the public key certificate and the private key do
        /// not match.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        public UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeUploadServerCertificate(request, null, null, true);
            return EndUploadServerCertificate(asyncResult);
        }

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
        public IAsyncResult BeginUploadServerCertificate(UploadServerCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeUploadServerCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadServerCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadServerCertificate.</param>
        /// 
        /// <returns>Returns a  UploadServerCertificateResult from IdentityManagementService.</returns>
        public  UploadServerCertificateResponse EndUploadServerCertificate(IAsyncResult asyncResult)
        {
            return endOperation< UploadServerCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeUploadServerCertificate(UploadServerCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UploadServerCertificateRequestMarshaller();
            var unmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  UploadSigningCertificate


        /// <summary>
        /// Uploads an X.509 signing certificate and associates it with the specified user. Some
        /// AWS services use X.509 signing certificates to validate requests that are signed with
        /// a corresponding private key. When you upload the certificate, its default status is
        /// <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, this API can be used to manage root credentials
        /// even if the AWS account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="DuplicateCertificateException">
        /// The request was rejected because the same certificate is associated to another user
        /// under the account.
        /// </exception>
        /// <exception cref="EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="InvalidCertificateException">
        /// The request was rejected because the certificate is invalid.
        /// </exception>
        /// <exception cref="LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeUploadSigningCertificate(request, null, null, true);
            return EndUploadSigningCertificate(asyncResult);
        }

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
        public IAsyncResult BeginUploadSigningCertificate(UploadSigningCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeUploadSigningCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadSigningCertificate operation.
        /// <seealso cref="Amazon.IdentityManagement.IAmazonIdentityManagementService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UploadSigningCertificateResult from IdentityManagementService.</returns>
        public  UploadSigningCertificateResponse EndUploadSigningCertificate(IAsyncResult asyncResult)
        {
            return endOperation< UploadSigningCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeUploadSigningCertificate(UploadSigningCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new UploadSigningCertificateRequestMarshaller();
            var unmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
    }
}