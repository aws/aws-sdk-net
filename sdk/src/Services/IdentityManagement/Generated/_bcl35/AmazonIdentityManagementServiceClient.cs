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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

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
    /// of IAM actions that you can call programmatically. For general information about IAM,
    /// see <a href="http://aws.amazon.com/iam/">AWS Identity and Access Management (IAM)</a>.
    /// For the user guide for IAM, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/">Using
    /// IAM</a>. 
    /// </para>
    ///  <note>AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to IAM and AWS. For example, the SDKs
    /// take care of tasks such as cryptographically signing requests (see below), managing
    /// errors, and retrying requests automatically. For information about the AWS SDKs, including
    /// how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a> page. </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to IAM. However,
    /// you can also use the IAM Query API to make direct calls to the IAM web service. To
    /// learn more about the IAM Query API, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in the <i>Using IAM</i> guide. IAM supports GET and POST requests
    /// for all actions. That is, the API does not require you to use GET for some actions
    /// and POST for others. However, GET requests are subject to the limitation size of a
    /// URL. Therefore, for operations that require larger sizes, use a POST request. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
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
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see the following:
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a>. This topic provides general information about the types
    /// of credentials used for accessing AWS. </li> <li> <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAMBestPractices.html">IAM
    /// Best Practices</a>. This topic presents a list of suggestions for using the IAM service
    /// to help secure your AWS resources. </li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a>. This set of topics walk you through the process of signing a
    /// request using an access key ID and secret access key. </li> </ul>
    /// </summary>
    public partial class AmazonIdentityManagementServiceClient : AmazonServiceClient, IAmazonIdentityManagementService
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityManagementServiceConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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

        
        #region  AddClientIDToOpenIDConnectProvider

        /// <summary>
        /// Adds a new client ID (also known as audience) to the list of client IDs already registered
        /// for the specified IAM OpenID Connect provider.
        /// 
        ///  
        /// <para>
        /// This action is idempotent; it does not fail or return an error if you add an existing
        /// client ID to the provider.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the AddClientIDToOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public AddClientIDToOpenIDConnectProviderResponse AddClientIDToOpenIDConnectProvider(AddClientIDToOpenIDConnectProviderRequest request)
        {
            var marshaller = new AddClientIDToOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<AddClientIDToOpenIDConnectProviderRequest,AddClientIDToOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddClientIDToOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddClientIDToOpenIDConnectProvider
        ///         operation.</returns>
        public IAsyncResult BeginAddClientIDToOpenIDConnectProvider(AddClientIDToOpenIDConnectProviderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddClientIDToOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;

            return BeginInvoke<AddClientIDToOpenIDConnectProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddClientIDToOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddClientIDToOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  AddClientIDToOpenIDConnectProviderResult from IdentityManagementService.</returns>
        public  AddClientIDToOpenIDConnectProviderResponse EndAddClientIDToOpenIDConnectProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<AddClientIDToOpenIDConnectProviderResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request)
        {
            var marshaller = new AddRoleToInstanceProfileRequestMarshaller();
            var unmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AddRoleToInstanceProfileRequest,AddRoleToInstanceProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
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
            var marshaller = new AddRoleToInstanceProfileRequestMarshaller();
            var unmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke<AddRoleToInstanceProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddRoleToInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToInstanceProfile.</param>
        /// 
        /// <returns>Returns a  AddRoleToInstanceProfileResult from IdentityManagementService.</returns>
        public  AddRoleToInstanceProfileResponse EndAddRoleToInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<AddRoleToInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  AddUserToGroup

        /// <summary>
        /// Adds the specified user to the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup service method.</param>
        /// 
        /// <returns>The response from the AddUserToGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request)
        {
            var marshaller = new AddUserToGroupRequestMarshaller();
            var unmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return Invoke<AddUserToGroupRequest,AddUserToGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
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
            var marshaller = new AddUserToGroupRequestMarshaller();
            var unmarshaller = AddUserToGroupResponseUnmarshaller.Instance;

            return BeginInvoke<AddUserToGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUserToGroup.</param>
        /// 
        /// <returns>Returns a  AddUserToGroupResult from IdentityManagementService.</returns>
        public  AddUserToGroupResponse EndAddUserToGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<AddUserToGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachGroupPolicy

        /// <summary>
        /// Attaches the specified managed policy to the specified group.
        /// 
        ///  
        /// <para>
        /// You use this API to attach a managed policy to a group. To embed an inline policy
        /// in a group, use <a>PutGroupPolicy</a>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public AttachGroupPolicyResponse AttachGroupPolicy(AttachGroupPolicyRequest request)
        {
            var marshaller = new AttachGroupPolicyRequestMarshaller();
            var unmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachGroupPolicyRequest,AttachGroupPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachGroupPolicy
        ///         operation.</returns>
        public IAsyncResult BeginAttachGroupPolicy(AttachGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachGroupPolicyRequestMarshaller();
            var unmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<AttachGroupPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachGroupPolicy.</param>
        /// 
        /// <returns>Returns a  AttachGroupPolicyResult from IdentityManagementService.</returns>
        public  AttachGroupPolicyResponse EndAttachGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachGroupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachRolePolicy

        /// <summary>
        /// Attaches the specified managed policy to the specified role.
        /// 
        ///  
        /// <para>
        /// When you attach a managed policy to a role, the managed policy is used as the role's
        /// access (permissions) policy. You cannot use a managed policy as the role's trust policy.
        /// The role's trust policy is created at the same time as the role, using <a>CreateRole</a>.
        /// You can update a role's trust policy using <a>UpdateAssumeRolePolicy</a>. 
        /// </para>
        ///  
        /// <para>
        /// Use this API to attach a managed policy to a role. To embed an inline policy in a
        /// role, use <a>PutRolePolicy</a>. For more information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy service method.</param>
        /// 
        /// <returns>The response from the AttachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public AttachRolePolicyResponse AttachRolePolicy(AttachRolePolicyRequest request)
        {
            var marshaller = new AttachRolePolicyRequestMarshaller();
            var unmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<AttachRolePolicyRequest,AttachRolePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachRolePolicy
        ///         operation.</returns>
        public IAsyncResult BeginAttachRolePolicy(AttachRolePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachRolePolicyRequestMarshaller();
            var unmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<AttachRolePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachRolePolicy.</param>
        /// 
        /// <returns>Returns a  AttachRolePolicyResult from IdentityManagementService.</returns>
        public  AttachRolePolicyResponse EndAttachRolePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachRolePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachUserPolicy

        /// <summary>
        /// Attaches the specified managed policy to the specified user.
        /// 
        ///  
        /// <para>
        /// You use this API to attach a managed policy to a user. To embed an inline policy in
        /// a user, use <a>PutUserPolicy</a>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public AttachUserPolicyResponse AttachUserPolicy(AttachUserPolicyRequest request)
        {
            var marshaller = new AttachUserPolicyRequestMarshaller();
            var unmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<AttachUserPolicyRequest,AttachUserPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachUserPolicy
        ///         operation.</returns>
        public IAsyncResult BeginAttachUserPolicy(AttachUserPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachUserPolicyRequestMarshaller();
            var unmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<AttachUserPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachUserPolicy.</param>
        /// 
        /// <returns>Returns a  AttachUserPolicyResult from IdentityManagementService.</returns>
        public  AttachUserPolicyResponse EndAttachUserPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachUserPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ChangePassword

        /// <summary>
        /// Changes the password of the IAM user who is calling this action. The root account
        /// password is not affected by this action. 
        /// 
        ///  
        /// <para>
        /// To change the password for a different user, see <a>UpdateLoginProfile</a>. For more
        /// information about modifying passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidUserTypeException">
        /// The request was rejected because the type of user for the transaction was incorrect.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ChangePasswordResponse ChangePassword(ChangePasswordRequest request)
        {
            var marshaller = new ChangePasswordRequestMarshaller();
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return Invoke<ChangePasswordRequest,ChangePasswordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
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
            var marshaller = new ChangePasswordRequestMarshaller();
            var unmarshaller = ChangePasswordResponseUnmarshaller.Instance;

            return BeginInvoke<ChangePasswordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        /// 
        /// <returns>Returns a  ChangePasswordResult from IdentityManagementService.</returns>
        public  ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult)
        {
            return EndInvoke<ChangePasswordResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccessKey

        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified
        /// user. The default status for new keys is <code>Active</code>. 
        /// 
        ///  
        /// <para>
        ///  If you do not specify a user name, IAM determines the user name implicitly based
        /// on the AWS access key ID signing the request. Because this action works for access
        /// keys under the AWS account, you can use this action to manage root credentials even
        /// if the AWS account has no associated users. 
        /// </para>
        ///  
        /// <para>
        ///  For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  <important> To ensure the security of your AWS account, the secret access key is
        /// accessible only during key and user creation. You must save the key (for example,
        /// in a text file) if you want to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the associated user and then create new keys. </important>
        /// </summary>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
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
        ///  If you do not specify a user name, IAM determines the user name implicitly based
        /// on the AWS access key ID signing the request. Because this action works for access
        /// keys under the AWS account, you can use this action to manage root credentials even
        /// if the AWS account has no associated users. 
        /// </para>
        ///  
        /// <para>
        ///  For information about limits on the number of keys you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  <important> To ensure the security of your AWS account, the secret access key is
        /// accessible only during key and user creation. You must save the key (for example,
        /// in a text file) if you want to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the associated user and then create new keys. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey service method.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request)
        {
            var marshaller = new CreateAccessKeyRequestMarshaller();
            var unmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;

            return Invoke<CreateAccessKeyRequest,CreateAccessKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
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
            var marshaller = new CreateAccessKeyRequestMarshaller();
            var unmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAccessKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessKey.</param>
        /// 
        /// <returns>Returns a  CreateAccessKeyResult from IdentityManagementService.</returns>
        public  CreateAccessKeyResponse EndCreateAccessKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccessKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccountAlias

        /// <summary>
        /// Creates an alias for your AWS account. For information about using an AWS account
        /// alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request)
        {
            var marshaller = new CreateAccountAliasRequestMarshaller();
            var unmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAccountAliasRequest,CreateAccountAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
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
            var marshaller = new CreateAccountAliasRequestMarshaller();
            var unmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAccountAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAlias.</param>
        /// 
        /// <returns>Returns a  CreateAccountAliasResult from IdentityManagementService.</returns>
        public  CreateAccountAliasResponse EndCreateAccountAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccountAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroup

        /// <summary>
        /// Creates a new group.
        /// 
        ///  
        /// <para>
        ///  For information about the number of groups you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var marshaller = new CreateGroupRequestMarshaller();
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupRequest,CreateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
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
            var marshaller = new CreateGroupRequestMarshaller();
            var unmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from IdentityManagementService.</returns>
        public  CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
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
        ///  For information about the number of instance profiles you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var marshaller = new CreateInstanceProfileRequestMarshaller();
            var unmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceProfileRequest,CreateInstanceProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
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
            var marshaller = new CreateInstanceProfileRequestMarshaller();
            var unmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke<CreateInstanceProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a  CreateInstanceProfileResult from IdentityManagementService.</returns>
        public  CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLoginProfile

        /// <summary>
        /// Creates a password for the specified user, giving the user the ability to access
        /// AWS services through the AWS Management Console. For more information about managing
        /// passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>Using IAM</i> guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request)
        {
            var marshaller = new CreateLoginProfileRequestMarshaller();
            var unmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<CreateLoginProfileRequest,CreateLoginProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
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
            var marshaller = new CreateLoginProfileRequestMarshaller();
            var unmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;

            return BeginInvoke<CreateLoginProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoginProfile.</param>
        /// 
        /// <returns>Returns a  CreateLoginProfileResult from IdentityManagementService.</returns>
        public  CreateLoginProfileResponse EndCreateLoginProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLoginProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateOpenIDConnectProvider

        /// <summary>
        /// Creates an IAM entity to describe an identity provider (IdP) that supports <a href="http://openid.net/connect/">OpenID
        /// Connect (OIDC)</a>. 
        /// 
        ///  
        /// <para>
        /// The OIDC provider that you create with this operation can be used as a principal in
        /// a role's trust policy to establish a trust relationship between AWS and the OIDC provider.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When you create the IAM OIDC provider, you specify the URL of the OIDC identity provider
        /// (IdP) to trust, a list of client IDs (also known as audiences) that identify the application
        /// or applications that are allowed to authenticate using the OIDC provider, and a list
        /// of thumbprints of the server certificate(s) that the IdP uses. You get all of this
        /// information from the OIDC IdP that you want to use for access to AWS. 
        /// </para>
        ///  <note>Because trust for the OIDC provider is ultimately derived from the IAM provider
        /// that this action creates, it is a best practice to limit access to the <a>CreateOpenIDConnectProvider</a>
        /// action to highly-privileged users. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the CreateOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateOpenIDConnectProviderResponse CreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request)
        {
            var marshaller = new CreateOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<CreateOpenIDConnectProviderRequest,CreateOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOpenIDConnectProvider
        ///         operation.</returns>
        public IAsyncResult BeginCreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;

            return BeginInvoke<CreateOpenIDConnectProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  CreateOpenIDConnectProviderResult from IdentityManagementService.</returns>
        public  CreateOpenIDConnectProviderResponse EndCreateOpenIDConnectProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOpenIDConnectProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePolicy

        /// <summary>
        /// Creates a new managed policy for your AWS account. 
        /// 
        ///  
        /// <para>
        /// This operation creates a policy version with a version identifier of <code>v1</code>
        /// and sets v1 as the policy's default version. For more information about policy versions,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies in general, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicy
        ///         operation.</returns>
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
        /// <returns>Returns a  CreatePolicyResult from IdentityManagementService.</returns>
        public  CreatePolicyResponse EndCreatePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePolicyVersion

        /// <summary>
        /// Creates a new version of the specified managed policy. To update a managed policy,
        /// you create a new policy version. A managed policy can have up to five versions. If
        /// the policy has five versions, you must delete an existing version using <a>DeletePolicyVersion</a>
        /// before you create a new version. 
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version; that is, the version that is in effect for the IAM
        /// users, groups, and roles that the policy is attached to. 
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request)
        {
            var marshaller = new CreatePolicyVersionRequestMarshaller();
            var unmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePolicyVersionRequest,CreatePolicyVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicyVersion
        ///         operation.</returns>
        public IAsyncResult BeginCreatePolicyVersion(CreatePolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePolicyVersionRequestMarshaller();
            var unmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePolicyVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicyVersion.</param>
        /// 
        /// <returns>Returns a  CreatePolicyVersionResult from IdentityManagementService.</returns>
        public  CreatePolicyVersionResponse EndCreatePolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRole

        /// <summary>
        /// Creates a new role for your AWS account. For more information about roles, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For information about limitations on role names and the number of
        /// roles you can create, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRole service method.</param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            var marshaller = new CreateRoleRequestMarshaller();
            var unmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return Invoke<CreateRoleRequest,CreateRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
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
            var marshaller = new CreateRoleRequestMarshaller();
            var unmarshaller = CreateRoleResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRole.</param>
        /// 
        /// <returns>Returns a  CreateRoleResult from IdentityManagementService.</returns>
        public  CreateRoleResponse EndCreateRole(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSAMLProvider

        /// <summary>
        /// Creates an IAM entity to describe an identity provider (IdP) that supports SAML 2.0.
        /// 
        ///  
        /// <para>
        ///  The SAML provider that you create with this operation can be used as a principal
        /// in a role's trust policy to establish a trust relationship between AWS and a SAML
        /// identity provider. You can create an IAM role that supports Web-based single sign-on
        /// (SSO) to the AWS Management Console or one that supports API access to AWS. 
        /// </para>
        ///  
        /// <para>
        ///  When you create the SAML provider, you upload an a SAML metadata document that you
        /// get from your IdP and that includes the issuer's name, expiration information, and
        /// keys that can be used to validate the SAML authentication response (assertions) that
        /// are received from the IdP. You must generate the metadata document using the identity
        /// management software that is used as your organization's IdP. 
        /// </para>
        ///  <note> This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>. </note> 
        /// <para>
        ///  For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-saml.html">Enabling
        /// SAML 2.0 Federated Users to Access the AWS Management Console</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the CreateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request)
        {
            var marshaller = new CreateSAMLProviderRequestMarshaller();
            var unmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<CreateSAMLProviderRequest,CreateSAMLProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
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
            var marshaller = new CreateSAMLProviderRequestMarshaller();
            var unmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSAMLProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  CreateSAMLProviderResult from IdentityManagementService.</returns>
        public  CreateSAMLProviderResponse EndCreateSAMLProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSAMLProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a new user for your AWS account.
        /// 
        ///  
        /// <para>
        ///  For information about limitations on the number of users you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var marshaller = new CreateUserRequestMarshaller();
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserRequest,CreateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
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
            var marshaller = new CreateUserRequestMarshaller();
            var unmarshaller = CreateUserResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from IdentityManagementService.</returns>
        public  CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVirtualMFADevice

        /// <summary>
        /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
        /// use <a>EnableMFADevice</a> to attach the MFA device to an IAM user. For more information
        /// about creating and working with virtual MFA devices, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
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
        /// the information is destroyed following secure procedures. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request)
        {
            var marshaller = new CreateVirtualMFADeviceRequestMarshaller();
            var unmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualMFADeviceRequest,CreateVirtualMFADeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
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
            var marshaller = new CreateVirtualMFADeviceRequestMarshaller();
            var unmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVirtualMFADeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  CreateVirtualMFADeviceResult from IdentityManagementService.</returns>
        public  CreateVirtualMFADeviceResponse EndCreateVirtualMFADevice(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVirtualMFADeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeactivateMFADevice

        /// <summary>
        /// Deactivates the specified MFA device and removes it from association with the user
        /// name for which it was originally enabled. 
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a Virtual MFA Device</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request)
        {
            var marshaller = new DeactivateMFADeviceRequestMarshaller();
            var unmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeactivateMFADeviceRequest,DeactivateMFADeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
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
            var marshaller = new DeactivateMFADeviceRequestMarshaller();
            var unmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;

            return BeginInvoke<DeactivateMFADeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMFADevice.</param>
        /// 
        /// <returns>Returns a  DeactivateMFADeviceResult from IdentityManagementService.</returns>
        public  DeactivateMFADeviceResponse EndDeactivateMFADevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeactivateMFADeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccessKey

        /// <summary>
        /// Deletes the access key associated with the specified user.
        /// 
        ///  
        /// <para>
        ///  If you do not specify a user name, IAM determines the user name implicitly based
        /// on the AWS access key ID signing the request. Because this action works for access
        /// keys under the AWS account, you can use this action to manage root credentials even
        /// if the AWS account has no associated users. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request)
        {
            var marshaller = new DeleteAccessKeyRequestMarshaller();
            var unmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessKeyRequest,DeleteAccessKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
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
            var marshaller = new DeleteAccessKeyRequestMarshaller();
            var unmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAccessKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessKey.</param>
        /// 
        /// <returns>Returns a  DeleteAccessKeyResult from IdentityManagementService.</returns>
        public  DeleteAccessKeyResponse EndDeleteAccessKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccessKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccountAlias

        /// <summary>
        /// Deletes the specified AWS account alias. For information about using an AWS account
        /// alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request)
        {
            var marshaller = new DeleteAccountAliasRequestMarshaller();
            var unmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountAliasRequest,DeleteAccountAliasResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
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
            var marshaller = new DeleteAccountAliasRequestMarshaller();
            var unmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAccountAliasRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAliasResult from IdentityManagementService.</returns>
        public  DeleteAccountAliasResponse EndDeleteAccountAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccountPasswordPolicy

        /// <summary>
        /// Deletes the password policy for the AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
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
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request)
        {
            var marshaller = new DeleteAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountPasswordPolicyRequest,DeleteAccountPasswordPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
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
            var marshaller = new DeleteAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAccountPasswordPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccountPasswordPolicyResult from IdentityManagementService.</returns>
        public  DeleteAccountPasswordPolicyResponse EndDeleteAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountPasswordPolicyResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var marshaller = new DeleteGroupRequestMarshaller();
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupRequest,DeleteGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
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
            var marshaller = new DeleteGroupRequestMarshaller();
            var unmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from IdentityManagementService.</returns>
        public  DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroupPolicy

        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified group.
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To detach a managed policy
        /// from a group, use <a>DetachGroupPolicy</a>. For more information about policies, refer
        /// to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request)
        {
            var marshaller = new DeleteGroupPolicyRequestMarshaller();
            var unmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupPolicyRequest,DeleteGroupPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
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
            var marshaller = new DeleteGroupPolicyRequestMarshaller();
            var unmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGroupPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteGroupPolicyResult from IdentityManagementService.</returns>
        public  DeleteGroupPolicyResponse EndDeleteGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstanceProfile

        /// <summary>
        /// Deletes the specified instance profile. The instance profile must not have an associated
        /// role. 
        /// 
        ///  <important> Make sure you do not have any Amazon EC2 instances running with the instance
        /// profile you are about to delete. Deleting a role or instance profile that is associated
        /// with a running instance will break any applications running on the instance. </important>
        /// 
        /// <para>
        /// For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request)
        {
            var marshaller = new DeleteInstanceProfileRequestMarshaller();
            var unmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceProfileRequest,DeleteInstanceProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
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
            var marshaller = new DeleteInstanceProfileRequestMarshaller();
            var unmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteInstanceProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceProfileResult from IdentityManagementService.</returns>
        public  DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLoginProfile

        /// <summary>
        /// Deletes the password for the specified user, which terminates the user's ability
        /// to access AWS services through the AWS Management Console. 
        /// 
        ///  <important> Deleting a user's password does not prevent a user from accessing IAM
        /// through the command line interface or the API. To prevent all user access you must
        /// also either make the access key inactive or delete it. For more information about
        /// making keys inactive or deleting them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
        /// </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request)
        {
            var marshaller = new DeleteLoginProfileRequestMarshaller();
            var unmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteLoginProfileRequest,DeleteLoginProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
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
            var marshaller = new DeleteLoginProfileRequestMarshaller();
            var unmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLoginProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoginProfile.</param>
        /// 
        /// <returns>Returns a  DeleteLoginProfileResult from IdentityManagementService.</returns>
        public  DeleteLoginProfileResponse EndDeleteLoginProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLoginProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOpenIDConnectProvider

        /// <summary>
        /// Deletes an IAM OpenID Connect identity provider.
        /// 
        ///  
        /// <para>
        /// Deleting an OIDC provider does not update any roles that reference the provider as
        /// a principal in their trust policies. Any attempt to assume a role that references
        /// a provider that has been deleted will fail. 
        /// </para>
        ///  
        /// <para>
        /// This action is idempotent; it does not fail or return an error if you call the action
        /// for a provider that was already deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteOpenIDConnectProviderResponse DeleteOpenIDConnectProvider(DeleteOpenIDConnectProviderRequest request)
        {
            var marshaller = new DeleteOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteOpenIDConnectProviderRequest,DeleteOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOpenIDConnectProvider
        ///         operation.</returns>
        public IAsyncResult BeginDeleteOpenIDConnectProvider(DeleteOpenIDConnectProviderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteOpenIDConnectProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  DeleteOpenIDConnectProviderResult from IdentityManagementService.</returns>
        public  DeleteOpenIDConnectProviderResponse EndDeleteOpenIDConnectProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOpenIDConnectProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePolicy

        /// <summary>
        /// Deletes the specified managed policy.
        /// 
        ///  
        /// <para>
        /// Before you can delete a managed policy, you must detach the policy from all users,
        /// groups, and roles that it is attached to, and you must delete all of the policy's
        /// versions. The following steps describe the process for deleting a managed policy:
        /// <ol> <li>Detach the policy from all users, groups, and roles that the policy is attached
        /// to, using the <a>DetachUserPolicy</a>, <a>DetachGroupPolicy</a>, or <a>DetachRolePolicy</a>
        /// APIs. To list all the users, groups, and roles that a policy is attached to, use <a>ListEntitiesForPolicy</a>.
        /// </li> <li>Delete all versions of the policy using <a>DeletePolicyVersion</a>. To list
        /// the policy's versions, use <a>ListPolicyVersions</a>. You cannot use <a>DeletePolicyVersion</a>
        /// to delete the version that is marked as the default version. You delete the policy's
        /// default version in the next step of the process. </li> <li>Delete the policy (this
        /// automatically deletes the policy's default version) using this API. </li> </ol> 
        /// </para>
        ///  
        /// <para>
        /// For information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
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
        /// <returns>Returns a  DeletePolicyResult from IdentityManagementService.</returns>
        public  DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePolicyVersion

        /// <summary>
        /// Deletes the specified version of the specified managed policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete the default version of a policy using this API. To delete the default
        /// version of a policy, use <a>DeletePolicy</a>. To find out which version of a policy
        /// is marked as the default version, use <a>ListPolicyVersions</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about versions for managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request)
        {
            var marshaller = new DeletePolicyVersionRequestMarshaller();
            var unmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyVersionRequest,DeletePolicyVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyVersion
        ///         operation.</returns>
        public IAsyncResult BeginDeletePolicyVersion(DeletePolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeletePolicyVersionRequestMarshaller();
            var unmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePolicyVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyVersion.</param>
        /// 
        /// <returns>Returns a  DeletePolicyVersionResult from IdentityManagementService.</returns>
        public  DeletePolicyVersionResponse EndDeletePolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePolicyVersionResponse>(asyncResult);
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
        /// a running instance will break any applications running on the instance. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole service method.</param>
        /// 
        /// <returns>The response from the DeleteRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            var marshaller = new DeleteRoleRequestMarshaller();
            var unmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteRoleRequest,DeleteRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
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
            var marshaller = new DeleteRoleRequestMarshaller();
            var unmarshaller = DeleteRoleResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRole.</param>
        /// 
        /// <returns>Returns a  DeleteRoleResult from IdentityManagementService.</returns>
        public  DeleteRoleResponse EndDeleteRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRolePolicy

        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified role.
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To detach a managed policy from
        /// a role, use <a>DetachRolePolicy</a>. For more information about policies, refer to
        /// <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request)
        {
            var marshaller = new DeleteRolePolicyRequestMarshaller();
            var unmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRolePolicyRequest,DeleteRolePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
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
            var marshaller = new DeleteRolePolicyRequestMarshaller();
            var unmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRolePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRolePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRolePolicyResult from IdentityManagementService.</returns>
        public  DeleteRolePolicyResponse EndDeleteRolePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRolePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSAMLProvider

        /// <summary>
        /// Deletes a SAML provider.
        /// 
        ///  
        /// <para>
        ///  Deleting the provider does not update any roles that reference the SAML provider
        /// as a principal in their trust policies. Any attempt to assume a role that references
        /// a SAML provider that has been deleted will fail. 
        /// </para>
        ///  <note> This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request)
        {
            var marshaller = new DeleteSAMLProviderRequestMarshaller();
            var unmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<DeleteSAMLProviderRequest,DeleteSAMLProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
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
            var marshaller = new DeleteSAMLProviderRequestMarshaller();
            var unmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSAMLProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSAMLProvider.</param>
        /// 
        /// <returns>Returns a  DeleteSAMLProviderResult from IdentityManagementService.</returns>
        public  DeleteSAMLProviderResponse EndDeleteSAMLProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSAMLProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServerCertificate

        /// <summary>
        /// Deletes the specified server certificate.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, including a list of AWS
        /// services that can use the server certificates that you manage with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> If you are using a server certificate with Elastic Load Balancing, deleting
        /// the certificate could have implications for your application. If Elastic Load Balancing
        /// doesn't detect the deletion of bound certificates, it may continue to use the certificates.
        /// This could cause Elastic Load Balancing to stop accepting traffic. We recommend that
        /// you remove the reference to the certificate from Elastic Load Balancing before using
        /// this command to delete the certificate. For more information, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html">DeleteLoadBalancerListeners</a>
        /// in the <i>Elastic Load Balancing API Reference</i>. </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            var marshaller = new DeleteServerCertificateRequestMarshaller();
            var unmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteServerCertificateRequest,DeleteServerCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
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
            var marshaller = new DeleteServerCertificateRequestMarshaller();
            var unmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteServerCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteServerCertificateResult from IdentityManagementService.</returns>
        public  DeleteServerCertificateResponse EndDeleteServerCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServerCertificateResponse>(asyncResult);
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
        /// under the AWS account, you can use this action to manage root credentials even if
        /// the AWS account has no associated users. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request)
        {
            var marshaller = new DeleteSigningCertificateRequestMarshaller();
            var unmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteSigningCertificateRequest,DeleteSigningCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
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
            var marshaller = new DeleteSigningCertificateRequestMarshaller();
            var unmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSigningCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSigningCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteSigningCertificateResult from IdentityManagementService.</returns>
        public  DeleteSigningCertificateResponse EndDeleteSigningCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSigningCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSSHPublicKey

        /// <summary>
        /// Deletes the specified SSH public key.
        /// 
        ///  
        /// <para>
        /// The SSH public key deleted by this action is used only for authenticating the associated
        /// IAM user to an AWS CodeCommit repository. For more information about using SSH keys
        /// to authenticate to an AWS CodeCommit repository, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the DeleteSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public DeleteSSHPublicKeyResponse DeleteSSHPublicKey(DeleteSSHPublicKeyRequest request)
        {
            var marshaller = new DeleteSSHPublicKeyRequestMarshaller();
            var unmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteSSHPublicKeyRequest,DeleteSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSSHPublicKey
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSSHPublicKey(DeleteSSHPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSSHPublicKeyRequestMarshaller();
            var unmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSSHPublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  DeleteSSHPublicKeyResult from IdentityManagementService.</returns>
        public  DeleteSSHPublicKeyResponse EndDeleteSSHPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSSHPublicKeyResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserRequest,DeleteUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
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
            var marshaller = new DeleteUserRequestMarshaller();
            var unmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from IdentityManagementService.</returns>
        public  DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserPolicy

        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified user.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To detach a managed policy from
        /// a user, use <a>DetachUserPolicy</a>. For more information about policies, refer to
        /// <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request)
        {
            var marshaller = new DeleteUserPolicyRequestMarshaller();
            var unmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteUserPolicyRequest,DeleteUserPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
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
            var marshaller = new DeleteUserPolicyRequestMarshaller();
            var unmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUserPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteUserPolicyResult from IdentityManagementService.</returns>
        public  DeleteUserPolicyResponse EndDeleteUserPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVirtualMFADevice

        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        ///  <note> You must deactivate a user's virtual MFA device before you can delete it.
        /// For information about deactivating MFA devices, see <a>DeactivateMFADevice</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request)
        {
            var marshaller = new DeleteVirtualMFADeviceRequestMarshaller();
            var unmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualMFADeviceRequest,DeleteVirtualMFADeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
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
            var marshaller = new DeleteVirtualMFADeviceRequestMarshaller();
            var unmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVirtualMFADeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualMFADeviceResult from IdentityManagementService.</returns>
        public  DeleteVirtualMFADeviceResponse EndDeleteVirtualMFADevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVirtualMFADeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachGroupPolicy

        /// <summary>
        /// Removes the specified managed policy from the specified group. 
        /// 
        ///  
        /// <para>
        /// A group can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteGroupPolicy</a> API. For information about policies, refer to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DetachGroupPolicyResponse DetachGroupPolicy(DetachGroupPolicyRequest request)
        {
            var marshaller = new DetachGroupPolicyRequestMarshaller();
            var unmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachGroupPolicyRequest,DetachGroupPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachGroupPolicy
        ///         operation.</returns>
        public IAsyncResult BeginDetachGroupPolicy(DetachGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachGroupPolicyRequestMarshaller();
            var unmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DetachGroupPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DetachGroupPolicyResult from IdentityManagementService.</returns>
        public  DetachGroupPolicyResponse EndDetachGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachGroupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachRolePolicy

        /// <summary>
        /// Removes the specified managed policy from the specified role. 
        /// 
        ///  
        /// <para>
        /// A role can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteRolePolicy</a> API. For information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DetachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DetachRolePolicyResponse DetachRolePolicy(DetachRolePolicyRequest request)
        {
            var marshaller = new DetachRolePolicyRequestMarshaller();
            var unmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;

            return Invoke<DetachRolePolicyRequest,DetachRolePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachRolePolicy
        ///         operation.</returns>
        public IAsyncResult BeginDetachRolePolicy(DetachRolePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachRolePolicyRequestMarshaller();
            var unmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DetachRolePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachRolePolicy.</param>
        /// 
        /// <returns>Returns a  DetachRolePolicyResult from IdentityManagementService.</returns>
        public  DetachRolePolicyResponse EndDetachRolePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachRolePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachUserPolicy

        /// <summary>
        /// Removes the specified managed policy from the specified user. 
        /// 
        ///  
        /// <para>
        /// A user can also have inline policies embedded with it. To delete an inline policy,
        /// use the <a>DeleteUserPolicy</a> API. For information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public DetachUserPolicyResponse DetachUserPolicy(DetachUserPolicyRequest request)
        {
            var marshaller = new DetachUserPolicyRequestMarshaller();
            var unmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;

            return Invoke<DetachUserPolicyRequest,DetachUserPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachUserPolicy
        ///         operation.</returns>
        public IAsyncResult BeginDetachUserPolicy(DetachUserPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachUserPolicyRequestMarshaller();
            var unmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DetachUserPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachUserPolicy.</param>
        /// 
        /// <returns>Returns a  DetachUserPolicyResult from IdentityManagementService.</returns>
        public  DetachUserPolicyResponse EndDetachUserPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachUserPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableMFADevice

        /// <summary>
        /// Enables the specified MFA device and associates it with the specified user name.
        /// When enabled, the MFA device is required for every subsequent login by the user name
        /// associated with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request)
        {
            var marshaller = new EnableMFADeviceRequestMarshaller();
            var unmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return Invoke<EnableMFADeviceRequest,EnableMFADeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
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
            var marshaller = new EnableMFADeviceRequestMarshaller();
            var unmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;

            return BeginInvoke<EnableMFADeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMFADevice.</param>
        /// 
        /// <returns>Returns a  EnableMFADeviceResult from IdentityManagementService.</returns>
        public  EnableMFADeviceResponse EndEnableMFADevice(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableMFADeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateCredentialReport

        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GenerateCredentialReportResponse GenerateCredentialReport()
        {
            return GenerateCredentialReport(new GenerateCredentialReportRequest());
        }

        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GenerateCredentialReportResponse GenerateCredentialReport(GenerateCredentialReportRequest request)
        {
            var marshaller = new GenerateCredentialReportRequestMarshaller();
            var unmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GenerateCredentialReportRequest,GenerateCredentialReportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCredentialReport operation.
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
            var marshaller = new GenerateCredentialReportRequestMarshaller();
            var unmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;

            return BeginInvoke<GenerateCredentialReportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateCredentialReport.</param>
        /// 
        /// <returns>Returns a  GenerateCredentialReportResult from IdentityManagementService.</returns>
        public  GenerateCredentialReportResponse EndGenerateCredentialReport(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateCredentialReportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccessKeyLastUsed

        /// <summary>
        /// Retrieves information about when the specified access key was last used. The information
        /// includes the date and time of last use, along with the AWS service and region that
        /// were specified in the last request made with that key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed service method.</param>
        /// 
        /// <returns>The response from the GetAccessKeyLastUsed service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request)
        {
            var marshaller = new GetAccessKeyLastUsedRequestMarshaller();
            var unmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;

            return Invoke<GetAccessKeyLastUsedRequest,GetAccessKeyLastUsedResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessKeyLastUsed
        ///         operation.</returns>
        public IAsyncResult BeginGetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetAccessKeyLastUsedRequestMarshaller();
            var unmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;

            return BeginInvoke<GetAccessKeyLastUsedRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessKeyLastUsed.</param>
        /// 
        /// <returns>Returns a  GetAccessKeyLastUsedResult from IdentityManagementService.</returns>
        public  GetAccessKeyLastUsedResponse EndGetAccessKeyLastUsed(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccessKeyLastUsedResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountAuthorizationDetails

        /// <summary>
        /// Retrieves information about all IAM users, groups, roles, and policies in your account,
        /// including their relationships to one another. Use this API to obtain a snapshot of
        /// the configuration of IAM permissions (users, groups, roles, and policies) in your
        /// account.
        /// 
        ///  
        /// <para>
        /// You can optionally filter the results using the <code>Filter</code> parameter. You
        /// can paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails service method.</param>
        /// 
        /// <returns>The response from the GetAccountAuthorizationDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetAccountAuthorizationDetailsResponse GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request)
        {
            var marshaller = new GetAccountAuthorizationDetailsRequestMarshaller();
            var unmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetAccountAuthorizationDetailsRequest,GetAccountAuthorizationDetailsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountAuthorizationDetails
        ///         operation.</returns>
        public IAsyncResult BeginGetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetAccountAuthorizationDetailsRequestMarshaller();
            var unmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;

            return BeginInvoke<GetAccountAuthorizationDetailsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountAuthorizationDetails.</param>
        /// 
        /// <returns>Returns a  GetAccountAuthorizationDetailsResult from IdentityManagementService.</returns>
        public  GetAccountAuthorizationDetailsResponse EndGetAccountAuthorizationDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountAuthorizationDetailsResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request)
        {
            var marshaller = new GetAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAccountPasswordPolicyRequest,GetAccountPasswordPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
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
            var marshaller = new GetAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetAccountPasswordPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  GetAccountPasswordPolicyResult from IdentityManagementService.</returns>
        public  GetAccountPasswordPolicyResponse EndGetAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountPasswordPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSummary

        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the AWS account.
        /// 
        ///  
        /// <para>
        ///  For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetAccountSummaryResponse GetAccountSummary()
        {
            return GetAccountSummary(new GetAccountSummaryRequest());
        }

        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the AWS account.
        /// 
        ///  
        /// <para>
        ///  For information about limitations on IAM entities, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary service method.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request)
        {
            var marshaller = new GetAccountSummaryRequestMarshaller();
            var unmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;

            return Invoke<GetAccountSummaryRequest,GetAccountSummaryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
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
            var marshaller = new GetAccountSummaryRequestMarshaller();
            var unmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;

            return BeginInvoke<GetAccountSummaryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSummary.</param>
        /// 
        /// <returns>Returns a  GetAccountSummaryResult from IdentityManagementService.</returns>
        public  GetAccountSummaryResponse EndGetAccountSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContextKeysForCustomPolicy

        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in the input policies. The policies are supplied as a list of one or more strings.
        /// To get the context keys from policies associated with an IAM user, group, or role,
        /// use <a>GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForCustomPolicy to understand what key
        /// names and values you must supply when you call <a>SimulateCustomPolicy</a>. Note that
        /// all parameters are shown in unencoded form here for clarity, but must be URL encoded
        /// to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="policyInputList">A list of policies for which you want list of context keys used in <code>Condition</code> elements. Each document is specified as a string containing the complete, valid JSON text of an IAM policy.</param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        public GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(List<string> policyInputList)
        {
            var request = new GetContextKeysForCustomPolicyRequest();
            request.PolicyInputList = policyInputList;
            return GetContextKeysForCustomPolicy(request);
        }


        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in the input policies. The policies are supplied as a list of one or more strings.
        /// To get the context keys from policies associated with an IAM user, group, or role,
        /// use <a>GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForCustomPolicy to understand what key
        /// names and values you must supply when you call <a>SimulateCustomPolicy</a>. Note that
        /// all parameters are shown in unencoded form here for clarity, but must be URL encoded
        /// to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        public GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(GetContextKeysForCustomPolicyRequest request)
        {
            var marshaller = new GetContextKeysForCustomPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContextKeysForCustomPolicyRequest,GetContextKeysForCustomPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContextKeysForCustomPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetContextKeysForCustomPolicy(GetContextKeysForCustomPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetContextKeysForCustomPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetContextKeysForCustomPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContextKeysForCustomPolicy.</param>
        /// 
        /// <returns>Returns a  GetContextKeysForCustomPolicyResult from IdentityManagementService.</returns>
        public  GetContextKeysForCustomPolicyResponse EndGetContextKeysForCustomPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContextKeysForCustomPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetContextKeysForPrincipalPolicy

        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in all of the IAM policies attached to the specified IAM entity. The entity can be
        /// an IAM user, group, or role. If you specify a user, then the request also includes
        /// all of the policies attached to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include only a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForPrincipalPolicy to understand what
        /// key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies attached to the user as well as to all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request.</param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(string policySourceArn)
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            return GetContextKeysForPrincipalPolicy(request);
        }


        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in all of the IAM policies attached to the specified IAM entity. The entity can be
        /// an IAM user, group, or role. If you specify a user, then the request also includes
        /// all of the policies attached to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include only a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForPrincipalPolicy to understand what
        /// key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies attached to the user as well as to all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request.</param>
        /// <param name="policyInputList">A optional list of additional policies for which you want list of context keys used in <code>Condition</code> elements.</param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(string policySourceArn, List<string> policyInputList)
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            request.PolicyInputList = policyInputList;
            return GetContextKeysForPrincipalPolicy(request);
        }


        /// <summary>
        /// Gets a list of all of the context keys referenced in <code>Condition</code> elements
        /// in all of the IAM policies attached to the specified IAM entity. The entity can be
        /// an IAM user, group, or role. If you specify a user, then the request also includes
        /// all of the policies attached to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include only a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request, and can be evaluated by using the <code>Condition</code>
        /// element of an IAM policy. Use GetContextKeysForPrincipalPolicy to understand what
        /// key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(GetContextKeysForPrincipalPolicyRequest request)
        {
            var marshaller = new GetContextKeysForPrincipalPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<GetContextKeysForPrincipalPolicyRequest,GetContextKeysForPrincipalPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContextKeysForPrincipalPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetContextKeysForPrincipalPolicy(GetContextKeysForPrincipalPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetContextKeysForPrincipalPolicyRequestMarshaller();
            var unmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetContextKeysForPrincipalPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContextKeysForPrincipalPolicy.</param>
        /// 
        /// <returns>Returns a  GetContextKeysForPrincipalPolicyResult from IdentityManagementService.</returns>
        public  GetContextKeysForPrincipalPolicyResponse EndGetContextKeysForPrincipalPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetContextKeysForPrincipalPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCredentialReport

        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetCredentialReportResponse GetCredentialReport()
        {
            return GetCredentialReport(new GetCredentialReportRequest());
        }

        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetCredentialReportResponse GetCredentialReport(GetCredentialReportRequest request)
        {
            var marshaller = new GetCredentialReportRequestMarshaller();
            var unmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return Invoke<GetCredentialReportRequest,GetCredentialReportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialReport operation.
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
            var marshaller = new GetCredentialReportRequestMarshaller();
            var unmarshaller = GetCredentialReportResponseUnmarshaller.Instance;

            return BeginInvoke<GetCredentialReportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentialReport.</param>
        /// 
        /// <returns>Returns a  GetCredentialReportResult from IdentityManagementService.</returns>
        public  GetCredentialReportResponse EndGetCredentialReport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCredentialReportResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var marshaller = new GetGroupRequestMarshaller();
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupRequest,GetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
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
            var marshaller = new GetGroupRequestMarshaller();
            var unmarshaller = GetGroupResponseUnmarshaller.Instance;

            return BeginInvoke<GetGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from IdentityManagementService.</returns>
        public  GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroupPolicy

        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified group.
        /// 
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a group, use <a>GetPolicy</a> to determine the policy's
        /// default version, then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request)
        {
            var marshaller = new GetGroupPolicyRequestMarshaller();
            var unmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetGroupPolicyRequest,GetGroupPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
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
            var marshaller = new GetGroupPolicyRequestMarshaller();
            var unmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetGroupPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetGroupPolicyResult from IdentityManagementService.</returns>
        public  GetGroupPolicyResponse EndGetGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupPolicyResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request)
        {
            var marshaller = new GetInstanceProfileRequestMarshaller();
            var unmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInstanceProfileRequest,GetInstanceProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
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
            var marshaller = new GetInstanceProfileRequestMarshaller();
            var unmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceProfile.</param>
        /// 
        /// <returns>Returns a  GetInstanceProfileResult from IdentityManagementService.</returns>
        public  GetInstanceProfileResponse EndGetInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceProfileResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request)
        {
            var marshaller = new GetLoginProfileRequestMarshaller();
            var unmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return Invoke<GetLoginProfileRequest,GetLoginProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
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
            var marshaller = new GetLoginProfileRequestMarshaller();
            var unmarshaller = GetLoginProfileResponseUnmarshaller.Instance;

            return BeginInvoke<GetLoginProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoginProfile.</param>
        /// 
        /// <returns>Returns a  GetLoginProfileResult from IdentityManagementService.</returns>
        public  GetLoginProfileResponse EndGetLoginProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLoginProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOpenIDConnectProvider

        /// <summary>
        /// Returns information about the specified OpenID Connect provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the GetOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetOpenIDConnectProviderResponse GetOpenIDConnectProvider(GetOpenIDConnectProviderRequest request)
        {
            var marshaller = new GetOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<GetOpenIDConnectProviderRequest,GetOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpenIDConnectProvider
        ///         operation.</returns>
        public IAsyncResult BeginGetOpenIDConnectProvider(GetOpenIDConnectProviderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;

            return BeginInvoke<GetOpenIDConnectProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  GetOpenIDConnectProviderResult from IdentityManagementService.</returns>
        public  GetOpenIDConnectProviderResponse EndGetOpenIDConnectProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOpenIDConnectProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Retrieves information about the specified managed policy, including the policy's default
        /// version and the total number of users, groups, and roles that the policy is attached
        /// to. For a list of the specific users, groups, and roles that the policy is attached
        /// to, use the <a>ListEntitiesForPolicy</a> API. This API returns metadata about the
        /// policy. To retrieve the policy document for a specific version of the policy, use
        /// <a>GetPolicyVersion</a>. 
        /// 
        ///  
        /// <para>
        /// This API retrieves information about managed policies. To retrieve information about
        /// an inline policy that is embedded with a user, group, or role, use the <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API. 
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var marshaller = new GetPolicyRequestMarshaller();
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyRequest,GetPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        public IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetPolicyRequestMarshaller();
            var unmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from IdentityManagementService.</returns>
        public  GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicyVersion

        /// <summary>
        /// Retrieves information about the specified version of the specified managed policy,
        /// including the policy document. 
        /// 
        ///  
        /// <para>
        /// To list the available versions for a policy, use <a>ListPolicyVersions</a>. 
        /// </para>
        ///  
        /// <para>
        /// This API retrieves information about managed policies. To retrieve information about
        /// an inline policy that is embedded in a user, group, or role, use the <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the types of policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            var marshaller = new GetPolicyVersionRequestMarshaller();
            var unmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<GetPolicyVersionRequest,GetPolicyVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyVersion
        ///         operation.</returns>
        public IAsyncResult BeginGetPolicyVersion(GetPolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetPolicyVersionRequestMarshaller();
            var unmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetPolicyVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyVersion.</param>
        /// 
        /// <returns>Returns a  GetPolicyVersionResult from IdentityManagementService.</returns>
        public  GetPolicyVersionResponse EndGetPolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRole

        /// <summary>
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the policy granting permission to assume the role. For more information about
        /// ARNs, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html#Identifiers_ARNs">ARNs</a>.
        /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRole service method.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetRoleResponse GetRole(GetRoleRequest request)
        {
            var marshaller = new GetRoleRequestMarshaller();
            var unmarshaller = GetRoleResponseUnmarshaller.Instance;

            return Invoke<GetRoleRequest,GetRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
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
            var marshaller = new GetRoleRequestMarshaller();
            var unmarshaller = GetRoleResponseUnmarshaller.Instance;

            return BeginInvoke<GetRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRole.</param>
        /// 
        /// <returns>Returns a  GetRoleResult from IdentityManagementService.</returns>
        public  GetRoleResponse EndGetRole(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRolePolicy

        /// <summary>
        /// Retrieves the specified inline policy document that is embedded with the specified
        /// role. 
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a role, use <a>GetPolicy</a> to determine the policy's
        /// default version, then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy service method.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request)
        {
            var marshaller = new GetRolePolicyRequestMarshaller();
            var unmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return Invoke<GetRolePolicyRequest,GetRolePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
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
            var marshaller = new GetRolePolicyRequestMarshaller();
            var unmarshaller = GetRolePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetRolePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRolePolicy.</param>
        /// 
        /// <returns>Returns a  GetRolePolicyResult from IdentityManagementService.</returns>
        public  GetRolePolicyResponse EndGetRolePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRolePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSAMLProvider

        /// <summary>
        /// Returns the SAML provider metadocument that was uploaded when the provider was created
        /// or updated. 
        /// 
        ///  <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request)
        {
            var marshaller = new GetSAMLProviderRequestMarshaller();
            var unmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<GetSAMLProviderRequest,GetSAMLProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
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
            var marshaller = new GetSAMLProviderRequestMarshaller();
            var unmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;

            return BeginInvoke<GetSAMLProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSAMLProvider.</param>
        /// 
        /// <returns>Returns a  GetSAMLProviderResult from IdentityManagementService.</returns>
        public  GetSAMLProviderResponse EndGetSAMLProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSAMLProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServerCertificate

        /// <summary>
        /// Retrieves information about the specified server certificate.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, including a list of AWS
        /// services that can use the server certificates that you manage with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate service method.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request)
        {
            var marshaller = new GetServerCertificateRequestMarshaller();
            var unmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return Invoke<GetServerCertificateRequest,GetServerCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
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
            var marshaller = new GetServerCertificateRequestMarshaller();
            var unmarshaller = GetServerCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<GetServerCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerCertificate.</param>
        /// 
        /// <returns>Returns a  GetServerCertificateResult from IdentityManagementService.</returns>
        public  GetServerCertificateResponse EndGetServerCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServerCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSSHPublicKey

        /// <summary>
        /// Retrieves the specified SSH public key, including metadata about the key.
        /// 
        ///  
        /// <para>
        /// The SSH public key retrieved by this action is used only for authenticating the associated
        /// IAM user to an AWS CodeCommit repository. For more information about using SSH keys
        /// to authenticate to an AWS CodeCommit repository, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the GetSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
        public GetSSHPublicKeyResponse GetSSHPublicKey(GetSSHPublicKeyRequest request)
        {
            var marshaller = new GetSSHPublicKeyRequestMarshaller();
            var unmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetSSHPublicKeyRequest,GetSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSSHPublicKey
        ///         operation.</returns>
        public IAsyncResult BeginGetSSHPublicKey(GetSSHPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetSSHPublicKeyRequestMarshaller();
            var unmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<GetSSHPublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  GetSSHPublicKeyResult from IdentityManagementService.</returns>
        public  GetSSHPublicKeyResponse EndGetSSHPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSSHPublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Retrieves information about the specified user, including the user's creation date,
        /// path, unique ID, and ARN. 
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID used to sign the request. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetUserResponse GetUser()
        {
            return GetUser(new GetUserRequest());
        }

        /// <summary>
        /// Retrieves information about the specified user, including the user's creation date,
        /// path, unique ID, and ARN. 
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID used to sign the request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            var marshaller = new GetUserRequestMarshaller();
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return Invoke<GetUserRequest,GetUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
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
            var marshaller = new GetUserRequestMarshaller();
            var unmarshaller = GetUserResponseUnmarshaller.Instance;

            return BeginInvoke<GetUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from IdentityManagementService.</returns>
        public  GetUserResponse EndGetUser(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserPolicy

        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified user.
        /// 
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a user, use <a>GetPolicy</a> to determine the policy's
        /// default version, then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request)
        {
            var marshaller = new GetUserPolicyRequestMarshaller();
            var unmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return Invoke<GetUserPolicyRequest,GetUserPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
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
            var marshaller = new GetUserPolicyRequestMarshaller();
            var unmarshaller = GetUserPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<GetUserPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPolicy.</param>
        /// 
        /// <returns>Returns a  GetUserPolicyResult from IdentityManagementService.</returns>
        public  GetUserPolicyResponse EndGetUserPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserPolicyResponse>(asyncResult);
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
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        ///  <note>To ensure the security of your AWS account, the secret access key is accessible
        /// only during key and user creation. </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
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
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        ///  <note>To ensure the security of your AWS account, the secret access key is accessible
        /// only during key and user creation. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request)
        {
            var marshaller = new ListAccessKeysRequestMarshaller();
            var unmarshaller = ListAccessKeysResponseUnmarshaller.Instance;

            return Invoke<ListAccessKeysRequest,ListAccessKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
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
            var marshaller = new ListAccessKeysRequestMarshaller();
            var unmarshaller = ListAccessKeysResponseUnmarshaller.Instance;

            return BeginInvoke<ListAccessKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessKeys.</param>
        /// 
        /// <returns>Returns a  ListAccessKeysResult from IdentityManagementService.</returns>
        public  ListAccessKeysResponse EndListAccessKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccessKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountAliases

        /// <summary>
        /// Lists the account alias associated with the account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListAccountAliasesResponse ListAccountAliases()
        {
            return ListAccountAliases(new ListAccountAliasesRequest());
        }

        /// <summary>
        /// Lists the account alias associated with the account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases service method.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request)
        {
            var marshaller = new ListAccountAliasesRequestMarshaller();
            var unmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAccountAliasesRequest,ListAccountAliasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
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
            var marshaller = new ListAccountAliasesRequestMarshaller();
            var unmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAccountAliasesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAliases.</param>
        /// 
        /// <returns>Returns a  ListAccountAliasesResult from IdentityManagementService.</returns>
        public  ListAccountAliasesResponse EndListAccountAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachedGroupPolicies

        /// <summary>
        /// Lists all managed policies that are attached to the specified group.
        /// 
        ///  
        /// <para>
        /// A group can also have inline policies embedded with it. To list the inline policies
        /// for a group, use the <a>ListGroupPolicies</a> API. For information about policies,
        /// refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// action returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListAttachedGroupPoliciesResponse ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request)
        {
            var marshaller = new ListAttachedGroupPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedGroupPoliciesRequest,ListAttachedGroupPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedGroupPolicies
        ///         operation.</returns>
        public IAsyncResult BeginListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAttachedGroupPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttachedGroupPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedGroupPolicies.</param>
        /// 
        /// <returns>Returns a  ListAttachedGroupPoliciesResult from IdentityManagementService.</returns>
        public  ListAttachedGroupPoliciesResponse EndListAttachedGroupPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachedGroupPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachedRolePolicies

        /// <summary>
        /// Lists all managed policies that are attached to the specified role. 
        /// 
        ///  
        /// <para>
        /// A role can also have inline policies embedded with it. To list the inline policies
        /// for a role, use the <a>ListRolePolicies</a> API. For information about policies, refer
        /// to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified role (or none that match the specified path prefix), the
        /// action returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListAttachedRolePoliciesResponse ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request)
        {
            var marshaller = new ListAttachedRolePoliciesRequestMarshaller();
            var unmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedRolePoliciesRequest,ListAttachedRolePoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedRolePolicies
        ///         operation.</returns>
        public IAsyncResult BeginListAttachedRolePolicies(ListAttachedRolePoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAttachedRolePoliciesRequestMarshaller();
            var unmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttachedRolePoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedRolePolicies.</param>
        /// 
        /// <returns>Returns a  ListAttachedRolePoliciesResult from IdentityManagementService.</returns>
        public  ListAttachedRolePoliciesResponse EndListAttachedRolePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachedRolePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachedUserPolicies

        /// <summary>
        /// Lists all managed policies that are attached to the specified user. 
        /// 
        ///  
        /// <para>
        /// A user can also have inline policies embedded with it. To list the inline policies
        /// for a user, use the <a>ListUserPolicies</a> API. For information about policies, refer
        /// to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// action returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListAttachedUserPoliciesResponse ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request)
        {
            var marshaller = new ListAttachedUserPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAttachedUserPoliciesRequest,ListAttachedUserPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedUserPolicies
        ///         operation.</returns>
        public IAsyncResult BeginListAttachedUserPolicies(ListAttachedUserPoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListAttachedUserPoliciesRequestMarshaller();
            var unmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAttachedUserPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedUserPolicies.</param>
        /// 
        /// <returns>Returns a  ListAttachedUserPoliciesResult from IdentityManagementService.</returns>
        public  ListAttachedUserPoliciesResponse EndListAttachedUserPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachedUserPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEntitiesForPolicy

        /// <summary>
        /// Lists all users, groups, and roles that the specified managed policy is attached to.
        /// 
        /// 
        ///  
        /// <para>
        /// You can use the optional <code>EntityFilter</code> parameter to limit the results
        /// to a particular type of entity (users, groups, or roles). For example, to list only
        /// the roles that are attached to the specified policy, set <code>EntityFilter</code>
        /// to <code>Role</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy service method.</param>
        /// 
        /// <returns>The response from the ListEntitiesForPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListEntitiesForPolicyResponse ListEntitiesForPolicy(ListEntitiesForPolicyRequest request)
        {
            var marshaller = new ListEntitiesForPolicyRequestMarshaller();
            var unmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesForPolicyRequest,ListEntitiesForPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntitiesForPolicy
        ///         operation.</returns>
        public IAsyncResult BeginListEntitiesForPolicy(ListEntitiesForPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListEntitiesForPolicyRequestMarshaller();
            var unmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<ListEntitiesForPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntitiesForPolicy.</param>
        /// 
        /// <returns>Returns a  ListEntitiesForPolicyResult from IdentityManagementService.</returns>
        public  ListEntitiesForPolicyResponse EndListEntitiesForPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntitiesForPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupPolicies

        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified group. 
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To list the managed policies
        /// that are attached to a group, use <a>ListAttachedGroupPolicies</a>. For more information
        /// about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified group, the
        /// action returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request)
        {
            var marshaller = new ListGroupPoliciesRequestMarshaller();
            var unmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListGroupPoliciesRequest,ListGroupPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
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
            var marshaller = new ListGroupPoliciesRequestMarshaller();
            var unmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupPolicies.</param>
        /// 
        /// <returns>Returns a  ListGroupPoliciesResult from IdentityManagementService.</returns>
        public  ListGroupPoliciesResponse EndListGroupPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Lists the groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListGroupsResponse ListGroups()
        {
            return ListGroups(new ListGroupsRequest());
        }

        /// <summary>
        /// Lists the groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var marshaller = new ListGroupsRequestMarshaller();
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsRequest,ListGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
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
            var marshaller = new ListGroupsRequestMarshaller();
            var unmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from IdentityManagementService.</returns>
        public  ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request)
        {
            var marshaller = new ListGroupsForUserRequestMarshaller();
            var unmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return Invoke<ListGroupsForUserRequest,ListGroupsForUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
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
            var marshaller = new ListGroupsForUserRequestMarshaller();
            var unmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;

            return BeginInvoke<ListGroupsForUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForUser.</param>
        /// 
        /// <returns>Returns a  ListGroupsForUserResult from IdentityManagementService.</returns>
        public  ListGroupsForUserResponse EndListGroupsForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsForUserResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request)
        {
            var marshaller = new ListInstanceProfilesRequestMarshaller();
            var unmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesRequest,ListInstanceProfilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
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
            var marshaller = new ListInstanceProfilesRequestMarshaller();
            var unmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke<ListInstanceProfilesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfiles.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesResult from IdentityManagementService.</returns>
        public  ListInstanceProfilesResponse EndListInstanceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceProfilesResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request)
        {
            var marshaller = new ListInstanceProfilesForRoleRequestMarshaller();
            var unmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return Invoke<ListInstanceProfilesForRoleRequest,ListInstanceProfilesForRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
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
            var marshaller = new ListInstanceProfilesForRoleRequestMarshaller();
            var unmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;

            return BeginInvoke<ListInstanceProfilesForRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfilesForRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfilesForRole.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesForRoleResult from IdentityManagementService.</returns>
        public  ListInstanceProfilesForRoleResponse EndListInstanceProfilesForRole(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceProfilesForRoleResponse>(asyncResult);
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
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
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request)
        {
            var marshaller = new ListMFADevicesRequestMarshaller();
            var unmarshaller = ListMFADevicesResponseUnmarshaller.Instance;

            return Invoke<ListMFADevicesRequest,ListMFADevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
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
            var marshaller = new ListMFADevicesRequestMarshaller();
            var unmarshaller = ListMFADevicesResponseUnmarshaller.Instance;

            return BeginInvoke<ListMFADevicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMFADevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMFADevices.</param>
        /// 
        /// <returns>Returns a  ListMFADevicesResult from IdentityManagementService.</returns>
        public  ListMFADevicesResponse EndListMFADevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMFADevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOpenIDConnectProviders

        /// <summary>
        /// Lists information about the OpenID Connect providers in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders service method.</param>
        /// 
        /// <returns>The response from the ListOpenIDConnectProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListOpenIDConnectProvidersResponse ListOpenIDConnectProviders(ListOpenIDConnectProvidersRequest request)
        {
            var marshaller = new ListOpenIDConnectProvidersRequestMarshaller();
            var unmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;

            return Invoke<ListOpenIDConnectProvidersRequest,ListOpenIDConnectProvidersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpenIDConnectProviders
        ///         operation.</returns>
        public IAsyncResult BeginListOpenIDConnectProviders(ListOpenIDConnectProvidersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListOpenIDConnectProvidersRequestMarshaller();
            var unmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;

            return BeginInvoke<ListOpenIDConnectProvidersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpenIDConnectProviders.</param>
        /// 
        /// <returns>Returns a  ListOpenIDConnectProvidersResult from IdentityManagementService.</returns>
        public  ListOpenIDConnectProvidersResponse EndListOpenIDConnectProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOpenIDConnectProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicies

        /// <summary>
        /// Lists all the managed policies that are available to your account, including your
        /// own customer managed policies and all AWS managed policies. 
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <code>OnlyAttached</code>,
        /// <code>Scope</code>, and <code>PathPrefix</code> parameters. For example, to list only
        /// the customer managed policies in your AWS account, set <code>Scope</code> to <code>Local</code>.
        /// To list only AWS managed policies, set <code>Scope</code> to <code>AWS</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListPoliciesResponse ListPolicies()
        {
            return ListPolicies(new ListPoliciesRequest());
        }

        /// <summary>
        /// Lists all the managed policies that are available to your account, including your
        /// own customer managed policies and all AWS managed policies. 
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <code>OnlyAttached</code>,
        /// <code>Scope</code>, and <code>PathPrefix</code> parameters. For example, to list only
        /// the customer managed policies in your AWS account, set <code>Scope</code> to <code>Local</code>.
        /// To list only AWS managed policies, set <code>Scope</code> to <code>AWS</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
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
        /// <returns>Returns a  ListPoliciesResult from IdentityManagementService.</returns>
        public  ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicyVersions

        /// <summary>
        /// Lists information about the versions of the specified managed policy, including the
        /// version that is set as the policy's default version. 
        /// 
        ///  
        /// <para>
        /// For more information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            var marshaller = new ListPolicyVersionsRequestMarshaller();
            var unmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyVersionsRequest,ListPolicyVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyVersions
        ///         operation.</returns>
        public IAsyncResult BeginListPolicyVersions(ListPolicyVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListPolicyVersionsRequestMarshaller();
            var unmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListPolicyVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyVersions.</param>
        /// 
        /// <returns>Returns a  ListPolicyVersionsResult from IdentityManagementService.</returns>
        public  ListPolicyVersionsResponse EndListPolicyVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPolicyVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRolePolicies

        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified role. 
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To list the managed policies
        /// that are attached to a role, use <a>ListAttachedRolePolicies</a>. For more information
        /// about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified role, the
        /// action returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request)
        {
            var marshaller = new ListRolePoliciesRequestMarshaller();
            var unmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListRolePoliciesRequest,ListRolePoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
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
            var marshaller = new ListRolePoliciesRequestMarshaller();
            var unmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListRolePoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRolePolicies.</param>
        /// 
        /// <returns>Returns a  ListRolePoliciesResult from IdentityManagementService.</returns>
        public  ListRolePoliciesResponse EndListRolePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRolePoliciesResponse>(asyncResult);
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
        /// </summary>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            var marshaller = new ListRolesRequestMarshaller();
            var unmarshaller = ListRolesResponseUnmarshaller.Instance;

            return Invoke<ListRolesRequest,ListRolesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
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
            var marshaller = new ListRolesRequestMarshaller();
            var unmarshaller = ListRolesResponseUnmarshaller.Instance;

            return BeginInvoke<ListRolesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoles.</param>
        /// 
        /// <returns>Returns a  ListRolesResult from IdentityManagementService.</returns>
        public  ListRolesResponse EndListRoles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRolesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSAMLProviders

        /// <summary>
        /// Lists the SAML providers in the account.
        /// 
        ///  <note> This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>. </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListSAMLProvidersResponse ListSAMLProviders()
        {
            return ListSAMLProviders(new ListSAMLProvidersRequest());
        }

        /// <summary>
        /// Lists the SAML providers in the account.
        /// 
        ///  <note> This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request)
        {
            var marshaller = new ListSAMLProvidersRequestMarshaller();
            var unmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;

            return Invoke<ListSAMLProvidersRequest,ListSAMLProvidersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
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
            var marshaller = new ListSAMLProvidersRequestMarshaller();
            var unmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;

            return BeginInvoke<ListSAMLProvidersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSAMLProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSAMLProviders.</param>
        /// 
        /// <returns>Returns a  ListSAMLProvidersResult from IdentityManagementService.</returns>
        public  ListSAMLProvidersResponse EndListSAMLProviders(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSAMLProvidersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServerCertificates

        /// <summary>
        /// Lists the server certificates that have the specified path prefix. If none exist,
        /// the action returns an empty list. 
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, including a list of AWS
        /// services that can use the server certificates that you manage with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
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
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, including a list of AWS
        /// services that can use the server certificates that you manage with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates service method.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request)
        {
            var marshaller = new ListServerCertificatesRequestMarshaller();
            var unmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListServerCertificatesRequest,ListServerCertificatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
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
            var marshaller = new ListServerCertificatesRequestMarshaller();
            var unmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke<ListServerCertificatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServerCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerCertificates.</param>
        /// 
        /// <returns>Returns a  ListServerCertificatesResult from IdentityManagementService.</returns>
        public  ListServerCertificatesResponse EndListServerCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServerCertificatesResponse>(asyncResult);
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
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
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
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates service method.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request)
        {
            var marshaller = new ListSigningCertificatesRequestMarshaller();
            var unmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListSigningCertificatesRequest,ListSigningCertificatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
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
            var marshaller = new ListSigningCertificatesRequestMarshaller();
            var unmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke<ListSigningCertificatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningCertificates.</param>
        /// 
        /// <returns>Returns a  ListSigningCertificatesResult from IdentityManagementService.</returns>
        public  ListSigningCertificatesResponse EndListSigningCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSigningCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSSHPublicKeys

        /// <summary>
        /// Returns information about the SSH public keys associated with the specified IAM user.
        /// If there are none, the action returns an empty list.
        /// 
        ///  
        /// <para>
        /// The SSH public keys returned by this action are used only for authenticating the IAM
        /// user to an AWS CodeCommit repository. For more information about using SSH keys to
        /// authenticate to an AWS CodeCommit repository, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListSSHPublicKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public ListSSHPublicKeysResponse ListSSHPublicKeys(ListSSHPublicKeysRequest request)
        {
            var marshaller = new ListSSHPublicKeysRequestMarshaller();
            var unmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;

            return Invoke<ListSSHPublicKeysRequest,ListSSHPublicKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSSHPublicKeys
        ///         operation.</returns>
        public IAsyncResult BeginListSSHPublicKeys(ListSSHPublicKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListSSHPublicKeysRequestMarshaller();
            var unmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;

            return BeginInvoke<ListSSHPublicKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSSHPublicKeys.</param>
        /// 
        /// <returns>Returns a  ListSSHPublicKeysResult from IdentityManagementService.</returns>
        public  ListSSHPublicKeysResponse EndListSSHPublicKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSSHPublicKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUserPolicies

        /// <summary>
        /// Lists the names of the inline policies embedded in the specified user. 
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To list the managed policies
        /// that are attached to a user, use <a>ListAttachedUserPolicies</a>. For more information
        /// about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified user, the
        /// action returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request)
        {
            var marshaller = new ListUserPoliciesRequestMarshaller();
            var unmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListUserPoliciesRequest,ListUserPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
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
            var marshaller = new ListUserPoliciesRequestMarshaller();
            var unmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<ListUserPoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPolicies.</param>
        /// 
        /// <returns>Returns a  ListUserPoliciesResult from IdentityManagementService.</returns>
        public  ListUserPoliciesResponse EndListUserPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUserPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the action returns all users in the AWS account. If there are none, the action returns
        /// an empty list. 
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListUsersResponse ListUsers()
        {
            return ListUsers(new ListUsersRequest());
        }

        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the action returns all users in the AWS account. If there are none, the action returns
        /// an empty list. 
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
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var marshaller = new ListUsersRequestMarshaller();
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersRequest,ListUsersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
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
            var marshaller = new ListUsersRequestMarshaller();
            var unmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke<ListUsersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from IdentityManagementService.</returns>
        public  ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVirtualMFADevices

        /// <summary>
        /// Lists the virtual MFA devices under the AWS account by assignment status. If you do
        /// not specify an assignment status, the action returns a list of all virtual MFA devices.
        /// Assignment status can be <code>Assigned</code>, <code>Unassigned</code>, or <code>Any</code>.
        /// 
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
        /// Lists the virtual MFA devices under the AWS account by assignment status. If you do
        /// not specify an assignment status, the action returns a list of all virtual MFA devices.
        /// Assignment status can be <code>Assigned</code>, <code>Unassigned</code>, or <code>Any</code>.
        /// 
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
            var marshaller = new ListVirtualMFADevicesRequestMarshaller();
            var unmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;

            return Invoke<ListVirtualMFADevicesRequest,ListVirtualMFADevicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
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
            var marshaller = new ListVirtualMFADevicesRequestMarshaller();
            var unmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;

            return BeginInvoke<ListVirtualMFADevicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualMFADevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualMFADevices.</param>
        /// 
        /// <returns>Returns a  ListVirtualMFADevicesResult from IdentityManagementService.</returns>
        public  ListVirtualMFADevicesResponse EndListVirtualMFADevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVirtualMFADevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGroupPolicy

        /// <summary>
        /// Adds (or updates) an inline policy document that is embedded in the specified group.
        /// 
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To attach a managed policy to
        /// a group, use <a>AttachGroupPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed in
        /// a group, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling <code>PutGroupPolicy</code>. For general information about using the
        /// Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>Using IAM</i> guide. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request)
        {
            var marshaller = new PutGroupPolicyRequestMarshaller();
            var unmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutGroupPolicyRequest,PutGroupPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
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
            var marshaller = new PutGroupPolicyRequestMarshaller();
            var unmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutGroupPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupPolicy.</param>
        /// 
        /// <returns>Returns a  PutGroupPolicyResult from IdentityManagementService.</returns>
        public  PutGroupPolicyResponse EndPutGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutGroupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRolePolicy

        /// <summary>
        /// Adds (or updates) an inline policy document that is embedded in the specified role.
        /// 
        /// 
        ///  
        /// <para>
        /// When you embed an inline policy in a role, the inline policy is used as the role's
        /// access (permissions) policy. The role's trust policy is created at the same time as
        /// the role, using <a>CreateRole</a>. You can update a role's trust policy using <a>UpdateAssumeRolePolicy</a>.
        /// For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>. 
        /// </para>
        ///  
        /// <para>
        /// A role can also have a managed policy attached to it. To attach a managed policy to
        /// a role, use <a>AttachRolePolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed with
        /// a role, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling <code>PutRolePolicy</code>. For general information about using the Query
        /// API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>Using IAM</i> guide. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// 
        /// <returns>The response from the PutRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request)
        {
            var marshaller = new PutRolePolicyRequestMarshaller();
            var unmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return Invoke<PutRolePolicyRequest,PutRolePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
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
            var marshaller = new PutRolePolicyRequestMarshaller();
            var unmarshaller = PutRolePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutRolePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRolePolicy.</param>
        /// 
        /// <returns>Returns a  PutRolePolicyResult from IdentityManagementService.</returns>
        public  PutRolePolicyResponse EndPutRolePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRolePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutUserPolicy

        /// <summary>
        /// Adds (or updates) an inline policy document that is embedded in the specified user.
        /// 
        /// 
        ///  
        /// <para>
        /// A user can also have a managed policy attached to it. To attach a managed policy to
        /// a user, use <a>AttachUserPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about limits on the number of inline policies that you can embed in
        /// a user, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  <note>Because policy documents can be large, you should use POST rather than GET
        /// when calling <code>PutUserPolicy</code>. For general information about using the Query
        /// API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>Using IAM</i> guide. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// 
        /// <returns>The response from the PutUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request)
        {
            var marshaller = new PutUserPolicyRequestMarshaller();
            var unmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return Invoke<PutUserPolicyRequest,PutUserPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
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
            var marshaller = new PutUserPolicyRequestMarshaller();
            var unmarshaller = PutUserPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutUserPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserPolicy.</param>
        /// 
        /// <returns>Returns a  PutUserPolicyResult from IdentityManagementService.</returns>
        public  PutUserPolicyResponse EndPutUserPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutUserPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveClientIDFromOpenIDConnectProvider

        /// <summary>
        /// Removes the specified client ID (also known as audience) from the list of client IDs
        /// registered for the specified IAM OpenID Connect provider.
        /// 
        ///  
        /// <para>
        /// This action is idempotent; it does not fail or return an error if you try to remove
        /// a client ID that was removed previously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the RemoveClientIDFromOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public RemoveClientIDFromOpenIDConnectProviderResponse RemoveClientIDFromOpenIDConnectProvider(RemoveClientIDFromOpenIDConnectProviderRequest request)
        {
            var marshaller = new RemoveClientIDFromOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;

            return Invoke<RemoveClientIDFromOpenIDConnectProviderRequest,RemoveClientIDFromOpenIDConnectProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveClientIDFromOpenIDConnectProvider
        ///         operation.</returns>
        public IAsyncResult BeginRemoveClientIDFromOpenIDConnectProvider(RemoveClientIDFromOpenIDConnectProviderRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveClientIDFromOpenIDConnectProviderRequestMarshaller();
            var unmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveClientIDFromOpenIDConnectProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveClientIDFromOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  RemoveClientIDFromOpenIDConnectProviderResult from IdentityManagementService.</returns>
        public  RemoveClientIDFromOpenIDConnectProviderResponse EndRemoveClientIDFromOpenIDConnectProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveClientIDFromOpenIDConnectProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveRoleFromInstanceProfile

        /// <summary>
        /// Removes the specified role from the specified instance profile.
        /// 
        ///  <important> Make sure you do not have any Amazon EC2 instances running with the role
        /// you are about to remove from the instance profile. Removing a role from an instance
        /// profile that is associated with a running instance will break any applications running
        /// on the instance. </important> 
        /// <para>
        ///  For more information about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>. For more information about instance profiles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request)
        {
            var marshaller = new RemoveRoleFromInstanceProfileRequestMarshaller();
            var unmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromInstanceProfileRequest,RemoveRoleFromInstanceProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
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
            var marshaller = new RemoveRoleFromInstanceProfileRequestMarshaller();
            var unmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveRoleFromInstanceProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRoleFromInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromInstanceProfile.</param>
        /// 
        /// <returns>Returns a  RemoveRoleFromInstanceProfileResult from IdentityManagementService.</returns>
        public  RemoveRoleFromInstanceProfileResponse EndRemoveRoleFromInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveRoleFromInstanceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveUserFromGroup

        /// <summary>
        /// Removes the specified user from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveUserFromGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            var marshaller = new RemoveUserFromGroupRequestMarshaller();
            var unmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return Invoke<RemoveUserFromGroupRequest,RemoveUserFromGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
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
            var marshaller = new RemoveUserFromGroupRequestMarshaller();
            var unmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveUserFromGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveUserFromGroup.</param>
        /// 
        /// <returns>Returns a  RemoveUserFromGroupResult from IdentityManagementService.</returns>
        public  RemoveUserFromGroupResponse EndRemoveUserFromGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveUserFromGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ResyncMFADevice

        /// <summary>
        /// Synchronizes the specified MFA device with AWS servers.
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, go to <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a Virtual MFA Device</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice service method.</param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request)
        {
            var marshaller = new ResyncMFADeviceRequestMarshaller();
            var unmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return Invoke<ResyncMFADeviceRequest,ResyncMFADeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
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
            var marshaller = new ResyncMFADeviceRequestMarshaller();
            var unmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;

            return BeginInvoke<ResyncMFADeviceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResyncMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResyncMFADevice.</param>
        /// 
        /// <returns>Returns a  ResyncMFADeviceResult from IdentityManagementService.</returns>
        public  ResyncMFADeviceResponse EndResyncMFADevice(IAsyncResult asyncResult)
        {
            return EndInvoke<ResyncMFADeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  SetDefaultPolicyVersion

        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. 
        /// 
        ///  
        /// <para>
        /// This action affects all users, groups, and roles that the policy is attached to. To
        /// list the users, groups, and roles that the policy is attached to, use the <a>ListEntitiesForPolicy</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// For information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request)
        {
            var marshaller = new SetDefaultPolicyVersionRequestMarshaller();
            var unmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<SetDefaultPolicyVersionRequest,SetDefaultPolicyVersionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDefaultPolicyVersion
        ///         operation.</returns>
        public IAsyncResult BeginSetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetDefaultPolicyVersionRequestMarshaller();
            var unmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke<SetDefaultPolicyVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDefaultPolicyVersion.</param>
        /// 
        /// <returns>Returns a  SetDefaultPolicyVersionResult from IdentityManagementService.</returns>
        public  SetDefaultPolicyVersionResponse EndSetDefaultPolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<SetDefaultPolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  SimulateCustomPolicy

        /// <summary>
        /// Simulate how a set of IAM policies and optionally a resource-based policy works with
        /// a list of API actions and AWS resources to determine the policies' effective permissions.
        /// The policies are provided as strings.
        /// 
        ///  
        /// <para>
        /// The simulation does not perform the API actions; it only checks the authorization
        /// to determine if the simulated policies allow or deny the actions.
        /// </para>
        ///  
        /// <para>
        /// If you want to simulate existing policies attached to an IAM user, group, or role,
        /// use <a>SimulatePrincipalPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. You can use the <code>Condition</code>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a>GetContextKeysForCustomPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use <code>MaxItems</code> and <code>Marker</code> parameters
        /// to paginate the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy service method.</param>
        /// 
        /// <returns>The response from the SimulateCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detail message indicates the source of the failure.
        /// </exception>
        public SimulateCustomPolicyResponse SimulateCustomPolicy(SimulateCustomPolicyRequest request)
        {
            var marshaller = new SimulateCustomPolicyRequestMarshaller();
            var unmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulateCustomPolicyRequest,SimulateCustomPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimulateCustomPolicy
        ///         operation.</returns>
        public IAsyncResult BeginSimulateCustomPolicy(SimulateCustomPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SimulateCustomPolicyRequestMarshaller();
            var unmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<SimulateCustomPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimulateCustomPolicy.</param>
        /// 
        /// <returns>Returns a  SimulateCustomPolicyResult from IdentityManagementService.</returns>
        public  SimulateCustomPolicyResponse EndSimulateCustomPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<SimulateCustomPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  SimulatePrincipalPolicy

        /// <summary>
        /// Simulate how a set of IAM policies attached to an IAM entity works with a list of
        /// API actions and AWS resources to determine the policies' effective permissions. The
        /// entity can be an IAM user, group, or role. If you specify a user, then the simulation
        /// also includes all of the policies that are attached to groups that the user belongs
        /// to .
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies specified as
        /// strings to include in the simulation. If you want to simulate only policies specified
        /// as strings, use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// You can also optionally include one resource-based policy to be evaluated with each
        /// of the resources included in the simulation.
        /// </para>
        ///  
        /// <para>
        /// The simulation does not perform the API actions, it only checks the authorization
        /// to determine if the simulated policies allow or deny the actions.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. You can use the <code>Condition</code>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use the <code>MaxItems</code> and <code>Marker</code>
        /// parameters to paginate the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the SimulatePrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detail message indicates the source of the failure.
        /// </exception>
        public SimulatePrincipalPolicyResponse SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request)
        {
            var marshaller = new SimulatePrincipalPolicyRequestMarshaller();
            var unmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;

            return Invoke<SimulatePrincipalPolicyRequest,SimulatePrincipalPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimulatePrincipalPolicy
        ///         operation.</returns>
        public IAsyncResult BeginSimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SimulatePrincipalPolicyRequestMarshaller();
            var unmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<SimulatePrincipalPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimulatePrincipalPolicy.</param>
        /// 
        /// <returns>Returns a  SimulatePrincipalPolicyResult from IdentityManagementService.</returns>
        public  SimulatePrincipalPolicyResponse EndSimulatePrincipalPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<SimulatePrincipalPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccessKey

        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This action can be used to disable a user's key as part of a key rotation work flow.
        /// 
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the UserName is determined implicitly
        /// based on the AWS access key ID used to sign the request. Because this action works
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        ///  
        /// <para>
        /// For information about rotating keys, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html">Managing
        /// Keys and Certificates</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request)
        {
            var marshaller = new UpdateAccessKeyRequestMarshaller();
            var unmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessKeyRequest,UpdateAccessKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
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
            var marshaller = new UpdateAccessKeyRequestMarshaller();
            var unmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAccessKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessKey.</param>
        /// 
        /// <returns>Returns a  UpdateAccessKeyResult from IdentityManagementService.</returns>
        public  UpdateAccessKeyResponse EndUpdateAccessKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccessKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountPasswordPolicy

        /// <summary>
        /// Updates the password policy settings for the AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action does not support partial updates. No parameters are required, but if you
        /// do not specify a parameter, that parameter's value reverts to its default value. See
        /// the <b>Request Parameters</b> section for each parameter's default value. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  For more information about using a password policy, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy()
        {
            return UpdateAccountPasswordPolicy(new UpdateAccountPasswordPolicyRequest());
        }

        /// <summary>
        /// Updates the password policy settings for the AWS account.
        /// 
        ///  <note> 
        /// <para>
        /// This action does not support partial updates. No parameters are required, but if you
        /// do not specify a parameter, that parameter's value reverts to its default value. See
        /// the <b>Request Parameters</b> section for each parameter's default value. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  For more information about using a password policy, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request)
        {
            var marshaller = new UpdateAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountPasswordPolicyRequest,UpdateAccountPasswordPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
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
            var marshaller = new UpdateAccountPasswordPolicyRequestMarshaller();
            var unmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAccountPasswordPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAccountPasswordPolicyResult from IdentityManagementService.</returns>
        public  UpdateAccountPasswordPolicyResponse EndUpdateAccountPasswordPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountPasswordPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssumeRolePolicy

        /// <summary>
        /// Updates the policy that grants an entity permission to assume a role. For more information
        /// about roles, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// Roles to Delegate Permissions and Federate Identities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAssumeRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request)
        {
            var marshaller = new UpdateAssumeRolePolicyRequestMarshaller();
            var unmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAssumeRolePolicyRequest,UpdateAssumeRolePolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
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
            var marshaller = new UpdateAssumeRolePolicyRequestMarshaller();
            var unmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAssumeRolePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssumeRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssumeRolePolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAssumeRolePolicyResult from IdentityManagementService.</returns>
        public  UpdateAssumeRolePolicyResponse EndUpdateAssumeRolePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssumeRolePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Updates the name and/or the path of the specified group.
        /// 
        ///  <important> You should understand the implications of changing a group's path or
        /// name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
        /// Users and Groups</a> in the <i>IAM User Guide</i>. </important> <note>To change a
        /// group name the requester must have appropriate permissions on both the source object
        /// and the target object. For example, to change Managers to MGRs, the entity making
        /// the request must have permission on Managers and MGRs, or must have permission on
        /// all (*). For more information about permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html"
        /// target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var marshaller = new UpdateGroupRequestMarshaller();
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupRequest,UpdateGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
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
            var marshaller = new UpdateGroupRequestMarshaller();
            var unmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from IdentityManagementService.</returns>
        public  UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLoginProfile

        /// <summary>
        /// Changes the password for the specified user.
        /// 
        ///  
        /// <para>
        /// Users can change their own passwords by calling <a>ChangePassword</a>. For more information
        /// about modifying passwords, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// Passwords</a> in the <i>IAM User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request)
        {
            var marshaller = new UpdateLoginProfileRequestMarshaller();
            var unmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateLoginProfileRequest,UpdateLoginProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
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
            var marshaller = new UpdateLoginProfileRequestMarshaller();
            var unmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateLoginProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoginProfile.</param>
        /// 
        /// <returns>Returns a  UpdateLoginProfileResult from IdentityManagementService.</returns>
        public  UpdateLoginProfileResponse EndUpdateLoginProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLoginProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateOpenIDConnectProviderThumbprint

        /// <summary>
        /// Replaces the existing list of server certificate thumbprints with a new list. 
        /// 
        ///  
        /// <para>
        /// The list that you pass with this action completely replaces the existing list of thumbprints.
        /// (The lists are not merged.)
        /// </para>
        ///  
        /// <para>
        /// Typically, you need to update a thumbprint only when the identity provider's certificate
        /// changes, which occurs rarely. However, if the provider's certificate <i>does</i> change,
        /// any attempt to assume an IAM role that specifies the OIDC provider as a principal
        /// will fail until the certificate thumbprint is updated.
        /// </para>
        ///  <note>Because trust for the OpenID Connect provider is ultimately derived from the
        /// provider's certificate and is validated by the thumbprint, it is a best practice to
        /// limit access to the <code>UpdateOpenIDConnectProviderThumbprint</code> action to highly-privileged
        /// users. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint service method.</param>
        /// 
        /// <returns>The response from the UpdateOpenIDConnectProviderThumbprint service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateOpenIDConnectProviderThumbprintResponse UpdateOpenIDConnectProviderThumbprint(UpdateOpenIDConnectProviderThumbprintRequest request)
        {
            var marshaller = new UpdateOpenIDConnectProviderThumbprintRequestMarshaller();
            var unmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;

            return Invoke<UpdateOpenIDConnectProviderThumbprintRequest,UpdateOpenIDConnectProviderThumbprintResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOpenIDConnectProviderThumbprint
        ///         operation.</returns>
        public IAsyncResult BeginUpdateOpenIDConnectProviderThumbprint(UpdateOpenIDConnectProviderThumbprintRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateOpenIDConnectProviderThumbprintRequestMarshaller();
            var unmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateOpenIDConnectProviderThumbprintRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOpenIDConnectProviderThumbprint.</param>
        /// 
        /// <returns>Returns a  UpdateOpenIDConnectProviderThumbprintResult from IdentityManagementService.</returns>
        public  UpdateOpenIDConnectProviderThumbprintResponse EndUpdateOpenIDConnectProviderThumbprint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateOpenIDConnectProviderThumbprintResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSAMLProvider

        /// <summary>
        /// Updates the metadata document for an existing SAML provider.
        /// 
        ///  <note>This operation requires <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request)
        {
            var marshaller = new UpdateSAMLProviderRequestMarshaller();
            var unmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return Invoke<UpdateSAMLProviderRequest,UpdateSAMLProviderResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
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
            var marshaller = new UpdateSAMLProviderRequestMarshaller();
            var unmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSAMLProviderRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  UpdateSAMLProviderResult from IdentityManagementService.</returns>
        public  UpdateSAMLProviderResponse EndUpdateSAMLProvider(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSAMLProviderResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServerCertificate

        /// <summary>
        /// Updates the name and/or the path of the specified server certificate.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, including a list of AWS
        /// services that can use the server certificates that you manage with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important>You should understand the implications of changing a server certificate's
        /// path or name. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs_manage.html#RenamingServerCerts">Renaming
        /// a Server Certificate</a> in the <i>IAM User Guide</i>.</important> <note>To change
        /// a server certificate name the requester must have appropriate permissions on both
        /// the source object and the target object. For example, to change the name from ProductionCert
        /// to ProdCert, the entity making the request must have permission on ProductionCert
        /// and ProdCert, or must have permission on all (*). For more information about permissions,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access Management</a>
        /// in the <i>IAM User Guide</i>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request)
        {
            var marshaller = new UpdateServerCertificateRequestMarshaller();
            var unmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateServerCertificateRequest,UpdateServerCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
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
            var marshaller = new UpdateServerCertificateRequestMarshaller();
            var unmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateServerCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateServerCertificateResult from IdentityManagementService.</returns>
        public  UpdateServerCertificateResponse EndUpdateServerCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServerCertificateResponse>(asyncResult);
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
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request)
        {
            var marshaller = new UpdateSigningCertificateRequestMarshaller();
            var unmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateSigningCertificateRequest,UpdateSigningCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
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
            var marshaller = new UpdateSigningCertificateRequestMarshaller();
            var unmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSigningCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateSigningCertificateResult from IdentityManagementService.</returns>
        public  UpdateSigningCertificateResponse EndUpdateSigningCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSigningCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSSHPublicKey

        /// <summary>
        /// Sets the status of the specified SSH public key to active or inactive. SSH public
        /// keys that are inactive cannot be used for authentication. This action can be used
        /// to disable a user's SSH public key as part of a key rotation work flow. 
        /// 
        ///  
        /// <para>
        /// The SSH public key affected by this action is used only for authenticating the associated
        /// IAM user to an AWS CodeCommit repository. For more information about using SSH keys
        /// to authenticate to an AWS CodeCommit repository, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the UpdateSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        public UpdateSSHPublicKeyResponse UpdateSSHPublicKey(UpdateSSHPublicKeyRequest request)
        {
            var marshaller = new UpdateSSHPublicKeyRequestMarshaller();
            var unmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateSSHPublicKeyRequest,UpdateSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSSHPublicKey
        ///         operation.</returns>
        public IAsyncResult BeginUpdateSSHPublicKey(UpdateSSHPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateSSHPublicKeyRequestMarshaller();
            var unmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateSSHPublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  UpdateSSHPublicKeyResult from IdentityManagementService.</returns>
        public  UpdateSSHPublicKeyResponse EndUpdateSSHPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSSHPublicKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Updates the name and/or the path of the specified user.
        /// 
        ///  <important> You should understand the implications of changing a user's path or name.
        /// For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_renaming">Renaming
        /// an IAM User</a> and <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_groups_manage_rename.html">Renaming
        /// an IAM Group</a> in the <i>IAM User Guide</i>. </important> <note> To change a user
        /// name the requester must have appropriate permissions on both the source object and
        /// the target object. For example, to change Bob to Robert, the entity making the request
        /// must have permission on Bob and Robert, or must have permission on all (*). For more
        /// information about permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html"
        /// target="blank">Permissions and Policies</a>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var marshaller = new UpdateUserRequestMarshaller();
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserRequest,UpdateUserResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
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
            var marshaller = new UpdateUserRequestMarshaller();
            var unmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUserRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from IdentityManagementService.</returns>
        public  UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
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
        /// For more information about working with server certificates, including a list of AWS
        /// services that can use the server certificates that you manage with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about the number of server certificates you can upload, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-limits.html">Limitations
        /// on IAM Entities and Objects</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  <note>Because the body of the public key certificate, private key, and the certificate
        /// chain can be large, you should use POST rather than GET when calling <code>UploadServerCertificate</code>.
        /// For information about setting up signatures and authorization through the API, go
        /// to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
        /// about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/programming.html">Calling
        /// the API by Making HTTP Query Requests</a> in the <i>IAM User Guide</i>. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.KeyPairMismatchException">
        /// The request was rejected because the public key certificate and the private key do
        /// not match.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            var marshaller = new UploadServerCertificateRequestMarshaller();
            var unmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadServerCertificateRequest,UploadServerCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
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
            var marshaller = new UploadServerCertificateRequestMarshaller();
            var unmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<UploadServerCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UploadServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadServerCertificate.</param>
        /// 
        /// <returns>Returns a  UploadServerCertificateResult from IdentityManagementService.</returns>
        public  UploadServerCertificateResponse EndUploadServerCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<UploadServerCertificateResponse>(asyncResult);
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
        /// for access keys under the AWS account, you can use this action to manage root credentials
        /// even if the AWS account has no associated users. 
        /// </para>
        ///  <note>Because the body of a X.509 certificate can be large, you should use POST rather
        /// than GET when calling <code>UploadSigningCertificate</code>. For information about
        /// setting up signatures and authorization through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
        /// about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// Query Requests</a> in the <i>Using IAM</i>guide. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateCertificateException">
        /// The request was rejected because the same certificate is associated with an IAM user
        /// in the account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidCertificateException">
        /// The request was rejected because the certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        public UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request)
        {
            var marshaller = new UploadSigningCertificateRequestMarshaller();
            var unmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return Invoke<UploadSigningCertificateRequest,UploadSigningCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
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
            var marshaller = new UploadSigningCertificateRequestMarshaller();
            var unmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<UploadSigningCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UploadSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UploadSigningCertificateResult from IdentityManagementService.</returns>
        public  UploadSigningCertificateResponse EndUploadSigningCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<UploadSigningCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  UploadSSHPublicKey

        /// <summary>
        /// Uploads an SSH public key and associates it with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// The SSH public key uploaded by this action can be used only for authenticating the
        /// associated IAM user to an AWS CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an AWS CodeCommit repository, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the UploadSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateSSHPublicKeyException">
        /// The request was rejected because the SSH public key is already associated with the
        /// specified IAM user.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidPublicKeyException">
        /// The request was rejected because the public key is malformed or otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced an entity that does not exist. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
        public UploadSSHPublicKeyResponse UploadSSHPublicKey(UploadSSHPublicKeyRequest request)
        {
            var marshaller = new UploadSSHPublicKeyRequestMarshaller();
            var unmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;

            return Invoke<UploadSSHPublicKeyRequest,UploadSSHPublicKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadSSHPublicKey
        ///         operation.</returns>
        public IAsyncResult BeginUploadSSHPublicKey(UploadSSHPublicKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UploadSSHPublicKeyRequestMarshaller();
            var unmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;

            return BeginInvoke<UploadSSHPublicKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  UploadSSHPublicKeyResult from IdentityManagementService.</returns>
        public  UploadSSHPublicKeyResponse EndUploadSSHPublicKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UploadSSHPublicKeyResponse>(asyncResult);
        }

        #endregion
        
    }
}